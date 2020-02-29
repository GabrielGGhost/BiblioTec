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

namespace GUI.ArquivosMortos.Emprestimos
{
    public partial class frmEmprestimosAlunoMorto : Form
    {

        bool modoAluno = true;

        EmprestimoMortoBLL emprestimosMortoBLL = new EmprestimoMortoBLL();

        EmprestimoInformation emprestimo;

        EmprestimosBLL emprestimosBLL = new EmprestimosBLL();

        public frmEmprestimosAlunoMorto()
        {
            InitializeComponent();
        }

        private void FrmEmprestimosMorto_Load(object sender, EventArgs e)
        {
            AtualizadaGrid();
        }

        void AtualizadaGrid()
        {
            string erro = "Erro Não Esperado!";
            try
            {
                if (modoAluno)
                {
                    dgvEmprestimos.DataSource = null;
                    dgvEmprestimos.DataSource = emprestimosMortoBLL.CarregarEmprestimosMortos(modoAluno);
                    dgvEmprestimos.Columns[0].Visible = false;
                    dgvEmprestimos.Columns[4].Width = 30;
                    dgvEmprestimos.Columns[5].Visible = false;
                    dgvEmprestimos.Columns[8].Width = 35;
                    dgvEmprestimos.Columns[10].Width = 35;
                    dgvEmprestimos.Columns[11].Visible = false;
                    dgvEmprestimos.Columns[12].Width = 35;
                    dgvEmprestimos.Columns[15].Width = 50;
                }
                else
                {
                    dgvEmprestimos.DataSource = null;
                    dgvEmprestimos.DataSource = emprestimosMortoBLL.CarregarEmprestimosMortos(modoAluno);

                    dgvEmprestimos.Columns[0].Visible = false;
                    dgvEmprestimos.Columns[1].Width = 50;
                    dgvEmprestimos.Columns[2].Width = 50;
                    dgvEmprestimos.Columns[3].Width = 50;
                    dgvEmprestimos.Columns[4].Visible = false;
                    dgvEmprestimos.Columns[7].Width = 30;
                    dgvEmprestimos.Columns[9].Width = 30;
                    dgvEmprestimos.Columns[10].Visible = false;
                    dgvEmprestimos.Columns[12].Width = 100;
                    dgvEmprestimos.Columns[12].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                }

                ConfiguracoesBLL configuracoesBLL = new ConfiguracoesBLL();
                float[] tam = configuracoesBLL.BuscarFonte();

                dgvEmprestimos.RowsDefaultCellStyle.Font = new Font("Segoe UI", tam[0], GraphicsUnit.Pixel);

                dgvEmprestimos.RowTemplate.Height = (int)tam[1];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, erro, MessageBoxButtons.OK, MessageBoxIcon.Error);
                erro = "Erro Não Esperado!";
            }
        }

        private void BtnAluno_Click(object sender, EventArgs e)
        {
            modoAluno = true;
            gbxAlunos.Visible = true;
            gbxFuncionario.Visible = false;
            BtnLimparCampos_Click(null, null);

            AtualizadaGrid();
        }

        private void BtnProfessor_Click(object sender, EventArgs e)
        {
            modoAluno = false;
            gbxAlunos.Visible = false;
            gbxFuncionario.Visible = true;
            BtnLimparCampos_Click(null, null);

            AtualizadaGrid();
        }

