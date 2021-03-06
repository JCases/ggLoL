﻿using System;
using System.Globalization;
using System.Threading;
using MaterialSkin;
using MaterialSkin.Controls;
using MaterialSkin.Animations;

namespace ggLoL
{
    public partial class LoadData : MaterialForm
    {
        public LoadData(string language)
        {
            Thread.CurrentThread.CurrentUICulture = new CultureInfo(language);
            InitializeComponent();
        }

        ~LoadData() { }

        private void Loading()
        {
            // Reset Progress Bar
            progressBarData.Value = 0;
            animationTimerData.Enabled = true;
        }

        private void AnimationTimer(object sender, EventArgs e)
        {
            progressBarData.PerformStep();

            // End Animation
            if (progressBarData.Value >= 100)
            {
                animationTimerData.Enabled = false;
                Close();
            }
        }

        private void Show(object sender, EventArgs e) { Loading(); }
    }
}
