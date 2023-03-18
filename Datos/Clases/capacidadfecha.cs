using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace Datos
{
    public class capacidadfecha
    {

        //##########################INSERT###################################
        public static bool AgregarCapacidad(string servicio, string fecha)
        {
            int capMax = Servicio.GetCapacidadMaxima(servicio);
            if (!CheckFechaCapacidad(fecha, servicio))
            {
                try
                {
                    string Query = "INSERT INTO Pollux.capacidad (`Servicio`, `Fecha`, `CapacidadActual`) VALUES (@servicio,@fecha,@capMax);";
                    MySqlCommand comando = new MySqlCommand(Query, ConexionBD.miConexion);
                    comando.Parameters.AddWithValue("@servicio", servicio);
                    comando.Parameters.AddWithValue("@fecha", fecha);
                    comando.Parameters.AddWithValue("@capMax", capMax);
                    MySqlDataReader Lector;
                    ConexionBD.miConexion.Open();
                    Lector = comando.ExecuteReader();
                    while (Lector.Read()) { }
                    ConexionBD.miConexion.Close();
                    return true;
                }
                catch (Exception f)
                {
                    ConexionBD.miConexion.Close();
                    Console.WriteLine("AgregarCapacidad:" + f.Message);
                    return false;
                }

            }
            return false;
        }
        //##########################INSERT###################################

        //##########################SELECT###################################
        public static int GetCapacidadFecha(string servicio, string fecha)
        {
            int capacidad = 0;
            try
            {
                string Query = "SELECT CapacidadActual FROM Pollux.capacidad where Servicio= @servicio AND Fecha= @fecha;";
                MySqlCommand comando = new MySqlCommand(Query, ConexionBD.miConexion);
                comando.Parameters.AddWithValue("@servicio",servicio);
                comando.Parameters.AddWithValue("@fecha", fecha);
                ConexionBD.miConexion.Open();
                MySqlDataReader lector = comando.ExecuteReader();
                    if (lector.Read())
                     {
                        capacidad = lector.GetInt32("CapacidadActual");
                        ConexionBD.miConexion.Close();
                        return capacidad;
                    }
                ConexionBD.miConexion.Close();
            }
            catch (Exception f)
            {
                ConexionBD.miConexion.Close();
                Console.WriteLine("getCapacidadFecha:" + f.Message);
                return capacidad;
            }
            return capacidad;
        }
        public static bool CheckFechaCapacidad(string fecha, string servicio)
        {
            try
            {
                string Query = "SELECT COUNT(*) FROM Pollux.capacidad WHERE Fecha= @fecha and Servicio=@servicio;";
                MySqlCommand comando = new MySqlCommand(Query, ConexionBD.miConexion);
                comando.Parameters.AddWithValue("@fecha", fecha);
                comando.Parameters.AddWithValue("@servicio", servicio);
                ConexionBD.miConexion.Open();
                object obj = comando.ExecuteScalar();

                if (Convert.ToInt32(obj) > 0)
                {
                    ConexionBD.miConexion.Close();
                    return true;

                }
                ConexionBD.miConexion.Close();
            }
            catch (Exception f)
            {
                ConexionBD.miConexion.Close();
                Console.WriteLine("checkFechaCapacidad:" + f.Message);
                return false;
            }
            return false;
        }
        public static DataTable OcupacionServiciosTop(DateTime desde, DateTime hasta)
        {
            string Query = "SELECT rs.Servicio, Floor(avg((100-(cf.CapacidadActual*100/s.CapacidadMax)))) 'Porcentaje' FROM Pollux.hora_reservada rs join Pollux.reserva r join Pollux.servicio s join Pollux.capacidad cf on rs.nroReserva = r.IdReserva and s.Nombre = rs.Servicio  and cf.Servicio = rs.Servicio where r.Fecha between @desde and @hasta group by rs.Servicio order by count(rs.servicio) desc limit 5;";
            
            DataTable xd = new DataTable("");
            try
            {

                MySqlCommand comando = new MySqlCommand(Query, ConexionBD.miConexion);
                comando.Parameters.AddWithValue("@desde",desde.ToString("yyyy-MM-dd"));
                comando.Parameters.AddWithValue("@hasta", hasta.ToString("yyyy-MM-dd"));
                MySqlDataAdapter MyAdapter = new MySqlDataAdapter();
                ConexionBD.miConexion.Open();
                MyAdapter.SelectCommand = comando;
                MyAdapter.Fill(xd);
                ConexionBD.miConexion.Close();
                return xd;
            }
            catch (Exception f)
            {
                ConexionBD.miConexion.Close();
                Console.WriteLine("OcupacionServiciosTop: " + f.Message);
                return xd;
            }
        }
        public static bool MostrarTablaCapacidades(DataGridView tabla,DateTime fecha)
        {
            try
            {
                string Query = "SELECT cf.Servicio, (s.CapacidadMax-cf.CapacidadActual) 'Capacidad Actual',s.CapacidadMax 'Capacidad Maxima',concat(floor((s.CapacidadMax-cf.CapacidadActual)*100/s.CapacidadMax),'%') 'Porcentaje de ocupacion' FROM Pollux.capacidad cf join Pollux.servicio s on cf.Servicio=s.Nombre where Fecha=@fecha order by (s.CapacidadMax-cf.CapacidadActual) desc;";
                MySqlCommand comando = new MySqlCommand(Query, ConexionBD.miConexion);
                comando.Parameters.AddWithValue("@fecha",fecha.ToString("yyyy-MM-dd"));
                ConexionBD.miConexion.Open();
                MySqlDataAdapter MyAdapter = new MySqlDataAdapter();
                MyAdapter.SelectCommand = comando;
                DataTable dTable = new DataTable();
                MyAdapter.Fill(dTable);
                tabla.DataSource = dTable;
                ConexionBD.miConexion.Close();
            }
            catch (Exception f)
            {
                ConexionBD.miConexion.Close();
                MessageBox.Show("MostrarTablaCapacidades: " + f.Message);
                return false;
            }
            return true;
        }
        public static DataTable MostrarTablaCapacidadesDT(DateTime fecha)
        {
            DataTable dTable = new DataTable();
            try
            {
                string Query = "SELECT cf.Servicio,cf.Fecha, (s.CapacidadMax-cf.CapacidadActual) 'Capacidad Actual',s.CapacidadMax 'Capacidad Maxima',concat(floor((s.CapacidadMax-cf.CapacidadActual)*100/s.CapacidadMax),'%') 'Porcentaje de ocupacion' FROM Pollux.capacidad cf join Pollux.servicio s on cf.Servicio=s.Nombre where cf.Fecha=@fecha order by (s.CapacidadMax-cf.CapacidadActual) desc;";
                MySqlCommand comando = new MySqlCommand(Query, ConexionBD.miConexion);
                comando.Parameters.AddWithValue("@fecha", fecha.ToString("yyyy-MM-dd"));
                ConexionBD.miConexion.Open();
                MySqlDataAdapter MyAdapter = new MySqlDataAdapter();
                MyAdapter.SelectCommand = comando;
                MyAdapter.Fill(dTable);
                ConexionBD.miConexion.Close();
            }
            catch (Exception f)
            {
                ConexionBD.miConexion.Close();
                MessageBox.Show("MostrarTablaCapacidadesDT: " + f.Message);
                return dTable;
            }
            return dTable;
        }
        //##########################SELECT###################################
    }
}
