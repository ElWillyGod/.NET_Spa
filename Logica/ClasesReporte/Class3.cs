using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class SalesReport
    {
        //Attributes-Properties
        public DateTime FechaReporte { get; private set; }
        public DateTime FechaComienzo { get; private set; }
        public DateTime FechaFinal { get; private set; }
        public List<SalesListing> salesListing { get; private set; }
        public List<NetSalesByPeriod> netSalesByPeriod { get; private set; }
        public double VentasTotales { get; private set; }
        //Methods
        public void createSalesOrderReport(DateTime fromDate, DateTime toDate)
        {
            //implement dates
            FechaReporte = DateTime.Now;
            FechaComienzo = fromDate;
            FechaFinal = toDate;
            //create sales listing
            var result = Datos.datos.getSalesOrder(fromDate.ToString("yyyy-MM-dd"), toDate.ToString("yyyy-MM-dd"));
            salesListing = new List<SalesListing>();
            foreach (System.Data.DataRow rows in result.Rows)
            {
                var salesModel = new SalesListing()
                {
                    IdReserva = Convert.ToInt32(rows[0]),
                    FechaReserva = Convert.ToDateTime(rows[1]),
                    Nombre = Convert.ToString(rows[2]),
                    Apellido = Convert.ToString(rows[3]),
                    MontoTotal = Convert.ToDouble(rows[4])
                };
                salesListing.Add(salesModel);
                //calculate total net sales
                VentasTotales += Convert.ToDouble(rows[4]);
            }
            //create net sales by period
            ////create temp list net sales by date
            var listSalesByDate = (from sales in salesListing
                                   group sales by sales.FechaReserva
                       into listSales
                                   select new
                                   {
                                       date = listSales.Key,
                                       amount = listSales.Sum(item => item.MontoTotal)
                                   }).AsEnumerable();
            ////get number of days
            int totalDays = Convert.ToInt32((toDate - fromDate).Days);
            ////group period by days
            if (totalDays <= 7)
            {
                netSalesByPeriod = (from sales in listSalesByDate
                                    group sales by sales.date.ToString("dd-MMM-yyyy")
                           into listSales
                                    select new NetSalesByPeriod
                                    {
                                        Periodo = listSales.Key,
                                        Ventas = listSales.Sum(item => item.amount)
                                    }).ToList();
            }
            ////group period by weeks
            else if (totalDays <= 30)
            {
                netSalesByPeriod = (from sales in listSalesByDate
                                    group sales by
                                    System.Globalization.CultureInfo.CurrentCulture.Calendar.GetWeekOfYear(
                                      sales.date, System.Globalization.CalendarWeekRule.FirstDay, DayOfWeek.Monday)
                        into listSales
                                    select new NetSalesByPeriod
                                    {
                                        Periodo = "Semana " + listSales.Key.ToString(),
                                        Ventas = listSales.Sum(item => item.amount)
                                    }).ToList();
            }
            ////group period by months
            else if (totalDays <= 365)
            {
                netSalesByPeriod = (from sales in listSalesByDate
                                    group sales by sales.date.ToString("MMM-yyyy")
                        into listSales
                                    select new NetSalesByPeriod
                                    {
                                        Periodo = listSales.Key,
                                        Ventas = listSales.Sum(item => item.amount)
                                    }).ToList();
            }
            ////group period by years
            else
            {
                netSalesByPeriod = (from sales in listSalesByDate
                                    group sales by sales.date.ToString("yyyy")
                        into listSales
                                    select new NetSalesByPeriod
                                    {
                                        Periodo = listSales.Key,
                                        Ventas = listSales.Sum(item => item.amount)
                                    }).ToList();
            }
        }
    }
}
