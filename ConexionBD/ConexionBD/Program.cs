using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ConexionBD
{
    class Program
    {
        static void Main(string[] args)
        {
                SqlConnection conectar = new SqlConnection("Data Source=CAM\\SQLEXPRESS;Initial Catalog=Mundial;Integrated Security=SSPI;");
            try
            {
                conectar.Open();
                Console.WriteLine("Se realizó la conexión");
                SqlCommand cmd = new SqlCommand("SELECT * FROM Juegos", conectar);
                SqlDataReader tabla = cmd.ExecuteReader();

                try
                {
                    while (tabla.Read())
                    {
                        Console.WriteLine("" + tabla[1]);
                    }

                    tabla.Close();
                }
                catch (SqlException e)
                {
                    Console.WriteLine("Falló la apertura." + e.Message);
                }
                        

            }
            catch (Exception ex)
            {
                Console.WriteLine("Mal Conexión. ", ex.ToString());
            }
            Console.ReadKey();
        }
    }
}
