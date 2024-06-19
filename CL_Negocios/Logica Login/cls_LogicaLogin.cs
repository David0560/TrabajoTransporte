using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CL_Negocios.Logica_Login
{
    public class cls_LogicaLogin
    {
        private bool existe;

        cls_ConectarUser userLogin = new cls_ConectarUser();
        cls_Permisos Permisos = new cls_Permisos();
        public bool LoginUser(string user, string pass)
        {
            existe = userLogin.Login(user, pass);
            //existe = userLoguin.Login(user, pass);
            if (existe)
            {
                Permisos.Permisos(cls_UserCache.IdUsuario);
            }
            return existe;
        }
    }
}
