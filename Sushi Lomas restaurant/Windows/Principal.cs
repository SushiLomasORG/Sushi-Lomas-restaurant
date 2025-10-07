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
using Sushi_Lomas_restaurant.Styles;
using Sushi_Lomas_restaurant.Windows.Administracion;
using Sushi_Lomas_restaurant.Windows.Generales;
using Sushi_Lomas_restaurant.Windows.Pedidos;

namespace Sushi_Lomas_restaurant.Windows
{
    public partial class Principal : Form
    {
        private Form formulario_Activo = null;
        StyleButton stylebutton = new StyleButton();

        public Principal()
        {
            InitializeComponent();
            cargar_estilos();

            this.DoubleBuffered = true;
        }

        private void btn_registrarPedido_Click(object sender, EventArgs e)
        {
            abrir_form(new Ingresar_telefono(this));
        }

        private void btn_listaPedido_Click(object sender, EventArgs e)
        {
            abrir_form(new Lista_de_pedidos());
        }

        private void btn_registrarGastosCompras_Click(object sender, EventArgs e)
        {
            abrir_form(new Registrar_gastos_y_compras());
        }

        private void btn_corteCaja_Click(object sender, EventArgs e)
        {

        }

        private void btn_registrarCliente_Click(object sender, EventArgs e)
        { 

        }

        private void btn_administrarClientes_Click(object sender, EventArgs e)
        {

        }

        private void btn_administrarProductos_Click(object sender, EventArgs e)
        {

        }

        private void btn_administrarPrecios_Click(object sender, EventArgs e)
        {

        }

        private void btn_administrarInventario_Click(object sender, EventArgs e)
        {

        }

        private void btn_administrarUsuarios_Click(object sender, EventArgs e)
        {

        }

        private void btn_cerrarFormulario_Click(object sender, EventArgs e)
        {
            cerrar_form();
        }

        public void abrir_form(Form formulario)
        {
            if (formulario_Activo != null)
                formulario_Activo.Close();
            formulario_Activo = formulario;
            formulario.TopLevel = false;
            formulario.FormBorderStyle = FormBorderStyle.None;
            //formulario.Dock = DockStyle.Fill;
            formulario.StartPosition = FormStartPosition.CenterScreen;
            panel1.Controls.Add(formulario);
            formulario.BringToFront();
            formulario.Show();
        }

        void cerrar_form()
        {
            if (formulario_Activo != null)
            {
                formulario_Activo.Close();
                formulario_Activo = null;
            }
        }

        void cargar_estilos()
        {
            stylebutton.estilo_boton(btn_registrarPedido);
            stylebutton.estilo_boton(btn_listaPedido);
            stylebutton.estilo_boton(btn_registrarGastosCompras);
            stylebutton.estilo_boton(btn_corteCaja);
            stylebutton.estilo_boton(btn_registrarCliente);
            stylebutton.estilo_boton(btn_administrarClientes);
            stylebutton.estilo_boton(btn_administrarProductos);
            stylebutton.estilo_boton(btn_administrarPrecios);
            stylebutton.estilo_boton(btn_administrarUsuarios);
            stylebutton.estilo_boton(btn_administrarInventario);
            stylebutton.estilo_boton(btn_salir);
            stylebutton.estilo_boton(btn_cerrarFormulario);

            lbl_nombreUsuario.Text = UserInfo.usuario;
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
