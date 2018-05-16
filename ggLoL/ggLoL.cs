using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
using MaterialSkin.Animations;

namespace ggLoL
{
    public partial class ggLoL : MaterialForm
    {
        private MaterialSkinManager msm;

        public ggLoL()
        {
            InitializeComponent();

            msm = MaterialSkinManager.Instance;
            msm.AddFormToManage(this);
            msm.Theme = MaterialSkinManager.Themes.LIGHT;

            msm.ColorScheme = new ColorScheme(
                Primary.BlueGrey800, Primary.BlueGrey900,
                Primary.BlueGrey900, Accent.LightBlue700,
                TextShade.WHITE);

            timer.Start();
        }

        ~ggLoL() { }

        // Timers
        private void Time(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToLongTimeString();
            lblTime.BackColor = Color.FromArgb(55, 71, 79);
            lblTime.ForeColor = Color.FromArgb(255, 255, 255);
        }

        private void ClickUserSignIn(object sender, EventArgs e)
        {
            ShowIndexScreen();
        }

        private void ClickUserLogin(object sender, EventArgs e)
        {
            ShowIndexScreen();
        }

        private void ShowIndexScreen()
        {
            // Show Options Sign Off & Profile
            //signOffOption.Visible = profileOption.Visible = true;

            cntrlSignLogin.Visible = false;
            slctrHeader.Visible = false;
            slctrHeader.BaseTabControl = cntrlIndex;

            // Clear Text Sign In & Login
            txtLUserName.Text = txtLPassword.Text = "";
            txtSIUserName.Text = txtSIPassword.Text = txtSIEmail.Text = "";
            chckBxStayConnected.Checked = chckBxTerms.Checked = false;

            Loading();
        }

        // Start Animation
        private void Loading()
        {
            // Reset Progress Bar
            progressBar.Value = 0;

            progressBar.RightToLeft = RightToLeft.Yes;
            progressBar.RightToLeftLayout = true;

            pnlLoading.Visible = true;
            animationTime.Enabled = true;
        }

        private void AnimationTimer(object sender, EventArgs e)
        {
            if (pnlLoading.Visible)
                progressBar.PerformStep();

            // End Animation
            if (pnlLoading.Visible && progressBar.Value >= 100)
            {
                pnlLoading.Visible = false;
                animationTime.Enabled = false;

                slctrHeader.Visible = true;

                if (slctrHeader.BaseTabControl == cntrlIndex) // Show Index
                    cntrlIndex.Visible = true;
                else // Show Sign In & Login
                    cntrlSignLogin.Visible = true;
            }
        }
    }
}
