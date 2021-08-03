﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScreenShake
{
    public partial class GUI : Form
    {
        public GUI()
        {
            InitializeComponent();

            new SettingControl(shakeSpeedSlider, shakeSpeedTextBox, 0.1, 8, "Shake Speed");
            new SettingControl(shakeIntensitySlider, shakeIntensityTextBox, 0.01, 0.05, "Shake Intensity");
        }

        private void applyBtn_Click(object sender, EventArgs e)
        {
            // Add shake keyframes to Picture In Picture based on settings
            ScreenShake.Apply();
            Close();
        }

        private void defaultSettingsBtn_Click(object sender, EventArgs e)
        {
            foreach (SettingControl setting in SettingControl.SettingControls.Values)
            {
                setting.Value = setting.defaultValue;
            }
        }

        private void shakeSpeedSlider_Scroll(object sender, EventArgs e)
        {
            if (SettingControl.SettingControls.ContainsKey("Shake Speed"))
            {
                SettingControl.SettingControls["Shake Speed"].UpdateFromSlider();
            }
        }

        private void shakeSpeedTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SettingControl.SettingControls["Shake Speed"].UpdateFromTextBox();
                e.Handled = true;
            }
        }

        private void shakeIntensitySlider_Scroll(object sender, EventArgs e)
        {
            if (SettingControl.SettingControls.ContainsKey("Shake Intensity"))
            {
                SettingControl.SettingControls["Shake Intensity"].UpdateFromSlider();
            }
        }

        private void shakeIntensityTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SettingControl.SettingControls["Shake Intensity"].UpdateFromTextBox();
                e.Handled = true;
            }
        }
    }
}
