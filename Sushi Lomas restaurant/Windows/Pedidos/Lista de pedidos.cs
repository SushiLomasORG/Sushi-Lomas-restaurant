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
using Sushi_Lomas_restaurant.Styles;

namespace Sushi_Lomas_restaurant.Windows.Pedidos
{
    public partial class Lista_de_pedidos : Form
    {
        public Lista_de_pedidos()
        {
            InitializeComponent();
            Style();

            this.DoubleBuffered = true;

            dataGridView1.ReadOnly = true;
        }

        int tipo = 0;
        int id_pedido = 0;

        bool permiso;

        private void POR_ENTREGAR_Click(object sender, EventArgs e)
        {
            tipo = 1;
            list();
            permiso = false;
        }

        private void ENTREGADO_Click(object sender, EventArgs e)
        {
            tipo = 2;
            list();
            permiso = false;

        }

        private void TODO_Click(object sender, EventArgs e)
        {
            tipo = 3;
            list();
            permiso = false;

        }

        private void TERMINAR_PEDIDO_Click(object sender, EventArgs e)
        {
            terminar_pedido();

            tipo = 1;
            list();

        }

        private void txt_filtrar_TextChanged(object sender, EventArgs e)
        {
            if (txt_filtrar.Text.Length > 0)
            {
                if (tipo == 0)
                {
                    list();
                }
                else if (tipo == 1 || tipo == 2)
                {
                    listxTipo();
                }
            }
            else
            {
                list();
            }
        }

        private void REIMPRIMIR_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                object valor = dataGridView1.Rows[e.RowIndex].Cells[0].Value;

                if (valor != null && int.TryParse(valor.ToString(), out int id_pedido))
                {
                    ver_detalle();
                    permiso = true;
                }
                else
                {
                    MessageBox.Show("Para volver a la lista normal usa cualquiera de las opciones de la izquierda.");
                }
            }
        }


        void terminar_pedido()
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Primero debes seleccionar el pedido que quieres terminar.");
                return;
            }

            id_pedido = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);

            try
            {
                string consulta = "Update Pedido set estado = 2 where id = @id";

                using (SqlConnection conect = Conect.GetConnection())
                using (SqlCommand command = new SqlCommand(consulta, conect))
                {
                    command.Parameters.AddWithValue("@id", id_pedido);

                    conect.Open();
                    int resultado = command.ExecuteNonQuery();

                    if (resultado > 0)
                    {
                        MessageBox.Show("Operación exitosa.");
                    }
                    else
                    {
                        MessageBox.Show("Error: no se pudo determinar el número del pedido.");
                    }
                    command.Dispose();
                }
            }
            catch(Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        void list()
        {
            try
            {
                string consulta = 

                using (SqlConnection conect = Conect.GetConnection())
                using (SqlDataAdapter adp = new SqlDataAdapter(consulta, conect))
                {
                    DataTable dt = new DataTable();
                    adp.Fill(dt);

                    dataGridView1.DataSource = dt;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show($"Error: {e.Message}");
            }
        }
        void listxTipo()
        {
            try
            {
                string consulta
                ;

                using (SqlConnection conect = Conect.GetConnection())
                using (SqlDataAdapter adp = new SqlDataAdapter(consulta, conect))
                {
                    DataTable dt = new DataTable();
                    adp.Fill(dt);

                    dataGridView1.DataSource = dt;
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        void ver_detalle()
        {
            try
            {
                string consulta =
                ;

                using (SqlConnection conect = Conect.GetConnection())
                using (SqlDataAdapter adp = new SqlDataAdapter(consulta, conect))
                {
                    DataTable dt = new DataTable();
                    adp.Fill(dt);

                    dataGridView1.DataSource = dt;
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        void Style()
        {
            StyleButton style = new StyleButton();

            style.estilo_boton(POR_ENTREGAR);
            style.estilo_boton(ENTREGADO);
            style.estilo_boton(TODO);
            style.estilo_boton(TERMINAR_PEDIDO);
            style.estilo_boton(REIMPRIMIR);
        }
    }
}
