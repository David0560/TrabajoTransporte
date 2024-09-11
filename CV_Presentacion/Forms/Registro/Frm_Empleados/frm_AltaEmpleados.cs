using CapaServicios;
using CL_Negocios;
using CL_Negocios.Empleados;
using CL_Negocios.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CV_Presentacion.Forms
{
    public partial class frm_AltaEmpleados : Form
    {
        private CL_administrarComboBox combo = new CL_administrarComboBox();
        public frm_AltaEmpleados()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CS_contraseña pass = new CS_contraseña();

            string nombre = txtLegajo.Text.ToString();
            string passuser = txtNombre.Text.ToString();

            string sha = pass.crearSHA256(nombre, passuser);

            txtApellido.Text = sha;

            lblApellido.Text = pass.crearCodigoVerificador(sha).ToString(); ;


        }
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void frm_Empleados_Load(object sender, EventArgs e)
        {
            combo.seleccionCombo(cboTarea, "spVerTareas");
            combo.seleccionCombo(cboDocumento, "spVerDocumentoIdent");
            combo.seleccionCombo(cboSexo, "spVerSexo");
            combo.seleccionCombo(cboCiudad, "spVerCiudad");
            mskFIngreso.Text = DateTime.Now.ToShortDateString();

            // Deshabilitar los GroupBoxes al iniciar el formulario
            gpbDatos.Enabled = false;
            gpbGrupoTrabajo.Enabled = false;

            // Inicializar el estado del CheckBox como no marcado
            chkRegistro.Checked = false;

            // Asociar el evento al ComboBox de Tarea
            cboTarea.SelectedIndexChanged += cboTarea_SelectedIndexChanged;
        }
        private void listaPermiso()
        {
            if (cboCiudad.SelectedItem != null)
            {
                int valorSeleccionado;
                if (int.TryParse(cboCiudad.SelectedValue.ToString(), out valorSeleccionado))
                {
                    int valor = Convert.ToInt32(cboCiudad.SelectedValue);
                    combo.seleccionarLocalidad(cboLocalidad, valor); 

                }
                else
                {
                    // Manejar el caso en que no se pueda convertir el valor a entero
                    //MessageBox.Show("El valor seleccionado no es válido");
                }
            }
        }

        

        private void cboCiudad_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboCiudad.SelectedValue != null) 
            {
                listaPermiso();
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                // Capturamos los valores ingresados por el usuario
                string nombre = txtNombre.Text;
                string apellido = txtApellido.Text;
                string fechaNacimiento = mskFNacimiento.Text;
                string numeroDocumento = txtNumeroDoc.Text;
                string calle = txtCalle.Text;
                string numeroDomicilio = txtNumero.Text;
                string email = txtEmail.Text;
                
                int idDocumentoIdent = Convert.ToInt32(cboDocumento.SelectedValue);
                int idSexo = Convert.ToInt32(cboSexo.SelectedValue);
                int idLocalidad = Convert.ToInt32(cboCiudad.SelectedValue);
                int idTarea = Convert.ToInt32(cboTarea.SelectedValue);

                // Crear una instancia de la clase Persona con los datos capturados
                Persona nuevaPersona = new Persona(nombre, apellido, DateTime.Parse(fechaNacimiento), idDocumentoIdent, numeroDocumento, idSexo, idLocalidad, calle, Convert.ToInt32(numeroDomicilio), email, idTarea);

                // Instanciamos la clase CL_AdministrarEmpleados y guardamos el nuevo empleado
                CL_AdministrarEmpleados administradorEmpleados = new CL_AdministrarEmpleados();
                administradorEmpleados.GuardarEmpleado(nuevaPersona);

                MessageBox.Show("Empleado guardado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (ArgumentException ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al guardar el empleado: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void chkRegistro_CheckedChanged(object sender, EventArgs e)
        {
            if (chkRegistro.Checked)
            {
                // Habilitar los GroupBoxes si el checkbox está marcado
                gpbDatos.Enabled = true;
                gpbGrupoTrabajo.Enabled = true;
            }
            else
            {
                // Deshabilitar los GroupBoxes si el checkbox no está marcado
                gpbDatos.Enabled = false;
                gpbGrupoTrabajo.Enabled = false;
            }
        }

        private void cboTarea_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Comprobar si el valor seleccionado en el ComboBox es "2" (Conductor)
            if (cboTarea.SelectedValue != null && cboTarea.SelectedValue.ToString() == "2")
            {
                // Habilitar los GroupBoxes si la tarea seleccionada es "Conductor"
                gpbDatos.Enabled = true;
                gpbGrupoTrabajo.Enabled = true;
            }
            else
            {
                // Verificar si el checkbox está marcado, en ese caso mantener los GroupBoxes habilitados
                if (!chkRegistro.Checked)
                {
                    // Deshabilitar los GroupBoxes si no es conductor y no está marcado el checkbox
                    gpbDatos.Enabled = false;
                    gpbGrupoTrabajo.Enabled = false;
                }
            }
        }

    }
}