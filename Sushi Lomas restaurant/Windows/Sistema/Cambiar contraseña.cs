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

namespace Sushi_Lomas_restaurant.Windows.Sistema
{
    public partial class Cambiar_contraseña : Form
    {
        StyleButton style = new StyleButton();

        public Cambiar_contraseña()
        {
            InitializeComponent();

            this.DoubleBuffered = true;

            txt_nombre.MaxLength = 20;
            txt_contraseña.MaxLength = 20;

            txt_nombre.TabIndex = 0;
            txt_contraseña.TabIndex = 1;
            btn_cambiar.TabIndex = 2;

            style.estilo_boton(btn_cambiar);
        }

        private void txt_nombre_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txt_nombre.Text))
            {
                User.verificar_existencia(txt_nombre.Text, lblmsgUsuario);
            }
            else
            {
                lblmsgUsuario.Text = "";
            }
        }

        private void btn_cambiar_Click(object sender, EventArgs e)
        {
            accion();
        }


        void accion()
        {
            if (string.IsNullOrEmpty(txt_nombre.Text) || string.IsNullOrEmpty(txt_contraseña.Text))
            {
                MessageBox.Show("Error: faltan campos por llenar.");
                return;
            }

            if (lblmsgUsuario.Text == "No disponible.")
            {
                MessageBox.Show("El nombre de usuario que ingresaste no existe.");
                return;
            }

            User.cambiar_contraseña(txt_nombre.Text, txt_contraseña.Text);
        }
    }
}
