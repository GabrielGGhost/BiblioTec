using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos
{
    public class LivroInformation
    {
        int _id;
        string _localziacao;
        string _nome;
        string _cidade;
        string _edicao;
        string _detalhes;
        string _ano;
        string _volumePags;
        string _editora;
        string _autor;
        int _tombo;
        decimal _multa;
        bool _roubado;


        public LivroInformation(string localziacao,
                                string nome,
                                string cidade,
                                string edicao,
                                string detalhes,
                                string ano,
                                string volumePags,
                                string editora,
                                string autor,
                                int tombo,
                                decimal multa)
        {
            _localziacao = localziacao;
            _nome = nome;
            _cidade = cidade;
            _edicao = edicao;
            _detalhes = detalhes;
            _ano = ano;
            _volumePags = volumePags;
            _editora = editora;
            _autor = autor;
            _tombo = tombo;
            _multa = multa;
        }

        public LivroInformation(int id,
                                string localziacao,
                                string nome, 
                                string cidade,
                                string edicao, 
                                string detalhes, 
                                string ano, 
                                string volumePags,
                                string editora,
                                string autor,
                                int tombo, 
                                decimal multa,
                                bool roubado)
        {
            _id = id;
            _localziacao = localziacao;
            _nome = nome;
            _cidade = cidade;
            _edicao = edicao;
            _detalhes = detalhes;
            _ano = ano;
            _volumePags = volumePags;
            _editora = editora;
            _autor = autor;
            _tombo = tombo;
            _multa = multa;
            _roubado = roubado;
        }

        public int Id { get => _id; set => _id = value; }
        public string Localziacao { get => _localziacao; set => _localziacao = value; }
        public string Nome { get => _nome; set => _nome = value; }
        public string Cidade { get => _cidade; set => _cidade = value; }
        public string Edicao { get => _edicao; set => _edicao = value; }
        public string Detalhes { get => _detalhes; set => _detalhes = value; }
        public string Ano { get => _ano; set => _ano = value; }
        public string VolumePags { get => _volumePags; set => _volumePags = value; }
        public string Editora { get => _editora; set => _editora = value; }
        public string Autor { get => _autor; set => _autor = value; }
        public int Tombo { get => _tombo; set => _tombo = value; }
        public decimal Multa { get => _multa; set => _multa = value; }
        public bool Roubado { get => _roubado; set => _roubado = value; }
    }
}
