using System;
using System.Collections;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;
using Bunifu.UI.WinForms;
using MySql.Data.MySqlClient;

namespace Datos
{
    public class Usuarios
    {
        //##########################INSERT###################################
        public static bool AltaEmpleado(int ci,string nombre,string apellido, string correo, int telefono, string direccion, string TipoUsuario, string pass, byte[] foto)
        {
            try
            {
                string Query = "insert into Pollux.usuario(Cedula,Password, Nombre, Apellido, Correo, Direccion, Telefono, TipoUsuario,foto) " +
                      "values(@ci,@pass,@nombre,@apellido,@correo,@direccion,@telefono,@TipoUsuario,@foto);";
                MySqlCommand comando = new MySqlCommand(Query, ConexionBD.miConexion);
                comando.Parameters.AddWithValue("@ci", ci);
                comando.Parameters.AddWithValue("@pass", pass);
                comando.Parameters.AddWithValue("@nombre", nombre);
                comando.Parameters.AddWithValue("@apellido", apellido);
                comando.Parameters.AddWithValue("@correo", correo);
                comando.Parameters.AddWithValue("@direccion", direccion);
                comando.Parameters.AddWithValue("@telefono", telefono);
                comando.Parameters.AddWithValue("@TipoUsuario", TipoUsuario);
                comando.Parameters.AddWithValue("@foto", foto);
                ConexionBD.miConexion.Open();
                comando.ExecuteReader();
                ConexionBD.miConexion.Close();
            }
            catch (Exception f)
            {
                ConexionBD.miConexion.Close();
                Console.WriteLine("AltaEmpleado:" + f.Message);
                return false;
            }
            return true;
        }
        //##########################INSERT###################################

