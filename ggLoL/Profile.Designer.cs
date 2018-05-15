namespace ggLoL
{
    public partial class Profile
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
            this.tbCntrlProfile = new MaterialSkin.Controls.MaterialTabControl();
            this.tbProfile = new System.Windows.Forms.TabPage();
            this.tbPswrd = new System.Windows.Forms.TabPage();
            this.pnlPassword = new System.Windows.Forms.Panel();
            this.btnPassword = new MaterialSkin.Controls.MaterialRaisedButton();
            this.lblCNewPassword = new MaterialSkin.Controls.MaterialLabel();
            this.lblNewPassword = new MaterialSkin.Controls.MaterialLabel();
            this.lblLastPassword = new MaterialSkin.Controls.MaterialLabel();
            this.txtCNewPassword = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtNewPassword = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtLastPassword = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.tbColor = new System.Windows.Forms.TabPage();
            this.tbSlctrProfile = new MaterialSkin.Controls.MaterialTabSelector();
            this.tbCntrlProfile.SuspendLayout();
            this.tbPswrd.SuspendLayout();
            this.pnlPassword.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbCntrlProfile
            // 
            this.tbCntrlProfile.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbCntrlProfile.Controls.Add(this.tbProfile);
            this.tbCntrlProfile.Controls.Add(this.tbPswrd);
            this.tbCntrlProfile.Controls.Add(this.tbColor);
            this.tbCntrlProfile.Depth = 0;
            this.tbCntrlProfile.Location = new System.Drawing.Point(0, 100);
            this.tbCntrlProfile.Margin = new System.Windows.Forms.Padding(0);
            this.tbCntrlProfile.MouseState = MaterialSkin.MouseState.HOVER;
            this.tbCntrlProfile.Name = "tbCntrlProfile";
            this.tbCntrlProfile.SelectedIndex = 0;
            this.tbCntrlProfile.Size = new System.Drawing.Size(798, 350);
            this.tbCntrlProfile.TabIndex = 0;
            // 
            // tbProfile
            // 
            this.tbProfile.BackColor = System.Drawing.SystemColors.Control;
            this.tbProfile.Location = new System.Drawing.Point(4, 22);
            this.tbProfile.Name = "tbProfile";
            this.tbProfile.Padding = new System.Windows.Forms.Padding(3);
            this.tbProfile.Size = new System.Drawing.Size(790, 324);
            this.tbProfile.TabIndex = 0;
            this.tbProfile.Text = "Profile";
            // 
            // tbPswrd
            // 
            this.tbPswrd.BackColor = System.Drawing.SystemColors.Control;
            this.tbPswrd.Controls.Add(this.pnlPassword);
            this.tbPswrd.Location = new System.Drawing.Point(4, 22);
            this.tbPswrd.Name = "tbPswrd";
            this.tbPswrd.Padding = new System.Windows.Forms.Padding(3);
            this.tbPswrd.Size = new System.Drawing.Size(790, 324);
            this.tbPswrd.TabIndex = 1;
            this.tbPswrd.Text = "Password";
            // 
            // pnlPassword
            // 
            this.pnlPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlPassword.Controls.Add(this.btnPassword);
            this.pnlPassword.Controls.Add(this.lblCNewPassword);
            this.pnlPassword.Controls.Add(this.lblNewPassword);
            this.pnlPassword.Controls.Add(this.lblLastPassword);
            this.pnlPassword.Controls.Add(this.txtCNewPassword);
            this.pnlPassword.Controls.Add(this.txtNewPassword);
            this.pnlPassword.Controls.Add(this.txtLastPassword);
            this.pnlPassword.Location = new System.Drawing.Point(210, 6);
            this.pnlPassword.Name = "pnlPassword";
            this.pnlPassword.Size = new System.Drawing.Size(350, 312);
            this.pnlPassword.TabIndex = 0;
            // 
            // btnPassword
            // 
            this.btnPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnPassword.AutoSize = true;
            this.btnPassword.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnPassword.Depth = 0;
            this.btnPassword.Icon = null;
            this.btnPassword.Location = new System.Drawing.Point(98, 242);
            this.btnPassword.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnPassword.Name = "btnPassword";
            this.btnPassword.Primary = true;
            this.btnPassword.Size = new System.Drawing.Size(153, 36);
            this.btnPassword.TabIndex = 7;
            this.btnPassword.Text = "Change Password";
            this.btnPassword.UseVisualStyleBackColor = true;
            // 
            // lblCNewPassword
            // 
            this.lblCNewPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCNewPassword.AutoSize = true;
            this.lblCNewPassword.Depth = 0;
            this.lblCNewPassword.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblCNewPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblCNewPassword.Location = new System.Drawing.Point(21, 192);
            this.lblCNewPassword.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblCNewPassword.Name = "lblCNewPassword";
            this.lblCNewPassword.Size = new System.Drawing.Size(167, 19);
            this.lblCNewPassword.TabIndex = 6;
            this.lblCNewPassword.Text = "Confirm New Password";
            // 
            // lblNewPassword
            // 
            this.lblNewPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblNewPassword.AutoSize = true;
            this.lblNewPassword.Depth = 0;
            this.lblNewPassword.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblNewPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblNewPassword.Location = new System.Drawing.Point(21, 135);
            this.lblNewPassword.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblNewPassword.Name = "lblNewPassword";
            this.lblNewPassword.Size = new System.Drawing.Size(109, 19);
            this.lblNewPassword.TabIndex = 5;
            this.lblNewPassword.Text = "New Password";
            // 
            // lblLastPassword
            // 
            this.lblLastPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblLastPassword.AutoSize = true;
            this.lblLastPassword.Depth = 0;
            this.lblLastPassword.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblLastPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblLastPassword.Location = new System.Drawing.Point(20, 80);
            this.lblLastPassword.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblLastPassword.Name = "lblLastPassword";
            this.lblLastPassword.Size = new System.Drawing.Size(108, 19);
            this.lblLastPassword.TabIndex = 4;
            this.lblLastPassword.Text = "Last Password";
            // 
            // txtCNewPassword
            // 
            this.txtCNewPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCNewPassword.Depth = 0;
            this.txtCNewPassword.Hint = "";
            this.txtCNewPassword.Location = new System.Drawing.Point(194, 188);
            this.txtCNewPassword.MaxLength = 32767;
            this.txtCNewPassword.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtCNewPassword.Name = "txtCNewPassword";
            this.txtCNewPassword.PasswordChar = '\0';
            this.txtCNewPassword.SelectedText = "";
            this.txtCNewPassword.SelectionLength = 0;
            this.txtCNewPassword.SelectionStart = 0;
            this.txtCNewPassword.Size = new System.Drawing.Size(126, 23);
            this.txtCNewPassword.TabIndex = 3;
            this.txtCNewPassword.TabStop = false;
            this.txtCNewPassword.UseSystemPasswordChar = true;
            // 
            // txtNewPassword
            // 
            this.txtNewPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtNewPassword.Depth = 0;
            this.txtNewPassword.Hint = "";
            this.txtNewPassword.Location = new System.Drawing.Point(194, 131);
            this.txtNewPassword.MaxLength = 32767;
            this.txtNewPassword.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtNewPassword.Name = "txtNewPassword";
            this.txtNewPassword.PasswordChar = '\0';
            this.txtNewPassword.SelectedText = "";
            this.txtNewPassword.SelectionLength = 0;
            this.txtNewPassword.SelectionStart = 0;
            this.txtNewPassword.Size = new System.Drawing.Size(126, 23);
            this.txtNewPassword.TabIndex = 3;
            this.txtNewPassword.TabStop = false;
            this.txtNewPassword.UseSystemPasswordChar = true;
            // 
            // txtLastPassword
            // 
            this.txtLastPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtLastPassword.Depth = 0;
            this.txtLastPassword.Hint = "";
            this.txtLastPassword.Location = new System.Drawing.Point(194, 76);
            this.txtLastPassword.MaxLength = 32767;
            this.txtLastPassword.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtLastPassword.Name = "txtLastPassword";
            this.txtLastPassword.PasswordChar = '\0';
            this.txtLastPassword.SelectedText = "";
            this.txtLastPassword.SelectionLength = 0;
            this.txtLastPassword.SelectionStart = 0;
            this.txtLastPassword.Size = new System.Drawing.Size(126, 23);
            this.txtLastPassword.TabIndex = 2;
            this.txtLastPassword.TabStop = false;
            this.txtLastPassword.UseSystemPasswordChar = true;
            // 
            // tbColor
            // 
            this.tbColor.BackColor = System.Drawing.SystemColors.Control;
            this.tbColor.Location = new System.Drawing.Point(4, 22);
            this.tbColor.Name = "tbColor";
            this.tbColor.Size = new System.Drawing.Size(790, 324);
            this.tbColor.TabIndex = 2;
            this.tbColor.Text = "Color";
            // 
            // tbSlctrProfile
            // 
            this.tbSlctrProfile.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbSlctrProfile.BaseTabControl = this.tbCntrlProfile;
            this.tbSlctrProfile.Depth = 0;
            this.tbSlctrProfile.Location = new System.Drawing.Point(0, 64);
            this.tbSlctrProfile.Margin = new System.Windows.Forms.Padding(0);
            this.tbSlctrProfile.MouseState = MaterialSkin.MouseState.HOVER;
            this.tbSlctrProfile.Name = "tbSlctrProfile";
            this.tbSlctrProfile.Size = new System.Drawing.Size(800, 36);
            this.tbSlctrProfile.TabIndex = 1;
            // 
            // Profile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbSlctrProfile);
            this.Controls.Add(this.tbCntrlProfile);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Profile";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Profile";
            this.tbCntrlProfile.ResumeLayout(false);
            this.tbPswrd.ResumeLayout(false);
            this.pnlPassword.ResumeLayout(false);
            this.pnlPassword.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabControl tbCntrlProfile;
        private System.Windows.Forms.TabPage tbProfile;
        private System.Windows.Forms.TabPage tbPswrd;
        private MaterialSkin.Controls.MaterialTabSelector tbSlctrProfile;
        private System.Windows.Forms.TabPage tbColor;
        private System.Windows.Forms.Panel pnlPassword;
        private MaterialSkin.Controls.MaterialRaisedButton btnPassword;
        private MaterialSkin.Controls.MaterialLabel lblCNewPassword;
        private MaterialSkin.Controls.MaterialLabel lblNewPassword;
        private MaterialSkin.Controls.MaterialLabel lblLastPassword;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtCNewPassword;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtNewPassword;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtLastPassword;
    }
}