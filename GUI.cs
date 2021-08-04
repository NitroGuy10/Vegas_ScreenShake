using System;
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

            new SettingControl(rotationSpeedSlider, rotationSpeedTextBox, 0.01, .15, "Rotation Speed");
            new SettingControl(rotationIntensitySlider, rotationIntensityTextBox, 0.001, .01, "Rotation Intensity");
            new SettingControl(shakeSpeedSlider, shakeSpeedTextBox, 0.1, 8, "Shake Speed");
            new SettingControl(shakeIntensitySlider, shakeIntensityTextBox, 0.01, 0.05, "Shake Intensity");
        }

        public string Seed
        {
            get
            {
                return seedBox.Text;
            }
        }

        public bool shakeX
        {
            get
            {
                return xCheckBox.Checked;
            }
        }

        public bool shakeY
        {
            get
            {
                return yCheckBox.Checked;
            }
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
            seedBox.Text = "0";
            xCheckBox.Checked = true;
            yCheckBox.Checked = true;
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

        private void rotationSpeedSlider_Scroll(object sender, EventArgs e)
        {
            if (SettingControl.SettingControls.ContainsKey("Rotation Speed"))
            {
                SettingControl.SettingControls["Rotation Speed"].UpdateFromSlider();
            }
        }

        private void rotationSpeedTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SettingControl.SettingControls["Rotation Speed"].UpdateFromTextBox();
                e.Handled = true;
            }
        }

        private void rotationIntensitySlider_Scroll(object sender, EventArgs e)
        {
            if (SettingControl.SettingControls.ContainsKey("Rotation Intensity"))
            {
                SettingControl.SettingControls["Rotation Intensity"].UpdateFromSlider();
            }
        }

        private void rotationIntensityTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SettingControl.SettingControls["Rotation Intensity"].UpdateFromTextBox();
                e.Handled = true;
            }
        }
    }
}
