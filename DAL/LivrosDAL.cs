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
    public class LivrosDAL
    {
        SqlConnection cn = new SqlConnection(Dados.StringDeConexao);
        public void IncluirLivro(LivroInformation livro, string erro)
        {
            try
            {
                cn.Open();

                SqlCommand incluirLivro = new SqlCommand("Livros_InserirLivro", cn);
                incluirLivro.CommandType = CommandType.StoredProcedure;

                incluirLivro.Parameters.AddWithValue("@nome", livro.Nome);
                incluirLivro.Parameters.AddWithValue("@Localizacao", livro.Localziacao);
                incluirLivro.Parameters.AddWithValue("@Cidade", livro.Cidade);
                incluirLivro.Parameters.AddWithValue("@edicao", livro.Edicao);
                incluirLivro.Parameters.AddWithValue("@detalhes", livro.Detalhes);
                incluirLivro.Parameters.AddWithValue("@ano", livro.Ano);
                incluirLivro.Parameters.AddWithValue("@volPags", livro.VolumePags);
                incluirLivro.Parameters.AddWithValue("@editora", livro.Editora);
                incluirLivro.Parameters.AddWithValue("@autor", livro.Autor);
                incluirLivro.Parameters.AddWithValue("@tombo", livro.Tombo);
                incluirLivro.Parameters.AddWithValue("@multa", livro.Multa);

                incluirLivro.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
            finally { cn.Close(); }
        }

        public object VizualizarMultas(string filtro, int opc, int vis, int dias, decimal multa)
        {
            try
            {
                cn.Open();

                SqlDataAdapter da = new SqlDataAdapter("Livros_VizualizarMultas", cn);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;

                da.SelectCommand.Parameters.AddWithValue("@filtro", filtro);
                da.SelectCommand.Parameters.AddWithValue("@vis", vis);
                da.SelectCommand.Parameters.AddWithValue("@opc", opc);
                da.SelectCommand.Parameters.AddWithValue("@dias", dias);
                da.SelectCommand.Parameters.AddWithValue("@multa", multa);

                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
            finally { cn.Close(); }
        }

        public string BuscarMultaFixa()
        {
            try
            {
                cn.Open();

                SqlCommand livroRoubado = new SqlCommand(@"SELECT MULTADIA FROM CONFIGURACOES", cn);

                string res = livroRoubado.ExecuteScalar().ToString();

                return res;
            }
            catch (SqlException ex) { throw new Exception(ex.Message); }
            finally { cn.Close(); }
        }

        public void LivroRoubado(int id_livro, int opc)
        {
            try
            {
                cn.Open();

                SqlCommand livroRoubado = new SqlCommand(@"Livros_LivroRoubado", cn);
                livroRoubado.CommandType = CommandType.StoredProcedure;

                livroRoubado.Parameters.AddWithValue("@idLivro", id_livro);
                livroRoubado.Parameters.AddWithValue("@opc", opc);

                livroRoubado.ExecuteNonQuery();
            }
            catch (SqlException ex) { throw new Exception(ex.Message); }
            finally { cn.Close(); }
        }

        public void DeletarLivro()
        {
            try
            {
                cn.Open();

                SqlCommand deletarLivro = new SqlCommand(@"Livros_ExcluirLivro", cn);

                deletarLivro.ExecuteNonQuery();
            }
            catch (SqlException ex) { throw new Exception(ex.Message); }
            finally { cn.Close(); }
        }

        public int BuscarUltimoTombo()
        {
            try
            {
                cn.Open();

                SqlCommand verificarTombo = new SqlCommand(@"SELECT MAX(TOMBO)
                                                                FROM LIVROS", cn);

                string resultado = Convert.ToString(verificarTombo.ExecuteScalar());

                if (resultado == "") return 1;
                else return int.Parse(resultado) + 1;
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
            finally { cn.Close(); }
        }

        public void AlterarLivro(LivroInformation livro, ref string erro)
        {
            try
            {
                cn.Open();

                SqlCommand incluirLivro = new SqlCommand("Livros_AlterarLivro", cn);
                incluirLivro.CommandType = CommandType.StoredProcedure;

                incluirLivro.Parameters.AddWithValue("@id", livro.Id);
                incluirLivro.Parameters.AddWithValue("@nome", livro.Nome);
                incluirLivro.Parameters.AddWithValue("@Localizacao", livro.Localziacao);
                incluirLivro.Parameters.AddWithValue("@Cidade", livro.Cidade);
                incluirLivro.Parameters.AddWithValue("@edicao", livro.Edicao);
                incluirLivro.Parameters.AddWithValue("@detalhes", livro.Detalhes);
                incluirLivro.Parameters.AddWithValue("@ano", livro.Ano);
                incluirLivro.Parameters.AddWithValue("@volPags", livro.VolumePags);
                incluirLivro.Parameters.AddWithValue("@editora", livro.Editora);
                incluirLivro.Parameters.AddWithValue("@autor", livro.Autor);
                incluirLivro.Parameters.AddWithValue("@tombo", livro.Tombo);
                incluirLivro.Parameters.AddWithValue("@multa", livro.Multa);
                incluirLivro.Parameters.AddWithValue("@roubado", livro.Roubado);

                incluirLivro.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                if (ex.Number == 2627)
                {
                    erro = "Tombo já Existente!";
                    throw new Exception("O número de tombo já foi registrado!");
                }
                throw new Exception(ex.Message);
            }
            finally { cn.Close(); }
        }

        public object ListarLivros(string filtro, int opc, int vis)
        {
            try
            {
                cn.Open();

                SqlDataAdapter da = new SqlDataAdapter("Livros_ListarLivros", cn);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;

                da.SelectCommand.Parameters.AddWithValue("@filtro", filtro);
                da.SelectCommand.Parameters.AddWithValue("@vis", vis);
                da.SelectCommand.Parameters.AddWithValue("@opc", opc);

                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
            finally { cn.Close(); }
        }
    }
}
