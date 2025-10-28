using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.Configuration;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sushi_Lomas_restaurant.Windows.Pedidos;

namespace Sushi_Lomas_restaurant.Class
{
    public static class Client
    {
        public static void registrar(string nombre, string telefono1, string telefono2, string direccion1, string direccion2)
        {
            try
            {
                string consulta = "INSERT INTO Cliente(nombre, telefono1, telefono2, direccion1, direccion2) VALUES(@nombre, @telefono1, @telefono2, @direccion1, @direccion2)";

                using (SqlConnection conect = Conect.GetConnection())
                using (SqlCommand command = new SqlCommand(consulta, conect))
                {
                    command.Parameters.AddWithValue("@nombre", nombre);
                    command.Parameters.AddWithValue("@telefono1", telefono1);
                    command.Parameters.AddWithValue("@telefono2", string.IsNullOrEmpty(telefono2) ? (object)DBNull.Value : telefono2);
                    command.Parameters.AddWithValue("@direccion1", direccion1);
                    command.Parameters.AddWithValue("@direccion2", string.IsNullOrEmpty(direccion2) ? (object)DBNull.Value : direccion2);


                    conect.Open();
                    int result = command.ExecuteNonQuery();

                    MessageBox.Show(result > 0 ? "Registro exitoso." : "Error al registrar.");
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Error: " + e.Message);
            }
        }

        public static void registrar_xPedido(string direccion)
        {
            try
            {
                string consulta = "INSERT INTO Cliente(nombre, telefono1, telefono2, direccion1, direccion2) VALUES(@nombre, @telefono1, 'NA', @direccion1, 'NA')";

                using (SqlConnection conect = Conect.GetConnection())
                using (SqlCommand command = new SqlCommand(consulta, conect))
                {
                    command.Parameters.AddWithValue("@nombre", Registrar_pedidos.nombre_cliente);
                    command.Parameters.AddWithValue("@telefono1", Registrar_pedidos.telefono);
                    command.Parameters.AddWithValue("@direccion1", direccion);

                    conect.Open();
                    int result = command.ExecuteNonQuery();

                    if (result == 0)
                    {
                        throw new Exception("Error al registrar al cliente: ");
                    }
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public static void obtener_direccion(ComboBox cmb_direccion)
        {
            try
            {
                string consulta = "SELECT direccion1, direccion2 FROM Cliente WHERE telefono1 = @telefono OR telefono2 = @telefono";

                using (SqlConnection conect = Conect.GetConnection())
                using (SqlCommand command = new SqlCommand(consulta, conect))
                {
                    command.Parameters.AddWithValue("@telefono", Registrar_pedidos.telefono);

                    conect.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        if (reader["direccion1"] != DBNull.Value)
                            cmb_direccion.Items.Add(reader["direccion1"].ToString());
                        if (reader["direccion2"] != DBNull.Value)
                            cmb_direccion.Items.Add(reader["direccion2"].ToString());
                    }
                    reader.Close();
                    command.Dispose();
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public static void comprobarExistencia(string telefono1, string telefono2, string direccion1, string direccion2, int opcion, Label lbl)
        {
            try
            {
                if (opcion == 1)
                {
                    using (SqlConnection conect = Conect.GetConnection())
                    using (SqlCommand command = new SqlCommand(
                    @"SELECT COUNT(*) 
                    FROM Cliente 
                    WHERE telefono1 = @telefono1 OR telefono2 = @telefono1
                    OR telefono1 = @telefono2 OR telefono2 = @telefono2", conect))
                    {
                        command.Parameters.AddWithValue("@telefono1", telefono1);
                        command.Parameters.AddWithValue("@telefono2", telefono2);

                        conect.Open();

                        int count = (int)command.ExecuteScalar();
                        if (count > 0)
                        {
                            lbl.Text = "No disponible."; lbl.ForeColor = Color.Tomato;
                        }
                        else
                        {
                            lbl.Text = "Disponible."; lbl.ForeColor = Color.SeaGreen;
                        }
                    }
                }
                else if (opcion == 2)
                {
                    using (SqlConnection conect = Conect.GetConnection())
                    using (SqlCommand command = new SqlCommand(
                    @"SELECT COUNT(*) 
                    FROM Cliente 
                    WHERE direccion1 = @direccion1 OR direccion2 = @direccion1
                    OR direccion1 = @direccion2 OR direccion2 = @direccion2", conect))
                    {
                        command.Parameters.AddWithValue("@direccion1", direccion1);
                        command.Parameters.AddWithValue("@direccion2", direccion2);

                        conect.Open();

                        int count = (int)command.ExecuteScalar();
                        if (count > 0)
                        {
                            lbl.Text = "No disponible."; lbl.ForeColor = Color.Tomato;
                        }
                        else
                        {
                            lbl.Text = "Disponible."; lbl.ForeColor = Color.SeaGreen;
                        }
                    }
                }
            }
            catch (Exception excep)
            {
                MessageBox.Show("Error al obtener los datos: " + excep.Message);
            }
        }


        private static SqlDataAdapter da;
        private static DataTable dt;
        private static SqlConnection con = Conect.GetConnection();

        public static void lista(DataGridView dataGridView1, string filtro)
        {
            try
            {
                // Consulta base
                string query = "SELECT id, nombre, telefono1, telefono2, direccion1, direccion2, fecha_registro, activo FROM Cliente";

                // Si hay filtro, agregamos WHERE con LIKE
                if (!string.IsNullOrEmpty(filtro))
                {
                    query += " WHERE telefono1 LIKE @telefono OR telefono2 LIKE @telefono";
                }

                da = new SqlDataAdapter(query, con);

                // Si hay filtro, agregamos parámetro
                if (!string.IsNullOrEmpty(filtro))
                {
                    da.SelectCommand.Parameters.AddWithValue("@telefono", "%" + filtro + "%");
                }

                SqlCommandBuilder cb = new SqlCommandBuilder(da);

                dt = new DataTable();
                da.Fill(dt);

                dataGridView1.DataSource = dt;
                dataGridView1.Columns["id"].ReadOnly = true;
                dataGridView1.Columns["fecha_registro"].ReadOnly = true;
                dataGridView1.Columns["activo"].ReadOnly = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al listar: " + ex.Message);
            }
        }

        public static void actualizarDatos()
        {
            try
            {
                SqlCommandBuilder cb = new SqlCommandBuilder(da);
                da.UpdateCommand = cb.GetUpdateCommand();
                da.UpdateCommand.Connection = con;

                if (con.State != ConnectionState.Open)
                    con.Open();

                da.Update(dt);
                MessageBox.Show("Cambios guardados correctamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar: " + ex.Message);
            }
        }
    }
}
