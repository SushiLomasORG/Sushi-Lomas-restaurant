using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sushi_Lomas_restaurant.Math
{
    public static class CalcularCambio
    {
        public static void cambio(string total, string conCuantoPaga, TextBox txt_feria)
        {
            decimal el_clienteDebe, el_clienteDa;

            bool totalValido = decimal.TryParse(total, out el_clienteDebe);
            bool pagoValido = decimal.TryParse(conCuantoPaga, out el_clienteDa);

            if (totalValido && pagoValido)
            {
                decimal cambio = el_clienteDa - el_clienteDebe;
                txt_feria.Text = cambio.ToString("0.00");
            }
            else
            {
                txt_feria.Text = "0.00";
            }
        }
    }
}
