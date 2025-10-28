using Sushi_Lomas_restaurant.Class;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sushi_Lomas_restaurant.Math
{
    public static class CorteCaja
    {
        public static void registrar(decimal venta, decimal gasto, decimal compra, decimal ganancia)
        {
            try
            {
                using (SqlConnection conect = Conect.GetConnection())
                using (SqlCommand command = new SqlCommand("INSERT INTO corte_caja(venta, gasto, compra, ganancia) VALUES (@venta, @gasto, @compra, @ganancia)", conect))
                {
                    command.Parameters.AddWithValue("@venta", venta);
                    command.Parameters.AddWithValue("@gasto", gasto);
                    command.Parameters.AddWithValue("@compra", compra);
                    command.Parameters.AddWithValue("@ganancias", ganancia);

                    conect.Open();
                    int resultado = command.ExecuteNonQuery();

                    MessageBox.Show(resultado > 0 ? "Registro exitoso." : "Error al registrar.");
                }
            }
            catch (Exception excep)
            {
                MessageBox.Show("Error: " + excep.Message);
            }
        }

        public static void desgloce_datos(DataGridView dataGridView1)
        {

        }
        
        public static decimal obtener(string tabla, string columna, string tipo = null)
        {
 
        }
    }
}
