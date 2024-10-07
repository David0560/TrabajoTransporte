using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaServicios
{
    public class CS_servicios
    {
        public CS_servicios() { }
        public void parametrosDataGridView(Control control)
        {
            if (control is DataGridView dataGridView)
            {
                dataGridView.DataSource = null; // Eliminar la fuente de datos del DataGridView
                dataGridView.Rows.Clear(); // Limpiar las filas en el DataGridView
                //dataGridView.Columns[1].Visible = false;
                dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect; //seleccionar solo la fila
                dataGridView.RowHeadersVisible = false; // columna de indice "Flecha" 
                dataGridView.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter; // centra el encabezado de la colunna
                //dataGridView.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter; // centra los valores de las filas
                dataGridView.MultiSelect = false; // Que no pueda seleccionar multiples filas
                dataGridView.ReadOnly = true; // no se permite editar desde la grilla
                dataGridView.RowHeadersVisible = false; // Oculto los encabezados de filas
                dataGridView.AllowUserToAddRows = false; // Desactiva  la ultima fila 
                //dataGridView.AllowUserToResizeColumns = false; // no permite cambiar el tamaño de la columna
                dataGridView.AllowUserToResizeRows = false; // no permite cambiar el tamaño de la fila
                dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                // Grafica
                dataGridView.CellBorderStyle = DataGridViewCellBorderStyle.None;
                dataGridView.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;// Quito los bordes de la cabecera
                //dataGridView.AutoResizeColumns();
                //*dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;// Selecciona toda la fila al hacer click en alguna celda
                //dataGridView.EnableHeadersVisualStyles = false; // Para poder modificar estilos en la cabecera
                //dataGridView.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;// Centro el texto de las cabeceras

            }
        }
        public void estiloDataGrid(Control control)
        {
            if (control is DataGridView dataGridView)
            {
                dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect; //seleccionar solo la fila
                dataGridView.RowHeadersVisible = false; // columna de indice "Flecha" 
                dataGridView.MultiSelect = false; // Que no pueda seleccionar multiples filas
                dataGridView.ReadOnly = true; // no se permite editar desde la grilla
                dataGridView.RowHeadersVisible = false; // Oculto los encabezados de filas
                dataGridView.AllowUserToAddRows = false; // Desactiva  la ultima fila 
                dataGridView.AllowUserToResizeRows = false; // no permite cambiar el tamaño de la fila
                dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                // Grafica
                dataGridView.CellBorderStyle = DataGridViewCellBorderStyle.None;
                dataGridView.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;// Quito los bordes de la cabecera
                //dataGridView.AutoResizeColumns();
                //*dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;// Selecciona toda la fila al hacer click en alguna celda
                //dataGridView.EnableHeadersVisualStyles = false; // Para poder modificar estilos en la cabecera
                //dataGridView.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;// Centro el texto de las cabeceras

            }
        }

        public void LimpiarControlesForm(Control control)
        {
            foreach (Control c in control.Controls)
            {
                if (c is TextBox textBox)
                {
                    textBox.Text = string.Empty; // Limpiar el contenido del TextBox
                }
                if (c is ComboBox comboBox)
                {
                    comboBox.SelectedIndex = -1; // Resetear la selección del ComboBox
                }
                if (c is DataGridView dataGridView)
                {
                    dataGridView.DataSource = null; // Eliminar la fuente de datos del DataGridView
                    dataGridView.Rows.Clear(); // Limpiar las filas en el DataGridView
                }
                if (c is MaskedTextBox maskedtextBox)
                {
                    maskedtextBox.Text = string.Empty; // Limpiar el contenido del maskedTextBox
                }
                if (c is GroupBox groupBox)
                {
                    foreach (Control hijo in groupBox.Controls)
                    {
                        LimpiarControlesForm(hijo);
                    }
                }


            }
        }

        public void LimpiarFormulario(Control control)
        {
            foreach (Control hijo in control.Controls)
            {
                LimpiarControl(hijo);
            }
        }

        private void LimpiarControl(Control control)
        {
            if (control is TextBox)
            {
                ((TextBox)control).Clear();
            }
            else if (control is ComboBox)
            {
                ((ComboBox)control).SelectedIndex = -1;
            }
            else if (control is CheckBox)
            {
                ((CheckBox)control).Checked = false;
            }
            else if (control is RadioButton)
            {
                ((RadioButton)control).Checked = false;
            }
            else if (control is MaskedTextBox)
            {
                ((MaskedTextBox)control).Clear();
            }
            else if (control is DateTimePicker)
            {
                ((DateTimePicker)control).Value = DateTime.Now;
            }
            else if (control is GroupBox)
            {
                foreach (Control hijo in ((GroupBox)control).Controls)
                {
                    LimpiarControl(hijo);
                }
            }
            else if (control is Panel)
            {
                foreach (Control hijo in ((Panel)control).Controls)
                {
                    LimpiarControl(hijo);
                }
            }
            else if (control is TableLayoutPanel)
            {
                foreach (Control hijo in ((TableLayoutPanel)control).Controls)
                {
                    LimpiarControl(hijo);
                }
            }
        }
    }
}