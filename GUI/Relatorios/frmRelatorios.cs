using GUI.Relatorios.ArquivoMorto;
using GUI.Relatorios.ArquivoMorto.Emprestimos.Alunos;
using GUI.Relatorios.ArquivoMorto.Emprestimos.Funcionarios;
using GUI.Relatorios.ArquivoMorto.Leitores.Funcionarios;
using GUI.Relatorios.Emprestimos.Emprestimos_Alunos;
using GUI.Relatorios.Leitores.Alunos;
using GUI.Relatorios.Leitores.Funcionários;
using GUI.Relatorios.Livros;
using GUI.Relatorios.Multas.Pendentes;
using GUI.Relatorios.FichaCatalograica;
using Microsoft.Reporting.Map.WebForms.BingMaps;
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
using GUI.Relatorios.LeitoresEspeciais;

namespace GUI.Relatorios
{
    public partial class frmRelatorios : Form
    {
        Form form = new Form();
        public frmRelatorios()
        {
            InitializeComponent();
        }


        private void BtnGerarPDF_Click(object sender, EventArgs e)
        {
            form?.Close();
            form = new frmVisRelAlunos
            {
                TopLevel = false,
                FormBorderStyle = FormBorderStyle.None,
                Dock = DockStyle.Fill
            };
            pnlRelatorios.Controls.Add(form);
            form.Show();
        }

        private void BtnFuncionarios_Click(object sender, EventArgs e)
        {
            form?.Close();
            form = new frmVisRelFuncionarios
            {
                TopLevel = false,
                FormBorderStyle = FormBorderStyle.None,
                Dock = DockStyle.Fill
            };
            pnlRelatorios.Controls.Add(form);
            form.Show();
        }

        private void BtnLivros_Click(object sender, EventArgs e)
        {
            form?.Close();
            form = new frmVisRelLivros
            {
                TopLevel = false,
                FormBorderStyle = FormBorderStyle.None,
                Dock = DockStyle.Fill
            };
            pnlRelatorios.Controls.Add(form);
            form.Show();
        }

        private void PnlSuperior_Paint(object sender, PaintEventArgs e)
        {

        }

        private void PnlRelatorios_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BtnEmprestimos_Click(object sender, EventArgs e)
        {
            form?.Close();
            form = new frmVisRelEmprestimosAluno
            {
                TopLevel = false,
                FormBorderStyle = FormBorderStyle.None,
                Dock = DockStyle.Fill
            };
            pnlRelatorios.Controls.Add(form);
            form.Show();
        }

        private void BtnAlunosMorto_Click(object sender, EventArgs e)
        {
            form?.Close();
            form = new frmVisRelAlunosMorto
            {
                TopLevel = false,
                FormBorderStyle = FormBorderStyle.None,
                Dock = DockStyle.Fill
            };
            pnlRelatorios.Controls.Add(form);
            form.Show();
        }

        private void BtnFuncionariosMorto_Click(object sender, EventArgs e)
        {
            form?.Close();
            form = new frmVisRelFuncionariosMorto
            {
                TopLevel = false,
                FormBorderStyle = FormBorderStyle.None,
                Dock = DockStyle.Fill
            };
            pnlRelatorios.Controls.Add(form);
            form.Show();
        }

        private void BtnEmprestimosMorto_Click(object sender, EventArgs e)
        {
            form?.Close();
            form = new frmRelVisEmprestimosAlunoMorto
            {
                TopLevel = false,
                FormBorderStyle = FormBorderStyle.None,
                Dock = DockStyle.Fill
            };
            pnlRelatorios.Controls.Add(form);
            form.Show();
        }

        private void BtnEmprestimosFuncionarios_Click(object sender, EventArgs e)
        {
            form?.Close();
            form = new frmVisRelEmprestimosFuncionarios
            {
                TopLevel = false,
                FormBorderStyle = FormBorderStyle.None,
                Dock = DockStyle.Fill
            };
            pnlRelatorios.Controls.Add(form);
            form.Show();
        }

        private void BtnEmprestimosFuncionarioMorto_Click(object sender, EventArgs e)
        {
            form?.Close();
            form = new frmVisRelEmprestimosFuncionarioMorto
            {
                TopLevel = false,
                FormBorderStyle = FormBorderStyle.None,
                Dock = DockStyle.Fill
            };
            pnlRelatorios.Controls.Add(form);
            form.Show();
        }

        private void TableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BtnMultas_Click(object sender, EventArgs e)
        {
            form?.Close();
            form = new frmVisRelMultas
            {
                TopLevel = false,
                FormBorderStyle = FormBorderStyle.None,
                Dock = DockStyle.Fill
            };
            pnlRelatorios.Controls.Add(form);
            form.Show();
        }

        private void BtnMultasPendentes_Click(object sender, EventArgs e)
        {
            form?.Close();
            form = new frmVisRelMultasPendentes
            {
                TopLevel = false,
                FormBorderStyle = FormBorderStyle.None,
                Dock = DockStyle.Fill
            };
            pnlRelatorios.Controls.Add(form);
            form.Show();
        }

        private void BtnFichas_Click(object sender, EventArgs e)
        {
            form?.Close();
            form = new frmVisRelFichas
            {
                TopLevel = false,
                FormBorderStyle = FormBorderStyle.None,
                Dock = DockStyle.Fill
            };
            pnlRelatorios.Controls.Add(form);
            form.Show();
        }

        private void BtnLeitoresEspeciais_Click(object sender, EventArgs e)
        {
            form?.Close();
            form = new frmVisRelLeitoresEspeciais
            {
                TopLevel = false,
                FormBorderStyle = FormBorderStyle.None,
                Dock = DockStyle.Fill
            };
            pnlRelatorios.Controls.Add(form);
            form.Show();
        }
    }
}