using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sushi_Lomas_restaurant.Class;
using Sushi_Lomas_restaurant.Windows;
using Sushi_Lomas_restaurant.Windows.Administracion;
using Sushi_Lomas_restaurant.Windows.Generales;
using Sushi_Lomas_restaurant.Windows.Pedidos;
using Sushi_Lomas_restaurant.Windows.Sistema;

namespace Sushi_Lomas_restaurant
{
    internal static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //SystemAccess sa = new SystemAccess();
            //sa.verificar();

            //if (sa.acceso != 1)
            //{
            //    MessageBox.Show("No tienes acceso a la aplicación.");
            //    return;
            //}

            using (Identiicarse id = new Identiicarse())
            {
                if (id.ShowDialog() == DialogResult.OK)
                {
                    Application.Run(new Principal());
                }
            }
        }
    }
}
