using Sushi_Lomas_restaurant.Class;
using Sushi_Lomas_restaurant.Styles;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sushi_Lomas_restaurant.Windows.Administracion
{
    public partial class Administrar_clientes : Form
    {
        StyleButton styleButton = new StyleButton();

        public Administrar_clientes()
        {
            InitializeComponent();

            this.DoubleBuffered = true;

            styleButton.estilo_boton(btn_guardarCambios);
            StyleDataGridView.styleDgv(dataGridView1);
            Client.lista(dataGridView1, "");
        }

        private void btn_guardarCambios_Click(object sender, EventArgs e)
        {
            Client.actualizarDatos();
            Client.lista(dataGridView1, "");
        }

        private void dataGridView1_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (e.Control is TextBox tb)
            {
                tb.KeyPress -= TextBox_KeyPress;
                tb.KeyPress += TextBox_KeyPress;
            }
        }

        private void TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox tb = sender as TextBox;

            int colIndex = dataGridView1.CurrentCell.ColumnIndex;
            string colName = dataGridView1.Columns[colIndex].Name;

            if (colName == "telefono1" || colName == "telefono2")
            {
                if (tb.Text.Length >= 10 && !char.IsControl(e.KeyChar))
                {
                    e.Handled = true;
                }

                if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                {
                    e.Handled = true;
                }
            }
        }

        private void txt_filtrar_TextChanged(object sender, EventArgs e)
        {
            Client.lista(dataGridView1, txt_filtrar.Text.Trim());
        }
    }
}