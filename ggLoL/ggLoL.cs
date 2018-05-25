using System;
using System.Drawing;
using System.IO;
using System.Net;
using System.ComponentModel;
using System.Deployment.Application;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
using MaterialSkin.Animations;


namespace ggLoL
{
    public partial class ggLoL : MaterialForm
    {
        public static MaterialSkinManager msm { get; set; }

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
            Profile profile = new Profile(msm);
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

        // Login, Sign In and Mode Offline
        private bool offline;
        private void ClickUserSignIn(object sender, EventArgs e)
        {
            offline = false;

            User user = new User("Javier", "hola", "arriba españa", "rojos", false);
            user.Save();
            
            ShowIndexScreen();
        }

        private void ClickUserLogin(object sender, EventArgs e)
        {
            offline = false;

            ShowIndexScreen();
        }

        private void ClickOfflineMode(object sender, EventArgs e)
        {
            offline = true;

            ShowIndexScreen();

            profileOption.Visible = false;
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

        // Download File (Events and Animations)

        WebClient web;
        string path;

        private void ClickDownloadDataOffline(object sender, EventArgs e)
        {
            // Reset Progress Bar
            progressBarDownload.Value = 0;

            progressBarDownload.RightToLeft = RightToLeft.Yes;
            progressBarDownload.RightToLeftLayout = true;

            DownloadFile();
        }

        private void DownloadFile()
        {
            string url;

            if (ggLoLMain.GetLinkFileData(out url))
            {
                // Show Panel and Disable Button Download
                pnlDownload.Visible = true;
                btnDownloadData.Visible = false;

                Uri uri = new Uri(url);

                string desktopPath =
                    Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

                string filename = Path.GetFileName(uri.LocalPath);

                web = new WebClient();

                path = desktopPath + "/" + filename;

                web.DownloadProgressChanged +=
                    new DownloadProgressChangedEventHandler(DownloadFileChanged);
                web.DownloadFileCompleted +=
                    new AsyncCompletedEventHandler(DownloadFileCompleted);
                web.DownloadFileAsync(uri, desktopPath + "/" + filename);
            }
        }

        private void DownloadFileChanged(object sender, 
            System.Net.DownloadProgressChangedEventArgs e)
        {
            progressBarDownload.Value = e.ProgressPercentage;
            lblValueDownload.Text = e.ProgressPercentage.ToString() + "%";
        }

        private void DownloadFileCompleted(object sender, AsyncCompletedEventArgs e)
        {
            pnlDownload.Visible = false;
            btnDownloadData.Visible = true;
            if (e.Cancelled)
            {
                MessageBox.Show("The download has been cancelled");
                File.Delete(path);
                return;
            }

            if (e.Error != null)
            {
                MessageBox.Show("An error ocurred while trying to download file");
                return;
            }

            MessageBox.Show("File succesfully downloaded");
        }

        private void ClickCancelDownload(object sender, EventArgs e)
        {
            web.CancelAsync();
        }


        // Events with Data

        private bool VerifyString(string text) { return text.Length > 0; }

            // Summoners Players
        private void ClickSearchPlayer(object sender, EventArgs e)
        {
            SummonerProfile s;
            if (VerifyString(txtSearchPlayer.Text))
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
            lblIDSummonerR.Text = s.id.ToString();
            lblIDAccountSummonerR.Text = s.accountId.ToString();
            lblLevelSummonerR.Text = s.summonerLevel.ToString();
            lblRevisionSummonerR.Text = s.revisionDate.ToString();
        }

        private void ClickSearchOtherPlayer(object sender, EventArgs e)
        {
            txtSearchPlayer.Text = "";
            pnlSearchPlayer.Visible = true;
            pnlResultSummonerProfile.Visible = false;
        }
            
            // Champions
        private void ClickSearchChampion(object sender, EventArgs e)
        {
            Champions c;
            if (VerifyString(txtSearchChampion.Text))
            {
                if (ggLoLMain.SearchChampion(out c))
                    ShowChampion(c, txtSearchChampion.Text);
            }
            else
                MessageBox.Show("Enter a Champion Name.");
        }

        private void ShowChampion(Champions c, string text)
        {
            try
            {
                lblChampionIDR.Text = c.data[text].id.ToString();
                lblChampionNameR.Text = c.data[text].name;

                pnlSearchChampion.Visible = false;
                pnlResultChampion.Visible = true;
            }
            catch (Exception) { MessageBox.Show("Error"); }
            
        }

        private void ClickSearchOtherChampion(object sender, EventArgs e)
        {
            txtSearchChampion.Text = "";
            pnlSearchChampion.Visible = true;
            pnlResultChampion.Visible = false;
        }
    }
}
