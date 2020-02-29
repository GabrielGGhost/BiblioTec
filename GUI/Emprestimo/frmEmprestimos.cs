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

namespace GUI.Emprestimo
{
    public partial class frmEmprestimos : Form
    {
        public frmEmprestimos()
        {
            InitializeComponent();
        }

        //EmprestimosBLL emprestimosBLL = new EmprestimosBLL();

        //EmprestimoInformation emprestimo;

        //int
        //    opc = 0,
        //    vis = 0,
        //    opcFiltro = 2;

        //bool
        //    aluno = true,
        //    inicio = true;

        //DateTime data;


        //private void FrmEmprestimos_Load(object sender, EventArgs e)
        //{
        //    if (emprestimosBLL.BuscarPermissaoMaxLivros()) lblMaxLivros.Text = emprestimosBLL.BuscarMaxLivros();
        //    else lblMaxLivros.Text = "0";

        //    cbxLeitor.ValueMember = "ID";
        //    cbxFiltroOpc.SelectedIndex = 0;
        //    cbxOpcFiltraLivro.SelectedIndex = 2;
        //    cbxVis.SelectedIndex = 0;
        //    dtEmprestimo.Text = DateTime.Now.ToShortDateString();
        //    data = dtEmprestimo.Value;
        //    CalcularDatas();
        //    inicio = false;
        //}

        //void CalcularDatas()
        //{
        //    try
        //    {
        //        dtDevolucao.Value = emprestimosBLL.CalcularDataDevolucao(data);
        //    }
        //    catch { }
        //}

        //void AtualizaGrid()
        //{
        //    string erro = "Erro Não Previsto!";
        //    try
        //    {
        //        CarregarLeitores();
        //        dgvLivros.DataSource = null;
        //        dgvLivros.DataSource = emprestimosBLL.CarregarLivros(opc, vis, txtFiltro.Text.Trim(), cbxFiltro.Text.Trim(), opcFiltro);
        //        dgvLivros.Columns[0].Width = 30;
        //        dgvLivros.Columns[0].Visible = false;

        //        if (cbxFiltroOpc.SelectedIndex == 0)
        //        {
        //            dgvLivros.Columns[1].Width = 210;
        //            dgvLivros.Columns[2].Width = 100;
        //            dgvLivros.Columns[3].Width = 50;
        //            dgvLivros.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        //            dgvLivros.Columns[5].Width = 50;
        //            dgvLivros.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        //            dgvLivros.Columns[6].Width = 60;
        //            dgvLivros.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

        //            if (cbxVis.SelectedIndex == 2)
        //            {
        //                dgvLivros.Columns[7].Visible = true;
        //                dgvLivros.Columns[7].Width = 80;
        //            }
        //            else dgvLivros.Columns[7].Visible = false;
        //        }
        //        else if (cbxFiltroOpc.SelectedIndex == 1)
        //        {
        //            dgvLivros.Columns[3].Width = 30;
        //            dgvLivros.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        //            dgvLivros.Columns[5].Width = 50;
        //            dgvLivros.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        //            dgvLivros.Columns[6].Width = 50;
        //            dgvLivros.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        //            dgvLivros.Columns[7].Width = 60;
        //            dgvLivros.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        //            dgvLivros.Columns[8].Visible = false;
        //        }
        //        else if(cbxFiltroOpc.SelectedIndex == 2)
        //        {
        //            dgvLivros.Columns[1].Width = 210;
        //            dgvLivros.Columns[2].Width = 100;
        //            dgvLivros.Columns[3].Width = 50;
        //            dgvLivros.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        //            dgvLivros.Columns[5].Width = 50;
        //            dgvLivros.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        //            dgvLivros.Columns[6].Width = 60;
        //            dgvLivros.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        //            dgvLivros.Columns[7].Visible = false;
        //        }

        //        ConfiguracoesBLL configuracoesBLL = new ConfiguracoesBLL();
        //        float[] tam = configuracoesBLL.BuscarFonte();

        //        dgvLivros.RowsDefaultCellStyle.Font = new Font("Segoe UI", tam[0], GraphicsUnit.Pixel);
        //        dgvLivros.RowTemplate.Height = (int)tam[1];
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message, erro, MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        erro = "Erro Não Previsto!";
        //    }

        //}

        //void CarregarLeitores()
        //{
        //    cbxLeitor.DataSource = emprestimosBLL.ListarLeitores(aluno);
        //    if (aluno) cbxLeitor.DisplayMember = "RM";
        //    else cbxLeitor.DisplayMember = "NOME";
        //    cbxLeitor.Text = "";
        //}

        //private void CbxAlunos_KeyDown(object sender, KeyEventArgs e)
        //{
        //    string erro = "Erro Não Esperado!";
        //    try
        //    {
        //        dtEmprestimo.Enabled = true;
        //        if (e.KeyData == Keys.Enter)
        //        {
        //            cbxFiltroOpc.SelectedIndex = 0;

        //            lblTrocar.Visible = true;
        //            lblNomeLeitor.Text = cbxLeitor.Text;
        //            cbxLeitor.Visible = false;
        //            lblNomeLeitor.Visible = true;

        //            if (aluno)
        //            {
        //                gbxAlunos.Visible = true;
        //                gbxFuncionario.Visible = false;

