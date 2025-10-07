using Sushi_Lomas_restaurant.Windows.Administracion;
using Sushi_Lomas_restaurant.Windows.Pedidos;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sushi_Lomas_restaurant.Class
{
    public static class Product
    {
        public static void list(string filtro, int tipo, DataGridView dataGridView_producto, int tipoLista)
        {       

            if (tipoLista == 1)
            {
                using (SqlConnection conect = Conect.GetConnection())
                using (SqlDataAdapter adaptador = new SqlDataAdapter(consulta_lista, conect))
                {
                    DataTable table = new DataTable();
                    adaptador.Fill(table);

                    dataGridView_producto.DataSource = table;
                }
            }
            else if (tipoLista == 2) 
            {
                using (SqlConnection conect = Conect.GetConnection())
                using (SqlDataAdapter adaptador = new SqlDataAdapter(consulta_lista_Bebidas, conect))
                {
                    DataTable table = new DataTable();
                    adaptador.Fill(table);

                    dataGridView_producto.DataSource = table;
                }
            }
            else if (tipoLista == 3)
            {
                using (SqlConnection conect = Conect.GetConnection())
                using (SqlDataAdapter adaptador = new SqlDataAdapter(consulta_lista_todo, conect))
                {
                    DataTable table = new DataTable();
                    adaptador.Fill(table);

                    dataGridView_producto.DataSource = table;
                }
            }
        }

        public static void lista_Simple(DataGridView dataGridView1, string producto, int tipo)
        {
            DataTable table = new DataTable();

            using (SqlConnection conect = Conect.GetConnection())
            using (SqlDataAdapter adapter = new SqlDataAdapter())
            {

                adapter.SelectCommand = new SqlCommand(conect);
                adapter.SelectCommand.CommandType = CommandType.Text;

                adapter.SelectCommand.Parameters.AddWithValue("@tipo", tipo);

                if (!string.IsNullOrEmpty(producto))
                {
                    adapter.SelectCommand.Parameters.AddWithValue("@nombre", "%" + producto + "%");
                }

                adapter.Fill(table);
                dataGridView1.DataSource = table;
            }
        }

        public static void listaINV(DataGridView dataGridView1)
        {
            using (SqlConnection conect = Conect.GetConnection();

            {
                DataTable table = new DataTable();

                dataGridView1.DataSource = table;

                dataGridView1.EnableHeadersVisualStyles = false; 
                dataGridView1.ClearSelection();
                dataGridView1.CurrentCell = null;
            }
        }
        
        public static void lista_x_stockINV(DataGridView dataGridView1, int umbral)
        {
        }

        public static void registrar(string nombre, int precio, int tipo)
        {
            try
            {
                using (SqlConnection conect = Conect.GetConnection())
                using (SqlCommand command = new SqlCommand("INSERT INTO Articulo(nombre, precio, tipo) VALUES(@nombre, @precio, @tipo)", conect))
                {
                    command.Parameters.AddWithValue("@nombre", nombre);
                    command.Parameters.AddWithValue("@precio", precio);
                    command.Parameters.AddWithValue("@tipo", tipo);

                    conect.Open();
                    int resultado = command.ExecuteNonQuery();

                    MessageBox.Show(resultado > 0 ? "Artículo registrado con éxito." : "Error al registrar el artículo.");
                    command.Dispose();
                }
            }
            catch (Exception excep)
            {
                MessageBox.Show("Error: " + excep.Message);
            }
        }

        public static void obtenerID(string articulo)
        {
            try
            {
                using (SqlConnection conect = Conect.GetConnection())
                using (SqlCommand command = new SqlCommand("SELECT id FROM Articulo WHERE nombre = @nombre", conect))
                {
                    command.Parameters.AddWithValue("@nombre", articulo);

                    conect.Open();
                    object result = command.ExecuteScalar();
                    if (result != null)
                    {
                        Administrar_inventario.id_articulo = (int)result;
                    }
                    else
                    {
                        MessageBox.Show("Error al obtener el ID del producto.");
                    }
                    command.Dispose();
                }
            }
            catch (Exception excep)
            {
                MessageBox.Show("Error al obtener el ID del producto: " + excep.Message);
            }
        }

        public static void comprobarExistencia(string nombre, Label lbl_msgProducto)
        {
            try
            {
                using (SqlConnection conect = Conect.GetConnection())
                using (SqlCommand command = new SqlCommand("SELECT COUNT(*) FROM Articulo WHERE nombre = @nombre", conect))
                {
                    command.Parameters.AddWithValue("@nombre", nombre);

                    conect.Open();
                    int count = (int)command.ExecuteScalar();
                    if (count > 0)
                    {
                        lbl_msgProducto.Text = "Nombre no disponible.";
                        lbl_msgProducto.ForeColor = Color.Tomato;
                    }
                    else
                    {
                        lbl_msgProducto.Text = "Nombre disponible.";
                        lbl_msgProducto.ForeColor = Color.SeaGreen;
                    }
                    command.Dispose();
                }
            }
            catch (Exception excep)
            {
                MessageBox.Show("Error al obtener el ID del producto: " + excep.Message);
            }
        }

        public static void actualizar_precio(string nuevoPrecio, string producto)
        {
            try
            {
                using (SqlConnection conect = Conect.GetConnection())
                using (SqlCommand c = new SqlCommand("update Articulo set precio = @precio where nombre = @nombre", conect))
                {
                    c.Parameters.AddWithValue("@precio", nuevoPrecio);
                    c.Parameters.AddWithValue("@nombre", producto);

                    conect.Open();
                    int r = c.ExecuteNonQuery();
                    MessageBox.Show(r > 0 ? "El precio cambio con éxito." : "Error al cambiar el precio.");
                    c.Dispose();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show($"Error: {e.Message}");
            }
        }

        public static void alimentar_inv(int cantidad, int id_articulo, int stock)
        {

        }
    }
}   
