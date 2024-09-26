using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CapaServicios.Entidades
{
    public class RegistroConducir
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int Numero { get; set; }
        public DateTime FechaOtorgado { get; set; }
        public DateTime FechaVencimiento { get; set; }

        //
        // Metodos
        //
        public RegistroConducir(int id, DateTime fechaO, DateTime fechaV)
        {
            this.Id = id;
            this.FechaOtorgado = fechaO;
            this.FechaVencimiento = fechaV;
        }

        public RegistroConducir(int id, string nombre, string apellido, int numero, DateTime fechaVencimiento)
        {
            Id = id;
            Nombre = nombre;
            Apellido = apellido;
            Numero = numero;
            FechaVencimiento = fechaVencimiento;
        }
    }
}
