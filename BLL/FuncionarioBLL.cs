using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using GUI;

namespace BLL
{
    public class FuncionarioBLL
    {
        FuncionarioDAL funcionarioDAL = new FuncionarioDAL();

        public void IncluirFuncionario(FuncionarioInformation funcionario, ref string erro)
        {
            if(funcionario.Nome.Trim() == "")
            {
                erro = "Campo de Nome Vazio!";
                throw new Exception("É preciso informar um nome ao funcionário!");
            }
            if(funcionario.Funcao.Trim() == "")
            {
                erro = "Campo de Função Vazio!";
                throw new Exception("É preciso informar uma função ao funcionário!!");
            }

            funcionarioDAL.IncluirFuncionario(funcionario);
        }

        public void AlterarFuncionario(FuncionarioInformation funcionario, ref string erro)
        {
            if (funcionario.Nome.Trim() == "")
            {
                erro = "Campo de Nome Vazio!";
                throw new Exception("É preciso informar um nome ao funcionário!");
            }
            if (funcionario.Celular.Trim() == "")
            {
                erro = "Campo de Celular Vazio!";
                throw new Exception("É preciso informar um celular ao funcionário!");
            }
            if (funcionario.Email.Trim() == "")
            {
                erro = "Campo de Email Vazio!";
                throw new Exception("É preciso informar um email ao funcionário!");
            }
            if (funcionario.Funcao.Trim() == "")
            {
                erro = "Campo de Função Vazio!";
                throw new Exception("É preciso informar uma função ao funcionário!!");
            }

            funcionarioDAL.AlterarFuncionario(funcionario);
        }

        public void DeletarFuncionario(int Id_Func, ref string erro)
        {
            funcionarioDAL.DeletarAluno(Id_Func, ref erro);
        }
    }
}
