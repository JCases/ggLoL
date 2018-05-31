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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoadData));
            this.lblWaitingData = new MaterialSkin.Controls.MaterialLabel();
            this.progressBarData = new MaterialSkin.Controls.MaterialProgressBar();
            this.animationTimerData = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // lblWaitingData
            // 
            resources.ApplyResources(this.lblWaitingData, "lblWaitingData");
            this.lblWaitingData.BackColor = System.Drawing.Color.Transparent;
            this.lblWaitingData.Depth = 0;
            this.lblWaitingData.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblWaitingData.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblWaitingData.Name = "lblWaitingData";
            // 
            // progressBarData
            // 
            resources.ApplyResources(this.progressBarData, "progressBarData");
            this.progressBarData.Depth = 0;
            this.progressBarData.MarqueeAnimationSpeed = 1;
            this.progressBarData.MouseState = MaterialSkin.MouseState.HOVER;
            this.progressBarData.Name = "progressBarData";
            // 
            // animationTimerData
            // 
            this.animationTimerData.Enabled = true;
            this.animationTimerData.Interval = 200;
            this.animationTimerData.Tick += new System.EventHandler(this.AnimationTimer);
            // 
            // LoadData
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ControlBox = false;
            this.Controls.Add(this.progressBarData);
            this.Controls.Add(this.lblWaitingData);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LoadData";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Sizable = false;
            this.Shown += new System.EventHandler(this.Show);
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel lblWaitingData;
        private MaterialSkin.Controls.MaterialProgressBar progressBarData;
        private System.Windows.Forms.Timer animationTimerData;
    }
}