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

    public partial class frmInicioGerente : Form
    {
        public static int contador = 0;

        public frmInicioGerente()
        {
            InitializeComponent();
        }
        private void tabla(DateTime desde,DateTime hasta)
        {
            cartesianChart1.Series.Clear();
            cartesianChart1.AxisX.Clear();
            cartesianChart1.AxisY.Clear();
            
            DataTable xd = Logica.capacidadfecha.OcupacionServiciosTop(desde,hasta);
            cartesianChart1.AnimationsSpeed = new TimeSpan(0, 0, 0, 0, 500);
            double[] valores = new double[5];
            string[] Servicios = new string[5];
            int i = 0;
            foreach (DataRow dr in xd.Rows)
            {
                valores[i] = double.Parse(dr["Porcentaje"].ToString());
                Servicios[i] = dr["Servicio"].ToString();
                i++;
            }

            cartesianChart1.Series = new SeriesCollection
            {
               new ColumnSeries
               {
                   Title = "ocupación",
                   Values = new ChartValues<double>(valores),
                   Fill = new SolidColorBrush(System.Windows.Media.Color.FromArgb(255, 165, 21, 80)),
                   Foreground = new SolidColorBrush(System.Windows.Media.Color.FromArgb(255, 199, 199, 199)),
                   MaxColumnWidth = 100
        }
            };
            cartesianChart1.AxisX.Add(new Axis
            {
                Title = "Servicios",
                Labels = Servicios,
                LabelFormatter = value => value.ToString("N")
            });
            cartesianChart1.AxisY.Add(new Axis
            {
                Sections = new SectionsCollection
                {
                    new AxisSection
                    {
                        Value = 70,
                        Stroke = Brushes.Green,
                        StrokeThickness = 3,
                        //StrokeDashArray = new DoubleCollection(new [] {10d})
                    },
                    new AxisSection
                    {
                        Value = 50,
                        Stroke = Brushes.Yellow,
                        StrokeThickness = 3,
                        //StrokeDashArray = new DoubleCollection(new [] {10d})
                    },
                     new AxisSection
                    {
                        Value = 30,
                        Stroke = Brushes.Red,
                        StrokeThickness = 3,
                        //StrokeDashArray = new DoubleCollection(new [] {10d})
                    }
                },
                Title = "Porcentaje %",
                LabelFormatter = value => value.ToString()
            });
            cartesianChart1.AxisX[0].Separator.Width = 150;
            cartesianChart1.AxisX[0].Separator.StrokeThickness = 0;
            cartesianChart1.AxisY[0].Separator.StrokeThickness = 0;
      
        }
        private void tablaLineas() {
            cartesianChart1.VisualElements.Add(new VisualElement
            {
                X = -0.4,
                Y = 71,
                HorizontalAlignment = System.Windows.HorizontalAlignment.Center,
                VerticalAlignment = VerticalAlignment.Top,
                UIElement = new TextBlock
                {
                    Text = "Ideal",
                    FontWeight = FontWeights.Bold,
                    FontSize = 12,
                    Opacity = 0.6,
                    Foreground = Brushes.Green
                }
            });
            cartesianChart1.VisualElements.Add(new VisualElement
            {
                X = -0.35,
                Y = 51,
                HorizontalAlignment = System.Windows.HorizontalAlignment.Center,
                VerticalAlignment = VerticalAlignment.Top,
                UIElement = new TextBlock
                {
                    Text = "Estable",
                    FontWeight = FontWeights.Bold,
                    FontSize = 12,
                    Opacity = 0.6,
                    Foreground = Brushes.Yellow
                }
            });
            cartesianChart1.VisualElements.Add(new VisualElement
            {
                X = -0.3,
                Y = 31,
                HorizontalAlignment = System.Windows.HorizontalAlignment.Center,
                VerticalAlignment = VerticalAlignment.Top,
                UIElement = new TextBlock
                {
                    Text = "Deplorable",
                    FontWeight = FontWeights.Bold,
                    FontSize = 12,
                    Opacity = 0.6,
                    Foreground = Brushes.Red
                }
            });
        }

        private void tabla2(DateTime desde,DateTime hasta)
        {
            cartesianChart2.Series.Clear();
            cartesianChart2.AxisX.Clear();
            cartesianChart2.AxisY.Clear();
            DataTable xd = Logica.Reserva.NroClientes(desde,hasta);
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
                    Stroke = new SolidColorBrush(System.Windows.Media.Color.FromArgb(255,165, 21, 80)),
                    PointGeometrySize = 15,
                    Fill = new SolidColorBrush(System.Windows.Media.Color.FromArgb(128,165, 21, 80))
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
        private void tablaPie(DateTime desde, DateTime hasta)
        {
            pieChart1.Series.Clear();
            pieChart1.AxisX.Clear();
            pieChart1.AxisY.Clear();
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
            lblPersonasHora.Text = "" + Logica.Reservas.ContarClientesCurrentHora();
            PorcentajeReservasConfirmadas.Value = 0;
            PorcentajeServiciosHabilitados.Value = 0;
            PorcentajeReservasConfirmadas.Text = String.Format("{0:P}",0);
            PorcentajeServiciosHabilitados.Text = String.Format("{0:P}", 0);

            
           
            var fromDate = DateTime.Today.AddDays(-7);
            var toDate = DateTime.Now;
            tablaPie(fromDate, toDate);
            tabla(fromDate, toDate);
            tablaLineas();
            tabla2(fromDate,toDate);
           
            DateTime hoy = DateTime.Today;
            lblNumeroClientes.Text = Convert.ToString(Logica.Reserva.ContarClientesHoy());
            lblReservasHoy.Text = Convert.ToString(Logica.Reservas.ContarReservasRealizadasHoy());
            lblIngresos.Text = String.Format("{0:C}", Logica.Reserva.IngresosEstaSemana());


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

        private void ServiciosHablitadosTimer_Tick(object sender, EventArgs e)
        {
            while (PorcentajeServiciosHabilitados.Value < Logica.Servicio.GetPorcentajeServiciosHabilitados())
            {
                PorcentajeServiciosHabilitados.Value++;
                PorcentajeServiciosHabilitados.Text = String.Format("{0}%", PorcentajeServiciosHabilitados.Value);
                ServiciosHablitadosTimer.Stop();
            }
        }

        private void Reloj_Tick(object sender, EventArgs e)
        {
            lblReloj.Text = DateTime.Now.ToString("HH:mm:ss");
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

        private void btn30DiasOcupacion_Click(object sender, EventArgs e)
        {
            var fromDate = DateTime.Today.AddDays(-30);
            var toDate = DateTime.Now;
            tabla(fromDate, toDate);
        }

        private void btn7diasOcupacion_Click(object sender, EventArgs e)
        {
            var fromDate = DateTime.Today.AddDays(-7);
            var toDate = DateTime.Now;
            tabla(fromDate, toDate);
        }

        private void btnOcupacionHoy_Click(object sender, EventArgs e)
        {
            var fromDate = DateTime.Today;
            var toDate = DateTime.Now;
            tabla(fromDate, toDate);
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
    }
}
