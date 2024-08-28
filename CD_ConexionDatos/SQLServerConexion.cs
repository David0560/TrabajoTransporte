using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CD_ConexionDatos
{
    public class SQLServerConexion : ConexionDB
   {
        public SQLServerConexion(string cadenaConexion) : base(cadenaConexion) { }
       
        public override void Conectar()
        {
            try
            {

                using (SqlConnection conexion = new SqlConnection(cadenaConexion))
                {
                    conexion.Open();
                    Console.WriteLine("Conectado a la base de datos");
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Error al conectar a la base de datos: " + ex.Message);
            }
        }

        public override void Desconectar()
        {
            try
            {
                using (SqlConnection conexion = new SqlConnection(cadenaConexion))
                {
                    conexion.Close();
                    Console.WriteLine("Desconectado de la base de datos");
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Error al desconectar de la base de datos: " + ex.Message);
            }
        }
   }
}
