namespace GUI.Login
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblMinimize = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAcessar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.pnlLogin = new System.Windows.Forms.Panel();
            this.txtUsuario = new MetroFramework.Controls.MetroTextBox();
            this.lblCriarNovoUsuario = new MetroFramework.Controls.MetroLabel();
            this.lblNovo = new MetroFramework.Controls.MetroLabel();
            this.txtSenha = new MetroFramework.Controls.MetroTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnlCadastrarUsuario = new System.Windows.Forms.Panel();
            this.txtNomeCompleto = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel11 = new MetroFramework.Controls.MetroLabel();
            this.btnCancelarCadastro = new System.Windows.Forms.Button();
            this.txtRepetirNovoPin = new MetroFramework.Controls.MetroTextBox();
            this.txtNovoPin = new MetroFramework.Controls.MetroTextBox();
            this.txtRepetirNovaSenha = new MetroFramework.Controls.MetroTextBox();
            this.txtNovaSenha = new MetroFramework.Controls.MetroTextBox();
            this.txtNovoUsuario = new MetroFramework.Controls.MetroTextBox();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.pnlConfirmar = new System.Windows.Forms.Panel();
            this.txtConfirmarSenhaPrincipal = new MetroFramework.Controls.MetroTextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAcessarPrivilegios = new System.Windows.Forms.Button();
            this.pnlResetarSenha = new System.Windows.Forms.Panel();
            this.pnlMudarSenha = new System.Windows.Forms.Panel();
            this.btnMudarSenha = new System.Windows.Forms.Button();
            this.txtRepetirSenhaConfirmacao = new MetroFramework.Controls.MetroTextBox();
            this.btnCancelarMudarSenha = new System.Windows.Forms.Button();
            this.txtNovaSenhaConfirmacao = new MetroFramework.Controls.MetroTextBox();
            this.pnlAvancar = new System.Windows.Forms.Panel();
            this.txtUsuarioConfirmacao = new MetroFramework.Controls.MetroTextBox();
            this.btnAvancar = new System.Windows.Forms.Button();
            this.btnCancelarConfirmacao = new System.Windows.Forms.Button();
            this.txtPinConfirmar = new MetroFramework.Controls.MetroTextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pnlPai = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.pnlLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlCadastrarUsuario.SuspendLayout();
            this.pnlConfirmar.SuspendLayout();
            this.pnlResetarSenha.SuspendLayout();
            this.pnlMudarSenha.SuspendLayout();
            this.pnlAvancar.SuspendLayout();
            this.panel4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.pnlPai.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.lblMinimize);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.metroLabel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(3, 16);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(361, 93);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel1_Paint);
            // 
            // lblMinimize
            // 
            this.lblMinimize.AutoSize = true;
            this.lblMinimize.BackColor = System.Drawing.Color.Transparent;
            this.lblMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblMinimize.Font = new System.Drawing.Font("Verdana", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMinimize.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblMinimize.Location = new System.Drawing.Point(326, -5);
            this.lblMinimize.Name = "lblMinimize";
            this.lblMinimize.Size = new System.Drawing.Size(32, 38);
            this.lblMinimize.TabIndex = 45;
            this.lblMinimize.Text = "-";
            this.lblMinimize.Click += new System.EventHandler(this.LblMinimize_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label11.Location = new System.Drawing.Point(101, 60);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(174, 23);
            this.label11.TabIndex = 44;
            this.label11.Text = "Fernando Prestes";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Verdana", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label10.Location = new System.Drawing.Point(119, 2);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(140, 59);
            this.label10.TabIndex = 43;
            this.label10.Text = "Etec";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.metroLabel2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.metroLabel2.Location = new System.Drawing.Point(-23, 75);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(471, 19);
            this.metroLabel2.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroLabel2.TabIndex = 16;
            this.metroLabel2.Text = "_____________________________________________________________________________";
            this.metroLabel2.UseCustomBackColor = true;
            this.metroLabel2.UseCustomForeColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(170, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 45;
            this.label1.Text = "V. 1.2";
            // 
            // btnAcessar
            // 
            this.btnAcessar.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnAcessar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAcessar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAcessar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAcessar.Location = new System.Drawing.Point(41, 277);
            this.btnAcessar.Name = "btnAcessar";
            this.btnAcessar.Size = new System.Drawing.Size(131, 45);
            this.btnAcessar.TabIndex = 3;
            this.btnAcessar.Text = "Acessar";
            this.btnAcessar.UseVisualStyleBackColor = false;
            this.btnAcessar.Click += new System.EventHandler(this.BtnAcessar_Click);
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnSair.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSair.Location = new System.Drawing.Point(193, 277);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(131, 45);
            this.btnSair.TabIndex = 4;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.BtnSair_Click);
            // 
            // pnlLogin
            // 
            this.pnlLogin.BackColor = System.Drawing.Color.Transparent;
            this.pnlLogin.Controls.Add(this.label1);
            this.pnlLogin.Controls.Add(this.txtUsuario);
            this.pnlLogin.Controls.Add(this.lblCriarNovoUsuario);
            this.pnlLogin.Controls.Add(this.lblNovo);
            this.pnlLogin.Controls.Add(this.txtSenha);
            this.pnlLogin.Controls.Add(this.btnAcessar);
            this.pnlLogin.Controls.Add(this.btnSair);
            this.pnlLogin.Controls.Add(this.pictureBox1);
            this.pnlLogin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlLogin.Location = new System.Drawing.Point(0, 0);
            this.pnlLogin.Name = "pnlLogin";
            this.pnlLogin.Size = new System.Drawing.Size(361, 377);
            this.pnlLogin.TabIndex = 8;
            // 
            // txtUsuario
            // 
            this.txtUsuario.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtUsuario.CustomButton.Image = null;
            this.txtUsuario.CustomButton.Location = new System.Drawing.Point(137, 1);
            this.txtUsuario.CustomButton.Name = "";
            this.txtUsuario.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtUsuario.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtUsuario.CustomButton.TabIndex = 1;
            this.txtUsuario.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtUsuario.CustomButton.UseSelectable = true;
            this.txtUsuario.CustomButton.Visible = false;
            this.txtUsuario.Lines = new string[0];
            this.txtUsuario.Location = new System.Drawing.Point(110, 157);
            this.txtUsuario.MaxLength = 20;
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.PasswordChar = '\0';
            this.txtUsuario.PromptText = "Login";
            this.txtUsuario.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtUsuario.SelectedText = "";
            this.txtUsuario.SelectionLength = 0;
            this.txtUsuario.SelectionStart = 0;
            this.txtUsuario.ShortcutsEnabled = true;
            this.txtUsuario.Size = new System.Drawing.Size(159, 23);
            this.txtUsuario.TabIndex = 5;
            this.txtUsuario.UseSelectable = true;
            this.txtUsuario.WaterMark = "Login";
            this.txtUsuario.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtUsuario.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtUsuario.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtUsuario_KeyDown);
            // 
            // lblCriarNovoUsuario
            // 
            this.lblCriarNovoUsuario.AutoSize = true;
            this.lblCriarNovoUsuario.BackColor = System.Drawing.Color.Transparent;
            this.lblCriarNovoUsuario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblCriarNovoUsuario.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblCriarNovoUsuario.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblCriarNovoUsuario.Location = new System.Drawing.Point(201, 356);
            this.lblCriarNovoUsuario.Name = "lblCriarNovoUsuario";
            this.lblCriarNovoUsuario.Size = new System.Drawing.Size(159, 19);
            this.lblCriarNovoUsuario.Style = MetroFramework.MetroColorStyle.Blue;
            this.lblCriarNovoUsuario.TabIndex = 12;
            this.lblCriarNovoUsuario.Text = "Redefinir Minha Senha";
            this.lblCriarNovoUsuario.UseCustomBackColor = true;
            this.lblCriarNovoUsuario.UseCustomForeColor = true;
            this.lblCriarNovoUsuario.Click += new System.EventHandler(this.LblCriarNovoUsuario_Click);
            // 
            // lblNovo
            // 
            this.lblNovo.AutoSize = true;
            this.lblNovo.BackColor = System.Drawing.Color.Transparent;
            this.lblNovo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblNovo.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblNovo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblNovo.Location = new System.Drawing.Point(0, 356);
            this.lblNovo.Name = "lblNovo";
            this.lblNovo.Size = new System.Drawing.Size(138, 19);
            this.lblNovo.Style = MetroFramework.MetroColorStyle.Blue;
            this.lblNovo.TabIndex = 11;
            this.lblNovo.Text = "Criar Novo Usuário";
            this.lblNovo.UseCustomBackColor = true;
            this.lblNovo.UseCustomForeColor = true;
            this.lblNovo.Click += new System.EventHandler(this.BtnNovoUsuario_Click);
            // 
            // txtSenha
            // 
            // 
            // 
            // 
            this.txtSenha.CustomButton.Image = null;
            this.txtSenha.CustomButton.Location = new System.Drawing.Point(137, 1);
            this.txtSenha.CustomButton.Name = "";
            this.txtSenha.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtSenha.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtSenha.CustomButton.TabIndex = 1;
            this.txtSenha.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtSenha.CustomButton.UseSelectable = true;
            this.txtSenha.CustomButton.Visible = false;
            this.txtSenha.Lines = new string[0];
            this.txtSenha.Location = new System.Drawing.Point(110, 196);
            this.txtSenha.MaxLength = 20;
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.PasswordChar = '*';
            this.txtSenha.PromptText = "Senha";
            this.txtSenha.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSenha.SelectedText = "";
            this.txtSenha.SelectionLength = 0;
            this.txtSenha.SelectionStart = 0;
            this.txtSenha.ShortcutsEnabled = true;
            this.txtSenha.Size = new System.Drawing.Size(159, 23);
            this.txtSenha.TabIndex = 6;
            this.txtSenha.UseSelectable = true;
            this.txtSenha.WaterMark = "Senha";
            this.txtSenha.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtSenha.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtSenha.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtSenha_KeyDown);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(89, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(203, 193);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // pnlCadastrarUsuario
            // 
            this.pnlCadastrarUsuario.BackColor = System.Drawing.Color.Transparent;
            this.pnlCadastrarUsuario.Controls.Add(this.txtNomeCompleto);
            this.pnlCadastrarUsuario.Controls.Add(this.metroLabel11);
            this.pnlCadastrarUsuario.Controls.Add(this.btnCancelarCadastro);
            this.pnlCadastrarUsuario.Controls.Add(this.txtRepetirNovoPin);
            this.pnlCadastrarUsuario.Controls.Add(this.txtNovoPin);
            this.pnlCadastrarUsuario.Controls.Add(this.txtRepetirNovaSenha);
            this.pnlCadastrarUsuario.Controls.Add(this.txtNovaSenha);
            this.pnlCadastrarUsuario.Controls.Add(this.txtNovoUsuario);
            this.pnlCadastrarUsuario.Controls.Add(this.btnCadastrar);
            this.pnlCadastrarUsuario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCadastrarUsuario.Location = new System.Drawing.Point(0, 0);
            this.pnlCadastrarUsuario.Name = "pnlCadastrarUsuario";
            this.pnlCadastrarUsuario.Size = new System.Drawing.Size(361, 377);
            this.pnlCadastrarUsuario.TabIndex = 9;
            this.pnlCadastrarUsuario.Visible = false;
            // 
            // txtNomeCompleto
            // 
            // 
            // 
            // 
            this.txtNomeCompleto.CustomButton.Image = null;
            this.txtNomeCompleto.CustomButton.Location = new System.Drawing.Point(211, 1);
            this.txtNomeCompleto.CustomButton.Name = "";
            this.txtNomeCompleto.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtNomeCompleto.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtNomeCompleto.CustomButton.TabIndex = 1;
            this.txtNomeCompleto.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtNomeCompleto.CustomButton.UseSelectable = true;
            this.txtNomeCompleto.CustomButton.Visible = false;
            this.txtNomeCompleto.Lines = new string[0];
            this.txtNomeCompleto.Location = new System.Drawing.Point(76, 61);
            this.txtNomeCompleto.MaxLength = 20;
            this.txtNomeCompleto.Name = "txtNomeCompleto";
            this.txtNomeCompleto.PasswordChar = '\0';
            this.txtNomeCompleto.PromptText = "Nome Completo";
            this.txtNomeCompleto.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNomeCompleto.SelectedText = "";
            this.txtNomeCompleto.SelectionLength = 0;
            this.txtNomeCompleto.SelectionStart = 0;
            this.txtNomeCompleto.ShortcutsEnabled = true;
            this.txtNomeCompleto.Size = new System.Drawing.Size(233, 23);
            this.txtNomeCompleto.TabIndex = 1;
            this.txtNomeCompleto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtNomeCompleto.UseSelectable = true;
            this.txtNomeCompleto.WaterMark = "Nome Completo";
            this.txtNomeCompleto.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtNomeCompleto.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtNomeCompleto.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtNomeCompleto_KeyDown);
            // 
            // metroLabel11
            // 
            this.metroLabel11.AutoSize = true;
            this.metroLabel11.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel11.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel11.Location = new System.Drawing.Point(76, 14);
            this.metroLabel11.Name = "metroLabel11";
            this.metroLabel11.Size = new System.Drawing.Size(214, 25);
            this.metroLabel11.TabIndex = 21;
            this.metroLabel11.Text = "Cadastrar Novo Usuário";
            this.metroLabel11.UseCustomBackColor = true;
            this.metroLabel11.UseCustomForeColor = true;
            // 
            // btnCancelarCadastro
            // 
            this.btnCancelarCadastro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnCancelarCadastro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelarCadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelarCadastro.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCancelarCadastro.Location = new System.Drawing.Point(186, 303);
            this.btnCancelarCadastro.Name = "btnCancelarCadastro";
            this.btnCancelarCadastro.Size = new System.Drawing.Size(153, 36);
            this.btnCancelarCadastro.TabIndex = 15;
            this.btnCancelarCadastro.Text = "Cancelar";
            this.btnCancelarCadastro.UseVisualStyleBackColor = false;
            this.btnCancelarCadastro.Click += new System.EventHandler(this.BtnCancelarCadastro_Click);
            // 
            // txtRepetirNovoPin
            // 
            // 
            // 
            // 
            this.txtRepetirNovoPin.CustomButton.Image = null;
            this.txtRepetirNovoPin.CustomButton.Location = new System.Drawing.Point(135, 1);
            this.txtRepetirNovoPin.CustomButton.Name = "";
            this.txtRepetirNovoPin.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtRepetirNovoPin.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtRepetirNovoPin.CustomButton.TabIndex = 1;
            this.txtRepetirNovoPin.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtRepetirNovoPin.CustomButton.UseSelectable = true;
            this.txtRepetirNovoPin.CustomButton.Visible = false;
            this.txtRepetirNovoPin.Lines = new string[0];
            this.txtRepetirNovoPin.Location = new System.Drawing.Point(108, 238);
            this.txtRepetirNovoPin.MaxLength = 20;
            this.txtRepetirNovoPin.Name = "txtRepetirNovoPin";
            this.txtRepetirNovoPin.PasswordChar = '*';
            this.txtRepetirNovoPin.PromptText = "Repetir Pin";
            this.txtRepetirNovoPin.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtRepetirNovoPin.SelectedText = "";
            this.txtRepetirNovoPin.SelectionLength = 0;
            this.txtRepetirNovoPin.SelectionStart = 0;
            this.txtRepetirNovoPin.ShortcutsEnabled = true;
            this.txtRepetirNovoPin.Size = new System.Drawing.Size(157, 23);
            this.txtRepetirNovoPin.TabIndex = 6;
            this.txtRepetirNovoPin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtRepetirNovoPin.UseSelectable = true;
            this.txtRepetirNovoPin.WaterMark = "Repetir Pin";
            this.txtRepetirNovoPin.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtRepetirNovoPin.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtRepetirNovoPin.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtRepetirNovoPin_KeyDown);
            // 
            // txtNovoPin
            // 
            // 
            // 
            // 
            this.txtNovoPin.CustomButton.Image = null;
            this.txtNovoPin.CustomButton.Location = new System.Drawing.Point(135, 1);
            this.txtNovoPin.CustomButton.Name = "";
            this.txtNovoPin.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtNovoPin.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtNovoPin.CustomButton.TabIndex = 1;
            this.txtNovoPin.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtNovoPin.CustomButton.UseSelectable = true;
            this.txtNovoPin.CustomButton.Visible = false;
            this.txtNovoPin.Lines = new string[0];
            this.txtNovoPin.Location = new System.Drawing.Point(108, 209);
            this.txtNovoPin.MaxLength = 20;
            this.txtNovoPin.Name = "txtNovoPin";
            this.txtNovoPin.PasswordChar = '*';
            this.txtNovoPin.PromptText = "Pin";
            this.txtNovoPin.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNovoPin.SelectedText = "";
            this.txtNovoPin.SelectionLength = 0;
            this.txtNovoPin.SelectionStart = 0;
            this.txtNovoPin.ShortcutsEnabled = true;
            this.txtNovoPin.Size = new System.Drawing.Size(157, 23);
            this.txtNovoPin.TabIndex = 5;
            this.txtNovoPin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtNovoPin.UseSelectable = true;
            this.txtNovoPin.WaterMark = "Pin";
            this.txtNovoPin.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtNovoPin.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtNovoPin.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtNovoPin_KeyDown);
            // 
            // txtRepetirNovaSenha
            // 
            // 
            // 
            // 
            this.txtRepetirNovaSenha.CustomButton.Image = null;
            this.txtRepetirNovaSenha.CustomButton.Location = new System.Drawing.Point(135, 1);
            this.txtRepetirNovaSenha.CustomButton.Name = "";
            this.txtRepetirNovaSenha.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtRepetirNovaSenha.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtRepetirNovaSenha.CustomButton.TabIndex = 1;
            this.txtRepetirNovaSenha.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtRepetirNovaSenha.CustomButton.UseSelectable = true;
            this.txtRepetirNovaSenha.CustomButton.Visible = false;
            this.txtRepetirNovaSenha.Lines = new string[0];
            this.txtRepetirNovaSenha.Location = new System.Drawing.Point(108, 170);
            this.txtRepetirNovaSenha.MaxLength = 20;
            this.txtRepetirNovaSenha.Name = "txtRepetirNovaSenha";
            this.txtRepetirNovaSenha.PasswordChar = '*';
            this.txtRepetirNovaSenha.PromptText = "Repetir Senha";
            this.txtRepetirNovaSenha.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtRepetirNovaSenha.SelectedText = "";
            this.txtRepetirNovaSenha.SelectionLength = 0;
            this.txtRepetirNovaSenha.SelectionStart = 0;
            this.txtRepetirNovaSenha.ShortcutsEnabled = true;
            this.txtRepetirNovaSenha.Size = new System.Drawing.Size(157, 23);
            this.txtRepetirNovaSenha.TabIndex = 4;
            this.txtRepetirNovaSenha.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtRepetirNovaSenha.UseSelectable = true;
            this.txtRepetirNovaSenha.WaterMark = "Repetir Senha";
            this.txtRepetirNovaSenha.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtRepetirNovaSenha.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtRepetirNovaSenha.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtRepetirNovaSenha_KeyDown);
            // 
            // txtNovaSenha
            // 
            // 
            // 
            // 
            this.txtNovaSenha.CustomButton.Image = null;
            this.txtNovaSenha.CustomButton.Location = new System.Drawing.Point(135, 1);
            this.txtNovaSenha.CustomButton.Name = "";
            this.txtNovaSenha.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtNovaSenha.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtNovaSenha.CustomButton.TabIndex = 1;
            this.txtNovaSenha.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtNovaSenha.CustomButton.UseSelectable = true;
            this.txtNovaSenha.CustomButton.Visible = false;
            this.txtNovaSenha.Lines = new string[0];
            this.txtNovaSenha.Location = new System.Drawing.Point(108, 140);
            this.txtNovaSenha.MaxLength = 20;
            this.txtNovaSenha.Name = "txtNovaSenha";
            this.txtNovaSenha.PasswordChar = '*';
            this.txtNovaSenha.PromptText = "Senha";
            this.txtNovaSenha.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNovaSenha.SelectedText = "";
            this.txtNovaSenha.SelectionLength = 0;
            this.txtNovaSenha.SelectionStart = 0;
            this.txtNovaSenha.ShortcutsEnabled = true;
            this.txtNovaSenha.Size = new System.Drawing.Size(157, 23);
            this.txtNovaSenha.TabIndex = 3;
            this.txtNovaSenha.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtNovaSenha.UseSelectable = true;
            this.txtNovaSenha.WaterMark = "Senha";
            this.txtNovaSenha.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtNovaSenha.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtNovaSenha.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtNovaSenha_KeyDown);
            // 
            // txtNovoUsuario
            // 
            // 
            // 
            // 
            this.txtNovoUsuario.CustomButton.Image = null;
            this.txtNovoUsuario.CustomButton.Location = new System.Drawing.Point(135, 1);
            this.txtNovoUsuario.CustomButton.Name = "";
            this.txtNovoUsuario.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtNovoUsuario.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtNovoUsuario.CustomButton.TabIndex = 1;
            this.txtNovoUsuario.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtNovoUsuario.CustomButton.UseSelectable = true;
            this.txtNovoUsuario.CustomButton.Visible = false;
            this.txtNovoUsuario.Lines = new string[0];
            this.txtNovoUsuario.Location = new System.Drawing.Point(108, 100);
            this.txtNovoUsuario.MaxLength = 20;
            this.txtNovoUsuario.Name = "txtNovoUsuario";
            this.txtNovoUsuario.PasswordChar = '\0';
            this.txtNovoUsuario.PromptText = "Usuário";
            this.txtNovoUsuario.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNovoUsuario.SelectedText = "";
            this.txtNovoUsuario.SelectionLength = 0;
            this.txtNovoUsuario.SelectionStart = 0;
            this.txtNovoUsuario.ShortcutsEnabled = true;
            this.txtNovoUsuario.Size = new System.Drawing.Size(157, 23);
            this.txtNovoUsuario.TabIndex = 2;
            this.txtNovoUsuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtNovoUsuario.UseSelectable = true;
            this.txtNovoUsuario.WaterMark = "Usuário";
            this.txtNovoUsuario.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtNovoUsuario.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtNovoUsuario.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtNovoUsuario_KeyDown);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCadastrar.Location = new System.Drawing.Point(34, 303);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(147, 36);
            this.btnCadastrar.TabIndex = 6;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = false;
            this.btnCadastrar.Click += new System.EventHandler(this.BtnCadastrar_Click);
            // 
            // pnlConfirmar
            // 
            this.pnlConfirmar.BackColor = System.Drawing.Color.Transparent;
            this.pnlConfirmar.Controls.Add(this.txtConfirmarSenhaPrincipal);
            this.pnlConfirmar.Controls.Add(this.btnCancelar);
            this.pnlConfirmar.Controls.Add(this.btnAcessarPrivilegios);
            this.pnlConfirmar.Location = new System.Drawing.Point(73, 90);
            this.pnlConfirmar.Name = "pnlConfirmar";
            this.pnlConfirmar.Size = new System.Drawing.Size(225, 127);
            this.pnlConfirmar.TabIndex = 10;
            this.pnlConfirmar.Visible = false;
            // 
            // txtConfirmarSenhaPrincipal
            // 
            // 
            // 
            // 
            this.txtConfirmarSenhaPrincipal.CustomButton.Image = null;
            this.txtConfirmarSenhaPrincipal.CustomButton.Location = new System.Drawing.Point(135, 1);
            this.txtConfirmarSenhaPrincipal.CustomButton.Name = "";
            this.txtConfirmarSenhaPrincipal.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtConfirmarSenhaPrincipal.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtConfirmarSenhaPrincipal.CustomButton.TabIndex = 1;
            this.txtConfirmarSenhaPrincipal.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtConfirmarSenhaPrincipal.CustomButton.UseSelectable = true;
            this.txtConfirmarSenhaPrincipal.CustomButton.Visible = false;
            this.txtConfirmarSenhaPrincipal.Lines = new string[0];
            this.txtConfirmarSenhaPrincipal.Location = new System.Drawing.Point(40, 33);
            this.txtConfirmarSenhaPrincipal.MaxLength = 32767;
            this.txtConfirmarSenhaPrincipal.Name = "txtConfirmarSenhaPrincipal";
            this.txtConfirmarSenhaPrincipal.PasswordChar = '*';
            this.txtConfirmarSenhaPrincipal.PromptText = "Confirmar Senha Principal";
            this.txtConfirmarSenhaPrincipal.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtConfirmarSenhaPrincipal.SelectedText = "";
            this.txtConfirmarSenhaPrincipal.SelectionLength = 0;
            this.txtConfirmarSenhaPrincipal.SelectionStart = 0;
            this.txtConfirmarSenhaPrincipal.ShortcutsEnabled = true;
            this.txtConfirmarSenhaPrincipal.Size = new System.Drawing.Size(157, 23);
            this.txtConfirmarSenhaPrincipal.TabIndex = 9;
            this.txtConfirmarSenhaPrincipal.UseSelectable = true;
            this.txtConfirmarSenhaPrincipal.WaterMark = "Confirmar Senha Principal";
            this.txtConfirmarSenhaPrincipal.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtConfirmarSenhaPrincipal.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtConfirmarSenhaPrincipal.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtConfirmarSenhaPrincipal_KeyDown);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCancelar.Location = new System.Drawing.Point(123, 81);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(98, 36);
            this.btnCancelar.TabIndex = 8;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // btnAcessarPrivilegios
            // 
            this.btnAcessarPrivilegios.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnAcessarPrivilegios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAcessarPrivilegios.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAcessarPrivilegios.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAcessarPrivilegios.Location = new System.Drawing.Point(9, 81);
            this.btnAcessarPrivilegios.Name = "btnAcessarPrivilegios";
            this.btnAcessarPrivilegios.Size = new System.Drawing.Size(98, 36);
            this.btnAcessarPrivilegios.TabIndex = 7;
            this.btnAcessarPrivilegios.Text = "Acessar";
            this.btnAcessarPrivilegios.UseVisualStyleBackColor = false;
            this.btnAcessarPrivilegios.Click += new System.EventHandler(this.BtnAcessarPrivilegios_Click);
            // 
            // pnlResetarSenha
            // 
            this.pnlResetarSenha.BackColor = System.Drawing.Color.Transparent;
            this.pnlResetarSenha.Controls.Add(this.pnlMudarSenha);
            this.pnlResetarSenha.Controls.Add(this.pnlAvancar);
            this.pnlResetarSenha.Controls.Add(this.panel4);
            this.pnlResetarSenha.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlResetarSenha.Location = new System.Drawing.Point(0, 0);
            this.pnlResetarSenha.Name = "pnlResetarSenha";
            this.pnlResetarSenha.Size = new System.Drawing.Size(361, 377);
            this.pnlResetarSenha.TabIndex = 16;
            this.pnlResetarSenha.Visible = false;
            // 
            // pnlMudarSenha
            // 
            this.pnlMudarSenha.Controls.Add(this.btnMudarSenha);
            this.pnlMudarSenha.Controls.Add(this.txtRepetirSenhaConfirmacao);
            this.pnlMudarSenha.Controls.Add(this.btnCancelarMudarSenha);
            this.pnlMudarSenha.Controls.Add(this.txtNovaSenhaConfirmacao);
            this.pnlMudarSenha.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlMudarSenha.Location = new System.Drawing.Point(0, 213);
            this.pnlMudarSenha.Name = "pnlMudarSenha";
            this.pnlMudarSenha.Size = new System.Drawing.Size(361, 183);
            this.pnlMudarSenha.TabIndex = 8;
            this.pnlMudarSenha.Visible = false;
            // 
            // btnMudarSenha
            // 
            this.btnMudarSenha.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnMudarSenha.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMudarSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMudarSenha.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnMudarSenha.Location = new System.Drawing.Point(60, 106);
            this.btnMudarSenha.Name = "btnMudarSenha";
            this.btnMudarSenha.Size = new System.Drawing.Size(120, 35);
            this.btnMudarSenha.TabIndex = 9;
            this.btnMudarSenha.Text = "Mudar Senha";
            this.btnMudarSenha.UseVisualStyleBackColor = false;
            this.btnMudarSenha.Click += new System.EventHandler(this.BtnMudarSenha_Click);
            // 
            // txtRepetirSenhaConfirmacao
            // 
            // 
            // 
            // 
            this.txtRepetirSenhaConfirmacao.CustomButton.Image = null;
            this.txtRepetirSenhaConfirmacao.CustomButton.Location = new System.Drawing.Point(133, 1);
            this.txtRepetirSenhaConfirmacao.CustomButton.Name = "";
            this.txtRepetirSenhaConfirmacao.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtRepetirSenhaConfirmacao.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtRepetirSenhaConfirmacao.CustomButton.TabIndex = 1;
            this.txtRepetirSenhaConfirmacao.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtRepetirSenhaConfirmacao.CustomButton.UseSelectable = true;
            this.txtRepetirSenhaConfirmacao.CustomButton.Visible = false;
            this.txtRepetirSenhaConfirmacao.Lines = new string[0];
            this.txtRepetirSenhaConfirmacao.Location = new System.Drawing.Point(110, 60);
            this.txtRepetirSenhaConfirmacao.MaxLength = 32767;
            this.txtRepetirSenhaConfirmacao.Name = "txtRepetirSenhaConfirmacao";
            this.txtRepetirSenhaConfirmacao.PasswordChar = '*';
            this.txtRepetirSenhaConfirmacao.PromptText = "Repetir Nova Senha";
            this.txtRepetirSenhaConfirmacao.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtRepetirSenhaConfirmacao.SelectedText = "";
            this.txtRepetirSenhaConfirmacao.SelectionLength = 0;
            this.txtRepetirSenhaConfirmacao.SelectionStart = 0;
            this.txtRepetirSenhaConfirmacao.ShortcutsEnabled = true;
            this.txtRepetirSenhaConfirmacao.Size = new System.Drawing.Size(155, 23);
            this.txtRepetirSenhaConfirmacao.TabIndex = 8;
            this.txtRepetirSenhaConfirmacao.UseSelectable = true;
            this.txtRepetirSenhaConfirmacao.WaterMark = "Repetir Nova Senha";
            this.txtRepetirSenhaConfirmacao.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtRepetirSenhaConfirmacao.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtRepetirSenhaConfirmacao.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtRepetirSenhaConfirmacao_KeyDown);
            // 
            // btnCancelarMudarSenha
            // 
            this.btnCancelarMudarSenha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnCancelarMudarSenha.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelarMudarSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelarMudarSenha.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCancelarMudarSenha.Location = new System.Drawing.Point(200, 106);
            this.btnCancelarMudarSenha.Name = "btnCancelarMudarSenha";
            this.btnCancelarMudarSenha.Size = new System.Drawing.Size(120, 35);
            this.btnCancelarMudarSenha.TabIndex = 10;
            this.btnCancelarMudarSenha.Text = "Cancelar";
            this.btnCancelarMudarSenha.UseVisualStyleBackColor = false;
            this.btnCancelarMudarSenha.Click += new System.EventHandler(this.BtnCancelarMudarSenha_Click);
            // 
            // txtNovaSenhaConfirmacao
            // 
            // 
            // 
            // 
            this.txtNovaSenhaConfirmacao.CustomButton.Image = null;
            this.txtNovaSenhaConfirmacao.CustomButton.Location = new System.Drawing.Point(133, 1);
            this.txtNovaSenhaConfirmacao.CustomButton.Name = "";
            this.txtNovaSenhaConfirmacao.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtNovaSenhaConfirmacao.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtNovaSenhaConfirmacao.CustomButton.TabIndex = 1;
            this.txtNovaSenhaConfirmacao.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtNovaSenhaConfirmacao.CustomButton.UseSelectable = true;
            this.txtNovaSenhaConfirmacao.CustomButton.Visible = false;
            this.txtNovaSenhaConfirmacao.Lines = new string[0];
            this.txtNovaSenhaConfirmacao.Location = new System.Drawing.Point(110, 25);
            this.txtNovaSenhaConfirmacao.MaxLength = 32767;
            this.txtNovaSenhaConfirmacao.Name = "txtNovaSenhaConfirmacao";
            this.txtNovaSenhaConfirmacao.PasswordChar = '*';
            this.txtNovaSenhaConfirmacao.PromptText = "Nova Senha";
            this.txtNovaSenhaConfirmacao.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNovaSenhaConfirmacao.SelectedText = "";
            this.txtNovaSenhaConfirmacao.SelectionLength = 0;
            this.txtNovaSenhaConfirmacao.SelectionStart = 0;
            this.txtNovaSenhaConfirmacao.ShortcutsEnabled = true;
            this.txtNovaSenhaConfirmacao.Size = new System.Drawing.Size(155, 23);
            this.txtNovaSenhaConfirmacao.TabIndex = 7;
            this.txtNovaSenhaConfirmacao.UseSelectable = true;
            this.txtNovaSenhaConfirmacao.WaterMark = "Nova Senha";
            this.txtNovaSenhaConfirmacao.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtNovaSenhaConfirmacao.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtNovaSenhaConfirmacao.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtNovaSenhaConfirmacao_KeyDown);
            // 
            // pnlAvancar
            // 
            this.pnlAvancar.Controls.Add(this.txtUsuarioConfirmacao);
            this.pnlAvancar.Controls.Add(this.btnAvancar);
            this.pnlAvancar.Controls.Add(this.btnCancelarConfirmacao);
            this.pnlAvancar.Controls.Add(this.txtPinConfirmar);
            this.pnlAvancar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlAvancar.Location = new System.Drawing.Point(0, 30);
            this.pnlAvancar.Name = "pnlAvancar";
            this.pnlAvancar.Size = new System.Drawing.Size(361, 183);
            this.pnlAvancar.TabIndex = 7;
            // 
            // txtUsuarioConfirmacao
            // 
            // 
            // 
            // 
            this.txtUsuarioConfirmacao.CustomButton.Image = null;
            this.txtUsuarioConfirmacao.CustomButton.Location = new System.Drawing.Point(133, 1);
            this.txtUsuarioConfirmacao.CustomButton.Name = "";
            this.txtUsuarioConfirmacao.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtUsuarioConfirmacao.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtUsuarioConfirmacao.CustomButton.TabIndex = 1;
            this.txtUsuarioConfirmacao.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtUsuarioConfirmacao.CustomButton.UseSelectable = true;
            this.txtUsuarioConfirmacao.CustomButton.Visible = false;
            this.txtUsuarioConfirmacao.Lines = new string[0];
            this.txtUsuarioConfirmacao.Location = new System.Drawing.Point(110, 25);
            this.txtUsuarioConfirmacao.MaxLength = 32767;
            this.txtUsuarioConfirmacao.Name = "txtUsuarioConfirmacao";
            this.txtUsuarioConfirmacao.PasswordChar = '\0';
            this.txtUsuarioConfirmacao.PromptText = "Usuário";
            this.txtUsuarioConfirmacao.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtUsuarioConfirmacao.SelectedText = "";
            this.txtUsuarioConfirmacao.SelectionLength = 0;
            this.txtUsuarioConfirmacao.SelectionStart = 0;
            this.txtUsuarioConfirmacao.ShortcutsEnabled = true;
            this.txtUsuarioConfirmacao.Size = new System.Drawing.Size(155, 23);
            this.txtUsuarioConfirmacao.TabIndex = 0;
            this.txtUsuarioConfirmacao.UseSelectable = true;
            this.txtUsuarioConfirmacao.WaterMark = "Usuário";
            this.txtUsuarioConfirmacao.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtUsuarioConfirmacao.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtUsuarioConfirmacao.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtUsuarioConfirmacao_KeyDown);
            // 
            // btnAvancar
            // 
            this.btnAvancar.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnAvancar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAvancar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAvancar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAvancar.Location = new System.Drawing.Point(60, 106);
            this.btnAvancar.Name = "btnAvancar";
            this.btnAvancar.Size = new System.Drawing.Size(120, 35);
            this.btnAvancar.TabIndex = 5;
            this.btnAvancar.Text = "Avançar";
            this.btnAvancar.UseVisualStyleBackColor = false;
            this.btnAvancar.Click += new System.EventHandler(this.BtnAvancar_Click);
            // 
            // btnCancelarConfirmacao
            // 
            this.btnCancelarConfirmacao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnCancelarConfirmacao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelarConfirmacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelarConfirmacao.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCancelarConfirmacao.Location = new System.Drawing.Point(200, 106);
            this.btnCancelarConfirmacao.Name = "btnCancelarConfirmacao";
            this.btnCancelarConfirmacao.Size = new System.Drawing.Size(120, 35);
            this.btnCancelarConfirmacao.TabIndex = 6;
            this.btnCancelarConfirmacao.Text = "Cancelar";
            this.btnCancelarConfirmacao.UseVisualStyleBackColor = false;
            this.btnCancelarConfirmacao.Click += new System.EventHandler(this.BtnCancelarConfirmacao_Click);
            // 
            // txtPinConfirmar
            // 
            // 
            // 
            // 
            this.txtPinConfirmar.CustomButton.Image = null;
            this.txtPinConfirmar.CustomButton.Location = new System.Drawing.Point(133, 1);
            this.txtPinConfirmar.CustomButton.Name = "";
            this.txtPinConfirmar.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtPinConfirmar.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPinConfirmar.CustomButton.TabIndex = 1;
            this.txtPinConfirmar.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPinConfirmar.CustomButton.UseSelectable = true;
            this.txtPinConfirmar.CustomButton.Visible = false;
            this.txtPinConfirmar.Lines = new string[0];
            this.txtPinConfirmar.Location = new System.Drawing.Point(110, 60);
            this.txtPinConfirmar.MaxLength = 32767;
            this.txtPinConfirmar.Name = "txtPinConfirmar";
            this.txtPinConfirmar.PasswordChar = '*';
            this.txtPinConfirmar.PromptText = "Pin";
            this.txtPinConfirmar.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPinConfirmar.SelectedText = "";
            this.txtPinConfirmar.SelectionLength = 0;
            this.txtPinConfirmar.SelectionStart = 0;
            this.txtPinConfirmar.ShortcutsEnabled = true;
            this.txtPinConfirmar.Size = new System.Drawing.Size(155, 23);
            this.txtPinConfirmar.TabIndex = 2;
            this.txtPinConfirmar.UseSelectable = true;
            this.txtPinConfirmar.WaterMark = "Pin";
            this.txtPinConfirmar.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPinConfirmar.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtPinConfirmar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtPinConfirmar_KeyDown);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.metroLabel1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(361, 30);
            this.panel4.TabIndex = 9;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.Location = new System.Drawing.Point(116, 2);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(147, 25);
            this.metroLabel1.TabIndex = 3;
            this.metroLabel1.Text = "Redefinir Senha";
            this.metroLabel1.UseCustomBackColor = true;
            this.metroLabel1.UseCustomForeColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.pnlPai);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(367, 489);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            // 
            // pnlPai
            // 
            this.pnlPai.Controls.Add(this.pnlLogin);
            this.pnlPai.Controls.Add(this.pnlResetarSenha);
            this.pnlPai.Controls.Add(this.pnlCadastrarUsuario);
            this.pnlPai.Controls.Add(this.pnlConfirmar);
            this.pnlPai.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlPai.Location = new System.Drawing.Point(3, 109);
            this.pnlPai.Name = "pnlPai";
            this.pnlPai.Size = new System.Drawing.Size(361, 377);
            this.pnlPai.TabIndex = 1;
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.CancelButton = this.btnSair;
            this.ClientSize = new System.Drawing.Size(367, 489);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FrmLogin_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlLogin.ResumeLayout(false);
            this.pnlLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlCadastrarUsuario.ResumeLayout(false);
            this.pnlCadastrarUsuario.PerformLayout();
            this.pnlConfirmar.ResumeLayout(false);
            this.pnlResetarSenha.ResumeLayout(false);
            this.pnlMudarSenha.ResumeLayout(false);
            this.pnlAvancar.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.pnlPai.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnAcessar;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Panel pnlLogin;
        private System.Windows.Forms.Panel pnlCadastrarUsuario;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Panel pnlConfirmar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAcessarPrivilegios;
        private MetroFramework.Controls.MetroTextBox txtConfirmarSenhaPrincipal;
        private MetroFramework.Controls.MetroTextBox txtSenha;
        private MetroFramework.Controls.MetroTextBox txtUsuario;
        private MetroFramework.Controls.MetroLabel lblCriarNovoUsuario;
        private MetroFramework.Controls.MetroLabel lblNovo;
        private MetroFramework.Controls.MetroTextBox txtNovoUsuario;
        private System.Windows.Forms.Button btnCancelarCadastro;
        private MetroFramework.Controls.MetroTextBox txtRepetirNovoPin;
        private MetroFramework.Controls.MetroTextBox txtNovoPin;
        private MetroFramework.Controls.MetroTextBox txtRepetirNovaSenha;
        private MetroFramework.Controls.MetroTextBox txtNovaSenha;
        private MetroFramework.Controls.MetroLabel metroLabel11;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel pnlResetarSenha;
        private System.Windows.Forms.Panel pnlMudarSenha;
        private System.Windows.Forms.Button btnMudarSenha;
        private System.Windows.Forms.Button btnCancelarMudarSenha;
        private MetroFramework.Controls.MetroTextBox txtRepetirSenhaConfirmacao;
        private MetroFramework.Controls.MetroTextBox txtNovaSenhaConfirmacao;
        private System.Windows.Forms.Button btnAvancar;
        private System.Windows.Forms.Button btnCancelarConfirmacao;
        private MetroFramework.Controls.MetroTextBox txtPinConfirmar;
        private MetroFramework.Controls.MetroTextBox txtUsuarioConfirmacao;
        private System.Windows.Forms.Panel pnlAvancar;
        private System.Windows.Forms.Panel panel4;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox txtNomeCompleto;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel pnlPai;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblMinimize;
    }
}