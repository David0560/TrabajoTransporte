using System;
using System.Windows.Forms;

namespace CV_Presentacion
{
    internal static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            CV_Presentacion.frmLogin frm = new CV_Presentacion.frmLogin();
            frm.ShowDialog();

            if (frm.DialogResult == DialogResult.OK)
            {
                Application.Run(new frmMenu());
            }
                
        }
    }
}
