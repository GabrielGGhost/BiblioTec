using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class MenuDAL
    {
        SqlConnection cn = new SqlConnection(Dados.StringDeConexao);
        public void AtualizarAvisos(int idMulta, bool email, bool sMS, bool whats, bool facebook)
        {
            try
            {
                cn.Open();

                SqlCommand atualizarAviso = new SqlCommand(@"UPDATE Multas
                                                                SET EMAIL = @EMAIL,
                                                                    SMS = @SMS,
                                                                    FACEBOOK = @FACEBOOK,
                                                                    WHATSAPP = @WHATS
                                                                        WHERE ID_MULTA = @ID", cn);

                atualizarAviso.Parameters.AddWithValue("@EMAIL", email);
                atualizarAviso.Parameters.AddWithValue("@SMS", sMS);
                atualizarAviso.Parameters.AddWithValue("@FACEBOOK", facebook);
                atualizarAviso.Parameters.AddWithValue("@WHATS", whats);
                atualizarAviso.Parameters.AddWithValue("@ID", idMulta);

                atualizarAviso.ExecuteNonQuery();
            }
            catch(SqlException ex)
            {
                throw new Exception(ex.Message);
            }finally
            {
                cn.Close();
            }
        }

        public void ExcluirEmprestimosFuncionariosDatados()
        {
            try
            {
                cn.Open();

                SqlCommand excluirDatados = new SqlCommand("MenuBLL_ExcluirEmprestimosFuncionariosDatados", cn);
                excluirDatados.CommandType = CommandType.StoredProcedure;

                excluirDatados.ExecuteNonQuery();
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

        public ArrayList CarregarLivrosSaidos(bool livro, int qtd, int indexChart)
        {
            try
            {
                cn.Open();

                ArrayList dados = new ArrayList();

                SqlDataAdapter maisSaidos = new SqlDataAdapter("Menu_LivrosMaisSaidosChart", cn);
                maisSaidos.SelectCommand.CommandType = CommandType.StoredProcedure;

                maisSaidos.SelectCommand.Parameters.AddWithValue("@INDEX", indexChart);
                maisSaidos.SelectCommand.Parameters.AddWithValue("@qtd", qtd);

                SqlDataReader dr;

                if (livro)
                {
                    dr = maisSaidos.SelectCommand.ExecuteReader();
                    dados.Clear();

                    while (dr.Read())
                    {
                        dados.Add(dr.GetString(0));
                    }

                    dr.Close();
                    return dados;
                } else
                {
                    dr = maisSaidos.SelectCommand.ExecuteReader();
                    dados.Clear();
                    while (dr.Read())
                    {
                        dados.Add(dr.GetInt32(1));
                    }

                    dr.Close();
                    return dados;
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

        public object CarregarMaisSaidos(int index)
        {
            try
            {
                cn.Open();

                SqlDataAdapter maisSaidos = new SqlDataAdapter("Menu_LivrosMaisSaidos", cn);
                maisSaidos.SelectCommand.CommandType = CommandType.StoredProcedure;

                maisSaidos.SelectCommand.Parameters.AddWithValue("@index", index);

                DataTable dt = new DataTable();
                maisSaidos.Fill(dt);

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

        public void ExcluirMultasDatadas()
        {
            try
            {
                cn.Open();

                SqlCommand excluirDatados = new SqlCommand("Multas_ExcluirDatadas", cn);
                excluirDatados.CommandType = CommandType.StoredProcedure;

                excluirDatados.ExecuteNonQuery();
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

        public bool VerificarBackupAtivo()
        {
            try
            {
                cn.Open();

                SqlCommand excluirDatados = new SqlCommand("SELECT backupAtivo FROM Configuracoes", cn);

                bool resultado = Convert.ToBoolean(excluirDatados.ExecuteNonQuery());

                return resultado;
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

        public void ExcluirEmprestimosAlunosDatados()
        {
            try
            {
                cn.Open();

                SqlCommand excluirDatados = new SqlCommand("Menu_ExcluirEmprestimosAlunosDatados", cn);
                excluirDatados.CommandType = CommandType.StoredProcedure;

                excluirDatados.ExecuteNonQuery();
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

        public object[] BuscarPermissoes()
        {
            try
            {
                cn.Open();

                object[] permissoes = new object[12];
                SqlCommand buscarPermissoes = new SqlCommand(@"Menu_ListarPermissoes", cn);

                SqlDataReader dr = buscarPermissoes.ExecuteReader();
                while(dr.Read())
                {
                    permissoes[0] = dr.GetValue(0);
                    permissoes[1] = dr.GetValue(1);
                    permissoes[2] = dr.GetValue(2);
                    permissoes[3] = dr.GetValue(3);
                    permissoes[4] = dr.GetValue(4);
                    permissoes[5] = dr.GetValue(5);
                    permissoes[6] = dr.GetValue(6);
                    permissoes[7] = dr.GetValue(7);
                    permissoes[8] = dr.GetValue(8);
                    permissoes[9] = dr.GetValue(9);
                    permissoes[10] = dr.GetValue(10);
                    permissoes[11] = dr.GetValue(11);
                }

                return permissoes;
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

        public string BuscarLogado()
        {
            try
            {
                cn.Open();

                SqlCommand atualizarAviso = new SqlCommand(@"SELECT logadoEm
                                                                FROM Configuracoes", cn);

                return atualizarAviso.ExecuteScalar().ToString();
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
