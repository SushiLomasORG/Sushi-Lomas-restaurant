using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sushi_Lomas_restaurant.Class;
using Sushi_Lomas_restaurant.Math;
using Sushi_Lomas_restaurant.Styles;

namespace Sushi_Lomas_restaurant.Windows.Pedidos
{
    public partial class Registrar_pedidos : Form
    {
        public Registrar_pedidos()
        {
            InitializeComponent();
            cargar_estilos();

            this.DoubleBuffered = true;

            txt_filtrarProducto.MaxLength = 50;
            txt_detalle.MaxLength = 256;
            txt_direccion.MaxLength = 256;
            txt_conCuantoPaga.MaxLength = 5;

            txt_feria.ReadOnly = true;
            dataGridView_producto.ReadOnly = true;

            tipo = 8;

            if (existe == true)
            {
                cmb_direccion.Enabled = true;
                Client.obtener_direccion(cmb_direccion);
            }
            else
            {
                cmb_direccion.Enabled = false;
            }

            lbl_total.Text = "0.00";
            txt_detalle.Text = "Ej: sin chippotle";

            StyleDataGridView.styleDgv(dataGridView_producto);
            StyleDataGridView.styleDgv(dataGridView_comanda);

            lista();

            dataGridView_comanda.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView_comanda.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView_comanda.AutoResizeColumns();

            MessageBox.Show($"existe: {existe}, id_cliente: {id_cliente}, nombre: {nombre_cliente}");
        }

        public static bool existe;
        public static int id_cliente = 0;
        public static string telefono = "";
        public static string nombre_cliente = "";
        string direccion = "";

        int tipo;
        int n_pedido = 0;
        int lugar = 0;
        int tipoLista = 8;

        private int tipo_direccion = 0;


        private void PROMOCIONES_Click(object sender, EventArgs e)
        {
            tipo = 1;
            lista();
        }

        private void SUSHI_Click(object sender, EventArgs e)
        {
            tipo = 2;
            lista();

        }

        private void CHAROLAS_Click(object sender, EventArgs e)
        {
            tipo = 3;
            lista();

        }

        private void ENTRADAS_Click(object sender, EventArgs e)
        {
            tipo = 4;
            lista();

        }

        private void OTROS_Click(object sender, EventArgs e)
        {
            tipo = 5;
            lista();

        }

        private void BEBIDAS_Click(object sender, EventArgs e)
        {
            tipo = 6;
            lista();

        }

        private void EXTRAS_Click(object sender, EventArgs e)
        {
            tipo = 7;
            lista();

        }

        private void TODOS_Click(object sender, EventArgs e)
        {
            tipo = 8;
            lista();

        }

        private void btn_agregarProducto_Click(object sender, EventArgs e)
        {
            string detalles = txt_detalle.Text;

            AgregarProductos.comanda(dataGridView_producto, dataGridView_comanda, detalles, txt_filtrarProducto);
            calcular_total();
            calcular_cambio();
        }

        private void btn_quitarProducto_Click(object sender, EventArgs e)
        {
            quitarProducto();
        }

        private void dataGridView_producto_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView_producto.Rows[e.RowIndex];
                object producto = row.Cells[1].Value;

