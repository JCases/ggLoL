﻿namespace ggLoL
{
    partial class ggLoL
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.slctrHeader = new MaterialSkin.Controls.MaterialTabSelector();
            this.cntrlSignLogin = new MaterialSkin.Controls.MaterialTabControl();
            this.tbLogin = new System.Windows.Forms.TabPage();
            this.pnlLogin = new System.Windows.Forms.Panel();
            this.btnLogin = new MaterialSkin.Controls.MaterialRaisedButton();
            this.chckBxStayConnected = new MaterialSkin.Controls.MaterialCheckBox();
            this.lblLPassword = new MaterialSkin.Controls.MaterialLabel();
            this.txtLPassword = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.lblLUserName = new MaterialSkin.Controls.MaterialLabel();
            this.txtLUserName = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.tbSignIn = new System.Windows.Forms.TabPage();
            this.pnlSingIn = new System.Windows.Forms.Panel();
            this.btnSingIn = new MaterialSkin.Controls.MaterialRaisedButton();
            this.lblSIConfirmPassword = new MaterialSkin.Controls.MaterialLabel();
            this.xtSIConfirmPassword = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.lblSIEmail = new MaterialSkin.Controls.MaterialLabel();
            this.txtSIEmail = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.chckBxTerms = new MaterialSkin.Controls.MaterialCheckBox();
            this.lblSIPassword = new MaterialSkin.Controls.MaterialLabel();
            this.txtSIPassword = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.lblSIUserName = new MaterialSkin.Controls.MaterialLabel();
            this.txtSIUserName = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.tbOffline = new System.Windows.Forms.TabPage();
            this.lblOffline = new MaterialSkin.Controls.MaterialLabel();
            this.btnOffline = new MaterialSkin.Controls.MaterialRaisedButton();
            this.lblTime = new MaterialSkin.Controls.MaterialLabel();
            this.cntrlIndex = new MaterialSkin.Controls.MaterialTabControl();
            this.tbNews = new System.Windows.Forms.TabPage();
            this.txtPatch = new System.Windows.Forms.TextBox();
            this.tbSummoner = new System.Windows.Forms.TabPage();
            this.pnlSearchPlayer = new System.Windows.Forms.Panel();
            this.tbChampions = new System.Windows.Forms.TabPage();
            this.tbTeams = new System.Windows.Forms.TabPage();
            this.tbTournaments = new System.Windows.Forms.TabPage();
            this.tbGameInfo = new System.Windows.Forms.TabPage();
            this.tbOverlay = new System.Windows.Forms.TabPage();
            this.pnlLoading = new System.Windows.Forms.Panel();
            this.lblLoading = new System.Windows.Forms.Label();
            this.progressBar = new MaterialSkin.Controls.MaterialProgressBar();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.animationTime = new System.Windows.Forms.Timer(this.components);
            this.txtChampion = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.btnChampion = new MaterialSkin.Controls.MaterialRaisedButton();
            this.cntrlSignLogin.SuspendLayout();
            this.tbLogin.SuspendLayout();
            this.pnlLogin.SuspendLayout();
            this.tbSignIn.SuspendLayout();
            this.pnlSingIn.SuspendLayout();
            this.tbOffline.SuspendLayout();
            this.cntrlIndex.SuspendLayout();
            this.tbNews.SuspendLayout();
            this.tbSummoner.SuspendLayout();
            this.tbChampions.SuspendLayout();
            this.pnlLoading.SuspendLayout();
            this.SuspendLayout();
            // 
            // slctrHeader
            // 
            this.slctrHeader.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.slctrHeader.BaseTabControl = this.cntrlSignLogin;
            this.slctrHeader.Depth = 0;
            this.slctrHeader.Location = new System.Drawing.Point(0, 61);
            this.slctrHeader.Margin = new System.Windows.Forms.Padding(0);
            this.slctrHeader.MouseState = MaterialSkin.MouseState.HOVER;
            this.slctrHeader.Name = "slctrHeader";
            this.slctrHeader.Size = new System.Drawing.Size(1280, 54);
            this.slctrHeader.TabIndex = 1;
            // 
            // cntrlSignLogin
            // 
            this.cntrlSignLogin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cntrlSignLogin.Controls.Add(this.tbLogin);
            this.cntrlSignLogin.Controls.Add(this.tbSignIn);
            this.cntrlSignLogin.Controls.Add(this.tbOffline);
            this.cntrlSignLogin.Depth = 0;
            this.cntrlSignLogin.Location = new System.Drawing.Point(0, 115);
            this.cntrlSignLogin.Margin = new System.Windows.Forms.Padding(0);
            this.cntrlSignLogin.MouseState = MaterialSkin.MouseState.HOVER;
            this.cntrlSignLogin.Name = "cntrlSignLogin";
            this.cntrlSignLogin.SelectedIndex = 0;
            this.cntrlSignLogin.Size = new System.Drawing.Size(1280, 607);
            this.cntrlSignLogin.TabIndex = 0;
            this.cntrlSignLogin.TabStop = false;
            // 
            // tbLogin
            // 
            this.tbLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tbLogin.Controls.Add(this.pnlLogin);
            this.tbLogin.Location = new System.Drawing.Point(4, 22);
            this.tbLogin.Name = "tbLogin";
            this.tbLogin.Padding = new System.Windows.Forms.Padding(3);
            this.tbLogin.Size = new System.Drawing.Size(1272, 581);
            this.tbLogin.TabIndex = 0;
            this.tbLogin.Text = "Login";
            // 
            // pnlLogin
            // 
            this.pnlLogin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlLogin.Controls.Add(this.btnLogin);
            this.pnlLogin.Controls.Add(this.chckBxStayConnected);
            this.pnlLogin.Controls.Add(this.lblLPassword);
            this.pnlLogin.Controls.Add(this.txtLPassword);
            this.pnlLogin.Controls.Add(this.lblLUserName);
            this.pnlLogin.Controls.Add(this.txtLUserName);
            this.pnlLogin.Location = new System.Drawing.Point(430, 126);
            this.pnlLogin.Name = "pnlLogin";
            this.pnlLogin.Size = new System.Drawing.Size(400, 400);
            this.pnlLogin.TabIndex = 5;
            // 
            // btnLogin
            // 
            this.btnLogin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnLogin.AutoSize = true;
            this.btnLogin.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnLogin.Depth = 0;
            this.btnLogin.Icon = null;
            this.btnLogin.Location = new System.Drawing.Point(257, 254);
            this.btnLogin.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Primary = true;
            this.btnLogin.Size = new System.Drawing.Size(61, 36);
            this.btnLogin.TabIndex = 4;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.ClickUserLogin);
            // 
            // chckBxStayConnected
            // 
            this.chckBxStayConnected.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.chckBxStayConnected.AutoSize = true;
            this.chckBxStayConnected.Depth = 0;
            this.chckBxStayConnected.Font = new System.Drawing.Font("Roboto", 10F);
            this.chckBxStayConnected.Location = new System.Drawing.Point(74, 260);
            this.chckBxStayConnected.Margin = new System.Windows.Forms.Padding(0);
            this.chckBxStayConnected.MouseLocation = new System.Drawing.Point(-1, -1);
            this.chckBxStayConnected.MouseState = MaterialSkin.MouseState.HOVER;
            this.chckBxStayConnected.Name = "chckBxStayConnected";
            this.chckBxStayConnected.Ripple = true;
            this.chckBxStayConnected.Size = new System.Drawing.Size(127, 30);
            this.chckBxStayConnected.TabIndex = 3;
            this.chckBxStayConnected.Text = "Stay Connected";
            this.chckBxStayConnected.UseVisualStyleBackColor = true;
            // 
            // lblLPassword
            // 
            this.lblLPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblLPassword.Depth = 0;
            this.lblLPassword.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblLPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblLPassword.Location = new System.Drawing.Point(146, 144);
            this.lblLPassword.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblLPassword.Name = "lblLPassword";
            this.lblLPassword.Size = new System.Drawing.Size(110, 20);
            this.lblLPassword.TabIndex = 5;
            this.lblLPassword.Text = "Password";
            this.lblLPassword.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtLPassword
            // 
            this.txtLPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtLPassword.Depth = 0;
            this.txtLPassword.Hint = "";
            this.txtLPassword.Location = new System.Drawing.Point(74, 184);
            this.txtLPassword.MaxLength = 100;
            this.txtLPassword.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtLPassword.Name = "txtLPassword";
            this.txtLPassword.PasswordChar = '\0';
            this.txtLPassword.SelectedText = "";
            this.txtLPassword.SelectionLength = 0;
            this.txtLPassword.SelectionStart = 0;
            this.txtLPassword.Size = new System.Drawing.Size(260, 23);
            this.txtLPassword.TabIndex = 2;
            this.txtLPassword.TabStop = false;
            this.txtLPassword.UseSystemPasswordChar = true;
            // 
            // lblLUserName
            // 
            this.lblLUserName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblLUserName.Depth = 0;
            this.lblLUserName.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblLUserName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblLUserName.Location = new System.Drawing.Point(146, 60);
            this.lblLUserName.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblLUserName.Name = "lblLUserName";
            this.lblLUserName.Size = new System.Drawing.Size(110, 20);
            this.lblLUserName.TabIndex = 0;
            this.lblLUserName.Text = "UserName";
            this.lblLUserName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtLUserName
            // 
            this.txtLUserName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtLUserName.Depth = 0;
            this.txtLUserName.Hint = "";
            this.txtLUserName.Location = new System.Drawing.Point(74, 98);
            this.txtLUserName.MaxLength = 100;
            this.txtLUserName.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtLUserName.Name = "txtLUserName";
            this.txtLUserName.PasswordChar = '\0';
            this.txtLUserName.SelectedText = "";
            this.txtLUserName.SelectionLength = 0;
            this.txtLUserName.SelectionStart = 0;
            this.txtLUserName.Size = new System.Drawing.Size(260, 23);
            this.txtLUserName.TabIndex = 1;
            this.txtLUserName.TabStop = false;
            this.txtLUserName.UseSystemPasswordChar = false;
            // 
            // tbSignIn
            // 
            this.tbSignIn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tbSignIn.Controls.Add(this.pnlSingIn);
            this.tbSignIn.Location = new System.Drawing.Point(4, 22);
            this.tbSignIn.Name = "tbSignIn";
            this.tbSignIn.Padding = new System.Windows.Forms.Padding(3);
            this.tbSignIn.Size = new System.Drawing.Size(1272, 581);
            this.tbSignIn.TabIndex = 1;
            this.tbSignIn.Text = "Sign In";
            // 
            // pnlSingIn
            // 
            this.pnlSingIn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlSingIn.Controls.Add(this.btnSingIn);
            this.pnlSingIn.Controls.Add(this.lblSIConfirmPassword);
            this.pnlSingIn.Controls.Add(this.xtSIConfirmPassword);
            this.pnlSingIn.Controls.Add(this.lblSIEmail);
            this.pnlSingIn.Controls.Add(this.txtSIEmail);
            this.pnlSingIn.Controls.Add(this.chckBxTerms);
            this.pnlSingIn.Controls.Add(this.lblSIPassword);
            this.pnlSingIn.Controls.Add(this.txtSIPassword);
            this.pnlSingIn.Controls.Add(this.lblSIUserName);
            this.pnlSingIn.Controls.Add(this.txtSIUserName);
            this.pnlSingIn.Location = new System.Drawing.Point(439, 107);
            this.pnlSingIn.Name = "pnlSingIn";
            this.pnlSingIn.Size = new System.Drawing.Size(400, 400);
            this.pnlSingIn.TabIndex = 4;
            // 
            // btnSingIn
            // 
            this.btnSingIn.AutoSize = true;
            this.btnSingIn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSingIn.Depth = 0;
            this.btnSingIn.Icon = null;
            this.btnSingIn.Location = new System.Drawing.Point(251, 324);
            this.btnSingIn.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSingIn.Name = "btnSingIn";
            this.btnSingIn.Primary = true;
            this.btnSingIn.Size = new System.Drawing.Size(69, 36);
            this.btnSingIn.TabIndex = 6;
            this.btnSingIn.Text = "Sign In";
            this.btnSingIn.Click += new System.EventHandler(this.ClickUserSignIn);
            // 
            // lblSIConfirmPassword
            // 
            this.lblSIConfirmPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblSIConfirmPassword.Depth = 0;
            this.lblSIConfirmPassword.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblSIConfirmPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblSIConfirmPassword.Location = new System.Drawing.Point(114, 244);
            this.lblSIConfirmPassword.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblSIConfirmPassword.Name = "lblSIConfirmPassword";
            this.lblSIConfirmPassword.Size = new System.Drawing.Size(180, 20);
            this.lblSIConfirmPassword.TabIndex = 4;
            this.lblSIConfirmPassword.Text = "Confirm Password";
            this.lblSIConfirmPassword.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // xtSIConfirmPassword
            // 
            this.xtSIConfirmPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.xtSIConfirmPassword.Depth = 0;
            this.xtSIConfirmPassword.Hint = "";
            this.xtSIConfirmPassword.Location = new System.Drawing.Point(74, 280);
            this.xtSIConfirmPassword.MaxLength = 100;
            this.xtSIConfirmPassword.MouseState = MaterialSkin.MouseState.HOVER;
            this.xtSIConfirmPassword.Name = "xtSIConfirmPassword";
            this.xtSIConfirmPassword.PasswordChar = '\0';
            this.xtSIConfirmPassword.SelectedText = "";
            this.xtSIConfirmPassword.SelectionLength = 0;
            this.xtSIConfirmPassword.SelectionStart = 0;
            this.xtSIConfirmPassword.Size = new System.Drawing.Size(260, 23);
            this.xtSIConfirmPassword.TabIndex = 4;
            this.xtSIConfirmPassword.TabStop = false;
            this.xtSIConfirmPassword.UseSystemPasswordChar = true;
            // 
            // lblSIEmail
            // 
            this.lblSIEmail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblSIEmail.Depth = 0;
            this.lblSIEmail.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblSIEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblSIEmail.Location = new System.Drawing.Point(150, 100);
            this.lblSIEmail.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblSIEmail.Name = "lblSIEmail";
            this.lblSIEmail.Size = new System.Drawing.Size(110, 20);
            this.lblSIEmail.TabIndex = 4;
            this.lblSIEmail.Text = "Email";
            this.lblSIEmail.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSIEmail
            // 
            this.txtSIEmail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtSIEmail.Depth = 0;
            this.txtSIEmail.Hint = "";
            this.txtSIEmail.Location = new System.Drawing.Point(74, 136);
            this.txtSIEmail.MaxLength = 100;
            this.txtSIEmail.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtSIEmail.Name = "txtSIEmail";
            this.txtSIEmail.PasswordChar = '\0';
            this.txtSIEmail.SelectedText = "";
            this.txtSIEmail.SelectionLength = 0;
            this.txtSIEmail.SelectionStart = 0;
            this.txtSIEmail.Size = new System.Drawing.Size(260, 23);
            this.txtSIEmail.TabIndex = 2;
            this.txtSIEmail.TabStop = false;
            this.txtSIEmail.UseSystemPasswordChar = false;
            // 
            // chckBxTerms
            // 
            this.chckBxTerms.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.chckBxTerms.AutoSize = true;
            this.chckBxTerms.Depth = 0;
            this.chckBxTerms.Font = new System.Drawing.Font("Roboto", 10F);
            this.chckBxTerms.Location = new System.Drawing.Point(74, 330);
            this.chckBxTerms.Margin = new System.Windows.Forms.Padding(0);
            this.chckBxTerms.MouseLocation = new System.Drawing.Point(-1, -1);
            this.chckBxTerms.MouseState = MaterialSkin.MouseState.HOVER;
            this.chckBxTerms.Name = "chckBxTerms";
            this.chckBxTerms.Ripple = true;
            this.chckBxTerms.Size = new System.Drawing.Size(116, 30);
            this.chckBxTerms.TabIndex = 5;
            this.chckBxTerms.Text = "Accept Terms";
            this.chckBxTerms.UseVisualStyleBackColor = true;
            // 
            // lblSIPassword
            // 
            this.lblSIPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblSIPassword.Depth = 0;
            this.lblSIPassword.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblSIPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblSIPassword.Location = new System.Drawing.Point(150, 174);
            this.lblSIPassword.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblSIPassword.Name = "lblSIPassword";
            this.lblSIPassword.Size = new System.Drawing.Size(110, 20);
            this.lblSIPassword.TabIndex = 5;
            this.lblSIPassword.Text = "Password";
            this.lblSIPassword.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSIPassword
            // 
            this.txtSIPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtSIPassword.Depth = 0;
            this.txtSIPassword.Hint = "";
            this.txtSIPassword.Location = new System.Drawing.Point(74, 206);
            this.txtSIPassword.MaxLength = 100;
            this.txtSIPassword.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtSIPassword.Name = "txtSIPassword";
            this.txtSIPassword.PasswordChar = '\0';
            this.txtSIPassword.SelectedText = "";
            this.txtSIPassword.SelectionLength = 0;
            this.txtSIPassword.SelectionStart = 0;
            this.txtSIPassword.Size = new System.Drawing.Size(260, 23);
            this.txtSIPassword.TabIndex = 3;
            this.txtSIPassword.TabStop = false;
            this.txtSIPassword.UseSystemPasswordChar = true;
            // 
            // lblSIUserName
            // 
            this.lblSIUserName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblSIUserName.Depth = 0;
            this.lblSIUserName.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblSIUserName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblSIUserName.Location = new System.Drawing.Point(150, 22);
            this.lblSIUserName.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblSIUserName.Name = "lblSIUserName";
            this.lblSIUserName.Size = new System.Drawing.Size(110, 20);
            this.lblSIUserName.TabIndex = 0;
            this.lblSIUserName.Text = "UserName";
            this.lblSIUserName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSIUserName
            // 
            this.txtSIUserName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtSIUserName.Depth = 0;
            this.txtSIUserName.Hint = "";
            this.txtSIUserName.Location = new System.Drawing.Point(74, 60);
            this.txtSIUserName.MaxLength = 32767;
            this.txtSIUserName.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtSIUserName.Name = "txtSIUserName";
            this.txtSIUserName.PasswordChar = '\0';
            this.txtSIUserName.SelectedText = "";
            this.txtSIUserName.SelectionLength = 0;
            this.txtSIUserName.SelectionStart = 0;
            this.txtSIUserName.Size = new System.Drawing.Size(260, 23);
            this.txtSIUserName.TabIndex = 1;
            this.txtSIUserName.TabStop = false;
            this.txtSIUserName.UseSystemPasswordChar = false;
            // 
            // tbOffline
            // 
            this.tbOffline.Controls.Add(this.lblOffline);
            this.tbOffline.Controls.Add(this.btnOffline);
            this.tbOffline.Location = new System.Drawing.Point(4, 22);
            this.tbOffline.Name = "tbOffline";
            this.tbOffline.Size = new System.Drawing.Size(1272, 581);
            this.tbOffline.TabIndex = 2;
            this.tbOffline.Text = "Offline Mode";
            this.tbOffline.UseVisualStyleBackColor = true;
            // 
            // lblOffline
            // 
            this.lblOffline.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblOffline.AutoSize = true;
            this.lblOffline.Depth = 0;
            this.lblOffline.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblOffline.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblOffline.Location = new System.Drawing.Point(437, 276);
            this.lblOffline.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblOffline.Name = "lblOffline";
            this.lblOffline.Size = new System.Drawing.Size(454, 19);
            this.lblOffline.TabIndex = 1;
            this.lblOffline.Text = "You need a previous download and save data for use Offline Mode.";
            // 
            // btnOffline
            // 
            this.btnOffline.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnOffline.AutoSize = true;
            this.btnOffline.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnOffline.Depth = 0;
            this.btnOffline.Icon = null;
            this.btnOffline.Location = new System.Drawing.Point(620, 179);
            this.btnOffline.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnOffline.Name = "btnOffline";
            this.btnOffline.Primary = true;
            this.btnOffline.Size = new System.Drawing.Size(63, 36);
            this.btnOffline.TabIndex = 0;
            this.btnOffline.Text = "Enter";
            this.btnOffline.UseVisualStyleBackColor = true;
            this.btnOffline.Click += new System.EventHandler(this.ClickOfflineMode);
            // 
            // lblTime
            // 
            this.lblTime.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.lblTime.Depth = 0;
            this.lblTime.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblTime.Location = new System.Drawing.Point(1162, 34);
            this.lblTime.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(76, 20);
            this.lblTime.TabIndex = 3;
            this.lblTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cntrlIndex
            // 
            this.cntrlIndex.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cntrlIndex.Controls.Add(this.tbNews);
            this.cntrlIndex.Controls.Add(this.tbSummoner);
            this.cntrlIndex.Controls.Add(this.tbChampions);
            this.cntrlIndex.Controls.Add(this.tbTeams);
            this.cntrlIndex.Controls.Add(this.tbTournaments);
            this.cntrlIndex.Controls.Add(this.tbGameInfo);
            this.cntrlIndex.Controls.Add(this.tbOverlay);
            this.cntrlIndex.Depth = 0;
            this.cntrlIndex.Location = new System.Drawing.Point(0, 115);
            this.cntrlIndex.Margin = new System.Windows.Forms.Padding(0);
            this.cntrlIndex.MouseState = MaterialSkin.MouseState.HOVER;
            this.cntrlIndex.Name = "cntrlIndex";
            this.cntrlIndex.SelectedIndex = 0;
            this.cntrlIndex.Size = new System.Drawing.Size(1280, 607);
            this.cntrlIndex.TabIndex = 0;
            this.cntrlIndex.TabStop = false;
            this.cntrlIndex.Visible = false;
            // 
            // tbNews
            // 
            this.tbNews.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tbNews.Controls.Add(this.txtPatch);
            this.tbNews.Location = new System.Drawing.Point(4, 22);
            this.tbNews.Name = "tbNews";
            this.tbNews.Size = new System.Drawing.Size(1272, 581);
            this.tbNews.TabIndex = 2;
            this.tbNews.Text = "News";
            // 
            // txtPatch
            // 
            this.txtPatch.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPatch.Location = new System.Drawing.Point(3, 3);
            this.txtPatch.Multiline = true;
            this.txtPatch.Name = "txtPatch";
            this.txtPatch.ReadOnly = true;
            this.txtPatch.Size = new System.Drawing.Size(1266, 575);
            this.txtPatch.TabIndex = 0;
            // 
            // tbSummoner
            // 
            this.tbSummoner.AutoScroll = true;
            this.tbSummoner.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tbSummoner.Controls.Add(this.pnlSearchPlayer);
            this.tbSummoner.Location = new System.Drawing.Point(4, 22);
            this.tbSummoner.Name = "tbSummoner";
            this.tbSummoner.Padding = new System.Windows.Forms.Padding(3);
            this.tbSummoner.Size = new System.Drawing.Size(1272, 581);
            this.tbSummoner.TabIndex = 0;
            this.tbSummoner.Text = "Summoners Profile";
            // 
            // pnlSearchPlayer
            // 
            this.pnlSearchPlayer.Location = new System.Drawing.Point(0, 0);
            this.pnlSearchPlayer.Name = "pnlSearchPlayer";
            this.pnlSearchPlayer.Size = new System.Drawing.Size(1272, 581);
            this.pnlSearchPlayer.TabIndex = 0;
            // 
            // tbChampions
            // 
            this.tbChampions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tbChampions.Controls.Add(this.btnChampion);
            this.tbChampions.Controls.Add(this.txtChampion);
            this.tbChampions.Location = new System.Drawing.Point(4, 22);
            this.tbChampions.Name = "tbChampions";
            this.tbChampions.Padding = new System.Windows.Forms.Padding(3);
            this.tbChampions.Size = new System.Drawing.Size(1272, 581);
            this.tbChampions.TabIndex = 1;
            this.tbChampions.Text = "Champions";
            // 
            // tbTeams
            // 
            this.tbTeams.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tbTeams.Location = new System.Drawing.Point(4, 22);
            this.tbTeams.Name = "tbTeams";
            this.tbTeams.Size = new System.Drawing.Size(1272, 581);
            this.tbTeams.TabIndex = 3;
            this.tbTeams.Text = "Teams";
            // 
            // tbTournaments
            // 
            this.tbTournaments.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tbTournaments.Location = new System.Drawing.Point(4, 22);
            this.tbTournaments.Name = "tbTournaments";
            this.tbTournaments.Size = new System.Drawing.Size(1272, 581);
            this.tbTournaments.TabIndex = 4;
            this.tbTournaments.Text = "Tournaments";
            // 
            // tbGameInfo
            // 
            this.tbGameInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tbGameInfo.Location = new System.Drawing.Point(4, 22);
            this.tbGameInfo.Name = "tbGameInfo";
            this.tbGameInfo.Size = new System.Drawing.Size(1272, 581);
            this.tbGameInfo.TabIndex = 5;
            this.tbGameInfo.Text = "Game Information";
            // 
            // tbOverlay
            // 
            this.tbOverlay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tbOverlay.Location = new System.Drawing.Point(4, 22);
            this.tbOverlay.Name = "tbOverlay";
            this.tbOverlay.Size = new System.Drawing.Size(1272, 581);
            this.tbOverlay.TabIndex = 6;
            this.tbOverlay.Text = "Overlay";
            // 
            // pnlLoading
            // 
            this.pnlLoading.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlLoading.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.pnlLoading.Controls.Add(this.lblLoading);
            this.pnlLoading.Controls.Add(this.progressBar);
            this.pnlLoading.Location = new System.Drawing.Point(0, 61);
            this.pnlLoading.Name = "pnlLoading";
            this.pnlLoading.Size = new System.Drawing.Size(1280, 54);
            this.pnlLoading.TabIndex = 0;
            this.pnlLoading.Visible = false;
            // 
            // lblLoading
            // 
            this.lblLoading.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblLoading.AutoSize = true;
            this.lblLoading.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.lblLoading.ForeColor = System.Drawing.SystemColors.Control;
            this.lblLoading.Location = new System.Drawing.Point(114, 17);
            this.lblLoading.Name = "lblLoading";
            this.lblLoading.Size = new System.Drawing.Size(80, 20);
            this.lblLoading.TabIndex = 2;
            this.lblLoading.Text = "Loading...";
            this.lblLoading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // progressBar
            // 
            this.progressBar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.progressBar.BackColor = System.Drawing.Color.White;
            this.progressBar.Depth = 0;
            this.progressBar.Location = new System.Drawing.Point(540, 26);
            this.progressBar.MarqueeAnimationSpeed = 10;
            this.progressBar.MouseState = MaterialSkin.MouseState.HOVER;
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(680, 5);
            this.progressBar.Step = 2;
            this.progressBar.TabIndex = 0;
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.Time);
            // 
            // animationTime
            // 
            this.animationTime.Interval = 60;
            this.animationTime.Tick += new System.EventHandler(this.AnimationTimer);
            // 
            // txtChampion
            // 
            this.txtChampion.Depth = 0;
            this.txtChampion.Hint = "";
            this.txtChampion.Location = new System.Drawing.Point(359, 224);
            this.txtChampion.MaxLength = 32767;
            this.txtChampion.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtChampion.Name = "txtChampion";
            this.txtChampion.PasswordChar = '\0';
            this.txtChampion.SelectedText = "";
            this.txtChampion.SelectionLength = 0;
            this.txtChampion.SelectionStart = 0;
            this.txtChampion.Size = new System.Drawing.Size(237, 23);
            this.txtChampion.TabIndex = 0;
            this.txtChampion.TabStop = false;
            this.txtChampion.UseSystemPasswordChar = false;
            // 
            // btnChampion
            // 
            this.btnChampion.AutoSize = true;
            this.btnChampion.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnChampion.Depth = 0;
            this.btnChampion.Icon = null;
            this.btnChampion.Location = new System.Drawing.Point(442, 270);
            this.btnChampion.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnChampion.Name = "btnChampion";
            this.btnChampion.Primary = true;
            this.btnChampion.Size = new System.Drawing.Size(73, 36);
            this.btnChampion.TabIndex = 1;
            this.btnChampion.Text = "Search";
            this.btnChampion.UseVisualStyleBackColor = true;
            // 
            // ggLoL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.pnlLoading);
            this.Controls.Add(this.cntrlIndex);
            this.Controls.Add(this.cntrlSignLogin);
            this.Controls.Add(this.slctrHeader);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.Name = "ggLoL";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ggLoL";
            this.Load += new System.EventHandler(this.LoadApp);
            this.cntrlSignLogin.ResumeLayout(false);
            this.tbLogin.ResumeLayout(false);
            this.pnlLogin.ResumeLayout(false);
            this.pnlLogin.PerformLayout();
            this.tbSignIn.ResumeLayout(false);
            this.pnlSingIn.ResumeLayout(false);
            this.pnlSingIn.PerformLayout();
            this.tbOffline.ResumeLayout(false);
            this.tbOffline.PerformLayout();
            this.cntrlIndex.ResumeLayout(false);
            this.tbNews.ResumeLayout(false);
            this.tbNews.PerformLayout();
            this.tbSummoner.ResumeLayout(false);
            this.tbChampions.ResumeLayout(false);
            this.tbChampions.PerformLayout();
            this.pnlLoading.ResumeLayout(false);
            this.pnlLoading.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private MaterialSkin.Controls.MaterialTabSelector slctrHeader;
        private MaterialSkin.Controls.MaterialTabControl cntrlSignLogin;
        private System.Windows.Forms.TabPage tbLogin;
        private System.Windows.Forms.TabPage tbSignIn;
        private MaterialSkin.Controls.MaterialLabel lblSIUserName;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtSIUserName;
        private MaterialSkin.Controls.MaterialLabel lblTime;
        private System.Windows.Forms.Panel pnlSingIn;
        private MaterialSkin.Controls.MaterialCheckBox chckBxTerms;
        private MaterialSkin.Controls.MaterialLabel lblSIPassword;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtSIPassword;
        private System.Windows.Forms.Panel pnlLogin;
        private MaterialSkin.Controls.MaterialCheckBox chckBxStayConnected;
        private MaterialSkin.Controls.MaterialLabel lblLPassword;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtLPassword;
        private MaterialSkin.Controls.MaterialLabel lblLUserName;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtLUserName;
        private MaterialSkin.Controls.MaterialLabel lblSIConfirmPassword;
        private MaterialSkin.Controls.MaterialSingleLineTextField xtSIConfirmPassword;
        private MaterialSkin.Controls.MaterialLabel lblSIEmail;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtSIEmail;
        private MaterialSkin.Controls.MaterialRaisedButton btnSingIn;
        private MaterialSkin.Controls.MaterialTabControl cntrlIndex;
        private System.Windows.Forms.TabPage tbSummoner;
        private System.Windows.Forms.TabPage tbChampions;
        private System.Windows.Forms.Panel pnlLoading;
        private MaterialSkin.Controls.MaterialProgressBar progressBar;
        private System.Windows.Forms.Label lblLoading;
        private System.Windows.Forms.TabPage tbNews;
        private System.Windows.Forms.TabPage tbTeams;
        private System.Windows.Forms.TabPage tbTournaments;
        private System.Windows.Forms.TabPage tbGameInfo;
        private System.Windows.Forms.TabPage tbOverlay;
        private MaterialSkin.Controls.MaterialRaisedButton btnLogin;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Timer animationTime;
        private System.Windows.Forms.TabPage tbOffline;
        private MaterialSkin.Controls.MaterialRaisedButton btnOffline;
        private MaterialSkin.Controls.MaterialLabel lblOffline;
        private System.Windows.Forms.Panel pnlSearchPlayer;
        private System.Windows.Forms.TextBox txtPatch;
        private MaterialSkin.Controls.MaterialRaisedButton btnChampion;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtChampion;
    }
}

