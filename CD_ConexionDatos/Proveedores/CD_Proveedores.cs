using CapaServicios.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public void GuardarProveedor(string nombreEmpresa, string contacto, string telefono,
                                  string email, string ciudad, string pais,
                                  string calle, string numero, int CP) //ALTA 
        {
            try
            {
                string query = @"
                INSERT INTO Proveedor 
                (Empresa, Contacto, Calle, Numero , Ciudad, País, CódigoPostal, Teléfono, Email ) 
                VALUES 
                (@Empresa, @Contacto, @Calle , @Numero , @Ciudad, @País, @CódigoPostal, @Teléfono, @Email )";

                using (SqlCommand command = new SqlCommand(query, con))
                {
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
                throw new ApplicationException("Error al guardar el vehículo: " + ex.Message);
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

    }
}
