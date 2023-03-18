using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{

    public class SalesReportServicios
    {
        // Attributes
        public DateTime FechaReporte { get; private set; }
        public DateTime DesdeFecha { get; private set; }
        public DateTime HastaFecha { get; private set; }
        public List<ServiciosVentas> VentasServicios { get; private set; }
        public double Total { get; private set; }
        // Propiertes

        public void GetBestSellingProductsReport(DateTime fromDate, DateTime toDate)
        {
            // implement dates
            FechaReporte = DateTime.Now;
            DesdeFecha = fromDate;
            HastaFecha = toDate;
            // Create list best selling products
            VentasServicios = new List<ServiciosVentas>();
           
            var resultTable = Servicio.TablaReporteServicios(fromDate, toDate);
            foreach (DataRow row in resultTable.Rows)
            {
                var bestProductModel = new ServiciosVentas()
                {
                    Servicio = Convert.ToString(row[0]),
                    Cantidad = Convert.ToInt32(row[1]),
                    Ventas = Convert.ToDouble(row[2])
                };
                VentasServicios.Add(bestProductModel);
                Total += Convert.ToDouble(row[2]);
            }
        }
    }


}
