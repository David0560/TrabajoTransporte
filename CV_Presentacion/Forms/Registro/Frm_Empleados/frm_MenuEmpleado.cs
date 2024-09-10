using CapaSesion;
using CV_Presentacion.Frm_Empleados;
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
            this.pnlFormulario02.Controls.Add(childForm);
            this.pnlFormulario02.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();

        }

        private void frm_MenuEmpleados_Load(object sender, EventArgs e)
        {
            OpenChildForm(new frm_AltaEmpleados(), sender);
        }

        private void btnAltaËmpleado_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frm_AltaEmpleados(), sender);
        }

        private void btnModificarEmpleado_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frm_ModificarEmpleados(), sender);
        }

        private void btnBuscarEmpleado_Click(object sender, EventArgs e)
        {

        }
    }
}
