using CD_ConexionDatos;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Net.NetworkInformation;

namespace CL_Negocios
{
    public class operaciones
    {
        SqlConnection con = new SqlConnection(); // prepara el objeto para recibir los valores
        

        public operaciones() { }

        public int ValidarUsuario(string password, string usuario)
        {
            
            try
            {
                using (con = connectionBD.CreaInstacia().CrearConexion())
                {
                    con.Open();
                    using (SqlCommand comando = new SqlCommand("spValidarUsuario", con))
                    {
                        comando.CommandType = CommandType.StoredProcedure;

                        comando.Parameters.AddWithValue("@password", password);
                        comando.Parameters.AddWithValue("@nombreUsuario", usuario);

                        SqlDataReader dr = comando.ExecuteReader();

                        if (dr.Read())
                        {
                            return dr.GetInt32(0);
                           
                        }
                        
                        //comando.Parameters.Add(new SqlParameter("@nombreUsuario", con));
                        //comando.Parameters["@nombreUsuatio"].Value = usuario;
                        //DataTable dt = new DataTable();
                        //SqlDataAdapter da = new SqlDataAdapter(comando);
                       
                        //da.Fill(dt);

                       
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally // permite colocar una condicion para saber el estado de la conexión
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close(); // cierra la conexión
                }
            }
            return 0;
           
        }

    }
}