        //                if (!emprestimosBLL.VerificarExistencia(true, cbxLeitor.Text, ref erro))
        //                {
        //                    erro = "Aluno Inexistente!";
        //                    throw new Exception("Não foi possível localizar este aluno!");
        //                }

        //                cbxLeitor.ValueMember = "ID";
        //                lblId.Text = cbxLeitor.SelectedValue.ToString();

        //                cbxLeitor.ValueMember = "NOME";
        //                lblNome.Text = cbxLeitor.SelectedValue.ToString();

        //                cbxLeitor.ValueMember = "RM";
        //                lblRM.Text = cbxLeitor.SelectedValue.ToString();

        //                cbxLeitor.ValueMember = "Curso";
        //                lblCurso.Text = cbxLeitor.SelectedValue.ToString();

        //                cbxLeitor.ValueMember = "Modulo";
        //                lblModulo.Text = cbxLeitor.SelectedValue.ToString();

        //                cbxLeitor.ValueMember = "Leitor_Especial";

        //                bool resultado = Convert.ToBoolean(cbxLeitor.SelectedValue);

        //                if (DateTime.Now >= Convert.ToDateTime("25/06/" + DateTime.Now.Year) && DateTime.Now <= Convert.ToDateTime("04/07/" + DateTime.Now.Year)
        //                    || DateTime.Now >= Convert.ToDateTime("25/11/" + DateTime.Now.Year) && DateTime.Now <= Convert.ToDateTime("04/12/" + DateTime.Now.Year))
        //                {
        //                    dtDevolucao.Enabled = true;
        //                }
        //                else
        //                {
        //                    if (resultado)
        //                    {
        //                        dtDevolucao.Enabled = true;
        //                    }
        //                    else
        //                    {
        //                        dtDevolucao.Enabled = false;
        //                    }
        //                }

        //                lblLivrosEmprestados.Text = emprestimosBLL.CarregarEmprestados(lblId.Text);

        //                if (lblMaxLivros.Text != "0")
        //                {
        //                    if (int.Parse(lblLivrosEmprestados.Text) >= int.Parse(lblMaxLivros.Text))
        //                    {
        //                        btnEmprestar.Enabled = false;
        //                        lblIdLivro.Text = "0";
        //                        lblNomeLivro.Text = "";
        //                        lblLocalizacaoLivro.Text = "";
        //                        lblAnoLivro.Text = "";
        //                        lblAutorLivro.Text = "";
        //                        lblTomboLivro.Text = "";
        //                        txtMultaLivro.Text = "";
        //                        lblStatus.Text = "";
        //                        if (resultado)
        //                        {
        //                            if (MessageBox.Show("Este aluno já possui o máximo de livros permitidos mas é um leitor especial!\nPermitir empréstimos?", "Máximo de Livros!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes) btnEmprestar.Enabled = true;
        //                        }
        //                        else MessageBox.Show("Este aluno já possui o máximo de livros permitidos!", "Máximo de Livros!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //                    }
        //                    else btnEmprestar.Enabled = true;
        //                }
        //            }
        //            else
        //            {
        //                gbxAlunos.Visible = false;
        //                gbxFuncionario.Visible = true;

        //                if (!emprestimosBLL.VerificarExistencia(false, cbxLeitor.Text, ref erro))
        //                {
        //                    erro = "Funcionário Inexistente!";
        //                    throw new Exception("Não foi possível localizar este funcionário!");
        //                }

        //                cbxLeitor.ValueMember = "ID_FUNCIONARIO";
        //                lblIdFuncionario.Text = cbxLeitor.SelectedValue.ToString();

        //                lblNomeFuncionario.Text = cbxLeitor.Text;

        //                cbxLeitor.ValueMember = "FUNCAO";
        //                lblFuncao.Text = cbxLeitor.SelectedValue.ToString();

        //                lblEmprestadosFuncionario.Text = emprestimosBLL.CarregarEmprestadosFunc(lblIdFuncionario.Text);

        //                if (lblMaxLivros.Text != "0")
        //                {
        //                    if (int.Parse(lblEmprestadosFuncionario.Text) >= int.Parse(lblMaxLivros.Text))
        //                    {
        //                        MessageBox.Show("Este funcionário já atingiu o limite de livros!", "Máximo de Livros", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //                        btnEmprestar.Enabled = false;
        //                        lblIdLivro.Text = "0";
        //                        lblNomeLivro.Text = "";
        //                        lblLocalizacaoLivro.Text = "";
        //                        lblAnoLivro.Text = "";
        //                        lblAutorLivro.Text = "";
        //                        lblTomboLivro.Text = "";
        //                        txtMultaLivro.Text = "";
        //                        lblStatus.Text = "";
        //                    }
        //                    else btnEmprestar.Enabled = true;
        //                }
        //            }
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        BtnTrocar_Click(null, null);
        //        MessageBox.Show(ex.Message, erro, MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        erro = "Erro Não Esperado!";
        //    }
        //}

        //private void BtnTrocar_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        lblTrocar.Visible = false;
        //        cbxLeitor.Visible = true;
        //        lblNomeLeitor.Visible = false;
        //        dgvLivros.Enabled = true;
        //        btnEmprestar.Enabled = true;

        //        lblId.Text = "0";
        //        lblNome.Text = "";
        //        lblRM.Text = "";
        //        lblCurso.Text = "";
        //        lblModulo.Text = "";
        //        lblLivrosEmprestados.Text = "";

