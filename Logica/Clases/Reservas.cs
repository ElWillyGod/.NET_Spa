using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Logica
{
    public class Reservas
    {
        public static DataTable reservas = new DataTable("Reservas");

        //##########################SELECT###################################
        public static ArrayList checkServiciosContratados(string cedula, string fecha)
        {
            return Datos.Reservas.CheckServiciosContratados(cedula, fecha);
        }
        public static bool cargarServiciosCliente(DataGridView tabla, int nro)
        {
            return Datos.Reservas.CargarServiciosCliente(tabla, nro);
        }
        public static int contarServiciosCliente(int cedula)
        {
            return Datos.Reservas.ContarServiciosCliente(cedula);
        }
        public static DataTable cargarServiciosReservados(int nro)
        {
            return Datos.Reservas.CargarServiciosReservados(nro);
        }
        public static DataTable cargarServiciosReservados2(int ci)
        {
            return Datos.Reservas.CargarServiciosReservados2(ci);
        }
        public static int ContarReservasRealizadasHoy()
        {
            return Datos.Reservas.ContarReservasRealizadasHoy();
        }
        public static int ContarClientesCurrentHora()
        {
            return Datos.Reservas.ContarClientesCurrentHora();
        }
        public static bool CargarClientesPorServicioYFecha(DataGridView tabla, string fecha, string servicio)
        {
            return Datos.Reservas.CargarClientesPorServicioYFecha(tabla, fecha, servicio);
        }
        public static DataTable CargarClientesPorServicioYFechaDT(string fecha, string servicio)
        {
            return Datos.Reservas.CargarClientesPorServicioYFechaDT(fecha, servicio);
        }
        public static bool CargarReservasPorHoraYFecha(DataGridView tabla, DateTime fecha, string hora)
        {
            return Datos.Reservas.CargarReservasPorHoraYFecha(tabla, fecha, hora);
        }
        public static DataTable CargarReservasPorHoraYFechaDT(DateTime fecha, string hora)
        {
            return Datos.Reservas.CargarReservasPorHoraYFechaDT(fecha, hora);
        }
        public static bool CargarArribos(DataGridView tabla, DateTime fecha)
        {
            return Datos.Reservas.CargarArribos(tabla, fecha);
        }
        public static bool CargarPartidas(DataGridView tabla, DateTime fecha)
        {
            return Datos.Reservas.CargarPartidas(tabla, fecha);
        }
        public static DataTable CargarHorasNoDisponiblesBD(string fecha)
        {
            return Datos.Reservas.CargarHorasNoDisponiblesBD(fecha);
        }
        //##########################SELECT###################################

        //##########################INSERT###################################
        public static bool ReservarServicio(int nro, string hora, int cliente, string servicio, int costo)
        {
            return Datos.Reservas.ReservarServicio(nro, hora, cliente, servicio, costo);
        }
        public static bool LogReservarServicio(int user, int nroReserva, string hora, int cliente, string accion)
        {
            return Datos.Reservas.LogReservarServicio(user, nroReserva,hora, cliente, accion);
        }
        //##########################INSERT###################################

        //##########################DELETE###################################
            public static bool bajaServicioCliente(int nro, string hora)
        {
            return Datos.Reservas.BajaServicioCliente(nro, hora);
        }
        //##########################DELETE###################################
        public static DataTable GetServiciosCliente(int nro)
        {
            return Datos.Reservas.GetServiciosCliente(nro);
        }
        //##########################UPDATE###################################
        public static bool cambiarHoraReserva(int nro, string horaVieja, string horaNueva)
        {
            return Datos.Reservas.CambiarHoraReserva(nro, horaVieja, horaNueva);
        }
        //##########################UPDATE###################################
    }
}