        //##########################SELECT###################################
        public static bool CambiarUltimoLogin(int cedula)
        {
            DateTime ahora = DateTime.Now;
            string momento = ahora.ToString("yyyy-MM-dd HH:mm:ss");
            try
            {

                string Query = "UPDATE Pollux.usuario SET UltimoLogin=@momento WHERE Cedula=@cedula;";
                MySqlCommand comando = new MySqlCommand(Query, ConexionBD.miConexion);
                comando.Parameters.AddWithValue("@momento", momento);
                comando.Parameters.AddWithValue("@cedula", cedula);
                ConexionBD.miConexion.Open();
                comando.ExecuteReader();
                ConexionBD.miConexion.Close();
                return true;
            }
            catch (Exception f)
            {
                ConexionBD.miConexion.Close();
                Console.WriteLine("CambiarUltimoLogin:" + f.Message);
                return false;
            }
        }
        public static string GetUserType(int cedula)
        {
            string tipo = "";
            try
            {
                string Query = "SELECT TipoUsuario FROM Pollux.usuario WHERE Cedula= @cedula;";
                MySqlCommand comando = new MySqlCommand(Query, ConexionBD.miConexion);
                comando.Parameters.AddWithValue("@cedula", cedula);
                ConexionBD.miConexion.Open();
                MySqlDataReader lector = comando.ExecuteReader();
                
                    if (lector.Read())
                    {
                        tipo = lector.GetString("TipoUsuario");
                        ConexionBD.miConexion.Close();
                        return tipo;
                    }
                
                ConexionBD.miConexion.Close();
            }
            catch (Exception f)
            {
                ConexionBD.miConexion.Close();
                Console.WriteLine("GetUserType: " + f.Message);
                return tipo;
            }
            return tipo;
        }
        public static bool GetUserPass(int cedula, string pass)
        {
            try
            {
                string Query = "SELECT * FROM Pollux.usuario WHERE Cedula=@cedula AND Password = @pass;";
                MySqlCommand comando = new MySqlCommand(Query, ConexionBD.miConexion);
                comando.Parameters.AddWithValue("@cedula", cedula);
                comando.Parameters.AddWithValue("@pass", pass);
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
                Console.WriteLine("GetUserPass: " + f.Message);
                return false;
            }
            return false;
        }
        public static string GetEmail(int cedula) {
            string tipo = "";
            try
            {
                string Query = "SELECT Correo FROM Pollux.usuario WHERE Cedula= @cedula;";
                MySqlCommand comando = new MySqlCommand(Query, ConexionBD.miConexion);
                comando.Parameters.AddWithValue("@cedula", cedula);
                ConexionBD.miConexion.Open();
                MySqlDataReader lector = comando.ExecuteReader();

                if (lector.Read())
                {
                    tipo = lector.GetString("Correo");
                    ConexionBD.miConexion.Close();
                    return tipo;
                }

                ConexionBD.miConexion.Close();
            }
            catch (Exception f)
            {
                ConexionBD.miConexion.Close();
                Console.WriteLine("GetEmail: " + f.Message);
                return tipo;
            }
            return tipo;
        }
        public static bool GetUserID(int cedula)
        {
            try
            {
                string Query = "SELECT COUNT(*) FROM Pollux.usuario WHERE Cedula= '" + cedula + "';";

                MySqlCommand comando = new MySqlCommand(Query, ConexionBD.miConexion);
                ConexionBD.miConexion.Open();
                object obj = comando.ExecuteScalar();
                if (Convert.ToInt32(obj) > 0)
                {
                    ConexionBD.miConexion.Close();
                    return true;
                }
                ConexionBD.miConexion.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
            return false;
        }
        public static bool CargarEmpleados(DataGridView tabla)
        {
            try
            {
                string Query = "select cedula,Nombre,Apellido,Correo,Telefono,Direccion,TipoUsuario Rol, UltimoLogin 'Login reciente' from Pollux.usuario where TipoUsuario !='Gerente';";
                MySqlCommand comando = new MySqlCommand(Query, ConexionBD.miConexion);
                ConexionBD.miConexion.Open();
                MySqlDataAdapter MyAdapter = new MySqlDataAdapter();
                MyAdapter.SelectCommand = comando;
                DataTable dTable = new DataTable();
                MyAdapter.Fill(dTable);
                tabla.DataSource = dTable;
                ConexionBD.miConexion.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message + "Cargar Empleados");
                return false;
            }
            return true;
        }
        public static bool BuscarEmpleado(DataGridView tabla,string filtro)
        {
            try
            {
                string Query = "select cedula,Nombre,Apellido,Correo,Telefono,Direccion,TipoUsuario Rol, UltimoLogin 'Login reciente' from Pollux.usuario where TipoUsuario !='Gerente' " +
                    "AND (cedula like ('"+filtro+ "') OR Nombre like ('" + filtro + "') Apellido like ('" + filtro + "'));";
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
                Console.WriteLine("BuscarEmpleado: " + f.Message);
                return false;
            }
            return true;
        }
        public static bool CargarFotosUsuarios(DataGridView tabla)
        {
            byte[] DatosImagen;
            try
            {
                string Query = "SELECT foto FROM Pollux.usuario;";
                MySqlCommand comando = new MySqlCommand(Query, ConexionBD.miConexion);
                ConexionBD.miConexion.Open();

                MySqlDataReader lector = comando.ExecuteReader();
                while (lector.Read())
                {
                    DatosImagen = (byte[])(lector["foto"]);
                    ConexionBD.miConexion.Close();
                    MemoryStream ms = new MemoryStream(DatosImagen);
                }
                ConexionBD.miConexion.Close();
                return true;

                
            }
            catch (Exception f)
            {
                ConexionBD.miConexion.Close();
                Console.WriteLine("CargarFotosUsuarios: " + f.Message);
                return false;
            }
        }
        public static bool CargarDatosUsuarioExistente(BunifuTextBox Cedula, BunifuTextBox Nombre, BunifuTextBox Apellido, BunifuTextBox Correo, BunifuTextBox Telefono, BunifuTextBox Direccion)
        {
            int contador = 0;
            try
            {
                string Query = "SELECT COUNT(*) FROM Pollux.usuario WHERE Cedula=@cedula;";
                MySqlCommand comando = new MySqlCommand(Query, ConexionBD.miConexion);
                comando.Parameters.AddWithValue("@cedula", Cedula.Text);
                ConexionBD.miConexion.Open();
                object obj = comando.ExecuteScalar();
                contador = Convert.ToInt32(obj);
                ConexionBD.miConexion.Close();
                if (contador == 0)
                {
                    return false;
                }
                else
                {
                    Query = "SELECT Cedula,Nombre,Apellido,Correo,Direccion,Telefono FROM Pollux.usuario WHERE Cedula=@cedula;";
                    comando = new MySqlCommand(Query, ConexionBD.miConexion);
                    comando.Parameters.AddWithValue("@cedula", Cedula.Text);
                    ConexionBD.miConexion.Open();
                    MySqlDataReader lector = comando.ExecuteReader();
                    while (lector.Read())
                    {
                        Cedula.Text = lector.GetString("Cedula");
                        Nombre.Text = lector.GetString("Nombre");
                        Apellido.Text = lector.GetString("Apellido");
                        Correo.Text = lector.GetString("Correo");
                        Direccion.Text = lector.GetString("Direccion");
                        Telefono.Text = lector.GetString("Telefono");

                    }
                    ConexionBD.miConexion.Close();
                    return true;
                }
            }

            catch (Exception f)
            {
                ConexionBD.miConexion.Close();
                Console.WriteLine("CargarFotosUsuarios: " + f.Message);
                return false;
            }

        }
        public static bool CargarPerfil(int usuario, Label Nombre, Label Apellido, Label Cedula, Label Cargo, Label Correo, Label Direccion, Label Telefono)
        {
            try
            {
                string Query = "SELECT * FROM Pollux.usuario WHERE Cedula= @cedula;";
                MySqlCommand comando = new MySqlCommand(Query, ConexionBD.miConexion);
                comando.Parameters.AddWithValue("@cedula", usuario);
                ConexionBD.miConexion.Open();
                MySqlDataReader lector = comando.ExecuteReader();

                if (lector.Read())
                {
                    Nombre.Text = lector.GetString("Nombre");
                    Apellido.Text = lector.GetString("Apellido");
                    Cedula.Text = lector.GetString("Cedula");
                    Cargo.Text = lector.GetString("TipoUsuario");
                    Correo.Text = lector.GetString("Correo");
                    Direccion.Text = lector.GetString("Direccion");
                    Telefono.Text = lector.GetString("Telefono");
                    ConexionBD.miConexion.Close();
                    return true;
                }

                ConexionBD.miConexion.Close();
            }
            catch (Exception f)
            {
                ConexionBD.miConexion.Close();
                Console.WriteLine("CargarPerfil: " + f.Message);
                return false;
            }
            return false;
        }
        public static Image CargarFotoUsuario(int cedula)
        {

            byte[] DatosImagen;
            try
            {
                string Query = "SELECT foto FROM Pollux.usuario WHERE Cedula= @cedula;";
                MySqlCommand comando = new MySqlCommand(Query, ConexionBD.miConexion);
                comando.Parameters.AddWithValue("@cedula", cedula);
                ConexionBD.miConexion.Open();

                MySqlDataReader lector = comando.ExecuteReader();
                if (lector.Read())
                {
                    DatosImagen = (byte[])(lector["foto"]);
                    ConexionBD.miConexion.Close();
                    MemoryStream ms = new MemoryStream(DatosImagen);
                    return Image.FromStream(ms);
                }

                ConexionBD.miConexion.Close();
            }
            catch (Exception f)
            {
                ConexionBD.miConexion.Close();
                Console.WriteLine("CargarFotoUsuario: " + f.Message);
                return null;
            }
            return null;
        }
        public static bool CambiarFotoUsuario(byte[] foto, int ci)
        {
            try
            {
                string Query = "UPDATE Pollux.usuario SET foto=@foto WHERE Cedula= @cedula;";
                MySqlCommand comando = new MySqlCommand(Query, ConexionBD.miConexion);
                comando.Parameters.AddWithValue("@foto", foto);
                comando.Parameters.AddWithValue("@cedula", ci);
                ConexionBD.miConexion.Open();
                comando.ExecuteReader();
                ConexionBD.miConexion.Close();
                return true;
            }
            catch (Exception f)
            {
                ConexionBD.miConexion.Close();
                Console.WriteLine("CambiarFotoUsuario: " + f.Message);
                return false;
            }
        }
        public static bool CargarDetallesUsuario(int ci, Bunifu.UI.WinForms.BunifuTextBox correo, Bunifu.UI.WinForms.BunifuTextBox direccion, Bunifu.UI.WinForms.BunifuTextBox telefono)
        {
            try
            {
                string Query = "SELECT Direccion,Correo,Telefono FROM Pollux.usuario WHERE Cedula= @cedula;";
                MySqlCommand comando = new MySqlCommand(Query, ConexionBD.miConexion);
                comando.Parameters.AddWithValue("@cedula", ci);
                ConexionBD.miConexion.Open();
                MySqlDataReader lector = comando.ExecuteReader();

                if (lector.Read())
                {
                    correo.Text = lector.GetString("Correo");
                    direccion.Text = lector.GetString("Direccion");
                    telefono.Text = lector.GetString("Telefono");
                    ConexionBD.miConexion.Close();
                    return true;
                }

                ConexionBD.miConexion.Close();
            }
            catch (Exception f)
            {
                ConexionBD.miConexion.Close();
                Console.WriteLine("CargarDetallesUsuario: " + f.Message);
                return false;
            }
            return false;
        }
        public static string NApellidoUsuario(int cedula)
        {
            string Nombre = "";
            string Apellido = "";
            string NApellido = "";
            try
            {
                string Query = "SELECT Nombre,Apellido FROM Pollux.usuario WHERE Cedula= @cedula;";
                MySqlCommand comando = new MySqlCommand(Query, ConexionBD.miConexion);
                comando.Parameters.AddWithValue("@cedula", cedula);
                ConexionBD.miConexion.Open();
                MySqlDataReader lector = comando.ExecuteReader();

                if (lector.Read())
                {
                    Nombre = lector.GetString("Nombre");
                    Apellido = lector.GetString("Apellido");
                    ConexionBD.miConexion.Close();
                    NApellido = Nombre[0] + Apellido;
                    return NApellido;
                    
                }

                ConexionBD.miConexion.Close();
            }
            catch (Exception f)
            {
                ConexionBD.miConexion.Close();
                Console.WriteLine("NApellidoUsuario: " + f.Message);
                return NApellido;
            }
            return NApellido;
        }
        public static string GetPass(int cedula)
        {
            string tipo = "";
            try
            {
                string Query = "SELECT Password FROM Pollux.usuario WHERE Cedula= @cedula;";
                MySqlCommand comando = new MySqlCommand(Query, ConexionBD.miConexion);
                comando.Parameters.AddWithValue("@cedula", cedula);
                ConexionBD.miConexion.Open();
                MySqlDataReader lector = comando.ExecuteReader();

                if (lector.Read())
                {
                    tipo = lector.GetString("Password");
                    ConexionBD.miConexion.Close();
                    return tipo;
                }

                ConexionBD.miConexion.Close();
            }
            catch (Exception f)
            {
                ConexionBD.miConexion.Close();
                Console.WriteLine("GetPass: " + f.Message);
                return tipo;
            }
            return tipo;
        }
        //##########################SELECT###################################

