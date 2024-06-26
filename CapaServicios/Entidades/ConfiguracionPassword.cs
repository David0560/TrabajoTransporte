using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace CapaServicios
{
    public class ConfiguracionPassword
    {
        public int Minimo { get; set; }
        public int Maximo { get; set; }
        public bool Mayuscula { get; set; }
        public bool Numero { get; set; }
        public bool Especial { get; set; }

        public void Configuracion(int min, int max, bool mayu, bool num, bool esp)
        {
            this.Minimo = min;
            this.Maximo = max;
            this.Mayuscula = mayu;
            this.Numero = num;
            this.Especial = esp;
        }


    }
}
