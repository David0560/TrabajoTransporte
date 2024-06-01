using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics.SymbolStore;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CD_ConexionDatos
{
    public class connectionBD
    {
        // delclaro variables para crear la conexion.
        private string Base;
        private string Servidor;
        private string Usuario;
        private string Clave;
        private bool Seguridad;

        public static connectionBD CreaInstacia()
        {
            if (con == null)
            {
                con = new connectionBD();
            }
            return con;
        }

        // crear un objeto de tipo conecxion es estatica para no perder la informacion
        // es para conpartir y realiza la conexion a la base de datos
        private static connectionBD con = null; //variable de conexion iniciada con un valor nulo
        
        private connectionBD() //constructor de clase, contiene los valores de las variables que va a tener la conexion
        {
            // esto se usa para que la segurida sea mejor ya que las variables se encuentran en el contructor provado
            //

            //---------------------------------//
            // ustendes tendrian que cargar    //
            // los valores que tiene en        //
            // su maquina, para poder         //
            // hacer la conexion.             //
            //--------------------------------//

            this.Base = "BD_Trasnporte";
            this.Servidor = "DESKTOP-8ROL9DF";
            this.Usuario = "DESKTOP-8ROL9DF//Morinigo David";
            this.Clave = "";
            this.Seguridad = true;
        }

        // metodo para devolver el string de conexion
        public SqlConnection CrearConexion() 
        {
            SqlConnection Cadena = new SqlConnection(); // instancio la cadena para la conexion
            
            // manera para controlar los errores
            try
            {
                // creo la variable de conexion
                Cadena.ConnectionString = $"Server={this.Servidor}; Database={this.Base}; ";
                // validar tipo de seguridad para conctarnos a SQL
                if (this.Seguridad) 
                {
                    //si es por windows
                    Cadena.ConnectionString = Cadena.ConnectionString + "Integrated Security = SSPI";// tipo de seguridad que utiliza windows
                }
                else
                {
                    Cadena.ConnectionString = Cadena.ConnectionString + $"User Id = {this.Usuario}; Password={this.Clave}"; // seguridad requeridad por SQL server
                }
            }
            catch (Exception ex)
            {
                Cadena = null; //por un problema de error cadena vuelve a ser null
                throw ex; //mostramos un mensaje con el error de la conexion.
            }
            return Cadena;// va devolver cadena.
        }  
    }
}
