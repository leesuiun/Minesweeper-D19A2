using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Minesweeper
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// //Download source code tai Sharecode.vn
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmMinesweeper());
        }
    }
}