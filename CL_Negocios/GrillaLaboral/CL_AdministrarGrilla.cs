﻿using CapaServicios;
using CapaServicios.Entidades.Diaria;
using CD_ConexionDatos;
using CD_ConexionDatos.ActualizarRegistros;
using CD_ConexionDatos.Empleados;
using CD_ConexionDatos.Entidades;
using CD_ConexionDatos.Negocio;
using CL_Negocios.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Net.Http;

namespace CL_Negocios.GrillaLaboral
{
    public class CL_AdministrarGrilla
    {
        DataTable tb = new DataTable();

        CD_GrillaDiaria cargar = new CD_GrillaDiaria();
        CS_servicios servicio = new CS_servicios();
        CD_listarTablas tabla = new CD_listarTablas();
        CD_Choferes chofer = new CD_Choferes();
        CD_Ramal Ramal = new CD_Ramal();
        CD_CrearGrilla g = new CD_CrearGrilla();
        CD_PlanillaLaboral planillaLaboral = new CD_PlanillaLaboral();
 
        private DataTable Frecunacia(int ramal)
        {
            return Ramal.FrecuenciaPorRamal(ramal);// devuelve la frecuencia del ramal seleccionado
        }
        public DataTable UnidadesActivas(DateTime fecha)
        {
            return chofer.obteneUnidadesConVTV(fecha); // devuelve la frecuencia del ramal seleccionado
        }
        public DataTable ChoferesQueTrabajan( DateTime fechaLicencia, int turno)
        {
            DataTable TablaTrabajan = new DataTable();
            TablaTrabajan.Columns.Add("legajo", typeof(int));
            TablaTrabajan.Columns.Add("Chofer", typeof(string));

            DataTable tabla1 = chofer.obtenerTablaChoferesConLicenciaTurno(fechaLicencia, turno);

            foreach (DataRow fila in tabla1.Rows)   
            {
                int id = Convert.ToInt32(fila["id"]);
                DateTime fechainicia = chofer.TrabajaEsteDia(id);
                if (Trabaja(fechaLicencia, fechainicia))
                {
                    TablaTrabajan.Rows.Add(fila["id"], fila["Apellido_Nombre"]);
                }
            }
             return TablaTrabajan;

        } //tabla con los choferes trabajan el dia x y el turno x
        private bool Trabaja(DateTime fecha, DateTime fechai)
        {
            int Dt = 4;
            int Df = 2;

            TimeSpan dife = fecha-fechai;
            int diferencia = dife.Days;
            int Resto = diferencia % (Dt + Df);
            if (Resto >= 4)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public bool CrearNuevaRegistro(DateTime grilla)
        {
            cargar.guardarNuevaGrilla(grilla);
            return true;
        }

        //
        // generador de grilla diarias
        public DataTable GenerarGrilla(int ramal, DateTime fecha)
        {
            //Creo la tabla de destino
            DataTable total = new DataTable();
            //creo sus columnas
            total.Columns.Add("IdFrecuencia", typeof(int));// id frecuencia ------
            total.Columns.Add("Nombre", typeof(string));//frecuencia
            total.Columns.Add("IdUnidad", typeof(int));// id unidad ------
            total.Columns.Add("Unidad", typeof(string));//unidad
            total.Columns.Add("HoraInicio", typeof(TimeSpan)); //frecuencia ------
            total.Columns.Add("legajo", typeof(int));//chofer id ------
            total.Columns.Add("Chofer", typeof(string)); //chofer
            total.Columns.Add("HoraEntrada", typeof(TimeSpan));
            total.Columns.Add("HoraFinTurno", typeof(TimeSpan));

            //creo las tablas a convinar
            DataTable Frec = Frecunacia(ramal); // Ramales
            DataTable Unidades = UnidadesLibres(UnidadesActivas(fecha), fecha); // unidades


            // crear metodo que filtre los choferes que ya fueron asignados en el dia seleccionado.

            DataTable ChoferesM = filtradoDeChoferes(ChoferesQueTrabajan(fecha, 1),fecha); // turno mañana
            DataTable ChoferesT = filtradoDeChoferes(ChoferesQueTrabajan(fecha, 2), fecha); // turno Tarde

            //cantidad de unidades me dice la la cantidad tambien por chofer por turno TM
            int CantidadU = Ramal.CantidadUnidadesRequeridas(ramal);
            // segunda tanda de choferes TT
            int totalTurno = Ramal.CantidadUnidadesRequeridas(ramal) * 2;

            for (int i = 0; i< CantidadU; i++)
            {
                
                DataRow fila = Frec.Rows[i];
                DataRow fila2 = Unidades.Rows[i];
                DataRow fila3 = ChoferesM.Rows[i];  


                DataRow filaDestino = total.NewRow();

                filaDestino["IdFrecuencia"] = fila["Id"];
                filaDestino["Nombre"] = fila["Nombre"];
                filaDestino["HoraInicio"]= fila["HoraInicio"];
                TimeSpan entrada = (TimeSpan)filaDestino["HoraInicio"];
                filaDestino["IdUnidad"] = fila2["IdUnidad"];
                filaDestino["Unidad"] = fila2["Nombre"];
                filaDestino["legajo"] = fila3["legajo"];
                filaDestino["Chofer"] = fila3["Chofer"];
                filaDestino["HoraEntrada"] = entrada - (TimeSpan.FromMinutes(20));
                TimeSpan salida = (TimeSpan)filaDestino["HoraEntrada"];
                filaDestino["HoraFinTurno"] = salida + (TimeSpan.FromHours(8));

                total.Rows.Add(filaDestino);
            }

            for (int j = 0; j < CantidadU; j++)
            {
                DataRow fila = Frec.Rows[CantidadU+j];
                DataRow fila2 = Unidades.Rows[j];
                DataRow fila3 = ChoferesT.Rows[j];


                DataRow filaDestino = total.NewRow();

                filaDestino["IdFrecuencia"] = fila["Id"];
                filaDestino["Nombre"] = fila["Nombre"];
                filaDestino["HoraInicio"] = fila["HoraInicio"];
                TimeSpan entrada = (TimeSpan)filaDestino["HoraInicio"];
                filaDestino["IdUnidad"] = fila2["IdUnidad"];
                filaDestino["Unidad"] = fila2["Nombre"];
                filaDestino["legajo"] = fila3["legajo"];
                filaDestino["Chofer"] = fila3["Chofer"];
                filaDestino["HoraEntrada"] = entrada - (TimeSpan.FromMinutes(20));
                TimeSpan salida = (TimeSpan)filaDestino["HoraEntrada"];
                filaDestino["HoraFinTurno"] = salida + (TimeSpan.FromHours(8));

                total.Rows.Add(filaDestino);
            }
            return total;
        }
        public DataTable GrillaDia(DataTable tabla)
        {
            DataTable total = new DataTable();

            total.Columns.Add("Nombre", typeof(string));//frecuencia
            total.Columns.Add("HoraInicio", typeof(TimeSpan)); //frecuencia ------
            total.Columns.Add("Unidad", typeof(string));//unidad
            total.Columns.Add("legajo", typeof(int));//chofer id ------
            total.Columns.Add("Chofer", typeof(string)); //chofer
            total.Columns.Add("HoraEntrada", typeof(TimeSpan));
            total.Columns.Add("HoraFinTurno", typeof(TimeSpan));

            for (int i = 0; i < tabla.Rows.Count; i++)
            {
                DataRow fila = tabla.Rows[i];

                DataRow filaDestino = total.NewRow();

                filaDestino["Nombre"] = fila["Nombre"];
                filaDestino["HoraInicio"] = fila["HoraInicio"];
                TimeSpan entrada = (TimeSpan)filaDestino["HoraInicio"];
                filaDestino["Unidad"] = fila["Unidad"];
                filaDestino["legajo"] = fila["legajo"];
                filaDestino["Chofer"] = fila["Chofer"];
                filaDestino["HoraEntrada"] = entrada - (TimeSpan.FromMinutes(20));
                TimeSpan salida = (TimeSpan)filaDestino["HoraEntrada"];
                filaDestino["HoraFinTurno"] = salida + (TimeSpan.FromHours(8));

                total.Rows.Add(filaDestino);
            }
            return total;
        } // tabla que se ve en el DGV
        //
        // tabla para guardar
        private List<PlanillaLab> ListaParaGuardar(DataTable tabla)
        {
            DataTable total = new DataTable();

            total.Columns.Add("IdFrecuencia", typeof(int));// id frecuencia ------
            total.Columns.Add("legajo", typeof(int));//chofer id ------
            total.Columns.Add("IdUnidad", typeof(int));// id unidad ------
            total.Columns.Add("HoraInicio", typeof(TimeSpan)); //frecuencia ------
            total.Columns.Add("HoraEntrada", typeof(TimeSpan));

            for (int i = 0; i < tabla.Rows.Count; i++)
            {
                DataRow fila = tabla.Rows[i];

                DataRow filaDestino = total.NewRow();

                filaDestino["IdFrecuencia"] = fila["IdFrecuencia"];
                filaDestino["legajo"] = fila["legajo"];
                filaDestino["IdUnidad"] = fila["IdUnidad"];
                filaDestino["HoraInicio"] = fila["HoraInicio"];
                filaDestino["HoraEntrada"] = fila["HoraEntrada"];
                

                total.Rows.Add(filaDestino);
            }


            List<PlanillaLab> listaLaboral = new List<PlanillaLab>();

            foreach (DataRow row in tabla.Rows)
            {
                PlanillaLab registro = new PlanillaLab(

                    Convert.ToInt32(row["IdFrecuencia"]),
                    Convert.ToInt32(row["legajo"]),
                    Convert.ToInt32(row["IdUnidad"]),
                    (TimeSpan)row["HoraInicio"],
                    (TimeSpan)(row["HoraEntrada"])
                );

                listaLaboral.Add(registro);
            }
            return listaLaboral;


        }
        //
        // Guardar grilla
        public int GuardarGrilla(DateTime fecha)
        {
            cargar.guardarNuevaGrilla(fecha);
            int datoGrilla = cargar.obtenerUltimoRegistroGrilla();
            return datoGrilla;
        }
        public bool guardarPlanillasLaboral(int idGrilla, int ramal, DateTime fecha)
        {
            if (planillaLaboral.GuardarPlanillas(idGrilla, ListaParaGuardar(GenerarGrilla(ramal, fecha))))
            {
                return true;
            }
            return false;
        }
        //
        //validar choferes
        public DataTable filtradoDeChoferes(DataTable tabla, DateTime fecha)
        {
            int valor = tabla.Rows.Count;
            // Eliminar registros del DataTable que existen en Salidas
            for (int i =0; i< valor; i++)
            {
                int id = Convert.ToInt32(tabla.Rows[i]["legajo"]);

                if (planillaLaboral.ExiteRegistroId(id, fecha))
                {
                    tabla.Rows[i].Delete();
                    tabla.AcceptChanges();
                    valor =tabla.Rows.Count;
                    i--;
                }
            }
            return tabla;
        }

        public DataTable UnidadesLibres(DataTable tabla, DateTime fecha)
        {
            int valor = tabla.Rows.Count;
            // Eliminar registros del DataTable que existen en Salidas
            for (int i = 0; i < valor; i++)
            {
                int id = Convert.ToInt32(tabla.Rows[i]["IdUnidad"]);

                if (planillaLaboral.ExisteRegistroUnidadId(id, fecha))
                {
                    tabla.Rows[i].Delete();
                    tabla.AcceptChanges();
                    valor = tabla.Rows.Count;
                    i--;
                }
            }
            return tabla;
        }

        public bool revisarCargaRamal(int id, DateTime fecha)
        {
            return cargar.revisarRemalCargado(id, fecha);
        }


    }
}
