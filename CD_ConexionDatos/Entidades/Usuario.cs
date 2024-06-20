using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CL_Negocios.Entidades
{
    public class Usuario
    {
        public int Id { get; set; }
        public string Nombre{ get; set; }
        public int Estado { get; set; }
        public int Id_persona { get; set; }
        public string Password_user { get; set; }
        public DateTime? Fecha_vence_pass { get; set; }
        public DateTime? Fecha_user_temporal { get; set; }
        public DateTime Fecha_alta { get; set; }
        public int Id_familia { get; set; }

        public Usuario(string nombre, int estado, int id_persona, string password_user, int id_familia, DateTime fecha_vence_pass, DateTime fecha_user_temporal)
        {
            this.Nombre = nombre;
            this.Estado = estado;
            this.Id_persona = id_persona;
            this.Password_user = password_user;
            this.Id_familia = id_familia;
            this.Fecha_vence_pass = fecha_vence_pass;
            this.Fecha_user_temporal = fecha_user_temporal;
        }

        public Usuario(string nombre, int estado, int id_persona, string password_user, int id_familia)
        {
            this.Nombre = nombre;
            this.Estado = estado;
            this.Id_persona = id_persona;
            this.Password_user = password_user;
            this.Id_familia = id_familia;
        }

    }
}
