namespace GUI.Relatorios.Emprestimos.Emprestimos_Alunos
{
    partial class frmVisRelEmprestimosAluno
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnBackup = new System.Windows.Forms.Button();
            this.biblioteca = new GUI.Biblioteca();
            this.emprestimosAlunosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.emprestimos_AlunosTableAdapter = new GUI.BibliotecaTableAdapters.Emprestimos_AlunosTableAdapter();
            this.reportViewer2 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.Emprestimos_AlunosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.biblioteca)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emprestimosAlunosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Emprestimos_AlunosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnBackup);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(1074, 790);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(5);
            this.panel1.Size = new System.Drawing.Size(190, 47);
            this.panel1.TabIndex = 16;
            // 
            // btnBackup
            // 
            this.btnBackup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnBackup.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnBackup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBackup.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackup.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnBackup.Location = new System.Drawing.Point(5, 5);
            this.btnBackup.Name = "btnBackup";
            this.btnBackup.Size = new System.Drawing.Size(180, 37);
            this.btnBackup.TabIndex = 16;
            this.btnBackup.Text = "Gerar Backup";
            this.btnBackup.UseVisualStyleBackColor = true;
            this.btnBackup.Click += new System.EventHandler(this.Button1_Click);
            // 
            // biblioteca
            // 
            this.biblioteca.DataSetName = "Biblioteca";
            this.biblioteca.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // emprestimosAlunosBindingSource
            // 
            this.emprestimosAlunosBindingSource.DataMember = "Emprestimos_Alunos";
            this.emprestimosAlunosBindingSource.DataSource = this.biblioteca;
            // 
            // emprestimos_AlunosTableAdapter
            // 
            this.emprestimos_AlunosTableAdapter.ClearBeforeFill = true;
            // 
            // reportViewer2
            // 
            this.reportViewer2.Dock = System.Windows.Forms.DockStyle.Top;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.Emprestimos_AlunosBindingSource;
            this.reportViewer2.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer2.LocalReport.ReportEmbeddedResource = "GUI.Relatorios.Emprestimos.Emprestimos_Alunos.RelEmprestimoAluno.rdlc";
            this.reportViewer2.Location = new System.Drawing.Point(0, 0);
            this.reportViewer2.Name = "reportViewer2";
            this.reportViewer2.ServerReport.BearerToken = null;
            this.reportViewer2.Size = new System.Drawing.Size(1264, 790);
            this.reportViewer2.TabIndex = 17;
            // 
            // Emprestimos_AlunosBindingSource
            // 
            this.Emprestimos_AlunosBindingSource.DataMember = "Emprestimos_Alunos";
            this.Emprestimos_AlunosBindingSource.DataSource = this.biblioteca;
            // 
            // frmVisRelEmprestimosAluno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(61)))));
            this.ClientSize = new System.Drawing.Size(1264, 837);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.reportViewer2);
            this.Name = "frmVisRelEmprestimosAluno";
            this.Text = "frmVisRelEmprestimosAluno";
            this.Load += new System.EventHandler(this.FrmVisRelEmprestimosAluno_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.biblioteca)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emprestimosAlunosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Emprestimos_AlunosBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnBackup;
        private Biblioteca biblioteca;
        private System.Windows.Forms.BindingSource emprestimosAlunosBindingSource;
        private BibliotecaTableAdapters.Emprestimos_AlunosTableAdapter emprestimos_AlunosTableAdapter;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer2;
        private System.Windows.Forms.BindingSource Emprestimos_AlunosBindingSource;
    }
}