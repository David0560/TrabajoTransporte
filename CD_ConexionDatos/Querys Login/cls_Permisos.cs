using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CD_ConexionDatos.Querys_Login
{
    public class cls_Permisos : cls_EjecutarQ
    {
        public bool Permisos(int IdUser)
        {
            string sSql = "SELECT PermisosUsuarios.IdPermiso, Permisos.Funcionalidad" +
                          " FROM Permisos INNER JOIN PermisosUsuarios ON Permisos.[IdPermiso] = PermisosUsuarios.[IdPermiso]" +
                          " where IdUsuario = " + IdUser +
                          " and ISNULL(PermisosUsuarios.FechaBaja) " +
                          " and if(NOT ISNULL(PermisosUsuarios.AltaProvisoria), PermisosUsuarios.AltaProvisoria >= date(), ISNULL(PermisosUsuarios.AltaProvisoria))  ";

            DataTable DT = new DataTable();
            cls_EjecutarQ Ejecutar = new cls_EjecutarQ();
            DT = Ejecutar.ConsultaRead(sSql);

            if (DT.Rows.Count > 0)
            {
                foreach (DataRow row in DT.Rows)
                {
                    cls_UserCache.PermisosUser.Add(Convert.ToInt32(row[0].ToString()), row[1].ToString());
                }
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
