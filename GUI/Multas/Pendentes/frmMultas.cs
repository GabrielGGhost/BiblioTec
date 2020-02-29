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

namespace GUI.Multas
{
    public partial class frmMultas : Form
    {
        public frmMultas()
        {
            InitializeComponent();
        }

        MultasBLL multasBLL = new MultasBLL();

        int opc = 0;

        private void FrmMultas_Load(object sender, EventArgs e)
        {
            cbxFiltroOpc.SelectedIndex = 1;
        }

        private void AtualizaGrid()
        {
            string erro = "Erro Não Previsto!";
            try
            {
                dgvMultas.DataSource = multasBLL.CarregarMultas(opc, txtFiltro.Text);
                dgvMultas.Columns[0].Visible = false;

                dgvMultas.Columns[1].Width = 50;
                dgvMultas.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgvMultas.Columns[4].Width = 80;
                dgvMultas.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

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
            string erro = "Erro Não Previsto!";
            try
            {
                int
                    id_multa = Convert.ToInt32(dgvMultas[0, dgvMultas.CurrentRow.Index].Value);

                object[] dadosAluno = multasBLL.CarregarDadosAlunos(id_multa);

                lblId.Text = dadosAluno[0].ToString();
                lblNome.Text = dadosAluno[1].ToString();
                lblRM.Text = dadosAluno[2].ToString();
                lblCurso.Text = dadosAluno[3].ToString();
                lblModulo.Text = dadosAluno[4].ToString();

                object[] dadosLivro = multasBLL.CarregarDadosLivro(id_multa);

                lblIdLivro.Text = dadosLivro[0].ToString();
                lblNomeLivro.Text = dadosLivro[1].ToString();
                lblLocalizacaoLivro.Text = dadosLivro[2].ToString();
                lblAnoLivro.Text = dadosLivro[3].ToString();
                lblAutorLivro.Text = dadosLivro[4].ToString();
                lblTomboLivro.Text = dadosLivro[5].ToString();
                lblMulta.Text = dadosLivro[6].ToString();
                lblStatus.Text = dadosLivro[7].ToString();

                lblIdMulta.Text = dgvMultas[0, dgvMultas.CurrentRow.Index].Value.ToString();
                lblValor.Text = dgvMultas[4, dgvMultas.CurrentRow.Index].Value.ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, erro, MessageBoxButtons.OK, MessageBoxIcon.Error);
                erro = "Erro Não Previsto!";
            }
        }

        private void BtnPagar_Click(object sender, EventArgs e)
        {
            string erro = "Erro Não Previsto!";
            try
            {
                if (dgvMultas.Rows.Count == 0)
                {
                    erro = "Sem Multas Disponíveis!";
                    throw new Exception("Não há multas pendentes para serem pagar!");
                }

                int
                    id_multa = Convert.ToInt32(lblIdMulta.Text);

                if (id_multa == 0)
                {
                    erro = "Multa Não Selecionada!";
                    throw new Exception("Nenhuma multa foi selecionada!");
                }

                if (MessageBox.Show("Deseja pagar a multa de " + lblNome.Text + "?", "Pagar Multa!", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    multasBLL.PagarMulta(id_multa);
                    MessageBox.Show("A multa de " + lblNome.Text + " foi paga!", "Dívida Paga!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    AtualizaGrid();
                    LimparCampos();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, erro, MessageBoxButtons.OK, MessageBoxIcon.Error);
                erro = "Erro Não Previsto!";
            }
        }

        private void LimparCampos()
        {
            lblId.Text = "";
            lblNome.Text = "";
            lblRM.Text = "";
            lblCurso.Text = "";
            lblModulo.Text = "";

            lblIdLivro.Text = "";
            lblNomeLivro.Text = "";
            lblLocalizacaoLivro.Text = "";
            lblAnoLivro.Text = "";
            lblAutorLivro.Text = "";
            lblTomboLivro.Text = "";
            lblMulta.Text = "";
            lblStatus.Text = "";

            lblIdMulta.Text = "";
            lblValor.Text = "";
        }

        private void BtnLimpar_Click(object sender, EventArgs e)
        {
            lblId.Text = "";
            lblNome.Text = "";
            lblRM.Text = "";
            lblCurso.Text = "";
            lblModulo.Text = "";

            lblIdLivro.Text = "";
            lblNomeLivro.Text = "";
            lblLocalizacaoLivro.Text = "";
            lblAnoLivro.Text = "";
            lblAutorLivro.Text = "";
            lblTomboLivro.Text = "";
            lblMulta.Text = "";
            lblStatus.Text = "";

            lblIdMulta.Text = "";
            lblValor.Text = "";

            lblMulta.Text = "0,00";
        }

        private void CbxFiltroOpc_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxFiltroOpc.SelectedIndex == 0) opc = 0;
            else if (cbxFiltroOpc.SelectedIndex == 1) opc = 1;
            else if (cbxFiltroOpc.SelectedIndex == 2) opc = 2;

            AtualizaGrid();
        }

        private void TxtFiltro_TextChanged(object sender, EventArgs e)
        {
            AtualizaGrid();
        }

        private void DgvLivros_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Up || e.KeyData == Keys.Down) DgvMultas_CellClick(null, null);
        }
    }
}