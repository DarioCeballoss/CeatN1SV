using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Presentacion
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
<<<<<<< HEAD
            Application.Run(new LogIn());
=======
            Application.Run(new MenuPrincipal());
>>>>>>> 2dc7637cdf5e89a554be6951e31a7b41478a15d6
        }
    }
}
