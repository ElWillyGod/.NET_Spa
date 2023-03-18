using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Logica
{
   public class acompañantes
    {
        public static DataTable lista = new DataTable("Acompañantes");

        //##########################INSERT###################################
        public static bool agregarAcompañante(int ci, int ciAcompañante, string fecha)
        {
            return Datos.acompañantes.agregarAcompañante(ci, ciAcompañante, fecha);

        }
        //##########################INSERT###################################

        //##########################SELECT###################################
        public static bool CargarAcompañantes(DataGridView tabla, string fecha, int ci)
        {
            return Datos.acompañantes.CargarAcompañantes(tabla, fecha, ci);
        }        
        public static DataTable GetAcompañantes(string fecha, int ci)
        {
            return Datos.acompañantes.GetAcompañantes(fecha, ci);
        }
        //##########################SELECT###################################
        public static bool BajaAcompañante(int ci, int ci2, string fecha)
        {
            return Datos.acompañantes.BajaAcompañante(ci, ci2, fecha);
        }
        //##########################DELETE###################################

    }
}
