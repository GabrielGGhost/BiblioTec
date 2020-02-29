using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class MultasBLL
    {

        MultasDAL multasDAL = new MultasDAL();

        public object CarregarMultas(int opc, string filtro)
        {
            return multasDAL.CarregarMultas(opc, filtro);
        }

        public object[] CarregarDadosAlunos(int id_multa)
        {
            return multasDAL.CarregarDadosAlunos(id_multa);
        }

        public object[] CarregarDadosLivro(int id_multa)
        {
            return multasDAL.CarregarDadosLivro(id_multa);
        }

        public void PagarMulta(int id_multa)
        {
            multasDAL.PagarMulta(id_multa);
        }
    }
}
