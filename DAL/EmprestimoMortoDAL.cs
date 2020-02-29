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
    public class EmprestimoMortoDAL
    {
        SqlConnection cn = new SqlConnection(Dados.StringDeConexao);
        public object CarregarEmprestimosMortos(bool modoAluno)
        {
            try
            {
                cn.Open();

                SqlDataAdapter carregarEmprestimos = new SqlDataAdapter("EmprestimosAlunoMorto_ListarEmprestimosMorto", cn);
                carregarEmprestimos.SelectCommand.CommandType = CommandType.StoredProcedure;

                carregarEmprestimos.SelectCommand.Parameters.AddWithValue("@modoAluno", modoAluno);

                DataTable dt = new DataTable();
                carregarEmprestimos.Fill(dt);

                return dt;
            }catch(SqlException ex)
            {
                throw new Exception(ex.Message);
            }finally
            {
                cn.Close();
            }
        }

        public void DesfazerRenovacao(EmprestimoInformation emprestimo, bool modoAluno)
        {
            try
            {
                cn.Open();

                SqlCommand desfazerRenovacao = new SqlCommand("EmprestimosAlunoMorto_DesfazerRenovacao", cn);
                desfazerRenovacao.CommandType = CommandType.StoredProcedure;

                desfazerRenovacao.Parameters.AddWithValue("@tombo", emprestimo.Tombo);
                desfazerRenovacao.Parameters.AddWithValue("@emprestimo", emprestimo.Retirada);
                desfazerRenovacao.Parameters.AddWithValue("@devolucao", emprestimo.Devolucao);
                desfazerRenovacao.Parameters.AddWithValue("@rm", emprestimo.Rm);
                if(emprestimo.NomeProfessor is null) desfazerRenovacao.Parameters.AddWithValue("@nomeFunc", "");
                else desfazerRenovacao.Parameters.AddWithValue("@nomeFunc", emprestimo.NomeProfessor);

                desfazerRenovacao.Parameters.AddWithValue("@ModoAluno", modoAluno);

                desfazerRenovacao.ExecuteNonQuery();
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

        public bool VerificarRenovacao(EmprestimoInformation emprestimo, bool modoAluno)
        {
            try
            {
                cn.Open();

                SqlCommand verificarRenovacao = new SqlCommand("EmprestimosAlunoMorto_VerificarRenovacao", cn);
                verificarRenovacao.CommandType = CommandType.StoredProcedure;

                verificarRenovacao.Parameters.AddWithValue("@tombo", emprestimo.Tombo);
                verificarRenovacao.Parameters.AddWithValue("@idAluno", emprestimo.IdAluno);
                verificarRenovacao.Parameters.AddWithValue("@modoAluno", modoAluno);
                verificarRenovacao.Parameters.AddWithValue("@idFunc", emprestimo.IdFuncionario);

                return Convert.ToBoolean(verificarRenovacao.ExecuteScalar());
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

        public bool VerificarDisponibilidade(string idLivro)
        {
            try
            {
                cn.Open();

                SqlCommand excluirMorto = new SqlCommand("EmprestimosAlunoMorto_VerificarDisponibilidade", cn);
                excluirMorto.CommandType = CommandType.StoredProcedure;

                excluirMorto.Parameters.AddWithValue("@idLivro", int.Parse(idLivro));

                return Convert.ToBoolean(excluirMorto.ExecuteScalar());
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

        public void ExcluirMorto(string idMorto, bool modoAluno)
        {
            try
            {
                cn.Open();

                SqlCommand excluirMorto = new SqlCommand("EmprestimosAlunoMorto_ExcluirMorto", cn);
                excluirMorto.CommandType = CommandType.StoredProcedure;

                excluirMorto.Parameters.AddWithValue("@idMorto", int.Parse(idMorto));
                excluirMorto.Parameters.AddWithValue("@modoAluno", modoAluno);

                excluirMorto.ExecuteNonQuery();
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
