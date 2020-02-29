using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GUI;
using Modelos;

namespace DAL
{
    public class AlunosMortoDAL
    {
        SqlConnection cn = new SqlConnection(Dados.StringDeConexao);
        public object ListarAlunos(int ensino, int vis, string filtro, bool modoAluno)
        {
            try
            {
                cn.Open();

                SqlDataAdapter listarAlunos = new SqlDataAdapter("AlunosMorto_ListarAlunosMortos", cn);
                listarAlunos.SelectCommand.CommandType = CommandType.StoredProcedure;

                listarAlunos.SelectCommand.Parameters.AddWithValue("@ensino", ensino);
                listarAlunos.SelectCommand.Parameters.AddWithValue("@vis", vis);
                listarAlunos.SelectCommand.Parameters.AddWithValue("@filtro", filtro);
                listarAlunos.SelectCommand.Parameters.AddWithValue("@modoAluno", modoAluno);

                DataTable dt = new DataTable();
                listarAlunos.Fill(dt);

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

        public void ExcluirFuncionarioMorto(FuncionarioInformation funcionario)
        {
            try
            {
                cn.Open();

                SqlCommand excluirFuncionarioMorto = new SqlCommand("FuncionariosMorto_ExcluirMorto", cn);
                excluirFuncionarioMorto.CommandType = CommandType.StoredProcedure;

                excluirFuncionarioMorto.Parameters.AddWithValue("@nome", funcionario.Nome);
                excluirFuncionarioMorto.Parameters.AddWithValue("@celular", funcionario.Celular);
                excluirFuncionarioMorto.Parameters.AddWithValue("@telefone", funcionario.Telefone);
                excluirFuncionarioMorto.Parameters.AddWithValue("@email", funcionario.Email);
                excluirFuncionarioMorto.Parameters.AddWithValue("@funcao", funcionario.Funcao);


                excluirFuncionarioMorto.ExecuteNonQuery();
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

        public void ExcluirDatados()
        {
            try
            {
                cn.Open();

                SqlCommand excluirDatados = new SqlCommand("AlunosMorto_ExcluirDatados", cn);
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

        public void ExcluirAlunoMorto(AlunosInformation aluno)
        {
            try
            {
                cn.Open();

                SqlCommand listarAlunos = new SqlCommand("AlunosMorto_ExcluirMorto", cn);
                listarAlunos.CommandType = CommandType.StoredProcedure;

                listarAlunos.Parameters.AddWithValue("@rm", aluno.RM);

                listarAlunos.ExecuteNonQuery();
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
