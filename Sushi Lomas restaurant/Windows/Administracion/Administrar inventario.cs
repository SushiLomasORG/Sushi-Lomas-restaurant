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
    public partial class Administrar_inventario : Form
    {
        StyleButton styleButton = new StyleButton();

        //string filtro;
        //int tipo;

        public Administrar_inventario()
        {
            InitializeComponent();

            this.DoubleBuffered = true;

            this.Shown += Administrar_inventario_Shown;
            this.Click += Administrar_inventario_Click;

            foreach (Control c in this.Controls)
            {
                if (!(c is DataGridView))
                {
                    c.Click += Administrar_inventario_Click;
                }
            }

            txt_producto.ReadOnly = true;
            txt_cantidad.BackColor = SystemColors.Window;
            dataGridView1.ReadOnly = true;

            txt_cantidad.MaxLength = 4;

            Product.listaINV(dataGridView1);
            StyleDataGridView.styleDgv(dataGridView1);

            styleButton.estilo_boton(btn_bajoStock);
            styleButton.estilo_boton(btn_alimentar);
            styleButton.estilo_boton(btn_sinStock);
            styleButton.estilo_boton(btn_todos);
            styleButton.estilo_boton(btn_imprimirTicket);
        }

        public static int id_articulo;
        private int umbral;
        private int stock;

        private string articulo;

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return; 

            DataGridViewRow fila = dataGridView1.Rows[e.RowIndex];

            if (fila.Cells[0].Value != null && fila.Cells[0].Value != DBNull.Value)
            {
                articulo = fila.Cells[0].Value.ToString();
            }
            else
            {
                return; 
            }

            // Validar celda 1 (stock)
            object valorStock = fila.Cells[1].Value;
            if (valorStock != null && valorStock != DBNull.Value)
            {
                // Intentar convertir a entero
                if (!int.TryParse(valorStock.ToString(), out stock))
                {
                    stock = 0; 
                }
            }
            else
            {
                stock = 0;
            }

            Product.obtenerID(articulo);
            txt_producto.Text = articulo;
        }

        private void btn_bajoStock_Click(object sender, EventArgs e)
        {
            umbral = 5;
            Product.lista_x_stockINV(dataGridView1, umbral);
        }

        private void btn_sinStock_Click(object sender, EventArgs e)
        {
            umbral = 0;
            Product.lista_x_stockINV(dataGridView1, umbral);
        }

        private void btn_todos_Click(object sender, EventArgs e)
        {

            Product.listaINV(dataGridView1);
        }

        private void btn_imprimirTicket_Click(object sender, EventArgs e)
        {

        }

        private void btn_alimentar_Click(object sender, EventArgs e)
        {
            disparador();
        }

        private void txt_cantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        void disparador()
        {
            if (string.IsNullOrEmpty(txt_cantidad.Text))
            {
                MessageBox.Show("Primero debes ingresar la cantidad de producto que vas a registrar.");
                return;
            }

            if (id_articulo == 0)
            {
                MessageBox.Show("Error al leer el id del artículo.");
                return;
            }

            if (stock == 0)
            {
                MessageBox.Show("Error al leer el stock del artículo.");
            }

            int cantidad = Convert.ToInt32(txt_cantidad.Text);

            Product.alimentar_inv(cantidad, id_articulo, stock);
            Product.listaINV(dataGridView1);
        }

        private void Administrar_inventario_Shown(object sender, EventArgs e)
        {
            dataGridView1.CurrentCell = null;
            dataGridView1.ClearSelection();
        }

        private void Administrar_inventario_Click(object sender, EventArgs e)
        {
            dataGridView1.ClearSelection(); 
        }
    }
}
