using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class EstatisticasBLL
    {
        EstatisticasDAL estatisticasDAL = new EstatisticasDAL();
        public object CarregarDevedores(int index)
        {
            return estatisticasDAL.CarregarDevedores(index);
        }

        public void AtualizarMultas()
        {
            estatisticasDAL.AtualizarMultas();
        }

        public void AtualizarModulos()
        {
            estatisticasDAL.AtualizarModulos();
        }

        public void AtualizarLeitoresEspeciais()
        {
            estatisticasDAL.AtualizarLeitoresEspeciais();

        }

        public void AtualizarAnos()
        {
            estatisticasDAL.AtualizarAnos();
        }

        public void MandarEmails()
        {
            estatisticasDAL.MandarEmail();
        }
    }
}
