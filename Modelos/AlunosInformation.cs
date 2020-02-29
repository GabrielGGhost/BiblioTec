using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos
{
    public class AlunosInformation
    {
        string _id;
        string _nome;
        string _RM;
        string _celular;
        string _telefone;
        string _email1;
        string _email2;
        DateTime _confeccao;
        string _termino;
        int _modulo;
        string _curso;
        bool _tecnico;

        public AlunosInformation(string nome,
                                 string RM,
                                 string celular,
                                 string telefone,
                                 string email1,
                                 string email2,
                                 DateTime confeccao,
                                 string termino,
                                 int modulo,
                                 string curso,
                                 bool tecnico)
        {
            _nome = nome;
            _RM = RM;
            _celular = celular;
            _telefone = telefone;
            _email1 = email1;
            _email2 = email2;
            _confeccao = confeccao;
            _termino = termino;
            _modulo = modulo;
            _curso = curso;
            _tecnico = tecnico;
        }

        public AlunosInformation(string id,
                                 string nome,
                                 string RM,
                                 string celular,
                                 string telefone,
                                 string email1,
                                 string email2,
                                 DateTime confeccao,
                                 string termino, 
                                 int modulo, 
                                 string curso,
                                 bool tecnico)
        {
            _id = id;
            _nome = nome;
            _RM = RM;
            _celular = celular;
            _telefone = telefone;
            _email1 = email1;
            _email2 = email2;
            _confeccao = confeccao;
            _termino = termino;
            _modulo = modulo;
            _curso = curso;
            _tecnico = tecnico;
        }

        public string Id { get => _id; set => _id = value; }
        public string Nome { get => _nome; set => _nome = value; }
        public string RM { get => _RM; set => _RM = value; }
        public string Celular { get => _celular; set => _celular = value; }
        public string Telefone { get => _telefone; set => _telefone = value; }
        public string Email1 { get => _email1; set => _email1 = value; }
        public string Email2 { get => _email2; set => _email2 = value; }
        public DateTime Confeccao { get => _confeccao; set => _confeccao = value; }
        public string Termino { get => _termino; set => _termino = value; }
        public int Modulo { get => _modulo; set => _modulo = value; }
        public string Curso { get => _curso; set => _curso = value; }
        public bool Tecnico { get => _tecnico; set => _tecnico = value; }
    }
}
