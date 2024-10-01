using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaServicios.Entidades
{
    public class ContolUnidad
    {
        public bool Luces { get; set; }
        public bool Cinturon { get; set; }
        public bool Frenos { get; set; }
        public bool PresionAire { get; set; }
        public bool LimpiaParabrisas { get; set; }
        public bool Desenpañador { get; set; }
        public bool Espejos { get; set; }
        public bool Puerta { get; set; }
        public bool Bosina { get; set; }
        public bool FrenoDeMano { get; set; }
        public bool Matafuego { get; set; }
        public bool VigiaMotor { get; set; }
        public bool CamaraSeguridad { get; set; }

        public ContolUnidad(bool luces, bool cinturon, bool frenos, bool presionaire, bool limpiaparabrisas, bool desenpañador, 
            bool espejos, bool puerta, bool bosina, bool frenodemano, bool matafuego, bool vigiamotor, bool camara)
        {
            this.Luces = luces;
            this.Cinturon = cinturon;
            this.Frenos = frenos;
            this.PresionAire = presionaire;
            this.LimpiaParabrisas= limpiaparabrisas;
            this.Desenpañador = desenpañador;
            this.Espejos = espejos;
            this.Puerta = puerta;
            this.Bosina = bosina;
            this.FrenoDeMano = frenodemano;
            this.Matafuego = matafuego;
            this.VigiaMotor = vigiamotor;
            this.CamaraSeguridad = camara;
        }
    }
}
