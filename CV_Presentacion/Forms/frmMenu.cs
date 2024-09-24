using CV_Presentacion.Forms;
using System;
using System.Windows.Forms;
using CapaSesion;
using CV_Presentacion.Frm_Usuario;
using CV_Presentacion.Frm_Informes;
using CV_Presentacion.Forms.Registro.Frm_Empleados;
using CV_Presentacion.Forms.Frm_Taller;
using CV_Presentacion.Forms.Registro.Frm_Proveedores;
using CV_Presentacion.Forms.Registro.Frm_Vehiculos;
using CV_Presentacion.Forms.Documentacion;
using CV_Presentacion.Forms.Diaria.Frm_Diaria;
using CV_Presentacion.Forms.Ajustes.Frm_Ajustes;
using CV_Presentacion.Forms.Diaria.Frm_Diaria.Frm_CierrePlanilla;
using CV_Presentacion.Forms.Informes.Frm_Informes;

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
        private void tmrFecha_Tick(object sender, EventArgs e)
        {
            lblFecha.Text = DateTime.Now.ToShortDateString();// coloco la hora actual de la pc en el label
            lblHora.Text = DateTime.Now.ToLongTimeString();
        }
        private void btnSalirUsuario_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Estas por Cerrar la sesion, ¿Estas seguro?", "Atencion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                this.Close();
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
            this.panelMenu.Controls.Add(childForm);
            this.panelMenu.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            //lblTitulo.Text = childForm.Text;

        }
        //
        //llamados a formularios a menu
        //
        private void diseñoSubMenu()
        {
            pnlUsuario.Visible = false;
            pnlRegistros.Visible = false;
            pnlTaller.Visible = false;
            pnlDocumentacion.Visible = false;
            pnlInformes.Visible = false;
            pnlDiaria.Visible = false;
            pnlAjuestes.Visible = false;
        }
        private void ocultarSubMenu()
        {
            if (pnlUsuario.Visible == true)
                pnlUsuario.Visible = false;
            if (pnlRegistros.Visible == true)
                pnlRegistros.Visible = false;
            if (pnlTaller.Visible == true)
                pnlTaller.Visible = false;
            if (pnlDocumentacion.Visible == true)
                pnlDocumentacion.Visible = false;
            if (pnlInformes.Visible == true)
                pnlInformes.Visible = false;
            if (pnlDiaria.Visible == true)
                pnlDiaria.Visible = false;
            if (pnlAjuestes.Visible == true)
                pnlAjuestes.Visible = false;
        }
        private void mostrarSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                ocultarSubMenu();
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }
        }
        //
        // abrir el submenu correspondiente al boton del mismo.
        //
        private void btnMenu_Click(object sender, EventArgs e)
        {
            activeForm.Close();
        }
        private void btnUsuario_Click(object sender, EventArgs e)
        {
            mostrarSubMenu(pnlUsuario);
        }
        private void btnInformes_Click_1(object sender, EventArgs e)
        {
            mostrarSubMenu(pnlRegistros);

        }
        private void btnEmpleados_Click(object sender, EventArgs e)
        {
            mostrarSubMenu(pnlDocumentacion);
        }
        private void btnRegistro_Click(object sender, EventArgs e) //Boton Informes
        {
            mostrarSubMenu(pnlInformes);
        }
        private void btnAlmacen_Click(object sender, EventArgs e) // Boton Diaria
        {
            mostrarSubMenu(pnlDiaria);
        }
        private void btnConfiguracion_Click(object sender, EventArgs e) // boton Taller
        {
            mostrarSubMenu(pnlTaller);
        }
        private void btnAjustes_Click(object sender, EventArgs e) 
        {
            mostrarSubMenu(pnlAjuestes);
        }
        //
        // Submenu - abrir los formularios
        //

        // Usuarios
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

        // Registros
        private void btnInfo01_Click(object sender, EventArgs e) //Empleados
        {
            OpenChildForm(new frm_MenuEmpleados(), sender);
            ocultarSubMenu();
        }
        private void btnRegProveedores_Click_1(object sender, EventArgs e)
        {
            OpenChildForm(new frm_MenuProveedores(), sender);
            ocultarSubMenu();
        } 
        private void btnRegVehiculos_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frm_MenuVehiculos(), sender);
            ocultarSubMenu();
        }

        //Documentacion
        private void btnEmpleados01_Click(object sender, EventArgs e) //LicenciaEmpleado
        {
            OpenChildForm(new frm_MenuLicenciaEmpleado(), sender);
            ocultarSubMenu();
        }
        private void btnDocTurno_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frm_MenuTurnosTrabajo(), sender);
            ocultarSubMenu();
        }
        private void btnDocUnidad_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frm_MenuUnidad(), sender);
            ocultarSubMenu();
        }
        private void btnDocRamales_Click(object sender, EventArgs e)
        {

            OpenChildForm(new frm_MenuRamales(), sender);
            ocultarSubMenu();
        }
        private void btnDocVtv_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frm_ActualizarRegistro(), sender);
            ocultarSubMenu();
        }

        //Informes
        private void btnRegistros01_Click(object sender, EventArgs e) // Estadisticas
        {
            OpenChildForm(new frm_Estadisticas(), sender);
            ocultarSubMenu();
        }
        private void btnRegistros02_Click(object sender, EventArgs e) // informer
        {
            OpenChildForm(new frm_Informes(), sender);
            ocultarSubMenu();
        }

        //Diarias
        private void btnTaller01_Click(object sender, EventArgs e) // Crear Grilla
        {
            OpenChildForm(new frm_EstimalGrilla(), sender);
            ocultarSubMenu();
        }
        private void btnTaller02_Click(object sender, EventArgs e) // Planilla Salida
        {
            OpenChildForm(new frm_PlanillaSalida(), sender);
            ocultarSubMenu();
        }
        private void btnDiaPlanillaC_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frm_MenuCierrePlanilla(), sender);
            ocultarSubMenu();
        }

        // Taller
        private void btnTallerCargaInsumos_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frm_MenuCargarInsumos(), sender);
            ocultarSubMenu();
        }
        private void btnConfig02_Click(object sender, EventArgs e) // Stock
        {
            OpenChildForm(new frm_Stock(), sender);
            ocultarSubMenu();
        }
        private void btnTallerMecanica_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frm_MenuMecanica(), sender);
            ocultarSubMenu();
        }

        // Ajustes
        private void btnAjustActPass_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.frm_Actualizar(), sender);
            ocultarSubMenu();
        }
        private void btnAjustConfig_Click_1(object sender, EventArgs e)
        {
            OpenChildForm(new frm_ConfigPrincipal(), sender);
            ocultarSubMenu();
        }
        /*private void btnAjustConfig_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frm_ConfigPrincipal(), sender);
            ocultarSubMenu();
        }*/


    }
}


    