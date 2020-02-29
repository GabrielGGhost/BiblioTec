using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class PagasBLL
    {
        PagasDAL pagasDAL = new PagasDAL();
        public object CarregarPagas(string filtro)
        {
            return pagasDAL.CarregarPagas(filtro);
        }

        public object[] BuscarDadosAluno(string IdAluno)
        {
            return pagasDAL.BuscarDadosAluno(IdAluno);
        }

        public object[] BuscarDadosLivro(string idLivro)
        {
            return pagasDAL.BuscarDadosLivro(idLivro);
        }

        public void DesfazerMulta(int idLog)
        {
            pagasDAL.DesfazerMulta(idLog);
        }
    }
}
