using BLL;
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

namespace GUI.ArquivosMortos.Alunos
{
    public partial class frmAlunosMorto : Form
    {

        AlunoFuncionarioMortoBLL alunosMortoBLL = new AlunoFuncionarioMortoBLL();

        AlunosBLL alunosBLL = new AlunosBLL();

        AlunosInformation aluno;

        FuncionarioInformation funcionario;

        FuncionarioBLL FuncionarioBLL = new FuncionarioBLL();

        int 
            ensino = 0,
            vis = 1;

        bool inicio = true;

        bool modoAluno = true;

        public frmAlunosMorto()
        {
            InitializeComponent();
        }

        private void FrmAlunosMorto_Load(object sender, EventArgs e)
        {
            cbxEnsino.SelectedIndex = 2;
            cbxFiltro.SelectedIndex = 1;
            inicio = false;
        }

        void AtualizaGrid()
        {
            string erro = "Erro Não Esperado!";
            try
            {
                if (modoAluno)
                {
                    dgvLeitores.DataSource = null;
                    dgvLeitores.DataSource = alunosMortoBLL.ListarAlunos(ensino, vis, txtFiltro.Text, modoAluno);
                    dgvLeitores.Columns[10].Visible = true;

                    if(cbxEnsino.SelectedIndex != 2) dgvLeitores.Columns[10].Visible = false;
                    else dgvLeitores.Columns[10].Visible = true;

                    dgvLeitores.Columns[0].Width = 50;
                    dgvLeitores.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    dgvLeitores.Columns[8].Width = 60;
                    dgvLeitores.Columns[10].Width = 40;
                }
                else
                {
                    dgvLeitores.DataSource = null;
                    dgvLeitores.DataSource = alunosMortoBLL.ListarAlunos(ensino, vis, txtFiltro.Text, modoAluno);
                }

                ConfiguracoesBLL configuracoesBLL = new ConfiguracoesBLL();
                float[] tam = configuracoesBLL.BuscarFonte();

                dgvLeitores.RowsDefaultCellStyle.Font = new Font("Segoe UI", tam[0], GraphicsUnit.Pixel);

                dgvLeitores.RowTemplate.Height = (int)tam[1];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, erro, MessageBoxButtons.OK, MessageBoxIcon.Error);
                erro = "Erro Não Esperado!";
            }
            }

