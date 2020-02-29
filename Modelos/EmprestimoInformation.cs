using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos
{
    public class EmprestimoInformation
    {
        int _idAluno;
        int _rm;
        string _nomeAluno;
        string _curso;
        int _modulo;

        int _idFuncionario;
        string _nomeProfessor;
        string _funcao;

        int _idLivro;
        string _nomeLivro;
        string _localizacao;
        string _ano;
        string _autor;
        int _tombo;
        DateTime _retirada;
        DateTime _devolucao;
        string _serie;
        public EmprestimoInformation(int idFuncionario,
                                     string nomeProfessor,
                                     string funcao,
                                     int idLivro,
                                     string nomeLivro,
                                     string localizacao,
                                     string ano,
                                     string autor,
                                     int tombo,
                                     DateTime retirada,
                                     DateTime devolucao,
                                     string serie)
        {
            IdFuncionario = idFuncionario;
            NomeProfessor = nomeProfessor;
            Funcao = funcao;
            IdLivro = idLivro;
            NomeLivro = nomeLivro;
            Localizacao = localizacao;
            Ano = ano;
            Autor = autor;
            Tombo = tombo;
            Retirada = retirada;
            Devolucao = devolucao;
            Serie = serie;
        }

        public EmprestimoInformation(int idAluno,
                                     int rm,
                                     string nomeAluno,
                                     string curso,
                                     int modulo,
                                     int idLivro,
                                     string nomeLivro,
                                     string localizacao,
                                     string ano,
                                     string autor,
                                     int tombo,
                                     DateTime retirada,
                                     DateTime devolucao,
                                     string serie)
        {
            IdAluno = idAluno;
            Rm = rm;
            NomeAluno = nomeAluno;
            Curso = curso;
            Modulo = modulo;
            IdLivro = idLivro;
            NomeLivro = nomeLivro;
            Localizacao = localizacao;
            Ano = ano;
            Autor = autor;
            Tombo = tombo;
            Retirada = retirada;
            Devolucao = devolucao;
            Retirada = retirada;
            Devolucao = devolucao;
            Serie = serie;
        }

        public int IdAluno { get => _idAluno; set => _idAluno = value; }
        public int Rm { get => _rm; set => _rm = value; }
        public string NomeAluno { get => _nomeAluno; set => _nomeAluno = value; }
        public string Curso { get => _curso; set => _curso = value; }
        public int Modulo { get => _modulo; set => _modulo = value; }
        public int IdFuncionario { get => _idFuncionario; set => _idFuncionario = value; }
        public string NomeProfessor { get => _nomeProfessor; set => _nomeProfessor = value; }
        public string Funcao { get => _funcao; set => _funcao = value; }
        public int IdLivro { get => _idLivro; set => _idLivro = value; }
        public string NomeLivro { get => _nomeLivro; set => _nomeLivro = value; }
        public string Localizacao { get => _localizacao; set => _localizacao = value; }
        public string Ano { get => _ano; set => _ano = value; }
        public string Autor { get => _autor; set => _autor = value; }
        public int Tombo { get => _tombo; set => _tombo = value; }
        public DateTime Retirada { get => _retirada; set => _retirada = value; }
        public DateTime Devolucao { get => _devolucao; set => _devolucao = value; }
        public string Serie { get => _serie; set => _serie = value; }
    }
}
