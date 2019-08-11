using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NCOMS
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
            Application.Run(new Form_Loading());
            Application.Run(new Form_Login());
           // Application.Run(new Form_ManagerMainWindow());
           // Application.Run(new Form_SupervisorMainWindow());
        }
    }
}
