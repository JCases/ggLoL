namespace ggLoL
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
            this.slctrHeader = new MaterialSkin.Controls.MaterialTabSelector();
            this.cntrlSignLogin = new MaterialSkin.Controls.MaterialTabControl();
            this.tbLogin = new System.Windows.Forms.TabPage();
            this.pnlLogin = new System.Windows.Forms.Panel();
            this.chckBxStayConnected = new MaterialSkin.Controls.MaterialCheckBox();
            this.lblLPassword = new MaterialSkin.Controls.MaterialLabel();
            this.txtLPassword = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.lblLUserName = new MaterialSkin.Controls.MaterialLabel();
            this.txtLUserName = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.btnLogin = new MaterialSkin.Controls.MaterialFlatButton();
            this.tbSignIn = new System.Windows.Forms.TabPage();
            this.pnlSingIn = new System.Windows.Forms.Panel();
            this.btnSingIn = new MaterialSkin.Controls.MaterialRaisedButton();
            this.lblSIConfirmPassword = new MaterialSkin.Controls.MaterialLabel();
            this.materialSingleLineTextField2 = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.lblSIEmail = new MaterialSkin.Controls.MaterialLabel();
            this.txtSIEmail = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.chckBxTerms = new MaterialSkin.Controls.MaterialCheckBox();
            this.lblSIPassword = new MaterialSkin.Controls.MaterialLabel();
            this.txtSIPassword = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.lblSIUserName = new MaterialSkin.Controls.MaterialLabel();
            this.txtSIUserName = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.lblTime = new MaterialSkin.Controls.MaterialLabel();
            this.cntrlIndex = new MaterialSkin.Controls.MaterialTabControl();
            this.tbNews = new System.Windows.Forms.TabPage();
            this.tbSummoner = new System.Windows.Forms.TabPage();
            this.tbChampions = new System.Windows.Forms.TabPage();
            this.tbTeams = new System.Windows.Forms.TabPage();
            this.tbTournaments = new System.Windows.Forms.TabPage();
            this.tbGameInfo = new System.Windows.Forms.TabPage();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.pnlLoading = new System.Windows.Forms.Panel();
            this.lblLoading = new System.Windows.Forms.Label();
            this.progressBar = new MaterialSkin.Controls.MaterialProgressBar();
            this.cntrlSignLogin.SuspendLayout();
            this.tbLogin.SuspendLayout();
            this.pnlLogin.SuspendLayout();
            this.tbSignIn.SuspendLayout();
            this.pnlSingIn.SuspendLayout();
            this.cntrlIndex.SuspendLayout();
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
            this.cntrlSignLogin.Depth = 0;
            this.cntrlSignLogin.Location = new System.Drawing.Point(0, 115);
            this.cntrlSignLogin.Margin = new System.Windows.Forms.Padding(0);
            this.cntrlSignLogin.MouseState = MaterialSkin.MouseState.HOVER;
            this.cntrlSignLogin.Name = "cntrlSignLogin";
            this.cntrlSignLogin.SelectedIndex = 0;
            this.cntrlSignLogin.Size = new System.Drawing.Size(1280, 607);
            this.cntrlSignLogin.TabIndex = 2;
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
            this.pnlLogin.Controls.Add(this.chckBxStayConnected);
            this.pnlLogin.Controls.Add(this.lblLPassword);
            this.pnlLogin.Controls.Add(this.txtLPassword);
            this.pnlLogin.Controls.Add(this.lblLUserName);
            this.pnlLogin.Controls.Add(this.txtLUserName);
            this.pnlLogin.Controls.Add(this.btnLogin);
            this.pnlLogin.Location = new System.Drawing.Point(430, 126);
            this.pnlLogin.Name = "pnlLogin";
            this.pnlLogin.Size = new System.Drawing.Size(400, 400);
            this.pnlLogin.TabIndex = 5;
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
            this.chckBxStayConnected.TabIndex = 6;
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
            this.txtLPassword.TabIndex = 4;
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
            this.txtLUserName.TabIndex = 3;
            this.txtLUserName.TabStop = false;
            this.txtLUserName.UseSystemPasswordChar = false;
            // 
            // btnLogin
            // 
            this.btnLogin.AutoSize = true;
            this.btnLogin.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnLogin.Depth = 0;
            this.btnLogin.Icon = null;
            this.btnLogin.Location = new System.Drawing.Point(0, 0);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnLogin.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Primary = false;
            this.btnLogin.Size = new System.Drawing.Size(16, 36);
            this.btnLogin.TabIndex = 7;
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
            this.pnlSingIn.Controls.Add(this.materialSingleLineTextField2);
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
            this.btnSingIn.Location = new System.Drawing.Point(0, 0);
            this.btnSingIn.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSingIn.Name = "btnSingIn";
            this.btnSingIn.Primary = true;
            this.btnSingIn.Size = new System.Drawing.Size(16, 36);
            this.btnSingIn.TabIndex = 0;
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
            // materialSingleLineTextField2
            // 
            this.materialSingleLineTextField2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.materialSingleLineTextField2.Depth = 0;
            this.materialSingleLineTextField2.Hint = "";
            this.materialSingleLineTextField2.Location = new System.Drawing.Point(74, 280);
            this.materialSingleLineTextField2.MaxLength = 100;
            this.materialSingleLineTextField2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialSingleLineTextField2.Name = "materialSingleLineTextField2";
            this.materialSingleLineTextField2.PasswordChar = '\0';
            this.materialSingleLineTextField2.SelectedText = "";
            this.materialSingleLineTextField2.SelectionLength = 0;
            this.materialSingleLineTextField2.SelectionStart = 0;
            this.materialSingleLineTextField2.Size = new System.Drawing.Size(260, 23);
            this.materialSingleLineTextField2.TabIndex = 5;
            this.materialSingleLineTextField2.TabStop = false;
            this.materialSingleLineTextField2.UseSystemPasswordChar = true;
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
            this.txtSIEmail.TabIndex = 5;
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
            this.chckBxTerms.TabIndex = 6;
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
            this.txtSIPassword.TabIndex = 4;
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
            this.txtSIUserName.TabIndex = 3;
            this.txtSIUserName.TabStop = false;
            this.txtSIUserName.UseSystemPasswordChar = false;
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
            this.cntrlIndex.Controls.Add(this.tabPage1);
            this.cntrlIndex.Depth = 0;
            this.cntrlIndex.Location = new System.Drawing.Point(0, 115);
            this.cntrlIndex.Margin = new System.Windows.Forms.Padding(0);
            this.cntrlIndex.MouseState = MaterialSkin.MouseState.HOVER;
            this.cntrlIndex.Name = "cntrlIndex";
            this.cntrlIndex.SelectedIndex = 0;
            this.cntrlIndex.Size = new System.Drawing.Size(1280, 607);
            this.cntrlIndex.TabIndex = 4;
            this.cntrlIndex.Visible = false;
            // 
            // tbNews
            // 
            this.tbNews.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tbNews.Location = new System.Drawing.Point(4, 22);
            this.tbNews.Name = "tbNews";
            this.tbNews.Size = new System.Drawing.Size(1272, 581);
            this.tbNews.TabIndex = 2;
            this.tbNews.Text = "News";
            // 
            // tbSummoner
            // 
            this.tbSummoner.AutoScroll = true;
            this.tbSummoner.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tbSummoner.Location = new System.Drawing.Point(4, 22);
            this.tbSummoner.Name = "tbSummoner";
            this.tbSummoner.Padding = new System.Windows.Forms.Padding(3);
            this.tbSummoner.Size = new System.Drawing.Size(1272, 581);
            this.tbSummoner.TabIndex = 0;
            this.tbSummoner.Text = "Summoners Profile";
            // 
            // tbChampions
            // 
            this.tbChampions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
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
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(1272, 581);
            this.tabPage1.TabIndex = 6;
            this.tabPage1.Text = "Overlay";
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
            // ggLoL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.pnlLoading);
            this.Controls.Add(this.cntrlIndex);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.cntrlSignLogin);
            this.Controls.Add(this.slctrHeader);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.Name = "ggLoL";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ggLoL";
            this.cntrlSignLogin.ResumeLayout(false);
            this.tbLogin.ResumeLayout(false);
            this.pnlLogin.ResumeLayout(false);
            this.pnlLogin.PerformLayout();
            this.tbSignIn.ResumeLayout(false);
            this.pnlSingIn.ResumeLayout(false);
            this.pnlSingIn.PerformLayout();
            this.cntrlIndex.ResumeLayout(false);
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
        private MaterialSkin.Controls.MaterialFlatButton btnLogin;
        private MaterialSkin.Controls.MaterialLabel lblSIConfirmPassword;
        private MaterialSkin.Controls.MaterialSingleLineTextField materialSingleLineTextField2;
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
        private System.Windows.Forms.TabPage tabPage1;
    }
}

