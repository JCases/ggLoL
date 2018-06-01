using System;
using System.Globalization;
using System.Threading;
using MaterialSkin;
using MaterialSkin.Controls;
using MaterialSkin.Animations;

namespace ggLoL
{
    public partial class Profile : MaterialForm
    {
        private MaterialSkinManager msm { get; set; }
        User user;

        public Profile(string language, MaterialSkinManager msm, User user)
        {
            Thread.CurrentThread.CurrentUICulture = new CultureInfo(language);

            InitializeComponent();

            this.msm = msm;

            this.user = user;

            ShowInfo(user);
        }
        ~Profile() { }

        // Profile Info

        private void ShowInfo(User currentUser)
        {
            lblProfileNameR.Text = currentUser.name;
            lblProfileEmailR.Text = currentUser.password;
            lblProfileNickR.Text = currentUser.nick;

            chckBxGreen.BackColor = msm.ColorScheme.PrimaryColor;
            chckBxGray.BackColor = msm.ColorScheme.PrimaryColor;
            chckBxBlue.BackColor = msm.ColorScheme.PrimaryColor;
            chckBxRed.BackColor = msm.ColorScheme.PrimaryColor;
            btnReLoadKeyVerify.BackColor = msm.ColorScheme.PrimaryColor;
        }

        // Colours for Application

        // PA QUE NACHO ESTE CONTENTO - BORRAR 
        private void uncheckchckBx()
        {
            for (int i = 0; i < 4; i++)
            {
                if (i == 0)
                    chckBxGreen.Checked = false;
                else if (i == 1)
                    chckBxGray.Checked = false;
                else if (i == 2)
                    chckBxBlue.Checked = false;
                else if (i == 3)
                    chckBxRed.Checked = false;
            }   
        }

        /*private void uncheckchckBx()
        {
            chckBxGreen.Checked = chckBxGray.Checked =
                chckBxBlue.Checked = chckBxRed.Checked = false;
        }*/

        private void colourGreen(object sender, EventArgs e)
        {
            uncheckchckBx();

            msm.ColorScheme = new ColorScheme(
                Primary.Green800, Primary.Green900,
                Primary.Green900, Accent.LightGreen700,
                TextShade.WHITE);

            chckBxGreen.Checked = true;

            Refresh();
        }

        private void colourBlue(object sender, EventArgs e)
        {
            uncheckchckBx();

            msm.ColorScheme = new ColorScheme(
                Primary.Blue800, Primary.Blue900,
                Primary.Blue900, Accent.LightBlue700,
                TextShade.WHITE);

            chckBxBlue.Checked = true;

            Refresh();
        }

        private void colourGray(object sender, EventArgs e)
        {
            uncheckchckBx();

            msm.ColorScheme = new ColorScheme(
                Primary.BlueGrey800, Primary.BlueGrey900,
                Primary.BlueGrey900, Accent.LightBlue700,
                TextShade.WHITE);

            chckBxGray.Checked = true;

            Refresh();
        }

        private void colourRed(object sender, EventArgs e)
        {
            uncheckchckBx();

            msm.ColorScheme = new ColorScheme(
                Primary.Red800, Primary.Red900,
                Primary.Red900, Accent.Orange700,
                TextShade.WHITE);

            chckBxRed.Checked = true;

            Refresh();
        }

        // ReLoad Key

        private void ClickReLoadKey(object sender, EventArgs e)
        {
            lblProfileVerifyCodeR.Text = VerifyProfile.CreateKey();
        }
    }
}
