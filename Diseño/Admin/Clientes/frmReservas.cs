using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClosedXML.Excel;
using Logica;
namespace Spa
{
    public partial class frmReservas : Form
    {
        int ci=0;
        string b = "";
        public frmReservas(int cedula,string tipoUsuario)
        {
            InitializeComponent();
            ci = cedula;
            b = tipoUsuario;
            if(b=="Admin")
            {
                MenuTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
                dgvReservas.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
                dgvReservas.ColumnHeadersDefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            }
           
            Reserva.CargarReservaCliente(dgvReservas, ci);
            DataGridViewButtonColumn servicioColumna = new DataGridViewButtonColumn();
            servicioColumna.Name = "Servicios";
            servicioColumna.Text = "Mostrar";
            servicioColumna.HeaderText = "Servicios";
            servicioColumna.UseColumnTextForButtonValue = true;
            int columnIndex = 3;
            if (dgvReservas.Columns["Servicios"] == null)
            {
                if (dgvReservas.Columns.Count != 0)
                {
                    dgvReservas.Columns.Insert(columnIndex, servicioColumna);

                }

            }
            DataGridViewButtonColumn AcompañantesColumna = new DataGridViewButtonColumn();
            AcompañantesColumna.Name = "Acompañantes";
            AcompañantesColumna.Text = "Mostrar";
            AcompañantesColumna.HeaderText = "Acompañantes";
            AcompañantesColumna.UseColumnTextForButtonValue = true;
            columnIndex = 4;
            if (dgvReservas.Columns["Acompañantes"] == null)
            {
                if (dgvReservas.Columns.Count != 0)
                {
                    dgvReservas.Columns.Insert(columnIndex, AcompañantesColumna);

                }

            }
            editar.DisplayIndex = 10;
            eliminar.DisplayIndex = 10;
        }

        private void frmReservas_Load(object sender, EventArgs e)
        {
            
        }

        private void dgvReservas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == dgvReservas.Columns["Servicios"].Index)
                {
                    DataGridViewRow row = dgvReservas.Rows[e.RowIndex];
                    frmModificarServiciosCliente xd = new frmModificarServiciosCliente(b, Int32.Parse(row.Cells["idReserva"].Value.ToString()));
                    if (xd.ShowDialog() == DialogResult.OK)
                    {
                        Reserva.CargarReservaCliente(dgvReservas, ci);
                        if(dgvReservas.Rows.Count==0)
                        {
                            this.DialogResult = DialogResult.OK;
                        }
                    }
                }
                if (e.ColumnIndex == dgvReservas.Columns["Acompañantes"].Index)
                {

                    DataGridViewRow row = dgvReservas.Rows[e.RowIndex];
                    DateTime dt = Convert.ToDateTime(row.Cells["Fecha"].Value.ToString());
                    frmListaAcompañantes xd = new frmListaAcompañantes(dt.ToString("yyyy-MM-dd"),ci,b);
                    if (xd.ShowDialog() == DialogResult.OK)
                    {

                    }
                }
                if (e.ColumnIndex == dgvReservas.Columns["editar"].Index)
                {
                    DataGridViewRow row = dgvReservas.Rows[e.RowIndex];
                    frmModificacionTotalAPagar xd = new frmModificacionTotalAPagar(Int32.Parse(row.Cells["idReserva"].Value.ToString()),b);
                    if (xd.ShowDialog() == DialogResult.OK)
                    {
                        Reserva.CargarReservaCliente(dgvReservas, ci);

                    }
                }
                if (e.ColumnIndex == dgvReservas.Columns["eliminar"].Index)
                {
                    DataGridViewRow row = dgvReservas.Rows[e.RowIndex];
                    Logica.Reserva.BorrarReservaCompleta(Int32.Parse(row.Cells["idReserva"].Value.ToString()),row.Cells["Fecha"].Value.ToString());
                    Reserva.logReserva(logica.UsuarioActual, Int32.Parse(row.Cells["idReserva"].Value.ToString()),"Reserva eliminada");
                        Reserva.SumarTotalAPagarCliente(ci);
                        Reserva.CargarReservaCliente(dgvReservas, ci);
                }
            }
            catch (ArgumentOutOfRangeException)
            {
            
            }
        }

        private void MenuTop_MouseDown(object sender, MouseEventArgs e)
        {
            logica.move(Handle, e);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            using(SaveFileDialog sfd = new SaveFileDialog() { Filter="Excel Workbook|*.xlsx"})
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        using (XLWorkbook workbook = new XLWorkbook())
                        {
                            workbook.AddWorksheet(Reserva.GetReservas(ci), "Reservas de " + ci);
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

        private void btnExportarPdf_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "PDF|*.pdf" })
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    logica.ExportToPdf(Reserva.GetReservas(ci), sfd.FileName,"Reservas de cliente");
                    frmPositivo xd = new frmPositivo("documento exportado a PDF correctamente");
                    xd.ShowDialog();
                }
            }
            
        }
    }
}
