using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Data;
using System.Windows.Forms;

namespace Datos
{
    public class Reservas
    {
        //##########################SELECT###################################
        public static ArrayList CheckServiciosContratados(string cedula, string fecha)
        {
            ArrayList hola = new ArrayList();
            try
            {
                string Query = "SELECT Hora FROM Pollux.hora_reservada where CI= @cedula and Fecha = @fecha;";
                MySqlCommand comando = new MySqlCommand(Query, ConexionBD.miConexion);
                comando.Parameters.AddWithValue("@cedula", cedula);
                comando.Parameters.AddWithValue("@fecha", fecha);
                MySqlDataReader Lector;
                ConexionBD.miConexion.Open();
                Lector = comando.ExecuteReader();
                while (Lector.Read())
                {
                    hola.Add(Lector.GetString("Hora"));
                }
                ConexionBD.miConexion.Close();
            }
            catch (Exception f)
            {
                ConexionBD.miConexion.Close();
                Console.WriteLine("CheckServiciosContratados:" + f.Message);
                return hola;
            }
            return hola;
        }
        public static bool CargarServiciosCliente(DataGridView tabla, int nro)
        {
            try
            {

                string Query = "select r.CI,rs.Cliente,r.Fecha, rs.nroReserva 'Nro. Reserva',rs.Hora,rs.Servicio,rs.Costo from Pollux.reserva r join Pollux.hora_reservada rs on r.IdReserva = rs.nroReserva where rs.nroReserva =@nro;";
                MySqlCommand comando = new MySqlCommand(Query, ConexionBD.miConexion);
                comando.Parameters.AddWithValue("@nro", nro);
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
                Console.WriteLine("CargarServiciosCliente: " + f.Message);
                return false;
            }
            return true;
        }
        public static DataTable GetServiciosCliente(int nro)
        {
            DataTable dTable = new DataTable();
            try
            {

                string Query = "select r.CI,r.Fecha, rs.nroReserva 'Nro. Reserva',rs.Hora,rs.Servicio,rs.Costo,rs.FechaRegistrado 'Fecha de registro' from Pollux.reserva r join Pollux.hora_reservada rs on r.IdReserva = rs.nroReserva where rs.nroReserva =@nro;";
                MySqlCommand comando = new MySqlCommand(Query, ConexionBD.miConexion);
                comando.Parameters.AddWithValue("@nro", nro);
                ConexionBD.miConexion.Open();
                MySqlDataAdapter MyAdapter = new MySqlDataAdapter();
                MyAdapter.SelectCommand = comando;
                MyAdapter.Fill(dTable);
                ConexionBD.miConexion.Close();
                return dTable;
            }
            catch (Exception f)
            {
                ConexionBD.miConexion.Close();
                Console.WriteLine("CargarServiciosCliente: " + f.Message);
                return dTable;
            }
        }
        public static int ContarServiciosCliente(int cedula)
        {
            int servicios = 0;
            try
            {

                string Query = "SELECT COUNT(*) FROM Pollux.reserva r join Pollux.hora_reservada rs on r.IdReserva = rs.nroReserva WHERE CI=@ci;";
                MySqlCommand comando = new MySqlCommand(Query, ConexionBD.miConexion);
                comando.Parameters.AddWithValue("@ci", cedula);
                ConexionBD.miConexion.Open();
                object obj = comando.ExecuteScalar();
                servicios = Convert.ToInt32(obj);
                ConexionBD.miConexion.Close();
            }
            catch (Exception f)
            {
                ConexionBD.miConexion.Close();
                Console.WriteLine("ContarServiciosCliente:" + f.Message);
                return servicios;
            }
            return servicios;
        }
        public static int ContarReservasRealizadasHoy()
        {
            int reservas = 0;
            try
            {

                string Query = "SELECT COUNT(DISTINCT nroReserva) FROM Pollux.hora_reservada where CAST(FechaRegistrado AS date)=current_date();";
                MySqlCommand comando = new MySqlCommand(Query, ConexionBD.miConexion);
                ConexionBD.miConexion.Open();
                object obj = comando.ExecuteScalar();
                reservas = Convert.ToInt32(obj);
                ConexionBD.miConexion.Close();
            }
            catch (Exception f)
            {
                ConexionBD.miConexion.Close();
                Console.WriteLine("ContarReservasRealizadasHoy:" + f.Message);
                return reservas;
            }
            return reservas;
        }
        public static DataTable CargarServiciosReservados(int nro)
        {
            DataTable hola = new DataTable("Datos");
            try
            {
                string Query = "select * from Pollux.hora_reservada where nroReserva=@nro;";
                MySqlCommand comando = new MySqlCommand(Query, ConexionBD.miConexion);
                comando.Parameters.AddWithValue("@nro", nro);
                ConexionBD.miConexion.Open();
                MySqlDataAdapter MyAdapter = new MySqlDataAdapter();
                MyAdapter.SelectCommand = comando;
                DataTable dt = new DataTable();
                MyAdapter.Fill(dt);
                hola = dt;
                ConexionBD.miConexion.Close();
            }
            catch (Exception f)
            {
                ConexionBD.miConexion.Close();
                Console.WriteLine("CargarServiciosReservados:" + f.Message);
            }
            return hola;
        }
        public static DataTable CargarServiciosReservados2(int nro)
        {
            DataTable hola = new DataTable("Datos");
            try
            {
                string Query = "select * from Pollux.hora_reservada where nroReserva=@nro;";
                MySqlCommand comando = new MySqlCommand(Query, ConexionBD.miConexion);
                comando.Parameters.AddWithValue("@nro", nro);
                ConexionBD.miConexion.Open();
                MySqlDataAdapter MyAdapter = new MySqlDataAdapter();
                MyAdapter.SelectCommand = comando;
                DataTable dt = new DataTable();
                MyAdapter.Fill(dt);
                hola = dt;
                ConexionBD.miConexion.Close();
            }
            catch (Exception f)
            {
                ConexionBD.miConexion.Close();
                Console.WriteLine("CargarServiciosReservados:" + f.Message);
            }
            return hola;
        }
        public static int ContarClientesCurrentHora()
        {
            int Clientes = 0;
            try
            {

                string Query = "SELECT Count(nroReserva) FROM Pollux.hora_reservada c join Pollux.reserva r on r.IdReserva=c.nroReserva where hour(Hora)=hour(current_time()) and r.Fecha=current_date();";
                MySqlCommand comando = new MySqlCommand(Query, ConexionBD.miConexion);
                ConexionBD.miConexion.Open();
                object obj = comando.ExecuteScalar();
                Clientes = Convert.ToInt32(obj);
                ConexionBD.miConexion.Close();
            }
            catch (Exception f)
            {
                ConexionBD.miConexion.Close();
                Console.WriteLine("ContarClientesCurrentHora: " + f.Message);
                return Clientes;
            }
            return Clientes;
        }
        public static bool CargarClientesPorServicioYFecha(DataGridView tabla,string fecha,string servicio)
        {
            try
            {

                string Query = "SELECT rs.Hora,r.Fecha,rs.Servicio,count(rs.Servicio) 'Cantidad Clientes' FROM Pollux.hora_reservada rs join Pollux.reserva r on rs.nroReserva=r.IdReserva where Servicio=@servicio and r.Fecha=@fecha and r.Confirmada=1 group by Hora order by count(rs.Servicio) desc;";
                MySqlCommand comando = new MySqlCommand(Query, ConexionBD.miConexion);
                comando.Parameters.AddWithValue("@servicio", servicio);
                comando.Parameters.AddWithValue("@fecha", fecha);
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
                Console.WriteLine("CargarClientesPorServicioYFecha: " + f.Message);
                return false;
            }
            return true;
        }
        public static DataTable CargarClientesPorServicioYFechaDT(string fecha, string servicio)
        {
            DataTable dTable = new DataTable();
            try
            {
                string Query = "SELECT rs.Hora,r.Fecha,rs.Servicio,count(rs.Servicio) 'Cantidad Clientes' FROM Pollux.hora_reservada rs join Pollux.reserva r on rs.nroReserva=r.IdReserva where Servicio=@servicio and r.Fecha=@fecha and r.Confirmada=1 group by Hora order by count(rs.Servicio) desc;";
                MySqlCommand comando = new MySqlCommand(Query, ConexionBD.miConexion);
                comando.Parameters.AddWithValue("@servicio", servicio);
                comando.Parameters.AddWithValue("@fecha", fecha);
                ConexionBD.miConexion.Open();
                MySqlDataAdapter MyAdapter = new MySqlDataAdapter();
                MyAdapter.SelectCommand = comando;
                MyAdapter.Fill(dTable);
                ConexionBD.miConexion.Close();
            }
            catch (Exception f)
            {
                ConexionBD.miConexion.Close();
                Console.WriteLine("CargarClientesPorServicioYFechaDT: " + f.Message);
                return dTable;
            }
            return dTable;
        }
        public static bool CargarReservasPorHoraYFecha(DataGridView tabla,DateTime fecha,string hora)
        {
            try
            {

                string Query = "SELECT  concat(c.Nombre,' ',c.Apellido) 'Nombre Completo', r.CI, rs.nroReserva, r.Fecha,rs.Hora, rs.Servicio FROM Pollux.hora_reservada rs join Pollux.reserva r join Pollux.cliente c  on rs.nroReserva=r.IdReserva and r.CI=c.CI where r.Fecha= @fecha and hour(rs.Hora)=@hora ;";
                MySqlCommand comando = new MySqlCommand(Query, ConexionBD.miConexion);
                comando.Parameters.AddWithValue("@fecha", fecha.ToString("yyyy-MM-dd"));
                comando.Parameters.AddWithValue("@hora", hora);
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
                Console.WriteLine("CargarReservasPorHoraYFecha: " + f.Message);
                return false;
            }
            return true;
        }
        public static DataTable CargarReservasPorHoraYFechaDT(DateTime fecha, string hora)
        {
            DataTable dTable = new DataTable();
            try
            {

                string Query = "SELECT  concat(c.Nombre,' ',c.Apellido) 'Nombre Completo', r.CI, rs.nroReserva, r.Fecha,rs.Hora, rs.Servicio FROM Pollux.hora_reservada rs join Pollux.reserva r join Pollux.cliente c  on rs.nroReserva=r.IdReserva and r.CI=c.CI where r.Fecha= @fecha and hour(rs.Hora)=@hora ;";
                MySqlCommand comando = new MySqlCommand(Query, ConexionBD.miConexion);
                comando.Parameters.AddWithValue("@fecha", fecha.ToString("yyyy-MM-dd"));
                comando.Parameters.AddWithValue("@hora", hora);
                ConexionBD.miConexion.Open();
                MySqlDataAdapter MyAdapter = new MySqlDataAdapter();
                MyAdapter.SelectCommand = comando;
                MyAdapter.Fill(dTable);
              
                ConexionBD.miConexion.Close();
            }
            catch (Exception f)
            {
                ConexionBD.miConexion.Close();
                Console.WriteLine("CargarReservasPorHoraYFechaDT: " + f.Message);
                return dTable;
            }
            return dTable;
        }
        public static bool CargarArribos(DataGridView tabla, DateTime fecha)
        {
            try
            {

                string Query = "SELECT rs.nroReserva,c.CI,concat(c.Nombre,' ',c.Apellido)'Nombre completo',rs.Hora FROM Pollux.hora_reservada rs join Pollux.reserva r join Pollux.cliente c on rs.nroReserva=r.IdReserva and r.CI=c.CI where rs.Servicio='Traslado Ida' and r.Fecha =@fecha order by rs.Hora;";
                MySqlCommand comando = new MySqlCommand(Query, ConexionBD.miConexion);
                comando.Parameters.AddWithValue("@fecha", fecha.ToString("yyyy-MM-dd"));
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
                Console.WriteLine("CargarArribos: " + f.Message);
                return false;
            }
            return true;
        }
        public static bool CargarPartidas(DataGridView tabla, DateTime fecha)
        {
            try
            {

                string Query = "SELECT rs.nroReserva,c.CI,concat(c.Nombre,' ',c.Apellido)'Nombre completo',rs.Hora FROM Pollux.hora_reservada rs join Pollux.reserva r join Pollux.cliente c on rs.nroReserva=r.IdReserva and r.CI=c.CI where rs.Servicio='Traslado Vuelta' and r.Fecha =@fecha order by rs.Hora;";
                MySqlCommand comando = new MySqlCommand(Query, ConexionBD.miConexion);
                comando.Parameters.AddWithValue("@fecha", fecha.ToString("yyyy-MM-dd"));
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
                Console.WriteLine("CargarPartidas: " + f.Message);
                return false;
            }
            return true;
        }
        public static DataTable CargarHorasNoDisponiblesBD(string fecha)
        {
            DataTable hola = new DataTable("Datos");
            try
            {
                string Query = "SELECT rs.Cliente,rs.Servicio,r.Fecha,rs.Hora,rs.Costo FROM Pollux.hora_reservada rs join Pollux.reserva r on rs.nroReserva=r.IdReserva where Fecha=@fecha;";
        MySqlCommand comando = new MySqlCommand(Query, ConexionBD.miConexion);
        comando.Parameters.AddWithValue("@fecha", fecha);
                ConexionBD.miConexion.Open();
                MySqlDataAdapter MyAdapter = new MySqlDataAdapter();
        MyAdapter.SelectCommand = comando;
                DataTable dt = new DataTable();
        MyAdapter.Fill(dt);
                hola = dt;
                ConexionBD.miConexion.Close();
            }
            catch (Exception f)
            {
                ConexionBD.miConexion.Close();
                Console.WriteLine("CargarHorasNoDisponiblesBD:" + f.Message);
            }
            return hola;
        }
        //##########################SELECT###################################

