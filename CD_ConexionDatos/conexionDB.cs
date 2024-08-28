using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CD_ConexionDatos
{
    public abstract class ConexionDB
    {
        protected string cadenaConexion;
        public ConexionDB(String CadenaConexion)
        {
            this.cadenaConexion = CadenaConexion;
        }

        public abstract void Conectar();
        public abstract void Desconectar();
    }
}
