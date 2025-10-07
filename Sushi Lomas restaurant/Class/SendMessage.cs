using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sushi_Lomas_restaurant.Class
{
    public static class SendMessage
    {
        private static string tel = "6871451508";
        private static string url = $"whatsapp://send?phone={tel}";

        public static void enviarMensaje()
        {
            Process.Start(new ProcessStartInfo { FileName = url, UseShellExecute = true });
        }
    }
}