        //##########################DELETE###################################
        public static bool BajaUsuario(int ci)
        {
            try
            {
                string Query = "delete from Pollux.usuario where Cedula=@ci;";
                MySqlCommand comando = new MySqlCommand(Query, ConexionBD.miConexion);
                comando.Parameters.AddWithValue("@ci",ci);
                ConexionBD.miConexion.Open();
                comando.ExecuteReader();
                ConexionBD.miConexion.Close();
            }
            catch (Exception f)
            {
                ConexionBD.miConexion.Close();
                Console.WriteLine("BajaUsuario: " + f.Message);
                return false;
            }
            return true;
        }
        //##########################DELETE###################################

        //##########################UPDATE###################################
        public static bool ModificarEmpleado(int ci, int ci2, string nombre, string apellido, string correo, string telefono, string direccion, string cargo)
        {
            try
            {

                string Query = "UPDATE Pollux.usuario SET Cedula=@ci2, Nombre=@nombre, Apellido=@apellido, Correo=@correo, Telefono=@telefono, Direccion=@direccion, TipoUsuario=@cargo WHERE Cedula =@ci;";
                MySqlCommand comando = new MySqlCommand(Query, ConexionBD.miConexion);
                comando.Parameters.AddWithValue("@ci2",ci2);
                comando.Parameters.AddWithValue("@nombre", nombre);
                comando.Parameters.AddWithValue("@apellido", apellido);
                comando.Parameters.AddWithValue("@correo", correo);
                comando.Parameters.AddWithValue("@telefono", telefono);
                comando.Parameters.AddWithValue("@direccion", direccion);
                comando.Parameters.AddWithValue("@cargo", cargo);
                comando.Parameters.AddWithValue("@ci", ci);
                ConexionBD.miConexion.Open();
                comando.ExecuteReader();
                ConexionBD.miConexion.Close();
            }
            catch (Exception f)
            {
                ConexionBD.miConexion.Close();
                Console.WriteLine("ModificarEmpleado: " + f.Message);
                return false;
            }
            return true;
        }
        public static bool EditarInfoContacto(string correo,string direccion,string telefono,int ci) {
            try
            {

                string Query = "UPDATE Pollux.usuario SET Correo=@correo,Direccion=@direccion,Telefono=@telefono WHERE Cedula= @cedula;";
                MySqlCommand comando = new MySqlCommand(Query, ConexionBD.miConexion);
                comando.Parameters.AddWithValue("@correo", correo);
                comando.Parameters.AddWithValue("@direccion", direccion);
                comando.Parameters.AddWithValue("@telefono", telefono);
                comando.Parameters.AddWithValue("@cedula", ci);
                ConexionBD.miConexion.Open();
                comando.ExecuteReader();
                ConexionBD.miConexion.Close();
                return true;
            }
            catch (Exception f)
            {
                ConexionBD.miConexion.Close();
                Console.WriteLine("EditarInfoContacto: " + f.Message);
                return false;
            }
        }
        public static bool EditarContraseña(string contraseña,int cedula)
        {
            try
            {

                string Query = "UPDATE Pollux.usuario SET Password=@contraseña WHERE Cedula= @cedula;";
                MySqlCommand comando = new MySqlCommand(Query, ConexionBD.miConexion);
                comando.Parameters.AddWithValue("@contraseña", contraseña);
                comando.Parameters.AddWithValue("@cedula", cedula);
                ConexionBD.miConexion.Open();
                comando.ExecuteReader();
                ConexionBD.miConexion.Close();
                return true;
            }
            catch (Exception f)
            {
                ConexionBD.miConexion.Close();
                Console.WriteLine("EditarContraseña: " + f.Message);
                return false;
            }
        }
        //##########################UPDATE###################################
    }
}
