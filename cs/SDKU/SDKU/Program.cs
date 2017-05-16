using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SDKU
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
            //Sdku sdk = new Sdku();
            Application.Run(new Form1());
            //Sdku sdk = new Sdku();
            //MessageBox.Show(sdk.num[1,2].ToString());
        }
    }
}
