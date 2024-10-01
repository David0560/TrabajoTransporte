using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaServicios
{
    public class Unidad
    {
        public int Id {  get; set; }
        public string Nombre { get; set; }    
        public int Id_Vehiculo { get; set;}  
        
        public Unidad(int id, string nombre, int id_vehiculo)
        {
            this.Id = id;
            this.Nombre = nombre;
            this.Id_Vehiculo = id_vehiculo;
        }
    }
}
