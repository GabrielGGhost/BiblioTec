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

namespace GUI.Livros
{
    public partial class frmLivros : Form
    {
        public frmLivros()
        {
            InitializeComponent();
        }

        int
            opc = 5,
            vis = 0,
            dias = 1;

        bool
            inicio = true,
            hidePainel = true;

        decimal multa;

        LivroInformation
            livro;

        LivrosBLL
            livrosBLL = new LivrosBLL();

        void AtualizaGrid()
        {
            string erro = "Erro Não Previsto!";

            try
            {
                dgvLivro.DataSource = livrosBLL.ListarLivros(txtFiltro.Text, opc, vis);
                dgvLivro.Columns[0].Visible = false;

                dgvLivro.Columns[4].Width = 40;
                dgvLivro.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgvLivro.Columns[5].Width = 40;
                dgvLivro.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgvLivro.Columns[6].Width = 60;
                dgvLivro.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgvLivro.Columns[9].Width = 40;
                dgvLivro.Columns[9].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgvLivro.Columns[11].Width = 60;
                dgvLivro.Columns[11].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

                if (cbxVis.SelectedIndex != 2) dgvLivro.Columns[12].Visible = false;
                else
                {
                    dgvLivro.Columns[12].Visible = true;
                    dgvLivro.Columns[12].Width = 80;
                }

                ConfiguracoesBLL configuracoesBLL = new ConfiguracoesBLL();
                float[] tam = configuracoesBLL.BuscarFonte();

                dgvLivro.RowsDefaultCellStyle.Font = new Font("Segoe UI", tam[0], GraphicsUnit.Pixel);
                dgvLivro.RowTemplate.Height = (int)tam[1];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, erro, MessageBoxButtons.OK, MessageBoxIcon.Error);
                erro = "Erro Não Previsto!";
            }
        }

        int BuscarUltimoTombo()
        {
            return livrosBLL.BuscarUltimoTombo();
        }

        private void BtnIncluir_Click(object sender, EventArgs e)
        {
            string erro = "Erro Não Previsto!";
            try
            {
                if(lblId.Text != "0")
                {
                    erro = "Livro Selecionado!";
                    throw new Exception("Clique em 'NovoLivro' antes de adicionar um novo livro");
                }
                try { int tombo = Convert.ToInt32(txtTombo.Text); }
                catch
                {
                    erro = "Número de tombo inválido!";
                    throw new Exception("O número de tombo não foi digitado corretamente");
                }

                if (txtAno.Text.Trim().Length != 4)
                {
                    erro = "Ano inválido!";
                    throw new Exception("O número do ano digitado é inválido!");
                }

                try { decimal multa= Convert.ToDecimal(txtMulta.Text); }
                catch
                {
                    erro = "Valor de Multa inválida!";
                    throw new Exception("O valor de multa não foi digitado corretamente");
                }

                livro = new LivroInformation(txtLocalizacao.Text,
                                              txtNome.Text,
                                              txtCidade.Text,
                                              txtEdicao.Text,
                                              txtDetalhes.Text,
                                              txtAno.Text,
                                              txtVolPags.Text,
                                              txtEditora.Text,
                                              txtAutor.Text,
                                              Convert.ToInt32(txtTombo.Text),
                                              Convert.ToDecimal(txtMulta.Text));

                livrosBLL.IncluirLivro(livro, erro);
                MessageBox.Show("O livro " + txtNome.Text + " foi cadastrado com sucesso!", "Livro Incluído!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                AtualizaGrid();
                BtnLimpar_Click(null, null);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, erro, MessageBoxButtons.OK, MessageBoxIcon.Error);
                erro = "Erro Não Previsto!";
            }
        }

        private void FrmLivros_Load(object sender, EventArgs e)
        {
            cbxVis.SelectedIndex = 0;
            cbxFiltro.SelectedIndex = 5;

            txtTombo.Text = BuscarUltimoTombo().ToString();
            AtualizaGrid();
            inicio = false;
            txtNome.Select();
        }


        private void DgvLivro_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                lblId.Text = dgvLivro[0, dgvLivro.CurrentRow.Index].Value.ToString();
                txtNome.Text = dgvLivro[1, dgvLivro.CurrentRow.Index].Value.ToString();
                txtLocalizacao.Text = dgvLivro[2, dgvLivro.CurrentRow.Index].Value.ToString();
                txtCidade.Text = dgvLivro[3, dgvLivro.CurrentRow.Index].Value.ToString();
                txtEdicao.Text = dgvLivro[4, dgvLivro.CurrentRow.Index].Value.ToString();
                txtAno.Text = dgvLivro[5, dgvLivro.CurrentRow.Index].Value.ToString();
                txtVolPags.Text = dgvLivro[6, dgvLivro.CurrentRow.Index].Value.ToString();
                txtAutor.Text = dgvLivro[7, dgvLivro.CurrentRow.Index].Value.ToString();
                txtEditora.Text = dgvLivro[8, dgvLivro.CurrentRow.Index].Value.ToString();
                txtTombo.Text = dgvLivro[9, dgvLivro.CurrentRow.Index].Value.ToString();
                txtDetalhes.Text = dgvLivro[10, dgvLivro.CurrentRow.Index].Value.ToString();
                txtMulta.Text = dgvLivro[11, dgvLivro.CurrentRow.Index].Value.ToString();

