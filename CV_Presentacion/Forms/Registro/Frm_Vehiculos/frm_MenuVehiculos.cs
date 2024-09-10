using CV_Presentacion.Frm_Unidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CV_Presentacion.Forms.Registro.Frm_Vehiculos
{
    public partial class frm_MenuVehiculos : Form
    {
        public frm_MenuVehiculos()
        {
            InitializeComponent();
        }
        private Form activeForm;
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
            this.pnlFormulario2.Controls.Add(childForm);
            this.pnlFormulario2.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();

        }
        private void frm_MenuVehiculos_Load(object sender, EventArgs e)
        {
            OpenChildForm(new frm_AltaVehiculos(), sender);
        }

        private void btnAltaVehiculo_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frm_AltaVehiculos(), sender);
        }

        private void btnModificarVehiculo_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frm_ModificarVehiculos(), sender);
        }

        private void btnBuscarVehiculo_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frm_BuscarVehiculos(), sender);
        }
    }
}