        //        lblIdFuncionario.Text = "0";
        //        lblNomeFuncionario.Text = "";
        //        lblFuncao.Text = "";
        //        lblEmprestadosFuncionario.Text = "";
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message);
        //    }
        //}

        //private void RadFuncionario_CheckedChanged(object sender, EventArgs e)
        //{
        //    if (radFuncionario.Checked)
        //    {
        //        lblTipoLeitor.Text = "Func:";
        //        aluno = false;

        //        if (cbxFiltroOpc.SelectedIndex != 2) cbxFiltroOpc.SelectedIndex = 0;
        //        lblNomeLeitor.Visible = false;
        //        cbxLeitor.Visible = true;
        //        lblTrocar.Visible = false;

        //        gbxAlunos.Visible = false;
        //        gbxFuncionario.Visible = true;

        //        dtDevolucao.Enabled = true;

        //        lblId.Text = "0";
        //        lblNome.Text = "";
        //        lblRM.Text = "";
        //        lblCurso.Text = "";
        //        lblModulo.Text = "";

        //        if (emprestimosBLL.BuscarPermissaoMaxLivrosFuncionarios()) lblMaxLivros.Text = emprestimosBLL.BuscarMaxLivrosFuncionario();
        //        else lblMaxLivros.Text = "0";

        //        CarregarLeitores();
        //    }
        //}

        //private void RadAluno_CheckedChanged(object sender, EventArgs e)
        //{
        //    if (radAluno.Checked)
        //    {
        //        lblTipoLeitor.Text = "RM:";
        //        aluno = true;

        //        if (cbxFiltroOpc.SelectedIndex != 1)cbxFiltroOpc.SelectedIndex = 0;
        //        lblNomeLeitor.Visible = false;
        //        cbxLeitor.Visible = true;
        //        lblTrocar.Visible = false;

        //        gbxAlunos.Visible = true;
        //        gbxFuncionario.Visible = false;

        //        dtDevolucao.Enabled = false;

        //        lblId.Text = "0";
        //        lblNome.Text = "";
        //        lblRM.Text = "";
        //        lblCurso.Text = "";
        //        lblModulo.Text = "";

        //        if (emprestimosBLL.BuscarPermissaoMaxLivros()) lblMaxLivros.Text = emprestimosBLL.BuscarMaxLivros();
        //        else lblMaxLivros.Text = "0";

        //        CarregarLeitores();
        //    }
        //}

        //private void DgvLivros_CellClick(object sender, DataGridViewCellEventArgs e)
        //{
        //    try
        //    {
                
        //        lblIdLivro.Text = dgvLivros[0, dgvLivros.CurrentRow.Index].Value.ToString();
        //        lblNomeLivro.Text = dgvLivros[1, dgvLivros.CurrentRow.Index].Value.ToString();
        //        lblLocalizacaoLivro.Text = dgvLivros[2, dgvLivros.CurrentRow.Index].Value.ToString();
        //        lblAnoLivro.Text = dgvLivros[3, dgvLivros.CurrentRow.Index].Value.ToString();
        //        lblAutorLivro.Text = dgvLivros[4, dgvLivros.CurrentRow.Index].Value.ToString();
        //        lblTomboLivro.Text = dgvLivros[5, dgvLivros.CurrentRow.Index].Value.ToString();
        //        txtMultaLivro.Text = dgvLivros[6, dgvLivros.CurrentRow.Index].Value.ToString();

        //        bool emprestado;

        //        if (cbxFiltroOpc.SelectedIndex == 0)
        //        {
        //            emprestado = Convert.ToBoolean(dgvLivros[7, dgvLivros.CurrentRow.Index].Value);
        //            lblIdLivro.Text = dgvLivros[0, dgvLivros.CurrentRow.Index].Value.ToString();
        //            lblNomeLivro.Text = dgvLivros[1, dgvLivros.CurrentRow.Index].Value.ToString();
        //            lblLocalizacaoLivro.Text = dgvLivros[2, dgvLivros.CurrentRow.Index].Value.ToString();
        //            lblAnoLivro.Text = dgvLivros[3, dgvLivros.CurrentRow.Index].Value.ToString();
        //            lblAutorLivro.Text = dgvLivros[4, dgvLivros.CurrentRow.Index].Value.ToString();
        //            lblTomboLivro.Text = dgvLivros[5, dgvLivros.CurrentRow.Index].Value.ToString();
        //            txtMultaLivro.Text = dgvLivros[6, dgvLivros.CurrentRow.Index].Value.ToString();
        //        }
        //        else if (cbxFiltroOpc.SelectedIndex == 1)
        //        {
        //            emprestado = Convert.ToBoolean(dgvLivros[8, dgvLivros.CurrentRow.Index].Value);
        //            lblIdLivro.Text = dgvLivros[0, dgvLivros.CurrentRow.Index].Value.ToString();
        //            lblNomeLivro.Text = dgvLivros[1, dgvLivros.CurrentRow.Index].Value.ToString();
        //            lblLocalizacaoLivro.Text = dgvLivros[2, dgvLivros.CurrentRow.Index].Value.ToString();
        //            lblAnoLivro.Text = dgvLivros[3, dgvLivros.CurrentRow.Index].Value.ToString();
        //            lblAutorLivro.Text = dgvLivros[4, dgvLivros.CurrentRow.Index].Value.ToString();
        //            lblTomboLivro.Text = dgvLivros[5, dgvLivros.CurrentRow.Index].Value.ToString();
        //            txtMultaLivro.Text = dgvLivros[7, dgvLivros.CurrentRow.Index].Value.ToString();
        //        }
        //        else if(cbxFiltroOpc.SelectedIndex == 2)
        //        {
        //            emprestado = Convert.ToBoolean(dgvLivros[6, dgvLivros.CurrentRow.Index].Value);
        //            lblIdLivro.Text = dgvLivros[0, dgvLivros.CurrentRow.Index].Value.ToString();
        //            lblNomeLivro.Text = dgvLivros[1, dgvLivros.CurrentRow.Index].Value.ToString();
        //            lblLocalizacaoLivro.Text = dgvLivros[2, dgvLivros.CurrentRow.Index].Value.ToString();
        //            lblAnoLivro.Text = dgvLivros[3, dgvLivros.CurrentRow.Index].Value.ToString();
        //            lblAutorLivro.Text = dgvLivros[4, dgvLivros.CurrentRow.Index].Value.ToString();
        //            lblTomboLivro.Text = dgvLivros[5, dgvLivros.CurrentRow.Index].Value.ToString();
        //            txtMultaLivro.Text = dgvLivros[6, dgvLivros.CurrentRow.Index].Value.ToString();
        //        }
        //        else
        //        {
        //            emprestado = false;
        //        }

