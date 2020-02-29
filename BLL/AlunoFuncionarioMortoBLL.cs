using DAL;
using GUI;
using Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class AlunoFuncionarioMortoBLL
    {

        AlunosMortoDAL alunosMortoDAL = new AlunosMortoDAL();

        public object ListarAlunos(int ensino, int vis, string filtro, bool modoAluno)
        {
            return alunosMortoDAL.ListarAlunos(ensino, vis, filtro, modoAluno);
        }

        public void ExcluirAlunoMorto(AlunosInformation aluno)
        {
            alunosMortoDAL.ExcluirAlunoMorto(aluno);
        }

        public void ExcluirDatados()
        {
            alunosMortoDAL.ExcluirDatados();
        }

        public void ExcluirFuncionarioMorto(FuncionarioInformation funcionario)
        {
            alunosMortoDAL.ExcluirFuncionarioMorto(funcionario);
        }
    }
}
