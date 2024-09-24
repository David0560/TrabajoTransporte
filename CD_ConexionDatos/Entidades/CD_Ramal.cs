using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CL_Negocios.Entidades;
using System.Runtime.Remoting.Messaging;

namespace CD_ConexionDatos.Entidades
{
    public class CD_Ramal
    {
        SqlConnection con = new SqlConnection(); // instancio la cadena para la conexion 

        //Propiedades de la clase.
        protected string Nombre { get; set; }
        protected int Kilometros { get; set; }
        protected int TiempoRecorrido { get; set; }
        protected int CantidadUnidades { get; set; }
        protected string Descripcion { get; set; }
        protected DateTime HoraInicio { get; set; }


        //Constructor de la clase.
        public CD_Ramal() { }
        public CD_Ramal(string nombre, int kilometros, int tiempoRecorrido, int cantidadUnidades, string descripcion, DateTime Hora)
        {
            Nombre = nombre;
            Kilometros = kilometros;
            TiempoRecorrido = tiempoRecorrido;
            CantidadUnidades = cantidadUnidades;
            Descripcion = descripcion;
            HoraInicio = Hora;
        }

        // Metodos incluidas en la clase.
        int cantidad;
        public DataTable FrecuenciaPorRamal(int id)
        {
            List<CD_Ramal> Ramal = new List<CD_Ramal>();

            using (con = connectionBD.CreaInstacia().CrearConexion())
            {
                con.Open();
                SqlCommand comando = new SqlCommand("spFrecuenciaPorRamal", con);
                comando.Parameters.Add(new SqlParameter("@xid", con));
                comando.Parameters["@xid"].Value = id;
                comando.CommandType = CommandType.StoredProcedure;
                DataTable tablaDatos = new DataTable();
                SqlDataAdapter adaptador = new SqlDataAdapter(comando);
                adaptador.Fill(tablaDatos);
                con.Close();
                return tablaDatos;
            }

        }
        public int CantidadUnidadesRequeridas(int id) // paso un parametro y devuelve un unico valor
        {
            using (con = connectionBD.CreaInstacia().CrearConexion()) // realizo la conexion
            {
                
                using (con = connectionBD.CreaInstacia().CrearConexion())
                {
                    con.Open();
                    SqlCommand comando = new SqlCommand("spCantidadUnidades", con);
                    comando.CommandType = CommandType.StoredProcedure;
                    comando.Parameters.AddWithValue("@xid", id);

                    using (SqlDataReader reader = comando.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            cantidad = Convert.ToInt32(reader["CantidadUnidades"]);
                        }
                    }
                    con.Close();
                }
                return cantidad;
            }
        }



    }
}
