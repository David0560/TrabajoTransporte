using CapaServicios;
using CD_ConexionDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CL_Negocios
{
    public class CL_administrarLogin
    {
        CS_contraseña contraseña = new CS_contraseña();

        private CD_loginUsuario _revisarLogin; //creo una propiedad con un objeto Crear Registro

        public CL_administrarLogin()
        {
            _revisarLogin = new CD_loginUsuario();//dentro del constructor instancio el objeto.    
        }

        public int UbicarUsuario(string nombreUsuario, string password)
        {
            int respuesta;
            int valor = _revisarLogin.ubicarUsuarioExistent(nombreUsuario);
            if (valor == 0)
            {
                respuesta = 1; // no se encontro usuario con ese nombre.
                return respuesta;
            }
            else
            {
                String ContraseñaUsuario = contraseña.crearSHA256(nombreUsuario, password);
                int codigo = contraseña.crearCodigoVerificador(ContraseñaUsuario);

                DataTable tablaValores = _revisarLogin.valoresParaLogin(valor);

                if (ContraseñaUsuario == tablaValores.Rows[0][0].ToString()) // valido password
                {
                    if (codigo == Convert.ToInt32(tablaValores.Rows[0][2])) // valido codigo verificador
                    {
                        if (Convert.ToInt32(tablaValores.Rows[0][1]) == 1) // valido estado de usuario
                        {
                            respuesta = 4; // acceso correcto
                            _revisarLogin.CargarUsuarioLogeado(valor);// cargo en cache al usuario
                            return respuesta;
                        }
                    }
                    else
                    {
                        respuesta = 3;// bloqueo de usuario por datos erroneros de seguridad.
                        return respuesta;
                    }
                }
                else
                {
                    respuesta = 2; // password del usuario incorrecto
                    return respuesta;
                }
                return 0; // El ususario se encuntra bloqueado 
            }
        }



    }
}
