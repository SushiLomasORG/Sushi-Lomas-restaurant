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

namespace Sushi_Lomas_restaurant.Windows.Generales
{
    public partial class Registrar_articulos : Form
    {
        StyleButton styleButton = new StyleButton();

        public Registrar_articulos()
        {
            InitializeComponent();

            this.DoubleBuffered = true;

            tipo = 0;

            styleButton.estilo_boton(btn_registrar);
            styleButton.estilo_boton(PROMOCIONES);
            styleButton.estilo_boton(SUSHI);
            styleButton.estilo_boton(CHAROLAS);
            styleButton.estilo_boton(ENTRADAS);
            styleButton.estilo_boton(OTROS);
            styleButton.estilo_boton(BEBIDAS);
            styleButton.estilo_boton(EXTRAS);

            txt_producto.MaxLength = 50;
            txt_precio.MaxLength = 4;
        }

        int tipo;

        private void PROMOCIONES_Click(object sender, EventArgs e)
        {
            tipo = 1;

            if (tipo != 0 && !string.IsNullOrEmpty(lbl_aclararProducto.Text))
            {
                limpiar();
            }
        }

        private void SUSHI_Click(object sender, EventArgs e)
        {
            tipo = 2;

            if (tipo != 0 && !string.IsNullOrEmpty(lbl_aclararProducto.Text))
            {
                limpiar();
            }
        }

        private void CHAROLAS_Click(object sender, EventArgs e)
        {
            tipo = 3;

            if (tipo != 0 && !string.IsNullOrEmpty(lbl_aclararProducto.Text))
            {
                limpiar();
            }
        }

        private void ENTRADAS_Click(object sender, EventArgs e)
        {
            tipo = 4;

            if (tipo != 0 && !string.IsNullOrEmpty(lbl_aclararProducto.Text))
            {
                limpiar();
            }
        }

        private void OTROS_Click(object sender, EventArgs e)
        {
            tipo = 5;

            if (tipo != 0 && !string.IsNullOrEmpty(lbl_aclararProducto.Text))
            {
                limpiar();
            }
        }

        private void BEBIDAS_Click(object sender, EventArgs e)
        {
            tipo = 6;

            if (tipo != 0 && !string.IsNullOrEmpty(lbl_aclararProducto.Text))
            {
                limpiar();
            }
        }

        private void EXTRAS_Click(object sender, EventArgs e)
        {
            tipo = 7;

            if (tipo != 0 && !string.IsNullOrEmpty(lbl_aclararProducto.Text))
            {
                limpiar();
            }
        }

        private void txt_producto_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txt_producto.Text))
            {
                string nombre = txt_producto.Text;
                Product.comprobarExistencia(nombre, lbl_msgProducto);
            }
        }

        private void txt_producto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (tipo == 0)
            {
                e.Handled = true;
                MessageBox.Show("Primero selecciona el tipo de producto.");
                return;
            }
        }

        private void txt_producto_Leave(object sender, EventArgs e)
        {
            if (tipo == 0)  
                return;

            string tipoProducto = "";

            if (tipo == 1)
                tipoProducto = "Promocion";
            else if (tipo == 2)
                tipoProducto = "Sushi";
            else if (tipo == 3)
                tipoProducto = "Charolas";
            else if (tipo == 4)
                tipoProducto = "Entradas";
            else if (tipo == 5)
                tipoProducto = "Otros";
            else if (tipo == 6)
                tipoProducto = "Bebidas";
            else if (tipo == 7)
                tipoProducto = "Extras";

            lbl_aclararProducto.Text = $"Se registrará un producto de tipo:  {tipoProducto}  con nombre:  {txt_producto.Text}";
        }

        private void btn_registrar_Click(object sender, EventArgs e)
        {
            disparador();
        }

        void disparador()
        {
            if (tipo == 0)
                return;

            string nombre = txt_producto.Text;
            int precio = Convert.ToInt32(txt_precio.Text);

            Product.registrar(nombre, precio, tipo);
            limpiar();
        }

        void limpiar()
        {
            txt_producto.Clear();
            txt_precio.Clear();
            lbl_aclararProducto.Text = "";
            lbl_msgProducto.Text = "";
        }
    }
}
