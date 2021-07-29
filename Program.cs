using System;
using System.Windows.Forms;

using ScriptPortal.Vegas;

namespace ScreenShake_Forms
{
    public class EntryPoint
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
        public void FromVegas(Vegas vegas)
        {
            Main();
        }
    }
}
