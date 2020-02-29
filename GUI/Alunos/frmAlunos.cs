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

namespace GUI.Alunos
{
    public partial class frmAlunos : Form
    {
        AlunosBLL alunosBLL = new AlunosBLL();

        FuncionarioBLL funcionarioBLL = new FuncionarioBLL();

        AlunosInformation aluno;

        FuncionarioInformation funcionario;

        bool
            hidePainel = true,
            inicio = true;

        public frmAlunos()
        {
            InitializeComponent();
        }

        int
            opc = 0,
            ensino = 3;

        bool modoAluno = true;

        private void FrmAlunos_Load(object sender, EventArgs e)
        {
            cbxEnsino.SelectedIndex = 2;
            cbxFiltro.SelectedIndex = 0;
            lblConfeccao.Text = DateTime.Now.ToShortDateString();
            inicio = false;
            txtRM.Select();
        }

        private void BtnAbir_Click(object sender, EventArgs e)
        {
            trmSlidePainel.Start();
            if (hidePainel) btnAbir.Text = "Abrir Painel";
            else btnAbir.Text = "Fechar Painel";
        }

        void AtualizaGrid()
        {
            string erro = "Erro Não Previsto!";
            try
            {
                if (modoAluno)
                {
                    pnlBotoesEspeciais.Visible = true;
                    dgvLeitores.DataSource = null;
                    dgvLeitores.DataSource = alunosBLL.CarregarAlunos(opc, txtFiltro.Text, ensino);
                    dgvLeitores.Columns[0].Visible = false;

                    dgvLeitores.Columns[1].Width = 30;
                    dgvLeitores.Columns[7].Width = 60;
                    dgvLeitores.Columns[9].Width = 30;
                    dgvLeitores.Columns[9].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    dgvLeitores.Columns[10].Width = 50;
                    dgvLeitores.Columns[11].Width = 40;

                    if (cbxEnsino.SelectedIndex != 2) dgvLeitores.Columns[11].Visible = false;
                    else dgvLeitores.Columns[11].Visible = true;
                }
                else if (!modoAluno)
                {
                    pnlBotoesEspeciais.Visible = false;

                    dgvLeitores.DataSource = null;
                    dgvLeitores.DataSource = alunosBLL.CarregarFuncionarios(opc, txtFiltro.Text);
                    dgvLeitores.Columns[0].Visible = false;

                    dgvLeitores.Columns[2].Width = 100;
                    dgvLeitores.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                }

                ConfiguracoesBLL configuracoesBLL = new ConfiguracoesBLL();
                float[] tam = configuracoesBLL.BuscarFonte();

                dgvLeitores.RowsDefaultCellStyle.Font = new Font("Segoe UI", tam[0], GraphicsUnit.Pixel);
                dgvLivrosLidos.RowsDefaultCellStyle.Font = new Font("Segoe UI", tam[0], GraphicsUnit.Pixel);

                dgvLeitores.RowTemplate.Height = (int)tam[1];
                dgvLivrosLidos.RowTemplate.Height = (int)tam[1];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, erro, MessageBoxButtons.OK, MessageBoxIcon.Error);
                erro = "Erro Não Previsto!";
            }
        }

