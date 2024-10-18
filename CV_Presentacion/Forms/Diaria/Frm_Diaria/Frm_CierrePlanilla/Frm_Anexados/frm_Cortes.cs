using CapaServicios;
using CapaServicios.Entidades;
using CapaServicios.Entidades.Diaria.CierrePlanilla;
using CL_Negocios.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CV_Presentacion.Forms.Diaria.Frm_Diaria
{
    public partial class frm_Cortes : Form
    {
        CS_servicios servicio = new CS_servicios();
        private List<CorteViaPublica> listaCorte;

        public frm_Cortes()
        {
            InitializeComponent();
            mskHora.Focus();
            listaCorte = new List<CorteViaPublica>();
            cargar();
            servicio.estiloDataGrid(dgvCorte);
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            TimeSpan hora = TimeSpan.Parse(mskHora.Text);
            string lugar = txbLugar.Text;
            string motivo = txbMotivo.Text;
            string retomo = txbRetoma.Text;
            TimeSpan horaSalida = TimeSpan.Parse(mskHoraSalida.Text);

            CorteViaPublica Dato = new CorteViaPublica(hora, lugar, motivo, retomo, horaSalida);
            listaCorte.Add( Dato );
            cargar();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            servicio.LimpiarTodoControl(groupBox2);
            mskHora.Clear();
            mskHoraSalida.Clear();
            mskHora.Focus();
        }

        public List<CorteViaPublica> GetListaCorte()
        {
            return listaCorte;
        }

        public void cargar()
        {
            dgvCorte.DataSource = null; // Limpiar la fuente de datos
            dgvCorte.DataSource = listaCorte;
        }

        private void btnElimiar_Click(object sender, EventArgs e)
        {
            if (dgvCorte.SelectedRows.Count > 0)
            {

                // Obtener el índice de la fila seleccionada
                int index = dgvCorte.SelectedRows[0].Index;

                // Obtener el objeto a eliminar
                CorteViaPublica objetoAEliminar = listaCorte[index];

                // Eliminar del origen de datos
                listaCorte.Remove(objetoAEliminar);

                // Actualizar el DataGridView
                dgvCorte.DataSource = null; // Limpiar la fuente de datos
                dgvCorte.DataSource = listaCorte; // Volver a establecer la fuente de datos
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
