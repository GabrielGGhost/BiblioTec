namespace GUI.FichaCatalografica
{
    partial class frmFichaCatalograficas
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dgvFichas = new MetroFramework.Controls.MetroGrid();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnExcluirAluno = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblAutor = new MetroFramework.Controls.MetroLabel();
            this.lblEditora = new MetroFramework.Controls.MetroLabel();
            this.lblAno = new MetroFramework.Controls.MetroLabel();
            this.lblCidade = new MetroFramework.Controls.MetroLabel();
            this.metroLabel16 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.lblId = new MetroFramework.Controls.MetroLabel();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.lblNome = new MetroFramework.Controls.MetroLabel();
            this.lblLocalizacao = new MetroFramework.Controls.MetroLabel();
            this.lblTombo = new MetroFramework.Controls.MetroLabel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtTombo = new MetroFramework.Controls.MetroTextBox();
            this.pnlSuperior = new System.Windows.Forms.Panel();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFichas)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dgvFichas);
            this.panel3.Controls.Add(this.panel1);
            this.panel3.Controls.Add(this.pnlSuperior);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1047, 848);
            this.panel3.TabIndex = 9;
            // 
            // dgvFichas
            // 
            this.dgvFichas.AllowUserToAddRows = false;
            this.dgvFichas.AllowUserToDeleteRows = false;
            this.dgvFichas.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.dgvFichas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvFichas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvFichas.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvFichas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvFichas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SunkenHorizontal;
            this.dgvFichas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvFichas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvFichas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvFichas.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvFichas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvFichas.EnableHeadersVisualStyles = false;
            this.dgvFichas.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgvFichas.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvFichas.Location = new System.Drawing.Point(312, 10);
            this.dgvFichas.MultiSelect = false;
            this.dgvFichas.Name = "dgvFichas";
            this.dgvFichas.ReadOnly = true;
            this.dgvFichas.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvFichas.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvFichas.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvFichas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFichas.Size = new System.Drawing.Size(735, 838);
            this.dgvFichas.TabIndex = 27;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(61)))));
            this.panel1.Controls.Add(this.btnExcluirAluno);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.ForeColor = System.Drawing.Color.Transparent;
            this.panel1.Location = new System.Drawing.Point(0, 10);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(8);
            this.panel1.Size = new System.Drawing.Size(312, 838);
            this.panel1.TabIndex = 6;
            // 
            // btnExcluirAluno
            // 
            this.btnExcluirAluno.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnExcluirAluno.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluirAluno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluirAluno.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnExcluirAluno.Location = new System.Drawing.Point(8, 788);
            this.btnExcluirAluno.Name = "btnExcluirAluno";
            this.btnExcluirAluno.Size = new System.Drawing.Size(296, 42);
            this.btnExcluirAluno.TabIndex = 29;
            this.btnExcluirAluno.Text = "Limpar";
            this.btnExcluirAluno.UseVisualStyleBackColor = true;
            this.btnExcluirAluno.Click += new System.EventHandler(this.BtnExcluirAluno_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tableLayoutPanel1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox1.Location = new System.Drawing.Point(8, 47);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(296, 374);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informações do Livro";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.65385F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 66.34615F));
            this.tableLayoutPanel1.Controls.Add(this.lblAutor, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.lblEditora, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.lblAno, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.lblCidade, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.metroLabel16, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.metroLabel4, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.metroLabel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.metroLabel1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.metroLabel3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblId, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.metroLabel8, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.metroLabel7, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.metroLabel6, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.lblNome, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblLocalizacao, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblTombo, 1, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 25);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 8;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.450734F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.177216F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.07595F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.86076F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 21.51899F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.594937F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.02532F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(290, 346);
            this.tableLayoutPanel1.TabIndex = 21;
            // 
            // lblAutor
            // 
            this.lblAutor.AutoSize = true;
            this.lblAutor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblAutor.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblAutor.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblAutor.Location = new System.Drawing.Point(100, 202);
            this.lblAutor.Name = "lblAutor";
            this.lblAutor.Size = new System.Drawing.Size(187, 73);
            this.lblAutor.TabIndex = 15;
            this.lblAutor.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.lblAutor.UseCustomBackColor = true;
            this.lblAutor.UseCustomForeColor = true;
            this.lblAutor.WrapToLine = true;
            // 
            // lblEditora
            // 
            this.lblEditora.AutoSize = true;
            this.lblEditora.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblEditora.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblEditora.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblEditora.Location = new System.Drawing.Point(100, 275);
            this.lblEditora.Name = "lblEditora";
            this.lblEditora.Size = new System.Drawing.Size(187, 26);
            this.lblEditora.TabIndex = 16;
            this.lblEditora.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.lblEditora.UseCustomBackColor = true;
            this.lblEditora.UseCustomForeColor = true;
            this.lblEditora.WrapToLine = true;
            // 
            // lblAno
            // 
            this.lblAno.AutoSize = true;
            this.lblAno.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblAno.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblAno.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblAno.Location = new System.Drawing.Point(100, 172);
            this.lblAno.Name = "lblAno";
            this.lblAno.Size = new System.Drawing.Size(187, 30);
            this.lblAno.TabIndex = 14;
            this.lblAno.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.lblAno.UseCustomBackColor = true;
            this.lblAno.UseCustomForeColor = true;
            this.lblAno.WrapToLine = true;
            // 
            // lblCidade
            // 
            this.lblCidade.AutoSize = true;
            this.lblCidade.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCidade.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblCidade.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblCidade.Location = new System.Drawing.Point(100, 301);
            this.lblCidade.Name = "lblCidade";
            this.lblCidade.Size = new System.Drawing.Size(187, 45);
            this.lblCidade.TabIndex = 9;
            this.lblCidade.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.lblCidade.UseCustomBackColor = true;
            this.lblCidade.UseCustomForeColor = true;
            this.lblCidade.WrapToLine = true;
            // 
            // metroLabel16
            // 
            this.metroLabel16.AutoSize = true;
            this.metroLabel16.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel16.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.metroLabel16.Location = new System.Drawing.Point(3, 301);
            this.metroLabel16.Name = "metroLabel16";
            this.metroLabel16.Size = new System.Drawing.Size(60, 19);
            this.metroLabel16.TabIndex = 14;
            this.metroLabel16.Text = "Cidade:";
            this.metroLabel16.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel16.UseCustomBackColor = true;
            this.metroLabel16.UseCustomForeColor = true;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.metroLabel4.Location = new System.Drawing.Point(3, 134);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(60, 19);
            this.metroLabel4.TabIndex = 8;
            this.metroLabel4.Text = "Tombo:";
            this.metroLabel4.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel4.UseCustomBackColor = true;
            this.metroLabel4.UseCustomForeColor = true;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.metroLabel2.Location = new System.Drawing.Point(3, 0);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(91, 18);
            this.metroLabel2.TabIndex = 5;
            this.metroLabel2.Text = "Id:";
            this.metroLabel2.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel2.UseCustomBackColor = true;
            this.metroLabel2.UseCustomForeColor = true;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.metroLabel1.Location = new System.Drawing.Point(3, 18);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(54, 19);
            this.metroLabel1.TabIndex = 6;
            this.metroLabel1.Text = "Nome:";
            this.metroLabel1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel1.UseCustomBackColor = true;
            this.metroLabel1.UseCustomForeColor = true;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.metroLabel3.Location = new System.Drawing.Point(3, 103);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(91, 19);
            this.metroLabel3.TabIndex = 7;
            this.metroLabel3.Text = "Localização:";
            this.metroLabel3.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel3.UseCustomBackColor = true;
            this.metroLabel3.UseCustomForeColor = true;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblId.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblId.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblId.Location = new System.Drawing.Point(100, 0);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(187, 18);
            this.lblId.TabIndex = 10;
            this.lblId.Text = "0";
            this.lblId.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.lblId.UseCustomBackColor = true;
            this.lblId.UseCustomForeColor = true;
            this.lblId.WrapToLine = true;
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel8.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.metroLabel8.Location = new System.Drawing.Point(3, 275);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(61, 19);
            this.metroLabel8.TabIndex = 7;
            this.metroLabel8.Text = "Editora:";
            this.metroLabel8.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel8.UseCustomBackColor = true;
            this.metroLabel8.UseCustomForeColor = true;
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.metroLabel7.Location = new System.Drawing.Point(3, 202);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(52, 19);
            this.metroLabel7.TabIndex = 6;
            this.metroLabel7.Text = "Autor:";
            this.metroLabel7.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel7.UseCustomBackColor = true;
            this.metroLabel7.UseCustomForeColor = true;
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.metroLabel6.Location = new System.Drawing.Point(3, 172);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(40, 19);
            this.metroLabel6.TabIndex = 5;
            this.metroLabel6.Text = "Ano:";
            this.metroLabel6.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel6.UseCustomBackColor = true;
            this.metroLabel6.UseCustomForeColor = true;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblNome.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblNome.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblNome.Location = new System.Drawing.Point(100, 18);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(187, 85);
            this.lblNome.TabIndex = 11;
            this.lblNome.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.lblNome.UseCustomBackColor = true;
            this.lblNome.UseCustomForeColor = true;
            this.lblNome.WrapToLine = true;
            // 
            // lblLocalizacao
            // 
            this.lblLocalizacao.AutoSize = true;
            this.lblLocalizacao.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblLocalizacao.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblLocalizacao.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblLocalizacao.Location = new System.Drawing.Point(100, 103);
            this.lblLocalizacao.Name = "lblLocalizacao";
            this.lblLocalizacao.Size = new System.Drawing.Size(187, 31);
            this.lblLocalizacao.TabIndex = 12;
            this.lblLocalizacao.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.lblLocalizacao.UseCustomBackColor = true;
            this.lblLocalizacao.UseCustomForeColor = true;
            this.lblLocalizacao.WrapToLine = true;
            // 
            // lblTombo
            // 
            this.lblTombo.AutoSize = true;
            this.lblTombo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTombo.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblTombo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblTombo.Location = new System.Drawing.Point(100, 134);
            this.lblTombo.Name = "lblTombo";
            this.lblTombo.Size = new System.Drawing.Size(187, 38);
            this.lblTombo.TabIndex = 13;
            this.lblTombo.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.lblTombo.UseCustomBackColor = true;
            this.lblTombo.UseCustomForeColor = true;
            this.lblTombo.WrapToLine = true;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(61)))));
            this.panel4.Controls.Add(this.txtTombo);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(8, 8);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(296, 39);
            this.panel4.TabIndex = 23;
            // 
            // txtTombo
            // 
            // 
            // 
            // 
            this.txtTombo.CustomButton.Image = null;
            this.txtTombo.CustomButton.Location = new System.Drawing.Point(268, 1);
            this.txtTombo.CustomButton.Name = "";
            this.txtTombo.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.txtTombo.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtTombo.CustomButton.TabIndex = 1;
            this.txtTombo.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtTombo.CustomButton.UseSelectable = true;
            this.txtTombo.CustomButton.Visible = false;
            this.txtTombo.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtTombo.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtTombo.Lines = new string[0];
            this.txtTombo.Location = new System.Drawing.Point(0, 0);
            this.txtTombo.MaxLength = 100;
            this.txtTombo.Name = "txtTombo";
            this.txtTombo.PasswordChar = '\0';
            this.txtTombo.PromptText = "Pesquisar por Livro";
            this.txtTombo.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtTombo.SelectedText = "";
            this.txtTombo.SelectionLength = 0;
            this.txtTombo.SelectionStart = 0;
            this.txtTombo.ShortcutsEnabled = true;
            this.txtTombo.Size = new System.Drawing.Size(296, 29);
            this.txtTombo.TabIndex = 25;
            this.txtTombo.UseSelectable = true;
            this.txtTombo.WaterMark = "Pesquisar por Livro";
            this.txtTombo.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtTombo.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTombo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtTobo_KeyDown);
            // 
            // pnlSuperior
            // 
            this.pnlSuperior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(72)))), ((int)(((byte)(76)))));
            this.pnlSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSuperior.Location = new System.Drawing.Point(0, 0);
            this.pnlSuperior.Name = "pnlSuperior";
            this.pnlSuperior.Size = new System.Drawing.Size(1047, 10);
            this.pnlSuperior.TabIndex = 5;
            // 
            // frmFichaCatalograficas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1047, 848);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmFichaCatalograficas";
            this.Text = "frmFichaCatalograficas";
            this.Load += new System.EventHandler(this.FrmFichaCatalograficas_Load);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFichas)).EndInit();
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel pnlSuperior;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroLabel lblCidade;
        private System.Windows.Forms.Panel panel4;
        private MetroFramework.Controls.MetroTextBox txtTombo;
        private MetroFramework.Controls.MetroLabel lblEditora;
        private MetroFramework.Controls.MetroLabel lblAutor;
        private MetroFramework.Controls.MetroLabel lblAno;
        private MetroFramework.Controls.MetroLabel metroLabel16;
        private MetroFramework.Controls.MetroLabel lblId;
        private MetroFramework.Controls.MetroLabel lblNome;
        private MetroFramework.Controls.MetroLabel lblLocalizacao;
        private MetroFramework.Controls.MetroLabel lblTombo;
        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Controls.MetroGrid dgvFichas;
        private System.Windows.Forms.Button btnExcluirAluno;
    }
}