        private void CbxModulo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string erro = "Erro Não Previsto!";
            try
            {
                if (cbxModulo.SelectedIndex != -1)
                {
                    int valor = Convert.ToInt32(cbxModulo.Text);
                    DateTime data = DateTime.Now;

                    lblTermino.Text = alunosBLL.CalcularTermino(valor, data, radTecnico.Checked, ref erro);
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
            string erro = "Erro Não Previsto!";
            try
            {
                if (!inicio)
                {
                    if (cbxFiltro.SelectedIndex == 0) opc = 0;
                    else if (cbxFiltro.SelectedIndex == 1) opc = 1;
                    else if (cbxFiltro.SelectedIndex == 2) opc = 2;
                    else if (cbxFiltro.SelectedIndex == 3) opc = 3;
                    else if (cbxFiltro.SelectedIndex == 4) opc = 4;
                    else if (cbxFiltro.SelectedIndex == 5) opc = 5;

                    AtualizaGrid();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, erro, MessageBoxButtons.OK, MessageBoxIcon.Error);
                erro = "Erro Não Previsto!";
            }
        }

        private void BtnIncluir_Click(object sender, EventArgs e)
        {
            string erro = "Erro Não Previsto!";
            try
            {
                if (modoAluno)
                {
                    if (lblId.Text != "0")
                    {
                        erro = "Aluno Selecionado!!";
                        throw new Exception("É preciso clicar em 'Novo' para adicionar um novo aluno!");
                    }

                    if (cbxModulo.Text == "")
                    {
                        erro = "Módulo Não Definido!";
                        throw new Exception("É preciso definir o módulo do aluno!");
                    }

                    bool tecnico;
                    if (radMedio.Checked) tecnico = false;
                    else tecnico = true;

                    aluno = new AlunosInformation(txtNome.Text,
                                                    txtRM.Text,
                                                    txtCelular.Text,
                                                    txtTelefone.Text,
                                                    txtEmail1.Text,
                                                    txtEmail2.Text,
                                                    Convert.ToDateTime(lblConfeccao.Text),
                                                    lblTermino.Text,
                                                    Convert.ToInt32(cbxModulo.Text),
                                                    cbxCurso.Text,
                                                    tecnico);

                    alunosBLL.IncluirAluno(aluno, ref erro);
                    MessageBox.Show("O(A) aluno(a) " + aluno.Nome + " foi incluído(a) com sucesso!", "Aluno cadastrado!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    AtualizaGrid();
                    BtnLimpar_Click(null, null);
                }
                else
                {
                    if (lblId.Text != "0")
                    {
                        erro = "Funcionário Selecionado!!";
                        throw new Exception("É preciso clicar em 'Novo' para adicionar um novo funcionário!");
                    }

                    if (txtFuncao.Text == "")
                    {
                        erro = "Função Não Definida!";
                        throw new Exception("É preciso definir uma função ao professor!");
                    }

                    funcionario = new FuncionarioInformation(txtNomeFuncionario.Text,
                                                            txtTelefoneFuncionario.Text,
                                                            txtCelularFuncionario.Text,
                                                            txtEmailFuncionario.Text,
                                                            txtFuncao.Text);

                    funcionarioBLL.IncluirFuncionario(funcionario, ref erro);
                    MessageBox.Show("O(A) funcionário(a) " + funcionario.Nome + " foi incluído(a) com sucesso!", "Funcionário cadastrado!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    AtualizaGrid();
                    BtnLimpar_Click(null, null);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, erro, MessageBoxButtons.OK, MessageBoxIcon.Error);
                erro = "Erro Não Previsto!";
            }
        }

        private void TxtFiltro_TextChanged(object sender, EventArgs e)
        {
            AtualizaGrid();
        }

        private void BtnAlterar_Click(object sender, EventArgs e)
        {
            string erro = "Erro Não Previsto!";
            try
            {
                if (modoAluno)
                {
                    if (lblId.Text == "0")
                    {
                        erro = "Nenhum Aluno Selecionado!";
                        throw new Exception("Nenhum aluno selecionado para a alteração!");
                    }

                    bool tecnico;
                    if (radMedio.Checked) tecnico = false;
                    else tecnico = true;

                    if (MessageBox.Show("Alterar as informações do(a) aluno(a) " + txtNome.Text + "?", "Alterar Aluno!", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                    {
                        aluno = new AlunosInformation(lblId.Text,
                                                        txtNome.Text,
                                                        txtRM.Text,
                                                        txtCelular.Text,
                                                        txtTelefone.Text,
                                                        txtEmail1.Text,
                                                        txtEmail2.Text,
                                                        Convert.ToDateTime(lblConfeccao.Text),
                                                        lblTermino.Text,
                                                        Convert.ToInt32(cbxModulo.Text),
                                                        cbxCurso.Text,
                                                        tecnico);

                        alunosBLL.AlterarAluno(aluno, ref erro);
                        MessageBox.Show("O(A) aluno(a) " + aluno.Nome + " foi alterado(a) com sucesso!", "Aluno(a) Alterado(a)!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        AtualizaGrid();
                        BtnLimpar_Click(null, null);
                    }
                }
                else
                {
                    if (lblIdFuncionario.Text == "0")
                    {
                        erro = "Nenhum Funcionário Selecionado!";
                        throw new Exception("Nenhum Funcionário selecionado para a alteração!");
                    }

                    if (MessageBox.Show("Alterar as informações do(a) funcionário(a) " + txtNomeFuncionario.Text + "?", "Alterar Funcionário!", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                    {
                        funcionario = new FuncionarioInformation(lblIdFuncionario.Text,
                                                        txtNomeFuncionario.Text,
                                                        txtTelefoneFuncionario.Text,
                                                        txtCelularFuncionario.Text,
                                                        txtEmailFuncionario.Text,
                                                        txtFuncao.Text);

                        funcionarioBLL.AlterarFuncionario(funcionario, ref erro);
                        MessageBox.Show("O(A) funcionário(a) " + funcionario.Nome + " foi alterado(a) com sucesso!", "Funcionário Alterado!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        AtualizaGrid();
                        BtnLimpar_Click(null, null);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, erro, MessageBoxButtons.OK, MessageBoxIcon.Error);
                erro = "Erro Não Previsto!";
            }
        }

        private void DgvAlunos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (modoAluno)
            {
                try
                {
                    lblId.Text = dgvLeitores[0, dgvLeitores.CurrentRow.Index].Value.ToString();
                    txtRM.Text = dgvLeitores[1, dgvLeitores.CurrentRow.Index].Value.ToString();
                    txtNome.Text = dgvLeitores[2, dgvLeitores.CurrentRow.Index].Value.ToString();
                    txtCelular.Text = dgvLeitores[3, dgvLeitores.CurrentRow.Index].Value.ToString();
                    txtTelefone.Text = dgvLeitores[4, dgvLeitores.CurrentRow.Index].Value.ToString();
                    txtEmail1.Text = dgvLeitores[5, dgvLeitores.CurrentRow.Index].Value.ToString();
                    txtEmail2.Text = dgvLeitores[6, dgvLeitores.CurrentRow.Index].Value.ToString();
                    DateTime conf = Convert.ToDateTime(dgvLeitores[7, dgvLeitores.CurrentRow.Index].Value);
                    lblConfeccao.Text = conf.ToShortDateString();
                    cbxCurso.Text = dgvLeitores[8, dgvLeitores.CurrentRow.Index].Value.ToString();
                    cbxModulo.Text = dgvLeitores[9, dgvLeitores.CurrentRow.Index].Value.ToString();
                    lblTermino.Text = dgvLeitores[10, dgvLeitores.CurrentRow.Index].Value.ToString();
                    if (Convert.ToBoolean(dgvLeitores[11, dgvLeitores.CurrentRow.Index].Value)) radTecnico.Checked = true;
                    else radMedio.Checked = true;
                }
                catch
                {
                    lblId.Text = "0";
                    txtRM.Text = "";
                    txtNome.Text = "";
                    txtCelular.Text = "";
                    txtTelefone.Text = "";
                    txtEmail1.Text = "";
                    txtEmail2.Text = "";
                    cbxCurso.SelectedIndex = -1;
                    cbxModulo.SelectedIndex = -1;
                    lblConfeccao.Text = "--/--/----";
                    lblTermino.Text = DateTime.Now.ToShortDateString();
                }
            }
            else
            {
                try
                {
                    lblIdFuncionario.Text = dgvLeitores[0, dgvLeitores.CurrentRow.Index].Value.ToString();
                    txtNomeFuncionario.Text = dgvLeitores[1, dgvLeitores.CurrentRow.Index].Value.ToString();
                    txtFuncao.Text = dgvLeitores[2, dgvLeitores.CurrentRow.Index].Value.ToString();
                    txtCelularFuncionario.Text = dgvLeitores[3, dgvLeitores.CurrentRow.Index].Value.ToString();
                    txtTelefoneFuncionario.Text = dgvLeitores[4, dgvLeitores.CurrentRow.Index].Value.ToString();
                    txtEmailFuncionario.Text = dgvLeitores[5, dgvLeitores.CurrentRow.Index].Value.ToString();
                }
                catch
                {
                    lblIdFuncionario.Text = "";
                    txtNomeFuncionario.Text = "";
                    txtCelularFuncionario.Text = "";
                    txtTelefoneFuncionario.Text = "";
                    txtEmailFuncionario.Text = "";
                    txtFuncao.Text = "";
                }
            }
        }

        private void BtnLimpar_Click(object sender, EventArgs e)
        {
            cbxCurso.SelectedIndex = -1;
            cbxModulo.SelectedIndex = -1;
            lblId.Text = "0";
            txtRM.Text = "";
            txtNome.Text = "";
            txtCelular.Text = "";
            txtTelefone.Text = "";
            txtEmail1.Text = "";
            txtEmail2.Text = "";
            lblConfeccao.Text = DateTime.Now.ToShortDateString();
            lblIdFuncionario.Text = "";
            txtNomeFuncionario.Text = "";
            txtCelularFuncionario.Text = "";
            txtTelefoneFuncionario.Text = "";
            txtEmailFuncionario.Text = "";
            txtFuncao.Text = "";
            txtRM.Focus();
        }

        private void BtnExcluirAluno_Click(object sender, EventArgs e)
        {
            string erro = "Erro Não Previsto!";
            try
            {
                if (modoAluno)
                {
                    int Id_Aluno = Convert.ToInt32(lblId.Text);

                    if (Id_Aluno == 0)
                    {
                        erro = "Nenhum Aluno Selecionado!";
                        throw new Exception("Nenhum aluno selecionado para a exclusão!");
                    }

                    if (MessageBox.Show("Excluir o(a) aluno(a) " + txtNome.Text + "?", "Exclusão de Aluno!", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                    {
                        if (cbxModulo.Text != "0")
                        {
                            if (MessageBox.Show("Este aluno ainda não terminou seu curso!\nDeseja continuar?", "Exclusão de Aluno!", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                            {
                                alunosBLL.DeletarAluno(Id_Aluno, ref erro);
                                MessageBox.Show("O(A) aluno(a) " + txtNome.Text + " foi excluído(a) com sucesso!!", "Aluno excluído!!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                                BtnLimpar_Click(null, null);
                                AtualizaGrid();
                            }
                        }
                        else
                        {
                            alunosBLL.DeletarAluno(Id_Aluno, ref erro);
                            MessageBox.Show("O(A) aluno(a) " + txtNome.Text + " foi excluído(a) com sucesso!!", "Aluno excluído!!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                            BtnLimpar_Click(null, null);
                            AtualizaGrid();
                        }
                    }
                }
                else
                {
                    int id_func = Convert.ToInt32(lblIdFuncionario.Text);

                    if (id_func == 0)
                    {
                        erro = "Nenhum Funcionário Selecionado!";
                        throw new Exception("Nenhum funcionário selecionado para a exclusão!");
                    }

                    if (MessageBox.Show("Excluir o(a) funcionário(a) " + txtNomeFuncionario.Text + "?", "Exclusão de Funcionário!", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                    {
                        int Id_Func = Convert.ToInt32(lblIdFuncionario.Text);

                        funcionarioBLL.DeletarFuncionario(Id_Func, ref erro);
                        MessageBox.Show("O(A) funcionário(a) " + txtNome.Text + " foi excluído(a) com sucesso!!", "Funcionário excluído!!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                        BtnLimpar_Click(null, null);
                        AtualizaGrid();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, erro, MessageBoxButtons.OK, MessageBoxIcon.Error);
                erro = "Erro Não Previsto!";
            }
        }

        private void BtnProfessor_Click(object sender, EventArgs e)
        {
            string erro = "Erro Não Previsto!";
            try
            {
                BtnLimpar_Click(null, null);
                modoAluno = false;

                btnAluno.BackColor = Color.FromArgb(53, 56, 61);
                btnProfessor.BackColor = Color.FromArgb(63, 66, 71);
                gbxAlunos.Visible = false;
                gbxProfessor.Visible = true;
                cbxEnsino.Visible = false;
                pnlFiltros.Width = 130;

                cbxFiltro.Items.Clear();
                cbxFiltro.Items.AddRange(new object[]{
                    "Nome",
                    "Telefone/Celular",
                    "Email",
                    "Função",
                });

                txtFiltro.WaterMark = "Procurar por funcionário";
                BtnFechar_Click(null, null);
                cbxFiltro.SelectedIndex = 0;
                txtNomeFuncionario.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, erro, MessageBoxButtons.OK, MessageBoxIcon.Error);
                erro = "Erro Não Previsto!";
            }
        }

        private void BtnAluno_Click(object sender, EventArgs e)
        {
            string erro = "Erro Não Previsto!";
            try
            {
                BtnLimpar_Click(null, null);
                modoAluno = true;

                btnProfessor.BackColor = Color.FromArgb(53, 56, 61);
                btnAluno.BackColor = Color.FromArgb(63, 66, 71);
                gbxAlunos.Visible = true;
                gbxProfessor.Visible = false;
                cbxEnsino.Visible = true;
                pnlFiltros.Width = 269;

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
                txtRM.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, erro, MessageBoxButtons.OK, MessageBoxIcon.Error);
                erro = "Erro Não Previsto!";
            }
        }

        private void BtnLeitorEspecial_Click(object sender, EventArgs e)
        {
            string erro = "Erro Não Previsto!";
            try
            {
                if (modoAluno)
                {
                    if (txtRM.Text == "")
                    {
                        erro = "Aluno Não Selecionado!";
                        throw new Exception("Selecione um aluno para verificar o progresso de leitor especial!");
                    }
                    int RM = Convert.ToInt32(txtRM.Text);
                    btnLeitorEspecial.Visible = false;
                    dgvLivrosLidos.DataSource = null;
                    dgvLivrosLidos.DataSource = alunosBLL.CarregarLivrosLivros(RM, modoAluno, ref erro);
                    dgvLeitores.Visible = false;
                    dgvLivrosLidos.Visible = true;
                    pnlLivrosLidos.Visible = true;
                    btnFechar.Visible = true;

                    dgvLivrosLidos.Columns[0].Width = 80;
                    dgvLivrosLidos.Columns[3].Width = 30;
                    dgvLivrosLidos.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    dgvLivrosLidos.Columns[4].Width = 70;
                    dgvLivrosLidos.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

                    lblLivrosLidos.Text = dgvLivrosLidos.Rows.Count.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, erro, MessageBoxButtons.OK, MessageBoxIcon.Error);
                erro = "Erro Não Previsto!";
            }
        }

        private void BtnFechar_Click(object sender, EventArgs e)
        {
            string erro = "Erro Não Previsto!";
            try
            {
                btnLeitorEspecial.Visible = true;

                dgvLivrosLidos.Visible = false;
                dgvLeitores.Visible = true;
                pnlLivrosLidos.Visible = false;
                btnFechar.Visible = false;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, erro, MessageBoxButtons.OK, MessageBoxIcon.Error);
                erro = "Erro Não Previsto!";
            }
        }

        private void TrmSlidePainel_Tick(object sender, EventArgs e)
        {
            if (hidePainel)
            {
                pnlClientes.Width -= 20;
                if (pnlClientes.Width <= 0)
                {
                    trmSlidePainel.Stop();
                    hidePainel = false;
                    this.Refresh();
                }
            }
            else
            {
                pnlClientes.Width += 20;
                if (pnlClientes.Width == 300)
                {
                    trmSlidePainel.Stop();
                    hidePainel = true;
                    this.Refresh();
                }
            }
        }

        private void DgvLeitores_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            BtnLeitorEspecial_Click(null, null);
        }

        private void RadMedio_CheckedChanged(object sender, EventArgs e)
        {
            CbxModulo_SelectedIndexChanged(null, null);
        }

        private void TxtRM_KeyDown(object sender, KeyEventArgs e)
        {
            string erro = "Erro Não Previsto!";
            try
            {
                if (e.KeyData == Keys.Enter)
                {
                    if (lblId.Text == "0") BtnIncluir_Click(null, null);
                    else BtnAlterar_Click(null, null);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, erro, MessageBoxButtons.OK, MessageBoxIcon.Error);
                erro = "Erro Não Previsto!";
            }
        }

        private void DgvLeitores_KeyUp(object sender, KeyEventArgs e)
        {
            string erro = "Erro Não Previsto!";
            try
            {
                if (e.KeyData == Keys.Up || e.KeyData == Keys.Down) DgvAlunos_CellClick(null, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, erro, MessageBoxButtons.OK, MessageBoxIcon.Error);
                erro = "Erro Não Previsto!";
            }
        }

        private void TxtNomeFuncionario_KeyDown(object sender, KeyEventArgs e)
        {
            string erro = "Erro Não Previsto!";
            try
            {
                if (e.KeyData == Keys.Enter)
                {
                    if (lblId.Text == "0") BtnIncluir_Click(null, null);
                    else BtnAlterar_Click(null, null);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, erro, MessageBoxButtons.OK, MessageBoxIcon.Error);
                erro = "Erro Não Previsto!";
            }
        }

        private void CbxCurso_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxCurso.SelectedIndex != 24)
            {
                cbxModulo.Items.Clear();
                this.cbxModulo.Items.AddRange(new object[] {
                "0",
                "1",
                "2",
                "3" });
            }
            else if(cbxCurso.SelectedIndex == 24)
            {
                cbxModulo.Items.Clear();
                this.cbxModulo.Items.AddRange(new object[] {
                "0",
                "1",
                "2"});
            }

            try { cbxModulo.Text = dgvLeitores[9, dgvLeitores.CurrentRow.Index].Value.ToString(); }
            catch { }
        }

        private void RadTecnico_CheckedChanged(object sender, EventArgs e)
        {
            CbxModulo_SelectedIndexChanged(null, null);
        }

        private void CbxEnsino_SelectedIndexChanged(object sender, EventArgs e)
        {
            string erro = "Erro Não Previsto!";
            try
            {
                if (cbxEnsino.SelectedIndex == 0) ensino = 0;
                else if (cbxEnsino.SelectedIndex == 1) ensino = 1;
                else if (cbxEnsino.SelectedIndex == 2) ensino = 2;

                AtualizaGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, erro, MessageBoxButtons.OK, MessageBoxIcon.Error);
                erro = "Erro Não Previsto!";
            }
        }
    }
}