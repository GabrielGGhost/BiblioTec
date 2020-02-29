namespace GUI.Relatorios
{
    partial class frmRelatorios
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
            this.pnlSuperior = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnAlunos = new System.Windows.Forms.Button();
            this.btnAlunosMorto = new System.Windows.Forms.Button();
            this.btnFuncionarios = new System.Windows.Forms.Button();
            this.btnFuncionariosMorto = new System.Windows.Forms.Button();
            this.btnLivros = new System.Windows.Forms.Button();
            this.btnEmprestimos = new System.Windows.Forms.Button();
            this.btnEmprestimosMorto = new System.Windows.Forms.Button();
            this.btnEmprestimosFuncionarios = new System.Windows.Forms.Button();
            this.btnEmprestimosFuncionarioMorto = new System.Windows.Forms.Button();
            this.btnMultas = new System.Windows.Forms.Button();
            this.btnMultasPendentes = new System.Windows.Forms.Button();
            this.pnlRelatorios = new System.Windows.Forms.Panel();
            this.btnFichas = new System.Windows.Forms.Button();
            this.btnLeitoresEspeciais = new System.Windows.Forms.Button();
            this.pnlSuperior.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlSuperior
            // 
            this.pnlSuperior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(72)))), ((int)(((byte)(76)))));
            this.pnlSuperior.Controls.Add(this.tableLayoutPanel1);
            this.pnlSuperior.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSuperior.Location = new System.Drawing.Point(0, 0);
            this.pnlSuperior.Name = "pnlSuperior";
            this.pnlSuperior.Padding = new System.Windows.Forms.Padding(8);
            this.pnlSuperior.Size = new System.Drawing.Size(200, 848);
            this.pnlSuperior.TabIndex = 16;
            this.pnlSuperior.Paint += new System.Windows.Forms.PaintEventHandler(this.PnlSuperior_Paint);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 184F));
            this.tableLayoutPanel1.Controls.Add(this.btnLeitoresEspeciais, 0, 12);
            this.tableLayoutPanel1.Controls.Add(this.btnAlunos, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnAlunosMorto, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnFuncionarios, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnFuncionariosMorto, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.btnLivros, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.btnEmprestimos, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.btnEmprestimosMorto, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.btnEmprestimosFuncionarios, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.btnEmprestimosFuncionarioMorto, 0, 8);
            this.tableLayoutPanel1.Controls.Add(this.btnMultas, 0, 9);
            this.tableLayoutPanel1.Controls.Add(this.btnMultasPendentes, 0, 10);
            this.tableLayoutPanel1.Controls.Add(this.btnFichas, 0, 11);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(8, 8);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 13;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.970149F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.20398F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.845771F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.328359F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.955224F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.338308F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.452736F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.326478F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.82519F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.094527F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.835821F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.8209F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 49F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(184, 832);
            this.tableLayoutPanel1.TabIndex = 25;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.TableLayoutPanel1_Paint);
            // 
            // btnAlunos
            // 
            this.btnAlunos.BackColor = System.Drawing.Color.Transparent;
            this.btnAlunos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlunos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlunos.ForeColor = System.Drawing.Color.Transparent;
            this.btnAlunos.Location = new System.Drawing.Point(3, 3);
            this.btnAlunos.Name = "btnAlunos";
            this.btnAlunos.Size = new System.Drawing.Size(178, 40);
            this.btnAlunos.TabIndex = 15;
            this.btnAlunos.Text = "Alunos";
            this.btnAlunos.UseVisualStyleBackColor = false;
            this.btnAlunos.Click += new System.EventHandler(this.BtnGerarPDF_Click);
            // 
            // btnAlunosMorto
            // 
            this.btnAlunosMorto.BackColor = System.Drawing.Color.Transparent;
            this.btnAlunosMorto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlunosMorto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlunosMorto.ForeColor = System.Drawing.Color.Transparent;
            this.btnAlunosMorto.Location = new System.Drawing.Point(3, 49);
            this.btnAlunosMorto.Name = "btnAlunosMorto";
            this.btnAlunosMorto.Size = new System.Drawing.Size(178, 50);
            this.btnAlunosMorto.TabIndex = 23;
            this.btnAlunosMorto.Text = "Alunos\r\n(Morto)";
            this.btnAlunosMorto.UseVisualStyleBackColor = false;
            this.btnAlunosMorto.Click += new System.EventHandler(this.BtnAlunosMorto_Click);
            // 
            // btnFuncionarios
            // 
            this.btnFuncionarios.BackColor = System.Drawing.Color.Transparent;
            this.btnFuncionarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFuncionarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFuncionarios.ForeColor = System.Drawing.Color.Transparent;
            this.btnFuncionarios.Location = new System.Drawing.Point(3, 121);
            this.btnFuncionarios.Name = "btnFuncionarios";
            this.btnFuncionarios.Size = new System.Drawing.Size(178, 39);
            this.btnFuncionarios.TabIndex = 16;
            this.btnFuncionarios.Text = "Funcionários";
            this.btnFuncionarios.UseVisualStyleBackColor = false;
            this.btnFuncionarios.Click += new System.EventHandler(this.BtnFuncionarios_Click);
            // 
            // btnFuncionariosMorto
            // 
            this.btnFuncionariosMorto.BackColor = System.Drawing.Color.Transparent;
            this.btnFuncionariosMorto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFuncionariosMorto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFuncionariosMorto.ForeColor = System.Drawing.Color.Transparent;
            this.btnFuncionariosMorto.Location = new System.Drawing.Point(3, 166);
            this.btnFuncionariosMorto.Name = "btnFuncionariosMorto";
            this.btnFuncionariosMorto.Size = new System.Drawing.Size(178, 50);
            this.btnFuncionariosMorto.TabIndex = 24;
            this.btnFuncionariosMorto.Text = "Funcionários\r\n(Mortos)";
            this.btnFuncionariosMorto.UseVisualStyleBackColor = false;
            this.btnFuncionariosMorto.Click += new System.EventHandler(this.BtnFuncionariosMorto_Click);
            // 
            // btnLivros
            // 
            this.btnLivros.BackColor = System.Drawing.Color.Transparent;
            this.btnLivros.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLivros.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLivros.ForeColor = System.Drawing.Color.Transparent;
            this.btnLivros.Location = new System.Drawing.Point(3, 239);
            this.btnLivros.Name = "btnLivros";
            this.btnLivros.Size = new System.Drawing.Size(178, 44);
            this.btnLivros.TabIndex = 17;
            this.btnLivros.Text = "Livros";
            this.btnLivros.UseVisualStyleBackColor = false;
            this.btnLivros.Click += new System.EventHandler(this.BtnLivros_Click);
            // 
            // btnEmprestimos
            // 
            this.btnEmprestimos.BackColor = System.Drawing.Color.Transparent;
            this.btnEmprestimos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmprestimos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmprestimos.ForeColor = System.Drawing.Color.Transparent;
            this.btnEmprestimos.Location = new System.Drawing.Point(3, 309);
            this.btnEmprestimos.Name = "btnEmprestimos";
            this.btnEmprestimos.Size = new System.Drawing.Size(178, 50);
            this.btnEmprestimos.TabIndex = 18;
            this.btnEmprestimos.Text = "Empréstimos Alunos";
            this.btnEmprestimos.UseVisualStyleBackColor = false;
            this.btnEmprestimos.Click += new System.EventHandler(this.BtnEmprestimos_Click);
            // 
            // btnEmprestimosMorto
            // 
            this.btnEmprestimosMorto.BackColor = System.Drawing.Color.Transparent;
            this.btnEmprestimosMorto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmprestimosMorto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmprestimosMorto.ForeColor = System.Drawing.Color.Transparent;
            this.btnEmprestimosMorto.Location = new System.Drawing.Point(3, 366);
            this.btnEmprestimosMorto.Name = "btnEmprestimosMorto";
            this.btnEmprestimosMorto.Size = new System.Drawing.Size(178, 50);
            this.btnEmprestimosMorto.TabIndex = 21;
            this.btnEmprestimosMorto.Text = "Empréstimos Alunos (Morto)\r\n";
            this.btnEmprestimosMorto.UseVisualStyleBackColor = false;
            this.btnEmprestimosMorto.Click += new System.EventHandler(this.BtnEmprestimosMorto_Click);
            // 
            // btnEmprestimosFuncionarios
            // 
            this.btnEmprestimosFuncionarios.BackColor = System.Drawing.Color.Transparent;
            this.btnEmprestimosFuncionarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmprestimosFuncionarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmprestimosFuncionarios.ForeColor = System.Drawing.Color.Transparent;
            this.btnEmprestimosFuncionarios.Location = new System.Drawing.Point(3, 440);
            this.btnEmprestimosFuncionarios.Name = "btnEmprestimosFuncionarios";
            this.btnEmprestimosFuncionarios.Size = new System.Drawing.Size(178, 51);
            this.btnEmprestimosFuncionarios.TabIndex = 22;
            this.btnEmprestimosFuncionarios.Text = "Empréstimos Funcionários (Morto)";
            this.btnEmprestimosFuncionarios.UseVisualStyleBackColor = false;
            this.btnEmprestimosFuncionarios.Click += new System.EventHandler(this.BtnEmprestimosFuncionarios_Click);
            // 
            // btnEmprestimosFuncionarioMorto
            // 
            this.btnEmprestimosFuncionarioMorto.BackColor = System.Drawing.Color.Transparent;
            this.btnEmprestimosFuncionarioMorto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmprestimosFuncionarioMorto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmprestimosFuncionarioMorto.ForeColor = System.Drawing.Color.Transparent;
            this.btnEmprestimosFuncionarioMorto.Location = new System.Drawing.Point(3, 497);
            this.btnEmprestimosFuncionarioMorto.Name = "btnEmprestimosFuncionarioMorto";
            this.btnEmprestimosFuncionarioMorto.Size = new System.Drawing.Size(178, 70);
            this.btnEmprestimosFuncionarioMorto.TabIndex = 19;
            this.btnEmprestimosFuncionarioMorto.Text = "Empréstimos Funcionários (Morto)";
            this.btnEmprestimosFuncionarioMorto.UseVisualStyleBackColor = false;
            this.btnEmprestimosFuncionarioMorto.Click += new System.EventHandler(this.BtnEmprestimosFuncionarioMorto_Click);
            // 
            // btnMultas
            // 
            this.btnMultas.BackColor = System.Drawing.Color.Transparent;
            this.btnMultas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMultas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMultas.ForeColor = System.Drawing.Color.Transparent;
            this.btnMultas.Location = new System.Drawing.Point(3, 589);
            this.btnMultas.Name = "btnMultas";
            this.btnMultas.Size = new System.Drawing.Size(178, 41);
            this.btnMultas.TabIndex = 26;
            this.btnMultas.Text = "Multas Pagas";
            this.btnMultas.UseVisualStyleBackColor = false;
            this.btnMultas.Click += new System.EventHandler(this.BtnMultas_Click);
            // 
            // btnMultasPendentes
            // 
            this.btnMultasPendentes.BackColor = System.Drawing.Color.Transparent;
            this.btnMultasPendentes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMultasPendentes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMultasPendentes.ForeColor = System.Drawing.Color.Transparent;
            this.btnMultasPendentes.Location = new System.Drawing.Point(3, 636);
            this.btnMultasPendentes.Name = "btnMultasPendentes";
            this.btnMultasPendentes.Size = new System.Drawing.Size(178, 42);
            this.btnMultasPendentes.TabIndex = 27;
            this.btnMultasPendentes.Text = "Multas Pendentes";
            this.btnMultasPendentes.UseVisualStyleBackColor = false;
            this.btnMultasPendentes.Click += new System.EventHandler(this.BtnMultasPendentes_Click);
            // 
            // pnlRelatorios
            // 
            this.pnlRelatorios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlRelatorios.Location = new System.Drawing.Point(200, 0);
            this.pnlRelatorios.Name = "pnlRelatorios";
            this.pnlRelatorios.Size = new System.Drawing.Size(1080, 848);
            this.pnlRelatorios.TabIndex = 17;
            this.pnlRelatorios.Paint += new System.Windows.Forms.PaintEventHandler(this.PnlRelatorios_Paint);
            // 
            // btnFichas
            // 
            this.btnFichas.BackColor = System.Drawing.Color.Transparent;
            this.btnFichas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFichas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFichas.ForeColor = System.Drawing.Color.Transparent;
            this.btnFichas.Location = new System.Drawing.Point(3, 697);
            this.btnFichas.Name = "btnFichas";
            this.btnFichas.Size = new System.Drawing.Size(178, 59);
            this.btnFichas.TabIndex = 28;
            this.btnFichas.Text = "Fichas Catalográficas";
            this.btnFichas.UseVisualStyleBackColor = false;
            this.btnFichas.Click += new System.EventHandler(this.BtnFichas_Click);
            // 
            // btnLeitoresEspeciais
            // 
            this.btnLeitoresEspeciais.BackColor = System.Drawing.Color.Transparent;
            this.btnLeitoresEspeciais.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLeitoresEspeciais.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLeitoresEspeciais.ForeColor = System.Drawing.Color.Transparent;
            this.btnLeitoresEspeciais.Location = new System.Drawing.Point(3, 781);
            this.btnLeitoresEspeciais.Name = "btnLeitoresEspeciais";
            this.btnLeitoresEspeciais.Size = new System.Drawing.Size(178, 42);
            this.btnLeitoresEspeciais.TabIndex = 29;
            this.btnLeitoresEspeciais.Text = "Leitores Especiais";
            this.btnLeitoresEspeciais.UseVisualStyleBackColor = false;
            this.btnLeitoresEspeciais.Click += new System.EventHandler(this.BtnLeitoresEspeciais_Click);
            // 
            // frmRelatorios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 848);
            this.Controls.Add(this.pnlRelatorios);
            this.Controls.Add(this.pnlSuperior);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmRelatorios";
            this.Text = "frmRelatorios";
            this.pnlSuperior.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlSuperior;
        private System.Windows.Forms.Panel pnlRelatorios;
        private System.Windows.Forms.Button btnAlunos;
        private System.Windows.Forms.Button btnEmprestimosFuncionarioMorto;
        private System.Windows.Forms.Button btnEmprestimos;
        private System.Windows.Forms.Button btnLivros;
        private System.Windows.Forms.Button btnFuncionarios;
        private System.Windows.Forms.Button btnEmprestimosMorto;
        private System.Windows.Forms.Button btnEmprestimosFuncionarios;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnAlunosMorto;
        private System.Windows.Forms.Button btnFuncionariosMorto;
        private System.Windows.Forms.Button btnMultas;
        private System.Windows.Forms.Button btnMultasPendentes;
        private System.Windows.Forms.Button btnLeitoresEspeciais;
        private System.Windows.Forms.Button btnFichas;
    }
}