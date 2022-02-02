using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

/*  Author:         Allesandra Sams-Jones
 *  Date:           2/2/2022
 *  Description:    Assignment 5.1
 */

namespace Exponents
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
