﻿using System;
using System.Windows.Forms;

namespace CautareNivelCareu
{
    static class MainProgram
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainWindow());
        }
    }
}
