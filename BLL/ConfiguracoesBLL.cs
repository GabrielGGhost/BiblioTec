using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class ConfiguracoesBLL
    {
        ConfiguracoesDAL configuracoesDAL = new ConfiguracoesDAL();

        public void DefinirMulta(decimal multa)
        {
            configuracoesDAL.DefinirMulta(multa);
        }

        public void AtualizarAvancoModulo(bool status)
        {
            configuracoesDAL.AtualizarAvancoModulo(status);
        }

        public void AtualizarAvancoAno(bool status)
        {
            configuracoesDAL.AtualizarAvancoAno(status);

        }

        public static bool BuscarLogin()
        {
            return ConfiguracoesDAL.BuscarLogin();
        }

        public void AtualizarExcluirFinalizados(bool status)
        {
            configuracoesDAL.AtualizarExcluirFinalizados(status);
        }

        public void AtualizarExcluirAlunosMortoAtivo(bool status)
        {
            configuracoesDAL.AtualizarExcluirAlunosMortoAtivo(status);
        }

        public void AtualizarMesesAlunoMorto(int meses)
        {
            configuracoesDAL.AtualizarExcluirAlunosMortoAtivo(meses);
        }

        public void ExcluirEmprestimosAlunosMeses(int meses)
        {
            configuracoesDAL.ExcluirEmprestimosAlunosMeses(meses);
        }

        public void AtualizarExcluirEmprestimosAlunosMortoAtivo(bool status)
        {
            configuracoesDAL.AtualizarExcluirEmprestimosAlunosMortoAtivo(status);

        }

        public void AtualizarMaxLivroAtivo(bool status)
        {
            configuracoesDAL.AtualizarMaxLivroAtivo(status);
        }

        public void MaxLivrosQtd(int qtd)
        {
            configuracoesDAL.MaxLivrosQtd(qtd);
        }

        public void ExcluirEmprestimosProfessoresAtivos(bool status)
        {
            configuracoesDAL.ExcluirEmprestimosProfessoresAtivos(status);
        }

        public string BuscarDiretorio()
        {
            return configuracoesDAL.BuscarDiretorio();
        }

        public void ExcluirEmprestimosProfessoresMeses(int meses)
        {
            configuracoesDAL.ExcluirEmprestimosProfessoresMeses(meses);
        }

        public void MaxLivrosQtdFuncionario(int qtd)
        {
            configuracoesDAL.MaxLivrosQtdFuncionario(qtd);
        }

        public void MaxLivroFuncionariosAtivo(bool status)
        {
            configuracoesDAL.MaxLivroFuncionariosAtivo(status);
        }

        public void BackupAtivo(bool status)
        {
            configuracoesDAL.BackupAtivo(status);

        }

        public void ExcluirMultasAtivo(bool status)
        {
            configuracoesDAL.ExcluirMultasAtivo(status);
        }

        public void ExcluirMultasMeses(int meses)
        {
            configuracoesDAL.ExcluirMultasMeses(meses);
        }

        public float[] BuscarFonte()
        {
            return configuracoesDAL.BuscarFonte();
        }

        public void ExcluirDataPassadasAtivo(bool status)
        {
            configuracoesDAL.ExcluirDataPassadasAtivo(status);
        }

        public bool ValidarSenha(string senhaDigitada)
        {
            return configuracoesDAL.ValidarSenha(senhaDigitada);
        }

        public string BuscarSenhaPrinciapal()
        {
            return configuracoesDAL.BuscarSenhaPrinciapal();
        }

        public void MudarSenhaPrincipal(string senha, string repetirSenha, ref string erro)
        {
            if(senha.Trim() == "")
            {
                erro = "Senha Vazia!";
                throw new Exception("É preciso informar uma nova senha!");
            }

            if(repetirSenha.Trim() == "")
            {
                erro = "Senha Inválida!";
                throw new Exception("É necessário confirmar a senha");
            }

            if(senha != repetirSenha)
            {
                erro = "Senhas Incompatíveis!";
                throw new Exception("As senhas digitadas devem se corresponder!");
            }

            configuracoesDAL.MudarSenhaPrincipal(senha);
        }

        public void AtrasadosAtivo(bool status)
        {
            configuracoesDAL.AtrasadosAtivo(status);
        }

        public void ChartAtivo(bool status)
        {
            configuracoesDAL.ChartAtivo(status);
        }

        public void MaisSaidosAtivo(bool status)
        {
            configuracoesDAL.MaisSaidosAtivo(status);
        }

        public void LoginAtivo(bool status)
        {
            configuracoesDAL.LoginAtivo(status);
        }

        public object[] CarregarDados()
        {
            return configuracoesDAL.CarregarDados();
        }

        public void DefinirDiretorio(string diretorio)
        {
            configuracoesDAL.DefinirDiretorio(diretorio);
        }

        public void EmailAtivo(bool status)
        {
            configuracoesDAL.EmailAtivo(status);
        }

        public void DefinirMensagemAutomatica(string p1, string p2, string p3, Modelos.EmailInformation email)
        {
            configuracoesDAL.DefinirMensagemAutomatica(p1, p2, p3, email);
        }

        public bool VerificarPermissao()
        {
            return configuracoesDAL.VerificarPermissao();
        }

        public void DefinirTamanho(int tam)
        {
            configuracoesDAL.DefinirTamanho(tam);
        }

        public object[] CarregarDadosEmail()
        {
            return configuracoesDAL.CarregarDadosEmail();
        }

        public void DefinirTamanhoLinha(int tam)
        {
            configuracoesDAL.DefinirTamanhoLinha(tam);
        }
    }
}
