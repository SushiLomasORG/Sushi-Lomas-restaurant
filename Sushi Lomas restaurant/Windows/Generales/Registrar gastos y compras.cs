using Sushi_Lomas_restaurant.Math;
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

namespace Sushi_Lomas_restaurant.Windows.Generales
{
    public partial class Registrar_gastos_y_compras : Form
    {
        StyleButton style = new StyleButton();

        public Registrar_gastos_y_compras()
        {
            InitializeComponent();

            this.DoubleBuffered = true;

            style.estilo_boton(btn_compra);
            style.estilo_boton(btn_gasto);
            style.estilo_boton(btn_OK);
            style.estilo_boton(btn_registrar);

            StyleDataGridView.styleDgv(dataGridView1);
        }

        string opcion = "";

        private void btn_gasto_Click(object sender, EventArgs e)
        {
            opcion = "gasto";
            txt_cantProducto.Enabled = false;
        }

        private void btn_compra_Click(object sender, EventArgs e)
        {
            opcion = "compra";
            txt_cantProducto.Enabled = true;
        }

        private void btn_OK_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(opcion))
            {
                MessageBox.Show("Primero debes seleccionar si es un gasto o una compra.");
                return;
            }
            else
            {
                string concepto = txt_concepto.Text;
                decimal c_producto = 0;
                decimal c_dinero;

                if (!decimal.TryParse(txt_precio.Text, out c_dinero))
                {
                    MessageBox.Show("Cantidad de dinero no es un número válido.");
                    return;
                }

                if (!string.IsNullOrWhiteSpace(txt_cantProducto.Text))
                {
                    if (!decimal.TryParse(txt_cantProducto.Text, out c_producto))
                    {
                        MessageBox.Show("Cantidad de producto no es un número válido.");
                        return;
                    }
                }

                if (opcion == "gasto")
                {
                    dataGridView1.Rows.Add(concepto, null, c_dinero);
                }
                else if (opcion == "compra")
                {
                    dataGridView1.Rows.Add(concepto, c_producto, c_dinero);
                }
                limpiar();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                if (dataGridView1.Columns[e.ColumnIndex] is DataGridViewButtonColumn)
                {
                    dataGridView1.Rows.RemoveAt(e.RowIndex);
                }
            }
        }

        private void btn_registrar_Click(object sender, EventArgs e)
        {
            accion();
        }

        void accion()
        {
            if (dataGridView1.Rows.Count == 0)
            {
                MessageBox.Show("Debes agregar cosas a la lista.");
                return;
            }
            else
            {
                GastosCompras.registrar(dataGridView1, opcion);

                limpiar();
                dataGridView1.Rows.Clear();
            }
        }

        void limpiar()
        {
            txt_concepto.Clear();
            txt_cantProducto.Clear();
            txt_precio.Clear();
        }

        private void txt_cantProducto_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(txt_cantProducto.Text, out int valor))
            {
                if (valor > 200)
                {
                    MessageBox.Show("No puedes usar una cantidad mayor a 200.");
                    txt_cantProducto.Clear();
                }
            }
        }

        private void txt_precio_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(txt_precio.Text, out int valor))
            {
                if (valor > 2000)
                {
                    MessageBox.Show("No puedes hacer un pago mayor a dos mil.");
                    txt_precio.Clear();
                }
            }
        }
    }
}
