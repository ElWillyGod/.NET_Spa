using ClosedXML.Excel;
using Logica;
using System;
using System.Data;
using System.Windows.Forms;

namespace Spa
{
    public partial class frmModificarServiciosCliente : Form
    {
        //Declaraciones
        //#############################################################################################
        static string Servicios = "";
        int x;
        string hora;
        string b;
        string CI;
        string Servicio;
        string Fecha;
        string Hora;
        int Precio;
        int nro;
        string cliente = "";
        string ida = "";
        string vuelta = "";
        //#############################################################################################
        public frmModificarServiciosCliente(string tipoUsuario, int Nro)
        {
            nro = Nro;
            b = tipoUsuario;
            InitializeComponent();
            if (tipoUsuario == "Gerente")
            {
                btnMostrarDisponibilidad.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));
                btnMostrarDisponibilidad.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));
                btnMostrarDisponibilidad.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));
                btnMostrarDisponibilidad.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));
                btnMostrarDisponibilidad.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));
                btnMostrarDisponibilidad.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));
                btnMostrarDisponibilidad.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));
                btnMostrarDisponibilidad.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));

                btnCambiarFechaHora.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));
                btnCambiarFechaHora.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));
                btnCambiarFechaHora.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));
                btnCambiarFechaHora.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));
                btnCambiarFechaHora.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));
                btnCambiarFechaHora.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));
                btnCambiarFechaHora.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));
                btnCambiarFechaHora.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));

                btnBorrarReserva.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));
                btnBorrarReserva.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));
                btnBorrarReserva.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));
                btnBorrarReserva.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));
                btnBorrarReserva.onHoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));
                btnBorrarReserva.OnIdleState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));
                btnBorrarReserva.OnPressedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));
                btnBorrarReserva.ForeColor= System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));


                MenuTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));
                dgvServicios.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));
            }
            

        }
        //Metodos
        //#############################################################################################

        public static void desactivarCombobox(ComboBox a)
        {
            a.Enabled = false;
            a.Text = "";
        }
        public static bool verificarHoraRetorno(string horaIda, string fecha, string servicio)
        {
            DateTime hora1 = DateTime.MinValue;
            DateTime hora2 = DateTime.MaxValue;
            if (horaIda != "" || horaIda != null)
                hora1 = Convert.ToDateTime(horaIda);


            foreach (DataRow dr in Logica.logica.ServiciosClientes.Rows)
            {
                if (dr["Servicio"].ToString() == "Traslado Vuelta" && dr["Fecha"].ToString() == fecha)
                {
                    hora2 = Convert.ToDateTime(dr["Hora"]);
                    break;
                }
            }
            if (hora1 >= hora2 && servicio != "Traslado Vuelta")
                return true;
            else
                return false;
        }
        //#############################################################################################
        //Botones
        //#############################################################################################
        private void frmModificarServiciosCliente_Load(object sender, EventArgs e)
        {
            Logica.Reservas.cargarServiciosCliente(dgvServicios, nro);
            dgvServicios.ColumnHeadersHeight = 60;


            
            if (dgvServicios.Rows.Count == 0)
            {
                frmNegativo chau = new frmNegativo("No hay servicios registrados para este cliente");
                if (chau.ShowDialog() == DialogResult.OK)
                {
                    this.Close();
                }              
            }
        }
        private void dgvServicios_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            try
            {
                cboxHoras.Text = "";
                cboxHoras.Enabled = false;
                DataGridViewRow row = this.dgvServicios.Rows[e.RowIndex];
                x = e.RowIndex;
                if (row.Cells["CI"].Value.ToString() != "")
                {
                    CI = row.Cells["CI"].Value.ToString();
                    Servicio = row.Cells["Servicio"].Value.ToString();
                    DateTime fecha = Convert.ToDateTime(row.Cells["Fecha"].Value.ToString());
                    Fecha = fecha.ToString("yyyy-MM-dd");
                    Console.WriteLine(Fecha);
                    Precio = Int32.Parse(row.Cells["Costo"].Value.ToString());
                    Console.WriteLine(Precio);
                    Hora = row.Cells["Hora"].Value.ToString();
                    Console.WriteLine(Hora);
                    lblServicio.Text = row.Cells["Servicio"].Value.ToString();
                    Console.WriteLine(lblServicio.Text);
                    //panelHoras.Enabled = true;                  

                }

            }
            catch (System.ArgumentOutOfRangeException) { }
        }
        private void btnMostrarDisponibilidad_Click(object sender, EventArgs e)
        {

        }
        private void btnCambiarFechaHora_Click(object sender, EventArgs e)
        {
            DateTime horaIda = DateTime.MinValue;
            DateTime horaVuelta = DateTime.MaxValue;
            hora = cboxHoras.GetItemText(cboxHoras.SelectedItem);
            try
            {
                Console.WriteLine("1");
                DataGridViewRow row = dgvServicios.Rows[x];
                if (hora != "")
                {
                    if (hora != row.Cells["Hora"].Value.ToString() && row.Cells["Servicio"].Value.ToString() == Servicio)
                    {
                        Console.WriteLine("3");
                        Logica.Fecha.ModificarCupos(Fecha, row.Cells["Hora"].Value.ToString(), Servicio, true);
                        Logica.Fecha.ModificarCupos(Fecha, hora, Servicio, false);
                        Logica.Reservas.cambiarHoraReserva(Reserva.GetIdReserva(Fecha, Int32.Parse(CI)), row.Cells["Hora"].Value.ToString(), hora);
                        frmPositivo dou = new frmPositivo("Servicio modificado correctamente");
                        dou.ShowDialog();
                        Logica.Reservas.cargarServiciosCliente(dgvServicios, nro);

                    }
                }
            }
            catch (System.ArgumentOutOfRangeException) { }
        }
        private void dtpFecha_ValueChanged(object sender, EventArgs e)
        {
            cboxHoras.Text = "";
            cboxHoras.Enabled = false;
        }
        private void btnBorrarReserva_Click(object sender, EventArgs e)
        {
           

        }
        private void MenuTop_MouseDown(object sender, MouseEventArgs e)
        {
            logica.move(Handle, e);
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
                            workbook.AddWorksheet(Reservas.GetServiciosCliente(nro), "dou " + nro);
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

        private void btnExportarPdf_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "PDF|*.pdf" })
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    logica.ExportToPdf(Reservas.GetServiciosCliente(nro), sfd.FileName,"Servicios Reservados");
                    frmPositivo xd = new frmPositivo("documento exportado a PDF correctamente");
                    xd.ShowDialog();
                }
            }
            
        }

        private void btnMostrarDisponibilidad_Click_1(object sender, EventArgs e)
        {
            try {
                for (int i = 0; i < dgvServicios.Rows.Count; i++)
                {

                    if (dgvServicios.Rows[i].Cells["Servicio"].Value.ToString() == "Traslado Ida")
                    {
                        ida = dgvServicios.Rows[i].Cells["Hora"].Value.ToString();
                    }
                    if (dgvServicios.Rows[i].Cells["Servicio"].Value.ToString() == "Traslado Vuelta")
                    {
                        vuelta = dgvServicios.Rows[i].Cells["Hora"].Value.ToString();
                    }
                }
                Servicios = lblServicio.Text;
                cboxHoras.Items.Clear();
                cboxHoras.Enabled = true;
                Logica.Fecha.agregarHoras(Servicios, Fecha);
                Logica.capacidadfecha.agregarCapacidad(Servicios, Fecha);
                Logica.Fecha.CargarHoras(cboxHoras, Servicios, Fecha, Logica.logica.horasNoDisponibles(dgvServicios), Logica.logica.horasNoDisponibles2(dgvServicios), ida, vuelta, Int32.Parse(CI), Reserva.GetIdReserva(Fecha, Int32.Parse(CI)));
            } catch (Exception)
            {

            }
            
        }

        private void btnCambiarFechaHora_Click_1(object sender, EventArgs e)
        {
            DateTime horaIda = DateTime.MinValue;
            DateTime horaVuelta = DateTime.MaxValue;
            hora = cboxHoras.GetItemText(cboxHoras.SelectedItem);
            try
            {
                Console.WriteLine("1");
                DataGridViewRow row = dgvServicios.Rows[x];
                if (hora != "")
                {
                    if (hora != row.Cells["Hora"].Value.ToString() && row.Cells["Servicio"].Value.ToString() == Servicio)
                    {
                        Console.WriteLine("3");
                        Logica.Fecha.ModificarCupos(Fecha, row.Cells["Hora"].Value.ToString(), Servicio, true);
                        Logica.Fecha.ModificarCupos(Fecha, hora, Servicio, false);
                        Reservas.LogReservarServicio(logica.UsuarioActual, Reserva.GetIdReserva(Fecha, Int32.Parse(CI)), row.Cells["Hora"].Value.ToString(),Int32.Parse(cliente),"Hora modificada a: "+hora);
                        Logica.Reservas.cambiarHoraReserva(Reserva.GetIdReserva(Fecha, Int32.Parse(CI)), row.Cells["Hora"].Value.ToString(), hora);
                        frmPositivo dou = new frmPositivo("Servicio modificado correctamente");
                        dou.ShowDialog();
                        Logica.Reservas.cargarServiciosCliente(dgvServicios, nro);

                    }
                }
            }
            catch (Exception f)
            {
                frmNegativo chau = new frmNegativo(f.Message);
                if (chau.ShowDialog() == DialogResult.OK)
                {
                }
            }


            //#############################################################################################
        }

        private void btnBorrarReserva_Click_1(object sender, EventArgs e)
        {
            if(lblServicio.Text != "Servicio")
            {
                for (int i = 0; i < dgvServicios.Rows.Count; i++)
                {

                    if (dgvServicios.Rows[i].Cells["Servicio"].Value.ToString() == "Traslado Ida")
                    {
                        ida = dgvServicios.Rows[i].Cells["Hora"].Value.ToString();
                    }
                    if (dgvServicios.Rows[i].Cells["Servicio"].Value.ToString() == "Traslado Vuelta")
                    {
                        vuelta = dgvServicios.Rows[i].Cells["Hora"].Value.ToString();
                    }
                }
                if (Hora != "")
                {
                    frmSiNo chau = new frmSiNo("Estas seguro que quieres borrar este servicio?");
                    if (chau.ShowDialog() == DialogResult.OK)
                    {
                        Reservas.LogReservarServicio(logica.UsuarioActual, Logica.Reserva.GetIdReserva(Fecha, Int32.Parse(CI)), Hora, Int32.Parse(cliente), "Hora dada de baja");
                        if (Logica.Reservas.bajaServicioCliente(Logica.Reserva.GetIdReserva(Fecha, Int32.Parse(CI)), Hora))
                        {
                            if ((Servicio != "Traslado Ida" && Servicio != "Traslado Vuelta") || (ida != "" ^ vuelta != ""))
                            {
                                Logica.Cliente.quitarPrecioServicio(Int32.Parse(CI), Precio);
                            }
                            Logica.Fecha.modificarCapacidad(Servicio, Fecha, true);
                            Logica.Fecha.ModificarCupos(Fecha, Hora, Servicio, true);
                            Reserva.BorrarDelCostoTotalXCantidad(nro, Precio);
                            Reserva.BorrarDeAPagarXCantidad(nro, Precio);
                            Reserva.SumarTotalAPagarCliente(Int32.Parse(CI));
                            Logica.Reservas.cargarServiciosCliente(dgvServicios, nro);
                            if (dgvServicios.Rows.Count == 0)
                            {
                                Reserva.BorrarSoloReserva(nro);
                                Reserva.SumarTotalAPagarCliente(Int32.Parse(CI));
                                this.DialogResult = DialogResult.OK;
                            }
                        }

                        Hora = "";
                    }
                }
            }
           
        }

        private void dgvServicios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dgvServicios.Rows[e.RowIndex];
             cliente = row.Cells["Cliente"].Value.ToString();
                MessageBox.Show(cliente);
            
        }
    }
}
