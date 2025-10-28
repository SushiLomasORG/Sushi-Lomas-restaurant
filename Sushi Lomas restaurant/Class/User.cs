using Sushi_Lomas_restaurant.Windows.Administracion;
using Sushi_Lomas_restaurant.Windows.Sistema;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sushi_Lomas_restaurant.Class
{
    public static class User
    {
        public static void lista(DataGridView dataGridView1)
        {
            using (SqlConnection conect = Conect.GetConnection())
            using (SqlDataAdapter adapter = new SqlDataAdapter("SELECT id, nombre FROM Usuario WHERE activo = 1;", conect))
            {
                DataTable table = new DataTable();
                adapter.Fill(table);

                dataGridView1.DataSource = table;
            }
        }
        
        public static void verificar_existencia(string nombre, Label lbl)
        {
            try
            {
                using (SqlConnection conect = Conect.GetConnection())
                using (SqlCommand command = new SqlCommand("SELECT COUNT(*) FROM Usuario WHERE nombre = @nombre", conect))
                {
                    command.Parameters.AddWithValue("@nombre", nombre);

                    conect.Open();
                    int count = (int)command.ExecuteScalar();

                    if (count > 0)
                    {
                        lbl.Text = "Nombre no disponible."; lbl.ForeColor = Color.Tomato;
                    }
                    else
                    {
                        lbl.Text = "Nombre disponible."; lbl.ForeColor = Color.SeaGreen;
                    }
                }
            }
            catch (Exception excep)
            {
                MessageBox.Show("Error: " + excep.Message);
            }
        }

        public static void registrar(string nombre, int rol, string contraseña)
        {
            try
            {
                using (SqlConnection conect = Conect.GetConnection())
                using (SqlCommand command = new SqlCommand("INSERT INTO Usuario(nombre, rol, contraseña) VALUES(@nombre, @rol, @contraseña)", conect))
                {
                    command.Parameters.AddWithValue("@nombre", nombre);
                    command.Parameters.AddWithValue("@rol", rol);
                    command.Parameters.AddWithValue("@contraseña", contraseña);

                    conect.Open();
                    int resultado = command.ExecuteNonQuery();

                    MessageBox.Show(resultado > 0 ? "Usuario registrado con éxito." : "Error al registrar al usuario.");
                }
            }
            catch (Exception excep)
            {
                MessageBox.Show("Error: " + excep.Message);
            }
        }

        public static void desactivar(int id_usuario)
        {
            try
            {
                using (SqlConnection conect = Conect.GetConnection())
                using (SqlCommand command = new SqlCommand("UPDATE Usuario SET activo = 0 WHERE id = @id", conect))
                {
                    command.Parameters.AddWithValue("@id", id_usuario);
     
                    conect.Open();
                    int resultado = command.ExecuteNonQuery();

                    MessageBox.Show(resultado > 0 ? "Usuario eliminado con éxito." : "Error al eliminar al usuario.");
                }
            }
            catch (Exception excep)
            {
                MessageBox.Show("Error: " + excep.Message);
            }
        }

        public static void cambiar_contraseña(string nombre, string contraseña)
        {
            try
            {
                using (SqlConnection conect = Conect.GetConnection())
                using (SqlCommand command = new SqlCommand("UPDATE Usuario SET contraseña = @contraseña WHERE nombre = @nombre", conect))
                {
                    command.Parameters.AddWithValue("@contraseña", contraseña);
                    command.Parameters.AddWithValue("@nombre", nombre);

                    int resultado = command.ExecuteNonQuery();

                    MessageBox.Show(resultado > 0 ? "Contraseña actualizada." : "Error al actualizar la contraseña.");
                }
            }
            catch (Exception excep)
            {
                MessageBox.Show("Error: " + excep.Message);
            }
        }
    }
}
