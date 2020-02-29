using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI
{
    public class FuncionarioInformation
    {
        string _id;
        string _nome;
        string _telefone;
        string _celular;
        string _email;
        string _funcao;

        public FuncionarioInformation(string nome, 
                                        string telefone, 
                                        string celular,
                                        string email,
                                        string funcao)
        {
            Nome = nome;
            Telefone = telefone;
            Celular = celular;
            Email = email;
            Funcao = funcao;
        }

        public FuncionarioInformation(string id, 
                                        string nome,
                                        string telefone,
                                        string celular,
                                        string email,
                                        string funcao)
        {
            Id = id;
            Nome = nome;
            Telefone = telefone;
            Celular = celular;
            Email = email;
            Funcao = funcao;
        }

        public string Id { get => _id; set => _id = value; }
        public string Nome { get => _nome; set => _nome = value; }
        public string Telefone { get => _telefone; set => _telefone = value; }
        public string Celular { get => _celular; set => _celular = value; }
        public string Email { get => _email; set => _email = value; }
        public string Funcao { get => _funcao; set => _funcao = value; }
    }
}
