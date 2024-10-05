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
        public int Telefono { get; set; }
        public string Email { get; set; }
        public string Ciudad { get; set; }
        public string Pais { get; set; }
        public string Calle { get; set; }
        public string Numero { get; set; }
        public int CP { get; set; }

        public Proveedores(string nombreempresa, string contacto, int telefono, string email, 
            string ciudad, string pais, string calle, string numero, int cp)
        {
            //No sé si pasar este o no, pero se genera en la DB   this.Id = id;
            this.NombreEmpresa = nombreempresa;
            this.Contacto = contacto;
            this.Telefono = telefono;
            this.Email = email;
            this.Ciudad = ciudad;
            this.Pais = pais;
            this.Calle = calle;
            this.Numero = numero;
            this.CP = cp; 
        }
    }

}


