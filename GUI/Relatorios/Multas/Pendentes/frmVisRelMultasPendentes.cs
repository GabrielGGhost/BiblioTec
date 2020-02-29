using BLL;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.Relatorios.Multas.Pendentes
{
    public partial class frmVisRelMultasPendentes : Form
    {
        public frmVisRelMultasPendentes()
        {
            InitializeComponent();
        }

        private void FrmVisRelMultasPendentes_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'biblioteca.Multas'. Você pode movê-la ou removê-la conforme necessário.
            this.multasTableAdapter.Fill(this.biblioteca.Multas);
            // TODO: This line of code loads data into the 'biblioteca.Multas' table. You can move, or remove it, as needed.
            this.multasTableAdapter.Fill(this.biblioteca.Multas);

            this.reportViewer1.RefreshReport();
        }

        void Exportar()
        {
            Warning[] warnings;
            string[] streamids;
            string mimeType;
            string encoding;
            string extension;

            byte[] bytes = reportViewer1.LocalReport.Render(
               "Excel", null, out mimeType, out encoding,
                out extension,
               out streamids, out warnings);

            ConfiguracoesBLL config = new ConfiguracoesBLL();
            string diretorio = config.BuscarDiretorio();

            if (!Directory.Exists(diretorio)) Directory.CreateDirectory(diretorio);

            FileStream fs = new FileStream(diretorio + @"\MultasPendentes(" + DateTime.Now.ToLongDateString() + ").xls",
               FileMode.Create);
            fs.Write(bytes, 0, bytes.Length);
            fs.Close();
        }

        private void BtnBackup_Click(object sender, EventArgs e)
        {
            string erro = "Erro Não Previsto!";
            try
            {
                Exportar();
                MessageBox.Show("O arquivo excel foi mandado para o diretório definido!", "Backup Realizado!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, erro, MessageBoxButtons.OK, MessageBoxIcon.Error);
                erro = "Erro Não Previsto!";
            }
        }
    }
}
