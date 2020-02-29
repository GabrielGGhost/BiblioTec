using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class MultasDAL
    {
        SqlConnection cn = new SqlConnection(Dados.StringDeConexao);
        public object CarregarMultas(int opc, string filtro)
        {
            try
            {
                cn.Open();

                SqlDataAdapter carregarMultas = new SqlDataAdapter("Multas_CarregarMultas", cn);
                carregarMultas.SelectCommand.CommandType = CommandType.StoredProcedure;

                carregarMultas.SelectCommand.Parameters.AddWithValue("@opc", opc);
                carregarMultas.SelectCommand.Parameters.AddWithValue("@filtro", filtro);

                DataTable dt = new DataTable();
                carregarMultas.Fill(dt);

                return dt;
            }catch(SqlException ex)
            {
                throw new Exception(ex.Message);
            }finally { cn.Close(); }
        }

        public void PagarMulta(int id_multa)
        {
            try
            {
                cn.Open();

                SqlCommand pagarMulta = new SqlCommand("Multas_PagarMulta", cn);
                pagarMulta.CommandType = CommandType.StoredProcedure;

                pagarMulta.Parameters.AddWithValue("@idMulta", id_multa);

                pagarMulta.ExecuteNonQuery();

            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
            finally { cn.Close(); }
        }

        public object[] CarregarDadosLivro(int id_multa)
        {
            try
            {
                cn.Open();

                object[] dadosLivro = new object[8];

                SqlDataAdapter carregarMultas = new SqlDataAdapter("Multas_CarregarDadosLivros", cn);
                carregarMultas.SelectCommand.CommandType = CommandType.StoredProcedure;

                carregarMultas.SelectCommand.Parameters.AddWithValue("@idMulta", id_multa);

                SqlDataReader dr = carregarMultas.SelectCommand.ExecuteReader();
                while (dr.Read())
                {
                    dadosLivro[0] = dr.GetValue(0);
                    dadosLivro[1] = dr.GetValue(1);
                    dadosLivro[2] = dr.GetValue(2);
                    dadosLivro[3] = dr.GetValue(3);
                    dadosLivro[4] = dr.GetValue(4);
                    dadosLivro[5] = dr.GetValue(5);
                    dadosLivro[6] = dr.GetValue(6);
                    dadosLivro[7] = dr.GetValue(7);
                }
                dr.Close();

                return dadosLivro;
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
            finally { cn.Close(); }
        }

        public object[] CarregarDadosAlunos(int id_multa)
        {
            try
            {
                cn.Open();

                object[] dadosAluno = new object[5];

                SqlDataAdapter carregarMultas = new SqlDataAdapter("Multas_CarregarDadosAlunos", cn);
                carregarMultas.SelectCommand.CommandType = CommandType.StoredProcedure;

                carregarMultas.SelectCommand.Parameters.AddWithValue("@idMulta", id_multa);

                SqlDataReader dr = carregarMultas.SelectCommand.ExecuteReader();
                while(dr.Read())
                {
                    dadosAluno[0] = dr.GetValue(0);
                    dadosAluno[1] = dr.GetValue(1);
                    dadosAluno[2] = dr.GetValue(2);
                    dadosAluno[3] = dr.GetValue(3);
                    dadosAluno[4] = dr.GetValue(4);
                }
                dr.Close();

                return dadosAluno;
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
            finally { cn.Close(); }
        }
    }
}
