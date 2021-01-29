using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace LauncherTemplate
{
    static class Program
    {
        /// <summary>
        /// OPEN.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainWindow());
        }
    }
}
