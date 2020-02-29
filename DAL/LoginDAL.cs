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
    public class LoginDAL
    {
        SqlConnection cn = new SqlConnection(Dados.StringDeConexao);
        public bool ValidarSenhaPrincipal(string senhaPrincipal)
        {
            try
            {
                cn.Open();

                SqlCommand validarSenhaPrincipal = new SqlCommand(@"SELECT SENHAPRINCIPAL
                                                                        FROM Configuracoes", cn);

                string resultado = Convert.ToString(validarSenhaPrincipal.ExecuteScalar());

                if (resultado == senhaPrincipal) return true;
                return false;
            }
            catch (SqlException ex) { throw new Exception(ex.Message); }
            finally { cn.Close(); }
        }

        public void CadastrarCliente(LoginInformation login, ref string erro)
        {
            try
            {
                cn.Open();

                SqlCommand validarSenhaPrincipal = new SqlCommand(@"SELECT count(*)
                                                                        FROM LOGIN
                                                                            WHERE USUARIO = '" + login.NovoUsuario + "'", cn);

                int resultado = Convert.ToInt32(validarSenhaPrincipal.ExecuteScalar());

                if (resultado != 0)
                {
                    erro = "Usuário já Existente!";
                    throw new Exception("Já existe um usuário com este nome cadastrado!");
                }

                SqlCommand cadastrarUsuario = new SqlCommand(@"INSERT INTO LOGIN
                                                                            VALUES (@USUARIO,
                                                                                    @SENHA,
                                                                                    @PIN,
                                                                                    @NomeCompleto)", cn);

                cadastrarUsuario.Parameters.AddWithValue("@USUARIO", login.NovoUsuario);
                cadastrarUsuario.Parameters.AddWithValue("@SENHA", login.NovaSenha);
                cadastrarUsuario.Parameters.AddWithValue("@PIN", login.NovoPin);
                cadastrarUsuario.Parameters.AddWithValue("@NomeCompleto", login.NomeCompleto);

                cadastrarUsuario.ExecuteNonQuery();
            }
            catch (SqlException ex) { throw new Exception(ex.Message); }
            finally { cn.Close(); }
        }

        public bool Acessar(LoginInformation login, ref string erro)
        {
            SqlTransaction t = null;
            try
            {
                cn.Open();

                t = cn.BeginTransaction(IsolationLevel.Serializable);

                SqlCommand verificarExistente = new SqlCommand(@"SELECT count(*)
                                                                        FROM LOGIN
                                                                            WHERE USUARIO = '" + login.Usuario + "'", cn, t);

                int resultado = Convert.ToInt32(verificarExistente.ExecuteScalar());

                if (resultado == 0)
                {
                    erro = "Dados Inválidos!";
                    throw new Exception("Usuário/senha inválidos!");
                }

                SqlCommand validarSenha = new SqlCommand(@"SELECT SENHA
                                                                    FROM LOGIN
                                                                        WHERE USUARIO = '" + login.Usuario + "'", cn, t);

                if (login.Senha == Convert.ToString(validarSenha.ExecuteScalar()))
                {
                    SqlCommand definirLogado = new SqlCommand(@"UPDATE CONFIGURACOES
                                                                    SET LogadoEm = '" + login.Usuario + "'", cn, t);

                    definirLogado.ExecuteNonQuery();

                    t.Commit();

                    return true;
                }
                return false;
            }
            catch (SqlException ex)
            {
                t.Rollback();
                throw new Exception(ex.Message);
            }
            finally { cn.Close(); }
        }

        public bool VerificarPin(string usuario, string pin, ref string erro)
        {
            try
            {
                cn.Open();

                SqlCommand verificarExistente = new SqlCommand(@"SELECT count(*)
                                                                        FROM LOGIN
                                                                            WHERE USUARIO = '" + usuario + "'", cn);

                int resultado = Convert.ToInt32(verificarExistente.ExecuteScalar());

                if (resultado == 0)
                {
                    erro = "Dados Inválidos!";
                    throw new Exception("Usuário/pin inválidos!");
                }

                SqlCommand verificarPin = new SqlCommand(@"SELECT PIN
                                                                    FROM LOGIN
                                                                        WHERE USUARIO = '" + usuario + "'", cn);

                string resultado2 = Convert.ToString(verificarPin.ExecuteScalar());

                if (pin == resultado2) return true;
                erro = "Dados Inválidos!";
                throw new Exception("Usuário/pin inválidos!");
            }
            catch (SqlException ex) { throw new Exception(ex.Message); }
            finally { cn.Close(); }
        }

        public void MudarSenha(string usuario, string novaSenha, string erro)
        {
            try
            {
                cn.Open();

                SqlCommand mudarSenha = new SqlCommand(@"UPDATE LOGIN
                                                            SET SENHA = '" + novaSenha + @"'
                                                                WHERE USUARIO = '" + usuario + "'", cn);

                mudarSenha.ExecuteNonQuery();
            }
            catch (SqlException ex) { throw new Exception(ex.Message); }
            finally { cn.Close(); }
        }
    }
}
