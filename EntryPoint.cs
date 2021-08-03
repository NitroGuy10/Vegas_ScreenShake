using System;
using System.Collections.Generic;
using System.Windows.Forms;
using ScriptPortal.Vegas;

namespace ScreenShake
{
    public class EntryPoint
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            // Application.SetCompatibleTextRenderingDefault(false);
            // Application.Run(new GUI());
            if (VegasH.gui == null)
            {
                VegasH.gui = new GUI();
            }
            VegasH.gui.ShowDialog();
        }
        public void FromVegas(Vegas vegas)
        {
            if (VegasH.vegas == null)
            {
                VegasH.vegas = vegas;
            }
            Main();
        }
    }
}
