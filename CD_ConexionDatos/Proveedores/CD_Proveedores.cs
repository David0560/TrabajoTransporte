using CapaServicios.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CL_Servicios.Entidades;

namespace CD_ConexionDatos
{
    public class CD_Proveedores
    {
        private SqlConnection con;

        public CD_Proveedores()
        {
            con = connectionBD.CreaInstacia().CrearConexion();
        }
        public DataTable ObtenerProveedores() // BUSQUEDA TOTAL
        {
            DataTable TablaDeProveedores = new DataTable();
            string query = "SELECT * FROM Proveedor";
            using (SqlCommand command = new SqlCommand(query, con))
            {
                using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                {
                    adapter.Fill(TablaDeProveedores);
                }
            }
            return TablaDeProveedores;
        }
        public DataTable ObtenerProveedoresPorEmpresa() // BUSQUEDA POR EMPRESA
        {
            DataTable TablaDeProveedores = new DataTable();
            string query = "SELECT Id, Empresa FROM Proveedor";
            using (SqlCommand command = new SqlCommand(query, con))
            {
                using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                {
                    adapter.Fill(TablaDeProveedores);
                }
            }
            return TablaDeProveedores;
        }
        public DataTable ObtenerProveedoresPorNombre() // BUSQUEDA POR NOMBRE
        {
            DataTable TablaDeProveedores = new DataTable();
            string query = "SELECT Id, Contacto FROM Proveedor";
            using (SqlCommand command = new SqlCommand(query, con))
            {
                using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                {
                    adapter.Fill(TablaDeProveedores);
                }
            }
            return TablaDeProveedores;
        }

        public DataTable ObtenerProveedoresPorIdEmpresa(int id) // BUSQUEDA DEL NOMBRE DE LA EMPRESA POR ID
        {
            DataTable TablaDeProveedores = new DataTable();
            string query = "SELECT * FROM Proveedor WHERE Id =@id";
            using (SqlCommand command = new SqlCommand(query, con))
            {
                command.Parameters.AddWithValue("@id", id);
                using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                {

                    adapter.Fill(TablaDeProveedores);
                }
            }
            return TablaDeProveedores;
        }
        public DataTable ObtenerProveedoresPorIdContacto(int id) // BUSQUEDA DEL CONTACTO DE LA EMPRESA POR ID
        {
            DataTable TablaDeProveedores = new DataTable();
            string query = "SELECT * FROM Proveedor WHERE Id =@id";
            using (SqlCommand command = new SqlCommand(query, con))
            {
                command.Parameters.AddWithValue("@id", id);
                using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                {

                    adapter.Fill(TablaDeProveedores);
                }
            }
            return TablaDeProveedores;
        }

        public void GuardarProveedor(Proveedores proveedores) // ALTA
        {
            using (var con = connectionBD.CreaInstacia().CrearConexion())
            {
                try
                {
                    con.Open();

                    SqlCommand command = new SqlCommand("spGuardarNuevoProveedor", con) // Puedes usar un procedimiento almacenado si lo prefieres
                    {
                        CommandType = CommandType.StoredProcedure // Cambiar a CommandType.Text si no usas SP
                    };

                    command.Parameters.AddWithValue("@Empresa", proveedores.NombreEmpresa);
                    command.Parameters.AddWithValue("@Contacto", proveedores.Contacto);
                    command.Parameters.AddWithValue("@Calle", proveedores.Calle);
                    command.Parameters.AddWithValue("@Numero", proveedores.Numero);
                    command.Parameters.AddWithValue("@Ciudad", proveedores.Ciudad);
                    command.Parameters.AddWithValue("@País", proveedores.Pais);
                    command.Parameters.AddWithValue("@CódigoPostal", proveedores.CP);
                    command.Parameters.AddWithValue("@Teléfono", proveedores.Telefono);
                    command.Parameters.AddWithValue("@Email", proveedores.Email);

                    command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    // Manejo de excepción
                    throw new ApplicationException("Error al guardar el proveedor: " + ex.Message);
                }
                finally
                {
                    con.Close();
                }
            }
        }

        public void ModificoProveedor(int id, string nombreEmpresa, string contacto, string telefono,
                                  string email, string ciudad, string pais,
                                  string calle, string numero, int CP) //MODIFICACIÓN 
        {
            try
            {
                string query = @"
            UPDATE Proveedor
            SET 
                Empresa = @Empresa,
                Contacto = @Contacto,
                Teléfono = @Teléfono,
                Email = @Email,
                Ciudad = @Ciudad,
                País = @País,
                Calle = @Calle,
                Numero = @Numero,
                CódigoPostal = @CódigoPostal
            WHERE Id = @id";
                using (SqlCommand command = new SqlCommand(query, con))
                {
                    command.Parameters.AddWithValue("@id", id);
                    command.Parameters.AddWithValue("@Empresa", nombreEmpresa);
                    command.Parameters.AddWithValue("@Contacto", contacto);
                    command.Parameters.AddWithValue("@Calle", calle);
                    command.Parameters.AddWithValue("@Numero", numero);
                    command.Parameters.AddWithValue("@Ciudad", ciudad);
                    command.Parameters.AddWithValue("@País", pais);
                    command.Parameters.AddWithValue("@CódigoPostal", CP);
                    command.Parameters.AddWithValue("@Teléfono", telefono);
                    command.Parameters.AddWithValue("@Email", email);

                    con.Open();
                    command.ExecuteNonQuery();
                }
                con.Close();
            }

            catch (Exception ex)
            {
                // Manejo de excepción
                throw new ApplicationException("Error al guardar el Proveedor: " + ex.Message);
            }
        }

        // Método para obtener proveedores filtrados por nombre de empresa
        public DataTable ObtenerProveedoresPorEmpresa(string empresa) // BUSQUEDA POR EMPRESA
        {
            DataTable TablaDeProveedores = new DataTable();

            using (SqlCommand command = new SqlCommand("spObtenerProveedoresPorEmpresa", con))
            {
                command.CommandType = CommandType.StoredProcedure; // Especificamos que es un Stored Procedure

                // Asegúrate de que el parámetro @Empresa esté definido en tu SP
                command.Parameters.AddWithValue("@Empresa", empresa);

                using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                {
                    adapter.Fill(TablaDeProveedores);
                }
            }
            return TablaDeProveedores;
        }
    }

}

