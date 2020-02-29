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

namespace GUI.FichaCatalografica
{
    public partial class frmFichaCatalograficas : Form
    {
        FichaBLL fichaBLL = new FichaBLL();
        public frmFichaCatalograficas()
        {
            InitializeComponent();
        }

        private void FrmFichaCatalograficas_Load(object sender, EventArgs e)
        {
            AtualizaGrid();
        }

        private void AtualizaGrid()
        {
            string erro = "Erro Não Esperado!";
            try
            {
                dgvFichas.DataSource = fichaBLL.CarregarFichas();
                dgvFichas.Columns[0].Visible = false;

                dgvFichas.Columns[1].Width = 50;
                dgvFichas.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgvFichas.Columns[2].Width = 150;
                dgvFichas.Columns[4].Width = 40;
                dgvFichas.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgvFichas.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgvFichas.Columns[6].Width = 50;
                dgvFichas.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

                ConfiguracoesBLL configuracoesBLL = new ConfiguracoesBLL();
                float[] tam = configuracoesBLL.BuscarFonte();

                dgvFichas.RowsDefaultCellStyle.Font = new Font("Segoe UI", tam[0], GraphicsUnit.Pixel);
                dgvFichas.RowTemplate.Height = (int)tam[1];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, erro, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TxtTobo_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if(e.KeyData == Keys.Enter)
                {
                    string tombo = txtTombo.Text;

                    object[] dados = fichaBLL.CarregarDados(tombo);

                    lblId.Text = dados[0].ToString();
                    lblLocalizacao.Text = dados[1].ToString();
                    lblNome.Text = dados[2].ToString();
                    lblCidade.Text = dados[3].ToString();
                    lblAno.Text = dados[4].ToString();
                    lblEditora.Text = dados[5].ToString();
                    lblAutor.Text = dados[6].ToString();
                    lblTombo.Text = dados[7].ToString();

                    dgvFichas.DataSource = null;
                    dgvFichas.DataSource = fichaBLL.CarregarFichas(int.Parse(lblId.Text));
                    dgvFichas.Columns[0].Visible = false;
                }
            }
            catch { }
        }

        private void BtnExcluirAluno_Click(object sender, EventArgs e)
        {
            AtualizaGrid();

            lblId.Text = "0";
            lblNome.Text = "";
            lblLocalizacao.Text = "";
            lblTombo.Text = "";
            lblAno.Text = "";
            lblAutor.Text = "";
            lblEditora.Text = "";
            lblCidade.Text = "";
        }
    }
}
