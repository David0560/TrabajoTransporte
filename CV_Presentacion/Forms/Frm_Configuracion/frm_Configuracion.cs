using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaServicios;
using CL_Negocios;

namespace CV_Presentacion.Forms
{
    public partial class frm_Configuracion : Form
    {
        public frm_Configuracion(string nombreUsuario)
        {
            InitializeComponent();
            lblNombreUsuario.Text = nombreUsuario;
        }
        public frm_Configuracion()
        {
            InitializeComponent();
        }
       
    }
}