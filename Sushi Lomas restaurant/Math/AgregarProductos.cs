using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sushi_Lomas_restaurant.Math
{
    public static class AgregarProductos
    {
        public static void comanda(DataGridView dataGridView_productos, DataGridView dataGridView_comanda, string detalles, TextBox txt_filtrarProducto)
        {
            if (dataGridView_productos.SelectedRows.Count > 0)
            {
                DataGridViewRow fila = dataGridView_productos.SelectedRows[0];

                if (fila.Cells[0].Value == null || fila.Cells[1].Value == null || fila.Cells[2].Value == null)
                {
                    MessageBox.Show("El producto seleccionado tiene información incompleta, falta: (ID, Nombre o Precio).");
                    return;
                }

                string detalle = string.IsNullOrWhiteSpace(detalles) || detalles == "Ej: sin chippotle" ? null : detalles.Trim();

                if (!int.TryParse(fila.Cells[0].Value.ToString(), out int id))
                {
                    MessageBox.Show("El ID del producto no es válido.");
                    return;
                }

                string producto = fila.Cells[1].Value.ToString();
                if (string.IsNullOrWhiteSpace(producto))
                {
                    MessageBox.Show("El nombre del producto está vacío.");
                    return;
                }

                if (!decimal.TryParse(fila.Cells[2].Value.ToString(), out decimal precio))
                {
                    MessageBox.Show("El precio del producto no es válido.");
                    return;
                }

                dataGridView_comanda.Rows.Add(id, producto, 1, precio, detalle);
            }
            else
            {
                MessageBox.Show("Selecciona la fila del producto para poder agregarlo.");
            }

            txt_filtrarProducto.Clear();
        }
    }
}
