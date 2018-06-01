using System;
using System.Drawing;
using System.IO;
using System.Net;
using System.ComponentModel;
using System.Globalization;
using System.Threading;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
using MaterialSkin.Animations;


namespace ggLoL
{
    public partial class ggLoL : MaterialForm
    {
        public static MaterialSkinManager msm { get; set; }
        public static string language = Properties.Settings.Default.Langue;

        public ggLoL()
        {
            Thread.CurrentThread.CurrentUICulture = new CultureInfo(language);
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

        public ggLoL(MaterialSkinManager.Themes theme, Primary colorP, 
            Primary darkP, Primary lightP, Accent accent, TextShade shade)
        {
            InitializeComponent();

            msm = MaterialSkinManager.Instance;
            msm.AddFormToManage(this);
            msm.Theme = theme;

            msm.ColorScheme = new ColorScheme(
                colorP, darkP, lightP, accent, shade);

            timer.Start();
        }

        ~ggLoL() { }
        
        // Prefixed Data
        private void LoadApp(object sender, EventArgs e)
        {
            Time(sender, e);
            ggLoLMain.setRegion("EUW");
            CurrentRegion("EUW");

            if (language == "en-EN")
                englishOption.Checked = true;
            else if (language == "es-ES")
                spanishOption.Checked = true;

            // Delete Tab Pages don't use in project
            cntrlIndex.TabPages.RemoveByKey("tbTeams");
            cntrlIndex.TabPages.RemoveByKey("tbTournaments");
            cntrlIndex.TabPages.RemoveByKey("tbOverlay");
        }

        // Timers
        private void Time(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToString("HH:mm:ss");
            //lblTime.BackColor = Color.FromArgb(55, 71, 79);
            lblTime.ForeColor = Color.FromArgb(255, 255, 255);
        }

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

        // Language App

        private void ClickEnglishLanguage(object sender, EventArgs e)
        {
            spanishOption.Checked = false;
            englishOption.Checked = true;
            Properties.Settings.Default.Langue = "en-EN";
            Properties.Settings.Default.Save();
            MessageBox.Show("Restart Aplication");
            Application.Restart();
        }

        private void ClickSpanishLanguage(object sender, EventArgs e)
        {
            englishOption.Checked = false;
            spanishOption.Checked = true;
            Properties.Settings.Default.Langue = "es-ES";
            Properties.Settings.Default.Save();
            MessageBox.Show("Reiniciando Aplicación");
            Application.Restart();
        }

        // Select Region
        private void SetRegion(object sender, EventArgs e)
        {
            // Reset Check State
            foreach (ToolStripMenuItem i in regionOption.DropDownItems)
                if (sender.Equals(i))
                    i.CheckState = CheckState.Checked;
                else
                    i.CheckState = CheckState.Unchecked;

            ggLoLMain.setRegion(sender.ToString());

            CurrentRegion(sender.ToString());
        }

        private void CurrentRegion(string region)
        {
            lblRegionSP.Text = region;
            lblRegionC.Text = region;
            lblRegionGI.Text = region;
        }

        private void ClickChangeRegion(object sender, EventArgs e)
        {
            Point point = new Point(Cursor.Position.X - 120, Cursor.Position.Y);
            mOption.Show(point);
            mOption.Visible = false;
            regionOption.ShowDropDown();
        }

        // Options Profile or Sign Off
        private User currentUser;
        private void ClickProfile(object sender, EventArgs e)
        {
            Profile profile = new Profile(language, msm, currentUser);
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

        // Login, Sign In and Mode Offline
        private void ClickUserSignIn(object sender, EventArgs e)
        {
            currentUser = new User(txtSIUserName.Text, txtSIPassword.Text, 
                txtSIEmail.Text, "", false);
            currentUser.Save();
            
            ggLoLMain.online = true;

            ShowIndexScreen();
        }

        private void ClickUserLogin(object sender, EventArgs e)
        {
            currentUser = new User(txtLUserName.Text, txtLPassword.Text);
            
            ggLoLMain.online = true;

            ShowIndexScreen();
        }

        private void ClickOfflineMode(object sender, EventArgs e)
        {
            profileOption.Visible = false;
            signOffOption.Visible = true;

            ggLoLMain.online = false;

            ShowIndexScreen();
        }

        private void ShowIndexScreen()
        {
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
            pnlLoading.BackColor = msm.ColorScheme.PrimaryColor;
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

                // Show Options Sign Off & Profile
                if (ggLoLMain.online)
                    signOffOption.Visible = profileOption.Visible 
                        = regionOption.Visible = true;
            }
        }

        // Download File (Events and Animations)

        WebClient web;
        string path;

        private void ClickDownloadDataOffline(object sender, EventArgs e)
        {
            pnlDownload.BackColor = msm.ColorScheme.PrimaryColor;
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
            ChampionMastery cm;
            if (VerifyString(txtSearchPlayer.Text))
            {
                if (ggLoLMain.SearchPlayer(txtSearchPlayer.Text, out s))
                {
                    cm = s.GetMaestry();
                    if (ggLoLMain.online)
                        s.Save();
                    ShowSummonerProfile(s);
                    ShowChampionMastery(cm);
                }
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

        private void ShowChampionMastery(ChampionMastery cm)
        {

        }

        private void ClickSearchOtherPlayer(object sender, EventArgs e)
        {
            txtSearchPlayer.Text = "";

            pnlSearchPlayer.Visible = true;
            pnlResultSummonerProfile.Visible = false;
            
            lblIDAccountSummonerR.Text = "";
            lblIDSummonerR.Text = "";
            lblLevelSummonerR.Text = "";
            lblRevisionSummonerR.Text = "";
        }
            
            // Champions
        private void ClickSearchChampion(object sender, EventArgs e)
        {
            Champions c;
            if (VerifyString(txtSearchChampion.Text))
            {
                if (ggLoLMain.SearchChampion(out c))
                {
                    ShowChampion(c, txtSearchChampion.Text);
                    if (ggLoLMain.online)
                        c.Save();
                }  
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

            lblChampionIDR.Text = "";
            lblChampionNameR.Text = "";
        }

        private void ClickSearchGameInfo(object sender, EventArgs e)
        {
            Items i;
            if (VerifyString(txtSearchChampion.Text))
            {
                if (ggLoLMain.SearchGameInfo(out i))
                {
                    ShowItems(i, txtSearchChampion.Text);
                    if (ggLoLMain.online)
                        i.Save();
                }
            }
            else
                MessageBox.Show("Enter a Game Info.");
        }

        private void ShowItems(Items i, string text)
        {
        }
    }
}
