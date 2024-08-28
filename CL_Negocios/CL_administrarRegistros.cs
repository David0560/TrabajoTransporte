using CL_Negocios.Entidades;
using System;
using CD_ConexionDatos;
using CapaServicios;
using System.Windows.Forms;
using CD_ConexionDatos.Entidades;

namespace CL_Negocios
{
    public class CL_administrarRegistros
    {
        CS_contraseña password = new CS_contraseña();


        private CD_crearRegistros _crearRegistros; //creo una propiedad con un objeto Crear Registro
        public CL_administrarRegistros()
        {
            _crearRegistros = new CD_crearRegistros(); //dentro del constructor instancio el objeto.    
        }
    }
}