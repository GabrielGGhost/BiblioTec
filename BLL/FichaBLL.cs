using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class FichaBLL
    {
        FichaDAL fichaDAL = new FichaDAL();
        public object CarregarFichas()
        {
            return fichaDAL.CarregarFichas();
        }

        public object[] CarregarDados(string tombo)
        {
            return fichaDAL.CarregarDados(tombo);
        }

        public object CarregarFichas(int idLivro)
        {
            return fichaDAL.CarregarFichas(idLivro);

        }
    }
}
