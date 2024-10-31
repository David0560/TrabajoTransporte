using CapaSesion.Cache;
using CL_Negocios.Entidades;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CD_ConexionDatos
{
    public class CD_RepositorioDePermisos
    {
        SqlConnection con = new SqlConnection(); // instancio la cadena para la conexion

        public List<PermisosUsuario> obtenerListaPermisoU (int idU)
        {
            List<PermisosUsuario> per = new List<PermisosUsuario>();

            using (con = connectionBD.CreaInstacia().CrearConexion())
            {
                using (SqlCommand command = new SqlCommand("spListaPermisoUsuario", con))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@xidUsuario", idU);
                    con.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            PermisosUsuario PUser = new PermisosUsuario()
                            {
                                Id = reader.GetInt32(1),
                                IdFamilia = reader.GetInt32(0),
                                NombreRol = reader.GetString(2)
                            };

                            per.Add(PUser);
                        }

                    }
                }

            }
            return per;
        }

    }
}
