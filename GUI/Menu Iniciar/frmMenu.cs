using BLL;
using GUI.Alunos;
using GUI.ArquivosMortos.Alunos;
using GUI.ArquivosMortos.Emprestimos;
using GUI.CalendarioEscolar;
using GUI.Carteirinha;
using GUI.ConfigutacoesBLL;
using GUI.Emprestimo;
using GUI.FichaCatalografica;
using GUI.LeitorEspecial;
using GUI.Livros;
using GUI.Login;
using GUI.Multas;
using GUI.Multas.Efetuadas;
using GUI.Relatorios;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace GUI.Menu_Iniciar
{
    public partial class frmMenu : Form
    {
        int
            qtd = 5,
            indexChart = 0;

        bool
            hideCadastro = false,
            hideLeitores = false,
            hideMorto = false,
            inicio = true;

        Form
            form = new Form();

        EstatisticasBLL
            estatisticasBLL = new EstatisticasBLL();

        MenuBLL
            menuBLL = new MenuBLL();

        AlunosBLL
            alunosBLL = new AlunosBLL();

        CalendarioBLL
            calendarioBLL = new CalendarioBLL();

        AlunoFuncionarioMortoBLL
            alunosMortoBLL = new AlunoFuncionarioMortoBLL();

        BackupBLL
            backupBLL = new BackupBLL();

        public frmMenu()
        {
            InitializeComponent();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            GraphicsPath botaoRedondo = new GraphicsPath();
            botaoRedondo.AddEllipse(0, 0, btnConfiguracoes.Width, btnConfiguracoes.Height);
            btnConfiguracoes.Region = new Region(botaoRedondo);
        }

        private void FrmMenu_Load(object sender, EventArgs e)
        {
            cbxFiltroAtrasados.SelectedIndex = 0;
            cbxIndexMaisSaidos.SelectedIndex = 0;
            cbxIntervaloChart.SelectedIndex = 0;
            cbxQtdMaisSaidos.SelectedIndex = 4;
            cbxTipoChart.SelectedIndex = 18;
            CarregarCharts();
            pnlMae.Visible = true;
            inicio = false;

            AjustarTamanhos();
        }

        private void BtnCadastros_Click(object sender, EventArgs e)
        {
            if (hideLeitores) trmSlideLeitores.Start();
            else if (hideMorto) trmSlideMorto.Start();
            trmSlideCadastro.Start();
        }

        private void BtnAlunos_Click(object sender, EventArgs e)
        {
            if (hideLeitores)
            {
                trmSlideLeitores.Start();
            }
            else if (hideMorto)
            {
                trmSlideLeitores.Start();
            }

            PadronizarCores();
            btnCadastros.ForeColor = Color.LightSkyBlue;
            btnAlunos.ForeColor = Color.LightSkyBlue;
            trmSlideCadastro.Start();
            pnlMenu.Visible = false;
            form?.Close();
            form = new frmAlunos
            {
                TopLevel = false,
                FormBorderStyle = FormBorderStyle.None,
                Dock = DockStyle.Fill
            };
            pnlConteudo.Controls.Add(form);
            form.Show();
        }

        private void BtnMenu_Click(object sender, EventArgs e)
        {
            if (hideCadastro) trmSlideCadastro.Start();
            else if (hideLeitores) trmSlideLeitores.Start();
            else if (hideMorto) trmSlideMorto.Start();

            pnlMenu.Visible = true;
            form?.Close();
            CarregarCharts();
            PadronizarCores();
            btnMenu.ForeColor = Color.LightSkyBlue;
        }

        void PadronizarCores()
        {
            btnMenu.ForeColor = Color.Transparent;

            btnCadastros.ForeColor = Color.Transparent;
            btnAlunos.ForeColor = Color.Transparent;
            btnLivro.ForeColor = Color.Transparent;

            btnEmprestimos.ForeColor = Color.Transparent;

            btnRelatorios.ForeColor = Color.Transparent;

            btnLeitores.ForeColor = Color.Transparent;
            btnMultas.ForeColor = Color.Transparent;
            btnCarteirinha.ForeColor = Color.Transparent;
            btnLeitoresEspecais.ForeColor = Color.Transparent;

            btnFichaCartografica.ForeColor = Color.Transparent;

            btnMorto.ForeColor = Color.Transparent;
            btnLeitoresMorto.ForeColor = Color.Transparent;
            btnEmprestimosMorto.ForeColor = Color.Transparent;
            btnEfetuadas.ForeColor = Color.Transparent;

            btnCalendarioEscolar.ForeColor = Color.Transparent;
        }
        private void Button3_Click(object sender, EventArgs e)
        {
            if (hideLeitores) trmSlideLeitores.Start();
            else if (hideMorto) trmSlideLeitores.Start();

            trmSlideCadastro.Start();
            PadronizarCores();
            btnCadastros.ForeColor = Color.LightSkyBlue;
            btnLivro.ForeColor = Color.LightSkyBlue;
            pnlMenu.Visible = false;
            form?.Close();
            form = new frmLivros
            {
                TopLevel = false,
                FormBorderStyle = FormBorderStyle.None,
                Dock = DockStyle.Fill
            };
            pnlConteudo.Controls.Add(form);
            form.Show();
        }

        private void BtnEmprestimos_Click(object sender, EventArgs e)
        {
            if (hideCadastro) trmSlideCadastro.Start();
            else if (hideLeitores) trmSlideLeitores.Start();
            else if (hideMorto) trmSlideMorto.Start();

            PadronizarCores();
            btnEmprestimos.ForeColor = Color.LightSkyBlue;

            pnlMenu.Visible = false;
            form?.Close();
            form = new frmEmprestimos
            {
                TopLevel = false,
                FormBorderStyle = FormBorderStyle.None,
                Dock = DockStyle.Fill
            };
            pnlConteudo.Controls.Add(form);
            form.Show();
        }

        private void CarregarCharts()
        {
            string erro = "Erro Não Previsto!";
            try
            {
                object[] permissoes = menuBLL.BuscarPermissoes();

                lblLogadoEm.Text = menuBLL.BuscarLogado();


                if (Convert.ToBoolean(permissoes[0])) estatisticasBLL.AtualizarModulos();
                if (Convert.ToBoolean(permissoes[1])) estatisticasBLL.AtualizarAnos();
                if (Convert.ToBoolean(permissoes[2])) alunosBLL.ExcluirFinalizadosTecnicos();
                if (Convert.ToBoolean(permissoes[3])) alunosMortoBLL.ExcluirDatados();

                if (Convert.ToBoolean(permissoes[4])) menuBLL.ExcluirEmprestimosAlunosDatados();

                if (Convert.ToBoolean(permissoes[10])) menuBLL.ExcluirEmprestimosFuncionariosDatados();

                if (Convert.ToBoolean(permissoes[5])) menuBLL.ExcluirMultasDatadas();

                if (Convert.ToBoolean(permissoes[6])) calendarioBLL.ExcluirFeriadosPassados();

                if (Convert.ToBoolean(permissoes[11])) estatisticasBLL.MandarEmails();

                CarregarAtrasados(Convert.ToBoolean(permissoes[7]));

                if (Convert.ToBoolean(permissoes[8]))
                {
                    pnlGrafico.Visible = true;
                    sptVertical.Visible = true;
                    CarregarMaisSaidosChart();
                }
                else
                {
                    pnlGrafico.Visible = false;
                    sptVertical.Visible = false;
                }

                if (Convert.ToBoolean(permissoes[9]))
                {
                    pnlGrafico.Width = 506;
                    pnlListaMaisSaidos.Visible = true;
                    sptVertical.Visible = true;
                    CarregarMaisSaidos(0);
                }
                else
                {
                    pnlListaMaisSaidos.Visible = false;
                    sptVertical.Visible = false;
                    pnlGrafico.Width = 1280;
                }


                estatisticasBLL.AtualizarLeitoresEspeciais();
                estatisticasBLL.AtualizarMultas();

                if (!inicio) AjustarTamanhos();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, erro, MessageBoxButtons.OK, MessageBoxIcon.Error);
                erro = "Erro Não Previsto!";
            }

        }

        void CarregarAtrasados(bool permissoes)
        {

            if (permissoes)
            {
                pnlHorizontal.Visible = true;
                dgvAtrasados.DataSource = null;
                dgvAtrasados.DataSource = estatisticasBLL.CarregarDevedores(cbxFiltroAtrasados.SelectedIndex);

                if (cbxFiltroAtrasados.SelectedIndex == 0)
                {
                    dgvAtrasados.ReadOnly = false;
                    dgvAtrasados.Columns[0].Visible = false;
                    dgvAtrasados.Columns[1].ReadOnly = true;
                    dgvAtrasados.Columns[2].ReadOnly = true;
                    dgvAtrasados.Columns[3].ReadOnly = true;
                    dgvAtrasados.Columns[4].ReadOnly = true;
                    dgvAtrasados.Columns[5].ReadOnly = true;
                    dgvAtrasados.Columns[6].ReadOnly = true;
                }
                else dgvAtrasados.ReadOnly = true;
            }
            else
            {
                pnlHorizontal.Visible = false;
                sptMeio.Visible = false;
            }
        }


        void AjustarTamanhos()
        {
            if (dgvAtrasados.Visible)
            {
                if (cbxFiltroAtrasados.SelectedIndex == 0)
                {
                    dgvAtrasados.Columns[2].Width = 40;
                    dgvAtrasados.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    dgvAtrasados.Columns[3].Width = 30;
                    dgvAtrasados.Columns[5].Width = 50;
                    dgvAtrasados.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    dgvAtrasados.Columns[6].Width = 30;
                    dgvAtrasados.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    dgvAtrasados.Columns[7].Width = 30;
                    dgvAtrasados.Columns[8].Width = 30;
                    dgvAtrasados.Columns[9].Width = 30;
                    dgvAtrasados.Columns[10].Width = 50;
                }else
                {
                    dgvAtrasados.Columns[3].Width = 80;
                }
            }

            if (dgvMaisSaidos.Visible)
            {
                dgvMaisSaidos.Columns[1].Width = 50;
                dgvMaisSaidos.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgvMaisSaidos.Columns[4].Width = 70;
                dgvMaisSaidos.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }

            ConfiguracoesBLL configuracoesBLL = new ConfiguracoesBLL();
            float[] tam = configuracoesBLL.BuscarFonte();

            dgvAtrasados.RowsDefaultCellStyle.Font = new Font("Segoe UI", tam[0], GraphicsUnit.Pixel);
            dgvMaisSaidos.RowsDefaultCellStyle.Font = new Font("Segoe UI", tam[0], GraphicsUnit.Pixel);

            dgvAtrasados.RowTemplate.Height = (int)tam[1];
            dgvMaisSaidos.RowTemplate.Height = (int)tam[1];
        }

        void CarregarMaisSaidos(int index)
        {
            dgvMaisSaidos.DataSource = menuBLL.CarregarMaisSaidos(index);
        }

        ArrayList
            livros = new ArrayList(),
            saidas = new ArrayList();

        void CarregarMaisSaidosChart()
        {
            livros = menuBLL.CarregarLivrosSaidos(true, qtd, indexChart);
            saidas = menuBLL.CarregarLivrosSaidos(false, qtd, indexChart);
            chtMaisSaidos.Series[0].Points.DataBindXY(livros, saidas);
        }
        private void BtnMultas_Click(object sender, EventArgs e)
        {
            if (hideCadastro)
            {
                trmSlideCadastro.Start();
            }
            else if (hideMorto)
            {
                trmSlideLeitores.Start();
            }

            trmSlideLeitores.Start();

            PadronizarCores();
            btnLeitores.ForeColor = Color.LightSkyBlue;
            btnMultas.ForeColor = Color.LightSkyBlue;
            pnlMenu.Visible = false;
            form?.Close();
            form = new frmMultas
            {
                TopLevel = false,
                FormBorderStyle = FormBorderStyle.None,
                Dock = DockStyle.Fill
            };
            pnlConteudo.Controls.Add(form);
            form.Show();
        }

        private void DgvAtrasados_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            string erro = "Erro Não Previsto!";
            try
            {

                int IdMulta = Convert.ToInt32(dgvAtrasados[0, dgvAtrasados.CurrentRow.Index].Value);

                bool
                    email = Convert.ToBoolean(dgvAtrasados[7, dgvAtrasados.CurrentRow.Index].Value),
                    SMS = Convert.ToBoolean(dgvAtrasados[8, dgvAtrasados.CurrentRow.Index].Value),
                    Whats = Convert.ToBoolean(dgvAtrasados[9, dgvAtrasados.CurrentRow.Index].Value),
                    Facebook = Convert.ToBoolean(dgvAtrasados[10, dgvAtrasados.CurrentRow.Index].Value);

                menuBLL.AtualizarAvisos(IdMulta, email, SMS, Whats, Facebook);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, erro, MessageBoxButtons.OK, MessageBoxIcon.Error);
                erro = "Erro Não Previsto!";
            }
        }

        private void BtnRelatorios_Click(object sender, EventArgs e)
        {
            if (hideCadastro) trmSlideCadastro.Start();
            else if (hideLeitores) trmSlideLeitores.Start();
            else if (hideMorto) trmSlideMorto.Start();

            PadronizarCores();
            btnRelatorios.ForeColor = Color.LightSkyBlue;
            pnlMenu.Visible = false;
            form?.Close();
            form = new frmRelatorios
            {
                TopLevel = false,
                FormBorderStyle = FormBorderStyle.None,
                Dock = DockStyle.Fill
            };
            pnlConteudo.Controls.Add(form);
            form.Show();
        }

        private void BtnFichaCartografica_Click(object sender, EventArgs e)
        {
            if (hideCadastro) trmSlideCadastro.Start();
            else if (hideLeitores) trmSlideLeitores.Start();
            else if (hideMorto) trmSlideMorto.Start();

            PadronizarCores();
            btnFichaCartografica.ForeColor = Color.LightSkyBlue;
            pnlMenu.Visible = false;
            form?.Close();
            form = new frmFichaCatalograficas
            {
                TopLevel = false,
                FormBorderStyle = FormBorderStyle.None,
                Dock = DockStyle.Fill
            };
            pnlConteudo.Controls.Add(form);
            form.Show();
        }

        private void TrmSlideCadastro_Tick(object sender, EventArgs e)
        {
            if (hideCadastro)
            {
                pnlCadastro.Height -= 20;
                if (pnlCadastro.Height == 0)
                {
                    trmSlideCadastro.Stop();
                    hideCadastro = false;
                    this.Refresh();
                }
            }
            else
            {
                pnlCadastro.Height += 20;
                if (pnlCadastro.Height == 100)
                {
                    trmSlideCadastro.Stop();
                    hideCadastro = true;
                    this.Refresh();
                }
            }
        }

        private void BtnLeitores_Click(object sender, EventArgs e)
        {
            if (hideCadastro) trmSlideCadastro.Start();
            else if (hideMorto) trmSlideMorto.Start();
            trmSlideLeitores.Start();
        }

        private void BtnLeitoresEspecais_Click(object sender, EventArgs e)
        {
            if (hideCadastro) trmSlideCadastro.Start();
            else if (hideMorto) trmSlideLeitores.Start();
            trmSlideLeitores.Start();

            PadronizarCores();
            btnLeitores.ForeColor = ForeColor = Color.LightSkyBlue;
            btnLeitoresEspecais.ForeColor = Color.LightSkyBlue;
            pnlMenu.Visible = false;
            form?.Close();
            form = new frmLeitorEspecial
            {
                TopLevel = false,
                FormBorderStyle = FormBorderStyle.None,
                Dock = DockStyle.Fill
            };
            pnlConteudo.Controls.Add(form);
            form.Show();
        }

        private void BtnMorto_Click(object sender, EventArgs e)
        {
            trmSlideMorto.Start();
        }

        private void BtnAlunosMorto_Click(object sender, EventArgs e)
        {
            if (hideCadastro)
            {
                trmSlideCadastro.Start();
            }
            else if (hideLeitores)
            {
                trmSlideLeitores.Start();
            }

            trmSlideMorto.Start();
            PadronizarCores();
            btnLeitoresMorto.ForeColor = Color.LightSkyBlue;
            btnMorto.ForeColor = Color.LightSkyBlue;
            pnlMenu.Visible = false;
            form?.Close();
            form = new frmAlunosMorto
            {
                TopLevel = false,
                FormBorderStyle = FormBorderStyle.None,
                Dock = DockStyle.Fill
            };
            pnlConteudo.Controls.Add(form);
            form.Show();
        }

        private void BtnEmprestimosMorto_Click(object sender, EventArgs e)
        {
            if (hideCadastro)
            {
                trmSlideCadastro.Start();
            }
            else if (hideLeitores)
            {
                trmSlideLeitores.Start();
            }

            trmSlideMorto.Start();
            PadronizarCores();
            btnEmprestimosMorto.ForeColor = Color.LightSkyBlue;
            btnMorto.ForeColor = Color.LightSkyBlue;
            pnlMenu.Visible = false;
            form?.Close();
            form = new frmEmprestimosAlunoMorto
            {
                TopLevel = false,
                FormBorderStyle = FormBorderStyle.None,
                Dock = DockStyle.Fill
            };
            pnlConteudo.Controls.Add(form);
            form.Show();
        }

        private void BtnCalendarioEscolar_Click(object sender, EventArgs e)
        {
            if (hideCadastro) trmSlideCadastro.Start();
            else if (hideLeitores) trmSlideLeitores.Start();
            else if (hideMorto) trmSlideMorto.Start();

            PadronizarCores();
            btnCalendarioEscolar.ForeColor = Color.LightSkyBlue;
            pnlMenu.Visible = false;
            form?.Close();
            form = new frmCalendarioEscolar
            {
                TopLevel = false,
                FormBorderStyle = FormBorderStyle.None,
                Dock = DockStyle.Fill
            };
            pnlConteudo.Controls.Add(form);
            form.Show();
        }

        private void BtnFechar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja encerrar o programa??", "Encerrar Programa!", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                CarregarCharts();
                this.Close();
            }
        }

        private void BtnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void BtnCarteirinha_Click(object sender, EventArgs e)
        {
            if (hideCadastro) trmSlideCadastro.Start();
            else if (hideMorto) trmSlideLeitores.Start();

            trmSlideLeitores.Start();

            PadronizarCores();
            btnLeitores.ForeColor = Color.LightSkyBlue;
            btnCarteirinha.ForeColor = Color.LightSkyBlue;

            pnlMenu.Visible = false;
            form?.Close();
            form = new frmCarteirinha
            {
                TopLevel = false,
                FormBorderStyle = FormBorderStyle.None,
                Dock = DockStyle.Fill
            };
            pnlConteudo.Controls.Add(form);
            form.Show();
        }

        private void TrmSlideMorto_Tick(object sender, EventArgs e)
        {
            if (hideMorto)
            {
                pnlMorto.Height -= 30;
                if (pnlMorto.Height <= 0)
                {
                    trmSlideMorto.Stop();
                    hideMorto = false;
                    this.Refresh();
                }
            }
            else
            {
                pnlMorto.Height += 30;
                if (pnlMorto.Height == 150)
                {
                    trmSlideMorto.Stop();
                    hideMorto = true;
                    this.Refresh();
                }
            }
        }

        private void BtnEfetuadas_Click(object sender, EventArgs e)
        {
            if (hideCadastro) trmSlideCadastro.Start();
            else if (hideLeitores) trmSlideLeitores.Start();

            trmSlideMorto.Start();
            PadronizarCores();
            btnEfetuadas.ForeColor = Color.LightSkyBlue;
            btnMorto.ForeColor = Color.LightSkyBlue;
            pnlMenu.Visible = false;
            form?.Close();
            form = new frmPagas
            {
                TopLevel = false,
                FormBorderStyle = FormBorderStyle.None,
                Dock = DockStyle.Fill
            };
            pnlConteudo.Controls.Add(form);
            form.Show();
        }

        private void CbxTipoChart_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxTipoChart.SelectedIndex == 0) chtMaisSaidos.Series[0].ChartType = SeriesChartType.Point;
            else if (cbxTipoChart.SelectedIndex == 1) chtMaisSaidos.Series[0].ChartType = SeriesChartType.FastPoint;
            else if (cbxTipoChart.SelectedIndex == 2) chtMaisSaidos.Series[0].ChartType = SeriesChartType.Bubble;
            else if (cbxTipoChart.SelectedIndex == 3) chtMaisSaidos.Series[0].ChartType = SeriesChartType.Line;
            else if (cbxTipoChart.SelectedIndex == 4) chtMaisSaidos.Series[0].ChartType = SeriesChartType.Spline;
            else if (cbxTipoChart.SelectedIndex == 5) chtMaisSaidos.Series[0].ChartType = SeriesChartType.StepLine;
            else if (cbxTipoChart.SelectedIndex == 6) chtMaisSaidos.Series[0].ChartType = SeriesChartType.FastLine;
            else if (cbxTipoChart.SelectedIndex == 7) chtMaisSaidos.Series[0].ChartType = SeriesChartType.Bar;
            else if (cbxTipoChart.SelectedIndex == 8) chtMaisSaidos.Series[0].ChartType = SeriesChartType.StackedBar;
            else if (cbxTipoChart.SelectedIndex == 9) chtMaisSaidos.Series[0].ChartType = SeriesChartType.StackedBar100;
            else if (cbxTipoChart.SelectedIndex == 10) chtMaisSaidos.Series[0].ChartType = SeriesChartType.Column;
            else if (cbxTipoChart.SelectedIndex == 11) chtMaisSaidos.Series[0].ChartType = SeriesChartType.StackedColumn;
            else if (cbxTipoChart.SelectedIndex == 12) chtMaisSaidos.Series[0].ChartType = SeriesChartType.StackedColumn100;
            else if (cbxTipoChart.SelectedIndex == 13) chtMaisSaidos.Series[0].ChartType = SeriesChartType.Area;
            else if (cbxTipoChart.SelectedIndex == 14) chtMaisSaidos.Series[0].ChartType = SeriesChartType.SplineArea;
            else if (cbxTipoChart.SelectedIndex == 15) chtMaisSaidos.Series[0].ChartType = SeriesChartType.StackedArea;
            else if (cbxTipoChart.SelectedIndex == 16) chtMaisSaidos.Series[0].ChartType = SeriesChartType.StackedArea100;
            else if (cbxTipoChart.SelectedIndex == 17) chtMaisSaidos.Series[0].ChartType = SeriesChartType.Pie;
            else if (cbxTipoChart.SelectedIndex == 18) chtMaisSaidos.Series[0].ChartType = SeriesChartType.Doughnut;
            else if (cbxTipoChart.SelectedIndex == 19) chtMaisSaidos.Series[0].ChartType = SeriesChartType.Stock;
            else if (cbxTipoChart.SelectedIndex == 20) chtMaisSaidos.Series[0].ChartType = SeriesChartType.Candlestick;
            else if (cbxTipoChart.SelectedIndex == 21) chtMaisSaidos.Series[0].ChartType = SeriesChartType.Range;
            else if (cbxTipoChart.SelectedIndex == 22) chtMaisSaidos.Series[0].ChartType = SeriesChartType.SplineRange;
            else if (cbxTipoChart.SelectedIndex == 23) chtMaisSaidos.Series[0].ChartType = SeriesChartType.RangeBar;
            else if (cbxTipoChart.SelectedIndex == 24) chtMaisSaidos.Series[0].ChartType = SeriesChartType.RangeColumn;
            else if (cbxTipoChart.SelectedIndex == 25) chtMaisSaidos.Series[0].ChartType = SeriesChartType.Radar;
            else if (cbxTipoChart.SelectedIndex == 26) chtMaisSaidos.Series[0].ChartType = SeriesChartType.Polar;
            else if (cbxTipoChart.SelectedIndex == 27) chtMaisSaidos.Series[0].ChartType = SeriesChartType.ErrorBar;
            else if (cbxTipoChart.SelectedIndex == 28) chtMaisSaidos.Series[0].ChartType = SeriesChartType.BoxPlot;
            else if (cbxTipoChart.SelectedIndex == 29) chtMaisSaidos.Series[0].ChartType = SeriesChartType.Renko;
            else if (cbxTipoChart.SelectedIndex == 30) chtMaisSaidos.Series[0].ChartType = SeriesChartType.ThreeLineBreak;
            else if (cbxTipoChart.SelectedIndex == 31) chtMaisSaidos.Series[0].ChartType = SeriesChartType.Kagi;
            else if (cbxTipoChart.SelectedIndex == 32) chtMaisSaidos.Series[0].ChartType = SeriesChartType.PointAndFigure;
            else if (cbxTipoChart.SelectedIndex == 33) chtMaisSaidos.Series[0].ChartType = SeriesChartType.Funnel;
            else if (cbxTipoChart.SelectedIndex == 34) chtMaisSaidos.Series[0].ChartType = SeriesChartType.Pyramid;
        }

        private void Sld3D_Click(object sender, EventArgs e)
        {
            if (sld3D.IsOn) chtMaisSaidos.ChartAreas[0].Area3DStyle.Enable3D = true;
            else chtMaisSaidos.ChartAreas[0].Area3DStyle.Enable3D = false;
        }

        private void CbxQtdMaisSaidos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxQtdMaisSaidos.SelectedIndex == 0) qtd = 1;
            else if (cbxQtdMaisSaidos.SelectedIndex == 1) qtd = 2;
            else if (cbxQtdMaisSaidos.SelectedIndex == 2) qtd = 3;
            else if (cbxQtdMaisSaidos.SelectedIndex == 3) qtd = 4;
            else if (cbxQtdMaisSaidos.SelectedIndex == 4) qtd = 5;
            else if (cbxQtdMaisSaidos.SelectedIndex == 5) qtd = 6;
            else if (cbxQtdMaisSaidos.SelectedIndex == 6) qtd = 7;
            else if (cbxQtdMaisSaidos.SelectedIndex == 7) qtd = 8;
            else if (cbxQtdMaisSaidos.SelectedIndex == 8) qtd = 9;
            else if (cbxQtdMaisSaidos.SelectedIndex == 9) qtd = 10;

            CarregarMaisSaidosChart();
        }

        private void DgvAtrasados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void CbxFiltroAtrasados_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!inicio)
            {
                CarregarAtrasados(true);
                AjustarTamanhos();
            }
        }

        private void CbxIntervaloChart_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!inicio)
            {
                if (cbxIntervaloChart.SelectedIndex == 0) indexChart = 0;
                else if (cbxIntervaloChart.SelectedIndex == 1) indexChart = 1;
                else if (cbxIntervaloChart.SelectedIndex == 2) indexChart = 2;
                else if (cbxIntervaloChart.SelectedIndex == 3) indexChart = 3;
                else if (cbxIntervaloChart.SelectedIndex == 4) indexChart = 4;
                else if (cbxIntervaloChart.SelectedIndex == 5) indexChart = 5;
                else indexChart = 6;

                CarregarMaisSaidosChart();
            }
        }

        private void BtnConfiguracoes_Click(object sender, EventArgs e)
        {
            PadronizarCores();
            pnlMenu.Visible = false;
            form?.Close();
            form = new frmConfiguracoes
            {
                TopLevel = false,
                FormBorderStyle = FormBorderStyle.None,
                Dock = DockStyle.Fill
            };
            pnlConteudo.Controls.Add(form);
            form.Show();
        }

        private void CbxIndexMaisSaidos_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index;

            if (!inicio)
            {
                if (cbxIndexMaisSaidos.SelectedIndex == 0) index = 0;
                else if (cbxIndexMaisSaidos.SelectedIndex == 1) index = 1;
                else if (cbxIndexMaisSaidos.SelectedIndex == 2) index = 2;
                else if (cbxIndexMaisSaidos.SelectedIndex == 3) index = 3;
                else if (cbxIndexMaisSaidos.SelectedIndex == 4) index = 4;
                else if (cbxIndexMaisSaidos.SelectedIndex == 5) index = 5;
                else index = 6;

                CarregarMaisSaidos(index);
            }
        }

        private void FrmMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            ConfiguracoesBLL config = new ConfiguracoesBLL();
            if (config.VerificarPermissao()) backupBLL.GerarBackup();

            frmLogin login = new frmLogin();
            login.Close();
        }

        private void TrmSlideLeitores_Tick(object sender, EventArgs e)
        {
            if (hideLeitores)
            {
                pnlLeitores.Height -= 30;
                if (pnlLeitores.Height <= 0)
                {
                    trmSlideLeitores.Stop();
                    hideLeitores = false;
                    this.Refresh();
                }
            }
            else
            {
                pnlLeitores.Height += 30;
                if (pnlLeitores.Height == 150)
                {
                    trmSlideLeitores.Stop();
                    hideLeitores = true;
                    this.Refresh();
                }
            }
        }
    }
}