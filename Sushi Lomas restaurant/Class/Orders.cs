using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sushi_Lomas_restaurant.Windows.Pedidos;

namespace Sushi_Lomas_restaurant.Class
{
    public static class Orders
    {
        static Registrar_pedidos re = new Registrar_pedidos();

        public static void Registrar(DataGridView dataGridView_comanda, string total, string direccion, int lugar, int n_pedido)
        {
            if (lugar != 0 && lugar != 1)
            {
                return;
            }

            try
            {
                using (SqlConnection conect = Conect.GetConnection())
                {
                    conect.Open();

                    using (SqlTransaction transact = conect.BeginTransaction())
                    {
                        try
                        {
                            // Insertar en Pedido
                            using (SqlCommand comand1 = new SqlCommand(@"
                            INSERT INTO Pedido(total, lugar, id_cliente, estado, n_pedido, telefono) 
                            VALUES(@total, @lugar, @id_cliente, 1, @n_pedido, @telefono); 
                            SELECT SCOPE_IDENTITY();", conect, transact))
                            {
                                comand1.Parameters.AddWithValue("@total", total);
                                comand1.Parameters.AddWithValue("@lugar", lugar);
                                comand1.Parameters.AddWithValue("@id_cliente", Registrar_pedidos.id_cliente);
                                comand1.Parameters.AddWithValue("@n_pedido", n_pedido);
                                comand1.Parameters.AddWithValue("@telefono", Registrar_pedidos.telefono);

                                int id_pedido = Convert.ToInt32(comand1.ExecuteScalar());

                                foreach (DataGridViewRow row in dataGridView_comanda.Rows)
                                {
                                    if (row.IsNewRow)
                                        continue;

                                    string detalle = row.Cells[4].Value?.ToString();

                                    if (!decimal.TryParse(row.Cells[3].Value?.ToString(), out decimal precioUnitario))
                                        throw new Exception("Error: precio_unitario inválido.");

                                    if (!int.TryParse(row.Cells[2].Value?.ToString(), out int cantidadProducto))
                                        throw new Exception("Error: cantidad inválida.");

                                    if (!int.TryParse(row.Cells[0].Value?.ToString(), out int id_articulos))
                                        throw new Exception("Error: artículo inválido.");

                                    // Insertar en Detalle_pedido
                                    using (SqlCommand command2 = new SqlCommand(@"
                                    INSERT INTO Detalle_pedido(detalle, precio_unitario, cantidad, articulo, id_pedido) 
                                    VALUES(@detalle, @precio_unitario, @cantidad, @articulo, @id_pedido); 
                                    SELECT SCOPE_IDENTITY();", conect, transact))
                                    {
                                        command2.Parameters.AddWithValue("@detalle", string.IsNullOrEmpty(detalle) ? (object)DBNull.Value : detalle);
                                        command2.Parameters.AddWithValue("@precio_unitario", precioUnitario);
                                        command2.Parameters.AddWithValue("@cantidad", cantidadProducto);
                                        command2.Parameters.AddWithValue("@articulo", id_articulos);
                                        command2.Parameters.AddWithValue("@id_pedido", id_pedido);

                                        int id_detallePedido = Convert.ToInt32(command2.ExecuteScalar());

                                        // Verificar tipo de artículo
                                        using (SqlCommand verificar_tipo = new SqlCommand(
                                            "SELECT tipo FROM articulo WHERE id = @id_articulo", conect, transact))
                                        {
                                            verificar_tipo.Parameters.AddWithValue("@id_articulo", id_articulos);
                                            int tipo = Convert.ToInt32(verificar_tipo.ExecuteScalar());

                                            if (tipo == 6)
                                            {
                                                // Verificar stock
                                                using (SqlCommand obtener_stock = new SqlCommand(
                                                    "SELECT stock FROM inventario WHERE articulo = @id_articulo", conect, transact))
                                                {
                                                    obtener_stock.Parameters.AddWithValue("@id_articulo", id_articulos);
                                                    int stock_actual = Convert.ToInt32(obtener_stock.ExecuteScalar());

                                                    if (stock_actual < cantidadProducto)
                                                        throw new Exception($"Stock insuficiente para el artículo con ID {id_articulos}. Disponible: {stock_actual}, solicitado: {cantidadProducto}");

                                                    // Actualizar inventario
                                                    using (SqlCommand actualizar_i = new SqlCommand(
                                                        "UPDATE inventario SET stock = stock - @cantidad WHERE articulo = @id_articulo", conect, transact))
                                                    {
                                                        actualizar_i.Parameters.AddWithValue("@cantidad", cantidadProducto);
                                                        actualizar_i.Parameters.AddWithValue("@id_articulo", id_articulos);

                                                        int resultado = actualizar_i.ExecuteNonQuery();
                                                        if (resultado <= 0)
                                                            throw new Exception("No se pudo actualizar el inventario para el producto con ID " + id_articulos);
                                                    }
                                                }
                                            }
                                        }

                                        // Insertar en pedido_domicilio si aplica
                                        if (lugar == 1)
                                        {
                                            using (SqlCommand comand3 = new SqlCommand(
                                                "INSERT INTO Pedido_domicilio(id_pedido, id_detalle, Direccion) VALUES (@id_pedido, @id_detalle, @Direccion)", conect, transact))
                                            {
                                                comand3.Parameters.AddWithValue("@id_pedido", id_pedido);
                                                comand3.Parameters.AddWithValue("@id_detalle", id_detallePedido);
                                                comand3.Parameters.AddWithValue("@Direccion", direccion);

                                                int i2 = comand3.ExecuteNonQuery();
                                                if (i2 <= 0)
                                                    throw new Exception("No se pudo insertar en Pedido_domicilio.");
                                            }
                                        }
                                    }
                                }
                            }

                            // Confirmar transacción
                            transact.Commit();
                            MessageBox.Show("Registro exitoso.");
                        }
                        catch (Exception excep)
                        {
                            transact.Rollback();
                            MessageBox.Show("Error al registrar el pedido: " + excep.Message);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        //
    }
}

