using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CD_ConexionDatos.Taller
{
    public class CD_RInsumos
    {
        private static connectionBD connection = connectionBD.CreaInstacia();
      
        // Método para guardar el registro de insumos y sus detalles
        public void GuardarRegistroInsumos(int idUsuario, int idProveedor, DataGridView dtListaArticulos, DateTime fechaEntrada)
        {
            using (SqlConnection con = connection.CrearConexion()) 
            {
                con.Open();  
                SqlTransaction transaction = con.BeginTransaction();  

                try
                {
                    //Primero se Inserta en la tabla RegistroInsumos y obtener el ID generado
                    int idRegistroInsumos;

                    using (SqlCommand cmd = new SqlCommand("spGuardarRegistroInsumos", con, transaction))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@ld_Usuario", idUsuario);
                        cmd.Parameters.AddWithValue("@ld_Proveedor", idProveedor);
                        cmd.Parameters.AddWithValue("@FechaEntrada", fechaEntrada);

                        idRegistroInsumos = Convert.ToInt32(cmd.ExecuteScalar());  // Obtener el ID del nuevo registro
                    }

                    //Segundo se Insertan los datos de los insumos en la tabla Insumos
                    foreach (DataGridViewRow row in dtListaArticulos.Rows)
                    {
                        if (!row.IsNewRow) // Ignorar la última fila vacía
                        {
                            int idArticulo = Convert.ToInt32(row.Cells["Id"].Value);  
                            int cantidad = Convert.ToInt32(row.Cells["Cantidad"].Value);  
                            DateTime fechaVencimiento = Convert.ToDateTime(row.Cells["FechaVencimiento"].Value);
                            using (SqlCommand cmd = new SqlCommand("spGuardarInsumo", con, transaction))
                            {
                                cmd.CommandType = CommandType.StoredProcedure;
                                cmd.Parameters.AddWithValue("@ld_Registrolnsumos", idRegistroInsumos);
                                cmd.Parameters.AddWithValue("@idArticulo", idArticulo);
                                cmd.Parameters.AddWithValue("@Cantidad", cantidad);
                                cmd.Parameters.AddWithValue("@FechaVencimiento", fechaVencimiento);

                                cmd.ExecuteNonQuery();
                            }
                        }
                    }
                    transaction.Commit();
                }
                catch (Exception ex)
                {
                    // Si hay un error se hace un rollback
                    transaction.Rollback();
                    throw new Exception("Error al guardar el registro de insumos: " + ex.Message);
                }
            }
        }
    }
}