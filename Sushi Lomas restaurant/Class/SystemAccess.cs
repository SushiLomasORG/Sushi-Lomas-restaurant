using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sushi_Lomas_restaurant.Class
{
    public class SystemAccess
    {
        public int acceso;

        public void verificar()
        {
            string consulta = "SELECT acceso FROM sistem_acces WHERE sistema = 'Sushi Lomas'";

            try
            {
                using (SqlConnection conect = Conect.GetConnection())
                using (SqlCommand command = new SqlCommand(consulta, conect))
                {
                    conect.Open();
                    object result = command.ExecuteScalar();
                    if (result != null)
                    {
                        acceso = Convert.ToInt32(result);
                    }
                    else
                    {
                        acceso = 0;
                    }
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}
