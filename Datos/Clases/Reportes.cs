using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class datos
    {
        public static string conexion = "datasource = 192.168.2.53; port = 3306; username = wantognazza; password = 54197669; persistsecurityinfo = True; SSL Mode = None"; //string para conectar
        public static MySqlConnection miConexion = new MySqlConnection(conexion);

        public static DataTable getSalesOrder(string comienzo, string final)
        {
            string Query = "SELECT r.IdReserva,r.Fecha,c.Nombre,c.Apellido,r.CostoTotal FROM Pollux.reserva r join Pollux.cliente c on r.CI=c.CI where r.Fecha>=@comienzo and r.Fecha<=@final and r.Confirmada=1 order by r.Fecha;";

            DataTable xd = new DataTable("");
            try
            {

                MySqlCommand comando = new MySqlCommand(Query, miConexion);
                comando.Parameters.AddWithValue("@comienzo", comienzo);
                comando.Parameters.AddWithValue("@final", final);

                MySqlDataAdapter MyAdapter = new MySqlDataAdapter();
                miConexion.Open();
                MyAdapter.SelectCommand = comando;
                MyAdapter.Fill(xd);
                miConexion.Close();
                return xd;
            }
            catch (Exception f)
            {
                miConexion.Close();
                Console.WriteLine("GetVentas: " + f.Message);
                return xd;
            }
        }

    }
}
