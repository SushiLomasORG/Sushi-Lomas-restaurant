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
using Sushi_Lomas_restaurant.Windows.Generales;

namespace Sushi_Lomas_restaurant.Windows.Pedidos
{
    public partial class Ingresar_telefono : Form
    {
        int id = 0;
        int id_disponible = 0;

        bool existe;

        private Principal principal;


        public Ingresar_telefono(Principal principal)
        {
            InitializeComponent();

            this.DoubleBuffered = true;

            this.principal = principal;

            txt_Telefono.MaxLength = 10;
            txt_cliente.MaxLength = 20;
            txt_Telefono.TabIndex = 0;

            string telefono = txt_Telefono.Text;
            obtener_ultimoID();
        }

        private void btn_continuar_Click(object sender, EventArgs e)
        {
            if (txt_Telefono.Text.Length < 10)
            {
                MessageBox.Show("Ingresa un número telefónico correcto.");
                return;
            }
            if (string.IsNullOrEmpty(txt_cliente.Text))
            {
                MessageBox.Show("Ingresa el nombre del cliente");
                return;
            }

            Registrar_pedidos.existe = existe;
            Registrar_pedidos.telefono = txt_Telefono.Text;
            Registrar_pedidos.nombre_cliente = txt_cliente.Text;

            if (existe == true)
            {
                Registrar_pedidos.id_cliente = id;
            }
            else
            {
                Registrar_pedidos.id_cliente = id_disponible;
            }

            Registrar_pedidos rp = new Registrar_pedidos();
            principal.abrir_form(rp);

            this.Close();
        }

        private void txt_Telefono_TextChanged(object sender, EventArgs e)
        {
            if (txt_Telefono.Text.Length == 10)
            {   
                string telefono = txt_Telefono.Text;
              
                obtener_nombre();
                obtener_id();

                if (existe == true)
                {
                    txt_cliente.Enabled = false;

                    txt_Telefono.TabIndex = 0;
                    btn_continuar.TabIndex = 1;
                }
                else
                {
                    txt_cliente.Enabled = true;

                    txt_Telefono.TabIndex = 0;
                    txt_cliente.TabIndex = 1;
                    btn_continuar.TabIndex = 2;
                }
            }
            else
            {
                txt_cliente.Clear();
            }
        }

        void obtener_id()
        {
            try
            {
                string query = "SELECT id FROM Cliente WHERE telefono1 = @telefono OR telefono2 = @telefono";

                using (SqlConnection connection = Conect.GetConnection())
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@telefono", txt_Telefono.Text);

                    connection.Open();
                    object result = command.ExecuteScalar();

                    if (result != null)
                    {
                        id = (int)result;
                    }
                    else
                    {
                        id = 1;
                    }
                    command.Dispose();
                }
            }
            catch(Exception excep)
            {
                string msg = "Error: No se pudo obtener el ID del cliente: ";
                throw new Exception(msg + excep.Message);
            }
        }

        void obtener_nombre()
        {
            try
            {
                string query = "SELECT nombre FROM Cliente WHERE telefono1 = @telefono OR telefono2 = @telefono";

                using (SqlConnection connection = Conect.GetConnection())
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@telefono", txt_Telefono.Text);

                    connection.Open();
                    object result = command.ExecuteScalar();

                    if (result != null)
                    {
                        txt_cliente.Enabled = false;
                        txt_cliente.Text = result.ToString();
                        existe = true;
                    }
                    else
                    {
                        existe = false;
                        txt_cliente.Enabled = true;
                    }
                    command.Dispose();
                }
            }
            catch(Exception excep)
            {
                string msg = "Error: No se pudo obtener el NOMBRE del cliente: ";
                throw new Exception(msg + excep.Message);
            }
        }

        void obtener_ultimoID()
        {
            try
            {
                string query = "SELECT TOP 1 id FROM Cliente where activo = 1 ORDER BY id DESC";

                using (SqlConnection connection = Conect.GetConnection())
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();
                    object result = command.ExecuteScalar();

                    if (result != null)
                    {
                        id_disponible = (int)result + 1;
                    }
                    else
                    {
                        id_disponible = 1;
                    }
                    command.Dispose();
                }
            }
            catch(Exception excep)
            {
                string msg = "Error: No se pudo obtener el ultimo ID disponible para el cliente: ";
                throw new Exception(msg + excep.Message);
            }
        }

        private void txt_Telefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txt_cliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
