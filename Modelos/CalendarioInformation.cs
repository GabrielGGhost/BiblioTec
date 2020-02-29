using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos
{
    public class CalendarioInformation
    {
        int _dia;
        int _mes;

        string _nome;

        DateTime data;

        public CalendarioInformation(string nome, DateTime data)
        {
            _nome = nome;
            this.data = data;
        }

        public CalendarioInformation(int dia, int mes, string nome)
        {
            _dia = dia;
            _mes = mes;
            _nome = nome;
        }

        public int Dia { get => _dia; set => _dia = value; }
        public int Mes { get => _mes; set => _mes = value; }
        public DateTime Data { get => data; set => data = value; }
        public string Nome { get => _nome; set => _nome = value; }
    }
}
