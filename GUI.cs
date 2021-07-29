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
            // Clear all animations from the Picture In Picture

            // Add shake keyframes to Picture In Picture based on settings
            ScreenShake.Apply();
        }
    }
}
