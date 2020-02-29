namespace GUI.CalendarioEscolar
{
    partial class frmCalendarioEscolar
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.trmSlidePainel = new System.Windows.Forms.Timer(this.components);
            this.pnlLivros = new System.Windows.Forms.Panel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.btnIncluir = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gbxMoveis = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.txtNome = new MetroFramework.Controls.MetroTextBox();
            this.txtData = new System.Windows.Forms.MaskedTextBox();
            this.gbxFixos = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.txtNome2 = new MetroFramework.Controls.MetroTextBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.txtDia = new MetroFramework.Controls.MetroTextBox();
            this.txtMes = new MetroFramework.Controls.MetroTextBox();
            this.dtCalendario = new MetroFramework.Controls.MetroDateTime();
            this.pnlOpc = new System.Windows.Forms.Panel();
            this.btnFixo = new System.Windows.Forms.Button();
            this.btnMovel = new System.Windows.Forms.Button();
            this.btnAbir = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dgvDatas = new MetroFramework.Controls.MetroGrid();
            this.pnlSuperior = new System.Windows.Forms.Panel();
            this.txtFiltroFeriado = new MetroFramework.Controls.MetroTextBox();
            this.pnlFiltro = new System.Windows.Forms.Panel();
            this.txtFiltroMes = new MetroFramework.Controls.MetroTextBox();
            this.txtFiltroDia = new MetroFramework.Controls.MetroTextBox();
            this.txtFiltroData = new System.Windows.Forms.MaskedTextBox();
            this.cbxOpcFiltro = new MetroFramework.Controls.MetroComboBox();
            this.pnlLivros.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.gbxMoveis.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.gbxFixos.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.pnlOpc.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatas)).BeginInit();
            this.pnlSuperior.SuspendLayout();
            this.pnlFiltro.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlLivros
            // 
            this.pnlLivros.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(61)))));
            this.pnlLivros.Controls.Add(this.tableLayoutPanel4);
            this.pnlLivros.Controls.Add(this.panel1);
            this.pnlLivros.Controls.Add(this.gbxMoveis);
            this.pnlLivros.Controls.Add(this.gbxFixos);
            this.pnlLivros.Controls.Add(this.dtCalendario);
            this.pnlLivros.Controls.Add(this.pnlOpc);
            this.pnlLivros.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLivros.Location = new System.Drawing.Point(0, 29);
            this.pnlLivros.Name = "pnlLivros";
            this.pnlLivros.Padding = new System.Windows.Forms.Padding(8, 5, 8, 8);
            this.pnlLivros.Size = new System.Drawing.Size(244, 792);
            this.pnlLivros.TabIndex = 10;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.btnIncluir, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.btnExcluir, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.btnLimpar, 0, 2);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(8, 390);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.Padding = new System.Windows.Forms.Padding(5);
            this.tableLayoutPanel4.RowCount = 3;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 49F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(228, 147);
            this.tableLayoutPanel4.TabIndex = 24;
            // 
            // btnIncluir
            // 
            this.btnIncluir.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnIncluir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnIncluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIncluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIncluir.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnIncluir.Location = new System.Drawing.Point(8, 8);
            this.btnIncluir.Name = "btnIncluir";
            this.btnIncluir.Size = new System.Drawing.Size(212, 38);
            this.btnIncluir.TabIndex = 20;
            this.btnIncluir.Text = "Incluir";
            this.btnIncluir.UseVisualStyleBackColor = true;
            this.btnIncluir.Click += new System.EventHandler(this.BtnIncluir_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnExcluir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluir.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnExcluir.Location = new System.Drawing.Point(8, 52);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(212, 38);
            this.btnExcluir.TabIndex = 18;
            this.btnExcluir.Text = "Deletar";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.BtnExcluir_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnLimpar.Location = new System.Drawing.Point(8, 96);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(212, 43);
            this.btnLimpar.TabIndex = 17;
            this.btnLimpar.Text = "Novo";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.BtnLimpar_Click);
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(8, 367);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(228, 23);
            this.panel1.TabIndex = 25;
            // 
            // gbxMoveis
            // 
            this.gbxMoveis.Controls.Add(this.tableLayoutPanel2);
            this.gbxMoveis.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbxMoveis.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxMoveis.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.gbxMoveis.Location = new System.Drawing.Point(8, 225);
            this.gbxMoveis.Name = "gbxMoveis";
            this.gbxMoveis.Size = new System.Drawing.Size(228, 142);
            this.gbxMoveis.TabIndex = 15;
            this.gbxMoveis.TabStop = false;
            this.gbxMoveis.Text = "Moveis e Não Letivos";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35.625F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 64.375F));
            this.tableLayoutPanel2.Controls.Add(this.metroLabel2, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.metroLabel3, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.txtNome, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.txtData, 1, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 25);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 82F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(222, 114);
            this.tableLayoutPanel2.TabIndex = 3;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel2.Location = new System.Drawing.Point(3, 82);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(73, 32);
            this.metroLabel2.TabIndex = 3;
            this.metroLabel2.Text = "Data:";
            this.metroLabel2.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel2.UseCustomBackColor = true;
            this.metroLabel2.UseCustomForeColor = true;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel3.Location = new System.Drawing.Point(3, 0);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(73, 82);
            this.metroLabel3.TabIndex = 15;
            this.metroLabel3.Text = "Nome:";
            this.metroLabel3.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel3.UseCustomBackColor = true;
            this.metroLabel3.UseCustomForeColor = true;
            // 
            // txtNome
            // 
            // 
            // 
            // 
            this.txtNome.CustomButton.Image = null;
            this.txtNome.CustomButton.Location = new System.Drawing.Point(63, 2);
            this.txtNome.CustomButton.Name = "";
            this.txtNome.CustomButton.Size = new System.Drawing.Size(71, 71);
            this.txtNome.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtNome.CustomButton.TabIndex = 1;
            this.txtNome.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtNome.CustomButton.UseSelectable = true;
            this.txtNome.CustomButton.Visible = false;
            this.txtNome.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtNome.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtNome.Lines = new string[0];
            this.txtNome.Location = new System.Drawing.Point(82, 3);
            this.txtNome.MaxLength = 100;
            this.txtNome.Multiline = true;
            this.txtNome.Name = "txtNome";
            this.txtNome.PasswordChar = '\0';
            this.txtNome.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNome.SelectedText = "";
            this.txtNome.SelectionLength = 0;
            this.txtNome.SelectionStart = 0;
            this.txtNome.ShortcutsEnabled = true;
            this.txtNome.Size = new System.Drawing.Size(137, 76);
            this.txtNome.TabIndex = 1;
            this.txtNome.UseSelectable = true;
            this.txtNome.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtNome.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtNome.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtData_KeyDown);
            // 
            // txtData
            // 
            this.txtData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtData.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtData.Location = new System.Drawing.Point(82, 85);
            this.txtData.Mask = "00/00/0000";
            this.txtData.Name = "txtData";
            this.txtData.Size = new System.Drawing.Size(137, 24);
            this.txtData.TabIndex = 2;
            this.txtData.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtData.ValidatingType = typeof(System.DateTime);
            this.txtData.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtData_KeyDown);
            // 
            // gbxFixos
            // 
            this.gbxFixos.Controls.Add(this.tableLayoutPanel1);
            this.gbxFixos.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbxFixos.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxFixos.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.gbxFixos.Location = new System.Drawing.Point(8, 78);
            this.gbxFixos.Name = "gbxFixos";
            this.gbxFixos.Size = new System.Drawing.Size(228, 147);
            this.gbxFixos.TabIndex = 23;
            this.gbxFixos.TabStop = false;
            this.gbxFixos.Text = "Fixos";
            this.gbxFixos.Visible = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35.625F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 64.375F));
            this.tableLayoutPanel1.Controls.Add(this.metroLabel4, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.metroLabel5, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtNome2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 25);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 82F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(222, 119);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel4.Location = new System.Drawing.Point(3, 0);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(73, 82);
            this.metroLabel4.TabIndex = 15;
            this.metroLabel4.Text = "Nome:";
            this.metroLabel4.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel4.UseCustomBackColor = true;
            this.metroLabel4.UseCustomForeColor = true;
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroLabel5.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel5.Location = new System.Drawing.Point(3, 82);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(73, 37);
            this.metroLabel5.TabIndex = 16;
            this.metroLabel5.Text = "Mês:";
            this.metroLabel5.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel5.UseCustomBackColor = true;
            this.metroLabel5.UseCustomForeColor = true;
            // 
            // txtNome2
            // 
            // 
            // 
            // 
            this.txtNome2.CustomButton.Image = null;
            this.txtNome2.CustomButton.Location = new System.Drawing.Point(63, 2);
            this.txtNome2.CustomButton.Name = "";
            this.txtNome2.CustomButton.Size = new System.Drawing.Size(71, 71);
            this.txtNome2.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtNome2.CustomButton.TabIndex = 1;
            this.txtNome2.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtNome2.CustomButton.UseSelectable = true;
            this.txtNome2.CustomButton.Visible = false;
            this.txtNome2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtNome2.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtNome2.Lines = new string[0];
            this.txtNome2.Location = new System.Drawing.Point(82, 3);
            this.txtNome2.MaxLength = 100;
            this.txtNome2.Multiline = true;
            this.txtNome2.Name = "txtNome2";
            this.txtNome2.PasswordChar = '\0';
            this.txtNome2.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNome2.SelectedText = "";
            this.txtNome2.SelectionLength = 0;
            this.txtNome2.SelectionStart = 0;
            this.txtNome2.ShortcutsEnabled = true;
            this.txtNome2.Size = new System.Drawing.Size(137, 76);
            this.txtNome2.TabIndex = 1;
            this.txtNome2.UseSelectable = true;
            this.txtNome2.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtNome2.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtNome2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtData_KeyDown);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.txtDia, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.txtMes, 1, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(82, 85);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(137, 31);
            this.tableLayoutPanel3.TabIndex = 19;
            // 
            // txtDia
            // 
            // 
            // 
            // 
            this.txtDia.CustomButton.Image = null;
            this.txtDia.CustomButton.Location = new System.Drawing.Point(38, 1);
            this.txtDia.CustomButton.Name = "";
            this.txtDia.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txtDia.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtDia.CustomButton.TabIndex = 1;
            this.txtDia.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtDia.CustomButton.UseSelectable = true;
            this.txtDia.CustomButton.Visible = false;
            this.txtDia.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtDia.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtDia.Lines = new string[0];
            this.txtDia.Location = new System.Drawing.Point(3, 3);
            this.txtDia.MaxLength = 2;
            this.txtDia.Multiline = true;
            this.txtDia.Name = "txtDia";
            this.txtDia.PasswordChar = '\0';
            this.txtDia.PromptText = "Dia";
            this.txtDia.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtDia.SelectedText = "";
            this.txtDia.SelectionLength = 0;
            this.txtDia.SelectionStart = 0;
            this.txtDia.ShortcutsEnabled = true;
            this.txtDia.Size = new System.Drawing.Size(62, 25);
            this.txtDia.TabIndex = 2;
            this.txtDia.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtDia.UseSelectable = true;
            this.txtDia.WaterMark = "Dia";
            this.txtDia.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtDia.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDia.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtData_KeyDown);
            // 
            // txtMes
            // 
            // 
            // 
            // 
            this.txtMes.CustomButton.Image = null;
            this.txtMes.CustomButton.Location = new System.Drawing.Point(39, 1);
            this.txtMes.CustomButton.Name = "";
            this.txtMes.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txtMes.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtMes.CustomButton.TabIndex = 1;
            this.txtMes.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtMes.CustomButton.UseSelectable = true;
            this.txtMes.CustomButton.Visible = false;
            this.txtMes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtMes.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtMes.Lines = new string[0];
            this.txtMes.Location = new System.Drawing.Point(71, 3);
            this.txtMes.MaxLength = 2;
            this.txtMes.Multiline = true;
            this.txtMes.Name = "txtMes";
            this.txtMes.PasswordChar = '\0';
            this.txtMes.PromptText = "Mês";
            this.txtMes.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtMes.SelectedText = "";
            this.txtMes.SelectionLength = 0;
            this.txtMes.SelectionStart = 0;
            this.txtMes.ShortcutsEnabled = true;
            this.txtMes.Size = new System.Drawing.Size(63, 25);
            this.txtMes.TabIndex = 3;
            this.txtMes.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtMes.UseSelectable = true;
            this.txtMes.WaterMark = "Mês";
            this.txtMes.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtMes.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMes.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtData_KeyDown);
            // 
            // dtCalendario
            // 
            this.dtCalendario.Dock = System.Windows.Forms.DockStyle.Top;
            this.dtCalendario.Location = new System.Drawing.Point(8, 49);
            this.dtCalendario.MinimumSize = new System.Drawing.Size(0, 29);
            this.dtCalendario.Name = "dtCalendario";
            this.dtCalendario.Size = new System.Drawing.Size(228, 29);
            this.dtCalendario.TabIndex = 22;
            this.dtCalendario.ValueChanged += new System.EventHandler(this.DtCalendario_ValueChanged);
            // 
            // pnlOpc
            // 
            this.pnlOpc.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlOpc.Controls.Add(this.btnFixo);
            this.pnlOpc.Controls.Add(this.btnMovel);
            this.pnlOpc.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlOpc.Location = new System.Drawing.Point(8, 5);
            this.pnlOpc.Name = "pnlOpc";
            this.pnlOpc.Size = new System.Drawing.Size(228, 44);
            this.pnlOpc.TabIndex = 14;
            // 
            // btnFixo
            // 
            this.btnFixo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(61)))));
            this.btnFixo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnFixo.FlatAppearance.BorderSize = 0;
            this.btnFixo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFixo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFixo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnFixo.Location = new System.Drawing.Point(110, 0);
            this.btnFixo.Name = "btnFixo";
            this.btnFixo.Size = new System.Drawing.Size(114, 40);
            this.btnFixo.TabIndex = 13;
            this.btnFixo.Text = "Fixos";
            this.btnFixo.UseVisualStyleBackColor = false;
            this.btnFixo.Click += new System.EventHandler(this.BtnFixo_Click);
            // 
            // btnMovel
            // 
            this.btnMovel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(66)))), ((int)(((byte)(71)))));
            this.btnMovel.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnMovel.FlatAppearance.BorderSize = 0;
            this.btnMovel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMovel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMovel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnMovel.Location = new System.Drawing.Point(0, 0);
            this.btnMovel.Name = "btnMovel";
            this.btnMovel.Size = new System.Drawing.Size(110, 40);
            this.btnMovel.TabIndex = 11;
            this.btnMovel.Text = "Móveis";
            this.btnMovel.UseVisualStyleBackColor = false;
            this.btnMovel.Click += new System.EventHandler(this.BtnMovel_Click);
            // 
            // btnAbir
            // 
            this.btnAbir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(54)))), ((int)(((byte)(59)))));
            this.btnAbir.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnAbir.FlatAppearance.BorderSize = 0;
            this.btnAbir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAbir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbir.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAbir.Location = new System.Drawing.Point(0, 0);
            this.btnAbir.Name = "btnAbir";
            this.btnAbir.Size = new System.Drawing.Size(241, 29);
            this.btnAbir.TabIndex = 8;
            this.btnAbir.Text = "Abrir Painel";
            this.btnAbir.UseVisualStyleBackColor = false;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dgvDatas);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(244, 29);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1036, 792);
            this.panel3.TabIndex = 11;
            // 
            // dgvDatas
            // 
            this.dgvDatas.AllowUserToAddRows = false;
            this.dgvDatas.AllowUserToDeleteRows = false;
            this.dgvDatas.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.dgvDatas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDatas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDatas.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvDatas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvDatas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SunkenHorizontal;
            this.dgvDatas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDatas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDatas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDatas.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvDatas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDatas.EnableHeadersVisualStyles = false;
            this.dgvDatas.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgvDatas.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvDatas.Location = new System.Drawing.Point(0, 0);
            this.dgvDatas.Name = "dgvDatas";
            this.dgvDatas.ReadOnly = true;
            this.dgvDatas.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDatas.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvDatas.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvDatas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDatas.Size = new System.Drawing.Size(1036, 792);
            this.dgvDatas.TabIndex = 5;
            // 
            // pnlSuperior
            // 
            this.pnlSuperior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(72)))), ((int)(((byte)(76)))));
            this.pnlSuperior.Controls.Add(this.txtFiltroFeriado);
            this.pnlSuperior.Controls.Add(this.pnlFiltro);
            this.pnlSuperior.Controls.Add(this.txtFiltroData);
            this.pnlSuperior.Controls.Add(this.cbxOpcFiltro);
            this.pnlSuperior.Controls.Add(this.btnAbir);
            this.pnlSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSuperior.Location = new System.Drawing.Point(0, 0);
            this.pnlSuperior.Name = "pnlSuperior";
            this.pnlSuperior.Size = new System.Drawing.Size(1280, 29);
            this.pnlSuperior.TabIndex = 9;
            // 
            // txtFiltroFeriado
            // 
            // 
            // 
            // 
            this.txtFiltroFeriado.CustomButton.Image = null;
            this.txtFiltroFeriado.CustomButton.Location = new System.Drawing.Point(543, 1);
            this.txtFiltroFeriado.CustomButton.Name = "";
            this.txtFiltroFeriado.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.txtFiltroFeriado.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtFiltroFeriado.CustomButton.TabIndex = 1;
            this.txtFiltroFeriado.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtFiltroFeriado.CustomButton.UseSelectable = true;
            this.txtFiltroFeriado.CustomButton.Visible = false;
            this.txtFiltroFeriado.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtFiltroFeriado.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtFiltroFeriado.Lines = new string[0];
            this.txtFiltroFeriado.Location = new System.Drawing.Point(709, 0);
            this.txtFiltroFeriado.MaxLength = 32767;
            this.txtFiltroFeriado.Name = "txtFiltroFeriado";
            this.txtFiltroFeriado.PasswordChar = '\0';
            this.txtFiltroFeriado.PromptText = "Pesquisar por feriado";
            this.txtFiltroFeriado.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtFiltroFeriado.SelectedText = "";
            this.txtFiltroFeriado.SelectionLength = 0;
            this.txtFiltroFeriado.SelectionStart = 0;
            this.txtFiltroFeriado.ShortcutsEnabled = true;
            this.txtFiltroFeriado.Size = new System.Drawing.Size(571, 29);
            this.txtFiltroFeriado.TabIndex = 21;
            this.txtFiltroFeriado.UseSelectable = true;
            this.txtFiltroFeriado.Visible = false;
            this.txtFiltroFeriado.WaterMark = "Pesquisar por feriado";
            this.txtFiltroFeriado.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtFiltroFeriado.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFiltroFeriado.TextChanged += new System.EventHandler(this.TxtFiltroFeriado_TextChanged);
            // 
            // pnlFiltro
            // 
            this.pnlFiltro.Controls.Add(this.txtFiltroMes);
            this.pnlFiltro.Controls.Add(this.txtFiltroDia);
            this.pnlFiltro.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlFiltro.Location = new System.Drawing.Point(539, 0);
            this.pnlFiltro.Name = "pnlFiltro";
            this.pnlFiltro.Size = new System.Drawing.Size(170, 29);
            this.pnlFiltro.TabIndex = 20;
            this.pnlFiltro.Visible = false;
            // 
            // txtFiltroMes
            // 
            // 
            // 
            // 
            this.txtFiltroMes.CustomButton.Image = null;
            this.txtFiltroMes.CustomButton.Location = new System.Drawing.Point(52, 1);
            this.txtFiltroMes.CustomButton.Name = "";
            this.txtFiltroMes.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.txtFiltroMes.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtFiltroMes.CustomButton.TabIndex = 1;
            this.txtFiltroMes.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtFiltroMes.CustomButton.UseSelectable = true;
            this.txtFiltroMes.CustomButton.Visible = false;
            this.txtFiltroMes.Dock = System.Windows.Forms.DockStyle.Left;
            this.txtFiltroMes.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtFiltroMes.Lines = new string[0];
            this.txtFiltroMes.Location = new System.Drawing.Point(80, 0);
            this.txtFiltroMes.MaxLength = 2;
            this.txtFiltroMes.Name = "txtFiltroMes";
            this.txtFiltroMes.PasswordChar = '\0';
            this.txtFiltroMes.PromptText = "Mês";
            this.txtFiltroMes.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtFiltroMes.SelectedText = "";
            this.txtFiltroMes.SelectionLength = 0;
            this.txtFiltroMes.SelectionStart = 0;
            this.txtFiltroMes.ShortcutsEnabled = true;
            this.txtFiltroMes.Size = new System.Drawing.Size(80, 29);
            this.txtFiltroMes.TabIndex = 20;
            this.txtFiltroMes.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtFiltroMes.UseSelectable = true;
            this.txtFiltroMes.WaterMark = "Mês";
            this.txtFiltroMes.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtFiltroMes.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFiltroMes.TextChanged += new System.EventHandler(this.TxtFiltroMes_TextChanged);
            // 
            // txtFiltroDia
            // 
            // 
            // 
            // 
            this.txtFiltroDia.CustomButton.Image = null;
            this.txtFiltroDia.CustomButton.Location = new System.Drawing.Point(52, 1);
            this.txtFiltroDia.CustomButton.Name = "";
            this.txtFiltroDia.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.txtFiltroDia.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtFiltroDia.CustomButton.TabIndex = 1;
            this.txtFiltroDia.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtFiltroDia.CustomButton.UseSelectable = true;
            this.txtFiltroDia.CustomButton.Visible = false;
            this.txtFiltroDia.Dock = System.Windows.Forms.DockStyle.Left;
            this.txtFiltroDia.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtFiltroDia.Lines = new string[0];
            this.txtFiltroDia.Location = new System.Drawing.Point(0, 0);
            this.txtFiltroDia.MaxLength = 2;
            this.txtFiltroDia.Name = "txtFiltroDia";
            this.txtFiltroDia.PasswordChar = '\0';
            this.txtFiltroDia.PromptText = "Dia";
            this.txtFiltroDia.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtFiltroDia.SelectedText = "";
            this.txtFiltroDia.SelectionLength = 0;
            this.txtFiltroDia.SelectionStart = 0;
            this.txtFiltroDia.ShortcutsEnabled = true;
            this.txtFiltroDia.Size = new System.Drawing.Size(80, 29);
            this.txtFiltroDia.TabIndex = 19;
            this.txtFiltroDia.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtFiltroDia.UseSelectable = true;
            this.txtFiltroDia.WaterMark = "Dia";
            this.txtFiltroDia.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtFiltroDia.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFiltroDia.TextChanged += new System.EventHandler(this.TxtFiltroDia_TextChanged);
            // 
            // txtFiltroData
            // 
            this.txtFiltroData.Dock = System.Windows.Forms.DockStyle.Left;
            this.txtFiltroData.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFiltroData.Location = new System.Drawing.Point(391, 0);
            this.txtFiltroData.Mask = "00/00/0000";
            this.txtFiltroData.Name = "txtFiltroData";
            this.txtFiltroData.Size = new System.Drawing.Size(148, 29);
            this.txtFiltroData.TabIndex = 24;
            this.txtFiltroData.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtFiltroData.ValidatingType = typeof(System.DateTime);
            this.txtFiltroData.TextChanged += new System.EventHandler(this.TxtFiltroData_TextChanged);
            // 
            // cbxOpcFiltro
            // 
            this.cbxOpcFiltro.Dock = System.Windows.Forms.DockStyle.Left;
            this.cbxOpcFiltro.FormattingEnabled = true;
            this.cbxOpcFiltro.ItemHeight = 23;
            this.cbxOpcFiltro.Items.AddRange(new object[] {
            "Data",
            "Nome",
            "Todos"});
            this.cbxOpcFiltro.Location = new System.Drawing.Point(241, 0);
            this.cbxOpcFiltro.Name = "cbxOpcFiltro";
            this.cbxOpcFiltro.Size = new System.Drawing.Size(150, 29);
            this.cbxOpcFiltro.TabIndex = 23;
            this.cbxOpcFiltro.UseSelectable = true;
            this.cbxOpcFiltro.SelectedIndexChanged += new System.EventHandler(this.CbxOpcFiltro_SelectedIndexChanged);
            // 
            // frmCalendarioEscolar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 821);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.pnlLivros);
            this.Controls.Add(this.pnlSuperior);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCalendarioEscolar";
            this.Text = "frmCalendarioEscolar";
            this.Load += new System.EventHandler(this.FrmCalendarioEscolar_Load);
            this.pnlLivros.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.gbxMoveis.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.gbxFixos.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.pnlOpc.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatas)).EndInit();
            this.pnlSuperior.ResumeLayout(false);
            this.pnlSuperior.PerformLayout();
            this.pnlFiltro.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer trmSlidePainel;
        private System.Windows.Forms.Panel pnlLivros;
        private System.Windows.Forms.Button btnAbir;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel pnlSuperior;
        private System.Windows.Forms.Button btnIncluir;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.GroupBox gbxMoveis;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox txtNome;
        private System.Windows.Forms.Panel pnlOpc;
        private System.Windows.Forms.Button btnFixo;
        private System.Windows.Forms.Button btnMovel;
        private System.Windows.Forms.MaskedTextBox txtData;
        private MetroFramework.Controls.MetroDateTime dtCalendario;
        private System.Windows.Forms.GroupBox gbxFixos;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroTextBox txtNome2;
        private MetroFramework.Controls.MetroTextBox txtMes;
        private MetroFramework.Controls.MetroTextBox txtDia;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private MetroFramework.Controls.MetroTextBox txtFiltroFeriado;
        private MetroFramework.Controls.MetroTextBox txtFiltroMes;
        private MetroFramework.Controls.MetroTextBox txtFiltroDia;
        private System.Windows.Forms.Panel pnlFiltro;
        private MetroFramework.Controls.MetroComboBox cbxOpcFiltro;
        private System.Windows.Forms.MaskedTextBox txtFiltroData;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Panel panel1;
        private MetroFramework.Controls.MetroGrid dgvDatas;
    }
}