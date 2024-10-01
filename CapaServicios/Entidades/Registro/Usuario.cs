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


        public List<string> PreguntasSeguridad { get; set; }
        public List<string> RespuestasSeguridad { get; set; }

        public string fechaVP { get; set; }
        public string fechaVU  { get; set; }



        public Usuario(string nombre, int estado, int id_persona, int id_familia, DateTime? fecha_vence_pass, DateTime? fecha_user_temporal,  string password_user, int id, DateTime fecha_alta)
        {
            this.Id = id;
            this.Nombre = nombre;
            this.Estado = estado;
            this.Id_persona = id_persona;
            this.Password_user = password_user;
            this.Id_familia = id_familia;
            this.Fecha_vence_pass = fecha_vence_pass;
            this.Fecha_user_temporal = fecha_user_temporal;
            this.Fecha_alta = fecha_alta;
        }
        public Usuario(string nombre, int id_persona, int id_familia, DateTime? fecha_vence_pass, DateTime? fecha_user_temporal, int estado, string password_user)
        {
            this.Nombre = nombre;
            this.Estado = estado;
            this.Id_persona = id_persona;
            this.Password_user = password_user;
            this.Id_familia = id_familia;
            this.Fecha_vence_pass = fecha_vence_pass;
            this.Fecha_user_temporal = fecha_user_temporal;
        }

        public Usuario(string nombre, int id_persona, int id_familia, string fechaVencePass, string fechaVenceUsuario)
        {
            this.Nombre = nombre;
            this.Id_persona = id_persona;
            this.Id_familia = id_familia;
            this.fechaVP= fechaVencePass;
            this.fechaVU = fechaVenceUsuario;
        }

        public Usuario()
        {
            PreguntasSeguridad = new List<string>();
            RespuestasSeguridad = new List<string>();
        }

        // Método para validar las respuestas de seguridad del usuario
        public bool ValidarRespuestasSeguridad(List<string> respuestasUsuario)
        {
            if (respuestasUsuario.Count != RespuestasSeguridad.Count)
                return false;

            for (int i = 0; i < respuestasUsuario.Count; i++)
            {
                if (!respuestasUsuario[i].Equals(RespuestasSeguridad[i], StringComparison.Ordinal))
                {
                    return false;
                }
            }
            return true;
        }

    }
}
