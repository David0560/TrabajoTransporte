using CapaServicios;
using CapaServicios.Entidades.Frecuencia;
using CL_Negocios.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CD_ConexionDatos.ActualizarRegistros
{
    public class CD_CrearGrilla
    {
        SqlConnection con = new SqlConnection(); // instancio la cadena para la conexion
       
        /*public List<Ramal> ObtenerRamal()
        {
            using (con = connectionBD.CreaInstacia().CrearConexion())
            {
                string query = "SELECT * FROM Ramal";
                List<Ramal> ListaRamal = new List<Ramal>();
                using (con = connectionBD.CreaInstacia().CrearConexion()) // realizo la conexion
                {
                    using (con = connectionBD.CreaInstacia().CrearConexion())
                    {
                        con.Open();
                        using (SqlCommand command = new SqlCommand(query, con))
                        {
                            using (SqlDataReader reader = command.ExecuteReader())
                            {
                                while (reader.Read())
                                {
                                    Ramal rama = new Ramal(
                                        reader.GetInt32(0),
                                        reader.GetString(1),
                                        reader.GetInt32(2),
                                        reader.GetTimeSpan(3),
                                        reader.GetInt32(4)
                                    );
                                    ListaRamal.Add(rama);
                                }
                            }
                        }
                    }
                    return ListaRamal;
                }
            }
        }
        public List<Personal> obtenerChoferes()
        {
            using (con = connectionBD.CreaInstacia().CrearConexion())
            {
                string query = "SELECT * FROM Persona";
                List<Personal> ListaPersona = new List<Personal>();
                using (con = connectionBD.CreaInstacia().CrearConexion()) // realizo la conexion
                {
                    using (con = connectionBD.CreaInstacia().CrearConexion())
                    {
                        con.Open();
                        using (SqlCommand command = new SqlCommand(query, con))
                        {
                            using (SqlDataReader reader = command.ExecuteReader())
                            {
                                while (reader.Read())
                                {
                                    Personal P = new Personal(
                                        reader.GetInt32(0),
                                        reader.GetString(1),
                                        reader.GetString(2),

                                        reader.GetDateTime(3),
                                        reader.GetInt32(4),
                                        reader.GetString(4),

                                        reader.GetInt32(4),
                                        reader.GetInt32(4),
                                        reader.GetString(4),

                                        reader.GetInt32(4),
                                        reader.GetString(4),
                                        reader.GetInt32(4),

                                        reader.GetDateTime(4),
                                        reader.GetInt32(4)
                                    );
                                    ListaPersona.Add(P);
                                }
                            }
                        }
                        return ListaPersona;
                    }
                }
            }
        }
        public List<Unidad> ObtenerUnidades()
        {
            using (con = connectionBD.CreaInstacia().CrearConexion())
            {
                string query = "SELECT * FROM Unidad";
                List<Unidad> ListaUnidad = new List<Unidad>();
                using (con = connectionBD.CreaInstacia().CrearConexion()) // realizo la conexion
                {
                    using (con = connectionBD.CreaInstacia().CrearConexion())
                    {
                        con.Open();
                        using (SqlCommand command = new SqlCommand(query, con))
                        {
                            using (SqlDataReader reader = command.ExecuteReader())
                            {
                                while (reader.Read())
                                {
                                    Unidad Uni = new Unidad(
                                        reader.GetInt32(0),
                                        reader.GetString(1),
                                        reader.GetInt32(2)
                                    );
                                    ListaUnidad.Add(Uni);
                                }
                            }
                        }
                    }
                    return ListaUnidad;
                }
            }
        }*/

    }
}
