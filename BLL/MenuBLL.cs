using DAL;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class MenuBLL
    {
        MenuDAL menuDAL = new MenuDAL();
        public void AtualizarAvisos(int idMulta, bool email, bool sMS, bool whats, bool facebook)
        {
            menuDAL.AtualizarAvisos(idMulta, email, sMS, whats, facebook);
        }

        public string BuscarLogado()
        {
            return menuDAL.BuscarLogado();
        }

        public object[] BuscarPermissoes()
        {
            return menuDAL.BuscarPermissoes();
        }

        public void ExcluirEmprestimosAlunosDatados()
        {
            menuDAL.ExcluirEmprestimosAlunosDatados();
        }

        public bool VerificarBackupAtivo()
        {
            return menuDAL.VerificarBackupAtivo();
        }

        public void ExcluirMultasDatadas()
        {
            menuDAL.ExcluirMultasDatadas();
        }

        public object CarregarMaisSaidos(int index)
        {
            return menuDAL.CarregarMaisSaidos(index);
        }

        public ArrayList CarregarLivrosSaidos(bool livro, int qtd, int indexChart)
        {
            return menuDAL.CarregarLivrosSaidos(livro, qtd, indexChart);
        }

        public void ExcluirEmprestimosFuncionariosDatados()
        {
            menuDAL.ExcluirEmprestimosFuncionariosDatados();
        }
    }
}
