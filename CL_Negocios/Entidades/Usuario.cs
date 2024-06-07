using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CL_Negocios.Entidades
{
    internal class Usuario
    {
        public string Nombre_usuario { get; set; }
        public bool Estado { get; set; }
        public int Id_persona { get; set; }
        public string Password_user { get; set; }
        public DateTime Fecha_vence_pass { get; set; }
        public DateTime Fecha_user_temporal { get; set; }
        public DateTime Fecha_alta { get; set; }
        public int Id_familia { get; set; }
        
        public Usuario (string nombre_usuario, bool estado, int id_persona, string password_user, DateTime fecha_vence_pass, DateTime fecha_user_temporal, DateTime fecha_alta, int id_familia)
        {
            Nombre_usuario = nombre_usuario;
            Estado = estado;
            Id_persona = id_persona;
            Password_user = password_user;
            Fecha_vence_pass = fecha_vence_pass;
            Fecha_user_temporal = fecha_user_temporal;
            Fecha_alta = fecha_alta;
            Id_familia = id_familia;
        }
    }
}
