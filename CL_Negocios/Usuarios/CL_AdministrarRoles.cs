using CD_ConexionDatos;
using CD_ConexionDatos.Usuarios;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CL_Negocios.Usuarios
{
    public class CL_AdministrarRoles
    {
        private CD_RolesFamiliasUsuarios _rolfa;
        
        public CL_AdministrarRoles() 
        {
            _rolfa = new CD_RolesFamiliasUsuarios();
        }
        //
        // Asignar nuevos roles a grupos de familia
        //
        public void cargarNuevoRol(int id1, int id2)
        {
            _rolfa.cargarNuevoRol(id1, id2);
        }
        public void EliminarRolEnFamilia(int id)
        {
            _rolfa.EliminarFamiliaRol(id);
        }
        //
        // asignar nuevos roles a usuarios
        //
        public void cargarNuevoRolUsuario(int idU, int idFR)
        {
            DateTime fecha = DateTime.Now;

            _rolfa.NuevoRolAUsuario(idU, idFR, fecha);
        }
        public void NuevoRolConVencimiento(int idU, int idFR, DateTime fechav)
        {
            DateTime fecha = DateTime.Now;

            _rolfa.NuevoRolAUsuarioConVencimiento(idU, idFR,fecha, fechav);
        }
        public void ActualizarFechaVenPermiso(int idP, DateTime fechaV)
        {
            _rolfa.ModificarRolFechaVencimiento(idP, fechaV);
        }
        public void eliminarPersmisoAUsuario(int idP)
        {
            _rolfa.EliminarRolAUsuario(idP);
        }
    }
}
