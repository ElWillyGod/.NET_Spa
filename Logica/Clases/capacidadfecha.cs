using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Logica
{
    public class capacidadfecha
    {
        //##########################INSERT###################################
        public static bool agregarCapacidad(string servicio, string fecha)
        {
            return Datos.capacidadfecha.AgregarCapacidad(servicio,fecha);
        }
        //##########################INSERT###################################
       
        //##########################SELECT###################################
        public static DataTable OcupacionServiciosTop(DateTime desde, DateTime hasta)
        {
            return Datos.capacidadfecha.OcupacionServiciosTop(desde,hasta);
        }
        public static bool MostrarTablaCapacidades(DataGridView tabla, DateTime fecha)
        {
            return Datos.capacidadfecha.MostrarTablaCapacidades(tabla,fecha);
        }
        public static DataTable MostrarTablaCapacidadesDT(DateTime fecha)
        {
            return Datos.capacidadfecha.MostrarTablaCapacidadesDT(fecha);
        }
        public static int GetCapacidadFecha(string servicio, string fecha)
        {
            return Datos.capacidadfecha.GetCapacidadFecha(servicio,fecha);
        }
        //##########################SELECT###################################
    }
}
