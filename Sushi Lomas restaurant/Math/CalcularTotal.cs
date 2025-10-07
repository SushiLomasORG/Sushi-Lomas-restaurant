using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sushi_Lomas_restaurant.Math
{
    public static class CalcularTotal
    {
        public static void cuenta(DataGridView dataGridView_comanda, int lugar, string direccionTXT, ComboBox cmb_direccion, Label lbl_total)
        {
            decimal total = 0;

            foreach (DataGridViewRow row in dataGridView_comanda.Rows)
            {
                if (row.IsNewRow)
                    continue;

                if (row.Cells[2].Value == null || row.Cells[3].Value == null)
                    continue;

                if (decimal.TryParse(row.Cells[2].Value.ToString(), out decimal cantidad) && decimal.TryParse(row.Cells[3].Value.ToString(), out decimal precio))
                {
                    total += cantidad * precio;
                }
            }

            if (lugar == 1)
            {
                if (!string.IsNullOrEmpty(direccionTXT) || cmb_direccion.SelectedIndex != -1)
                {
                    total += 10;
                }
                else
                {
                    total -= 10;
                }
            }

            lbl_total.Text = total.ToString();
        }
    }
}
