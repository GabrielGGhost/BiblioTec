using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Printing;
using BLL;

namespace GUI.Carteirinha
{
    public partial class frmCarteirinha : Form
    {
        PrintPreviewDialog printPreview = new PrintPreviewDialog();

        PrintDocument printDocument = new PrintDocument();

        CalendarioBLL calendarioDAL = new CalendarioBLL();

        EmprestimosBLL emprestimosBLL = new EmprestimosBLL();

        public frmCarteirinha()
        {
            InitializeComponent();
        }

        private void FrmCarteirinha_Load(object sender, EventArgs e)
        {
            AtualizaGrid();
        }

        void AtualizaGrid()
        {
            cbxAlunos.DataSource = emprestimosBLL.ListarLeitores(true);
            cbxAlunos.DisplayMember = "RM";
        }

        public void Print(Panel pnl, bool v)
        {
            PrinterSettings ps = new PrinterSettings();
            if (v) pnlCarteirinhaFrente = pnl;
            else pnlCarteirinhaTras = pnl;
            GetPrintArea(pnl);

        }

        Bitmap memorying;
        public void GetPrintArea(Panel pnl)
        {
            memorying = null;
            memorying = new Bitmap(pnl.Width, pnl.Height);
            pnl.DrawToBitmap(memorying, new Rectangle(0, 0, pnl.Width, pnl.Height));
            printPreview.Document = printDocument;
            printDocument.PrintPage += new PrintPageEventHandler(PrintDocument_PrintPage);
            printPreview.ShowDialog();
        }

        public void PrintDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            Rectangle pageArea = e.PageBounds;
            e.Graphics.DrawImage(memorying, (pageArea.Width/2) - (this.pnlCarteirinhaFrente.Width/2), this.pnlCarteirinhaFrente.Location.Y);
        }

        private void BtnImprimir_Click(object sender, EventArgs e)
        {
            Print(pnlCarteirinhaFrente, true);
        }

        private void CbxAlunos_KeyDown(object sender, KeyEventArgs e)
        {

                
        }

        private string FormatarTermino(string termino)
        {
            string
                mes = termino.Substring(0, 3),
                ano = termino.Substring(4, 4),
                conclusao;

            if (mes == "Nov") conclusao = "30/11/";
            else conclusao = "30/06/";

            return conclusao += ano;
        }

        private void BtnImprimirTras_Click(object sender, EventArgs e)
        {
            Print(pnlCarteirinhaTras, false);
        }

        private void CbxAlunos_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyData == Keys.Enter)
                {
                    cbxAlunos.ValueMember = "RM";
                    lblRm.Text = cbxAlunos.SelectedValue.ToString();

                    cbxAlunos.ValueMember = "ID";
                    lblId.Text = cbxAlunos.SelectedValue.ToString();

                    cbxAlunos.ValueMember = "NOME";
                    lblNome.Text = cbxAlunos.SelectedValue.ToString();

                    cbxAlunos.ValueMember = "CELULAR";
                    lblCelular.Text = cbxAlunos.SelectedValue.ToString();

                    cbxAlunos.ValueMember = "TELEFONE";
                    lblTelefone.Text = cbxAlunos.SelectedValue.ToString();

                    cbxAlunos.ValueMember = "EMAIL1";
                    lblEmail1.Text = cbxAlunos.SelectedValue.ToString();

                    cbxAlunos.ValueMember = "EMAIL2";
                    lblEmail2.Text = cbxAlunos.SelectedValue.ToString();

                    cbxAlunos.ValueMember = "CURSO";
                    lblCurso.Text = cbxAlunos.SelectedValue.ToString();

                    cbxAlunos.ValueMember = "MODULO";
                    lblModulo.Text = cbxAlunos.SelectedValue.ToString();

                    cbxAlunos.ValueMember = "TERMINO";
                    lblTermino.Text = cbxAlunos.SelectedValue.ToString();

                    cbxAlunos.ValueMember = "CONFECCAO";
                    lblConfeccao.Text = Convert.ToDateTime(cbxAlunos.SelectedValue).ToShortDateString();

                    lblDataCpt.Text = FormatarTermino(lblTermino.Text);

                    lblNomeAluno.Text = lblNome.Text;
                    lblValidadeAbv.Text = lblTermino.Text;
                    lblRMcarteira.Text = lblRm.Text;
                    lblPrimeiro.Text = "1° - " + lblCurso.Text;
                    lblSegundo.Text = "2° - " + lblCurso.Text;
                    lblTerceiro.Text = "3° - " + lblCurso.Text;
                }
            }
            catch (Exception ex) { }
        }
    }
}
