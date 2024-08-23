using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CL_Negocios.Entidades
{
    internal class Pregunta
    {
        private int Id_pregunta { get; set;}
        private string Desc_Pregunta { get; set;}


        public Pregunta( string pregunta)
        {
            
            Desc_Pregunta = pregunta;
        }

    }

}
