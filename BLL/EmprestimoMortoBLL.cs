using DAL;
using Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class EmprestimoMortoBLL
    {
        EmprestimoMortoDAL emprestimoMortoDAL = new EmprestimoMortoDAL();
        public object CarregarEmprestimosMortos(bool modoAluno)
        {
            return emprestimoMortoDAL.CarregarEmprestimosMortos(modoAluno);
        }

        public void ExcluirMorto(string idMorto, bool modoAluno)
        {
            emprestimoMortoDAL.ExcluirMorto(idMorto, modoAluno);
        }

        public bool VerificarDisponibilidade(string idLivro)
        {
            return emprestimoMortoDAL.VerificarDisponibilidade(idLivro);
        }

        public bool verificarRenovacao(EmprestimoInformation emprestimo, bool modoAluno)
        {
            return emprestimoMortoDAL.VerificarRenovacao(emprestimo, modoAluno);
        }

        public void DesfazerRenovacao(EmprestimoInformation emprestimo, bool modoAluno)
        {
            emprestimoMortoDAL.DesfazerRenovacao(emprestimo, modoAluno);
        }
    }
}
