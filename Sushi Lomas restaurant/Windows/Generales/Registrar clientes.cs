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
    public partial class Registrar_clientes : Form
    {
        StyleButton style = new StyleButton();

        public Registrar_clientes()
        {
            InitializeComponent();

            this.DoubleBuffered = true;

            txt_nombre.TabIndex = 0;
            txt_telefono1.TabIndex = 1;
            txt_telefono2.TabIndex = 2;
            txt_domicilio1.TabIndex = 3;
            txt_domicilio2.TabIndex = 4;
            btn_registrar.TabIndex = 5;

            txt_nombre.MaxLength = 20;

            txt_telefono1.MaxLength = 10;
            txt_telefono2.MaxLength = 10;

            txt_domicilio1.MaxLength = 256;
            txt_domicilio2.MaxLength = 256;

            style.estilo_boton(btn_registrar);
        }


        private void txt_telefono1_TextChanged(object sender, EventArgs e)
        {
            Client.comprobarExistencia(txt_telefono1.Text, txt_telefono1.Text, "", "", 1, lbl_msgTelefono1);


            if (string.IsNullOrEmpty(txt_telefono1.Text))
                lbl_msgTelefono1.Text = "";
        }

        private void txt_telefono2_TextChanged(object sender, EventArgs e)
        {
            Client.comprobarExistencia(txt_telefono2.Text, txt_telefono2.Text, "", "", 1, lbl_msgTelefono2);

            if (string.IsNullOrEmpty(txt_telefono2.Text))
                lbl_msgTelefono2.Text = "";
        }

        private void txt_domicilio1_TextChanged(object sender, EventArgs e)
        {
            Client.comprobarExistencia("", "", txt_domicilio1.Text, txt_domicilio1.Text, 2, lbl_msgDireccion1);

            if (string.IsNullOrEmpty(txt_domicilio1.Text))
                lbl_msgDireccion1.Text = "";
        }

        private void txt_domicilio2_TextChanged(object sender, EventArgs e)
        {
            Client.comprobarExistencia("", "", txt_domicilio2.Text, txt_domicilio2.Text, 2, lbl_msgDireccion2);

            if (string.IsNullOrEmpty(txt_domicilio2.Text))
                lbl_msgDireccion2.Text = "";
        }

        private void txt_telefono1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txt_telefono2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btn_registrar_Click(object sender, EventArgs e)
        {
            disparador();
        }

        void disparador()
        {
            if (string.IsNullOrEmpty(txt_nombre.Text) || string.IsNullOrEmpty(txt_telefono1.Text) || string.IsNullOrEmpty(txt_domicilio1.Text))
            {
                MessageBox.Show("Faltan campos obligatorios por llenar...");
                return;
            }

            if (lbl_msgDireccion1.Text == "No disponible." || lbl_msgDireccion2.Text == "No disponible." || lbl_msgTelefono1.Text == "No disponible." || lbl_msgTelefono2.Text == "No disponible.")
            {
                MessageBox.Show("Algún campo Telefono o Direccion tienen un valor no disponible.");
                return;
            }

            string nombre = txt_nombre.Text;
            string telefono1 = txt_telefono1.Text;
            string telefono2 = txt_telefono2.Text;
            string direccion1 = txt_domicilio1.Text;
            string direccion2 = txt_domicilio2.Text;

            Client.registrar(nombre, telefono1, telefono2, direccion1, direccion2);
            limpiar();
        }

        void limpiar()
        {
            txt_nombre.Clear();
            txt_telefono1.Clear();
            txt_telefono2.Clear();
            txt_domicilio1.Clear();
            txt_domicilio2.Clear();
        }
    }
}
