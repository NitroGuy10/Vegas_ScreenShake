using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScreenShake
{
    public class SettingControl
    {
        public static Dictionary<string, SettingControl> SettingControls = new Dictionary<string, SettingControl>();

        public TrackBar slider;
        public TextBox textBox;
        public double sliderScalar;
        public string name;
        public double defaultValue;
        private double value;

        public SettingControl(TrackBar slider, TextBox textBox, double sliderScalar, double defaultValue, string name)
        {
            this.slider = slider;
            this.textBox = textBox;
            this.sliderScalar = sliderScalar;
            this.defaultValue = defaultValue;
            this.name = name;
            Value = defaultValue;
            
            SettingControls[name] = this;
        }

        public void UpdateFromSlider ()
        {
            Value = slider.Value * sliderScalar;
        }

        public void UpdateFromTextBox()
        {
            try
            {
                Value = Double.Parse(textBox.Text);
            }
            catch (Exception)
            {
                Value = Value;
            }
        }

        public double Value
        {
            get
            {
                return value;
            }

            set
            {
                this.value = value;
                textBox.Text = value.ToString();
                slider.Value = Math.Min(Math.Max((int) Math.Round(value / sliderScalar), slider.Minimum), slider.Maximum);
            }
        }
    }
}
