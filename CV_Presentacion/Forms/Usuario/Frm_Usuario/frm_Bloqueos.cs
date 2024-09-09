using CapaServicios;
using CL_Negocios;
using CL_Negocios.Usuarios;
using Microsoft.VisualBasic;
using System;
using System.Windows.Forms;

namespace CV_Presentacion.Frm_Usuario
{
    public partial class frm_Bloqueos : Form
    {
        CL_administrarComboBox combo = new CL_administrarComboBox();
        CL_administrarTablas tabla = new CL_administrarTablas();
        CL_administrarTablas tabla2 = new CL_administrarTablas();
        CL_AdministrarUsuario registro = new CL_AdministrarUsuario();
        CS_contraseña conta = new CS_contraseña();
        CS_servicios servicio = new CS_servicios();
        ConfiguracionPassword configure = new ConfiguracionPassword();
        CL_administrarPreguntas pre = new CL_administrarPreguntas();
        private ConfiguracionPasswordBLL configuracionPasswordBLL;
        

        public frm_Bloqueos()
        {
            InitializeComponent();
          

        }

        private void frm_Bloqueos_Load(object sender, EventArgs e)
        {
            //
            // Comportamiento del DatagridView
            //
            servicio.parametrosDataGridView(dgvListaUsuarios);
            dgvListaUsuarios.DataSource = tabla.ListarUsuarios();
        }

        private void btnGuardarBloqueos_Click(object sender, EventArgs e)
        {
            string nombre = this.dgvListaUsuarios.SelectedRows[0].Cells[3].Value.ToString();

            int id = Convert.ToInt32(this.dgvListaUsuarios.SelectedRows[0].Cells[0].Value);
            string estado = Convert.ToString(Interaction.InputBox($"Realizará cambios en el estado del \nUsuario: \n \n{nombre} \n \nColoque el estado que desee para el usuario \n0 = bloqueado, 1 = activo"));
            registro.bloquearUsuario(id, estado);
            //registro.LimpiarControlesEnTabPage(tabBloqueos);
            dgvListaUsuarios.DataSource = tabla.ListarUsuarios();
        }

        private void btnNuevoPassword_Click(object sender, EventArgs e)
        {

            string usuario = this.dgvListaUsuarios.SelectedRows[0].Cells[3].Value.ToString();
            DialogResult resultado = MessageBox.Show($"Generará una nueva contraseña para el Usuario \n {usuario} \n ¿Está seguro?", "Atención", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
            if (resultado == DialogResult.OK)
            {
                int id = Convert.ToInt32(this.dgvListaUsuarios.SelectedRows[0].Cells[0].Value);
                string nombre = Convert.ToString(this.dgvListaUsuarios.SelectedRows[0].Cells[3].Value);
                registro.enviarNuevoPassword(id, nombre, configure);
            }

        }
    }
}