        private void DgvLeitores_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (modoAluno)
                {
                    lblRm.Text = dgvLeitores[0, dgvLeitores.CurrentRow.Index].Value.ToString();
                    lblNome.Text = dgvLeitores[1, dgvLeitores.CurrentRow.Index].Value.ToString();
                    lblCelular.Text = dgvLeitores[2, dgvLeitores.CurrentRow.Index].Value.ToString();
                    lblTelefone.Text = dgvLeitores[3, dgvLeitores.CurrentRow.Index].Value.ToString();
                    lblEmail1.Text = dgvLeitores[4, dgvLeitores.CurrentRow.Index].Value.ToString();
                    lblEmail2.Text = dgvLeitores[5, dgvLeitores.CurrentRow.Index].Value.ToString();
                    lblConfeccao.Text = dgvLeitores[6, dgvLeitores.CurrentRow.Index].Value.ToString();
                    lblCurso.Text = dgvLeitores[7, dgvLeitores.CurrentRow.Index].Value.ToString();
                    if (Convert.ToBoolean(dgvLeitores[8, dgvLeitores.CurrentRow.Index].Value)) lblLeitorEspecial.Text = "Sim";
                    else lblLeitorEspecial.Text = "Não";
                    lblExclusao.Text = Convert.ToDateTime(dgvLeitores[9, dgvLeitores.CurrentRow.Index].Value).ToShortDateString();
                    if (Convert.ToBoolean(dgvLeitores[10, dgvLeitores.CurrentRow.Index].Value)) lblEnsino.Text = "Técnico";
                    else lblEnsino.Text = "Médio";
                }else
                {
                    lblNomeFuncionario.Text = dgvLeitores[0, dgvLeitores.CurrentRow.Index].Value.ToString();
                    lblFuncao.Text = dgvLeitores[1, dgvLeitores.CurrentRow.Index].Value.ToString();
                    lblTelefoneFuncionario.Text = dgvLeitores[2, dgvLeitores.CurrentRow.Index].Value.ToString();
                    lblCelularFuncionario.Text = dgvLeitores[3, dgvLeitores.CurrentRow.Index].Value.ToString();
                    lblEmailFuncionario.Text = dgvLeitores[4, dgvLeitores.CurrentRow.Index].Value.ToString();
                    lblExcluidoEm.Text = Convert.ToDateTime(dgvLeitores[5, dgvLeitores.CurrentRow.Index].Value).ToShortDateString();
                }
            }
            catch
            {
                Limpar();
            }
        }

        private void BtnRecuperarPainel_Click(object sender, EventArgs e)
        {
            string erro = "Erro Não Previsto!";
            try
            {
                if (modoAluno)
                {
                    if (dgvLeitores.Rows.Count == 0)
                    {
                        erro = "Lista Vazia!";
                        throw new Exception("Não há alunos para serem restaurados!");
                    }

                    if (lblRm.Text == "")
                    {
                        erro = "Nenhum Aluno Selecionado!";
                        throw new Exception("Selecione um aluno para restaurar!");
                    }

                    pnlRecuperar.Visible = true;
                    lblRecuperacaoRM.Text = lblRm.Text;
                    txtRecuperarNome.Text = lblNome.Text;
                    txtRecuperarCelular.Text = lblCelular.Text;
                    txtRecuperarTelefone.Text = lblTelefone.Text;
                    txtRecuperarEmail1.Text = lblEmail1.Text;
                    txtRecuperarEmail2.Text = lblEmail2.Text;
                    cbxRecuperarCurso.Text = lblCurso.Text;
                    txtRecuperarConfeccao.Text = lblConfeccao.Text;
                    lblLeitorStatus.Text = lblLeitorEspecial.Text;

                    if (lblEnsino.Text == "Médio") radMedio.Checked = true;
                    else radTecnico.Checked = true;
                }else
                {
                    if (dgvLeitores.Rows.Count == 0)
                    {
                        erro = "Lista Vazia!";
                        throw new Exception("Não há funcionários para serem restaurados!");
                    }

                    if (lblNomeFuncionario.Text == "")
                    {
                        erro = "Funcionário Não Selecionado!";
                        throw new Exception("Selecione um aluno para restaurar!");
                    }
                    pnlFuncionarios.Visible = true;
                    txtNomeFuncionario.Text = lblNomeFuncionario.Text;
                    txtCelularFuncionario.Text = lblCelularFuncionario.Text;
                    txtTelefoneFuncionario.Text = lblTelefoneFuncionario.Text;
                    txtFuncao.Text = lblFuncao.Text;
                    txtEmail.Text = lblEmailFuncionario.Text;
                }

                pnlLeitores.Enabled = false;
                pnlSuperior.Enabled = false;
                dgvLeitores.Enabled = false;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, erro, MessageBoxButtons.OK, MessageBoxIcon.Error);
                erro = "Erro Não Previsto!";
            }

        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            pnlRecuperar.Visible = false;
            pnlLeitores.Enabled = true;
            pnlSuperior.Enabled = true;
            dgvLeitores.Enabled = true;
        }

        private void CbxRecuperarModulo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string erro = "Erro Não Previsto!";
            try
            {
                int valor = Convert.ToInt32(cbxRecuperarModulo.Text);
                DateTime data = DateTime.Now;

                lblRecuperarTermino.Text = alunosBLL.CalcularTermino(valor, data, radTecnico.Checked, ref erro);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, erro, MessageBoxButtons.OK, MessageBoxIcon.Error);
                erro = "Erro Não Previsto!";
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string erro = "Erro Não Previsto!";
            try
            {
                if (cbxRecuperarModulo.Text == "")
                {
                    erro = "Módulo Não Definido!";
                    throw new Exception("É preciso definir o módulo do aluno!");
                }

                aluno = new AlunosInformation(txtRecuperarNome.Text,
                                                lblRecuperacaoRM.Text,
                                                txtRecuperarCelular.Text,
                                                txtRecuperarTelefone.Text,
                                                txtRecuperarEmail1.Text,
                                                txtRecuperarEmail2.Text,
                                                Convert.ToDateTime(txtRecuperarConfeccao.Text),
                                                lblRecuperarTermino.Text,
                                                Convert.ToInt32(cbxRecuperarModulo.Text),
                                                cbxRecuperarCurso.Text,
                                                radTecnico.Checked);
                if (MessageBox.Show("Deseja restaurar o aluno " + txtRecuperarNome.Text + "?", "Restaurar Aluno!", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    alunosBLL.IncluirAluno(aluno, ref erro);
                    alunosMortoBLL.ExcluirAlunoMorto(aluno);

                    if (lblLeitorStatus.Text == "Sim") alunosBLL.TornarEspecial(lblRecuperacaoRM.Text);

                    MessageBox.Show("O(A) aluno(a) " + aluno.Nome + " foi restaurado com sucesso!", "Aluno cadastrado!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    AtualizaGrid();
                    BtnCancelar_Click(null, null);
                    Limpar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, erro, MessageBoxButtons.OK, MessageBoxIcon.Error);
                erro = "Erro Não Previsto!";
            }
        }

        private void CbxFiltro_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!inicio)
            {
                if (cbxFiltro.SelectedIndex == 0) vis = 0;
                else if (cbxFiltro.SelectedIndex == 1) vis = 1;
                else if (cbxFiltro.SelectedIndex == 2) vis = 2;
                else if (cbxFiltro.SelectedIndex == 3) vis = 3;
                else vis = 4;

                AtualizaGrid();
            }
        }

        private void TxtFiltro_TextChanged(object sender, EventArgs e)
        {
            AtualizaGrid();
        }

        private void BtnProfessor_Click(object sender, EventArgs e)
        {
            string erro = "Erro Não Previsto!";
            try
            {
                modoAluno = false;

                btnAluno.BackColor = Color.FromArgb(53, 56, 61);
                btnProfessor.BackColor = Color.FromArgb(63, 66, 71);
                gbxAlunos.Visible = false;
                gbxProfessor.Visible = true;
                cbxEnsino.Visible = false;

                cbxFiltro.Items.Clear();
                cbxFiltro.Items.AddRange(new object[]{
                    "Nome",
                    "Telefone/Celular",
                    "Email",
                    "Função",
                });
                cbxFiltro.SelectedIndex = 0;

                txtFiltro.WaterMark = "Procurar por funcionário";
                AtualizaGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, erro, MessageBoxButtons.OK, MessageBoxIcon.Error);
                erro = "Erro Não Previsto!";
            }
        }

        private void BtnCancelarFuncionario_Click(object sender, EventArgs e)
        {
            pnlFuncionarios.Visible = false;
            pnlLeitores.Enabled = true;
            pnlSuperior.Enabled = true;
            dgvLeitores.Enabled = true;
        }

        private void BtnRecuperarFuncionario_Click(object sender, EventArgs e)
        {
            string erro = "Erro Não Previsto!";
            try
            {


                funcionario = new FuncionarioInformation(lblNomeFuncionario.Text,
                                                         lblTelefoneFuncionario.Text,
                                                         lblCelularFuncionario.Text,
                                                         lblEmailFuncionario.Text,
                                                         lblFuncao.Text);

                if (MessageBox.Show("Deseja restaurar este funcionário?", "Restaurar Funcionário!", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    FuncionarioBLL.IncluirFuncionario(funcionario, ref erro);
                    alunosMortoBLL.ExcluirFuncionarioMorto(funcionario);
                    MessageBox.Show("O(A) aluno(a) " + funcionario.Nome + " foi restaurado com sucesso!", "Funcionário Recuperado!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    AtualizaGrid();
                    BtnCancelarFuncionario_Click(null, null);
                    Limpar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, erro, MessageBoxButtons.OK, MessageBoxIcon.Error);
                erro = "Erro Não Previsto!";
            }
        }

        void Limpar()
        {
            lblRm.Text = "";
            lblNome.Text = "";
            lblCelular.Text = "";
            lblTelefone.Text = "";
            lblEmail1.Text = "";
            lblEmail2.Text = "";
            lblCurso.Text = "";
            lblConfeccao.Text = "";
            lblLeitorEspecial.Text = "";
            lblExclusao.Text = "";
            lblLeitorEspecial.Text = "";

            lblNomeFuncionario.Text = "";
            lblFuncao.Text = "";
            lblTelefoneFuncionario.Text = "";
            lblCelularFuncionario.Text = "";
            lblEmailFuncionario.Text = "";
            lblExcluidoEm.Text = "";
        }

        private void BtnAluno_Click(object sender, EventArgs e)
        {
            string erro = "Erro Não Previsto!";
            try
            {
                modoAluno = true;

                btnProfessor.BackColor = Color.FromArgb(53, 56, 61);
                btnAluno.BackColor = Color.FromArgb(63, 66, 71);
                gbxAlunos.Visible = true;
                gbxProfessor.Visible = false;
                cbxEnsino.Visible = true;

                cbxFiltro.Items.Clear();
                this.cbxFiltro.Items.AddRange(new object[] {
                "RM",
                "Nome",
                "Telefone/Celular",
                "Email",
                "Curso"});
                cbxFiltro.SelectedIndex = 1;

                txtFiltro.WaterMark = "Procurar por aluno";

                AtualizaGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, erro, MessageBoxButtons.OK, MessageBoxIcon.Error);
                erro = "Erro Não Previsto!";
            }
        }

        private void CbxCurso_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxRecuperarCurso.SelectedIndex != 6)
            {
                cbxRecuperarModulo.Items.Clear();
                this.cbxRecuperarModulo.Items.AddRange(new object[] {
                "0",
                "1",
                "2",
                "3" });
            }
            else if (cbxRecuperarCurso.SelectedIndex == 6)
            {
                cbxRecuperarModulo.Items.Clear();
                this.cbxRecuperarModulo.Items.AddRange(new object[] {
                "0",
                "1",
                "2"});
            }
        }

        private void RadTecnico_CheckedChanged(object sender, EventArgs e)
        {
            CbxRecuperarModulo_SelectedIndexChanged(null, null);
        }

        private void RadMedio_CheckedChanged(object sender, EventArgs e)
        {
            CbxRecuperarModulo_SelectedIndexChanged(null, null);
        }

        private void CbxEnsino_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxEnsino.SelectedIndex == 0) ensino = 0;
            else if (cbxEnsino.SelectedIndex == 1) ensino = 1;
            else ensino = 2;

            AtualizaGrid();
        }
    }
}