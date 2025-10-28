using Sushi_Lomas_restaurant.Class;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sushi_Lomas_restaurant.Math
{
    public static class GastosCompras
    {
        public static void registrar(DataGridView dataGridView1, string opcion)
        {
            try
            {
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (row.IsNewRow)
                        continue;

                    using (SqlConnection conect = Conect.GetConnection())
                    using (SqlCommand command = new SqlCommand($"INSERT INTO gastos_compras(concepto, cantidad_dinero, cantidad_producto, tipo) VALUES(@concepto, @cantidad_dinero, @cantidad_producto, '{opcion}')", conect))
                    {
                        string concepto = row.Cells[0].Value.ToString();
                        decimal c_d = 0;
                        decimal c_p = 0;

                        if (row.Cells[2].Value != null &&
                        !string.IsNullOrWhiteSpace(row.Cells[2].Value.ToString()))
                        {
                            decimal.TryParse(row.Cells[2].Value.ToString(), out c_d);
                        }

                        if (row.Cells[1].Value != null &&
                            !string.IsNullOrWhiteSpace(row.Cells[1].Value.ToString()))
                        {
                            decimal.TryParse(row.Cells[1].Value.ToString(), out c_p);
                        }

                        command.Parameters.AddWithValue("@concepto", concepto);
                        command.Parameters.AddWithValue("@cantidad_dinero", c_d);
                        command.Parameters.AddWithValue("@cantidad_producto", c_p);

                        conect.Open();

                        int resultado = command.ExecuteNonQuery();

                        MessageBox.Show(resultado > 0 ? "Registro exitoso." : "Error al registrar.");
                    }
                }
            }
            catch (Exception excep)
            {
                MessageBox.Show("Error: " + excep.Message);
            }
        }
    }
}
