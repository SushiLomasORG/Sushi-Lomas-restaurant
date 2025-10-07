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
    public partial class Autorizacion : Form
    {
        public Autorizacion()
        {
            InitializeComponent();
            CenterToScreen();

            this.DoubleBuffered = true;

            MaximizeBox = false;
            MinimizeBox = false;

            txt_contraseña.PasswordChar = '*';

            txt_contraseña.TabIndex = 0;
            btn_confirmar.TabIndex = 1;
        }

        private void btn_confirmar_Click(object sender, EventArgs e)
        {

        }

        private void cb_mostrarContraseña_CheckedChanged(object sender, EventArgs e)
        {
            if (txt_contraseña.PasswordChar == '*')
            {
                txt_contraseña.PasswordChar = '\0';
            }
            else
            {
                txt_contraseña.PasswordChar = '*'; 
            }
        }
    }
}
