using CapaServicios.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaServicios.Entidades
{
    public class Proveedores
    {
        public int Id { get; set; }
        public string NombreEmpresa { get; set; }    
        public string Contacto { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }

        public string Ciudad {  get; set; }
        public string Pais { get; set; }    

        public string Calle { get; set; }
        public string Numero { get; set; }
        public int CP { get; set; }
    }
 
}



