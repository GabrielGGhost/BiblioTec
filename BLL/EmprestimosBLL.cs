using DAL;
using Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class EmprestimosBLL
    {
        EmprestimosDAL emprestimosDAL = new EmprestimosDAL();


        public object ListarLeitores(bool aluno)
        {
            return emprestimosDAL.ListarLeitores(aluno);
        }

        public object CarregarLivros(int opc, int vis, string txtFiltro, string cbxFiltro, int opcFiltro)
        {
            return emprestimosDAL.CarregarLivros(opc, vis, txtFiltro, cbxFiltro, opcFiltro);
        }

        public DateTime CalcularDataDevolucao(DateTime data)
        {
            return emprestimosDAL.CalcularDataDevolucao(data);
        }

        public void RealizarEmprestimo(EmprestimoInformation emprestimo, bool aluno, bool ficha, ref string erro)
        {
            if ((Convert.ToDateTime(emprestimo.Devolucao) - Convert.ToDateTime(emprestimo.Retirada)).Days < 7)
            {
                erro = "Tempo Insuficiente!";
                throw new Exception("É preciso selecionar um dia igual ou superior a 7 dias!");
            }

            emprestimosDAL.RealizarEmprestimo(emprestimo, aluno, ficha, ref erro);
        }

        public bool BuscarPermissaoMaxLivros()
        {
            return emprestimosDAL.BuscarPermissaoMaxLivros();
        }

        public string BuscarMaxLivros()
        {
            return emprestimosDAL.BuscarMaxLivros();
        }

        public object ListarAlunosDevedores()
        {
            return emprestimosDAL.ListarAlunosDevedores();
        }

        public object[] BuscarDadosEmprestados(string id_Livro, bool aluno)
        {
            return emprestimosDAL.BuscarDadosEmprestados(id_Livro, aluno);
        }

        public void DevolverLivro(int id_leitor, int id_livro, bool aluno, ref string erro)
        {
            if(id_livro == 0)
            {
                erro = "Nenhum Livro Selecionado!";
                throw new Exception("É preciso selecionar um livro antes de devolver!");
            }

            if (id_leitor == 0)
            {
                erro = "Nenhum Leitor Selecionado!";
                throw new Exception("É preciso selecionar um leitor antes de devolver!");
            }
            emprestimosDAL.DevolverLivro(id_leitor, id_livro, aluno, ref erro);
        }

        public void RenovarLivro(int id_leitor, int id_livro, bool aluno, ref string erro, string retirada, string devolucao)
        {

            if ((Convert.ToDateTime(devolucao) - Convert.ToDateTime(retirada)).Days < 7)
            {
                erro = "Tempo Insuficiente!";
                throw new Exception("É preciso selecionar um dia igual ou superior a 7 dias!");
            }

            if (id_livro == 0)
            {
                erro = "Nenhum Livro Selecionado!";
                throw new Exception("É preciso selecionar um livro antes de devolver!");
            }

            if (id_leitor == 0)
            {
                erro = "Nenhum Leitor Selecionado!";
                throw new Exception("É preciso selecionar um leitor antes de devolver!");
            }
            emprestimosDAL.RenovarLivro(id_leitor, id_livro, aluno, retirada, devolucao);
        }

        public bool VerificarExistencia(bool aluno, string str, ref string erro)
        {
            return emprestimosDAL.VerificarExistencia(aluno, str, ref erro);
        }

        public void AtualizarMulta(decimal valor, string idLivro)
        {
            emprestimosDAL.AtualizarMulta(valor, idLivro);
        }

        public object ListarFuncionariosDevedores()
        {
            return emprestimosDAL.ListarFuncionariosDevedores();
        }

        public string CarregarEmprestados(string id)
        {
            return emprestimosDAL.CarregarEmprestados(id);
        }

        public string BuscarMaxLivrosFuncionario()
        {
            return emprestimosDAL.BuscarMaxLivrosFuncionario();
        }

        public bool BuscarPermissaoMaxLivrosFuncionarios()
        {
            return emprestimosDAL.BuscarPermissaoMaxLivrosFuncionarios();

        }

        public string CarregarEmprestadosFunc(string id)
        {
            return emprestimosDAL.CarregarEmprestadosFunc(id);
        }

        public decimal BuscarMulta(string id)
        {
            return emprestimosDAL.BuscarMulta(id);
        }

        public void ExcluirEmprestimo(EmprestimoInformation emprestimo, bool aluno)
        {
            emprestimosDAL.ExcluirEmprestimo(emprestimo, aluno);
        }

        public bool VerificarDisponibilidade(string idLivro)
        {
            return emprestimosDAL.VerificarDisponibilidade(idLivro);
        }
    }
}
