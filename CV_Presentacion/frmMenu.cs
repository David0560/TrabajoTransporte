using CV_Presentacion.Forms;
using System;
using System.Windows.Forms;
using CapaSesion;
using System.Runtime.InteropServices.ComTypes;
using CV_Presentacion.Frm_Usuario;

namespace CV_Presentacion
{
    public partial class FrmMenu : Form
    {

        private Form activeForm;
        public FrmMenu()
        {
            InitializeComponent();
        }
        private void FrmMenu_Load(object sender, EventArgs e)
        {
            CargarDatosUsuario();
        }
        private void CargarDatosUsuario()
        {
            lblNombreUsuario.Text = $"{UsuarioLoginCache.Nombre}, {UsuarioLoginCache.Apellido}";
            lblTipoUsuario.Text = UsuarioLoginCache.Familia;

        }

        private void btnSalirUsuario_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Estas por Cerrar la sesion, ¿Estas seguro?", "Atencion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                this.Close();
        }
        //llamados a formularios a menu
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
            this.panelMenu.Controls.Add(childForm);
            this.panelMenu.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lblTitulo.Text = childForm.Text;

        }
        private void btnUsuario_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frm_AltaUsuario(), sender);
        }
        private void btnInformes_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frm_informes(), sender);
        }
        private void btnEmpleados_Click_1(object sender, EventArgs e)
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
        private void btnMenu_Click(object sender, EventArgs e)
        {
            activeForm.Close();
        }

        private void tmrFecha_Tick(object sender, EventArgs e)
        {
            lblFecha.Text = DateTime.Now.ToShortDateString();// coloco la hora actual de la pc en el label
            lblHora.Text = DateTime.Now.ToLongTimeString();
        }
    }
}


