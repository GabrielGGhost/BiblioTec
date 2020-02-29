using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GUI;

namespace DAL
{
    public class FuncionarioDAL
    {
        SqlConnection cn = new SqlConnection(Dados.StringDeConexao);
        public void IncluirFuncionario(FuncionarioInformation funcionario)
        {
            try
            {
                cn.Open();

                SqlCommand verificarNome = new SqlCommand("SELECT COUNT(*) FROM FUNCIONARIOS WHERE NOME = @nome", cn);
                verificarNome.Parameters.AddWithValue("@nome", funcionario.Nome);

                int resultado = Convert.ToInt32(verificarNome.ExecuteScalar());

                if(resultado != 0)
                {
                    throw new Exception("Os funcionários não podem ter o mesmo nome! Tente um diferente ou um apelido !");
                }

                SqlCommand incluirFuncionario = new SqlCommand(@"Funcionarios_IncluirFuncionario", cn);
                incluirFuncionario.CommandType = CommandType.StoredProcedure;

                incluirFuncionario.Parameters.AddWithValue("@nome", funcionario.Nome);
                incluirFuncionario.Parameters.AddWithValue("@celular", funcionario.Celular);
                incluirFuncionario.Parameters.AddWithValue("@telefone", funcionario.Telefone);
                incluirFuncionario.Parameters.AddWithValue("@email", funcionario.Email);
                incluirFuncionario.Parameters.AddWithValue("@funcao", funcionario.Funcao);

                incluirFuncionario.ExecuteNonQuery();
            }
            catch(SqlException ex)
            {
                throw new Exception(ex.Message);
            } finally { cn.Close(); }
        }

        public void AlterarFuncionario(FuncionarioInformation funcionario)
        {
            try
            {
                cn.Open();

                SqlCommand incluirFuncionario = new SqlCommand(@"Funcionarios_AlterarFuncionario", cn);
                incluirFuncionario.CommandType = CommandType.StoredProcedure;

                incluirFuncionario.Parameters.AddWithValue("@id", funcionario.Id);
                incluirFuncionario.Parameters.AddWithValue("@nome", funcionario.Nome);
                incluirFuncionario.Parameters.AddWithValue("@celular", funcionario.Celular);
                incluirFuncionario.Parameters.AddWithValue("@telefone", funcionario.Telefone);
                incluirFuncionario.Parameters.AddWithValue("@email", funcionario.Email);
                incluirFuncionario.Parameters.AddWithValue("@funcao", funcionario.Funcao);

                incluirFuncionario.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
            finally { cn.Close(); }
        }

        public void DeletarAluno(int Id_Func, ref string erro)
        {
            try
            {
                cn.Open();

                SqlCommand incluirFuncionario = new SqlCommand(@"Funcionarios_DeletarFuncionario", cn);
                incluirFuncionario.CommandType = CommandType.StoredProcedure;

                incluirFuncionario.Parameters.AddWithValue("@id", Id_Func);

                incluirFuncionario.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                if(ex.Number == 547)
                {
                    erro = "Empréstimos Pendentes!";
                    throw new Exception("Este funcionário possui empréstismos pendentes!");
                }
                throw new Exception(ex.Message);
            }
            finally { cn.Close(); }
        }
    }
}