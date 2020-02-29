using DAL;
using Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class CalendarioBLL
    {

        CalendarioDAL calendarioDAL = new CalendarioDAL();

        public object CarregarDatas(bool modoFixo, int opc, string dia, string mes, DateTime data, string feriado)
        {
            return calendarioDAL.CarregarDatas(modoFixo, opc, dia, mes, data, feriado);
        }

        public void InserirData(CalendarioInformation calendario, bool modoFixo, ref string erro)
        {
            if (!modoFixo)
            {
                if (calendario.Data < DateTime.Now)
                {
                    erro = "Data Inválida!";
                    throw new Exception("As datas precisam ser supeiores a data atual!");
                }
            }else
            {
                calendario.Data = DateTime.Now;
            }
            calendarioDAL.InserirData(calendario, modoFixo, ref erro);
        }

        public void DeletarData(CalendarioInformation calendario, bool modoFixo)
        {
            calendarioDAL.DeletarData(calendario, modoFixo);
        }

        public object ListarAlunos()
        {
            return calendarioDAL.ListarAlunos();
        }

        public int[] VerificarEmprestimos(bool modoFixo, string dia, string mes, string data)
        {
            if (data.Trim() == "/  /") data = DateTime.Now.ToShortDateString();
            return calendarioDAL.VerificarEmprestimos(modoFixo, dia, mes, data);
        }

        public void ExcluirFeriadosPassados()
        {
            calendarioDAL.ExcluirFeriadosPassados();
        }
    }
}
