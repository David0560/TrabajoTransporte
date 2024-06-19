using CD_ConexionDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CL_Negocios
{
    public class CL_administrarTablas
    {
        private CD_listarTablas datosTabla = new CD_listarTablas();
        public bool validarExistenciaDeUsuario (int valor)
        {
            int resultado = datosTabla.ConsultarId(valor, "spExisteUsuario");
            
            if (resultado == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
            
        }
    }
}
