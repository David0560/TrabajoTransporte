using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaServicios
{
    public class Unidades
    {
        public int Id {  get; set; }
        public string Nombre { get; set; }    
        public int Id_Vehiculo { get; set;}   
        
        public Unidades(int id, string Nombre, int id_Vehiculo)
        {
            this.Id = id;
            this.Nombre = Nombre;
            this.Id_Vehiculo = id_Vehiculo;
        }
    }
}
