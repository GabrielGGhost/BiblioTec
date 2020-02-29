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
    public class AlunosDAL
    {
        SqlConnection cn = new SqlConnection(Dados.StringDeConexao);
        public object CarregarAlunos(int opc, string filtro, int ensino)
        {
            try
            {
                cn.Open();

                SqlDataAdapter carregarAlunos = new SqlDataAdapter("Alunos_ListarAlunos", cn);
                carregarAlunos.SelectCommand.CommandType = CommandType.StoredProcedure;

                carregarAlunos.SelectCommand.Parameters.AddWithValue("@opc", opc);
                carregarAlunos.SelectCommand.Parameters.AddWithValue("@filtro", filtro);
                carregarAlunos.SelectCommand.Parameters.AddWithValue("@ensino", ensino);


                DataTable dt = new DataTable();
                carregarAlunos.Fill(dt);
                return dt;
            }
            catch(SqlException ex) { throw new Exception(ex.Message); }
            finally { cn.Close(); }
        }

        public void IncluirAluno(AlunosInformation aluno)
        {
            try
            {
                cn.Open();

                SqlCommand verificarRM = new SqlCommand(@"SELECT COUNT(*)
                                                             FROM Alunos
                                                                WHERE RM = " + aluno.RM, cn);

                int resultado = Convert.ToInt32(verificarRM.ExecuteScalar());

                if (resultado != 0) throw new Exception("Já existe um aluno com este RA cadastrado no sistema!");

                SqlCommand carregarAlunos = new SqlCommand("Alunos_InserirAluno", cn);
                carregarAlunos.CommandType = CommandType.StoredProcedure;

                carregarAlunos.Parameters.AddWithValue("@RM", aluno.RM);
                carregarAlunos.Parameters.AddWithValue("@Nome", aluno.Nome);
                carregarAlunos.Parameters.AddWithValue("@celular", aluno.Celular);
                carregarAlunos.Parameters.AddWithValue("@telefone", aluno.Telefone);
                carregarAlunos.Parameters.AddWithValue("@email1", aluno.Email1);
                carregarAlunos.Parameters.AddWithValue("@email2", aluno.Email2);
                carregarAlunos.Parameters.AddWithValue("@confeccao", aluno.Confeccao);
                carregarAlunos.Parameters.AddWithValue("@termino", aluno.Termino);
                carregarAlunos.Parameters.AddWithValue("@modulo", aluno.Modulo);
                carregarAlunos.Parameters.AddWithValue("@curso", aluno.Curso);
                carregarAlunos.Parameters.AddWithValue("@tecnico", aluno.Tecnico);

                carregarAlunos.ExecuteNonQuery();

            }
            catch (SqlException ex) { throw new Exception(ex.Message); }
            finally { cn.Close(); }
        }

        public object CarregarFuncionarios(int opc, string filtro)
        {
            try
            {
                cn.Open();

                SqlDataAdapter carregarAlunos = new SqlDataAdapter("Funcionarios_ProcurarFuncionarios", cn);
                carregarAlunos.SelectCommand.CommandType = CommandType.StoredProcedure;

                carregarAlunos.SelectCommand.Parameters.AddWithValue("@opc", opc);
                carregarAlunos.SelectCommand.Parameters.AddWithValue("@filtro", filtro);

                DataTable dt = new DataTable();
                carregarAlunos.Fill(dt);
                return dt;
            }
            catch (SqlException ex) { throw new Exception(ex.Message); }
            finally { cn.Close(); }
        }

        public void ExcluirFinalizadosTecnicos()
        {
            try
            {
                cn.Open();
                int[] alunos = new int[0];
                int[] rm = new int[0];
                int tam = 0;
                SqlCommand listarFinalizados = new SqlCommand(@"SELECT Id, rm
                                                                    FROM Alunos
                                                                        WHERE Modulo = 0", cn);

                SqlDataReader dr = listarFinalizados.ExecuteReader();
                while (dr.Read())
                {
                    tam++;
                    Array.Resize(ref alunos, tam);
                    Array.Resize(ref rm, tam);

                    alunos[tam - 1] = dr.GetInt32(0);
                    rm[tam - 1] = dr.GetInt32(1);
                }

                dr.Close();

                SqlCommand excluirAluno;

                for (int i = 0; i < alunos.Length ; i++)
                {
                    excluirAluno = new SqlCommand("Alunos_ExcluirFinalizado", cn);
                    excluirAluno.CommandType = CommandType.StoredProcedure;

                    excluirAluno.Parameters.AddWithValue("@IdAluno", alunos[i]);
                    excluirAluno.Parameters.AddWithValue("@rm", rm[i]);

                    excluirAluno.ExecuteNonQuery();
                }
            }
            catch (SqlException ex) { throw new Exception(ex.Message); }
            finally { cn.Close(); }
        }

        public object CarregarLivrosLivros(int idAluno)
        {
            try
            {
                cn.Open();

                SqlDataAdapter carregarLivrosLidos = new SqlDataAdapter("Alunos_CarregarLivrosLidos", cn);
                carregarLivrosLidos.SelectCommand.CommandType = CommandType.StoredProcedure;

                carregarLivrosLidos.SelectCommand.Parameters.AddWithValue("@RM", idAluno);

                DataTable dt = new DataTable();
                carregarLivrosLidos.Fill(dt);
                return dt;
            }
            catch (SqlException ex) { throw new Exception(ex.Message); }
            finally { cn.Close(); }
        }

        public void TornarEspecial(string rm)
        {
            try
            {
                cn.Open();

                SqlCommand tornarEspecial = new SqlCommand("Alunos_TornarEspecial", cn);
                tornarEspecial.CommandType = CommandType.StoredProcedure;

                tornarEspecial.Parameters.AddWithValue("@rm", rm);

                tornarEspecial.ExecuteNonQuery();
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
            finally { cn.Close(); }
        }

        public void DeletarAluno(int id_Aluno, ref string erro)
        {
            try
            {
                cn.Open();

                SqlCommand carregarAlunos = new SqlCommand("Alunos_DeletarAluno", cn);
                carregarAlunos.CommandType = CommandType.StoredProcedure;

                carregarAlunos.Parameters.AddWithValue("@id", id_Aluno);

                carregarAlunos.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                if(ex.Number == 547)
                {
                    erro = "Transações Pendentes!"; 
                    throw new Exception("Este aluno possua empréstimos e/ou multas pendentes!");
                }
                throw new Exception(ex.Message);
            }
            finally { cn.Close(); }
        }

        public void AlterarAluno(AlunosInformation aluno)
        {
            try
            {
                cn.Open();

                SqlCommand verificarRM = new SqlCommand(@"SELECT COUNT(*)
                                                             FROM Alunos
                                                                WHERE RM = " + aluno.RM, cn);

                int resultado = Convert.ToInt32(verificarRM.ExecuteScalar());

                if (resultado > 1) throw new Exception("Já existe um aluno com este RA cadastrado no sistema!");

                SqlCommand carregarAlunos = new SqlCommand("Alunos_AlterarAluno", cn);
                carregarAlunos.CommandType = CommandType.StoredProcedure;

                carregarAlunos.Parameters.AddWithValue("@ID", aluno.Id);
                carregarAlunos.Parameters.AddWithValue("@RM", aluno.RM);
                carregarAlunos.Parameters.AddWithValue("@Nome", aluno.Nome);
                carregarAlunos.Parameters.AddWithValue("@celular", aluno.Celular);
                carregarAlunos.Parameters.AddWithValue("@telefone", aluno.Telefone);
                carregarAlunos.Parameters.AddWithValue("@email1", aluno.Email1);
                carregarAlunos.Parameters.AddWithValue("@email2", aluno.Email2);
                carregarAlunos.Parameters.AddWithValue("@confeccao", aluno.Confeccao);
                carregarAlunos.Parameters.AddWithValue("@termino", aluno.Termino);
                carregarAlunos.Parameters.AddWithValue("@modulo", aluno.Modulo);
                carregarAlunos.Parameters.AddWithValue("@curso", aluno.Curso);
                carregarAlunos.Parameters.AddWithValue("@tecnico", aluno.Tecnico);

                carregarAlunos.ExecuteNonQuery();
            }
            catch (SqlException ex) { throw new Exception(ex.Message); }
            finally { cn.Close(); }
        }

        public string CalcularTermino(int valor, DateTime data, bool tecnico)
        {
            try
            {
                cn.Open();

                SqlCommand carregarAlunos = new SqlCommand("Alunos_Calcular", cn);
                carregarAlunos.CommandType = CommandType.StoredProcedure;

                carregarAlunos.Parameters.AddWithValue("@valor", valor);
                carregarAlunos.Parameters.AddWithValue("@data", data);
                carregarAlunos.Parameters.AddWithValue("@tecnico", tecnico);

                string resultado = Convert.ToString(carregarAlunos.ExecuteScalar());

                return resultado;
            }
            catch (SqlException ex) { throw new Exception(ex.Message); }
            finally { cn.Close(); }
        }
    }
}