                if(Convert.ToBoolean(dgvLivro[12, dgvLivro.CurrentRow.Index].Value))
                {
                    btnRoubado.Text = "Livro Encontrado";
                    btnRoubado.ForeColor = Color.Green;
                } else
                {
                    btnRoubado.Text = "Livro Roubado";
                    btnRoubado.ForeColor = Color.Red;
                }
            }
            catch
            {
                lblId.Text = "0";
                txtNome.Text = "";
                txtLocalizacao.Text = "";
                txtTombo.Text = "";
                txtCidade.Text = "";
                txtEdicao.Text = "1";
                txtAno.Text = "";
                txtVolPags.Text = "";
                txtEditora.Text = "";
                txtAutor.Text = "";
                txtDetalhes.Text = "";
                txtMulta.Text = "0,00";
            }
        }

        private void BtnLimpar_Click(object sender, EventArgs e)
        {
            lblId.Text = "0";
            txtNome.Text = "";
            txtLocalizacao.Text = "";
            txtTombo.Text = BuscarUltimoTombo().ToString();
            txtCidade.Text = "";
            txtEdicao.Text = "1";
            txtAno.Text = "";
            txtVolPags.Text = "";
            txtEditora.Text = "";
            txtAutor.Text = "";
            txtDetalhes.Text = "";
            txtMulta.Text = "0,00";
            btnRoubado.Text = "Livro Roubado";
            btnRoubado.ForeColor = Color.Red;
        }

        private void BtnAlterar_Click(object sender, EventArgs e)
        {
            string erro = "Erro Não Previsto!";
            try
            { 
                bool roubado;
                try { int tombo = Convert.ToInt32(txtTombo.Text); }
                catch
                {
                    erro = "Número de tombo inválido!";
                    throw new Exception("O número de tombo não foi digitado corretamente");
                }

                if (txtAno.Text.Trim().Length != 4)
                {
                    erro = "Ano inválido!";
                    throw new Exception("O número do ano digitado é inválido!");
                }

                try { decimal multa = Convert.ToDecimal(txtMulta.Text); }
                catch
                {
                    erro = "Valor de Multa inválida!";
                    throw new Exception("O valor de multa não foi digitado corretamente");
                }

                if (btnRoubado.Text == "Livro Roubado") roubado = false;
                else roubado = true;

                if (MessageBox.Show("Alterar as informações do livro " + txtNome.Text + "?", "Alter Livro", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    livro = new LivroInformation(Convert.ToInt32(lblId.Text),
                                                  txtLocalizacao.Text,
                                                  txtNome.Text,
                                                  txtCidade.Text,
                                                  txtEdicao.Text,
                                                  txtDetalhes.Text,
                                                  txtAno.Text,
                                                  txtVolPags.Text,
                                                  txtEditora.Text,
                                                  txtAutor.Text,
                                                  Convert.ToInt32(txtTombo.Text),
                                                  Convert.ToDecimal(txtMulta.Text),
                                                  roubado);

                    livrosBLL.AlterarLivro(livro, ref erro);
                    MessageBox.Show("O livro " + txtNome.Text + " foi alterado com sucesso!", "Livro Alterado!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
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

        private void CbxVis_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxVis.SelectedIndex == 0) vis = 0;
            else if (cbxVis.SelectedIndex == 1) vis = 1;
            else if (cbxVis.SelectedIndex == 2) vis = 2;

            if (inicio == false) AtualizaGrid();

            if(dgvVisualizadorMultas.Visible) CarregarVisualizadorMultas(multa, dias);
        }

        private void CbxFiltro_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxFiltro.SelectedIndex == 0) opc = 0;
            else if (cbxFiltro.SelectedIndex == 1) opc = 1;
            else if (cbxFiltro.SelectedIndex == 2) opc = 2;
            else if (cbxFiltro.SelectedIndex == 3) opc = 3;
            else if (cbxFiltro.SelectedIndex == 4) opc = 4;
            else if (cbxFiltro.SelectedIndex == 5) opc = 5;
            else if (cbxFiltro.SelectedIndex == 6) opc = 6;

            if (inicio == false) AtualizaGrid();

            if(dgvVisualizadorMultas.Visible) CarregarVisualizadorMultas(multa, dias);
        }

        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            string erro = "Erro Não Previsto!";
            try
            {
                int id_livro = Convert.ToInt32(lblId.Text);

                livrosBLL.DeletarLivro(id_livro);
                MessageBox.Show("O livro " + txtNome.Text + " foi excluído com sucesso!");
                AtualizaGrid();
                BtnLimpar_Click(null, null);
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

        private void BtnRoubado_Click(object sender, EventArgs e)
        {
            string erro = "Erro Não Previsto!";
            try
            {
                int id_livro = Convert.ToInt32(lblId.Text);

                if (btnRoubado.ForeColor == Color.Red)
                {
                    if (MessageBox.Show("Definir o livro " + txtNome.Text + " como roubado?", "Livro Roubado!", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                    {
                        livrosBLL.LivroRoubado(id_livro, 0, ref erro);
                        MessageBox.Show("O livro " + txtNome.Text + " foi definido como roubado!", "Livro Roubado!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }
                }
                else
                {
                    if (MessageBox.Show("Definir o livro " + txtNome.Text + " como disponível?", "Livro Disponível!", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                    {
                        livrosBLL.LivroRoubado(id_livro, 1, ref erro);
                        MessageBox.Show("O livro " + txtNome.Text + " foi definido como disponível!", "Livro Encontrado", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }
                }
                AtualizaGrid();
                BtnLimpar_Click(null, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, erro, MessageBoxButtons.OK, MessageBoxIcon.Error);
                erro = "Erro Não Previsto!";
            }
        }

        private void BtnAbir_Click(object sender, EventArgs e)
        {
            trmSlidePainel.Start();
        }

        private void BtnMultas_Click(object sender, EventArgs e)
        {
            string erro = "Erro Não Previsto!";
            try
            {
                btnMultas.Visible = false;
                BtnLimpar_Click(null, null);
                pnlFerramentas.Visible = true;
                pnlFechar.Visible = true;
                dgvLivro.Visible = false;
                dgvVisualizadorMultas.Visible = true;

                lblMulta.Text = livrosBLL.BuscarMultaFixa();

                txtDiaMulta.Text = lblMulta.Text;

                CarregarVisualizadorMultas(Convert.ToDecimal(txtDiaMulta.Text), 1);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, erro, MessageBoxButtons.OK, MessageBoxIcon.Error);
                erro = "Erro Não Previsto!";
            }
        }

        void CarregarVisualizadorMultas(decimal multa, int dias)
        {
            dgvVisualizadorMultas.DataSource = livrosBLL.VizualizarMultas(txtFiltro.Text, opc, vis, dias, multa);

            dgvVisualizadorMultas.Columns[1].Width = 200;
            dgvVisualizadorMultas.Columns[2].Width = 100;
            dgvVisualizadorMultas.Columns[3].Width = 40;
            dgvVisualizadorMultas.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvVisualizadorMultas.Columns[4].Width = 120;
            dgvVisualizadorMultas.Columns[5].Width = 40;
            dgvVisualizadorMultas.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvVisualizadorMultas.Columns[6].Width = 40;
            dgvVisualizadorMultas.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvVisualizadorMultas.Columns[7].Width = 60;
            dgvVisualizadorMultas.Columns[7].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvVisualizadorMultas.Columns[0].Visible = false;
        }

        private void BtnFechar_Click(object sender, EventArgs e)
        {
            btnMultas.Visible = true;
            pnlFerramentas.Visible = false;
            pnlFechar.Visible = false;
            dgvLivro.Visible = true;
            dgvVisualizadorMultas.Visible = false;
        }

        private void TxtDias_TextChanged(object sender, EventArgs e)
        {
            try
            {
                try { multa = multa = Convert.ToDecimal(txtDiaMulta.Text); } catch { multa = 0; }
                try { dias = dias = Convert.ToInt32(txtDias.Text); } catch { dias = 0; }

                CarregarVisualizadorMultas(multa, dias);
            }
            catch { }
        }

        private void DgvLivro_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            try { if (e.KeyData == Keys.Up || e.KeyData == Keys.Down) DgvLivro_CellClick(null, null); }
            catch { }
        }

        private void DgvLivro_KeyUp(object sender, KeyEventArgs e)
        {
            try { if(e.KeyData == Keys.Up || e.KeyData == Keys.Down || e.KeyData == Keys.PageUp || e.KeyData == Keys.PageDown || e.KeyData == Keys.Home || e.KeyData == Keys.End) DgvLivro_CellClick(null, null); }
            catch { }
        }

        private void TxtNome_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                if (lblId.Text == "0") BtnIncluir_Click(null, null);
                else BtnAlterar_Click(null, null);
            }
        }

        private void MetroTextBox2_TextChanged(object sender, EventArgs e)
        {
            try
            {
                try { multa = multa = Convert.ToDecimal(txtDiaMulta.Text); } catch { multa = 0; }
                try { dias = dias = Convert.ToInt32(txtDias.Text); } catch { dias = 0; }

                CarregarVisualizadorMultas(multa, dias);
            }
            catch { }
        }

        private void TrmSlideLivros_Tick(object sender, EventArgs e)
        {
            if (hidePainel)
            {
                pnlLivros.Width -= 20;
                if (pnlLivros.Width <= 0)
                {
                    trmSlidePainel.Stop();
                    hidePainel = false;
                    this.Refresh();
                }
            }
            else
            {
                pnlLivros.Width += 20;
                if (pnlLivros.Width == 300)
                {
                    trmSlidePainel.Stop();
                    hidePainel = true;
                    this.Refresh();
                }
            }
        }
    }
}