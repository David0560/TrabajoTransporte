using CapaServicios;
using CD_ConexionDatos.Entidades;
using CD_ConexionDatos;
using CD_ConexionDatos.Password;
using CL_Negocios.Entidades;
using CL_Negocios.Usuarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CL_Negocios.Login
{
    public class CL_AdministrarRecuperoPass
    {
        CD_RegistrosPassword ValidarPassword = new CD_RegistrosPassword();
        CS_contraseña Pass = new CS_contraseña();
        CL_AdministrarUsuario ActualizarRegistros = new CL_AdministrarUsuario();
        ConfiguracionPassword configure = new ConfiguracionPassword();
        CD_RegistrosPassword _dbPass = new CD_RegistrosPassword();

        // tablas contraseña (idUsuario, passSha, sistema 0, fecha)
        // actualizar codigoV (idU, valor)
        // actualizar password_user con text

        public bool ValidarNuevoPass(string NombreUser, string Password, string nuevopass)
        {
            configure.Configuracion(4, 8, true, true, false);
            int idUser = ValidarPassword.ObtenerIdUsuarioPorNombre(NombreUser); // id usuario
            // verificar si la ultima pass es igual a la ingresada.
            string validar = Pass.crearSHA256(NombreUser, Password);
            string passActual = ValidarPassword.ObtenerUltimoPass(idUser);
            if (validar == passActual)
            {
                string contraseña = Pass.crearSHA256(NombreUser, nuevopass);
                bool system = false;
                ContrasenaUsuario passUser = new ContrasenaUsuario(idUser, contraseña, system);
                _dbPass.GuardarNuevaContraseña(passUser);

                // Actualizar codigo verificador
                int codV = Convert.ToInt32(Pass.crearCodigoVerificador(contraseña));
                codigoVerificador codigoV = new codigoVerificador(idUser, codV);
                _dbPass.ActualizarCodigoV(codigoV);

                // actualizar passwordusurario
                _dbPass.actualizarPasswordUsuario(idUser, nuevopass);
                return true;
            }
            else
            {
                return false;
            }
            
        }
    }
}
