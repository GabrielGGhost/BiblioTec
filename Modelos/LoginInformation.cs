using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos
{
    public class LoginInformation
    {
        string _usuario;
        string _senha;
        string _novoUsuario;
        string _novaSenha;
        string _repetirNovaSenha;
        string _novoPin;
        string _repetirNovoPin;
        string _nomeCompleto;

        public string Usuario { get => _usuario; set => _usuario = value; }
        public string Senha { get => _senha; set => _senha = value; }
        public string NovoUsuario { get => _novoUsuario; set => _novoUsuario = value; }
        public string NovaSenha { get => _novaSenha; set => _novaSenha = value; }
        public string RepetirNovaSenha { get => _repetirNovaSenha; set => _repetirNovaSenha = value; }
        public string NovoPin { get => _novoPin; set => _novoPin = value; }
        public string RepetirNovoPin { get => _repetirNovoPin; set => _repetirNovoPin = value; }
        public string NomeCompleto { get => _nomeCompleto; set => _nomeCompleto = value; }
    }
}
