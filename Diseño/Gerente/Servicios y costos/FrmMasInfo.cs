using ClosedXML.Excel;
using Logica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Spa
{
    public partial class FrmMasInfo : Form
    {
        string xdf="";
        public FrmMasInfo(string servicio)
        {
            xdf = servicio;
            InitializeComponent();
            Logica.Reservas.CargarClientesPorServicioYFecha(dgvClientesPorHora, DateTime.Today.ToString("yyyy-MM-dd"), servicio);
            dtpFechaCapacidades.Value = DateTime.Today;
        }

        private void FrmMasInfo_Load(object sender, EventArgs e)
        {
            
        }

        private void MenuTop_MouseDown(object sender, MouseEventArgs e)
        {
            Logica.logica.move(Handle, e);
        }

        private void btnBuscarCapacidad_Click(object sender, EventArgs e)
        {
            Logica.Reservas.CargarClientesPorServicioYFecha(dgvClientesPorHora, dtpFechaCapacidades.Value.ToString("yyyy-MM-dd"), xdf);
        }

        private void btnExportarCapacidadesExcel_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "Excel Workbook|*.xlsx" })
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        using (XLWorkbook workbook = new XLWorkbook())
                        {
                            workbook.AddWorksheet(Reservas.CargarClientesPorServicioYFechaDT(dtpFechaCapacidades.Value.ToString("yyyy-MM-dd"),xdf), "asd");
                            workbook.SaveAs(sfd.FileName);
                        }
                        frmPositivo xd = new frmPositivo("documento exportado a Excel correctamente");
                        xd.ShowDialog();
                    }
                    catch (Exception f)
                    {
                        frmSiNo xd = new frmSiNo(f.Message);
                        if (xd.ShowDialog() == DialogResult.OK)
                        {
                          
                        }
                    }
                }

            }
        }

        private void btnExportarCapacidadesPDF_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "PDF|*.pdf" })
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    logica.ExportToPdf(Reservas.CargarClientesPorServicioYFechaDT(dtpFechaCapacidades.Value.ToString("yyyy-MM-dd"),xdf), sfd.FileName, "Cantidad Clientes");
                    frmPositivo xd = new frmPositivo("documento exportado a PDF correctamente");
                    xd.ShowDialog();
                }
            }
            
        }
    }
}
