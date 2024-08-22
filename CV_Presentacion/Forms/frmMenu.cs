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
            OpenChildForm(new frm_AltaUsuario(), sender);

        }
        private void btmUserPermisos_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frm_PermisosUsuarios(), sender);

        }
        private void btmUserBloqueos_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frm_Bloqueos(), sender);

        }
        private void btmUserGrupos_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frm_PermisosGrupos(), sender);

        }
        private void btnUserPreguntas_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frm_PregunrtasDeSeguridad(), sender);

        }
        private void btmUserConfiguracion_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frm_Configuracion(), sender);

        }


        // submenu
        private void btnInformes_Click_1(object sender, EventArgs e)
        {
            mostrarSubMenu(pnlInformes);

        }
        private void btnInfo01_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frm_informes(), sender);
        }

        private void btnInfo02_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frm_Informes2(), sender);
        }


        private void btnEmpleados_Click(object sender, EventArgs e)
        {
            mostrarSubMenu(pnlEmpleados);
        }
        private void btnEmpleados01_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frm_Empleados(), sender);
        }
        private void btnEmpleados02_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frm_Empleados2(), sender);
        }


        private void btnVehiculo_Click(object sender, EventArgs e)
        {
            mostrarSubMenu(pnlVehiculos);
        }
        private void btnUnidades01_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frm_Vehiculos(), sender);
        }
        private void btnUnidades02_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frm_Vehiculos2(), sender);
        }



        private void btnRegistro_Click(object sender, EventArgs e)
        {
            mostrarSubMenu(pnlRegistros);
        }

        private void btnRegistros01_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frm_Registros(), sender);
        }
        private void btnRegistros02_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frm_registros2(), sender);
        }




        private void btnAlmacen_Click(object sender, EventArgs e)
        {
            mostrarSubMenu(pnlAlmacen);
        }

        private void btnTaller01_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frm_Almacen(), sender);
        }
        private void btnTaller02_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frm_Taller2(), sender);
        }


        private void btnConfiguracion_Click(object sender, EventArgs e)
        {
            mostrarSubMenu(pnlConfiguracion);

            //OpenChildForm(new frm_Configuracion(), sender);
        }

        private void btnConfig01_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frm_Configuracion(), sender);
        }

        private void btnConfig02_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frm_configuracion2(), sender);
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
            pnlInformes.Visible = false;
            pnlConfiguracion.Visible = false;
            pnlEmpleados.Visible = false;
            pnlRegistros.Visible = false;
            pnlAlmacen.Visible = false;
            pnlVehiculos.Visible = false;
        }
        private void ocultarSubMenu()
        {
            if (pnlUsuario.Visible==true)
                pnlUsuario.Visible = false;
            if (pnlInformes.Visible == true)
                pnlInformes.Visible = false; 
            if (pnlConfiguracion.Visible == true)
                pnlConfiguracion.Visible = false; 
            if (pnlEmpleados.Visible == true)
                pnlEmpleados.Visible = false; 
            if (pnlRegistros.Visible == true)
                pnlRegistros.Visible = false; 
            if (pnlAlmacen.Visible == true)
                pnlAlmacen.Visible = false;
            if (pnlVehiculos.Visible==true)
                pnlVehiculos.Visible = false;
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


    