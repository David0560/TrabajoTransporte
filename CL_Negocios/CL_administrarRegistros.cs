using CL_Negocios.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CD_ConexionDatos;
using CapaServicios;
using static System.Net.WebRequestMethods;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Windows.Forms;
using Microsoft.Win32;

namespace CL_Negocios
{
    public class CL_administrarRegistros
    {
        CS_contraseña password = new CS_contraseña();

        private CD_crearRegistros _crearRegistros; //creo una propiedad con un objeto Crear Registro
        public CL_administrarRegistros()
        {
            _crearRegistros = new CD_crearRegistros(); //dentro del constructor instancio el objeto.    
        }

        //relacionados al usuario
        public bool insertarNuevoUsuario(Usuario usuario, ConfiguracionPassword config)
        {
            if (usuario.Nombre != "")
            {

                string pass = password.crearContraseña(config);
                DateTime? fechaVU = ValidarFecha(usuario.fechaVU);
                DateTime? fechaVP = ValidarFecha(usuario.fechaVP);

                if (ContieneEspacio(usuario.Nombre))
                {
                    if (validarFechaPosible(fechaVU) & validarFechaPosible(fechaVP))
                    {
                        Usuario guardarUsuario = new Usuario(usuario.Nombre, usuario.Id_persona, usuario.Id_familia, fechaVP, fechaVU, 1, pass);
                        _crearRegistros.guardarNuevoUsuario(guardarUsuario);
                        return true;
                    }
                    return false;
                }
                return false;
            }
            else
            {
                return false;
            }
                
        }
        public void eliminarUsuario(string nombreUsuario)
        {
            _crearRegistros.borrarUsuario(nombreUsuario);
        }
        public void bloquearUsuario(string nombreUsuario)
        {
            _crearRegistros.bloqueoDeUsuario(nombreUsuario);
        }

        //relacionados a los roles
        public void insertarPermisoPorFamilia (Permisos permiso)
        {
            int id_famil_rol =permiso.Id_familia_rol;
            int id_usuario =_crearRegistros.obtenerUltimoUsuario();
            DateTime? fecha_baja = null;

            Permisos NuevoPermiso = new Permisos(id_famil_rol, id_usuario, fecha_baja);

            _crearRegistros.guardarNuevoPermiso(NuevoPermiso);
        }
        public void insertarNuevoPermiso(Permisos permiso)
        {
            int id_famil_rol = permiso.Id_familia_rol;
            int id_usuario = permiso.Id_usuario;
            DateTime? fecha_baja = ValidarFecha(permiso.fecha_vence);

            Permisos NuevoPermiso = new Permisos(id_famil_rol, id_usuario, fecha_baja);

            _crearRegistros.guardarNuevoPermiso(NuevoPermiso);
        }
        public void elimiarPermiso(int id)
        {
            _crearRegistros.EliminarPermisoDeUsuario(id);
        }

        public void ActualizarFechaRegistro(int id, string fecha)
        {
            DateTime? fecha_baja = ValidarFecha(fecha);
            _crearRegistros.ActualizarFechaVencimiento(id, fecha_baja);
        }

        //validaciones
        public DateTime? ValidarFecha(string valor)
        {
            if(valor == "  /  /")
            {
                DateTime? fecha= null;
                return fecha;
            }
            else if (valor == "")
            {
                DateTime? fecha = null;
                return fecha;
            }
            else
            {               
                    DateTime? fecha = DateTime.Parse(valor);
                    return fecha;
                
            }

        }
        public bool validarFechaPosible(DateTime? valor)
        {
            if (valor > DateTime.Now || valor == null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool ContieneEspacio (string nombre)
        {
            // Verificar si la cadena contiene espacios en su interior
            if (nombre.Contains(" "))
            {
                return false; // La cadena contiene espacios
            }
            else
            {
                return true; // La cadena no contiene espacios
            }
        }
        public void LimpiarControles(Control control)
        {
           // Recorrer todos los controles dentro del control padre
            foreach (var c in control.Controls)
            {
                // Verificar si el control es un TextBox
                if (c is TextBox)
                {
                    ((TextBox)c).Clear(); // Limpia el contenido del TextBox
                }

                // Verificar si el control es un ComboBox if (c is ComboBox)
                {
                    ((ComboBox)c).SelectedIndex = -1 ; // Reiniciar la selección del ComboBox
                    ((ComboBox)c).Text = ""; // Limpiar el texto del ComboBox
                }

                // Verificar si el control es un DataGridView
                if (control is DataGridView dataGridView)
                {
                    dataGridView.DataSource = null; // Eliminar la fuente de datos del DataGridView
                    dataGridView.Rows.Clear(); // Limpiar las filas en el DataGridView
                }
            }

        }
        public void LimpiarControlesEnTabPage(TabPage tabPage)
        {
            foreach (Control control in tabPage.Controls)
            {
                if (control is TextBox textBox)
                {
                    textBox.Text = string.Empty; // Limpiar el contenido del TextBox
                }
                if (control is ComboBox comboBox)
                {
                    comboBox.SelectedIndex = -1; // Resetear la selección del ComboBox
                }
                if (control is DataGridView dataGridView)
                {
                    dataGridView.DataSource = null; // Eliminar la fuente de datos del DataGridView
                    dataGridView.Rows.Clear(); // Limpiar las filas en el DataGridView
                }
                if (control is MaskedTextBox maskedtextBox)
                {
                    maskedtextBox.Text = string.Empty; // Limpiar el contenido del maskedTextBox
                }


            }
        }

       
       



    }
}