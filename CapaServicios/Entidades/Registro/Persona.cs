using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CL_Negocios.Entidades
{
    public class Persona
    {
        public int Id { get; set; }
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
        public int Telefono { get; set; }
        

        public Persona(int id, string nombre, string apellido, DateTime fecha_nac, int id_documento_iden, string numero_identidad, int id_sexo, int id_localidad, string calle, int numero_domicilio, string email, int id_tarea, int telefono)
        {
            this.Id = id;
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Fecha_nacimiento = fecha_nac;
            this.Id_documento_iden = id_documento_iden;
            this.Numero_identidad = numero_identidad;
            this.Id_sexo = id_sexo;
            this.Id_localidad = id_localidad;
            this.Calle = calle;
            this.Numero_domicilio = numero_domicilio;
            this.Email = email;
            this.Id_tarea = id_tarea;
            this.Telefono = telefono;


        }
        public Persona(string nombre,  string apellido, DateTime fecha_nac, int id_documento_iden, string numero_identidad, int id_sexo, int id_localidad, string calle, int numero_domicilio, string email, int telefono, int id_tarea)
        {
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Fecha_nacimiento = fecha_nac;
            this.Id_documento_iden = id_documento_iden;
            this.Numero_identidad = numero_identidad;
            this.Id_sexo = id_sexo;
            this.Id_localidad = id_localidad;
            this.Calle = calle;
            this.Numero_domicilio = numero_domicilio;
            this.Email = email;
            this.Id_tarea = id_tarea;
            this.Telefono = telefono;
        }
           public Persona(int id, string nombre, string apellido, DateTime fecha_nac, int id_documento_iden, string numero_identidad, int id_sexo, int id_localidad, string calle, int numero_domicilio, string email, int id_tarea)
        {
            this.Id = id;
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Fecha_nacimiento = fecha_nac;
            this.Id_documento_iden = id_documento_iden;
            this.Numero_identidad = numero_identidad;
            this.Id_sexo = id_sexo;
            this.Id_localidad = id_localidad;
            this.Calle = calle;
            this.Numero_domicilio = numero_domicilio;
            this.Email = email;
            this.Id_tarea = id_tarea;
        }
    }
}
