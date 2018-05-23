namespace ggLoL
{
    partial class LoadData
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
            this.lblWaitingData = new MaterialSkin.Controls.MaterialLabel();
            this.progressBarData = new MaterialSkin.Controls.MaterialProgressBar();
            this.animationTimerData = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // lblWaitingData
            // 
            this.lblWaitingData.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblWaitingData.BackColor = System.Drawing.Color.Transparent;
            this.lblWaitingData.Depth = 0;
            this.lblWaitingData.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblWaitingData.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblWaitingData.Location = new System.Drawing.Point(92, 150);
            this.lblWaitingData.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblWaitingData.Name = "lblWaitingData";
            this.lblWaitingData.Size = new System.Drawing.Size(210, 88);
            this.lblWaitingData.TabIndex = 0;
            this.lblWaitingData.Text = "Wait a Second...";
            this.lblWaitingData.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // progressBarData
            // 
            this.progressBarData.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.progressBarData.Depth = 0;
            this.progressBarData.Location = new System.Drawing.Point(24, 272);
            this.progressBarData.MarqueeAnimationSpeed = 1;
            this.progressBarData.MouseState = MaterialSkin.MouseState.HOVER;
            this.progressBarData.Name = "progressBarData";
            this.progressBarData.Size = new System.Drawing.Size(350, 5);
            this.progressBarData.TabIndex = 1;
            // 
            // animationTimerData
            // 
            this.animationTimerData.Enabled = true;
            this.animationTimerData.Interval = 200;
            this.animationTimerData.Tick += new System.EventHandler(this.AnimationTimer);
            // 
            // LoadData
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(400, 400);
            this.ControlBox = false;
            this.Controls.Add(this.progressBarData);
            this.Controls.Add(this.lblWaitingData);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LoadData";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoadData";
            this.Shown += new System.EventHandler(this.Show);
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel lblWaitingData;
        private MaterialSkin.Controls.MaterialProgressBar progressBarData;
        private System.Windows.Forms.Timer animationTimerData;
    }
}