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
        public DataTable ObtenerProveedoresPorEmpresa(string nombreEmpresa)
        {
            DataTable dt = new DataTable();
            using (var con = connectionBD.CreaInstacia().CrearConexion())
            {
                try
                {
                    con.Open();
                    SqlCommand command = new SqlCommand("spObtenerProveedoresPorEmpresa", con)
                    {
                        CommandType = CommandType.StoredProcedure
                    };
                    command.Parameters.AddWithValue("@Empresa", nombreEmpresa);
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    adapter.Fill(dt);
                }
                catch (Exception ex)
                {
                    throw new ApplicationException("Error al obtener proveedores por empresa: " + ex.Message);
                }
            }
            return dt;
        }

        public DataTable ObtenerProveedoresPorContacto(string contacto)
        {
            DataTable dt = new DataTable();
            using (var con = connectionBD.CreaInstacia().CrearConexion())
            {
                try
                {
                    con.Open();
                    SqlCommand command = new SqlCommand("spObtenerProveedoresPorContacto", con)
                    {
                        CommandType = CommandType.StoredProcedure
                    };
                    command.Parameters.AddWithValue("@Contacto", contacto);
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    adapter.Fill(dt);
                }
                catch (Exception ex)
                {
                    throw new ApplicationException("Error al obtener proveedores por contacto: " + ex.Message);
                }
            }
            return dt;
        }


    }

    }


