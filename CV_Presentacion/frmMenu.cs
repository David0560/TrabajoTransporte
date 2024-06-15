using CV_Presentacion.Forms;
using System;
using System.Windows.Forms;

namespace CV_Presentacion
{
    public partial class frmMenu : Form
    {

        private Form activeForm;
        public frmMenu()
        {
            InitializeComponent();
        }

        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
            {
                
                activeForm.Close();
                
            }
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelMenu.Controls.Add(childForm);
            this.panelMenu.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lblTitulo.Text = childForm.Text;

        }
        private void btnUsuario_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frm_Usuario(), sender);
        }

        private void btnInformes_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frm_informes(), sender);
        }

        private void btnEmpleados_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frm_Empleados(), sender);
        }

        private void btnVehiculo_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frm_Vehiculos(), sender);
        }

        private void btnRegistro_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frm_Registros(), sender);
        }

        private void btnAlmacen_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frm_Almacen(), sender);
        }

        private void btnConfiguracion_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frm_Configuracion(), sender);
        }
    }
}


