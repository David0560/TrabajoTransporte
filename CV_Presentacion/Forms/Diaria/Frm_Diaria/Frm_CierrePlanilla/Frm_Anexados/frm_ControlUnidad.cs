using CapaServicios.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CV_Presentacion.Forms.Diaria.Frm_Diaria.Frm_CierrePlanilla.Frm_Anexados
{
    public partial class frm_ControlUnidad : Form
    {
       public ContolUnidad objetos1 { get; private set;}

        public frm_ControlUnidad()
        {
            InitializeComponent();
            checkBox1.Checked = true;
            checkBox2.Checked = true;
            checkBox3.Checked = true;
            checkBox4.Checked = true;
            checkBox5.Checked = true;
            checkBox6.Checked = true;
            checkBox7.Checked = true;
            checkBox8.Checked = true;
            checkBox9.Checked = true;
            checkBox10.Checked = true;
            checkBox11.Checked = true;
            checkBox12.Checked = true;
            checkBox13.Checked = true;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            objetos1 = new ContolUnidad(
                checkBox1.Checked,
                checkBox2.Checked,
                checkBox3.Checked,
                checkBox4.Checked,
                checkBox5.Checked,
                checkBox6.Checked,
                checkBox7.Checked,
                checkBox8.Checked,
                checkBox9.Checked,
                checkBox10.Checked,
                checkBox11.Checked,
                checkBox12.Checked,
                checkBox13.Checked
                );

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
