using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Dados
    {
        public static string StringDeConexao
        {
            get
            {
                return @"Data Source=ITAUTEC\CURSOTESTES;
                        Initial Catalog=Biblioteca;
                        User ID=sa;
                        Password=root";
            }
        }
    }
}
