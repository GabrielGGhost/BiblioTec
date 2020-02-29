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
    public class CalendarioDAL
    {

        SqlConnection cn = new SqlConnection(Dados.StringDeConexao);
        public object CarregarDatas(bool modoFixo, int opc, string dia, string mes, DateTime data, string feriado)
        {
           try
            {
                cn.Open();

                SqlDataAdapter listarDatas = new SqlDataAdapter("Calendario_CarregarFeriados", cn);
                listarDatas.SelectCommand.CommandType = CommandType.StoredProcedure;

                listarDatas.SelectCommand.Parameters.AddWithValue("@ModoFixo", modoFixo);
                listarDatas.SelectCommand.Parameters.AddWithValue("@opc", opc);
                listarDatas.SelectCommand.Parameters.AddWithValue("@dia", dia);
                listarDatas.SelectCommand.Parameters.AddWithValue("@mes", mes);
                listarDatas.SelectCommand.Parameters.AddWithValue("@data", data);
                listarDatas.SelectCommand.Parameters.AddWithValue("@feriado", feriado);

                DataTable dt = new DataTable();
                listarDatas.Fill(dt);

                return dt;
            }catch(SqlException ex)
            {
                throw new Exception(ex.Message);
            }finally
            {
                cn.Close();
            }

        }

        public void ExcluirFeriadosPassados()
        {
            try
            {
                cn.Open();

                SqlCommand excluirPassados = new SqlCommand("Calendario_ExclurPassados", cn);
                excluirPassados.CommandType = CommandType.StoredProcedure;

                excluirPassados.ExecuteNonQuery();
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

        public int[] VerificarEmprestimos(bool modoFixo, string dia, string mes, string data)
        {
            try
            {
                cn.Open();

                SqlCommand contarEmprestimos = new SqlCommand("Calendario_ContarEmprestimos", cn);
                contarEmprestimos.CommandType = CommandType.StoredProcedure;
                int[] resultados = new int[2];
                int tam = 0;
                contarEmprestimos.Parameters.AddWithValue("@modoFixo", modoFixo);
                contarEmprestimos.Parameters.AddWithValue("@dia", dia);
                contarEmprestimos.Parameters.AddWithValue("@mes", mes);
                contarEmprestimos.Parameters.AddWithValue("@data", data);

                SqlDataReader dr = contarEmprestimos.ExecuteReader();
                while(dr.Read())
                {
                    tam++;
                    resultados[tam - 1] = dr.GetInt32(0);
                }
                dr.Close();

                return resultados;
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

        public object ListarAlunos()
        {
            try
            {
                cn.Open();

                SqlDataAdapter inserirData = new SqlDataAdapter("Carteirinha_ListarAlunos", cn);
                inserirData.SelectCommand.CommandType = CommandType.StoredProcedure;

                DataTable dt = new DataTable();
                inserirData.Fill(dt);

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

        public void DeletarData(CalendarioInformation calendario, bool modoFixo)
        {
            try
            {
                cn.Open();

                SqlCommand inserirData = new SqlCommand("Calendario_DeletarFeriado", cn);
                inserirData.CommandType = CommandType.StoredProcedure;

                inserirData.Parameters.AddWithValue("@dia", calendario.Dia);
                inserirData.Parameters.AddWithValue("@mes", calendario.Mes);
                inserirData.Parameters.AddWithValue("@modoFixo", modoFixo);

                if(calendario.Data < Convert.ToDateTime("01/01/1800")) inserirData.Parameters.AddWithValue("@data", DateTime.Now);
                else inserirData.Parameters.AddWithValue("@data", calendario.Data);

                inserirData.ExecuteNonQuery();
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

        public void InserirData(CalendarioInformation calendario, bool modoFixo, ref string erro)
        {
            SqlTransaction t = null;
            try
            {
                cn.Open();

                t = cn.BeginTransaction(IsolationLevel.Serializable);

                SqlCommand inserirData = new SqlCommand("Calendario_InserirData", cn, t);
                inserirData.CommandType = CommandType.StoredProcedure;

                if(calendario.Data == Convert.ToDateTime("01/01/0001")) inserirData.Parameters.AddWithValue("@data", DateTime.Now);
                else inserirData.Parameters.AddWithValue("@data", calendario.Data);

                inserirData.Parameters.AddWithValue("@dia", calendario.Dia);
                inserirData.Parameters.AddWithValue("@mes", calendario.Mes);
                inserirData.Parameters.AddWithValue("@nome", calendario.Nome);
                inserirData.Parameters.AddWithValue("@fixo", modoFixo);

                SqlCommand adiarEmprestimos = new SqlCommand("Calendario_AdiarEmprestimos", cn, t);
                adiarEmprestimos.CommandType = CommandType.StoredProcedure;

                adiarEmprestimos.Parameters.AddWithValue("@dia", calendario.Dia);
                adiarEmprestimos.Parameters.AddWithValue("@mes", calendario.Mes);
                adiarEmprestimos.Parameters.AddWithValue("@data", calendario.Data);
                adiarEmprestimos.Parameters.AddWithValue("@fixo", modoFixo);

                inserirData.ExecuteNonQuery();
                adiarEmprestimos.ExecuteNonQuery();
                t.Commit();
            }
            catch (SqlException ex)
            {
                t.Rollback();
                if(ex.Number == 2627)
                {
                    erro = "Data Duplicada!";
                    throw new Exception("Já existe uma data salva igual a informada!");
                }
                throw new Exception(ex.Message);
            }
            finally
            {
                cn.Close();
            }
        }
    }
}
