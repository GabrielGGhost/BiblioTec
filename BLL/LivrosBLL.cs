using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Modelos;

namespace BLL
{
    public class LivrosBLL
    {
        LivrosDAL livrosDAL = new LivrosDAL();

        public void IncluirLivro(LivroInformation livro, string erro)
        {
            if(livro.Nome.Trim() == "")
            {
                erro = "Campo Nome Vazio!";
                throw new Exception("É preciso informar um nome ao livro!");
            }

            if (livro.Multa == 0)
            {
                erro = "Valor de Multa Zerado!";
                throw new Exception("O valor da multa do livro não pode ser 0,00!");
            }

            livrosDAL.IncluirLivro(livro, erro);
        }

        public object ListarLivros(string filtro, int opc, int vis)
        {
            return livrosDAL.ListarLivros(filtro, opc, vis);
        }

        public void AlterarLivro(LivroInformation livro, ref string erro)
        {
            if (livro.Nome.Trim() == "")
            {
                erro = "Campo Nome Vazio!";
                throw new Exception("É preciso informar um nome ao livro!");
            }

            if (livro.Multa == 0)
            {
                erro = "Valor de Multa Zerado!";
                throw new Exception("O valor da multa do livro não pode ser 0,00!");
            }

            livrosDAL.AlterarLivro(livro, ref erro);
        }

        public int BuscarUltimoTombo()
        {
            return livrosDAL.BuscarUltimoTombo();
        }

        public void DeletarLivro(int id_livro)
        {
            livrosDAL.DeletarLivro();
        }

        public void LivroRoubado(int id_livro, int opc, ref string erro)
        {
            if(id_livro == 0)
            {
                erro = "Livro Não Selecionado!";
                throw new Exception("Selecione um livro para desativá-lo!");
            }
            livrosDAL.LivroRoubado(id_livro, opc);
        }

        public object VizualizarMultas(string filtro, int opc, int vis, int dias, decimal multa)
        {
            return livrosDAL.VizualizarMultas(filtro, opc, vis, dias, multa);
        }

        public string BuscarMultaFixa()
        {
            return livrosDAL.BuscarMultaFixa();
        }
    }
}
