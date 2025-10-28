using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sushi_Lomas_restaurant.Styles
{
    internal class StyleButton
    {
        public void estilo_boton(Button btn)
        {
            btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(50, Color.Black); 
            btn.FlatAppearance.MouseDownBackColor = Color.FromArgb(80, Color.Black); 
        }
    }
}
