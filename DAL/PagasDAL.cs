using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class PagasDAL
    {
        SqlConnection cn = new SqlConnection(Dados.StringDeConexao);
        public object CarregarPagas(string filtro)
        {
            try
            {
                cn.Open();

                SqlDataAdapter carregarPagas = new SqlDataAdapter("MultasPagas_CarregarPagas", cn);
                carregarPagas.SelectCommand.CommandType = CommandType.StoredProcedure;

                carregarPagas.SelectCommand.Parameters.AddWithValue("@filtro", filtro);

                DataTable dt = new DataTable();
                carregarPagas.Fill(dt);

                return dt;
            }catch(SqlException ex)
            {
                throw new Exception(ex.Message);
            } finally
            {
                cn.Close();
            }
        }

        public void DesfazerMulta(int idLog)
        {
            try
            {
                cn.Open();

                SqlCommand desfazerMultaPaga = new SqlCommand("MultasPagas_DesfazerMulta", cn);
                desfazerMultaPaga.CommandType = CommandType.StoredProcedure;

                desfazerMultaPaga.Parameters.AddWithValue("@idLog", idLog);

                desfazerMultaPaga.ExecuteNonQuery();
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

        public object[] BuscarDadosLivro(string idLivro)
        {
            try
            {
                cn.Open();

                SqlCommand buscarDados = new SqlCommand("MultasPagas_DadosLivros", cn);
                buscarDados.CommandType = CommandType.StoredProcedure;

                buscarDados.Parameters.AddWithValue("@idLivro", int.Parse(idLivro));

                object[] dados = new object[5];
                SqlDataReader dr = buscarDados.ExecuteReader();
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
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                cn.Close();
            }

        }

        public object[] BuscarDadosAluno(string idAluno)
        {
            try
            {
                cn.Open();

                SqlCommand buscarDados = new SqlCommand("MultasPagas_DadosAlunos", cn);
                buscarDados.CommandType = CommandType.StoredProcedure;

                buscarDados.Parameters.AddWithValue("@idAluno", int.Parse(idAluno));

                object[] dados = new object[3];
                SqlDataReader dr = buscarDados.ExecuteReader();
                while(dr.Read())
                {
                    dados[0] = dr.GetValue(0);
                    dados[1] = dr.GetValue(1);
                    dados[2] = dr.GetValue(2);
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
    }
}