                txt_productoSeleccionado.Text = producto?.ToString() ?? "";
            }
        }

        private void cmb_direccion_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_direccion.SelectedIndex == -1)
            {
                lugar = 1;
            }
            else
            {
                lugar = 2;
                tipo_direccion = 1;
            }

            calcular_total();
            txt_direccion.Clear();
        }

        private void txt_direccion_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_direccion.Text))
            {
                lugar = 0;
            }
            else
            {
                lugar = 1;
                tipo_direccion = 2;
            }
        }

        private void txt_direccion_Enter(object sender, EventArgs e)
        {
            if (cmb_direccion.SelectedIndex != -1)
            {
                cmb_direccion.SelectedIndex = -1;
            }
        }

        private void txt_detalle_Enter(object sender, EventArgs e)
        {
            if (txt_detalle.Text == "Ej: sin chippotle")
            {
                txt_detalle.Clear();    
            }
        }

        private void txt_detalle_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_detalle.Text))
            {
                txt_detalle.Text = "Ej: sin chippotle";
            }
        }

        private void txt_filtrarProducto_TextChanged(object sender, EventArgs e)
        {
            lista();
        }

        private void txt_conCuantoPaga_TextChanged(object sender, EventArgs e)
        {
            calcular_cambio();
        }

        private void btn_OK_Click(object sender, EventArgs e)
        {
            if (existe == false)
            {
                Client.registrar_xPedido(direccion);
            }

            registrar();
            limpiar();

            this.Close();
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            cancelar();
        }


        void lista()
        {
            string filtro = txt_filtrarProducto.Text;

            if (tipo == 8)
            {
                tipoLista = 3;
            }
            else if (tipo == 6)
            {
                tipoLista = 2;
            }
            else
            {
                tipoLista = 1;
            }

            Product.list(filtro, tipo, dataGridView_producto, tipoLista);
        }

        void registrar()
        {
            string total = lbl_total.Text;
         
            if (tipo_direccion == 1)
            {
                direccion = cmb_direccion.SelectedItem.ToString();
            }
            else 
            {
                direccion = txt_direccion.Text;
            }

            Orders.Registrar(dataGridView_comanda, total, direccion, lugar, n_pedido);      
        }

        void calcular_total()
        {
            string direccionTXT = txt_direccion.Text;
            CalcularTotal.cuenta(dataGridView_comanda, lugar, direccionTXT, cmb_direccion, lbl_total);
        }

        void calcular_cambio()
        {
            string total = lbl_total.Text;
            string conCuantoPaga = txt_conCuantoPaga.Text;
            string feria = txt_feria.Text;

            CalcularCambio.cambio(total, conCuantoPaga, txt_feria);
        }

        void quitarProducto()
        {
            if (dataGridView_comanda.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow fila in dataGridView_comanda.SelectedRows)
                {
                    if (!fila.IsNewRow)
                    {
                        dataGridView_comanda.Rows.Remove(fila);
                        txt_conCuantoPaga.Clear();
                        txt_feria.Clear();
                    }
                }
            }
            else
            {
            }
            calcular_total();
        }

        void limpiar()
        {
            existe = false;
            tipo = 0;
            lugar = 0;
            id_cliente = 0;

            txt_detalle.Text = "Ej: sin chipottle";
            txt_direccion.Text = "";
            cmb_direccion.SelectedIndex = -1;
            dataGridView_comanda.Rows.Clear();

            txt_conCuantoPaga.Clear();
            txt_feria.Clear();
            lbl_total.Text = "";
        }

        void cancelar()
        {
            existe = false;
            tipo = 0;
            lugar = 0;
            id_cliente = 0;

            txt_detalle.Text = "Ej: sin chippotle";
            txt_direccion.Clear();
            cmb_direccion.SelectedIndex = -1;
            dataGridView_comanda.Rows.Clear();

            this.Close();
        }

        void cargar_estilos()
        {
            StyleButton stylebutton = new StyleButton();

            stylebutton.estilo_boton(PROMOCIONES);
            stylebutton.estilo_boton(SUSHI);
            stylebutton.estilo_boton(CHAROLAS);
            stylebutton.estilo_boton(ENTRADAS);
            stylebutton.estilo_boton(OTROS);
            stylebutton.estilo_boton(BEBIDAS);
            stylebutton.estilo_boton(EXTRAS);
            stylebutton.estilo_boton(TODOS);
            stylebutton.estilo_boton(btn_OK);
            stylebutton.estilo_boton(btn_agregarProducto);
            stylebutton.estilo_boton(btn_cancelar);
        }

        private void txt_conCuantoPaga_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
