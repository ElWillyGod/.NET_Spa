using System;
using System.Collections;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Bunifu.UI.WinForms;
namespace Datos
{
    public class Cliente
    {




        //##########################INSERT###################################
        public static bool ReservarCliente(int ci, string nombre, string apellido,string correo, string telefono, string direccion,string entrada,int total)
        {
            try
            {
                string Query = "insert into Pollux.cliente(CI,Nombre,Apellido,Correo,Telefono,Direccion,Entrada,TotalAPagar) " +
                    "values(@ci,@nombre,@apellido,@correo,@telefono,@direccion,@entrada,@total);";
 
                MySqlCommand comando = new MySqlCommand(Query, ConexionBD.miConexion);
                comando.Parameters.AddWithValue("@ci",ci);
                comando.Parameters.AddWithValue("@nombre", nombre);
                comando.Parameters.AddWithValue("@apellido", apellido);
                comando.Parameters.AddWithValue("@correo", correo);
                comando.Parameters.AddWithValue("@telefono", telefono);
                comando.Parameters.AddWithValue("@direccion", direccion);
                comando.Parameters.AddWithValue("@entrada", entrada);
                comando.Parameters.AddWithValue("@total", total);
                ConexionBD.miConexion.Open();
                comando.ExecuteReader();
                ConexionBD.miConexion.Close();
            }
            catch (Exception f)
            {
                ConexionBD.miConexion.Close();
                MessageBox.Show("ReservarCliente: "+ f.Message);
                return false;
            }
            return true;
        }
        public static bool logCliente(int user,int ci,string accion)
        {
            try
            {
                string Query = "INSERT INTO Pollux.sirve (Usuario, Cliente, Fecha, Accion) VALUES (@user, @cliente, @fecha, @accion);";

                MySqlCommand comando = new MySqlCommand(Query, ConexionBD.miConexion);
                comando.Parameters.AddWithValue("@user", user);
                comando.Parameters.AddWithValue("@cliente", ci);
                comando.Parameters.AddWithValue("@fecha", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
                comando.Parameters.AddWithValue("@accion", accion);
                ConexionBD.miConexion.Open();
                comando.ExecuteReader();
                ConexionBD.miConexion.Close();
            }
            catch (Exception f)
            {
                ConexionBD.miConexion.Close();
                MessageBox.Show("logCliente: " + f.Message);
                return false;
            }
            return true;
        }
        //##########################INSERT###################################


        //##########################SELECT###################################
        public static bool CargarClientes(DataGridView tabla)
        {
            try
            {
                string Query = "SELECT CI,Nombre,Apellido,Correo,Telefono,Direccion,Entrada, totalAPagar 'Total a pagar' from Pollux.cliente;";
                MySqlCommand comando = new MySqlCommand(Query, ConexionBD.miConexion);
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
                Console.WriteLine("CargarClientes: "+ f.Message );
                return false;
            }
            return true;
        }
        public static bool CheckClienteExiste(int cedula)
        {
            try
            {
                string Query = "SELECT COUNT(*) FROM Pollux.cliente WHERE CI= @cedula;";
                MySqlCommand comando = new MySqlCommand(Query, ConexionBD.miConexion);
                comando.Parameters.AddWithValue("@cedula", cedula);
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
                MessageBox.Show("checkClienteExiste: " + f.Message);
                return false;
            }
            return false;
        }
        public static bool CheckReservaExiste(int ci,string fecha)
        {
            try
            {
                string Query = "SELECT COUNT(*) FROM Pollux.reserva WHERE CI= @ci AND Fecha=@fecha;";
                MySqlCommand comando = new MySqlCommand(Query, ConexionBD.miConexion);
                comando.Parameters.AddWithValue("@ci", ci);
                comando.Parameters.AddWithValue("@fecha", fecha);

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
                MessageBox.Show("CheckReservaExiste: " + f.Message);
                return false;
            }
            return false;
        }
        public static bool CargarDatosClienteExistente(BunifuTextBox Cedula, BunifuTextBox Nombre, BunifuTextBox Apellido, BunifuTextBox Correo, BunifuTextBox Telefono, BunifuTextBox Direccion, ComboBox cb)
        {
            try
            {
                string Query = "SELECT COUNT(*) FROM Pollux.cliente WHERE CI= @cedula;";

                MySqlCommand comando = new MySqlCommand(Query, ConexionBD.miConexion);
                comando.Parameters.AddWithValue("@cedula",Cedula.Text);
                ConexionBD.miConexion.Open();
                object obj = comando.ExecuteScalar();
                if (Convert.ToInt32(obj) == 0)
                {
                    ConexionBD.miConexion.Close();
                    return false;
                }
                else
                {
                    ConexionBD.miConexion.Close();
                    Query = "SELECT * FROM Pollux.cliente WHERE CI= @cedula;";
                    comando = new MySqlCommand(Query, ConexionBD.miConexion);
                    comando.Parameters.AddWithValue("@cedula", Cedula.Text);
                    ConexionBD.miConexion.Open();
                    MySqlDataReader lector = comando.ExecuteReader();
                    while (lector.Read())
                    {
                        Cedula.Text = lector.GetString("CI");
                        Nombre.Text = lector.GetString("Nombre");
                        Apellido.Text = lector.GetString("Apellido");
                        Correo.Text = lector.GetString("Correo");
                        Telefono.Text = lector.GetString("Telefono");
                        Direccion.Text = lector.GetString("Direccion");
                        if (lector.GetString("Entrada") == "Entrada Jubilados")
                            cb.Text = "Entrada Jubilados";
                        if (lector.GetString("Entrada") == "Entrada Turistas")
                            cb.Text = "Entrada Turistas";
                        else
                            cb.Text = "Entrada Estandar";
                    }
                    ConexionBD.miConexion.Close();
                    return true;
                }
            }

            catch (Exception f)
            {
                ConexionBD.miConexion.Close();
                Console.WriteLine("CargarDatosClienteExistente: " + f.Message);
                return false;
            }

        }
        public static int GetTotalAPagar(int ci)
        {
            int costo = 0;
            try
            {
                string Query = "SELECT TotalAPagar FROM Pollux.cliente where CI= @ci;";
                MySqlCommand comando = new MySqlCommand(Query, ConexionBD.miConexion);
                comando.Parameters.AddWithValue("@ci",ci);
                ConexionBD.miConexion.Open();
                MySqlDataReader lector = comando.ExecuteReader();
                
                    if (lector.Read())
                    {
                        costo = lector.GetInt32("TotalAPagar");
                        ConexionBD.miConexion.Close();
                        return costo;
                    }
                ConexionBD.miConexion.Close();
            }
            catch (Exception f)
            {
                ConexionBD.miConexion.Close();
                Console.WriteLine("GetTotalAPagar:" + f.Message);
                return costo;
            }
            return costo;
        }
        public static bool BuscarCliente(DataGridView tabla, string filtro)
        {
            try
            {
                string Query = "SELECT CI,Nombre,Apellido,Correo,Telefono,Direccion,Entrada, totalAPagar 'Total a pagar' from Pollux.cliente where Nombre like @filtro OR Apellido like @filtro OR CI like @filtro;";
                MySqlCommand comando = new MySqlCommand(Query, ConexionBD.miConexion);
                comando.Parameters.AddWithValue("@filtro", "%" + filtro + "%");
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
                Console.WriteLine("BuscarCliente: " + f.Message);
                return false;
            }
            return true;
        }
        public static bool BuscarClientePorIdReserva(DataGridView tabla, string filtro)
        {
            try
            {
                string Query = "SELECT c.CI,c.Nombre,c.Apellido,c.Correo,c.Telefono,c.Direccion,c.Entrada, c.totalAPagar 'Total a pagar' from Pollux.cliente c join Pollux.reserva r on r.CI=c.CI where r.IdReserva=@nro;";
                MySqlCommand comando = new MySqlCommand(Query, ConexionBD.miConexion);
                comando.Parameters.AddWithValue("@nro",filtro);
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
                Console.WriteLine("BuscarCliente: " + f.Message);
                return false;
            }
            return true;
        }
        //##########################SELECT###################################


        //##########################DELETE###################################
        public static bool BajaCliente(int ci)
        {
            try
            {
                string Query = "delete from Pollux.cliente where CI=@ci;";
                MySqlCommand comando = new MySqlCommand(Query, ConexionBD.miConexion);
                comando.Parameters.AddWithValue("@ci", ci);
                MySqlDataReader Lector;
                ConexionBD.miConexion.Open();
                Lector = comando.ExecuteReader();
                while (Lector.Read()) { }
                ConexionBD.miConexion.Close();
            }
            catch (Exception f)
            {
                ConexionBD.miConexion.Close();
                Console.WriteLine("BajaCliente: "+f.Message);
                return false;
            }
            return true;
        }
        //##########################DELETE###################################


        //##########################UPDATE###################################
        public static bool ModificarCliente(int ci, int ci2,string nombre,string apellido, string correo,string telefono,string direccion,string entrada,int totalAPagar)
        {
            try
            {

                string Query = "UPDATE Pollux.cliente SET CI=@ci2, Nombre=@nombre, Apellido=@apellido, Correo=@correo, Telefono=@telefono, Direccion=@direccion,Entrada=@entrada, TotalAPagar=@totalAPagar WHERE CI=@ci;";
                MySqlCommand comando = new MySqlCommand(Query, ConexionBD.miConexion);
                comando.Parameters.AddWithValue("@ci", ci);
                comando.Parameters.AddWithValue("@ci2", ci2);
                comando.Parameters.AddWithValue("@nombre", nombre);
                comando.Parameters.AddWithValue("@apellido", apellido);
                comando.Parameters.AddWithValue("@correo", correo);
                comando.Parameters.AddWithValue("@telefono", telefono);
                comando.Parameters.AddWithValue("@direccion", direccion);
                comando.Parameters.AddWithValue("@entrada", entrada);
                comando.Parameters.AddWithValue("@totalAPagar", totalAPagar);
                ConexionBD.miConexion.Open();
                comando.ExecuteReader();
                ConexionBD.miConexion.Close();
            }
            catch (Exception f)
            {
                ConexionBD.miConexion.Close();
                Console.WriteLine("ModificarCliente: " + f.Message);
                return false;
            }
            return true;
        }
        public static bool QuitarPrecioServicio(int ci,int valor) {

            int total = GetTotalAPagar(ci);
            if (total == 0)
            {
                return true;
            }
            else if (total > 0)
            {
                total -= valor;
                try
                {

                    string Query = "UPDATE Pollux.cliente SET TotalAPagar=@total WHERE CI=@ci;";
                    MySqlCommand comando = new MySqlCommand(Query, ConexionBD.miConexion);
                    comando.Parameters.AddWithValue("@total",total);
                    comando.Parameters.AddWithValue("@ci", ci);
                    ConexionBD.miConexion.Open();
                    comando.ExecuteReader();
                    ConexionBD.miConexion.Close();
                    return true;
                }
                catch (Exception f)
                {
                    ConexionBD.miConexion.Close();
                    Console.WriteLine("QuitarPrecioServicio: " + f.Message);
                    return false;
                }
            }
            return false;
        }
        public static bool ModificarTotalAPagar(int ci, int valor)
        {
            int suma = 0;
            try
            {

                string Query = "select TotalAPagar from Pollux.cliente where CI=@ci;";
                MySqlCommand comando = new MySqlCommand(Query, ConexionBD.miConexion);
                comando.Parameters.AddWithValue("@ci", ci);
                ConexionBD.miConexion.Open();

                MySqlDataReader lector = comando.ExecuteReader();

                if (lector.Read())
                {
                    suma = lector.GetInt32("TotalAPagar");
                    ConexionBD.miConexion.Close();
                }
                ConexionBD.miConexion.Close();
                suma += valor;
                Query = "update Pollux.cliente set TotalAPagar=@suma where CI=@ci;";
                comando = new MySqlCommand(Query, ConexionBD.miConexion);
                comando.Parameters.AddWithValue("@suma", suma);
                comando.Parameters.AddWithValue("@ci", ci);
                ConexionBD.miConexion.Open();
                comando.ExecuteReader();
                ConexionBD.miConexion.Close();
                return true;
            }
            catch (Exception f)
            {
                ConexionBD.miConexion.Close();
                Console.WriteLine("ModificarTotalAPagar: " + f.Message);
                return false;
            }
        }
        //##########################UPDATE################################### 
    }
}
