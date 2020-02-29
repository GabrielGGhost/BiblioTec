using BLL;
using GUI;
using GUI.Menu_Iniciar;
using Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.Login
{
    public partial class frmLogin : Form
    {
        int opc;
        LoginBLL loginBLL = new LoginBLL();
        LoginInformation login = new LoginInformation();

        public frmLogin()
        {
            InitializeComponent();
        }

        private void BtnNovoUsuario_Click(object sender, EventArgs e)
        {
            txtUsuario.Text = "";
            txtSenha.Text = "";
            pnlCadastrarUsuario.Visible = false;
            pnlLogin.Visible = false;
            pnlConfirmar.Visible = true;
            pnlResetarSenha.Visible = false;
            txtConfirmarSenhaPrincipal.Focus();
            opc = 0;
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            txtConfirmarSenhaPrincipal.Text = "";
            pnlCadastrarUsuario.Visible = false;
            pnlConfirmar.Visible = false;
            pnlResetarSenha.Visible = false;
            pnlLogin.Visible = true;
            opc = 0;
        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnAcessarPrivilegios_Click(object sender, EventArgs e)
        {
            string erro = "Erro não previsto!";
            try
            {
                if (txtConfirmarSenhaPrincipal.Text == "")
                {
                    erro = "Senha Não Digitada!";
                    throw new Exception("Informe uma senha!");
                }
                if (loginBLL.ValidarSenhaPrincipal(txtConfirmarSenhaPrincipal.Text))
                {
                    if (opc == 0)
                    {
                        txtConfirmarSenhaPrincipal.Text = "";
                        pnlCadastrarUsuario.Visible = true;
                        pnlLogin.Visible = false;
                        pnlConfirmar.Visible = false;
                        pnlResetarSenha.Visible = false;
                        txtNomeCompleto.Focus();
                    }
                    else
                    {
                        txtConfirmarSenhaPrincipal.Text = "";
                        pnlCadastrarUsuario.Visible = false;
                        pnlLogin.Visible = false;
                        pnlConfirmar.Visible = false;
                        pnlResetarSenha.Visible = true;
                        txtUsuarioConfirmacao.Focus();
                    }
                }
                else
                {
                    erro = "Senha Principal Inválida!";
                    throw new Exception("A senha principal digitada está incorreta!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, erro, MessageBoxButtons.OK, MessageBoxIcon.Error);
                erro = "Erro não previsto!";
            }
        }


        private void BtnCancelarCadastro_Click(object sender, EventArgs e)
        {
            pnlCadastrarUsuario.Visible = false;
            pnlLogin.Visible = true;
            pnlConfirmar.Visible = false;
        }


        private void BtnCadastrar_Click(object sender, EventArgs e)
        {
            string erro = "Erro não previsto!";
            try
            {
                login.NovoUsuario = txtNovoUsuario.Text;
                login.NovaSenha = txtNovaSenha.Text;
                login.RepetirNovaSenha = txtRepetirNovaSenha.Text;
                login.NovoPin = txtNovoPin.Text;
                login.RepetirNovoPin = txtRepetirNovoPin.Text;
                login.NomeCompleto = txtNomeCompleto.Text;

                loginBLL.CadastrarNovoUsuario(login, ref erro);
                MessageBox.Show("Usuário adicionado com sucesso!", "Usuário Adicionado!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                BtnCancelarCadastro_Click(null, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, erro, MessageBoxButtons.OK, MessageBoxIcon.Error);
                erro = "Erro não previsto!";
            }
        }

        private void LblCriarNovoUsuario_Click(object sender, EventArgs e)
        {
            txtUsuario.Text = "";
            txtSenha.Text = "";
            pnlCadastrarUsuario.Visible = false;
            pnlLogin.Visible = false;
            pnlConfirmar.Visible = true;
            pnlResetarSenha.Visible = false;
            txtConfirmarSenhaPrincipal.Focus();
            opc = 1;
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            txtUsuario.Select();
        }

        private void TxtConfirmarSenhaPrincipal_KeyDown(object sender, KeyEventArgs e)
        {
            try { if (e.KeyData == Keys.Enter) BtnAcessarPrivilegios_Click(null, null); }
            catch { }
        }

        private void BtnAcessar_Click(object sender, EventArgs e)
        {
            string erro = "Erro não previsto!";
            try
            {
                login.Usuario = txtUsuario.Text;
                login.Senha = txtSenha.Text;

                if (loginBLL.Acessar(login, ref erro))
                {
                    this.Visible = false;
                    txtUsuario.Text = "";
                    txtSenha.Text = "";
                    frmMenu menu = new frmMenu();
                    menu.StartPosition = FormStartPosition.CenterScreen;
                    menu.Show();
                }
                else
                {
                    MessageBox.Show("Usuário/Senha Inválidos!", "Dados inválidos!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, erro, MessageBoxButtons.OK, MessageBoxIcon.Error);
                erro = "Erro não previsto!";
            }
        }

        private void TxtNovoUsuario_KeyDown(object sender, KeyEventArgs e)
        {
            try { if (e.KeyData == Keys.Enter) txtNovaSenha.Focus(); } catch { }
        }

        private void TxtNovaSenha_KeyDown(object sender, KeyEventArgs e)
        {
            try { if (e.KeyData == Keys.Enter) txtRepetirNovaSenha.Focus(); }
            catch { }
        }

        private void TxtRepetirNovaSenha_KeyDown(object sender, KeyEventArgs e)
        {
            try { if (e.KeyData == Keys.Enter) txtNovoPin.Focus(); }
            catch { }
        }

        private void TxtNovoPin_KeyDown(object sender, KeyEventArgs e)
        {
            try { if (e.KeyData == Keys.Enter) txtRepetirNovoPin.Focus(); }
            catch { }
        }

        private void TxtRepetirNovoPin_KeyDown(object sender, KeyEventArgs e)
        {
            try { if (e.KeyData == Keys.Enter) BtnCadastrar_Click(null, null); }
            catch { }
        }

        private void BtnCancelarConfirmacao_Click(object sender, EventArgs e)
        {
            BtnCancelar_Click(null, null);
        }

        private void BtnAvancar_Click(object sender, EventArgs e)
        {
            string erro = "Erro Não Previsto!";
            try
            {
                if (loginBLL.VerificarPin(txtUsuarioConfirmacao.Text, txtPinConfirmar.Text, ref erro))
                {
                    txtPinConfirmar.Text = "";
                    pnlMudarSenha.Visible = true;
                    pnlAvancar.Visible = false;
                    txtNovaSenhaConfirmacao.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, erro, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnMudarSenha_Click(object sender, EventArgs e)
        {
            string erro = "Erro Não Previsto!";
            try
            {
                loginBLL.MudarSenha(txtUsuarioConfirmacao.Text, txtNovaSenhaConfirmacao.Text, txtRepetirSenhaConfirmacao.Text, ref erro);
                MessageBox.Show("A senha foi alterada com sucesso!", "Senha Alterada!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                txtNovaSenhaConfirmacao.Text = "";
                txtRepetirSenhaConfirmacao.Text = "";
                BtnCancelar_Click(null, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, erro, MessageBoxButtons.OK, MessageBoxIcon.Error);
                erro = "Erro Não Previsto!";
            }
        }

        private void BtnCancelarMudarSenha_Click(object sender, EventArgs e)
        {
            BtnCancelar_Click(null, null);
            pnlAvancar.Visible = true;
            pnlMudarSenha.Visible = false;
            txtUsuarioConfirmacao.Text = "";
        }


        private void TxtNomeCompleto_KeyDown(object sender, KeyEventArgs e)
        {
            try { if (e.KeyData == Keys.Enter) txtNovoUsuario.Focus(); }
            catch { }
        }

        private void TxtSenha_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter) BtnAcessar_Click(null, null);
        }

        private void TxtUsuario_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter) txtSenha.Focus();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            txtUsuario.Focus();
        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void TxtUsuarioConfirmacao_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter) txtPinConfirmar.Focus();
        }

        private void TxtPinConfirmar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter) BtnAvancar_Click(null, null);
        }

        private void TxtNovaSenhaConfirmacao_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter) txtRepetirSenhaConfirmacao.Focus();
        }

        private void TxtRepetirSenhaConfirmacao_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter) BtnMudarSenha_Click(null, null);
        }

        private void LblMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }
    }
}
    
