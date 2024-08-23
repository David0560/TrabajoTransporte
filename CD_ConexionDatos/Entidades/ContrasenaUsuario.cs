using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CD_ConexionDatos.Entidades
{
    public class ContrasenaUsuario
    {
        public int Id_usuario { get; set; }
        public string Contraseña { get; set; }
        public bool Sistema { get; set; }
        public DateTime Fecha { get; set; }

        public ContrasenaUsuario(int id_usuario, string contraseña, bool sistema, DateTime fecha)
        {
            this.Id_usuario = id_usuario;
            this.Contraseña = contraseña;
            this.Sistema = sistema;
            this.Fecha = fecha;
        }


        public ContrasenaUsuario(int id_usuario, string contraseña, bool sistema)
        {
            this.Id_usuario = id_usuario;
            this.Contraseña = contraseña;
            this.Sistema = sistema;
        }
    }
}
