﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Logica
{
   public class Servicio
    {
        //##########################INSERT###################################
        public static bool altaServicio(string nombre, int capacidadMax, int permanenciaMinutos, int cuposMax, int costo)
        {
            return Datos.Servicio.AltaServicio(nombre,capacidadMax,permanenciaMinutos,cuposMax,costo);
        }
        public static bool logServicio(int user, string Servicio, string Accion)
        {
            return Datos.Servicio.logServicio(user, Servicio, Accion);
        }
            //##########################INSERT###################################

            //##########################DELETE###################################
            public static bool bajaServicio(string nombre)
        {
            return Datos.Servicio.BajaServicio(nombre);
        }
        //##########################DELETE###################################

        //##########################UPDATE###################################
        public static bool ModificarServicio(int capacidad, int permanencia, int cupos, int costo, int hab, string servicio)
        {
            return Datos.Servicio.ModificarServicio(capacidad, permanencia, cupos, costo, hab, servicio);
        }
        public static bool habilitarDesabilitarServicio(string servicio, bool deshabilitar, string fecha)
        {
            return Datos.Servicio.HabilitarDesabilitarServicio(servicio, deshabilitar, fecha);
        }
        //##########################UPDATE###################################

        //##########################SELECT###################################
        public static ArrayList getServicios()
        {
            return Datos.Servicio.GetServicios();
        }
        public static int verificiarPrecio(string servicio)
        {
            return Datos.Servicio.VerificiarPrecio(servicio);
        }
        public static bool mostrarTablaServicios(DataGridView tabla)
        {
            return Datos.Servicio.MostrarTablaServicios(tabla);
        }
        public static bool buscarServicio(string servicio, DataGridView tabla)
        {
            return Datos.Servicio.BuscarServicio(servicio, tabla);
        }
        public static int getPermanencia(string servicio)
        {
            return Datos.Servicio.GetPermanencia(servicio);
        }
        public static int getCupos(string servicio)
        {
            return Datos.Servicio.GetCupos(servicio);
        }
        public static int getCapacidadMaxima(string servicio)
        {
            return Datos.Servicio.GetCapacidadMaxima(servicio);
        }
        public static int GetPorcentajeServiciosHabilitados()
        {
            return Datos.Servicio.GetPorcentajeServiciosHabilitados();
        }
        public static bool GetHabilitado(string servicio)
        {
            return Datos.Servicio.GetHabilitado(servicio);
        }
        public static bool CargarServiciosComboBox(ComboBox combo)
        {
            return Datos.Servicio.CargarServiciosComboBox(combo);
        }
        public static DataTable TablaReporteServicios(DateTime desde,DateTime hasta)
        {
            return Datos.Servicio.TablaReporteServicios(desde,hasta);
        }
        //##########################SELECT###################################

    }
}
