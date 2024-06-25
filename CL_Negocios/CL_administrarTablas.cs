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
       
        private CD_listarTablas _crearTablas; //creo una propiedad con un objeto Crear Registro
        public CL_administrarTablas()
        {
            _crearTablas = new CD_listarTablas(); //dentro del constructor instancio el objeto.    
        }


        public bool validarExistenciaDeUsuario (int valor)
        {
            int resultado = _crearTablas.ConsultarId(valor, "spExisteUsuario");
            
            if (resultado == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public DataTable permisosTorTipoDeUsuario(int id_familia)
        {
            DataTable data =  _crearTablas.tablaPermisosPorFamilia(id_familia, "spListarPermisosPorTipoUser");
            return data;

        }

        public DataTable permisosPorUsuario(int id_usuario)
        {
            DataTable data = _crearTablas.tablaPermisos(id_usuario, "spListaPermisosPorUsuario");
            return data;
        }

        public DataTable ListarUsuarios()
        {
            DataTable data = _crearTablas.listarQuery("spListarUsuarios");
            return data;
        }
    }
}
