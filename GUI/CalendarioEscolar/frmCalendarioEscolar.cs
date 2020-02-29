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

namespace GUI.CalendarioEscolar
{
    public partial class frmCalendarioEscolar : Form
    {
        bool modoFixo = false;

        int opc = 3;

        DateTime data = DateTime.Now;

        CalendarioBLL calendarioBLL = new CalendarioBLL();

        CalendarioInformation calendario;

        public frmCalendarioEscolar()
        {
            InitializeComponent();
        }

        private void FrmCalendarioEscolar_Load(object sender, EventArgs e)
        {
            txtFiltroData.Text = DateTime.Now.ToShortDateString();
            cbxOpcFiltro.SelectedIndex = 2;
        }

        private void DtCalendario_ValueChanged(object sender, EventArgs e)
        {
            if(modoFixo)
            {
                txtDia.Text = dtCalendario.Value.ToString("dd");
                txtMes.Text = dtCalendario.Value.ToString("MM");
            }
            else
            {

                txtData.Text = dtCalendario.Value.ToShortDateString();
            }
        }

        private void BtnMovel_Click(object sender, EventArgs e)
        {
            modoFixo = false;

            gbxMoveis.Visible = true;
            gbxFixos.Visible = false;

            if(cbxOpcFiltro.SelectedIndex == 0)
            {
                pnlFiltro.Visible = false;
                txtFiltroData.Visible = true;
            }

            dgvDatas.DataSource = null;
            dgvDatas.DataSource = calendarioBLL.CarregarDatas(modoFixo, opc, txtFiltroDia.Text, txtFiltroMes.Text, data, txtFiltroFeriado.Text);
        }

        private void BtnFixo_Click(object sender, EventArgs e)
        {
            modoFixo = true;

            gbxMoveis.Visible = false;
            gbxFixos.Visible = true;

            if (cbxOpcFiltro.SelectedIndex == 0)
            {
                pnlFiltro.Visible = true;
                txtFiltroData.Visible = false;
            }

            dgvDatas.DataSource = null;
            dgvDatas.DataSource = calendarioBLL.CarregarDatas(modoFixo, opc, txtFiltroDia.Text, txtFiltroMes.Text, data, txtFiltroFeriado.Text);
        }

