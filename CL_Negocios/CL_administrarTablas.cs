using CD_ConexionDatos;
using System;
using System.Collections.Generic;
using System.Data;
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

        public DataTable permisosPorFamilia(int id_familia)
        {
            DataTable data =  datosTabla.tablaPermisosPorFamilia(id_familia, "spListarPermisosPorTipoUser");
            return data;

        }

        public DataTable permisosPorUsuario(int id_usuario)
        {
            DataTable data = datosTabla.tablaPermisos(id_usuario, "spListaPermisosPorUsuario");
            return data;
        }
    }
}