        //##########################INSERT###################################
        public static bool ReservarServicio(int nroReserva, string hora, int cliente, string servicio, int costo)
        {
            try
            {
                string Query = "insert into Pollux.hora_reservada(nroReserva,Hora,Cliente,Servicio,Costo) values(@nro,@hora,@Cliente,@servicio,@costo);";
                MySqlCommand comando = new MySqlCommand(Query, ConexionBD.miConexion);
                comando.Parameters.AddWithValue("@nro", nroReserva);
                comando.Parameters.AddWithValue("@hora", hora);
                comando.Parameters.AddWithValue("@Cliente", cliente);
                comando.Parameters.AddWithValue("@servicio", servicio);
                comando.Parameters.AddWithValue("@costo", costo);
                ConexionBD.miConexion.Open();
                comando.ExecuteReader();
                ConexionBD.miConexion.Close();
                return true;
            }
            catch (Exception f)
            {
                ConexionBD.miConexion.Close();
                Console.WriteLine("ReservarServicio:" + f.Message);
                return false;
            }

        }
        public static bool LogReservarServicio(int user,int nroReserva, string hora, int cliente, string accion)
        {
            try
            {
                string Query = "insert into Pollux.edita(Usuario,HoraReservada,NroReserva,cliente,Fecha,Accion) values(@user,@hora,@NroReserva,@cliente,@Fecha,@Accion);";
                MySqlCommand comando = new MySqlCommand(Query, ConexionBD.miConexion);

                comando.Parameters.AddWithValue("@user", user);
                comando.Parameters.AddWithValue("@hora", hora);
                comando.Parameters.AddWithValue("@NroReserva", nroReserva);
                comando.Parameters.AddWithValue("@cliente", cliente);
                comando.Parameters.AddWithValue("@Fecha", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
                comando.Parameters.AddWithValue("@Accion", accion);

                ConexionBD.miConexion.Open();
                comando.ExecuteReader();
                ConexionBD.miConexion.Close();
                return true;
            }
            catch (Exception f)
            {
                ConexionBD.miConexion.Close();
                Console.WriteLine("ReservarServicio:" + f.Message);
                return false;
            }

        }
        //##########################INSERT###################################

        //##########################DELETE###################################
        public static bool BajaServicioCliente(int nro, string hora)
        {
            try
            {
                string Query = "delete from Pollux.hora_reservada where nroReserva=@nro AND Hora=@hora;";
                MySqlCommand comando = new MySqlCommand(Query, ConexionBD.miConexion);
                comando.Parameters.AddWithValue("@nro", nro);
                comando.Parameters.AddWithValue("@hora", hora);
                MySqlDataReader Lector;
                ConexionBD.miConexion.Open();
                Lector = comando.ExecuteReader();
                while (Lector.Read()) { }
                ConexionBD.miConexion.Close();
            }
            catch (Exception f)
            {
                ConexionBD.miConexion.Close();
                Console.WriteLine("BajaServicioCliente:" + f.Message);
                return false;
            }
            return true;
        }
        //##########################DELETE###################################

        //##########################UPDATE###################################
        public static bool CambiarHoraReserva(int nro, string horaVieja, string horaNueva)
        {
            try
            {
                string Query = "UPDATE Pollux.hora_reservada SET Hora=@horaNueva WHERE nroReserva=@nro and Hora= @horaVieja;";
                MySqlCommand comando = new MySqlCommand(Query, ConexionBD.miConexion);
                comando.Parameters.AddWithValue("@horaNueva", horaNueva);
                comando.Parameters.AddWithValue("@nro", nro);
                comando.Parameters.AddWithValue("@horaVieja", horaVieja);
                ConexionBD.miConexion.Open();
                comando.ExecuteReader();
                ConexionBD.miConexion.Close();
            }
            catch (Exception f)
            {
                ConexionBD.miConexion.Close();
                Console.WriteLine("CambiarHoraReserva:" + f.Message);
                return false;
            }
            return true;
        }
        //##########################UPDATE###################################
    }
}
