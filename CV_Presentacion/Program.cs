using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CV_Presentacion
{
    internal static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>

        public static frmLogin login;
        public static FrmMenu frmMenu;
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(frmMenu = new FrmMenu());
            //Application.Run(new frm_Empleado());
            Application.Run(new frmLogin());
        }
    }
}
