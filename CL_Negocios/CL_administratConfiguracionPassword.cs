using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CD_ConexionDatos;

namespace CL_Negocios
{
    public class CL_administratConfiguracionPassword
    {
        private CD_ConfiguracionPassword _configuracionPassword;

        public CL_administratConfiguracionPassword()
        {
            _configuracionPassword = new CD_ConfiguracionPassword();//dentro del constructor instancio el objeto.    
        }
        
        public void GuardarConfiguracion(int minimo, int maximo, int intentos, bool mayusMinus, bool numerosLetras, bool especial, bool dosPasos, bool repetir, bool datosPersonales, bool preguntaSeguridad, bool nuevasPreguntas, bool bloqueoAuto, int diasBloqueo)
        {
            // Aquí podrías implementar lógica adicional antes de guardar en la base de datos, si es necesario

            // Llamar al método en la capa de acceso a datos para guardar la configuración
            _configuracionPassword.GuardarConfiguracion(minimo, maximo, intentos, mayusMinus, numerosLetras, especial, dosPasos, repetir, datosPersonales, preguntaSeguridad, nuevasPreguntas, bloqueoAuto, diasBloqueo);
        }

    }
}
