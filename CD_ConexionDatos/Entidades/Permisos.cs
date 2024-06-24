﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CL_Negocios.Entidades
{
    public class Permisos
    {
        public int Id_familia_rol { get; set; }
        public int Id_usuario { get; set; }
        public DateTime Fecha_alta { get; set; }
        public DateTime? Fecha_baja { get; set; }

        public string fecha_vence { get; set; }

        public Permisos(int id_familia_rol)
        {
            Id_familia_rol = id_familia_rol;
        }

        public Permisos(int id_familia_rol, int id_usuario, DateTime? fecha_baja)
        {
            Id_familia_rol = id_familia_rol;
            Id_usuario = id_usuario;
            Fecha_baja = fecha_baja;
        }
        public Permisos(int id_familia_rol, int id_usuario, DateTime? fecha_baja, DateTime fecha_alta)
        {
            Id_familia_rol = id_familia_rol;
            Id_usuario = id_usuario;
            Fecha_baja = fecha_baja;
            Fecha_alta = fecha_alta;
        }

        public Permisos(int id_familia_rol, int id_usuario, string fecha_baja)
        {
            Id_familia_rol = id_familia_rol;
            Id_usuario = id_usuario;
            fecha_vence = fecha_baja;
        }

    }

}
