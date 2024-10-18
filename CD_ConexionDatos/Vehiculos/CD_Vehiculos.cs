using System.Data.SqlClient;
using System.Data;
using System;

namespace CD_ConexionDatos
{
    public class CD_Vehiculos
    {
        private SqlConnection con;

        public CD_Vehiculos()
        {
            con = connectionBD.CreaInstacia().CrearConexion();
        }

        public void GuardarNuevoVehiculo(DateTime fechaAlta, string dominio, string tipo, string marca,
                                   string modelo, string marcaMotor, string numeroMotor,
                                   string marcaChasis, string numeroChasis, string estado,
                                   int cantidadPlazas, decimal km, int idCombustible,
                                   DateTime fechaOtorgadoVTV, DateTime fechaVencimientoVTV)
        {
            try
            {
                using (SqlCommand comando = new SqlCommand("spGuardarNuevoVehiculo", con))
                {
                    comando.CommandType = CommandType.StoredProcedure;

                    comando.Parameters.AddWithValue("@xfecha_alta", fechaAlta);
                    comando.Parameters.AddWithValue("@xdominio", dominio.Length <= 15 ? dominio : dominio.Substring(0, 15));
                    comando.Parameters.AddWithValue("@xtipo", tipo.Length <= 50 ? tipo : tipo.Substring(0, 50));
                    comando.Parameters.AddWithValue("@xmarca", marca.Length <= 50 ? marca : marca.Substring(0, 50));
                    comando.Parameters.AddWithValue("@xmodelo", modelo.Length <= 50 ? modelo : modelo.Substring(0, 50));
                    comando.Parameters.AddWithValue("@xmarca_motor", marcaMotor.Length <= 50 ? marcaMotor : marcaMotor.Substring(0, 50));
                    comando.Parameters.AddWithValue("@xnumero_motor", numeroMotor.Length <= 50 ? numeroMotor : numeroMotor.Substring(0, 50));
                    comando.Parameters.AddWithValue("@xmarca_chasis", marcaChasis.Length <= 50 ? marcaChasis : marcaChasis.Substring(0, 50));
                    comando.Parameters.AddWithValue("@xnumero_chasis", numeroChasis.Length <= 50 ? numeroChasis : numeroChasis.Substring(0, 50));
                    comando.Parameters.AddWithValue("@xestado", estado.Length <= 50 ? estado : estado.Substring(0, 50));
                    comando.Parameters.AddWithValue("@xcantidad_plazas", cantidadPlazas);
                    comando.Parameters.AddWithValue("@xkm", km);
                    comando.Parameters.AddWithValue("@xid_combustible", idCombustible);
                    comando.Parameters.AddWithValue("@xfecha_otorgado", fechaOtorgadoVTV);
                    comando.Parameters.AddWithValue("@xfecha_vencimiento", fechaVencimientoVTV);

                    con.Open();
                    int rowsAffected = comando.ExecuteNonQuery();
                    con.Close();
                }
            }
            catch (Exception ex)
            {
                // Manejo de excepción
                throw new ApplicationException("Error al guardar el vehículo: " + ex.Message);
            }
        }
        public DataTable ObtengoVehículosPorPatente(string patente)
        {
            DataTable dt = new DataTable();
            using (var con = connectionBD.CreaInstacia().CrearConexion())
            {
                try
                {
                    con.Open();
                    SqlCommand command = new SqlCommand("spObtenerVehiculosPorPatente", con)
                    {
                        CommandType = CommandType.StoredProcedure
                    };
                    command.Parameters.AddWithValue("@Dominio", patente);
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

    }
}