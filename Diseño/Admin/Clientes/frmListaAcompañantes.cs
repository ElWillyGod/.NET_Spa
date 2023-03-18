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
    public partial class frmListaAcompañantes : Form
    {
        string Fecha;
        int CI = 0;
        string b = "";
        public frmListaAcompañantes(string fecha,int ci,string tipoUsuario)
        {
            b = tipoUsuario;
            Fecha = fecha;
            CI = ci;
            InitializeComponent();
            if(b=="Admin")
            {
                   MenuTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
                   dgvAcompañantes.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
                   dgvAcompañantes.ColumnHeadersDefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            }
            acompañantes.CargarAcompañantes(dgvAcompañantes,fecha,ci);
            eliminar.DisplayIndex = 7;
        }

        private void MenuTop_MouseDown(object sender, MouseEventArgs e)
        {
            logica.move(Handle, e);
        }

        private void frmListaAcompañantes_Load(object sender, EventArgs e)
        {

        }

        private void dgvAcompañantes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvAcompañantes.Columns["eliminar"].Index)
            {
                DataGridViewRow row = dgvAcompañantes.Rows[e.RowIndex];
                acompañantes.BajaAcompañante(CI,Int32.Parse(row.Cells["CI"].Value.ToString()),Fecha);
                acompañantes.CargarAcompañantes(dgvAcompañantes, Fecha, CI);

            }
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "Excel Workbook|*.xlsx" })
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        using (XLWorkbook workbook = new XLWorkbook())
                        {
                            workbook.AddWorksheet(acompañantes.GetAcompañantes("xd", CI), "Acompañantes de " + CI);
                            workbook.SaveAs(sfd.FileName);
                        }
                        frmPositivo xd = new frmPositivo("documento exportado a Excel correctamente");
                        xd.ShowDialog();
                    }
                    catch (Exception f)
                    {
                        frmNegativo chau = new frmNegativo(f.Message);
                        ShowDialog();
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
                    logica.ExportToPdf(acompañantes.GetAcompañantes("xd", CI), sfd.FileName,"Lista de acompañantes\n de Cliente");
                    frmPositivo xd = new frmPositivo("documento exportado a PDF correctamente");
                    xd.ShowDialog();
                }
            }
            
        }
    }
}
