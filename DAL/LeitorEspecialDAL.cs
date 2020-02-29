using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class LeitorEspecialDAL
    {
        SqlConnection cn = new SqlConnection(Dados.StringDeConexao);
        public object CarregarLeitores(int opc, string filtro)
        {
            try
            {
                cn.Open();

                SqlDataAdapter listarLeitores = new SqlDataAdapter("LeitorEspecial_ListarLeitores", cn);
                listarLeitores.SelectCommand.CommandType = CommandType.StoredProcedure;

                listarLeitores.SelectCommand.Parameters.AddWithValue("@Opc", opc);
                listarLeitores.SelectCommand.Parameters.AddWithValue("@filtro", filtro);

                DataTable dt = new DataTable();
                listarLeitores.Fill(dt);

                return dt;
            }
            catch(SqlException ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                cn.Close();
            }
        }

        public void AlterarSituacao(int idAluno, string situacao)
        {
            try
            {
                cn.Open();

                SqlCommand alterarSituacao = new SqlCommand("LeitorEspecial_AlterarLeitor", cn);
                alterarSituacao.CommandType = CommandType.StoredProcedure;

                alterarSituacao.Parameters.AddWithValue("@idAluno", idAluno);
                alterarSituacao.Parameters.AddWithValue("@situacao", situacao);

                alterarSituacao.ExecuteNonQuery();
            }
            catch(SqlException ex)
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
