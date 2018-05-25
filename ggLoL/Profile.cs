using System;
using MaterialSkin;
using MaterialSkin.Controls;
using MaterialSkin.Animations;

namespace ggLoL
{
    public partial class Profile : MaterialForm
    {
        private MaterialSkinManager msm { get; set; }

        public Profile(MaterialSkinManager msm)
        {
            InitializeComponent();

            this.msm = msm;
        }
        ~Profile() { }

        // Themes for Application
        private void lightTheme(object sender, EventArgs e)
        {
            //msm.Theme = MaterialSkinManager.Themes.LIGHT;
        }
        private void darkTheme(object sender, EventArgs e)
        {
            //msm.Theme = MaterialSkinManager.Themes.DARK;
        }
    }
}
