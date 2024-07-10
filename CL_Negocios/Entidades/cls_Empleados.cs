using CapaDatos.Entidades;
using System;
using System.Data;

namespace CapaLogicaNegocio.Entidades
{
    public class cls_Empleados
    {
        cls_EmpleadosQ datos_emp = new cls_EmpleadosQ();

        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public DateTime Fecha_Nacimiento { get; set; }
        public int Id_Documento_Ident { get; set; }
        public int Numero_Ident { get; set; }
        public int Id_Sexo { get; set; }
        public int Id_Localidad { get; set; }
        public string Calle { get; set; }
        public int Numero_Domicilio { get; set; }
        public string Email { get; set; }
        public int Id_Tarea { get; set; }

        public DataTable VerEmpleados(string datos = "")
        {
            return datos_emp.ObtenerEmpleados(datos);
        }

        public void AgregarEmpleado()
        {
            datos_emp.Nombre = Nombre;
            datos_emp.Apellido = Apellido;
            datos_emp.Id_Sexo = Id_Sexo;
            datos_emp.Id_Documento_Ident = Id_Documento_Ident;
            datos_emp.Numero_Ident = Numero_Ident;
            datos_emp.Fecha_Nacimiento = Fecha_Nacimiento;
            datos_emp.Email = Email;
            datos_emp.Id_Localidad = Id_Localidad;
            datos_emp.Calle = Calle;
            datos_emp.Numero_Domicilio = Numero_Domicilio;
            datos_emp.Id_Tarea = Id_Tarea;

            datos_emp.AgregarEmp();
        }

        public void ModificarEmpleado()
        {
            datos_emp.Id = Id;
            datos_emp.Nombre = Nombre;
            datos_emp.Apellido = Apellido;
            datos_emp.Id_Sexo = Id_Sexo;
            datos_emp.Id_Documento_Ident = Id_Documento_Ident;
            datos_emp.Numero_Ident = Numero_Ident;
            datos_emp.Fecha_Nacimiento = Fecha_Nacimiento;
            datos_emp.Email = Email;
            datos_emp.Id_Localidad = Id_Localidad;
            datos_emp.Calle = Calle;
            datos_emp.Numero_Domicilio = Numero_Domicilio;
            datos_emp.Id_Tarea = Id_Tarea;

            datos_emp.ModificarEmp();
        }
        public void EliminarEmpleado(int idEmpleado)
        {
            datos_emp.EliminarEmp(idEmpleado);
        }



    }
}