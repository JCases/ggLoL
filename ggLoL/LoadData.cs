using System;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
using MaterialSkin.Animations;

namespace ggLoL
{
    public partial class LoadData : MaterialForm
    {
        public LoadData()
        {
            InitializeComponent();

            Loading();
        }

        ~LoadData() { }

        private void Loading()
        {
            // Reset Progress Bar
            progressBarData.Value = 0;

            progressBarData.RightToLeft = RightToLeft.Yes;
            progressBarData.RightToLeftLayout = true;

            pnlLoading.Visible = true;
            animationTimerData.Enabled = true;
        }

        private void AnimationTimer(object sender, EventArgs e)
        {
            if (pnlLoading.Visible)
                progressBarData.PerformStep();

            // End Animation
            if (pnlLoading.Visible && progressBarData.Value >= 100)
            {
                pnlLoading.Visible = false;
                animationTimerData.Enabled = false;
            }
        }
    }
}