        //        if (emprestado)
        //        {
        //            dtDevolucao.Enabled = false;
        //            dtEmprestimo.Enabled = false;
        //            lblStatus.Text = "Emprestado";
        //            BtnTrocar_Click(null, null);

        //            object[] dados = emprestimosBLL.BuscarDadosEmprestados(lblIdLivro.Text, aluno);

        //            if (dados.Length != 5)
        //            {

        //                radAluno.Checked = true;
        //                gbxAlunos.Visible = true;
        //                gbxFuncionario.Visible = false;
        //                lblId.Text = dados[0].ToString();
        //                lblRM.Text = dados[1].ToString();
        //                lblNome.Text = dados[2].ToString();
        //                cbxLeitor.Text = lblRM.Text;
        //                lblNomeLeitor.Text = lblRM.Text;
        //                lblCurso.Text = dados[3].ToString();
        //                lblModulo.Text = dados[4].ToString();
        //                dtEmprestimo.Value = Convert.ToDateTime(dados[5]);
        //                dtDevolucao.Value = Convert.ToDateTime(dados[6]);

        //                lblTrocar.Visible = true;
        //                lblNomeLeitor.Visible = true;
        //                cbxLeitor.Visible = false;
        //                cbxLeitor.Text = lblNome.Text;
        //                cbxLeitor.ValueMember = "Leitor_Especial";
        //                bool resultado = Convert.ToBoolean(cbxLeitor.SelectedValue);

        //                if (resultado)
        //                {
        //                    dtDevolucao.Enabled = true;
        //                }
        //                else
        //                {
        //                    dtDevolucao.Enabled = false;
        //                }

        //                lblLivrosEmprestados.Text = emprestimosBLL.CarregarEmprestados(lblId.Text);

        //                if (lblMaxLivros.Text != "0")
        //                {
        //                    if (int.Parse(lblLivrosEmprestados.Text) >= int.Parse(lblMaxLivros.Text))
        //                    {
        //                        btnEmprestar.Enabled = false;
        //                    }
        //                    else btnEmprestar.Enabled = true;
        //                }
        //            }
        //            else
        //            {
        //                gbxAlunos.Visible = false;
        //                gbxFuncionario.Visible = true;

        //                radFuncionario.Checked = true;
        //                lblIdFuncionario.Text = Convert.ToString(dados[0]);
        //                lblNomeFuncionario.Text = Convert.ToString(dados[1]);
        //                lblFuncao.Text = Convert.ToString(dados[2]);
        //                dtEmprestimo.Value = Convert.ToDateTime(dados[3]);
        //                dtDevolucao.Value = Convert.ToDateTime(dados[4]);

        //                lblNomeLeitor.Text = lblNomeFuncionario.Text;
        //                lblNomeLeitor.Visible = true;
        //                cbxLeitor.Text = lblNomeFuncionario.Text;
        //                cbxLeitor.Visible = false;
        //                lblTrocar.Visible = true;
        //            }
        //        }
        //        else
        //        {
        //            if (cbxLeitor.Visible == true)
        //            {
        //                lblId.Text = "0";
        //                lblRM.Text = "";
        //                lblNome.Text = "";
        //                lblCurso.Text = "";
        //                lblModulo.Text = "";
        //            }
        //            dtEmprestimo.Text = DateTime.Now.ToShortDateString();
        //            lblStatus.Text = "Disponível";
        //        }

        //        if (Convert.ToDecimal(txtMultaLivro.Text) == 0)
        //        {
        //            MessageBox.Show("A multa do livro ainda não foi definida!\nDefinia-a agora antes emprestar este livro!", "Multa Necessária!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //        }
        //    }
        //    catch
        //    {
        //        lblId.Text = "0";
        //        lblNomeLivro.Text = "";
        //        lblLocalizacaoLivro.Text = "";
        //        lblAnoLivro.Text = "";
        //        lblAutorLivro.Text = "";
        //        lblTomboLivro.Text = "";
        //        txtMultaLivro.Text = "";
        //        lblStatus.Text = "";
        //    }
        //}

