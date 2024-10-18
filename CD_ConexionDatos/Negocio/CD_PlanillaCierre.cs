using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaServicios.Entidades.Diaria;
using CL_Negocios.Entidades;
using CapaServicios.Entidades;
using CapaServicios.Entidades.Diaria.CierrePlanilla;

namespace CD_ConexionDatos.Negocio
{
    public class CD_PlanillaCierre
    {
        SqlConnection con = new SqlConnection(); // instancio la cadena para la conexion
        public DataTable ListaDeRegistrosCierre(DateTime fecha)
        {
            using (con = connectionBD.CreaInstacia().CrearConexion())
            {
                con.Open();
                SqlCommand comando = new SqlCommand("spListaParaCierre", con);

                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add(new SqlParameter("@xfecha", con));
                comando.Parameters["@xfecha"].Value = fecha;
                comando.CommandType = CommandType.StoredProcedure;
                DataTable lista = new DataTable();
                SqlDataAdapter adaptador = new SqlDataAdapter(comando);
                adaptador.Fill(lista);
                con.Close();
                return lista;
            }
        }

        public DataTable registroCierre(int id)
        {
            using (con = connectionBD.CreaInstacia().CrearConexion())
            {
                con.Open();
                SqlCommand comando = new SqlCommand("spObtenerRegistroCierre", con);

                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add(new SqlParameter("@xid", con));
                comando.Parameters["@xid"].Value = id;
                comando.CommandType = CommandType.StoredProcedure;
                DataTable lista = new DataTable();
                SqlDataAdapter adaptador = new SqlDataAdapter(comando);
                adaptador.Fill(lista);
                con.Close();
                return lista;
            }
        }

        public bool GuardarRegitrosCierre( CierrePlanillaLaboral objeto)
        {
             using (con = connectionBD.CreaInstacia().CrearConexion())
            {
                con.Open();

                SqlCommand comando = new SqlCommand("spGuardarNuevoCierre", con)
                {
                    CommandType = CommandType.StoredProcedure
                };
                comando.Parameters.AddWithValue("@xid", objeto.Id);
                comando.Parameters.AddWithValue("@xhoraCierre", objeto.HoraCierre);
                comando.Parameters.AddWithValue("@xkmLlegada", objeto.KmLlegada);
                comando.Parameters.AddWithValue("@xCombuLlegada", objeto.CombustibleLlegada);

                comando.ExecuteNonQuery();

                con.Close();
                return true;
            }
    
        }

        public bool GuardarContUni(ContolUnidad objeto, int id)
        {
            using (con = connectionBD.CreaInstacia().CrearConexion())
            {
                con.Open();

                SqlCommand comando = new SqlCommand("spGuardarNuevoControlUnidad", con)
                {
                    CommandType = CommandType.StoredProcedure
                };
                comando.Parameters.AddWithValue("@xluces", objeto.Luces);
                comando.Parameters.AddWithValue("@xcinturon", objeto.Cinturon);
                comando.Parameters.AddWithValue("@xfrenos", objeto.Frenos);
                comando.Parameters.AddWithValue("@xpresionAire", objeto.PresionAire);
                comando.Parameters.AddWithValue("@xlimpiaParabrisas", objeto.LimpiaParabrisas);
                comando.Parameters.AddWithValue("@xdesenpañador", objeto.Desenpañador);
                comando.Parameters.AddWithValue("@xespejos", objeto.Espejos);
                comando.Parameters.AddWithValue("@xpuerta", objeto.Puerta);
                comando.Parameters.AddWithValue("@bosina", objeto.Bosina);
                comando.Parameters.AddWithValue("@xfrenoDeMano", objeto.FrenoDeMano);
                comando.Parameters.AddWithValue("@xmatafuego", objeto.Matafuego);
                comando.Parameters.AddWithValue("@xVigiaMotor", objeto.VigiaMotor);
                comando.Parameters.AddWithValue("@xcamaraSeguridad", objeto.CamaraSeguridad);
                comando.Parameters.AddWithValue("@xcierrep", id);

                comando.ExecuteNonQuery();

                con.Close();
                return true;
            }

        }
        public void GuardarCortes(CorteViaPublica objeto , int id)
        {
            using (con = connectionBD.CreaInstacia().CrearConexion())
            {
                con.Open();

                SqlCommand comando = new SqlCommand("spGuardarNuevoCorte", con)
                {
                    CommandType = CommandType.StoredProcedure
                };
                comando.Parameters.AddWithValue("@xhora", objeto.Hora);
                comando.Parameters.AddWithValue("@xlugar", objeto.Lugar);
                comando.Parameters.AddWithValue("@xmotivo", objeto.Motivo);
                comando.Parameters.AddWithValue("@xretopo", objeto.Retomo);
                comando.Parameters.AddWithValue("@xhoraSalida", objeto.HoraSalida);
                comando.Parameters.AddWithValue("@xcierrep", id);

                comando.ExecuteNonQuery();

                con.Close();
            }
        }
    }

}
