using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos
{
    public class EmailInformation
    {
        string
            _texto1,
            _texto2,
            _texto3,
            _texto4,
            _texto5,
            _texto6,
            _texto7,
            _texto8;

        int
            _dado1,
            _dado2,
            _dado3,
            _dado4,
            _dado5,
            _dado6,
            _dado7,
            _dado8;

        public EmailInformation(string texto1,
                                string texto2,
                                string texto3,
                                string texto4,
                                string texto5,
                                string texto6,
                                string texto7,
                                string texto8,
                                int dado1,
                                int dado2,
                                int dado3,
                                int dado4,
                                int dado5,
                                int dado6,
                                int dado7,
                                int dado8)
        {
            _texto1 = texto1;
            _texto2 = texto2;
            _texto3 = texto3;
            _texto4 = texto4;
            _texto5 = texto5;
            _texto6 = texto6;
            _texto7 = texto7;
            _texto8 = texto8;
            _dado1 = dado1;
            _dado2 = dado2;
            _dado3 = dado3;
            _dado4 = dado4;
            _dado5 = dado5;
            _dado6 = dado6;
            _dado7 = dado7;
            _dado8 = dado8;
        }

        public string Texto1 { get => _texto1; set => _texto1 = value; }
        public string Texto2 { get => _texto2; set => _texto2 = value; }
        public string Texto3 { get => _texto3; set => _texto3 = value; }
        public string Texto4 { get => _texto4; set => _texto4 = value; }
        public string Texto5 { get => _texto5; set => _texto5 = value; }
        public string Texto6 { get => _texto6; set => _texto6 = value; }
        public string Texto7 { get => _texto7; set => _texto7 = value; }
        public string Texto8 { get => _texto8; set => _texto8 = value; }
        public int Dado1 { get => _dado1; set => _dado1 = value; }
        public int Dado2 { get => _dado2; set => _dado2 = value; }
        public int Dado3 { get => _dado3; set => _dado3 = value; }
        public int Dado4 { get => _dado4; set => _dado4 = value; }
        public int Dado5 { get => _dado5; set => _dado5 = value; }
        public int Dado6 { get => _dado6; set => _dado6 = value; }
        public int Dado7 { get => _dado7; set => _dado7 = value; }
        public int Dado8 { get => _dado8; set => _dado8 = value; }
    }
}
