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
    public class Fecha
    {
        //##########################INSERT###################################
        public static bool agregarHoras(string servicio, string fecha)
        {
            return Datos.Fecha.AgregarHoras(servicio,fecha);
        }
        //##########################INSERT###################################

        //##########################SELECT###################################
        public static bool CargarHoras(ComboBox combo, string servicio, string fecha, ArrayList horasNoDisponibles, ArrayList horasNoDisponibles2, string ida, string vuelta, int ci,int nro)
        {
            return Datos.Fecha.CargarHoras(combo, servicio, fecha, horasNoDisponibles, horasNoDisponibles2, ida, vuelta, ci,nro);
        }   
        public static bool checkFecha(string fecha, string servicio)
        {
           return Datos.Fecha.CheckFecha(fecha, servicio);
        }
        public static int getCuposHora(string servicio, string fecha, string hora)
        {
            return Datos.Fecha.GetCuposHora(servicio, fecha, hora);
        }
        public static bool MostrarTablaCupos(DataGridView tabla, DateTime fecha, string servicio)
        {
            return Datos.Fecha.MostrarTablaCupos(tabla, fecha, servicio);
        }
        public static DataTable MostrarTablaCuposDT(DateTime fecha, string servicio)
        {
            return Datos.Fecha.MostrarTablaCuposDT(fecha, servicio);
        }
        public static ArrayList CargarHoras2(string servicio, string fecha)
        {
            return Datos.Fecha.CargarHoras2(servicio, fecha);
        }
        //##########################SELECT###################################

        //##########################UPDATE###################################
        public static bool modificarCapacidad(string servicio, string fecha, bool SumarCapacidad)
        {
            return Datos.Fecha.modificarCapacidad(servicio, fecha, SumarCapacidad);
        }
        public static bool ModificarCupos(string fecha, string hora, string servicio, bool SumarCupo)
        {
            return Datos.Fecha.ModificarCupos(fecha, hora, servicio, SumarCupo);
        }
        //##########################UPDATE###################################

        public static ArrayList horasNoDisponiblesReservadas(int nro)
        {
            return Datos.Fecha.HorasNoDisponiblesReservadas(nro);
        }
        public static ArrayList horasNoDisponiblesReservadas2(int nro)
        {
            return Datos.Fecha.HorasNoDisponiblesReservadas2(nro);
        }
        
        

    }
}
