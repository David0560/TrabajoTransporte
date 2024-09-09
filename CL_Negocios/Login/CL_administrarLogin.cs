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
                        int estadoUsuario = Convert.ToInt32(tablaValores.Rows[0][1]); // obtener el estado del usuario
                        int contraseñaSistema = Convert.ToInt32(tablaValores.Rows[0][3]); // obtener el valor de la columna sistema
                        bool tienePreguntas = UsuarioTienePreguntas(nombreUsuario); // verificar si el usuario tiene preguntas de seguridad

                        if (estadoUsuario == 1) // validar estado de usuario
                        {
                            if (contraseñaSistema == 1 && !tienePreguntas) // primera vez que ingresa
                            {
                                respuesta = 5; // primera vez que ingresa al sistema
                            }
                            else if (contraseñaSistema == 1 && tienePreguntas) // sistema es 1 y tiene preguntas cargadas
                            {
                                respuesta = 6; // tiene que cambiar la contraseña
                            }
                            else
                            {
                                respuesta = 4; // acceso correcto
                                _revisarLogin.CargarUsuarioLogeado(valor); // cargar en caché al usuario
                            }
                        }
                        else
                        {
                            respuesta = 3; // bloqueo de usuario por datos erróneos de seguridad
                        }
                    }
                    else
                    {
                        respuesta = 2; // password del usuario incorrecto
                    }
                }
                else
                {
                    respuesta = 2; // password del usuario incorrecto
                }

                return respuesta; // retornar la respuesta según el estado del usuario
            }
        }

        // Método para verificar si un usuario tiene preguntas de seguridad cargadas
        private bool UsuarioTienePreguntas(string nombreUsuario)
        {
            // Utilizo el método existente para verificar si el usuario tiene preguntas de seguridad
            return new CL_administrarPreguntasUsuario().UsuarioTienePreguntas(nombreUsuario);
        }


    }
}
