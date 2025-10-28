using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sushi_Lomas_restaurant.Class;
using Sushi_Lomas_restaurant.Styles;

namespace Sushi_Lomas_restaurant.Windows.Administracion
{
    public partial class Administrar_precios : Form
    {
        StyleButton button = new StyleButton();
        public Administrar_precios()
        {
            InitializeComponent();

            this.DoubleBuffered = true;

            tipo = 1;
            Product.lista_Simple(dataGridView1, producto, tipo);
            StyleDataGridView.styleDgv(dataGridView1);

            dataGridView1.ReadOnly = true;
            txt_precioActual.ReadOnly = true;

            button.estilo_boton(btn_Reg);

            txt_nuevoPrecio.MaxLength = 4;
            txt_producto.MaxLength = 50;
        }

        int tipo = 0;
        string producto = "";

        private void PROMOCIONES_Click(object sender, EventArgs e)
        {
            tipo = 1;
            Product.lista_Simple(dataGridView1, producto, tipo);
        }

        private void SUSHIS_Click(object sender, EventArgs e)
        {
            tipo = 2;
            Product.lista_Simple(dataGridView1, producto, tipo);
        }

        private void CHAROLAS_Click(object sender, EventArgs e)
        {
            tipo = 3;
            Product.lista_Simple(dataGridView1, producto, tipo);
        }

        private void ENTRADAS_Click(object sender, EventArgs e)
        {
            tipo = 4;
            Product.lista_Simple(dataGridView1, producto, tipo);
        }

        private void OTROS_Click(object sender, EventArgs e)
        {
            tipo = 5;
            Product.lista_Simple(dataGridView1, producto, tipo);
        }

        private void BEBIDAS_Click(object sender, EventArgs e)
        {
            tipo = 6;
            Product.lista_Simple(dataGridView1, producto, tipo);
        }

        private void EXTRAS_Click(object sender, EventArgs e)
        {
            tipo = 7;
            Product.lista_Simple(dataGridView1, producto, tipo);
        }

        private void txt_filtrar_TextChanged(object sender, EventArgs e)
        {
            producto = txt_producto.Text;
            Product.lista_Simple(dataGridView1, producto, tipo);
        }

        private void txt_nuevoPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txt_producto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                DataGridViewRow fila = dataGridView1.Rows[e.RowIndex];

                txt_producto.Text = fila.Cells[0].Value?.ToString();
                txt_precioActual.Text = fila.Cells[1].Value?.ToString();
            }
        }

        private void Registrar_Click(object sender, EventArgs e)
        {
            disparador();
        }

        void disparador()
        {

        }

    }
}
