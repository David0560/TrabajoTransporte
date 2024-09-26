using CapaServicios.Entidades;
using CD_ConexionDatos;
using CD_ConexionDatos.ActualizarRegistros;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;

namespace CL_Negocios.ActualizarRegistros
{
    public class CL_AdministrarRegistros
    {
        private CD_ActualizarRegistros _ActualizarRegistro; //propiedad de la clase

        public CL_AdministrarRegistros() 
        {
            _ActualizarRegistro = new CD_ActualizarRegistros();//dentro del constructor el objeto.    
        }

        //metodos VTV
        public DataTable CargarRegistrosVehiculos()
        {
            return _ActualizarRegistro.ObtenerTablaVtvVenciada();
        }
        public bool ActualizarVtv(int id, DateTime fechaO, DateTime fechaV)
        {
            VerificacionVtv datos = new VerificacionVtv(id, fechaO, fechaV);

            if (_ActualizarRegistro.ActualizarVtv(datos))
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        // metodo RegistroCond
        public DataTable CargarRegistrosCond()
        {
            return _ActualizarRegistro.ObtenerTablaRegConducirPorVencer();
        }
        public bool ActualizarRegistroCond(int id, DateTime fechaO, DateTime fechaV)
        {
            RegistroConducir datos = new RegistroConducir(id, fechaO, fechaV);

            if (_ActualizarRegistro.ActualizarRegConducir(datos))
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public bool valores()
        {
            int coches = _ActualizarRegistro.CantVehiculosActualizar();
            int choferes = _ActualizarRegistro.CantRegistroActualizar();
            int total = coches + choferes;
            if (total > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
