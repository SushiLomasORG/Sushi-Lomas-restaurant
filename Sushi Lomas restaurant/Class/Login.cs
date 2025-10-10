using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sushi_Lomas_restaurant.Windows;

namespace Sushi_Lomas_restaurant.Class
{
    public class Login
    {
        public bool logear(string usuario, string contraseña)
        {
            try
            {
                //Consultas que se usan para el inicio de sesion, se consultan el rol y el nombre, antes de mostrar los demas datos
                string consulta0 = "SELECT rol FROM Usuario WHERE nombre = @usuario and contraseña = @contraseña";
                string consulta1 = "SELECT nombre FROM Usuario WHERE nombre = @usuario and contraseña = @contraseña";
                string consulta2 = "SELECT * FROM Usuario WHERE nombre = @usuario and contraseña = @contraseña";

                using (SqlConnection con = Conect.GetConnection())
                using (SqlCommand com = new SqlCommand(consulta0, con))
                {
                    com.Parameters.AddWithValue("@usuario", usuario);
                    com.Parameters.AddWithValue("@contraseña", contraseña);

                    con.Open();
                    object resultado = com.ExecuteScalar();
                    if (resultado != null)
                    {
                        UserInfo.rol = Convert.ToInt32(resultado);
                    }
                    else
                    {
                        throw new Exception("No se pudo obtener tu nombre de usuario.");
                    }
                    com.Dispose();
                }

                using (SqlConnection con = Conect.GetConnection())
                using (SqlCommand com = new SqlCommand(consulta1, con))
                {
                    com.Parameters.AddWithValue("@usuario", usuario);
                    com.Parameters.AddWithValue("@contraseña", contraseña);

                    con.Open();
                    object resultado = com.ExecuteScalar();
                    if (resultado != null)
                    {
                        UserInfo.usuario = resultado.ToString();
                    }
                    else
                    {
                        throw new Exception("No se pudo obtener tu nombre de usuario.");
                    }
                    com.Dispose();
                }

                using (SqlConnection con = Conect.GetConnection())
                using (SqlCommand com = new SqlCommand(consulta2, con))
                {
                    com.Parameters.AddWithValue("@usuario", usuario);
                    com.Parameters.AddWithValue("@contraseña", contraseña);

                    con.Open();
                    SqlDataReader reader = com.ExecuteReader();

                    if (reader.HasRows)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            catch(Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}
