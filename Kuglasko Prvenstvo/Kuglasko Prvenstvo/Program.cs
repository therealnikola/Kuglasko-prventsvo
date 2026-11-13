using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KuglaskoPrvenstvo
{

    internal static class Program
    {
        public static string konekcioniString { get; private set; }
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            konekcioniString = "Server=EVGA\\SQLEXPRESS; Database=KuglaskoPrvenstvo; Integrated Security=True;";
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Pocetna());
        }
    }
}
