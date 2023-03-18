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
    public partial class frmCapacidadesYCupos : Form
    {
        public frmCapacidadesYCupos(string tipo)
        {
            InitializeComponent();
            dtpFechaCapacidades.Value = DateTime.Today;
            dtpFechaCupos.Value = DateTime.Today;
            Logica.capacidadfecha.MostrarTablaCapacidades(dgvCapacidades, dtpFechaCapacidades.Value);
            Logica.Servicio.CargarServiciosComboBox(cbServicio);
            cbServicio.SelectedIndex = 0;
            Logica.Fecha.MostrarTablaCupos(dgvCupos,dtpFechaCupos.Value,cbServicio.SelectedItem.ToString());
            
                if (tipo == "Gerente")
                {
                    dgvCapacidades.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));
                    dgvCupos.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));
                    btnBuscarCapacidad.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));
                    btnBuscarCapacidad.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));
                    btnBuscarCapacidad.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));
                    btnBuscarCapacidad.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));
                    btnBuscarCapacidad.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));
                    btnBuscarCapacidad.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));
                    btnBuscarCapacidad.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));
                    btnBuscarCapacidad.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));

                    btnBuscarCupos.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));
                    btnBuscarCupos.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));
                    btnBuscarCupos.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));
                    btnBuscarCupos.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));
                    btnBuscarCupos.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));
                    btnBuscarCupos.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));
                    btnBuscarCupos.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));
                    btnBuscarCupos.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));
                }
        }

        private void frmCapacidadesYCupos_Load(object sender, EventArgs e)
        {

        }

        private void btnBuscarCapacidad_Click(object sender, EventArgs e)
        {
            Logica.capacidadfecha.MostrarTablaCapacidades(dgvCapacidades, dtpFechaCapacidades.Value);
        }

        private void btnBuscarCupos_Click(object sender, EventArgs e)
        {
            Logica.Fecha.MostrarTablaCupos(dgvCupos, dtpFechaCupos.Value, cbServicio.SelectedItem.ToString());
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
                            workbook.AddWorksheet(Logica.capacidadfecha.MostrarTablaCapacidadesDT(dtpFechaCapacidades.Value), "dou");
                            workbook.SaveAs(sfd.FileName);
                        }
                        frmPositivo xd = new frmPositivo("documento exportado a Excel correctamente");
                        xd.ShowDialog();
                    }
                    catch (Exception f)
                    {
                        frmNegativo chau = new frmNegativo(f.Message);
                        if (chau.ShowDialog() == DialogResult.OK)
                        {
                        }
                    }
                }

            }
        }

        private void btnExportarCuposPDF_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "PDF|*.pdf" })
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    Logica.logica.ExportToPdf(Logica.Fecha.MostrarTablaCuposDT(dtpFechaCupos.Value, cbServicio.SelectedItem.ToString()), sfd.FileName, "Cupos");
                    frmPositivo xd = new frmPositivo("documento exportado a PDF correctamente");
                    xd.ShowDialog();
                }
            }
            
        }

        private void btnExportarCuposExcel_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "Excel Workbook|*.xlsx" })
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        using (XLWorkbook workbook = new XLWorkbook())
                        {
                            workbook.AddWorksheet(Logica.Fecha.MostrarTablaCuposDT(dtpFechaCupos.Value,cbServicio.SelectedItem.ToString()), "dou");
                            workbook.SaveAs(sfd.FileName);
                        }
                        frmPositivo xd = new frmPositivo("documento exportado a Excel correctamente");
                        xd.ShowDialog();
                    }
                    catch (Exception f)
                    {
                        frmNegativo chau = new frmNegativo(f.Message);
                        if (chau.ShowDialog() == DialogResult.OK)
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
                    Logica.logica.ExportToPdf(Logica.capacidadfecha.MostrarTablaCapacidadesDT(dtpFechaCapacidades.Value), sfd.FileName, "Cupos");
                    frmPositivo xd = new frmPositivo("documento exportado a PDF correctamente");
                    xd.ShowDialog();
                }
            }
        }
    }
}
