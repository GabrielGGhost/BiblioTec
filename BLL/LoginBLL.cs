using DAL;
using MetroFramework.Controls;
using Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class LoginBLL
    {
        LoginDAL loginDAL = new LoginDAL();
        public bool ValidarSenhaPrincipal(string senhaPrincipal)
        {
            return loginDAL.ValidarSenhaPrincipal(senhaPrincipal);
        }

        public void CadastrarNovoUsuario(LoginInformation login, ref string erro)
        {
            if (login.NomeCompleto.Trim() == "")
            {
                erro = "Nome Inválido";
                throw new Exception("É necessário definir o Nome do Usuário!");
            }

            if (login.NovoUsuario.Trim() == "")
            {
                erro = "Usuário Inválido";
                throw new Exception("É necessário definir um usuário!");
            }

            if(login.NovoUsuario.Trim().Length < 4)
            {
                erro = "Usuário Muito Curto!";
                throw new Exception("O usuário precisa ter ao menos 4 letras!");
            }

            if(login.NovaSenha.Trim() == "")
            {
                erro = "Senha Inválida!";
                throw new Exception("É necessário definir uma senha ao usuário!");
            }
            if (login.NovaSenha.Trim().Length < 5)
            {
                erro = "Senha Muito Curta!";
                throw new Exception("A senha deve ter ao menos 5 caracteres!");
            }

            if (login.RepetirNovaSenha.Trim() == "")
            {
                erro = "Senha Não Confirmada!";
                throw new Exception("É necessário repetir a senha digitada!");
            }
            if (login.NovaSenha.Trim() != login.RepetirNovaSenha.Trim())
            {
                erro = "Senhas Não Correspondentes!";
                throw new Exception("As senhas digitadas não correspondem!");
            }

            if (login.NovoPin.Trim() == "")
            {
                erro = "Pin Inválido!";
                throw new Exception("É necessário definir um pin ao usuário!");
            }
            if (login.NovoPin.Trim().Length < 5)
            {
                erro = "Pin Muito Curto!";
                throw new Exception("O pin deve ter ao menos 5 caracteres!");
            }

            if (login.RepetirNovoPin.Trim() == "")
            {
                erro = "Pin Não Confirmado!";
                throw new Exception("É necessário repetir o pin digitado!");
            }
            if (login.NovoPin.Trim() != login.RepetirNovoPin)
            {
                erro = "Pins Não Correspondem!";
                throw new Exception("Os pins digitados não correspondem!");
            }

            loginDAL.CadastrarCliente(login, ref erro);
        }

        public bool Acessar(LoginInformation login, ref string erro)
        {
            if(login.Usuario.Trim() == "")
            {
                erro = "Usuário Vazio!";
                throw new Exception("É preciso informar o usuário!");
            }

            if (login.Senha.Trim() == "")
            {
                erro = "Senha Vazia!";
                throw new Exception("É preciso informar a senha!");
            }

            return loginDAL.Acessar(login, ref erro);
        }

        public bool VerificarPin(string usuario, string pin, ref string erro)
        {
            if(usuario == "")
            {
                erro = "Usuário Vazio!";
                throw new Exception("É preciso informar um usuário existente!");
            }

            if(pin == "")
            {
                erro = "Pin Vazio!";
                throw new Exception("É preciso informar o pin vinculado ao usuário!");
            }

            return loginDAL.VerificarPin(usuario, pin, ref erro);
        }

        public void MudarSenha(string usuario, string novaSenha, string confirmacaoSenha, ref string erro)
        {

            if (novaSenha == "")
            {
                erro = "Nova Senha Vazia!";
                throw new Exception("É preciso informar a nova senha!");
            }

            if(confirmacaoSenha == "")
            {
                erro = "Confirmação de Senha Vazia!";
                throw new Exception("É preciso repetir a nova senha!");
            }

            if (confirmacaoSenha != novaSenha)
            {
                erro = "Senhas Incompativeis!";
                throw new Exception("As senhas digitadas não se correspondem!");
            }

            loginDAL.MudarSenha(usuario, novaSenha, erro);
        }
    }
}
