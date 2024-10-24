using CapaServicios;
using CD_ConexionDatos;
using CL_Negocios.Usuarios;
using Microsoft.Win32;
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
        CL_AdministrarUsuario user = new CL_AdministrarUsuario();

        private CD_loginUsuario _revisarLogin; //creo una propiedad con un objeto Crear Registro

        public CL_administrarLogin()
        {
            _revisarLogin = new CD_loginUsuario();//dentro del constructor instancio el objeto.    
        }

        public int UbicarUsuario(string nombreUsuario, string password)
        {
            int respuesta;
            int valor = _revisarLogin.ubicarUsuarioExistent(nombreUsuario); // id usuario
            if (valor != 0)
            {
                // tengo usuario
                // saber si password coincide,

                String ContraseñaUsuario = contraseña.crearSHA256(nombreUsuario, password); // password SHA256
                int codigo = contraseña.crearCodigoVerificador(ContraseñaUsuario); // codigo V

                DataTable tablaValores = _revisarLogin.valoresParaLogin(valor);

                if (ContraseñaUsuario == tablaValores.Rows[0][0].ToString()) // valido password
                {
                    if (codigo == Convert.ToInt32(tablaValores.Rows[0][2])) // valido codigo verificador
                    {
                        int estadoUsuario = Convert.ToInt32(tablaValores.Rows[0][1]); // obtener el estado del usuario
                        int contraseñaSistema = Convert.ToInt32(tablaValores.Rows[0][3]); // obtener el valor de la columna sistema
                        bool tienePreguntas = UsuarioTienePreguntas(nombreUsuario); // verificar si el usuario tiene preguntas de seguridad

                        if (estadoUsuario == 1) // validar estado de usuario Activo.
                        {                         
                            if (contraseñaSistema == 1 && !tienePreguntas) // primera vez que ingresa
                            {
                                _revisarLogin.primerIngresoNuevoIntento(valor); // crear registro de intentos en 0.
                                respuesta = 5; // primera vez que ingresa al sistema
                            }
                            else if (contraseñaSistema == 1 && tienePreguntas) // sistema es 1 y tiene preguntas cargadas
                            {
                                respuesta = 6; // tiene que cambiar la contraseña
                            }
                            else
                            {
                                respuesta = 4; // acceso correcto
                                _revisarLogin.AumentarIntentosDeUsuario(valor, 0);// vuelve el registro a 0 intentos al ingresar al sistema
                                _revisarLogin.CargarUsuarioLogeado(valor); // cargar en caché al usuario
                            }
                        }
                        else
                        {
                            respuesta = 3; // valor estado usuario inactivo
                        }
                    }
                    else
                    {
                        respuesta = 2; // el CodigoV no coincide con el de la BD
                        user.bloquearUsuario(valor, "0"); // codigoV incorrecto con el almacenado.
                        // deberia cambiar el password y el CV.
                        // revisar la logica para identificar como se puede
                        // generar nuevar contraseña y nuevo CV.
                    }
                }
                else
                {
                    // revisar si mi usuario tiene registros nuevo de error de intentos
                    if (_revisarLogin.cantidadDeIntentosDeUsuario(valor)>=0 && _revisarLogin.cantidadDeIntentosDeUsuario(valor)<2) // si intentos es >0 && < 3 entonces cargar +1 a cantidada
                    {
                        int cantTotal = _revisarLogin.cantidadDeIntentosDeUsuario(valor)+1;
                        _revisarLogin.AumentarIntentosDeUsuario(valor, cantTotal);
                    }
                    else // bloquear usuario.
                    {
                        user.bloquearUsuario(valor, "0"); // cantidad de intentos superados.
                    }
                    respuesta = 2; // password del usuario incorrecto
                }

                return respuesta; // retornar la respuesta según el estado del usuario
                                
            }
            else
            {
                respuesta = 1; // no se encontro usuario con ese nombre.
                return respuesta;
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
