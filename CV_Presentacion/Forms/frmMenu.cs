using CV_Presentacion.Forms;
using System;
using System.Windows.Forms;
using CapaSesion;
using System.Runtime.InteropServices.ComTypes;
using CV_Presentacion.Frm_Usuario;
using CV_Presentacion.Frm_Informes;
using CV_Presentacion.Frm_Empleados;
using CV_Presentacion.Frm_Unidades;
using CV_Presentacion.Forms.Frm_Registros;
using CV_Presentacion.Forms.Frm_Taller;
using CV_Presentacion.Forms.Frm_Configuracion;

namespace CV_Presentacion
{
    public partial class FrmMenu : Form
    {

        private Form activeForm;
        public FrmMenu()
        {
            InitializeComponent();
            diseñoSubMenu();
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
        
        // abrir el submenu correspondiente al boton del mismo.
        private void btnUsuario_Click(object sender, EventArgs e)
        {
            mostrarSubMenu(pnlUsuario);
        }
        // abrir los formularios del submenu
        private void btmUserAlta_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Frm_Usuario.frm_AltaUsuario(), sender);
            ocultarSubMenu();
        }
        private void btmUserPermisos_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frm_PermisosUsuarios(), sender);
            ocultarSubMenu();
        }
        private void btmUserBloqueos_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frm_Bloqueos(), sender);
            ocultarSubMenu();
        }
        private void btmUserGrupos_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frm_PermisosGrupos(), sender);
            ocultarSubMenu();
        }
        private void btnUserPreguntas_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frm_PregunrtasDeSeguridad(), sender);
            ocultarSubMenu();
        }
        private void btmUserConfiguracion_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frm_ConfiguracionPass(), sender);
            ocultarSubMenu();
        }


        // submenu
        private void btnInformes_Click_1(object sender, EventArgs e)
        {
            mostrarSubMenu(pnlAltas);

        }
        private void btnInfo01_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frm_informes(), sender);
            ocultarSubMenu();
        }

        private void btnInfo02_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frm_Informes2(), sender);
            ocultarSubMenu();
        }


        private void btnEmpleados_Click(object sender, EventArgs e)
        {
            mostrarSubMenu(pnlDocumentacion);
        }
        private void btnEmpleados01_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frm_Empleados(), sender);
            ocultarSubMenu();
        }
        private void btnEmpleados02_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frm_Empleados2(), sender);
            ocultarSubMenu();
        }


        private void btnVehiculo_Click(object sender, EventArgs e)
        {
            mostrarSubMenu(pnlOperaciones);
        }
        private void btnUnidades01_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frm_Vehiculos(), sender);
            ocultarSubMenu();
        }
        private void btnUnidades02_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frm_Vehiculos2(), sender);
            ocultarSubMenu();
        }



        private void btnRegistro_Click(object sender, EventArgs e)
        {
            mostrarSubMenu(pnlInformes);
        }

        private void btnRegistros01_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frm_Registros(), sender);
            ocultarSubMenu();
        }
        private void btnRegistros02_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frm_registros2(), sender);
            ocultarSubMenu();
        }




        private void btnAlmacen_Click(object sender, EventArgs e)
        {
            mostrarSubMenu(pnlTaller);
        }

        private void btnTaller01_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frm_Almacen(), sender);
            ocultarSubMenu();
        }
        private void btnTaller02_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frm_Taller2(), sender);
            ocultarSubMenu();
        }


        private void btnConfiguracion_Click(object sender, EventArgs e)
        {
            mostrarSubMenu(pnlConfiguracion);
        }

        private void btnConfig01_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frm_Configuracion(), sender);
            ocultarSubMenu();
        }

        private void btnConfig02_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frm_configuracion2(), sender);
            ocultarSubMenu();
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

        private void diseñoSubMenu()
        {
            pnlUsuario.Visible = false;
            pnlAltas.Visible = false;
            pnlConfiguracion.Visible = false;
            pnlDocumentacion.Visible = false;
            pnlInformes.Visible = false;
            pnlTaller.Visible = false;
            pnlOperaciones.Visible = false;
        }
        private void ocultarSubMenu()
        {
            if (pnlUsuario.Visible==true)
                pnlUsuario.Visible = false;
            if (pnlAltas.Visible == true)
                pnlAltas.Visible = false; 
            if (pnlConfiguracion.Visible == true)
                pnlConfiguracion.Visible = false; 
            if (pnlDocumentacion.Visible == true)
                pnlDocumentacion.Visible = false; 
            if (pnlInformes.Visible == true)
                pnlInformes.Visible = false; 
            if (pnlTaller.Visible == true)
                pnlTaller.Visible = false;
            if (pnlOperaciones.Visible==true)
                pnlOperaciones.Visible = false;
        }

        private void mostrarSubMenu( Panel subMenu)
        {
            if(subMenu.Visible == false)
            {
                ocultarSubMenu();
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }
        }
    }
}


    