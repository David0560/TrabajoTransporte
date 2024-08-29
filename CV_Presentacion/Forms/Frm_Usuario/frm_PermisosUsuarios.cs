using CapaServicios;
using CL_Negocios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CV_Presentacion.Frm_Usuario
{
    public partial class frm_PermisosUsuarios : Form
    {
        CL_administrarComboBox _combo = new CL_administrarComboBox();
        CS_servicios _servicio = new CS_servicios();
        CL_administrarTablas _tabla = new CL_administrarTablas();

        public frm_PermisosUsuarios()
        {
            InitializeComponent();
        }
        private void cboSeleccionarUsuario_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboSeleccionarUsuario.SelectedValue != null) //reparo la falta de seleccion en el combobox.
            {
                listaPermiso();
            }
            //int valorSeleccionado;
            // necedsito que este combo tenga los permisos que no tiene el usuario seleccionado.
            /*if (int.TryParse(cboSeleccionarUsuario.SelectedValue.ToString(), out valorSeleccionado))
            {
                int valor = Convert.ToInt32(cboSeleccionarUsuario.SelectedValue);
                _combo.seleccionNuevoPermisoCombo(cboSeleccionarPermiso, valor);
            }*/
            
        }
        private void frm_PermisosUsuarios_Load(object sender, EventArgs e)
        {
            _servicio.parametrosDataGridView(dgvDatos);
            _combo.seleccionCombo(cboSeleccionarUsuario, "spVerUsuario");
        }
        private void listaPermiso()
        {
            // Obtener el valor seleccionado del ComboBox
            if (cboSeleccionarUsuario.SelectedItem != null)
            {
                int valorSeleccionado;
                if (int.TryParse(cboSeleccionarUsuario.SelectedValue.ToString(), out valorSeleccionado))
                {
                    // Llamar a la función con el valor obtenido del ComboBox
                    dgvDatos.DataSource = _tabla.permisosPorUsuario(valorSeleccionado);

                    int valor = Convert.ToInt32(cboSeleccionarUsuario.SelectedValue);
                    _combo.seleccionNuevoPermisoCombo(cboSeleccionarPermiso, valor);

                }
                else
                {
                    // Manejar el caso en que no se pueda convertir el valor a entero
                    //MessageBox.Show("El valor seleccionado no es válido");
                }
            }
        }
        private void cboSeleccionarPermiso_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
