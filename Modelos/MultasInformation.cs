using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos
{
    public class MultasInformation
    {
        int _id;
        string _nome;
        decimal _multa;

        public MultasInformation(int id,
                                 string nome,
                                 decimal multa)
        {
            _id = id;
            _nome = nome;
            _multa = multa;
        }

        public int Id { get => _id; set => _id = value; }
        public string Nome { get => _nome; set => _nome = value; }
        public decimal Multa { get => _multa; set => _multa = value; }
    }
}
