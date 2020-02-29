using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ConfiguracoesDAL
    {
        SqlConnection cn = new SqlConnection(Dados.StringDeConexao);

        public void DefinirMulta(decimal multa)
        {
            try
            {
                cn.Open();

                SqlCommand atualizarMulta = new SqlCommand("UPDATE CONFIGURACOES SET MULTADIA = @multa", cn);

                atualizarMulta.Parameters.AddWithValue("@multa", multa);

                atualizarMulta.ExecuteNonQuery();

            }catch(SqlException ex)
            {
                throw new Exception(ex.Message);
            }finally
            {
                cn.Close();
            }
        }

        public static bool BuscarLogin()
        {
            SqlConnection cn = new SqlConnection(Dados.StringDeConexao);
            try
            {
                cn.Open();

                SqlCommand resposta = new SqlCommand("SELECT loginAtivo from CONFIGURACOES", cn);

                return Convert.ToBoolean(resposta.ExecuteScalar());
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

        public void AtualizarExcluirFinalizados(bool status)
        {
            try
            {
                cn.Open();

                SqlCommand atualizarMulta = new SqlCommand("UPDATE CONFIGURACOES SET ExcluirFinalizadosAtivo = @status", cn);

                atualizarMulta.Parameters.AddWithValue("@status", status);

                atualizarMulta.ExecuteNonQuery();
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

        public void AtualizarExcluirEmprestimosAlunosMortoAtivo(bool status)
        {
            try
            {
                cn.Open();

                SqlCommand atualizarMulta = new SqlCommand("UPDATE CONFIGURACOES SET ExcluirEmprestimosAlunoAtivo = @status", cn);

                atualizarMulta.Parameters.AddWithValue("@status", status);

                atualizarMulta.ExecuteNonQuery();
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

        public string BuscarDiretorio()
        {
            try
            {
                cn.Open();

                SqlCommand atualizarMulta = new SqlCommand("SELECT Diretorio FROM CONFIGURACOES", cn);

                return Convert.ToString(atualizarMulta.ExecuteScalar());
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

        public float[] BuscarFonte()
        {
            try
            {
                cn.Open();

                float[] tam = new float[2];

                SqlCommand BuscarFonte = new SqlCommand("SELECT tamFont FROM CONFIGURACOES", cn);

                tam[0] =  Convert.ToInt32(BuscarFonte.ExecuteScalar());

                SqlCommand BuscarRows = new SqlCommand("SELECT tamRows FROM CONFIGURACOES", cn);

                tam[1] = Convert.ToInt32(BuscarRows.ExecuteScalar());

                return tam;
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

        public void ExcluirEmprestimosProfessoresMeses(int meses)
        {
            try
            {
                cn.Open();

                SqlCommand atualizarMulta = new SqlCommand("UPDATE CONFIGURACOES SET ExcluirEmprestimosProfessoresMeses = @meses", cn);

                atualizarMulta.Parameters.AddWithValue("@meses", meses);

                atualizarMulta.ExecuteNonQuery();
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

        public void ExcluirMultasMeses(int meses)
        {
            try
            {
                cn.Open();

                SqlCommand atualizarMulta = new SqlCommand("UPDATE CONFIGURACOES SET ExcluirMultasMeses = @meses", cn);

                atualizarMulta.Parameters.AddWithValue("@meses", meses);

                atualizarMulta.ExecuteNonQuery();
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

        public string BuscarSenhaPrinciapal()
        {
            try
            {
                cn.Open();

                SqlCommand atualizarMulta = new SqlCommand("SELECT SenhaPrincipal FROM CONFIGURACOES", cn);

                return Convert.ToString(atualizarMulta.ExecuteScalar());
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

        public bool ValidarSenha(string senhaDigitada)
        {
            try
            {
                cn.Open();

                SqlCommand logadoEm = new SqlCommand("SELECT LogadoEm FROM CONFIGURACOES", cn);

                string usuarioLogado = Convert.ToString(logadoEm.ExecuteScalar());

                SqlCommand senhaLogado = new SqlCommand("SELECT senha FROM LOGIN WHERE USUARIO = @usuario", cn);
                senhaLogado.Parameters.AddWithValue("@usuario", usuarioLogado);

                string senhaSalva = Convert.ToString(senhaLogado.ExecuteScalar());

                if (senhaSalva == senhaDigitada) return true;
                return false;
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

        public void DefinirTamanhoLinha(int tam)
        {
            try
            {
                cn.Open();

                SqlCommand AtualizarTamanho = new SqlCommand("UPDATE CONFIGURACOES SET TamRows = @tam", cn);

                AtualizarTamanho.Parameters.AddWithValue("@tam", tam);

                AtualizarTamanho.ExecuteNonQuery();
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

        public object[] CarregarDadosEmail()
        {
            try
            {
                cn.Open();

                object[] dados = new object[16];

                SqlCommand ReunirDados = new SqlCommand("Configuracoes_DadosEmail", cn);
                ReunirDados.CommandType = CommandType.StoredProcedure;

                SqlDataReader dr = ReunirDados.ExecuteReader();
                while (dr.Read())
                {
                    dados[0] = dr.GetValue(0);
                    dados[1] = dr.GetValue(1);
                    dados[2] = dr.GetValue(2);
                    dados[3] = dr.GetValue(3);
                    dados[4] = dr.GetValue(4);
                    dados[5] = dr.GetValue(5);
                    dados[6] = dr.GetValue(6);
                    dados[7] = dr.GetValue(7);
                    dados[8] = dr.GetValue(8);
                    dados[9] = dr.GetValue(9);
                    dados[10] = dr.GetValue(10);
                    dados[11] = dr.GetValue(11);
                    dados[12] = dr.GetValue(12);
                    dados[13] = dr.GetValue(13);
                    dados[14] = dr.GetValue(14);
                    dados[15] = dr.GetValue(15);
                }
                dr.Close();

                return dados;
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

        public void DefinirTamanho(int tam)
        {
            try
            {
                cn.Open();

                SqlCommand atualizarMulta = new SqlCommand("UPDATE CONFIGURACOES SET tamFont = @tam", cn);

                atualizarMulta.Parameters.AddWithValue("@tam", tam);

                atualizarMulta.ExecuteNonQuery();
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

        public bool VerificarPermissao()
        {
            try
            {
                cn.Open();

                SqlCommand PermitirBackUp = new SqlCommand("SELECT backupAtivo FROM CONFIGURACOES", cn);

                return Convert.ToBoolean(PermitirBackUp.ExecuteNonQuery());
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

        public void DefinirMensagemAutomatica(string p1, string p2, string p3, Modelos.EmailInformation email)
        {
            SqlTransaction t = null;
            try
            {
                cn.Open();

                t = cn.BeginTransaction(IsolationLevel.Serializable);
                SqlCommand guardarDados = new SqlCommand(@"UPDATE CONFIGURACOES SET texto1 = @t1,
                                                                                    texto2 = @t2,
                                                                                    texto3 = @t3,
                                                                                    texto4 = @t4,
                                                                                    texto5 = @t5,
                                                                                    texto6 = @t6,
                                                                                    texto7 = @t7,
                                                                                    texto8 = @t8,
                                                                                    
                                                                                    dado1 = @d1,
                                                                                    dado2 = @d2,
                                                                                    dado3 = @d3,
                                                                                    dado4 = @d4,
                                                                                    dado5 = @d5,
                                                                                    dado6 = @d6,
                                                                                    dado7 = @d7,
                                                                                    dado8 = @d8", cn, t);

                guardarDados.Parameters.AddWithValue("@t1", email.Texto1);
                guardarDados.Parameters.AddWithValue("@t2", email.Texto2);
                guardarDados.Parameters.AddWithValue("@t3", email.Texto3);
                guardarDados.Parameters.AddWithValue("@t4", email.Texto4);
                guardarDados.Parameters.AddWithValue("@t5", email.Texto5);
                guardarDados.Parameters.AddWithValue("@t6", email.Texto6);
                guardarDados.Parameters.AddWithValue("@t7", email.Texto7);
                guardarDados.Parameters.AddWithValue("@t8", email.Texto8);
                guardarDados.Parameters.AddWithValue("@d1", email.Dado1);
                guardarDados.Parameters.AddWithValue("@d2", email.Dado2);
                guardarDados.Parameters.AddWithValue("@d3", email.Dado3);
                guardarDados.Parameters.AddWithValue("@d4", email.Dado4);
                guardarDados.Parameters.AddWithValue("@d5", email.Dado5);
                guardarDados.Parameters.AddWithValue("@d6", email.Dado6);
                guardarDados.Parameters.AddWithValue("@d7", email.Dado7);
                guardarDados.Parameters.AddWithValue("@d8", email.Dado8);

                guardarDados.ExecuteNonQuery();

                SqlCommand atualizarMulta = new SqlCommand(@"UPDATE CONFIGURACOES SET p1 = @p1,
                                                                                      p2 = @p2,
                                                                                      p3 = @p3", cn, t);

                atualizarMulta.Parameters.AddWithValue("@p1", p1);
                atualizarMulta.Parameters.AddWithValue("@p2", p2);
                atualizarMulta.Parameters.AddWithValue("@p3", p3);

                atualizarMulta.ExecuteNonQuery();

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

        public void EmailAtivo(bool status)
        {
            try
            {
                cn.Open();

                SqlCommand atualizarMulta = new SqlCommand("UPDATE CONFIGURACOES SET EnviarEmailAtivo = @status", cn);

                atualizarMulta.Parameters.AddWithValue("@status", status);

                atualizarMulta.ExecuteNonQuery();
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

        public void DefinirDiretorio(string diretorio)
        {
            try
            {
                cn.Open();

                SqlCommand atualizarMulta = new SqlCommand("UPDATE CONFIGURACOES SET Diretorio = @diretorio", cn);

                atualizarMulta.Parameters.AddWithValue("@diretorio", diretorio);

                atualizarMulta.ExecuteNonQuery();
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

        public object[] CarregarDados()
        {
            try
            {
                cn.Open();

                object[] dados = new object[26];

                SqlDataAdapter bsucarDados = new SqlDataAdapter("Configuracoes_ListarConfiguracoes", cn);

                bsucarDados.SelectCommand.CommandType = CommandType.StoredProcedure;

                SqlDataReader dr = bsucarDados.SelectCommand.ExecuteReader();
                while(dr.Read())
                {
                    dados[0] = dr.GetValue(0);
                    dados[1] = dr.GetValue(1);
                    dados[2] = dr.GetValue(2);
                    dados[3] = dr.GetValue(3);
                    dados[4] = dr.GetValue(4);
                    dados[5] = dr.GetValue(5);
                    dados[6] = dr.GetValue(6);
                    dados[7] = dr.GetValue(7);
                    dados[8] = dr.GetValue(8);
                    dados[9] = dr.GetValue(9);
                    dados[10] = dr.GetValue(10);
                    dados[11] = dr.GetValue(11);
                    dados[12] = dr.GetValue(12);
                    dados[13] = dr.GetValue(13);
                    dados[14] = dr.GetValue(14);
                    dados[15] = dr.GetValue(15);
                    dados[16] = dr.GetValue(16);
                    dados[17] = dr.GetValue(17);
                    dados[18] = dr.GetValue(18);
                    dados[19] = dr.GetValue(19);
                    dados[20] = dr.GetValue(20);
                    dados[21] = dr.GetValue(21);
                    dados[22] = dr.GetValue(22);
                    dados[23] = dr.GetValue(23);
                    dados[24] = dr.GetValue(24);
                    dados[25] = dr.GetValue(25);
                }
                dr.Close();

                return dados;
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

        public void LoginAtivo(bool status)
        {
            try
            {
                cn.Open();

                SqlCommand atrasadosAtivo = new SqlCommand("UPDATE CONFIGURACOES SET loginAtivo = @status", cn);

                atrasadosAtivo.Parameters.AddWithValue("@status", status);

                atrasadosAtivo.ExecuteNonQuery();
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

        public void MaisSaidosAtivo(bool status)
        {
            try
            {
                cn.Open();

                SqlCommand atrasadosAtivo = new SqlCommand("UPDATE CONFIGURACOES SET maisSaidosVisivel = @status", cn);

                atrasadosAtivo.Parameters.AddWithValue("@status", status);

                atrasadosAtivo.ExecuteNonQuery();
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

        public void ChartAtivo(bool status)
        {
            try
            {
                cn.Open();

                SqlCommand atrasadosAtivo = new SqlCommand("UPDATE CONFIGURACOES SET ChartVisivel = @status", cn);

                atrasadosAtivo.Parameters.AddWithValue("@status", status);

                atrasadosAtivo.ExecuteNonQuery();
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

        public void AtrasadosAtivo(bool status)
        {
            try
            {
                cn.Open();

                SqlCommand atrasadosAtivo = new SqlCommand("UPDATE CONFIGURACOES SET AtrasadosVisivel = @status", cn);

                atrasadosAtivo.Parameters.AddWithValue("@status", status);

                atrasadosAtivo.ExecuteNonQuery();
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

        public void MudarSenhaPrincipal(string senha)
        {
            try
            {
                cn.Open();

                SqlCommand atualizarMulta = new SqlCommand("UPDATE CONFIGURACOES SET senhaPrincipal = @senha", cn);

                atualizarMulta.Parameters.AddWithValue("@senha", senha);

                atualizarMulta.ExecuteNonQuery();
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

        public void ExcluirDataPassadasAtivo(bool status)
        {
            try
            {
                cn.Open();

                SqlCommand atualizarMulta = new SqlCommand("UPDATE CONFIGURACOES SET ExcluirDatasPassadasAtivo = @status", cn);

                atualizarMulta.Parameters.AddWithValue("@status", status);

                atualizarMulta.ExecuteNonQuery();
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

        public void ExcluirMultasAtivo(bool status)
        {
            try
            {
                cn.Open();

                SqlCommand atualizarMulta = new SqlCommand("UPDATE CONFIGURACOES SET ExcluirMultasAtivo = @status", cn);

                atualizarMulta.Parameters.AddWithValue("@status", status);

                atualizarMulta.ExecuteNonQuery();
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

        public void BackupAtivo(bool status)
        {
            try
            {
                cn.Open();

                SqlCommand atualizarMulta = new SqlCommand("UPDATE CONFIGURACOES SET backupAtivo = @status", cn);

                atualizarMulta.Parameters.AddWithValue("@status", status);

                atualizarMulta.ExecuteNonQuery();
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

        public void MaxLivroFuncionariosAtivo(bool status)
        {
            try
            {
                cn.Open();

                SqlCommand atualizarMulta = new SqlCommand("UPDATE CONFIGURACOES SET maxLivrosFuncionariosAtivo = @status", cn);

                atualizarMulta.Parameters.AddWithValue("@status", status);

                atualizarMulta.ExecuteNonQuery();
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

        public void MaxLivrosQtdFuncionario(int qtd)
        {
            try
            {
                cn.Open();

                SqlCommand atualizarMulta = new SqlCommand("UPDATE CONFIGURACOES SET maxLivrosFuncionariosQtd = @qtd", cn);

                atualizarMulta.Parameters.AddWithValue("@qtd", qtd);

                atualizarMulta.ExecuteNonQuery();
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

        public void ExcluirEmprestimosProfessoresAtivos(bool status)
        {
            try
            {
                cn.Open();

                SqlCommand atualizarMulta = new SqlCommand("UPDATE CONFIGURACOES SET ExcluirEmprestimosProfessoresAtivo = @status", cn);

                atualizarMulta.Parameters.AddWithValue("@status", status);

                atualizarMulta.ExecuteNonQuery();
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

        public void MaxLivrosQtd(int qtd)
        {
            try
            {
                cn.Open();

                SqlCommand atualizarMulta = new SqlCommand("UPDATE CONFIGURACOES SET maxLivroQtd = @qtd", cn);

                atualizarMulta.Parameters.AddWithValue("@qtd", qtd);

                atualizarMulta.ExecuteNonQuery();
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

        public void AtualizarMaxLivroAtivo(bool status)
        {
            try
            {
                cn.Open();

                SqlCommand atualizarMulta = new SqlCommand("UPDATE CONFIGURACOES SET maxLivroAtivo = @status", cn);

                atualizarMulta.Parameters.AddWithValue("@status", status);

                atualizarMulta.ExecuteNonQuery();
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

        public void ExcluirEmprestimosAlunosMeses(int meses)
        {
            try
            {
                cn.Open();

                SqlCommand atualizarMulta = new SqlCommand("UPDATE CONFIGURACOES SET ExcluirEmprestimosAlunoMeses = @mese", cn);

                atualizarMulta.Parameters.AddWithValue("@mese", meses);

                atualizarMulta.ExecuteNonQuery();
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

        public void AtualizarExcluirAlunosMortoAtivo(int meses)
        {
            try
            {
                cn.Open();

                SqlCommand atualizarMulta = new SqlCommand("UPDATE CONFIGURACOES SET ExcluirFinalizadosMeses = @mese", cn);

                atualizarMulta.Parameters.AddWithValue("@mese", meses);

                atualizarMulta.ExecuteNonQuery();
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

        public void AtualizarExcluirAlunosMortoAtivo(bool status)
        {
            try
            {
                cn.Open();

                SqlCommand atualizarMulta = new SqlCommand("UPDATE CONFIGURACOES SET ExcluirFinalizadosMortoAtivo = @status", cn);

                atualizarMulta.Parameters.AddWithValue("@status", status);

                atualizarMulta.ExecuteNonQuery();
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

        public void AtualizarAvancoAno(bool status)
        {
            try
            {
                cn.Open();

                SqlCommand atualizarMulta = new SqlCommand("UPDATE CONFIGURACOES SET AtualizarAnosAtivo = @status", cn);

                atualizarMulta.Parameters.AddWithValue("@status", status);

                atualizarMulta.ExecuteNonQuery();
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

        public void AtualizarAvancoModulo(bool status)
        {
            try
            {
                cn.Open();

                SqlCommand atualizarMulta = new SqlCommand("UPDATE CONFIGURACOES SET AtualizarModulosAtivo = @status", cn);

                atualizarMulta.Parameters.AddWithValue("@status", status);

                atualizarMulta.ExecuteNonQuery();
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