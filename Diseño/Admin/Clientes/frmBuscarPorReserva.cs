using ClosedXML.Excel;
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
    public partial class frmBuscarPorReserva : Form
    {
        public frmBuscarPorReserva(string tipo)
        {
            InitializeComponent();
            Logica.logica.CargarHorarioDelSpa(cbHora);
            if(tipo =="Admin")
            {
                btnBuscar.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
                btnBuscar.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
                btnBuscar.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(255)))));
                btnBuscar.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
                btnBuscar.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
                btnBuscar.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(255)))));
                btnBuscar.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
                btnBuscar.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
                MenuTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
                dgvClientesPorHora.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
                dgvClientesPorHora.ColumnHeadersDefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            }
            dtpFecha.Value = DateTime.Today;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if(cbHora.Text!=string.Empty) {
                Logica.Reservas.CargarReservasPorHoraYFecha(dgvClientesPorHora, dtpFecha.Value, cbHora.Text);
            }
            
        }

        private void MenuTop_MouseDown(object sender, MouseEventArgs e)
        {
            Logica.logica.move(Handle, e);
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
                            workbook.AddWorksheet(Logica.Reservas.CargarReservasPorHoraYFechaDT(dtpFecha.Value,cbHora.Text), "Reservas ");
                            workbook.SaveAs(sfd.FileName);

                        }
                        frmPositivo xd = new frmPositivo("documento exportado a Excel correctamente");
                        xd.ShowDialog();
                    }
                    catch (Exception f)
                    {
                        frmNegativo xd = new frmNegativo(f.Message);
                        xd.ShowDialog();
                    }
                }

            }
        }

        private void frmBuscarPorReserva_Load(object sender, EventArgs e)
        {

        }

        private void btnExportarCapacidadesPDF_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "PDF|*.pdf" })
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    Logica.logica.ExportToPdf(Logica.Reservas.CargarReservasPorHoraYFechaDT(dtpFecha.Value, cbHora.Text), sfd.FileName, "Reservas de cliente");
                    frmPositivo xd = new frmPositivo("documento exportado a PDF correctamente");
                    xd.ShowDialog();
                }
            }
           
        }
    }
}
