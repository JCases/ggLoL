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
        }
    }
}
