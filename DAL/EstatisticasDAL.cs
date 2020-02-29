using System;
using System.Data;
using System.Data.SqlClient;
using Outlook = Microsoft.Office.Interop.Outlook;

namespace DAL
{
    public class EstatisticasDAL
    {
        SqlConnection cn = new SqlConnection(Dados.StringDeConexao);
        public object CarregarDevedores(int index)
        {
            try
            {
                cn.Open();

                SqlDataAdapter carregarDevedpres = new SqlDataAdapter("Estatistica_ListagemMenu", cn);
                carregarDevedpres.SelectCommand.CommandType = CommandType.StoredProcedure;

                carregarDevedpres.SelectCommand.Parameters.AddWithValue("@index", index);

                DataTable dt = new DataTable();
                carregarDevedpres.Fill(dt);
                return dt;

            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                cn.Close();
            }
        }

        public void MandarEmail()
        {
            try
            {
                cn.Open();

                int[] rm = new int[0];
                int[] idMulta = new int[0];
                int[] idLivro = new int[0];
                int tam = 0;
                SqlCommand listarDados = new SqlCommand("Multas_ListarPreEmail", cn);

                SqlDataReader dr = listarDados.ExecuteReader();
                while(dr.Read())
                {
                    tam++;

                    Array.Resize(ref rm, tam);
                    Array.Resize(ref idMulta, tam);
                    Array.Resize(ref idLivro, tam);

                    rm[tam - 1] = dr.GetInt32(0);
                    idMulta[tam - 1] = dr.GetInt32(1);
                    idLivro[tam - 1] = dr.GetInt32(2);
                }
                dr.Close();

                for (int i = 0; i < rm.Length; i++)
                {
                    SqlCommand MontarParagrafo1 = new SqlCommand("Multas_MontarParagrafo1", cn);
                    MontarParagrafo1.CommandType = CommandType.StoredProcedure;

                    MontarParagrafo1.Parameters.AddWithValue("@rm", rm[i]);
                    MontarParagrafo1.Parameters.AddWithValue("@idMulta", idMulta[i]);
                    MontarParagrafo1.Parameters.AddWithValue("@idLivro", idLivro[i]);

                    string paragrafo1 = Convert.ToString(MontarParagrafo1.ExecuteScalar());

                    SqlCommand MontarParagrafo2 = new SqlCommand("Multas_MontarParagrafo2", cn);
                    MontarParagrafo2.CommandType = CommandType.StoredProcedure;

                    MontarParagrafo2.Parameters.AddWithValue("@rm", rm[i]);
                    MontarParagrafo2.Parameters.AddWithValue("@idMulta", idMulta[i]);
                    MontarParagrafo2.Parameters.AddWithValue("@idLivro", idLivro[i]);

                    string paragrafo2 = Convert.ToString(MontarParagrafo2.ExecuteScalar());

                    SqlCommand MontarParagrafo3 = new SqlCommand("Multas_MontarParagrafo3", cn);
                    MontarParagrafo3.CommandType = CommandType.StoredProcedure;

                    MontarParagrafo3.Parameters.AddWithValue("@rm", rm[i]);
                    MontarParagrafo3.Parameters.AddWithValue("@idMulta", idMulta[i]);
                    MontarParagrafo3.Parameters.AddWithValue("@idLivro", idLivro[i]);

                    string paragrafo3 = Convert.ToString(MontarParagrafo3.ExecuteScalar());

                    string[] emails = new string[2];

                    SqlCommand buscarEmails = new SqlCommand("Multas_BuscarEmails", cn);
                    buscarEmails.CommandType = CommandType.StoredProcedure;

                    buscarEmails.Parameters.AddWithValue("@rm", rm[i]);

                    SqlDataReader dr2 = buscarEmails.ExecuteReader();
                    while (dr2.Read())
                    {
                        emails[0] = dr2.GetString(0);
                        emails[1] = dr2.GetString(1);
                    }
                    dr2.Close();

                    for (int j = 0; j < 2; j++)
                    {
                        if(emails[j] != "")
                        {
                            Outlook.Application _app = new Outlook.Application();
                            Outlook.MailItem mail = (Outlook.MailItem)_app.CreateItem(Outlook.OlItemType.olMailItem);
                            mail.To = emails[j];
                            mail.Subject = "Atraso de Livro";
                            mail.Body = paragrafo1 + "\n\n" + paragrafo2 + "\n\n" + paragrafo3;
                            mail.Importance = Outlook.OlImportance.olImportanceNormal;
                            ((Outlook.MailItem)mail).Send();

                            SqlCommand marcarMulta = new SqlCommand("update Multas set Email = 1 where id_multa = " + idMulta[i], cn);

                            marcarMulta.ExecuteNonQuery();
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                cn.Close();
            }
        }

        public void AtualizarAnos()
        {
            try
            {
                cn.Open();

                int atual = DateTime.Now.Year;

                SqlCommand SemestreRegistrado = new SqlCommand(@"SELECT ano FROM CONFIGURACOES", cn);
                int registrado = Convert.ToInt32(SemestreRegistrado.ExecuteScalar());

                if (atual != registrado)
                {
                    SqlCommand atualizarSemestre = new SqlCommand(@"UPDATE CONFIGURACOES 
                                                                        SET ano = " + atual, cn);

                    atualizarSemestre.ExecuteNonQuery();
                }
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                cn.Close();
            }
        }

        public void AtualizarLeitoresEspeciais()
        {
            SqlTransaction t = null;
            try
            {
                cn.Open();
                t = cn.BeginTransaction(IsolationLevel.Serializable);

                int[] dados = new int[0];
                int tam = 0;

                SqlCommand buscarAlunos = new SqlCommand(@"SELECT Id_Aluno, count(DISTINCT ID_LIVRO)[Livros]   
	                                                            FROM [Emprestimos_Alunos(Morto)]
		                                                            WHERE Leitor_Especial = 0
			                                                            group by Id_Aluno
			                                                            having 	count(DISTINCT ID_LIVRO)  >= 36", cn, t);

                SqlDataReader dr = buscarAlunos.ExecuteReader();
                while (dr.Read())
                {
                    tam++;

                    Array.Resize(ref dados, tam);

                    dados[tam - 1] = dr.GetInt32(0);
                }
                dr.Close();

                SqlCommand
                    tornarLeitoresEspeciais,
                    inserirLeiLeitorEspecial;

                for (int i = 0; i < dados.Length; i++)
                {

                    tornarLeitoresEspeciais = new SqlCommand(@"UPDATE ALUNOS
                                                                    SET Leitor_Especial = 1
                                                                        WHERE ID =" + dados[i], cn, t);

                    inserirLeiLeitorEspecial = new SqlCommand(@"LeitorEspecial_InserirLeitor", cn, t);
                    inserirLeiLeitorEspecial.CommandType = CommandType.StoredProcedure;

                    inserirLeiLeitorEspecial.Parameters.AddWithValue("@idAluno", dados[i]);

                    inserirLeiLeitorEspecial.ExecuteNonQuery();
                    tornarLeitoresEspeciais.ExecuteNonQuery();
                }
                t.Commit();
            }
            catch (SqlException ex)
            {
                t.Rollback();
                throw new Exception(ex.Message);
            }
            finally
            {
                cn.Close();
            }
        }

        public void AtualizarModulos()
        {
            try
            {
                cn.Open();

                SqlCommand SemestreAtual = new SqlCommand(@"IF((SELECT DATEPART(QUARTER, GETDATE())) = 1
                                                                    OR (SELECT DATEPART(QUARTER, GETDATE())) = 2)
	                                                                    SELECT 1
                                                                ELSE
                                                                	SELECT 2", cn);
                int atual = Convert.ToInt32(SemestreAtual.ExecuteScalar());

                SqlCommand SemestreRegistrado = new SqlCommand(@"SELECT semestre FROM CONFIGURACOES", cn);
                int registrado = Convert.ToInt32(SemestreRegistrado.ExecuteScalar());

                if (atual != registrado)
                {
                    SqlCommand atualizarSemestre = new SqlCommand(@"UPDATE CONFIGURACOES 
                                                                        SET semestre = " + atual, cn);

                    atualizarSemestre.ExecuteNonQuery();
                }
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                cn.Close();
            }
        }

        public void AtualizarMultas()
        {
            try
            {
                cn.Open();
                int[] id_emp = new int[0];
                int[] id_Aluno = new int[0];
                int[] id_Livro = new int[0];
                int[] dias = new int[0];
                int tam = 0;
                SqlDataAdapter carregarDevedpres = new SqlDataAdapter("Estatistica_ListarAtrasados", cn);
                carregarDevedpres.SelectCommand.CommandType = CommandType.StoredProcedure;

                SqlDataReader dr = carregarDevedpres.SelectCommand.ExecuteReader();
                while (dr.Read())
                {
                    tam++;
                    Array.Resize(ref id_emp, tam);
                    Array.Resize(ref id_Aluno, tam);
                    Array.Resize(ref id_Livro, tam);
                    Array.Resize(ref dias, tam);

                    id_emp[tam - 1] = dr.GetInt32(0);
                    id_Aluno[tam - 1] = dr.GetInt32(1);
                    id_Livro[tam - 1] = dr.GetInt32(2);
                    dias[tam - 1] = dr.GetInt32(3);
                }
                dr.Close();

                SqlCommand atualizarDivida;

                for (int i = 0; i < id_Livro.Length; i++)
                {
                    atualizarDivida = new SqlCommand("Multas_AtualizarMultas", cn);
                    atualizarDivida.CommandType = CommandType.StoredProcedure;

                    atualizarDivida.Parameters.AddWithValue("@idAluno", id_Aluno[i]);
                    atualizarDivida.Parameters.AddWithValue("@idLivro", id_Livro[i]);
                    atualizarDivida.Parameters.AddWithValue("@dias", dias[i]);
                    atualizarDivida.Parameters.AddWithValue("@idEmp", id_emp[i]);

                    atualizarDivida.ExecuteNonQuery();
                }
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                cn.Close();
            }
        }
    }
}