using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sushi_Lomas_restaurant.Class
{
    public static class Conect
    {
        private static string db = "Data Source=(local);Initial Catalog=Sushi_lomas_sc1;Integrated Security=True;";

        public static SqlConnection GetConnection()
        {
            return new SqlConnection(db);
        }
    }
}
