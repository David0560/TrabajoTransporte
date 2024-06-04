using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CL_Negocios.Entidades
{
    internal class Persona
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public DateTime Fecha_nacimiento { get; set; }
        public int Id_documento_iden { get; set; }
        public string Numero_identidad { get; set; }
        public int Id_sexo { get; set; }
        public int Id_localidad { get; set; }
        public string Calle { get; set; }
        public int Numero_domicilio { get; set; }
        public string Email { get; set; }
        public int Id_tarea { get; set;}

        public Persona(string nombre,  string apellido, DateTime fecha_nac, int id_documento_iden, string numero_identidad, int id_sexo, int id_localidad, string calle, int numero_domicilio, string email, int id_tarea)
        {
            Nombre = nombre;
            Apellido = apellido;
            Fecha_nacimiento = fecha_nac;
            Id_documento_iden = id_documento_iden;
            Numero_identidad = numero_identidad;
            Id_sexo = id_sexo;
            Id_localidad = id_localidad;
            Calle = calle;
            Numero_domicilio = numero_domicilio;
            Email = email;
            Id_tarea = id_tarea;
        }
    }
}
