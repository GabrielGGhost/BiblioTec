using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelos;

namespace DAL
{
    public class EmprestimosDAL
    {
        SqlConnection cn = new SqlConnection(Dados.StringDeConexao);
        public object ListarLeitores(bool aluno)
        {
            try
            {
                cn.Open();

                SqlDataAdapter listarLeitores;

                if(aluno)
                {
                    listarLeitores = new SqlDataAdapter("SELECT * FROM ALUNOS", cn);
                } else
                {
                    listarLeitores = new SqlDataAdapter("SELECT * FROM Funcionarios", cn);
                }

                DataTable dt = new DataTable();
                listarLeitores.Fill(dt);

                return dt;
            }
            catch (Exception ex) { throw new Exception(ex.Message);}
            finally { cn.Close(); }
        }

        public void RealizarEmprestimo(EmprestimoInformation emprestimo, bool aluno, bool ficha, ref string erro)
        {
            SqlTransaction t = null;
            try
            {
                cn.Open();

                SqlCommand realizarEmprestimo;

                SqlCommand verificarDia = new SqlCommand("Emprestimo_DiaLeitorEspecial", cn);
                verificarDia.CommandType = CommandType.StoredProcedure;

                verificarDia.Parameters.AddWithValue("@devolucao", emprestimo.Devolucao);

                bool acesso = Convert.ToBoolean(verificarDia.ExecuteScalar());

                if(!acesso)
                {
                    erro = "Dia Não Letivo!";
                    throw new Exception("O dia escolhido não é um dia letivo!");
                }

                t = cn.BeginTransaction(IsolationLevel.Serializable);
                if (aluno)
                {
                        SqlCommand permitirEmprestimo = new SqlCommand(@"SELECT COUNT(*)
                                                                        FROM MULTAS
                                                                            WHERE ID_Aluno = " + emprestimo.IdAluno, cn, t);

                        int resultado = Convert.ToInt32(permitirEmprestimo.ExecuteScalar());

                        if (resultado > 0)
                        {
                            erro = "Dívida Pendente!";
                            throw new Exception("O aluno possui dívidas pendentes e não pode emprestar livros!");
                        }

                    realizarEmprestimo = new SqlCommand("Emprestimos_RealziarEmprestimoAluno", cn, t);
                    realizarEmprestimo.CommandType = CommandType.StoredProcedure;

                    realizarEmprestimo.Parameters.AddWithValue("@idAluno", emprestimo.IdAluno);
                    realizarEmprestimo.Parameters.AddWithValue("@RM", emprestimo.Rm);
                    realizarEmprestimo.Parameters.AddWithValue("@NomeAluno", emprestimo.NomeAluno);
                    realizarEmprestimo.Parameters.AddWithValue("@Curso", emprestimo.Curso);
                    realizarEmprestimo.Parameters.AddWithValue("@Modulo", emprestimo.Modulo);

                } else
                {
                    realizarEmprestimo = new SqlCommand("Emprestimos_RealziarEmprestimoFuncionario", cn, t);
                    realizarEmprestimo.CommandType = CommandType.StoredProcedure;

                    realizarEmprestimo.Parameters.AddWithValue("@idFuncionario", emprestimo.IdFuncionario);
                    realizarEmprestimo.Parameters.AddWithValue("@Nome", emprestimo.NomeProfessor);
                    realizarEmprestimo.Parameters.AddWithValue("@Funcao", emprestimo.Funcao);
                }

                realizarEmprestimo.Parameters.AddWithValue("@IdLivro", emprestimo.IdLivro);
                realizarEmprestimo.Parameters.AddWithValue("@nomeLivro", emprestimo.NomeLivro);
                realizarEmprestimo.Parameters.AddWithValue("@Localizacao", emprestimo.Localizacao);
                realizarEmprestimo.Parameters.AddWithValue("@Ano", emprestimo.Ano);
                realizarEmprestimo.Parameters.AddWithValue("@Autor", emprestimo.Autor);
                realizarEmprestimo.Parameters.AddWithValue("@Tombo", emprestimo.Tombo);
                realizarEmprestimo.Parameters.AddWithValue("@Retirada", emprestimo.Retirada);
                realizarEmprestimo.Parameters.AddWithValue("@Devolucao", emprestimo.Devolucao);
                realizarEmprestimo.ExecuteNonQuery();

                if (ficha)
                {
                    SqlCommand gerarFicha = new SqlCommand(@"FeichaCatalografica_GerarAnotacao", cn, t);
                    gerarFicha.CommandType = CommandType.StoredProcedure;

                    gerarFicha.Parameters.AddWithValue("@retirada", emprestimo.Retirada);
                    gerarFicha.Parameters.AddWithValue("@idLivro", emprestimo.IdLivro);
                    gerarFicha.Parameters.AddWithValue("@autor", emprestimo.Autor);
                    gerarFicha.Parameters.AddWithValue("@tombo", emprestimo.Tombo);

                    if (emprestimo.NomeAluno == null || emprestimo.NomeAluno == "") gerarFicha.Parameters.AddWithValue("@aluno", "");
                    else gerarFicha.Parameters.AddWithValue("@aluno", emprestimo.NomeAluno);

                    gerarFicha.Parameters.AddWithValue("@serie", emprestimo.Serie);
                    gerarFicha.Parameters.AddWithValue("@Devolucao", emprestimo.Devolucao);

                    if (emprestimo.NomeProfessor == "" || emprestimo.NomeProfessor == null) gerarFicha.Parameters.AddWithValue("@Professor", "");
                    else gerarFicha.Parameters.AddWithValue("@Professor", emprestimo.NomeProfessor);

                    if (emprestimo.Funcao == "" || emprestimo.Funcao == null) gerarFicha.Parameters.AddWithValue("@Funcao", "");
                    else gerarFicha.Parameters.AddWithValue("@Funcao", emprestimo.Funcao);

                    gerarFicha.Parameters.AddWithValue("@modoAluno", aluno);


                    gerarFicha.ExecuteNonQuery();
                }
                t.Commit();
            }
            catch (SqlException ex)
            {
                t.Rollback();
                throw new Exception(ex.Message);
            }
            finally { cn.Close(); }
        }

        public bool VerificarDisponibilidade(string idLivro)
        {
            try
            {
                cn.Open();

                SqlCommand emprestado = new SqlCommand("SELECT emprestado FROM livros WHERE id = @ID", cn);

                emprestado.Parameters.AddWithValue("@id", idLivro);

                bool resultado = Convert.ToBoolean(emprestado.ExecuteScalar());

                return resultado;
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
            finally { cn.Close(); }
        }

        public void ExcluirEmprestimo(EmprestimoInformation emprestimo, bool aluno)
        {
            SqlTransaction t = null;
            try
            {
                cn.Open();

                SqlCommand realizarEmprestimo;

                t = cn.BeginTransaction(IsolationLevel.Serializable);

                realizarEmprestimo = new SqlCommand("Emprestimos_DeletarEmprestimo", cn, t);
                realizarEmprestimo.CommandType = CommandType.StoredProcedure;

                realizarEmprestimo.Parameters.AddWithValue("@Tombo", emprestimo.Tombo);
                realizarEmprestimo.Parameters.AddWithValue("@retirada", emprestimo.Retirada);
                realizarEmprestimo.Parameters.AddWithValue("@devolucao", emprestimo.Devolucao);
                realizarEmprestimo.Parameters.AddWithValue("@aluno", aluno);

                if (aluno)
                {
                    realizarEmprestimo.Parameters.AddWithValue("@idLeitor", emprestimo.IdAluno);
                    realizarEmprestimo.Parameters.AddWithValue("@serie", emprestimo.Rm + " - " + emprestimo.Modulo + " - " + emprestimo.Curso);
                }
                else
                {
                    realizarEmprestimo.Parameters.AddWithValue("@idLeitor", emprestimo.IdFuncionario);
                    realizarEmprestimo.Parameters.AddWithValue("@serie", emprestimo.Funcao);
                }

                realizarEmprestimo.ExecuteNonQuery();

                t.Commit();
            }
            catch (SqlException ex)
            {
                t.Rollback();
                throw new Exception(ex.Message);
            }
            finally { cn.Close(); }
        }

        public decimal BuscarMulta(string id)
        {
            try
            {
                cn.Open();

                SqlCommand emprestimos = new SqlCommand("SELECT multa FROM livros WHERE id = @ID", cn);

                emprestimos.Parameters.AddWithValue("@id", id);

                decimal resultado = Convert.ToDecimal(emprestimos.ExecuteScalar());

                return resultado;
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
            finally { cn.Close(); }
        }

        public string CarregarEmprestadosFunc(string id)
        {
            try
            {
                cn.Open();

                SqlCommand emprestimos = new SqlCommand("SELECT COUNT(ID_LIVRO) FROM Emprestimos_Funcionarios WHERE ID_FUNCIONARIO = @ID", cn);

                emprestimos.Parameters.AddWithValue("@id", id);

                string resultado = Convert.ToString(emprestimos.ExecuteScalar());

                return resultado;
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
            finally { cn.Close(); }
        }

        public bool BuscarPermissaoMaxLivrosFuncionarios()
        {
            try
            {
                cn.Open();

                SqlCommand maxLivros = new SqlCommand("SELECT maxLivrosFuncionariosAtivo FROM CONFIGURACOES", cn);

                bool resultado = Convert.ToBoolean(maxLivros.ExecuteScalar());

                return resultado;
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
            finally { cn.Close(); }
        }

        public string BuscarMaxLivrosFuncionario()
        {
            try
            {
                cn.Open();

                SqlCommand maxLivros = new SqlCommand("SELECT maxLivrosFuncionariosQtd FROM CONFIGURACOES", cn);

                string resultado = Convert.ToString(maxLivros.ExecuteScalar());

                return resultado;
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
            finally { cn.Close(); }
        }

        public bool BuscarPermissaoMaxLivros()
        {
            try
            {
                cn.Open();

                SqlCommand maxLivros = new SqlCommand("SELECT maxLivroAtivo FROM CONFIGURACOES", cn);

                bool resultado = Convert.ToBoolean(maxLivros.ExecuteScalar());

                return resultado;
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
            finally { cn.Close(); }
        }

        public string BuscarMaxLivros()
        {
            try
            {
                cn.Open();

                SqlCommand maxLivros = new SqlCommand("SELECT maxLivroQtd FROM CONFIGURACOES", cn);

                string resultado = Convert.ToString(maxLivros.ExecuteScalar());

                return resultado;
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
            finally { cn.Close(); }
        }

        public string CarregarEmprestados(string id)
        {
            try
            {
                cn.Open();

                SqlCommand contarEmprestimos = new SqlCommand("SELECT COUNT(*) FROM EMPRESTIMOS_ALUNOS WHERE ID_ALUNO = @id_aluno", cn);

                contarEmprestimos.Parameters.AddWithValue("@id_aluno", id);
                string resultado = Convert.ToString(contarEmprestimos.ExecuteScalar());

                return resultado;
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
            finally { cn.Close(); }
        }

        public bool VerificarExistencia(bool aluno, string str, ref string erro)
        {
            try
            {
                cn.Open();

                SqlCommand verificarExistencia = new SqlCommand("Emprestimo_VerificarExistencia", cn);
                verificarExistencia.CommandType = CommandType.StoredProcedure;

                verificarExistencia.Parameters.AddWithValue("@aluno", aluno);
                verificarExistencia.Parameters.AddWithValue("@str", str);

                bool resultado = Convert.ToBoolean(verificarExistencia.ExecuteScalar());

                return resultado;
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
            finally { cn.Close(); }
        }

        public object ListarFuncionariosDevedores()
        {
            try
            {
                cn.Open();

                SqlDataAdapter alunosDevedores = new SqlDataAdapter(@"SELECT DISTINCT f.Nome
	                                                                    FROM Emprestimos_Funcionarios as ea
		                                                                    INNER JOIN Funcionarios as f
			                                                                    ON f.Id_Funcionario = ea.Id_Funcionario", cn);

                DataTable dt = new DataTable();
                alunosDevedores.Fill(dt);
                return dt;
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
            finally { cn.Close(); }
        }

        public void AtualizarMulta(decimal valor, string idLivro)
        {
            try
            {
                cn.Open();

                SqlCommand atualizarMulta = new SqlCommand("Emprestimo_AtualizarMulta", cn);
                atualizarMulta.CommandType = CommandType.StoredProcedure;

                atualizarMulta.Parameters.AddWithValue("@valor", valor);
                atualizarMulta.Parameters.AddWithValue("@idLivro", int.Parse(idLivro));

                atualizarMulta.ExecuteNonQuery();
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
            finally { cn.Close(); }
        }

        public void RenovarLivro(int id_leitor, int id_livro, bool aluno, string retirada, string devolucao)
        {
            SqlTransaction t = null;
            try
            {
                cn.Open();

                t = cn.BeginTransaction(IsolationLevel.Serializable);

                SqlCommand verificarDivida = new SqlCommand(@"select Multa
                                                                    from Emprestimos_Alunos
                                                                            where Id_Livro = " + id_livro + @"
                                                                                AND id_aluno = " + id_leitor, cn, t);

                decimal resultado = Convert.ToDecimal(verificarDivida.ExecuteScalar());

                if(resultado != 0)
                {
                    throw new Exception("O aluno não pode renovar este livro porque há uma multa pendente relacionada à ele!");
                }

                SqlCommand devolverLivro = new SqlCommand("Emprestimo_RenovarLivro", cn, t);
                devolverLivro.CommandType = CommandType.StoredProcedure;

                devolverLivro.Parameters.AddWithValue("@id_leitor", id_leitor);
                devolverLivro.Parameters.AddWithValue("@id_livro", id_livro);
                devolverLivro.Parameters.AddWithValue("@aluno", aluno);
                devolverLivro.Parameters.AddWithValue("@retirada", retirada);
                devolverLivro.Parameters.AddWithValue("@devolucao", devolucao);


                SqlCommand gerarFicha = new SqlCommand(@"FeichaCatalografica_GerarAnotacaoRenovacao", cn, t);
                gerarFicha.CommandType = CommandType.StoredProcedure;

                gerarFicha.Parameters.AddWithValue("@idLeitor", id_leitor);
                gerarFicha.Parameters.AddWithValue("@idLivro", id_livro);
                gerarFicha.Parameters.AddWithValue("@Aluno", aluno);
                gerarFicha.Parameters.AddWithValue("@retirada", retirada);
                gerarFicha.Parameters.AddWithValue("@devolucao", devolucao);

                gerarFicha.ExecuteNonQuery();

                devolverLivro.ExecuteNonQuery();

                t.Commit();
            }
            catch (Exception ex)
            {
                t.Rollback();
                throw new Exception(ex.Message);
            }
            finally { cn.Close(); }
        }

        public void DevolverLivro(int id_leitor, int id_livro, bool aluno, ref string erro)
        {
            try
            {
                cn.Open();


                SqlCommand devolverLivro = new SqlCommand("Emprestimo_DevolverLivro", cn);
                devolverLivro.CommandType = CommandType.StoredProcedure;

                devolverLivro.Parameters.AddWithValue("@id_leitor", id_leitor);
                devolverLivro.Parameters.AddWithValue("@id_livro", id_livro);
                devolverLivro.Parameters.AddWithValue("@aluno", aluno);

                devolverLivro.ExecuteNonQuery();
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
            finally { cn.Close(); }
        }

        public object[] BuscarDadosEmprestados(string id_Livro, bool aluno)
        {
            try
            {
                cn.Open();


                SqlCommand verificarExistencia = new SqlCommand(@"select count(*)
                                                                    from Emprestimos_Alunos
                                                                        WHERE Id_Livro = " + id_Livro, cn);

                int resultado = Convert.ToInt32(verificarExistencia.ExecuteScalar());

                if (resultado > 0)
                {
                    object[] dados = new object[7];

                    SqlCommand alunosDevedores = new SqlCommand(@"select EA.Id_Aluno,
	                                                                    EA.RM,
	                                                                    A.NOME,
	                                                                    EA.Curso,
	                                                                    EA.Modulo,
	                                                                    EA.Data_Emprestimo,
	                                                                    EA.Data_Vencimento
		                                                                    from Emprestimos_Alunos AS EA
			                                                                    INNER JOIN Alunos AS A
				                                                                    ON A.Id = EA.Id_Aluno
					                                                                    WHERE EA.Id_Livro = " + id_Livro, cn);

                    SqlDataReader dr = alunosDevedores.ExecuteReader();
                    while (dr.Read())
                    {
                        dados[0] = dr.GetValue(0);
                        dados[1] = dr.GetValue(1);
                        dados[2] = dr.GetValue(2);
                        dados[3] = dr.GetValue(3);
                        dados[4] = dr.GetValue(4);
                        dados[5] = dr.GetValue(5);
                        dados[6] = dr.GetValue(6);
                    }
                    dr.Close();
                    return dados;
                } else
                {
                    object[] dados = new object[5];

                    SqlCommand alunosDevedores = new SqlCommand(@"select EF.ID_FUNCIONARIO,
	                                                                        F.Nome,
	                                                                        EF.Funcao,
	                                                                        EF.Data_Emprestimo,
	                                                                        EF.Data_Vencimento
		                                                                        from Emprestimos_Funcionarios AS EF
			                                                                        INNER JOIN Funcionarios AS f
				                                                                        ON f.Id_Funcionario = EF.ID_FUNCIONARIO
					                                                                        WHERE EF.Id_Livro =  " + id_Livro, cn);

                    SqlDataReader dr = alunosDevedores.ExecuteReader();
                    while (dr.Read())
                    {
                        dados[0] = dr.GetValue(0);
                        dados[1] = dr.GetValue(1);
                        dados[2] = dr.GetValue(2);
                        dados[3] = dr.GetValue(3);
                        dados[4] = dr.GetValue(4);
                    }
                    dr.Close();
                    return dados;
                }
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
            finally { cn.Close(); }
        }

        public object ListarAlunosDevedores()
        {
            try
            {
                cn.Open();

                SqlDataAdapter alunosDevedores = new SqlDataAdapter(@"SELECT DISTINCT a.RM
                                                                FROM Emprestimos_Alunos as ea
                                                                    INNER JOIN Alunos as a
                                                                        ON a.Id = ea.Id_Aluno", cn);

                DataTable dt = new DataTable();
                alunosDevedores.Fill(dt);
                return dt;
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
            finally { cn.Close(); }
        }

        public DateTime CalcularDataDevolucao(DateTime data)
        {
            try
            {
                cn.Open();

                SqlCommand calcularDevolucao = new SqlCommand("Emprestimo_CalcularDevolucao", cn);
                calcularDevolucao.CommandType = CommandType.StoredProcedure;

                calcularDevolucao.Parameters.AddWithValue("@data", data);

                return Convert.ToDateTime(calcularDevolucao.ExecuteScalar());
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
            finally { cn.Close(); }
        }

        public object CarregarLivros(int opc, int vis, string txtFiltro, string cbxFiltro, int opcFiltro)
        {
            try
            {
                cn.Open();

                SqlDataAdapter listarLeitores = new SqlDataAdapter("Emprestimo_ListarLivros", cn);
                listarLeitores.SelectCommand.CommandType = CommandType.StoredProcedure;

                listarLeitores.SelectCommand.Parameters.AddWithValue("@opc", opc);
                listarLeitores.SelectCommand.Parameters.AddWithValue("@vis", vis);
                listarLeitores.SelectCommand.Parameters.AddWithValue("@txtFiltro", txtFiltro);
                listarLeitores.SelectCommand.Parameters.AddWithValue("@cbxFiltro", cbxFiltro);
                listarLeitores.SelectCommand.Parameters.AddWithValue("@cbxOpcFiltrarLivro", opcFiltro);

                DataTable dt = new DataTable();
                listarLeitores.Fill(dt);

                return dt;
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
            finally { cn.Close(); }
        }
    }
}
