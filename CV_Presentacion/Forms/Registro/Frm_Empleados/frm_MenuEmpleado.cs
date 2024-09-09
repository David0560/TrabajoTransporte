using CapaSesion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CV_Presentacion.Forms.Registro.Frm_Empleados
{
    public partial class frm_MenuEmpleados : Form
    {

        private Form activeForm;

        public frm_MenuEmpleados()
        {
            InitializeComponent();
        }
        private void OpenChildForm(Form childForm, object sender)
        {
            if (activeForm != null)
            {

                activeForm.Close();

            }
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.pnlBoton.Controls.Add(childForm);
            this.pnlBoton.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();

        }

        
    }
}
