using System;
using System.Drawing;
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

        // Open Menu
        private void clickMenu(object sender, EventArgs e)
        {
            mOption.Show(Cursor.Position);
        }

        // Themes for Application
        private void lightTheme(object sender, EventArgs e)
        {

            msm.Theme = MaterialSkinManager.Themes.LIGHT;
            lightOptionTheme.CheckState = CheckState.Checked;
            darkOptionTheme.CheckState = CheckState.Unchecked;
        }
        private void darkTheme(object sender, EventArgs e)
        {
            msm.Theme = MaterialSkinManager.Themes.DARK;
            darkOptionTheme.CheckState = CheckState.Checked;
            lightOptionTheme.CheckState = CheckState.Unchecked;
        }

        // Options Profile or Sign Off
        private void ClickProfile(object sender, EventArgs e)
        {
            Profile profile = new Profile();
            profile.ShowDialog();
        }
        private void ClickSignOff(object sender, EventArgs e)
        {
            // NOT Show Option Sign Off & Profile
            signOffOption.Visible = profileOption.Visible = false;

            cntrlIndex.Visible = false;
            slctrHeader.Visible = false;
            slctrHeader.BaseTabControl = cntrlSignLogin;

            Loading();
        }

        // Timers
        private void Time(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToString("HH:mm:ss");
            lblTime.BackColor = Color.FromArgb(55, 71, 79);
            lblTime.ForeColor = Color.FromArgb(255, 255, 255);
        }

        private void LoadApp(object sender, EventArgs e)
        {
            Time(sender, e);
            ggLoLMain.setRegion("EUW");
        }

        private void ClickUserSignIn(object sender, EventArgs e)
        {
            ShowIndexScreen();
        }

        private void ClickUserLogin(object sender, EventArgs e)
        {
            ShowIndexScreen();
        }

        private void ClickOfflineMode(object sender, EventArgs e)
        {
            ShowIndexScreen();
        }

        private void ShowIndexScreen()
        {
            // Show Options Sign Off & Profile
            signOffOption.Visible = profileOption.Visible = true;

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

        private void ClickSearchPlayer(object sender, EventArgs e)
        {
            SummonerProfile s;
            if (txtSearchPlayer.Text.Length > 0)
            {
                if (ggLoLMain.SearchPlayer(txtSearchPlayer.Text, out s))
                    ShowSummonerProfile(s);
            }
            else
                MessageBox.Show("Enter a Summoner Name.");
        }

        private void ShowSummonerProfile(SummonerProfile s)
        {
            pnlSearchPlayer.Visible = false;
            pnlResultSummonerProfile.Visible = true;
            lblNameSummonerR.Text = s.name;
            // TERMINAR PERFIL PERSONAL
        }

        private void ClickSearchOtherPlayer(object sender, EventArgs e)
        {
            txtSearchPlayer.Text = "";
            pnlSearchPlayer.Visible = true;
            pnlResultSummonerProfile.Visible = false;
        }
    }
}
