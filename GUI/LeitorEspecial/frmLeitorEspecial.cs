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

namespace GUI.LeitorEspecial
{
    public partial class frmLeitorEspecial : Form
    {

        LeitorEspecialBLL leitorEspecialBLL = new LeitorEspecialBLL();

        int opc = 1;

        bool hidePainel = true;

        public frmLeitorEspecial()
        {
            InitializeComponent();
        }

        private void FrmLeitorEspecial_Load(object sender, EventArgs e)
        {
            cbxFiltro.SelectedIndex = 1;
        }

        void AtualizaGrid()
        {
            string erro = "Erro Não Previsto!";
            try
            {
                dgvLeitores.DataSource = leitorEspecialBLL.CarregarLeitores(opc, txtFiltro.Text);
                dgvLeitores.Columns[0].Visible = false;

                ConfiguracoesBLL configuracoesBLL = new ConfiguracoesBLL();
                float[] tam = configuracoesBLL.BuscarFonte();

                dgvLeitores.RowsDefaultCellStyle.Font = new Font("Segoe UI", tam[0], GraphicsUnit.Pixel);
                dgvLeitores.RowTemplate.Height = (int)tam[1];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, erro, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DgvLeitores_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                lblId.Text = dgvLeitores[0, dgvLeitores.CurrentRow.Index].Value.ToString();
                lblRm.Text = dgvLeitores[1, dgvLeitores.CurrentRow.Index].Value.ToString();
                lblNome.Text = dgvLeitores[2, dgvLeitores.CurrentRow.Index].Value.ToString();
                lblCelular.Text = dgvLeitores[3, dgvLeitores.CurrentRow.Index].Value.ToString();
                lblTelefone.Text = dgvLeitores[4, dgvLeitores.CurrentRow.Index].Value.ToString();
                lblEmail1.Text = dgvLeitores[5, dgvLeitores.CurrentRow.Index].Value.ToString();
                lblEmail2.Text = dgvLeitores[6, dgvLeitores.CurrentRow.Index].Value.ToString();
                lblConfeccao.Text = Convert.ToDateTime(dgvLeitores[7, dgvLeitores.CurrentRow.Index].Value).ToShortDateString();
                lblTermino.Text = dgvLeitores[8, dgvLeitores.CurrentRow.Index].Value.ToString();
                lblModulo.Text = dgvLeitores[9, dgvLeitores.CurrentRow.Index].Value.ToString();
                lblCurso.Text = dgvLeitores[10, dgvLeitores.CurrentRow.Index].Value.ToString();
                txtSituacao.Text = dgvLeitores[11, dgvLeitores.CurrentRow.Index].Value.ToString();
            }
            catch
            {
                lblId.Text = "";
                lblRm.Text = "";
                lblNome.Text = "";
                lblCelular.Text = "";
                lblTelefone.Text = "";
                lblEmail1.Text = "";
                lblEmail2.Text = "";
                lblCurso.Text = "";
                lblModulo.Text = "";
                lblTermino.Text = "";
                lblConfeccao.Text = "";
                txtSituacao.Text = "";
            }
        }

        private void BtnAlterar_Click(object sender, EventArgs e)
        {
            string erro = "Erro Não Previsto!";
            try
            {
                if(lblId.Text == "0")
                {
                    erro = "Aluno Não Selecionado!";
                    throw new Exception("É preciso selecionar um aluno antes de alterá-lo!");
                }

                string situacao = txtSituacao.Text;
                int idAluno = Convert.ToInt32(lblId.Text);


                leitorEspecialBLL.AlterarSituacao(idAluno, situacao);
                MessageBox.Show("Situação do aluno " + lblNome.Text + " alterado com sucesso!", "Situação Atualizada!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                AtualizaGrid();
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message, erro, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CbxFiltro_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxFiltro.SelectedIndex == 0) opc = 0;
            else if (cbxFiltro.SelectedIndex == 1) opc = 1;
            else if (cbxFiltro.SelectedIndex == 2) opc = 2;
            else if (cbxFiltro.SelectedIndex == 3) opc = 3;
            else if (cbxFiltro.SelectedIndex == 4) opc = 4;

            AtualizaGrid();
        }

        private void TxtFiltro_TextChanged(object sender, EventArgs e)
        {
            AtualizaGrid();
        }

        private void TrmSlidePainel_Tick(object sender, EventArgs e)
        {
            if (hidePainel)
            {
                pnlLeitores.Width -= 30;
                if (pnlLeitores.Width <= 0)
                {
                    trmSlidePainel.Stop();
                    hidePainel = false;
                    this.Refresh();
                }
            }
            else
            {
                pnlLeitores.Width += 30;
                if (pnlLeitores.Width == 300)
                {
                    trmSlidePainel.Stop();
                    hidePainel = true;
                    this.Refresh();
                }
            }
        }

        private void BtnAbir_Click(object sender, EventArgs e)
        {
            if (!hidePainel) btnAbir.Text = "Fechar Painel";
            else btnAbir.Text = "Abrir Painel";
            trmSlidePainel.Start();
        }
    }
}
