namespace GUI.Relatorios.ArquivoMorto.Emprestimos.Funcionarios
{
    partial class frmVisRelEmprestimosFuncionarioMorto
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnBackup = new System.Windows.Forms.Button();
            this.biblioteca = new GUI.Biblioteca();
            this.emprestimosFuncionariosmortoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.emprestimos_Funcionarios_morto_TableAdapter = new GUI.BibliotecaTableAdapters.Emprestimos_Funcionarios_morto_TableAdapter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.biblioteca)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emprestimosFuncionariosmortoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Top;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.emprestimosFuncionariosmortoBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "GUI.Relatorios.ArquivoMorto.Emprestimos.Funcionarios.RelEmprestimosFuncionarioMor" +
    "to.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1264, 790);
            this.reportViewer1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnBackup);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(1074, 790);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(5);
            this.panel1.Size = new System.Drawing.Size(190, 47);
            this.panel1.TabIndex = 20;
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
            this.btnBackup.Click += new System.EventHandler(this.BtnBackup_Click);
            // 
            // biblioteca
            // 
            this.biblioteca.DataSetName = "Biblioteca";
            this.biblioteca.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // emprestimosFuncionariosmortoBindingSource
            // 
            this.emprestimosFuncionariosmortoBindingSource.DataMember = "Emprestimos_Funcionarios(morto)";
            this.emprestimosFuncionariosmortoBindingSource.DataSource = this.biblioteca;
            // 
            // emprestimos_Funcionarios_morto_TableAdapter
            // 
            this.emprestimos_Funcionarios_morto_TableAdapter.ClearBeforeFill = true;
            // 
            // frmVisRelEmprestimosFuncionarioMorto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(61)))));
            this.ClientSize = new System.Drawing.Size(1264, 837);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frmVisRelEmprestimosFuncionarioMorto";
            this.Text = "frmVisRelEmprestimosFuncionarioMorto";
            this.Load += new System.EventHandler(this.FrmVisRelEmprestimosFuncionarioMorto_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.biblioteca)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emprestimosFuncionariosmortoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnBackup;
        private Biblioteca biblioteca;
        private System.Windows.Forms.BindingSource emprestimosFuncionariosmortoBindingSource;
        private BibliotecaTableAdapters.Emprestimos_Funcionarios_morto_TableAdapter emprestimos_Funcionarios_morto_TableAdapter;
    }
}