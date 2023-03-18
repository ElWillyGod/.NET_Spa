using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bunifu.UI.WinForms;
namespace Logica
{
    public class Cliente
    {
        //##########################INSERT###################################
        public static bool ReservarCliente(int ci, string nombre, string apellido, string correo, string telefono, string direccion,string entrada, int total)
        {
           return Datos.Cliente.ReservarCliente(ci, nombre, apellido, correo, telefono, direccion, entrada, total);
        }
        public static bool logCliente(int user, int ci, string accion)
        {
            return Datos.Cliente.logCliente(user,ci,accion);
        }
            //##########################INSERT###################################

            //##########################SELECT###################################
            public static bool CargarClientes(DataGridView tabla)
        {
            return Datos.Cliente.CargarClientes(tabla);
        }
        public static bool CheckClienteExiste(int cedula)
        {
            return Datos.Cliente.CheckClienteExiste(cedula);
        }
        public static bool CheckReservaExiste(int ci, string fecha)
        {
            return Datos.Cliente.CheckReservaExiste(ci, fecha);
        }
        public static bool cargarDatosClienteExistente(BunifuTextBox Cedula, BunifuTextBox Nombre, BunifuTextBox Apellido, BunifuTextBox Correo, BunifuTextBox Telefono, BunifuTextBox Direccion, ComboBox cb)
        {
            return Datos.Cliente.CargarDatosClienteExistente(Cedula,Nombre,Apellido,Correo,Telefono,Direccion,cb);

        }
        public static int getTotalAPagar(int ci)
        {
            return Datos.Cliente.GetTotalAPagar(ci);
        }
        public static bool BuscarCliente(DataGridView tabla, string filtro)
        {
            return Datos.Cliente.BuscarCliente(tabla, filtro);
        }
        public static bool BuscarClientePorIdReserva(DataGridView tabla, string filtro)
        {
            return Datos.Cliente.BuscarClientePorIdReserva(tabla, filtro);
        }
        //##########################SELECT###################################

        //##########################DELETE###################################
        public static bool bajaCliente(int ci)
        {
            return Datos.Cliente.BajaCliente(ci);
        }
        //##########################DELETE###################################

        //##########################UPDATE###################################
        public static bool ModificarTotalAPagar(int ci, int valor)
        {
            return Datos.Cliente.ModificarTotalAPagar(ci, valor);
        }
        public static bool quitarPrecioServicio(int ci, int valor)
        {
            return Datos.Cliente.QuitarPrecioServicio(ci, valor);
        }
        public static bool modificarCliente(int ci, int ci2, string nombre, string apellido, string correo, string telefono, string direccion, string entrada, int totalAPagar)
        {
            return Datos.Cliente.ModificarCliente(ci, ci2, nombre, apellido, correo, telefono, direccion, entrada, totalAPagar);
        }
        //##########################UPDATE###################################

    }

}
