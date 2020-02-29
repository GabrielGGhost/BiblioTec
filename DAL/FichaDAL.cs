using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class FichaDAL
    {
        SqlConnection cn = new SqlConnection(Dados.StringDeConexao);
        public object CarregarFichas()
        {
            try
            {
                cn.Open();

                SqlDataAdapter carregarLivros = new SqlDataAdapter(@"FichasCatalograficas_CarregarUltimasFichas", cn);
                carregarLivros.SelectCommand.CommandType = CommandType.StoredProcedure;

                DataTable dt = new DataTable();
                carregarLivros.Fill(dt);

                return dt;
            }catch(SqlException ex)
            {
                throw new Exception(ex.Message);
            }finally
            {
                cn.Close();
            }
        }

        public object CarregarFichas(int idLivro)
        {
            try
            {
                cn.Open();

                SqlDataAdapter carregarLivros = new SqlDataAdapter(@"FichasCatalograficas_CarregarFichas", cn);
                carregarLivros.SelectCommand.CommandType = CommandType.StoredProcedure;

                carregarLivros.SelectCommand.Parameters.AddWithValue("@idLivro", idLivro);

                DataTable dt = new DataTable();
                carregarLivros.Fill(dt);

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

        public object[] CarregarDados(string tombo)
        {
            try
            {
                cn.Open();

                object[] dados = new object[8];

                SqlCommand carregarLivros = new SqlCommand(@"SELECT * FROM LIVROS WHERE TOMBO LIKE '" + tombo + "'", cn);

                SqlDataReader dr = carregarLivros.ExecuteReader();
                while(dr.Read())
                {
                    dados[0] = dr.GetValue(0);
                    dados[1] = dr.GetValue(1);
                    dados[2] = dr.GetValue(2);
                    dados[3] = dr.GetValue(3);
                    dados[4] = dr.GetValue(6);
                    dados[5] = dr.GetValue(8);
                    dados[6] = dr.GetValue(9);
                    dados[7] = dr.GetValue(10);
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