        //private void TxtlDataEmprestimo_TextChanged(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        data = dtEmprestimo.Value;
        //    }
        //    catch
        //    {
        //        data = DateTime.Now;
        //    }

        //    CalcularDatas();
        //}

        //private void CbxFiltroOpc_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        if (!inicio)
        //        {
        //            if (cbxFiltroOpc.SelectedIndex == 0)
        //            {
        //                opc = 0;
        //                cbxVis.Visible = true;
        //                cbxFiltro.Visible = false;
        //                txtFiltro.Visible = true;
        //                cbxOpcFiltraLivro.Visible = true;
        //            }
        //            else if (cbxFiltroOpc.SelectedIndex == 1)
        //            {
        //                opc = 1;
        //                cbxVis.Visible = false;
        //                cbxFiltro.Visible = true;
        //                txtFiltro.Visible = false;
        //                cbxOpcFiltraLivro.Visible = false;
        //                cbxFiltro.DataSource = emprestimosBLL.ListarAlunosDevedores();
        //                cbxFiltro.DisplayMember = "RM";
        //                cbxFiltro.Text = "";
        //                dgvLivros.DataSource = null;
        //                radAluno.Checked = true;
        //            }
        //            else if (cbxFiltroOpc.SelectedIndex == 2)
        //            {
        //                opc = 2;
        //                cbxVis.Visible = false;
        //                cbxFiltro.Visible = true;
        //                txtFiltro.Visible = false;
        //                cbxOpcFiltraLivro.Visible = false;
        //                cbxFiltro.DataSource = emprestimosBLL.ListarFuncionariosDevedores();
        //                cbxFiltro.DisplayMember = "Nome";
        //                cbxFiltro.Text = "";
        //                radFuncionario.Checked = true;
        //            }
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }

        //    AtualizaGrid();
        //}

        //private void TxtFiltro_Click(object sender, EventArgs e)
        //{
        //    AtualizaGrid();
        //}

        //private void CbxFiltro_TextChanged(object sender, EventArgs e)
        //{
        //    if (cbxFiltroOpc.SelectedIndex == 1) cbxFiltro.DisplayMember = "RM";
        //    AtualizaGrid();
        //}

        //private void BtnDevolver_Click(object sender, EventArgs e)
        //{
        //    string erro = "Erro Não Previsto!";
        //    try
        //    {
        //        if (dgvLivros.Rows.Count == 0)
        //        {
        //            erro = "Nenhum Lívro Disponível!";
        //            throw new Exception("Não há lívros disponíveis para serem devolvidos!");
        //        }


        //        bool emprestado = emprestimosBLL.VerificarDisponibilidade(lblIdLivro.Text);
        //        if (!emprestado)
        //        {
        //            erro = "Livro Não Empestado!";
        //            throw new Exception("Esse livro ainda não foi emprestado!");
        //        }

        //        int
        //            id_leitor,
        //            id_livro = Convert.ToInt32(lblIdLivro.Text);

        //        bool aluno;

        //        if (gbxAlunos.Visible == true)
        //        {
        //            aluno = true;
        //            id_leitor = Convert.ToInt32(lblId.Text);

        //            if (MessageBox.Show("Receber o livro " + lblNomeLivro.Text + " de " + lblNome.Text + "?", "Receber Livro", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
        //            {
        //                emprestimosBLL.DevolverLivro(id_leitor, id_livro, aluno, ref erro);
        //                MessageBox.Show("O Livro " + lblNomeLivro.Text + " foi devolvido!", "Livro devolvido!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        //                AtualizaGrid();
        //                BtnTrocar_Click(null, null);

        //                BtnLimparCampos_Click(null, null);
        //            }
        //        }
        //        else
        //        {
        //            aluno = false;
        //            id_leitor = Convert.ToInt32(lblIdFuncionario.Text);

        //            if (MessageBox.Show("Receber o livro " + lblNomeLivro.Text + " de " + lblNomeFuncionario.Text + "?", "Receber Livro", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
        //            {
        //                emprestimosBLL.DevolverLivro(id_leitor, id_livro, aluno, ref erro);
        //                MessageBox.Show("O Livro " + lblNomeLivro.Text + " foi devolvido!", "Livro devolvido!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        //                AtualizaGrid();
        //                BtnTrocar_Click(null, null);

        //                BtnLimparCampos_Click(null, null);
        //            }
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message, erro, MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        erro = "Erro Não Previsto!";
        //    }
        //}

        //private void BtnRenovarPainel_Click(object sender, EventArgs e)
        //{

        //    string erro = "Erro Não Previsto!";
        //    try
        //    {
        //        if(lblIdLivro.Text == "0")
        //        {
        //            erro = "Livro Não selecionado!";
        //            throw new Exception("Selecione um livro emprestado antes de emprestar um livro");
        //        }

        //        if (dgvLivros.Rows.Count == 0)
        //        {
        //            erro = "Nenhum Lívro Disponível!";
        //            throw new Exception("Não há lívros disponíveis para serem renovados!");
        //        }

        //        if (cbxFiltroOpc.SelectedIndex == 0)
        //        {

        //            bool emprestado = emprestimosBLL.VerificarDisponibilidade(lblIdLivro.Text);
        //            if (!emprestado)
        //            {
        //                erro = "Livro não Emprestado!";
        //                throw new Exception("Este livro está disponível no momento!");
        //            }
        //        }
        //        else if (cbxFiltroOpc.SelectedIndex == 0)
        //        {
        //            if (!Convert.ToBoolean(dgvLivros[8, dgvLivros.CurrentRow.Index].Value))
        //            {
        //                erro = "Livro Não Empestado!";
        //                throw new Exception("Esse livro ainda não foi emprestado!");
        //            }
        //        }
        //        else
        //        {
        //            if (!Convert.ToBoolean(dgvLivros[7, dgvLivros.CurrentRow.Index].Value))
        //            {
        //                erro = "Livro Não Empestado!";
        //                throw new Exception("Esse livro ainda não foi emprestado!");
        //            }
        //        }

        //        bool
        //            aluno = gbxAlunos.Visible,
        //            leitorEspecial;

        //        dtRetiradaRenovacao.Value = DateTime.Now;

        //        dtDevolucaoRenovacao.Value = emprestimosBLL.CalcularDataDevolucao(dtRetiradaRenovacao.Value);
        //        if (aluno)
        //        {
        //            cbxLeitor.ValueMember = "Leitor_Especial";
        //            leitorEspecial = Convert.ToBoolean(cbxLeitor.SelectedValue);
        //        }
        //        else leitorEspecial = false;

        //        if (leitorEspecial || !aluno) dtDevolucaoRenovacao.Enabled = true;
        //        else
        //        {
        //            dtDevolucaoRenovacao.Enabled = false;
        //        }
        //        pnlBotoes.Enabled = false;
        //        pnlInformacoes.Enabled = false;
        //        pnlSuperior.Enabled = false;
        //        dgvLivros.Enabled = false;
        //        pnlFiltros.Enabled = false;

        //        pnlRenovar.Visible = true;
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message, erro, MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        erro = "Erro Não Previsto!";
        //    }
        //}

        //private void BtnRenovar_Click_1(object sender, EventArgs e)
        //{
        //    string erro = "Erro Não Previsto!";
        //    try
        //    {
        //        int
        //            id_leitor,
        //            id_livro = Convert.ToInt32(lblIdLivro.Text);


        //        if (dtDevolucao.Enabled)
        //        {
        //            try { Convert.ToDateTime(dtDevolucao.Value); }
        //            catch
        //            {
        //                erro = "Devolução Inválida!";
        //                throw new Exception("A data de devolução foi digitada incorretamente!");
        //            }
        //        }

        //        try { Convert.ToDateTime(dtRetiradaRenovacao.Value); }
        //        catch
        //        {
        //            erro = "Renovação Inválida!";
        //            throw new Exception("A data de renovação foi digitada incorretamente!");
        //        }

        //        try
        //        {
        //            if (Convert.ToDecimal(txtMultaLivro.Text) == 0)
        //            {
        //                erro = "Multa Não Permitida!";
        //                throw new Exception("O livro precisa de uma multa superior a 0! Modifique-a aqui mesmo no campo de multa!");
        //            }
        //        }
        //        catch
        //        {
        //            erro = "Multa não definida!";
        //            throw new Exception("A multa deve estar digitada no campo de multa!");
        //        }

        //        if (gbxAlunos.Visible)
        //        {
        //            aluno = true;
        //            id_leitor = Convert.ToInt32(lblId.Text);
        //            if (MessageBox.Show("Renovar o livro " + lblNomeLivro.Text + " de " + lblNome.Text + "?", "Renovar Livro", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
        //            {
        //                emprestimosBLL.RenovarLivro(id_leitor, id_livro, aluno, ref erro, dtRetiradaRenovacao.Value.ToShortDateString(), dtDevolucaoRenovacao.Value.ToShortDateString());
        //                MessageBox.Show("O Livro " + lblNomeLivro.Text + " foi Renovado!", "Livro devolvido!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        //                AtualizaGrid();
        //                BtnCancelar_Click(null, null);
        //                BtnLimparCampos_Click(null, null);
        //            }
        //        }
        //        else
        //        {
        //            aluno = false;
        //            id_leitor = Convert.ToInt32(lblIdFuncionario.Text);
        //            if (MessageBox.Show("Renovar o livro " + lblNomeLivro.Text + " de " + lblNomeFuncionario.Text + "?", "Renovar Livro", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
        //            {
        //                emprestimosBLL.RenovarLivro(id_leitor, id_livro, aluno, ref erro, dtRetiradaRenovacao.Value.ToShortDateString(), dtDevolucaoRenovacao.Value.ToShortDateString());
        //                MessageBox.Show("O Livro " + lblNomeLivro.Text + " foi Renovado!", "Livro devolvido!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        //                AtualizaGrid();
        //                BtnCancelar_Click(null, null);
        //                BtnLimparCampos_Click(null, null);
        //            }
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message, erro, MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        erro = "Erro Não Previsto!";
        //    }
        //}

        //private void BtnCancelar_Click(object sender, EventArgs e)
        //{
        //    pnlBotoes.Enabled = true;
        //    pnlInformacoes.Enabled = true;
        //    pnlSuperior.Enabled = true;
        //    dgvLivros.Enabled = true;
        //    pnlFiltros.Enabled = true;
        //    pnlRenovar.Visible = false;
        //}

        //private void TxtRetiradaRenovacao_TextChanged(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        try { data = Convert.ToDateTime(dtRetiradaRenovacao.Value); }
        //        catch { data = DateTime.Now;}

        //        dtRetiradaRenovacao.Value = emprestimosBLL.CalcularDataDevolucao(data);
        //    }
        //    catch { }
        //}

        //private void BtnLimparCampos_Click(object sender, EventArgs e)
        //{
        //    BtnTrocar_Click(null, null);
        //    cbxLeitor.Text = "";

        //    lblIdLivro.Text = "0";
        //    lblNomeLivro.Text = "";
        //    lblLocalizacaoLivro.Text = "";
        //    lblAnoLivro.Text = "";
        //    lblAutorLivro.Text = "";
        //    lblTomboLivro.Text = "";
        //    txtMultaLivro.Text = "";
        //    lblStatus.Text = "";
        //    dtEmprestimo.Value= DateTime.Now;
        //    dtDevolucao.Enabled = false;
        //    dtEmprestimo.Enabled = true;
        //}

        //private void BtnEmprestar_Click(object sender, EventArgs e)
        //{
        //    string erro = "Erro Não Previsto!";
        //    try
        //    {
        //        if (lblIdLivro.Text == "0")
        //        {
        //            erro = "Livro não selecionado!";
        //            throw new Exception("Selecione um livro antes de emprestá-lo!");
        //        }

        //        int
        //            id_leitor,
        //            id_livro = Convert.ToInt32(lblIdLivro.Text);


        //        bool emprestado = emprestimosBLL.VerificarDisponibilidade(lblIdLivro.Text);
        //        if (emprestado)
        //        {
        //            erro = "Livro já Emprestado!";
        //            throw new Exception("Este livro está ocupado no momento!");
        //        }

        //        if (lblIdLivro.Text == "0")
        //        {
        //            erro = "Livro Não Selecionado!";
        //            throw new Exception("Selecione um livro antes de emprestá-lo!");
        //        }

        //        try
        //        {
        //            if (Convert.ToDecimal(txtMultaLivro.Text) == 0)
        //            {
        //                erro = "Multa Não Permitida!";
        //                throw new Exception("O livro precisa de uma multa superior a 0! Modifique-a aqui mesmo no campo de multa!");
        //            }
        //        }
        //        catch
        //        {
        //            erro = "Multa não definida!";
        //            throw new Exception("A multa deve estar digitada no campo de multa!");
        //        }

        //        if (gbxAlunos.Visible)
        //        {
        //            aluno = true;
        //            id_leitor = Convert.ToInt32(lblId.Text);

        //            if (id_leitor == 0)
        //            {
        //                erro = "Aluno Não Escolhido!";
        //                throw new Exception("Escolha um aluno antes de emprestar um livro!");
        //            }

        //            if (MessageBox.Show("Emprestar " + lblNomeLivro.Text + " para " + lblNome.Text + "?", "Empréstimo de Livro", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
        //            {
        //                emprestimo = new EmprestimoInformation(int.Parse(lblId.Text),
        //                                                       int.Parse(lblRM.Text),
        //                                                       lblNome.Text,
        //                                                       lblCurso.Text,
        //                                                       int.Parse(lblModulo.Text),
        //                                                       int.Parse(lblIdLivro.Text),
        //                                                       lblNomeLivro.Text,
        //                                                       lblLocalizacaoLivro.Text,
        //                                                       lblAnoLivro.Text,
        //                                                       lblAutorLivro.Text,
        //                                                       int.Parse(lblTomboLivro.Text),
        //                                                       dtEmprestimo.Value,
        //                                                       Convert.ToDateTime(dtDevolucao.Value),
        //                                                       lblRM.Text + " - " + lblModulo.Text + " - " + lblCurso.Text);


        //                emprestimosBLL.RealizarEmprestimo(emprestimo, aluno, true, ref erro);
        //                MessageBox.Show("O Livro " + lblNomeLivro.Text + " foi emprestado para " + lblNome.Text + "!", "Livro Emprestado!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        //                AtualizaGrid();
        //                BtnTrocar_Click(null, null);
        //            }
        //        }
        //        else
        //        {
        //            aluno = false;
        //            id_leitor = Convert.ToInt32(lblIdFuncionario.Text);

        //            if (id_leitor == 0)
        //            {
        //                erro = "Funcionário Não Escolhido!";
        //                throw new Exception("Escolha um funcionário antes de emprestar um livro!");
        //            }

        //            if (MessageBox.Show("Emprestar o livro " + lblNomeLivro.Text + " para " + lblNomeFuncionario.Text + "?", "Emprestar Livro", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
        //            {
        //                emprestimo = new EmprestimoInformation(int.Parse(lblIdFuncionario.Text),
        //                               lblNomeFuncionario.Text,
        //                               lblFuncao.Text,
        //                               int.Parse(lblIdLivro.Text),
        //                               lblNomeLivro.Text,
        //                               lblLocalizacaoLivro.Text,
        //                               lblAnoLivro.Text,
        //                               lblAutorLivro.Text,
        //                               int.Parse(lblTomboLivro.Text),
        //                               Convert.ToDateTime(dtEmprestimo.Value),
        //                               Convert.ToDateTime(dtDevolucao.Value),
        //                               lblFuncao.Text);

        //                emprestimosBLL.RealizarEmprestimo(emprestimo, aluno, true, ref erro);
        //                MessageBox.Show("O Livro " + lblNomeLivro.Text + " foi emprestado para " + lblNomeFuncionario.Text + "!", "Livro Emprestado!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        //                AtualizaGrid();
        //                BtnTrocar_Click(null, null);
        //            }
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message, erro, MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        erro = "Erro Não Previsto!";
        //    }
        //}

        //private void TxtMultaLivro_TextChanged(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        decimal valor = Convert.ToDecimal(txtMultaLivro.Text);

        //        decimal atual = emprestimosBLL.BuscarMulta(lblIdLivro.Text);

        //            if (valor != atual)
        //            {
        //                emprestimosBLL.AtualizarMulta(valor, lblIdLivro.Text);
        //                AtualizaGrid();
        //            }

        //    }
        //    catch
        //    {
        //        txtMultaLivro.Text = "";
        //    }
        //}

        //private void DgvLivros_KeyUp(object sender, KeyEventArgs e)
        //{
        //    string erro = "Erro Não Previsto!";
        //    try
        //    {
        //        if (e.KeyData == Keys.Up || e.KeyData == Keys.Down) DgvLivros_CellClick(null, null);
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message, erro, MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        erro = "Erro Não Previsto!";
        //    }
        //}

        //private void BtnExcluirEmprestimo_Click(object sender, EventArgs e)
        //{
        //    string erro = "Erro Não Previsto!";
        //    try
        //    {
        //        if (!Convert.ToBoolean(dgvLivros[7, dgvLivros.CurrentRow.Index].Value))
        //        {
        //            erro = "Livro Disponível";
        //            throw new Exception("Este livro não foi emprestado!");
        //        }
        //        if (MessageBox.Show("Deseja excluir este empréstimo? Sua ficha catalográfica também será deletada!", "Deletar Empréstimo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
        //        {
        //            if (gbxAlunos.Visible)
        //            {
        //                emprestimo = new EmprestimoInformation(int.Parse(lblId.Text),
        //                                                       int.Parse(lblRM.Text),
        //                                                       lblNome.Text,
        //                                                       lblCurso.Text,
        //                                                       int.Parse(lblModulo.Text),
        //                                                       int.Parse(lblIdLivro.Text),
        //                                                       lblNomeLivro.Text,
        //                                                       lblLocalizacaoLivro.Text,
        //                                                       lblAnoLivro.Text,
        //                                                       lblAutorLivro.Text,
        //                                                       int.Parse(lblTomboLivro.Text),
        //                                                       Convert.ToDateTime(dtEmprestimo.Value),
        //                                                       Convert.ToDateTime(dtDevolucao.Value),
        //                                                       lblRM.Text + " - " + lblModulo.Text + " - " + lblCurso.Text);
        //            }
        //            else
        //            {
        //                emprestimo = new EmprestimoInformation(int.Parse(lblIdFuncionario.Text),
        //                                                       lblNomeFuncionario.Text,
        //                                                       lblFuncao.Text,
        //                                                       int.Parse(lblIdLivro.Text),
        //                                                       lblNomeLivro.Text,
        //                                                       lblLocalizacaoLivro.Text,
        //                                                       lblAnoLivro.Text,
        //                                                       lblAutorLivro.Text,
        //                                                       int.Parse(lblTomboLivro.Text),
        //                                                       Convert.ToDateTime(dtEmprestimo.Value),
        //                                                       Convert.ToDateTime(dtDevolucao.Text),
        //                                                       lblFuncao.Text);
        //            }
        //            emprestimosBLL.ExcluirEmprestimo(emprestimo, aluno);
        //            MessageBox.Show("O empréstimo foi deletado com sucesso", "Empréstimo Excluidp!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //            AtualizaGrid();
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message, erro, MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        erro = "Erro Não Previsto!";
        //    }
        //}

        //private void MetroDateTime1_ValueChanged(object sender, EventArgs e)
        //{

        //}

        //private void DtRetiradaRenovacao_ValueChanged(object sender, EventArgs e)
        //{
        //    dtDevolucaoRenovacao.Value = emprestimosBLL.CalcularDataDevolucao(dtRetiradaRenovacao.Value);
        //}

        //private void TxtFiltro_TextChanged(object sender, EventArgs e)
        //{
        //    AtualizaGrid();
        //}

        //private void CbxOpcFiltraLivro_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    if (!inicio)
        //    {
        //        if (cbxOpcFiltraLivro.SelectedIndex == 0) opcFiltro = 0;
        //        else if (cbxOpcFiltraLivro.SelectedIndex == 1) opcFiltro = 1;
        //        else if (cbxOpcFiltraLivro.SelectedIndex == 2) opcFiltro = 2;

        //        AtualizaGrid();
        //    }
        //}

        //private void CbxVis_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    if (!inicio)
        //    {
        //        if (cbxVis.SelectedIndex == 0) vis = 0;
        //        else if (cbxVis.SelectedIndex == 1) vis = 1;
        //        else if (cbxVis.SelectedIndex == 2) vis = 2;

        //        AtualizaGrid();
        //    }
        //}
    }
}