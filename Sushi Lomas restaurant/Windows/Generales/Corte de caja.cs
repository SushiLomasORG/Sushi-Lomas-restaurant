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
    public partial class Corte_de_caja : Form
    {
        StyleButton btn = new StyleButton();
        decimal venta;
        decimal gasto;
        decimal compra;
        decimal total;

        public Corte_de_caja()
        {
            InitializeComponent();

            this.DoubleBuffered = true;

            txt_ventas.ReadOnly = true;
            txt_gastos.ReadOnly = true;
            txt_compras.ReadOnly = true;
            txt_ganancias.ReadOnly = true;

            StyleDataGridView.styleDgv(dataGridView1);
            btn.estilo_boton(btn_registrar);

            venta = CorteCaja.obtener("pedido", "total");
            gasto = CorteCaja.obtener("gastos_compras", "cantidad_dinero", "gasto");
            compra = CorteCaja.obtener("gastos_compras", "cantidad_dinero", "compra");

            txt_ventas.Text = venta.ToString("N2");
            txt_gastos.Text = gasto.ToString("N2");
            txt_compras.Text = compra.ToString("N2");

            total = venta - gasto - compra;
            txt_ganancias.Text = total.ToString("N2");

            CorteCaja.desgloce_datos(dataGridView1);
        }

        private void btn_registrar_Click(object sender, EventArgs e)
        {
            CorteCaja.registrar(venta, gasto, compra, total);

            txt_ventas.Clear();
            txt_gastos.Clear();
            txt_compras.Clear();
            txt_ganancias.Clear();
            dataGridView1.Rows.Clear();
        }
    }
}
