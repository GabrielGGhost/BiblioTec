using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.Multas.Efetuadas
{
    public partial class frmPagas : Form
    {
        PagasBLL pagasBLL = new PagasBLL();

        EmprestimosBLL emprestimosBLL = new EmprestimosBLL();

        public frmPagas()
        {
            InitializeComponent();
        }

        private void FrmPagas_Load(object sender, EventArgs e)
        {
            AtualizaGrid();
        }

        void AtualizaGrid()
        {
            string erro = "Erro Não Previsto!";
            try
            {
                dgvMultas.DataSource = pagasBLL.CarregarPagas(txtFiltro.Text.Trim());

                dgvMultas.Columns[0].Visible = false;
                dgvMultas.Columns[1].Visible = false;
                dgvMultas.Columns[3].Visible = false;
                dgvMultas.Columns[5].Width = 50;
                dgvMultas.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgvMultas.Columns[6].Width = 30;
                dgvMultas.Columns[7].Width = 30;
                dgvMultas.Columns[8].Width = 30;
                dgvMultas.Columns[9].Width = 30;
                dgvMultas.Columns[10].Visible = false;
                dgvMultas.Columns[11].Width = 80;

                ConfiguracoesBLL configuracoesBLL = new ConfiguracoesBLL();
                float[] tam = configuracoesBLL.BuscarFonte();

                dgvMultas.RowsDefaultCellStyle.Font = new Font("Segoe UI", tam[0], GraphicsUnit.Pixel);
                dgvMultas.RowTemplate.Height = (int)tam[1];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, erro, MessageBoxButtons.OK, MessageBoxIcon.Error);
                erro = "Erro Não Previsto!";
            }
        }

        private void DgvMultas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                gbxAlunos.Height = 197;
                tlpAlunos.Visible = true;
                lblMensagem.Visible = false;

                gbxLivro.Height = 305;
                tlpLivros.Visible = true;
                lblMensagemLivro.Visible = false;

                lblIdLog.Text = dgvMultas[0, dgvMultas.CurrentRow.Index].Value.ToString();
                lblIdAluno.Text = dgvMultas[1, dgvMultas.CurrentRow.Index].Value.ToString();
                lblNome.Text = dgvMultas[2, dgvMultas.CurrentRow.Index].Value.ToString();
                lblIdLivro.Text = dgvMultas[3, dgvMultas.CurrentRow.Index].Value.ToString();
                lblNomeLivro.Text = dgvMultas[4, dgvMultas.CurrentRow.Index].Value.ToString();
                lblValor.Text = dgvMultas[5, dgvMultas.CurrentRow.Index].Value.ToString();

                if (Convert.ToBoolean(dgvMultas[6, dgvMultas.CurrentRow.Index].Value)) lblEmail.Text = "Avisado";
                else lblEmail.Text = "Não Avisado!";
                if (Convert.ToBoolean(dgvMultas[7, dgvMultas.CurrentRow.Index].Value)) lblWhats.Text = "Avisado";
                else lblWhats.Text = "Não Avisado!";
                if (Convert.ToBoolean(dgvMultas[8, dgvMultas.CurrentRow.Index].Value)) lblSMS.Text = "Avisado";
                else lblSMS.Text = "Não Avisado!";
                if (Convert.ToBoolean(dgvMultas[9, dgvMultas.CurrentRow.Index].Value)) lblFacebook.Text = "Avisado";
                else lblFacebook.Text = "Não Avisado!";

                object[] dadosAluno = pagasBLL.BuscarDadosAluno(lblIdAluno.Text);

                try
                {
                    lblRM.Text = dadosAluno[0].ToString();
                    lblCurso.Text = dadosAluno[1].ToString();
                    lblModulo.Text = dadosAluno[2].ToString();
                }
                catch
                {
                    gbxAlunos.Height = 90;
                    tlpAlunos.Visible = false;
                    lblMensagem.Visible = true;
                }

                object[] dadosLivro = pagasBLL.BuscarDadosLivro(lblIdLivro.Text);
                try
                {
                    lblLocalizacaoLivro.Text = dadosLivro[0].ToString();
                    lblAnoLivro.Text = dadosLivro[1].ToString();
                    lblAutorLivro.Text = dadosLivro[2].ToString();
                    lblTomboLivro.Text = dadosLivro[3].ToString();
                    lblMulta.Text = dadosLivro[4].ToString();
                }catch
                {
                    gbxLivro.Height = 90;
                    tlpLivros.Visible = false;
                    lblMensagemLivro.Visible = true;
                }
            }
            catch 
            {
                BtnLimparCampos_Click(null, null);
            }
        }

        private void BtnLimparCampos_Click(object sender, EventArgs e)
        {
            lblIdLog.Text = "0";
            lblValor.Text = "";
            lblEmail.Text = "";
            lblWhats.Text = "";
            lblSMS.Text = "";
            lblFacebook.Text = "";
            lblIdAluno.Text = "0";
            lblNome.Text = "";
            lblRM.Text = "";
            lblCurso.Text = "";
            lblModulo.Text = "";
            lblIdLivro.Text = "";
            lblNome.Text = "";
            lblLocalizacaoLivro.Text = "";
            lblAnoLivro.Text = "";
            lblAutorLivro.Text = "";
            lblTomboLivro.Text = "";
            lblMulta.Text = "";
        }

        private void BtnDesfazer_Click(object sender, EventArgs e)
        {
            string erro = "Erro Não Previsto!";
            try
            {
                if(lblIdLog.Text == "0")
                {
                    erro = "Multa Não Selecionada!";
                    throw new Exception("É preciso selecionar a multa que deseja restaurar!");
                }

                if (MessageBox.Show("Deseja restaurar está multa?\nEste aluno não podera emprestar ou renovar livros!", "Desfazer Multa!", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    int idLog = int.Parse(lblIdLog.Text);

                    pagasBLL.DesfazerMulta(idLog);
                    MessageBox.Show("A multa foi desfeita com sucesso!");
                    AtualizaGrid();
                    BtnLimparCampos_Click(null, null);
                }


            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message, erro, MessageBoxButtons.OK, MessageBoxIcon.Error);
                erro = "Erro Não Previsto!";
            }
        }

        private void TxtFiltro_TextChanged(object sender, EventArgs e)
        {
            AtualizaGrid();
        }
    }
}
