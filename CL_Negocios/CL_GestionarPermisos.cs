using CapaSesion.Cache;
using CD_ConexionDatos;
using CL_Negocios.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CL_Negocios
{
    public class CL_GestionarPermisos
    {
        private CD_RepositorioDePermisos repositorioPermisos;

        public CL_GestionarPermisos()
        {
            repositorioPermisos = new CD_RepositorioDePermisos();
        }

        public List<PermisosUsuario> obtenerPermisos(int idU)
        {
            return repositorioPermisos.obtenerListaPermisoU(idU);
        }
    }
}
