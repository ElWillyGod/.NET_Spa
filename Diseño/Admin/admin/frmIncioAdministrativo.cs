using LiveCharts;
using LiveCharts.Wpf;
using System;
using System.Collections;
using System.Data;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Forms;
using System.Windows.Media;

namespace Spa
{

    public partial class frmInicioAdministrativo : Form
    {
        public static int contador = 0;

        public frmInicioAdministrativo()
        {
            InitializeComponent();
            lblPersonasHora.Text = "" + Logica.Reservas.ContarClientesCurrentHora();
        }
        private void tabla2(DateTime desde, DateTime hasta)
        {
            cartesianChart2.Series.Clear();
            cartesianChart2.AxisX.Clear();
            cartesianChart2.AxisY.Clear();
            DataTable xd = Logica.Reserva.NroClientes(desde, hasta);
            cartesianChart2.AnimationsSpeed = new TimeSpan(0, 0, 0, 0, 600);
            int[] valores = new int[xd.Rows.Count];
            string[] Fechas = new string[xd.Rows.Count];
            int i = 0;
            foreach (DataRow dr in xd.Rows)
            {
                valores[i] = Int32.Parse(dr["Clientes"].ToString());
                Fechas[i] = dr["Fecha"].ToString();
                i++;
            }
            cartesianChart2.Series = new SeriesCollection
            {
                new LineSeries
                {
                     Title = "Clientes",
                    Values = new ChartValues<int> (valores),
                    StrokeThickness = 2,
                    Stroke = new SolidColorBrush(System.Windows.Media.Color.FromArgb(255,0, 126, 249)),
                    PointGeometrySize = 15,
                    Fill = new SolidColorBrush(System.Windows.Media.Color.FromArgb(128,0, 126, 249))
                }
            };

            cartesianChart2.AxisX.Add(new Axis
            {
                Title = "Fechas",
                Labels = Fechas,
                Foreground = new SolidColorBrush(System.Windows.Media.Color.FromArgb(255, 199, 199, 199))
            });

            cartesianChart2.AxisY.Add(new Axis
            {
                Title = "Nro Clientes",
                LabelFormatter = value => value.ToString("N0"),
                Foreground = new SolidColorBrush(System.Windows.Media.Color.FromArgb(255, 199, 199, 199))
            });
            cartesianChart2.AxisX[0].Separator.StrokeThickness = 0;
            cartesianChart2.AxisY[0].Separator.StrokeThickness = 0;
        }
        private void tablaPie(DateTime desde,DateTime hasta)
        {
            DataTable xd = Logica.Reserva.ServiciosMasReservados(desde,hasta);
            Func<ChartPoint, string> labelPoint = chartPoint =>
                string.Format("{0} ({1:P})", chartPoint.Y, chartPoint.Participation);

            SeriesCollection piechartData = new SeriesCollection();
            foreach (DataRow dr in xd.Rows)
            {
                piechartData.Add(new PieSeries
                {

                    Title = dr["Servicio"].ToString(),
                    Values = new ChartValues<double> { Double.Parse(dr["Nro Reservas"].ToString()) },
                    DataLabels = true,
                    LabelPoint = labelPoint,
                    Stroke = new SolidColorBrush(System.Windows.Media.Color.FromArgb(255, 40, 40, 40)),
                    Foreground = Brushes.White
                });
            }
            pieChart1.DefaultLegend.Foreground = new SolidColorBrush(System.Windows.Media.Color.FromArgb(255, 199, 199, 199));
            pieChart1.Series = piechartData;
            pieChart1.LegendLocation = LegendLocation.Bottom;
        }
        private void temporizador_Tick(object sender, EventArgs e)
        {
            temporizador.Stop();
        }
        private void frmInicioGerente_Load(object sender, EventArgs e)
        {
            
            var fromDate = DateTime.Today.AddDays(-7);
            var toDate = DateTime.Now;
            tablaPie(fromDate, toDate);
            tabla2(fromDate, toDate);
            lblNumeroClientes.Text = Convert.ToString(Logica.Reserva.ContarClientesHoy());
            lblReservasHoy.Text = Convert.ToString(Logica.Reservas.ContarReservasRealizadasHoy());
        


        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Reloj_Tick(object sender, EventArgs e)
        {
            lblReloj.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void ReservasConfirmadasTimer_Tick(object sender, EventArgs e)
        {
            while (PorcentajeReservasConfirmadas.Value < Logica.Reserva.GetPorcentajeConfirmados())
            {
                PorcentajeReservasConfirmadas.Value++;
                PorcentajeReservasConfirmadas.Text = String.Format("{0}%", PorcentajeReservasConfirmadas.Value);
                ReservasConfirmadasTimer.Stop();
            }
        }

        private void btnTopHoy_Click(object sender, EventArgs e)
        {
            var fromDate = DateTime.Today;
            var toDate = DateTime.Now;
            tablaPie(fromDate, toDate);
        }

        private void btnTop7dias_Click(object sender, EventArgs e)
        {
            var fromDate = DateTime.Today.AddDays(-7);
            var toDate = DateTime.Now;
            tablaPie(fromDate, toDate);
        }

        private void btn30DiasTop_Click(object sender, EventArgs e)
        {
            var fromDate = DateTime.Today.AddDays(-30);
            var toDate = DateTime.Now;
            tablaPie(fromDate, toDate);
        }

        private void btn30DiasClientes_Click(object sender, EventArgs e)
        {
            var fromDate = DateTime.Today.AddDays(-30);
            var toDate = DateTime.Now;
            tabla2(fromDate, toDate);
        }

        private void btn7diasClientes_Click(object sender, EventArgs e)
        {

            var fromDate = DateTime.Today.AddDays(-7);
            var toDate = DateTime.Now;

            tabla2(fromDate, toDate);
        }
    }
}
