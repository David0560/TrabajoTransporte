using System;

namespace CD_ConexionDatos.Entidades
{
    public class Ramal
    { 
            public int Id { get; set; }
            public string Nombre { get; set; }
            public int Kilometros { get; set; }
            public TimeSpan Hora { get; set; }
            public int CantidadSalidas { get; set; }

            public Ramal(int id, string nombre, int kilom, TimeSpan hora, int cantSalidas)
            {
                this.Id = id;
                this.Nombre = nombre;
                this.Kilometros = kilom;
                this.Hora = hora;
                this.CantidadSalidas = cantSalidas;
            }
        
    }
}