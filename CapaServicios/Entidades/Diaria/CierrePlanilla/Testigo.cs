using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaServicios.Entidades.Diaria.CierrePlanilla
{
    public class Testigo
    {
        public string Apellido { get; set; }
        public string Nombre { get; set; }
        public int DNI { get; set; }
        public string Domicilio { get; set; }
        public int Numero { get; set; }
        public int Telefono { get; set; }

        public Testigo(string apellido, string nombre, int dNI, string domicilio, int numero, int telefono)
        {
            Apellido = apellido;
            Nombre = nombre;
            DNI = dNI;
            Domicilio = domicilio;
            Numero = numero;
            Telefono = telefono;
        }
    }
}
