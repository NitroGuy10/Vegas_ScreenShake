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
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new GUI());
        }
        public void FromVegas(Vegas vegas)
        {
            VegasH.vegas = vegas;
            // TODO previous settings should be stored in a file and read upon opening script

            Main();
        }
    }
}
