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

namespace Sushi_Lomas_restaurant
{
    public partial class Identiicarse : Form
    {
        Login login = new Login();

        public Identiicarse()
        {
            InitializeComponent();
            CenterToScreen();

            this.DoubleBuffered = true;

            MaximizeBox = false;
            MinimizeBox = false;

            txt_contraseña.PasswordChar = '•';

            txt_usuario.MaxLength = 20;
            txt_contraseña.MaxLength = 20;

            toolTip1.SetToolTip(txt_usuario, "Max. 20 caracteres.");
            toolTip1.SetToolTip(txt_contraseña, "Max. 20 caracteres.");

            txt_usuario.TabIndex = 0;
            txt_contraseña.TabIndex = 1;
            btn_login.TabIndex = 2;
            button1.TabIndex = 3;
        }

        private void cb_mostrar_contraseña_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_mostrar_contraseña.Checked == true)
            {
                txt_contraseña.PasswordChar = '\0';
            }
            else
            {
                txt_contraseña.PasswordChar = '•';
            }
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            trigger();
        }

        private void txt_contraseña_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                trigger();
            }
        }

        void trigger()
        {
            string usuario = txt_usuario.Text;
            string contraseña = txt_contraseña.Text;

            if (string.IsNullOrEmpty(usuario) || string.IsNullOrEmpty(contraseña))
            {
                MessageBox.Show("Debes llenar ambos campos para continuar.");
                return;
            }

            if (login.logear(usuario, contraseña))
            {
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Datos incorrectos.");
            }
        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            SendMessage.enviarMensaje();
        }
    }
}
