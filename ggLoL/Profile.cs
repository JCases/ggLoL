using System;
using MaterialSkin;
using MaterialSkin.Controls;
using MaterialSkin.Animations;

namespace ggLoL
{
    public partial class Profile : MaterialForm
    {
        private MaterialSkinManager msm { get; set; }

        public Profile(MaterialSkinManager msm, User currentUser)
        {
            InitializeComponent();

            this.msm = msm;

            ShowInfo(currentUser);
        }
        ~Profile() { }

        // Profile Info

        private void ShowInfo(User currentUser)
        {
            lblProfileNameR.Text = currentUser.name;
            lblProfileEmailR.Text = currentUser.password;
            lblProfileNickR.Text = currentUser.nick;
        }

        // Colours for Application

        private void uncheckchckBx()
        {
            chckBxGreen.Checked = chckBxGray.Checked =
                chckBxBlue.Checked = chckBxRed.Checked = false;
        }

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
    }
}
