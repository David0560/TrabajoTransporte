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
        public void ModificoProveedor(Proveedores proveedores) // ALTA
        {
            using (var con = connectionBD.CreaInstacia().CrearConexion())
            {
                try
                {
                    con.Open();

                    SqlCommand command = new SqlCommand("spModificarProveedor", con) // Puedes usar un procedimiento almacenado si lo prefieres
                    {
                        CommandType = CommandType.StoredProcedure // Cambiar a CommandType.Text si no usas SP
                    };
                    command.Parameters.AddWithValue("@Id", proveedores.Id);
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
        public void GuardarProveedor(Proveedores proveedores) // ALTA
        {
            using (var con = connectionBD.CreaInstacia().CrearConexion())
            {
                try
                {
                    con.Open();

                    SqlCommand command = new SqlCommand("spGuardarNuevoProveedor", con) // 
                    {
                        CommandType = CommandType.StoredProcedure // 
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
        public void EliminarProveedor(int proveedorId) // ELIMINAR
        {
            using (var con = connectionBD.CreaInstacia().CrearConexion())
            {
                try
                {
                    con.Open();

                    SqlCommand command = new SqlCommand("spEliminarProveedor", con) // 
                    {
                        CommandType = CommandType.StoredProcedure //
                    };
                    command.Parameters.AddWithValue("@Id", proveedorId);

                    command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    // Manejo de excepción
                    throw new ApplicationException("Error al eliminar el proveedor: " + ex.Message);
                }
             
            }
        }


    }

    }


