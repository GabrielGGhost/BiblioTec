using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class LeitorEspecialBLL
    {

        LeitorEspecialDAL leitorEspecialDAL = new LeitorEspecialDAL();

        public object CarregarLeitores(int opc, string filtro)
        {
            return leitorEspecialDAL.CarregarLeitores(opc, filtro);
        }

        public void AlterarSituacao(int idAluno, string situacao)
        {
            leitorEspecialDAL.AlterarSituacao(idAluno, situacao);
        }
    }
}
