using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CD_ConexionDatos;
namespace CL_Negocios
{
    public class ConfiguracionPasswordBLL
    {
        private readonly ConfiguracionPasswordDAL configuracionPasswordDAL;

        public ConfiguracionPasswordBLL(ConfiguracionPasswordDAL configuracionPasswordDAL)
        {
            this.configuracionPasswordDAL = configuracionPasswordDAL;
        }
        public void GuardarConfiguracion(int minimo, int maximo, int intentos, bool mayusMinus, bool numerosLetras, bool especial, bool dosPasos, bool repetir, bool datosPersonales, bool preguntaSeguridad, bool nuevasPreguntas, bool bloqueoAuto, int diasBloqueo)
        {
            // Aquí podrías implementar lógica adicional antes de guardar en la base de datos, si es necesario

            // Llamar al método en la capa de acceso a datos para guardar la configuración
            configuracionPasswordDAL.GuardarConfiguracion(minimo, maximo, intentos, mayusMinus, numerosLetras, especial, dosPasos, repetir, datosPersonales, preguntaSeguridad, nuevasPreguntas, bloqueoAuto, diasBloqueo);
        }
    }
}
