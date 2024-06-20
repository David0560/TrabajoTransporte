using CL_Negocios.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CD_ConexionDatos;

namespace CL_Negocios
{
    public class CL_administrarRegistros
    {
        CD_crearRegistros registros = new CD_crearRegistros();
        public CL_administrarRegistros() { }

        public void insertarNuevoUsuario(Usuario usuario)
        {
            registros.guardarNuevoUsuario(usuario);
        }

    }
}