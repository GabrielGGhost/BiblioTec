using DAL;
using Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class AlunosBLL
    {
        AlunosDAL alunosDAL = new AlunosDAL();
        public object CarregarAlunos(int opc, string filtro, int ensino)
        {
            return alunosDAL.CarregarAlunos(opc, filtro, ensino);
        }

        public string CalcularTermino(int valor, DateTime data, bool tecnico, ref string erro)
        {

            return alunosDAL.CalcularTermino(valor, data, tecnico);
        }

        public void IncluirAluno(AlunosInformation aluno, ref string erro)
        {
            if (aluno.Nome == "")
            {
                erro = "Nome Não Informado!";
                throw new Exception("O aluno precisa de um nome!");
            }

            if (aluno.RM == "")
            {
                erro = "RM Não Informado!";
                throw new Exception("O aluno precisa de um RM!");
            }
            if (aluno.Curso == "")
            {
                erro = "Curso Não Informado!";
                throw new Exception("O aluno precisa de um curso!");
            }
            if (aluno.Modulo == 0)
            {
                erro = "Módulo/Ano Inválido!";
                throw new Exception("O módulo/ano não pode ser 0");
            }

            alunosDAL.IncluirAluno(aluno);
        }

        public object CarregarFuncionarios(int opc, string filtro)
        {
            return alunosDAL.CarregarFuncionarios(opc, filtro);

        }

        public void AlterarAluno(AlunosInformation aluno, ref string erro)
        {
            if (aluno.Nome == "")
            {
                erro = "Nome Não Informado!";
                throw new Exception("O aluno precisa de um nome!");
            }

            if (aluno.RM == "")
            {
                erro = "RM Não Informado!";
                throw new Exception("O aluno precisa de um RM!");
            }
            if (aluno.Celular == "")
            {
                erro = "Celular Não Informado!";
                throw new Exception("O aluno precisa de um nome!");
            }
            if (aluno.Email1 == "")
            {
                erro = "Email Não Informado!";
                throw new Exception("O aluno precisa de um email!");
            }
            if (aluno.Curso == "")
            {
                erro = "Curso Não Informado!";
                throw new Exception("O aluno precisa de um curso!");
            }

            if (aluno.Modulo == 0)
            {
                erro = "Módulo/Ano Inválido!";
                throw new Exception("O módulo/ano não pode ser 0");
            }

            alunosDAL.AlterarAluno(aluno);
        }

        public void DeletarAluno(int id_Aluno, ref string erro)
        {
            if (id_Aluno == 0)
            {
                erro = "Nenhum Aluno Selecionado!";
                throw new Exception("É preciso selecionar um cliente antes de excluí-lo!");
            }
            alunosDAL.DeletarAluno(id_Aluno, ref erro);
        }

        public void ExcluirFinalizadosTecnicos()
        {
            alunosDAL.ExcluirFinalizadosTecnicos();
        }

        public object CarregarLivrosLivros(int idAluno, bool modoAluno, ref string erro)
        {
            if (!modoAluno)
            {
                erro = "Funcionário Selecionado!";
                throw new Exception("Apenas alunos podem ser leitores especiais!");
            }

            if (idAluno == 0)
            {
                erro = "Aluno Não Selecionado!";
                throw new Exception("É preciso selecionar um aluno para verificar o leitor especial!");
            }

            return alunosDAL.CarregarLivrosLivros(idAluno);
        }

        public void TornarEspecial(string rm)
        {
            alunosDAL.TornarEspecial(rm);
        }
    }
}
