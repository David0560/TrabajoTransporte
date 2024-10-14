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
        // Atributos privados
        private int id;
        private string nombreEmpresa;
        private string contacto;
        private int telefono;
        private string email;
        private string ciudad;
        private string pais;
        private string calle;
        private string numero;
        private int cp;

        // Propiedades públicas
        public int Id
        {
            get { return id; }
            private set { id = value; }
        }
        public string NombreEmpresa
        {
            get { return nombreEmpresa; }
            set { nombreEmpresa = value; }
        }
        public string Contacto
        {
            get { return contacto; }
            set { contacto = value; }
        }
        public int Telefono
        {
            get { return telefono; }
            set { telefono = value; }
        }
        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        public string Ciudad
        {
            get { return ciudad; }
            set { ciudad = value; }
        }
        public string Pais
        {
            get { return pais; }
            set { pais = value; }
        }
        public string Calle
        {
            get { return calle; }
            set { calle = value; }
        }
        public string Numero
        {
            get { return numero; }
            set { numero = value; }
        }
        public int CP
        {
            get { return cp; }
            set { cp = value; }
        }

        // Constructor
        public Proveedores(string nombreempresa, string contacto, int telefono, string email,
            string ciudad, string pais, string calle, string numero, int cp)
        {
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

        public Proveedores(int id, string nombreempresa, string contacto, int telefono, string email,
            string ciudad, string pais, string calle, string numero, int cp)
            : this(nombreempresa, contacto, telefono, email, ciudad, pais, calle, numero, cp) // Llama al otro constructor
        {
            this.Id = id;
        }
    }


}


