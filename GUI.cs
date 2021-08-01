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
        }

        private void applyBtn_Click(object sender, EventArgs e)
        {
            // Add shake keyframes to Picture In Picture based on settings
            if (VegasH.appliedAnimation)
            {
                MessageBox.Show("You cannot apply the animation more than once. Instead, close the script and run it again.");
            }
            else
            {
                VegasH.appliedAnimation = true;
                ScreenShake.Apply();
            }
        }
    }
}
