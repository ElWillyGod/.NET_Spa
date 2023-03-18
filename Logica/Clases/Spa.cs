using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class Spa
    {
        //##########################SELECT###################################
        public static string gethoraApertura()
        {
            return Datos.Spa.GethoraApertura();
        }
        public static string gethoraCierre()
        {
            return Datos.Spa.GethoraCierre();
        }
        public static Image CargarlogoAColorSpa()
        {
            return Datos.Spa.CargarlogoAColorSpa(); 
        }
        //##########################SELECT###################################

        //##########################UPDATE###################################
        public static bool modificarHorarioSpa(string horaEntrada, string horaCierre)
        {
            return Datos.Spa.modificarHorarioSpa(horaEntrada,horaCierre);
        }
        //##########################UPDATE###################################


    }
}
