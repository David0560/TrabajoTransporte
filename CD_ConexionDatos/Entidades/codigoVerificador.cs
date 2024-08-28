using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CD_ConexionDatos
{
    public class codigoVerificador
    {
        public int Id_usuario { get; set; }
        public int Valor { get; set; }

        public codigoVerificador(int id_usuario, int valor)
        {
            this.Id_usuario = id_usuario;
            this.Valor = valor;
        }
    }
}