        private void BtnIncluir_Click(object sender, EventArgs e)
        {
            string erro = "Erro Não Previsto!";
            try
            {
                if(modoFixo)
                {
                    try { Convert.ToDateTime(txtDia.Text + "/" + txtMes.Text + "/" + DateTime.Now.Year) ; }
                    catch
                    {
                        erro = "Data Inválida!";
                        throw new Exception("A data informada é inválida!");
                    }

                    calendario = new CalendarioInformation(int.Parse(txtDia.Text),
                                                           int.Parse(txtMes.Text),
                                                           txtNome2.Text);

                    int[] resultado = calendarioBLL.VerificarEmprestimos(modoFixo, txtDia.Text, txtMes.Text, txtData.Text);

                    if(resultado[1] > 0 || resultado[0] > 0)
                    {
                        if(MessageBox.Show("Há " + resultado[0] + "empréstimo(s) pendente(s) para alunos e " + resultado[1] + " para funcionários para o dia não letivo a ser definido. Ao confimar as datas do empréstimo de todos serão adiados. Continuar?", "Adiar Empréstimos!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                        {

                            calendarioBLL.InserirData(calendario, modoFixo, ref erro);
                            MessageBox.Show("Feriado incluído com sucesso!", "Inclusão de Feriado!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                            AtualizaGrid();
                        }
                    }
                    else
                    {
                        if (MessageBox.Show("Adicionar o dia não letivo?", "Adiar Empréstimos!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            calendarioBLL.InserirData(calendario, modoFixo, ref erro);
                            MessageBox.Show("Feriado incluído com sucesso!", "Inclusão de Feriado!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                            AtualizaGrid();

                        }
                    }
                }
                else
                {
                    try { Convert.ToDateTime(txtData.Text); }
                    catch
                    {
                        erro = "Data Inválida!";
                        throw new Exception("A data informada é inválida!");
                    }

                    calendario = new CalendarioInformation(txtNome.Text,
                                                           Convert.ToDateTime(txtData.Text));

                    int[] resultado = calendarioBLL.VerificarEmprestimos(modoFixo, txtDia.Text, txtMes.Text, txtData.Text);

                    if (resultado[1] > 0 || resultado[0] > 0)
                    {
                        if (MessageBox.Show("Há " + resultado[0] + "empréstimo(s) pendente(s) para alunos e " + resultado[1] + " para funcionários para o dia deste feriado a ser definido. Ao confimar as datas do empréstimo de todos serão adiados. Continuar?", "Adiar Empréstimos!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                        {
                            calendarioBLL.InserirData(calendario, modoFixo, ref erro);
                            MessageBox.Show("Feriado incluído com sucesso!", "Inclusão de Feriado!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                            AtualizaGrid();
                        }
                    }
                    else
                    {
                        if (MessageBox.Show("Adicionar o dia não letivo?", "Adiar Empréstimos!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            calendarioBLL.InserirData(calendario, modoFixo, ref erro);
                            MessageBox.Show("Feriado incluído com sucesso!", "Inclusão de Feriado!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                            AtualizaGrid();
                        }
                    }
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message, erro, MessageBoxButtons.OK, MessageBoxIcon.Error);
                erro = "Erro Não Previsto!";
            }
        }

        void AtualizaGrid()
        {
            string erro = "Erro Não Previsto!";
            try
            {
                dgvDatas.DataSource = null;
                dgvDatas.DataSource = calendarioBLL.CarregarDatas(modoFixo, opc, txtFiltroDia.Text, txtFiltroMes.Text, data, txtFiltroFeriado.Text);

                ConfiguracoesBLL configuracoesBLL = new ConfiguracoesBLL();
                float[] tam = configuracoesBLL.BuscarFonte();

                dgvDatas.RowsDefaultCellStyle.Font = new Font("Segoe UI", tam[0], GraphicsUnit.Pixel);

                dgvDatas.RowTemplate.Height = (int)tam[1];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, erro, MessageBoxButtons.OK, MessageBoxIcon.Error);
                erro = "Erro Não Previsto!";
            }
        }

        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            string erro = "Erro Não Previsto!";
            try
            {
                if(modoFixo)
                {
                    calendario = new CalendarioInformation(int.Parse(txtDia.Text),
                                                           int.Parse(txtMes.Text),
                                                           txtNome2.Text);

                    calendarioBLL.DeletarData(calendario, modoFixo);
                    MessageBox.Show("Data excluída com sucesso!", "Exclusão de Feriado!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    AtualizaGrid();
                }
                else
                {
                    try { calendario.Data = Convert.ToDateTime(txtData.Text); }
                    catch
                    {
                        erro = "Data Inválida!";
                        throw new Exception("A data está em um formato incorreto!");
                    }

                    calendarioBLL.DeletarData(calendario, modoFixo);
                    MessageBox.Show("Data excluída com sucesso!", "Exclusão de Feriado!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    AtualizaGrid();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, erro, MessageBoxButtons.OK, MessageBoxIcon.Error);
                erro = "Erro Não Previsto!";
            }
        }

        private void DgvDatas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
           {
                if (modoFixo)
                {
                    txtDia.Text = dgvDatas[0, dgvDatas.CurrentRow.Index].Value.ToString();
                    txtMes.Text = dgvDatas[1, dgvDatas.CurrentRow.Index].Value.ToString();
                    txtNome2.Text = dgvDatas[2, dgvDatas.CurrentRow.Index].Value.ToString();
                }
                else
                {
                    txtData.Text = dgvDatas[0, dgvDatas.CurrentRow.Index].Value.ToString();
                    txtNome.Text = dgvDatas[1, dgvDatas.CurrentRow.Index].Value.ToString();
                }
            }catch
            {
                txtDia.Text = "";
                txtMes.Text = "";
                txtNome2.Text = "";
                txtData.Text = "";
                txtNome.Text = "";
            }

        }

        private void BtnLimpar_Click(object sender, EventArgs e)
        {
            txtNome.Text = "";
            txtNome2.Text = "";
            txtDia.Text = "";
            txtMes.Text = "";
            txtData.Text = "";
        }

        private void CbxOpcFiltro_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (!modoFixo)
                {
                    if (cbxOpcFiltro.SelectedIndex == 0)
                    {
                        pnlFiltro.Visible = false;
                        txtFiltroData.Visible = true;
                        txtFiltroFeriado.Text = "";
                        txtFiltroFeriado.Visible = false;

                        opc = 0;

                        AtualizaGrid();
                    }
                    else if (cbxOpcFiltro.SelectedIndex == 1)
                    {
                        pnlFiltro.Visible = false;
                        txtFiltroData.Visible = false;
                        txtFiltroFeriado.Text = "";
                        txtFiltroFeriado.Visible = true;

                        opc = 1;

                        AtualizaGrid();
                    }
                    else
                    {
                        pnlFiltro.Visible = false;
                        txtFiltroData.Visible = false;
                        txtFiltroFeriado.Text = "";
                        txtFiltroFeriado.Visible = false;

                        opc = 2;

                        AtualizaGrid();
                    }
                }
                else
                {
                    if (cbxOpcFiltro.SelectedIndex == 0)
                    {
                        pnlFiltro.Visible = true;
                        txtFiltroData.Visible = false;
                        txtFiltroFeriado.Text = "";
                        txtFiltroFeriado.Visible = false;

                        opc = 0;

                        AtualizaGrid();
                    }
                    else if (cbxOpcFiltro.SelectedIndex == 1)
                    {
                        pnlFiltro.Visible = false;
                        txtFiltroData.Visible = false;
                        txtFiltroFeriado.Text = "";
                        txtFiltroFeriado.Visible = true;

                        opc = 1;

                        AtualizaGrid();
                    }
                    else
                    {
                        pnlFiltro.Visible = false;
                        txtFiltroData.Visible = false;
                        txtFiltroFeriado.Text = "";
                        txtFiltroFeriado.Visible = false;

                        opc = 2;

                        AtualizaGrid();
                    }
                }
            }catch { }
        }

        private void TxtFiltroDia_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Convert.ToInt32(txtFiltroDia.Text);
                AtualizaGrid();
            }catch
            {
                txtFiltroDia.Text = "";
                AtualizaGrid();
            }
        }

        private void TxtFiltroMes_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Convert.ToInt32(txtFiltroMes.Text);
                AtualizaGrid();
            }
            catch
            {
                txtFiltroMes.Text = "";
                AtualizaGrid();
            }
        }

        private void TxtFiltroData_TextChanged(object sender, EventArgs e)
        {
            try
            {
                data = Convert.ToDateTime(txtFiltroData.Text);
                if (data < Convert.ToDateTime("01/01/1800")) data = DateTime.Now;
                AtualizaGrid();
            }catch
            {
                data = DateTime.Now;
                AtualizaGrid();
            }
        }

        private void TxtFiltroFeriado_TextChanged(object sender, EventArgs e)
        {
            AtualizaGrid();
        }

        private void TxtData_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyData == Keys.Enter) BtnIncluir_Click(null, null);
            }catch { }
        }
    }
}
