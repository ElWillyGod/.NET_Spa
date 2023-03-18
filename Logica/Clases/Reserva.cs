using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Logica
{
    public class Reserva
    {
        //##########################INSERT###################################
        public static bool ReservarServicio(string fecha, int ci, int confirmada, int APagar, int total, string medioDePago)
        {
            return Datos.Reserva.CrearReserva(fecha, ci, confirmada, APagar, total, medioDePago);
        }
        public static bool logReserva(int user, int IdReserva, string accion)
        {
            return Datos.Reserva.logReserva(user,IdReserva,accion);
        }

            //##########################INSERT###################################


            //##########################SELECT###################################
            public static int GetIdReserva(string fecha, int ci)
        {
            return Datos.Reserva.GetIdReserva(fecha, ci);
        }
        public static DataTable GetReservas(int ci)
        {
            return Datos.Reserva.GetReservas(ci);
        }
        public static bool CargarReservaCliente(DataGridView tabla, int ci)
        {
            return Datos.Reserva.CargarReservaCliente(tabla, ci);
        }
        public static int ContarClientesHoy()
        {
            return Datos.Reserva.ContarClientesHoy();
        }
        public static int IngresosEstaSemana()
        {

            return Datos.Reserva.IngresosEstaSemana();
        }
        public static DataTable ServiciosMasReservados(DateTime desde, DateTime hasta)
        {
            return Datos.Reserva.ServiciosMasReservados(desde, hasta);
        }
        public static DataTable NroClientes(DateTime desde, DateTime hasta)
        {
            return Datos.Reserva.NroClientes(desde, hasta);
        }
        public static int GetPorcentajeConfirmados()
        {
            return Datos.Reserva.GetPorcentajeConfirmados();
        }
        //##########################SELECT###################################

        //##########################UPDATE###################################
        public static bool sumarTotal(int nro, int valor)
        {
            return Datos.Reserva.SumarTotal(nro, valor);
        }
        public static bool SumarAPagar(int nro, int valor)
        {
            return Datos.Reserva.SumarAPagar(nro, valor);
        }
        public static bool borrarConfirmacion(int nro, int valor)
        {
            return Datos.Reserva.borrarConfirmacion(nro, valor);
        }
        public static bool SumarTotalAPagarCliente(int ci)
        {
            return Datos.Reserva.SumarTotalAPagarCliente(ci);
        }
        public static bool SetAPagar(int idReserva, int valor)
        {
            return Datos.Reserva.SetAPagar(idReserva, valor);
        }
        //##########################UPDATE###################################


        //##########################DELETE###################################
        public static bool BorrarDelCostoTotalXCantidad(int nroReserva, int valor)
        {
            return Datos.Reserva.BorrarDelCostoTotalXCantidad(nroReserva,valor);
        }
        public static bool BorrarDeAPagarXCantidad(int nroReserva, int valor)
        {
            return Datos.Reserva.BorrarDeAPagarXCantidad(nroReserva, valor);
        }
        public static bool BorrarSoloReserva(int nro)
        {
            return Datos.Reserva.BorrarSoloReserva(nro);
        }
        public static bool BorrarReservaCompleta(int nro, string fecha)
        {
            return Datos.Reserva.BorrarReservaCompleta(nro,fecha);
        }
        public static bool borrarTodasReservasCliente(int ci)
        {
            return Datos.Reserva.borrarTodasReservasCliente(ci);
        }
        //##########################DELETE###################################


        }
}