        private void DgvEmprestimos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (modoAluno)
                {
                    lblIdMorto.Text = dgvEmprestimos[0, dgvEmprestimos.CurrentRow.Index].Value.ToString();
                    lblDataEmprestimo.Text = Convert.ToDateTime(dgvEmprestimos[1, dgvEmprestimos.CurrentRow.Index].Value).ToShortDateString();
                    lblDataDevolucao.Text = Convert.ToDateTime(dgvEmprestimos[2, dgvEmprestimos.CurrentRow.Index].Value).ToShortDateString();
                    lblDataDevolvida.Text = Convert.ToDateTime(dgvEmprestimos[3, dgvEmprestimos.CurrentRow.Index].Value).ToShortDateString();
                    lblMulta.Text = dgvEmprestimos[4, dgvEmprestimos.CurrentRow.Index].Value.ToString();
                    lblIdLivro.Text = dgvEmprestimos[5, dgvEmprestimos.CurrentRow.Index].Value.ToString();
                    lblLocalizacaoLivro.Text = dgvEmprestimos[6, dgvEmprestimos.CurrentRow.Index].Value.ToString();
                    lblNomeLivro.Text = dgvEmprestimos[7, dgvEmprestimos.CurrentRow.Index].Value.ToString();
                    lblAnoLivro.Text = dgvEmprestimos[8, dgvEmprestimos.CurrentRow.Index].Value.ToString();
                    lblAutorLivro.Text = dgvEmprestimos[9, dgvEmprestimos.CurrentRow.Index].Value.ToString();
                    lblTomboLivro.Text = dgvEmprestimos[10, dgvEmprestimos.CurrentRow.Index].Value.ToString();
                    lblIdAluno.Text = dgvEmprestimos[11, dgvEmprestimos.CurrentRow.Index].Value.ToString();
                    lblRM.Text = dgvEmprestimos[12, dgvEmprestimos.CurrentRow.Index].Value.ToString();
                    lblNome.Text = dgvEmprestimos[13, dgvEmprestimos.CurrentRow.Index].Value.ToString();
                    lblCurso.Text = dgvEmprestimos[14, dgvEmprestimos.CurrentRow.Index].Value.ToString();
                    lblModulo.Text = dgvEmprestimos[15, dgvEmprestimos.CurrentRow.Index].Value.ToString();
                }
                else
                {
                    lblIdMorto.Text = dgvEmprestimos[0, dgvEmprestimos.CurrentRow.Index].Value.ToString();
                    lblDataEmprestimo.Text = Convert.ToDateTime(dgvEmprestimos[1, dgvEmprestimos.CurrentRow.Index].Value).ToShortDateString();
                    lblDataDevolucao.Text = Convert.ToDateTime(dgvEmprestimos[2, dgvEmprestimos.CurrentRow.Index].Value).ToShortDateString();
                    lblDataDevolvida.Text = Convert.ToDateTime(dgvEmprestimos[3, dgvEmprestimos.CurrentRow.Index].Value).ToShortDateString();
                    lblMulta.Text = "-----";
                    lblIdLivro.Text = dgvEmprestimos[4, dgvEmprestimos.CurrentRow.Index].Value.ToString();
                    lblNomeLivro.Text = dgvEmprestimos[5, dgvEmprestimos.CurrentRow.Index].Value.ToString();
                    lblLocalizacaoLivro.Text = dgvEmprestimos[6, dgvEmprestimos.CurrentRow.Index].Value.ToString();
                    lblAnoLivro.Text = dgvEmprestimos[7, dgvEmprestimos.CurrentRow.Index].Value.ToString();
                    lblAutorLivro.Text = dgvEmprestimos[8, dgvEmprestimos.CurrentRow.Index].Value.ToString();
                    lblTomboLivro.Text = dgvEmprestimos[9, dgvEmprestimos.CurrentRow.Index].Value.ToString();
                    lblIdFuncionario.Text = dgvEmprestimos[10, dgvEmprestimos.CurrentRow.Index].Value.ToString();
                    lblNomeFuncionario.Text = dgvEmprestimos[11, dgvEmprestimos.CurrentRow.Index].Value.ToString();
                    lblFuncao.Text = dgvEmprestimos[12, dgvEmprestimos.CurrentRow.Index].Value.ToString();
                }
            }
            catch
            {
                BtnLimparCampos_Click(null, null);
            }
        }

        private void BtnLimparCampos_Click(object sender, EventArgs e)
        {
            lblIdMorto.Text = "0";
            lblDataEmprestimo.Text = "";
            lblDataDevolucao.Text = "";
            lblDataDevolvida.Text = "";
            lblMulta.Text = "";
            lblIdLivro.Text = "0";
            lblNomeLivro.Text = "";
            lblLocalizacaoLivro.Text = "";
            lblAnoLivro.Text = "";
            lblAutorLivro.Text = "";
            lblTomboLivro.Text = "";
            lblIdAluno.Text = "0";
            lblRM.Text = "";
            lblNome.Text = "";
            lblCurso.Text = "";
            lblModulo.Text = "";
            lblIdFuncionario.Text = "";
            lblNomeFuncionario.Text = "";
            lblFuncao.Text = "";
        }

        private void BtnDesfazer_Click(object sender, EventArgs e)
        {
            string erro = "Erro Não Previsto!";
            try
            {
                if (lblIdMorto.Text == "0")
                {
                    erro = "Empréstimo Não Selecionado!";
                    throw new Exception("É preciso selecionar um empréstimo para desfazê-lo!");
                }

                if (emprestimosMortoBLL.VerificarDisponibilidade(lblIdLivro.Text))
                {
                    erro = "Livro Emprestado!";
                    throw new Exception("O livro agora está emprestado!");
                }


                if (modoAluno)
                {
                    if (lblIdAluno.Text == "0")
                    {
                        erro = "Nenhum Empréstimo Selecionado!";
                        throw new Exception("Selecione um aluno para desfazer o empréstimo!");
                    }



                    if (MessageBox.Show("Desfazer o empréstimo de " + lblNomeLivro.Text + " para " + lblNome.Text + "?", "Desfazer Empréstimo!", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                    {
                        string serie = lblModulo.Text + " - " + lblCurso.Text;
                        emprestimo = new EmprestimoInformation(Convert.ToInt32(lblIdAluno.Text),
                                                                Convert.ToInt32(lblRM.Text),
                                                                lblNome.Text,
                                                                lblCurso.Text,
                                                                Convert.ToInt32(lblModulo.Text),
                                                                Convert.ToInt32(lblIdLivro.Text),
                                                                lblNomeLivro.Text,
                                                                lblLocalizacaoLivro.Text,
                                                                lblAnoLivro.Text,
                                                                lblAutorLivro.Text,
                                                                Convert.ToInt32(lblTomboLivro.Text),
                                                                Convert.ToDateTime(lblDataEmprestimo.Text),
                                                                Convert.ToDateTime(lblDataDevolucao.Text),
                                                                serie);

                        if(emprestimosMortoBLL.verificarRenovacao(emprestimo, modoAluno)) emprestimosMortoBLL.DesfazerRenovacao(emprestimo, modoAluno);
                        else emprestimosBLL.RealizarEmprestimo(emprestimo, modoAluno, false, ref erro);

                        emprestimosMortoBLL.ExcluirMorto(lblIdMorto.Text, modoAluno);
                        MessageBox.Show("O empréstimo foi desfeito!", "Empréstimo Desfeito!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        lblIdAluno.Text = "0";
                        AtualizadaGrid();
                        lblNomeLivro.Text = "";
                        lblLocalizacaoLivro.Text = "";
                        lblAnoLivro.Text = "";
                        lblAutorLivro.Text = "";
                        lblTomboLivro.Text = "";
                    }
                }
                else
                {
                    if (lblIdFuncionario.Text == "0")
                    {
                        erro = "Nenhum Empréstimo Selecionado!";
                        throw new Exception("Selecione um funcionário para desfazer o emprestimo!");
                    }

                    if (MessageBox.Show("Emprestar o livro " + lblNomeLivro.Text + " para " + lblNomeFuncionario.Text + "?", "Empréstimo de Livro", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                    {
                        string serie = "-----";
                        emprestimo = new EmprestimoInformation(Convert.ToInt32(lblIdFuncionario.Text),
                                                                lblNomeFuncionario.Text,
                                                                lblFuncao.Text,
                                                                Convert.ToInt32(lblIdLivro.Text),
                                                                lblNomeLivro.Text,
                                                                lblLocalizacaoLivro.Text,
                                                                lblAnoLivro.Text,
                                                                lblAutorLivro.Text,
                                                                Convert.ToInt32(lblTomboLivro.Text),
                                                                Convert.ToDateTime(lblDataEmprestimo.Text),
                                                                Convert.ToDateTime(lblDataDevolucao.Text),
                                                                serie);

                        if (emprestimosMortoBLL.verificarRenovacao(emprestimo, modoAluno)) emprestimosMortoBLL.DesfazerRenovacao(emprestimo, modoAluno);
                        else emprestimosBLL.RealizarEmprestimo(emprestimo, modoAluno, false, ref erro);

                        emprestimosMortoBLL.ExcluirMorto(lblIdMorto.Text, modoAluno);
                        MessageBox.Show("O Livro " + lblNomeLivro.Text + " foi emprestado para " + lblNomeFuncionario.Text + "!", "Livro Emprestado!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        AtualizadaGrid();
                        lblIdAluno.Text = "0";
                        lblNomeLivro.Text = "";
                        lblLocalizacaoLivro.Text = "";
                        lblAnoLivro.Text = "";
                        lblAutorLivro.Text = "";
                        lblTomboLivro.Text = "";
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, erro, MessageBoxButtons.OK, MessageBoxIcon.Error);
                erro = "Erro Não Previsto!";
            }
        }

        private void BtnAluno_Click_1(object sender, EventArgs e)
        {
            string erro = "Erro Não Previsto!";
            try
            {
                modoAluno = true;

                btnProfessor.BackColor = Color.FromArgb(53, 56, 61);
                btnAluno.BackColor = Color.FromArgb(63, 66, 71);
                gbxAlunos.Visible = true;
                gbxFuncionario.Visible = false;

                AtualizadaGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, erro, MessageBoxButtons.OK, MessageBoxIcon.Error);
                erro = "Erro Não Previsto!";
            }
        }

        private void BtnProfessor_Click_1(object sender, EventArgs e)
        {
            string erro = "Erro Não Previsto!";
            try
            {
                modoAluno = false;

                btnAluno.BackColor = Color.FromArgb(53, 56, 61);
                btnProfessor.BackColor = Color.FromArgb(63, 66, 71);
                gbxAlunos.Visible = false;
                gbxFuncionario.Visible = true;

                AtualizadaGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, erro, MessageBoxButtons.OK, MessageBoxIcon.Error);
                erro = "Erro Não Previsto!";
            }
        }
    }
}