using CapaServicios.Entidades;
using CL_Negocios.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CD_ConexionDatos.ActualizarRegistros
{
    public class CD_ActualizarRegistros
    {
        SqlConnection con = new SqlConnection(); // instancio la cadena para la conexion
        SqlDataReader dr; // permite lee la secuencia de filas en una tabla "dr es una variable"
        DataTable dt = new DataTable(); // instancia un objeto tipo tabla
        int cantidad;
        //
        //Metodos
        //
        //**** VTV 
        public bool ActualizarVtv(VerificacionVtv datos)
        {
            try
            {
                using (con = connectionBD.CreaInstacia().CrearConexion())
                {
                    con.Open();
                    using (SqlCommand comando = new SqlCommand("spActualizarVtv", con))
                    {
                        comando.CommandType = CommandType.StoredProcedure; // importante colocar esta linea para actualizar el registros
                        comando.Parameters.AddWithValue("@xId", datos.Id);
                        comando.Parameters.AddWithValue("@xFechaOtorgado", datos.FechaOtorgado);
                        comando.Parameters.AddWithValue("@xFechaVencimiento", datos.FechaVencimiento);

                        comando.ExecuteNonQuery();
                        con.Close();
                    }
                }
                return true;
            }
            catch (Exception)
            {
                // Manejar la excepción según sea necesario
                return false; // Actualización fallida
                throw;
            }
        }
        public List<VerificacionVtv> ObtenerListaVtvVencida() // forma para cargar una lista desde la base de datos 
        {
            List<VerificacionVtv> listaVtv = new List<VerificacionVtv>();

            using (con = connectionBD.CreaInstacia().CrearConexion())
            {
                con.Open();

                using (SqlCommand command = new SqlCommand("sp_RegistrosCochePorVencer", con))
                {
                    using (SqlDataReader reader = command.ExecuteReader()) //obtengo la tabla con los registros de la query
                    {
                        while (reader.Read())// leo la tabla y los cargo un variables
                        {
                            // las propiedades son las que se encuentran en la entidad del objeto (propiedades)

                            int Id = Convert.ToInt32(reader["Id"]);
                            string Nombre = Convert.ToString(reader["Nombre"]);
                            string Dominio = Convert.ToString(reader["Dominio"]);
                            string Modelo = Convert.ToString(reader["Modelo"]);
                            DateTime FechaV = Convert.ToDateTime(reader["FechaVencimiento"]);


                            VerificacionVtv VtvVence = new VerificacionVtv(Id, Nombre, Dominio, Modelo, FechaV); //cargo las variables usando el constructor

                            listaVtv.Add(VtvVence); // guardo los objetos en la lista
                        }
                        return listaVtv;// devuelve la lista con los objetos
                    }
                }
            }

        }
        public DataTable ObtenerTablaVtvVenciada()
        {
            try
            {
                // primero creo una instancia de la clase connectionBD luego activo activo el constructor y por ultimo llamo al metodo para crear la conexion.
                using (con = connectionBD.CreaInstacia().CrearConexion())// nos devuelve el string de conexin a sql
                {
                    using (SqlCommand comando = new SqlCommand("spRegistroCochePorVencer", con))
                    {
                        con.Open();// abro la conexion.
                        dr = comando.ExecuteReader(); // comando va a tener los resultados de la consulta y los lleva atraves del executereade estos los voy a cargar en la lista.
                        dt.Load(dr); // la variable tabla (dataTable) va a cargar lo que tiene lista
                        return dt; // devuelvo tabla que lo contiene en memora depues lo mando al grid
                    }; // preparo la BD para que reciva la consulta (consulta, conexion)
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
        }
        public int CantVehiculosActualizar()
        {
            using (con = connectionBD.CreaInstacia().CrearConexion()) // realizo la conexion
            {
                using (SqlCommand comando = new SqlCommand("spContarRegistrosVTv", con))
                {
                    comando.CommandType = CommandType.StoredProcedure;
                    con.Open();// abro la conexion.
                    using (SqlDataReader leer = comando.ExecuteReader())
                    {
                        while (leer.Read())
                        {
                            cantidad = Convert.ToInt32(leer["TotalRegistros"]);
                        }
                    }
                }
            }
            return cantidad;
        }

        //**** RegistroCond
        public DataTable ObtenerTablaRegConducirPorVencer()
        {
            try
            {
                // primero creo una instancia de la clase connectionBD luego activo activo el constructor y por ultimo llamo al metodo para crear la conexion.
                using (con = connectionBD.CreaInstacia().CrearConexion())// nos devuelve el string de conexin a sql
                {
                    using (SqlCommand comando = new SqlCommand("spRegistroCondPorVencer", con))
                    {
                        con.Open();// abro la conexion.
                        dr = comando.ExecuteReader(); // comando va a tener los resultados de la consulta y los lleva atraves del executereade estos los voy a cargar en la lista.
                        dt.Load(dr); // la variable tabla (dataTable) va a cargar lo que tiene lista
                        return dt; // devuelvo tabla que lo contiene en memora depues lo mando al grid
                    }; // preparo la BD para que reciva la consulta (consulta, conexion)
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
        }
        public bool ActualizarRegConducir(RegistroConducir datos)
        {
            try
            {
                using (con = connectionBD.CreaInstacia().CrearConexion())
                {
                    con.Open();
                    using (SqlCommand comando = new SqlCommand("spActualizarRegConducir", con))
                    {
                        comando.CommandType = CommandType.StoredProcedure; // importante colocar esta linea para actualizar el registros
                        comando.Parameters.AddWithValue("@xId", datos.Id);
                        comando.Parameters.AddWithValue("@xFechaOtorgado", datos.FechaOtorgado);
                        comando.Parameters.AddWithValue("@xFechaVencimiento", datos.FechaVencimiento);

                        comando.ExecuteNonQuery();
                        con.Close();
                    }
                }
                return true;
            }
            catch (Exception)
            {
                // Manejar la excepción según sea necesario
                return false; // Actualización fallida
                throw;
            }
        }
        public int CantRegistroActualizar()
        {
            using (con = connectionBD.CreaInstacia().CrearConexion()) // realizo la conexion
            {
                using (SqlCommand comando = new SqlCommand("spContarRegistrosConducir", con))
                {
                    comando.CommandType = CommandType.StoredProcedure;
                    con.Open();// abro la conexion.
                    using (SqlDataReader leer = comando.ExecuteReader())
                    {
                        while (leer.Read())
                        {
                            cantidad = Convert.ToInt32(leer["TotalRegistros"]);
                        }
                    }
                }
            }
            return cantidad;
        }
    }


}

