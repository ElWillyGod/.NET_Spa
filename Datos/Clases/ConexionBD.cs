using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace Datos
{
    public class ConexionBD
    {
        public static string conexion = "datasource = localhost; port = 3306; username = root; password = 08001930WillyGod; persistsecurityinfo = True; SSL Mode = None"; //string para conectar
        public static MySqlConnection miConexion = new MySqlConnection(conexion);

        public static bool ConexionEstable()
        {
            try
            {
                miConexion.Open();
                miConexion.Close();
                return true;
            }
            catch (Exception f) {
                miConexion.Close();
                MessageBox.Show("ERROR: "+f.Message);
                return false;
            }
        }
    }
}
