using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace Datos
{
    public class ConexionBD
    {
        public static string conexion = "datasource = localhost; port = 3306; username = User; password = PassUSer; persistsecurityinfo = True; SSL Mode = None";
        //"server = localhost; port = 3306; database = pollux; uid = *user* ; pwd =*passUser*"; string para conectar por si no funciona al anterior

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
