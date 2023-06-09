﻿using System;
using System.Collections;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Logica;

namespace Spa
{
    public partial class frmReservaCliente2 : Form
    {
        static string fecha1;
        Panel xd;
        static string b;
        static int cedula=0;
        int total = 0;
        int x = 0;
        bool yaExiste = false;
        int cantidadPersonas = 1;
        int costoEntradas = 0;
        public frmReservaCliente2(Panel btnes,string tipoUsuario)
        {
            InitializeComponent();
            if(tipoUsuario== "Admin")
            {
                btnAcompañantes.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(255)))));
                btnAcompañantes.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(255)))));
                btnAcompañantes.OnPressedState.BorderColor =System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
                btnAcompañantes.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
                btnCancelar.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(255)))));
                btnCancelar.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
                btnCancelar.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
                btnContinuar.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(255)))));
                btnContinuar.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
                btnContinuar.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
                btnContinuar.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
                btnContinuar.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(255)))));
                btnContinuar.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
                btnContinuar.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
                btnContinuar.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
                btnReservar.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(255)))));
                btnReservar.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
                btnReservar.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
                btnReservar.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
                btnReservar.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(255)))));
                btnReservar.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
                btnReservar.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
                btnReservar.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
                txtCedula.BorderColorActive = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
                txtCedula.OnActiveState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
                txtNombre.BorderColorActive = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
                txtNombre.OnActiveState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
                txtApellido.BorderColorActive = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
                txtApellido.OnActiveState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
                txtCorreo.BorderColorActive = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
                txtCorreo.OnActiveState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
                txtTelefono.BorderColorActive = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
                txtTelefono.OnActiveState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
                txtDireccion.BorderColorActive = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
                txtDireccion.OnActiveState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
                txtSeña.BorderColorActive = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
                txtSeña.OnActiveState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
                SwitchConfirmado.ToggleStateOn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
                SwitchConfirmado.ToggleStateOn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
                //SwitchCorreoRecibo.ToggleStateOn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
                //SwitchCorreoRecibo.ToggleStateOn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
                switchTicket.ToggleStateOn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
                switchTicket.ToggleStateOn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            }
            lblCostoTotal.Text = String.Format("COSTO TOTAL: {0:C2}", total);
            dtpFecha.MinDate = DateTime.Today;
            dtpFecha.MaxDate = DateTime.Today.AddMonths(6);
         
            Entrada.MostrarEntradas(cbEntradas);
            b = tipoUsuario;
            xd = btnes;
            acompañantes.lista.Clear();
            if (acompañantes.lista.Columns.Count == 0)
            {
                acompañantes.lista.Columns.Add("CI");
                acompañantes.lista.Columns.Add("Nombre");
                acompañantes.lista.Columns.Add("Apellido");
                acompañantes.lista.Columns.Add("Correo");
                acompañantes.lista.Columns.Add("Telefono");
                acompañantes.lista.Columns.Add("Dirección");
                acompañantes.lista.Columns.Add("Entrada");
            }
            Reservas.reservas.Clear();
            if (Reservas.reservas.Columns.Count == 0)
            {
                Reservas.reservas.Columns.Add("CI");
                Reservas.reservas.Columns.Add("Servicio");
                Reservas.reservas.Columns.Add("Fecha");
                Reservas.reservas.Columns.Add("Hora");
                Reservas.reservas.Columns.Add("Costo");
            }
        }
        private bool validar()
        {
            try
            {
                int hola = Int32.Parse(txtCedula.Text);
            }
            catch (Exception)
            {
                frmNegativo negativo = new frmNegativo("El documento ingresado no es valido");
                negativo.ShowDialog();
                return false;
            }
            try
            {
                int hola = Int32.Parse(txtTelefono.Text);
            }
            catch (Exception)
            {
                frmNegativo negativo = new frmNegativo("El telefono ingresado no es valido");
                negativo.ShowDialog();
                return false;
            }

            if (!logica.validarCampoVacio(txtCedula.Text))
            {
                frmNegativo negativo = new frmNegativo("El campo Cedula no puede estar vacio");
                negativo.ShowDialog();
                return false;
            }
            else if (!logica.validarCampoVacio(txtNombre.Text))
            {
                frmNegativo negativo = new frmNegativo("El campo Nombre no puede estar vacio");
                negativo.ShowDialog();
                return false;
            }
            else if (!logica.validarCampoVacio(txtApellido.Text))
            {
                frmNegativo negativo = new frmNegativo("El campo Apellido no puede estar vacio");
                negativo.ShowDialog();
                return false;
            }
            else if (!logica.validarCampoVacio(txtCorreo.Text))
            {
                frmNegativo negativo = new frmNegativo("El campo Correo no puede estar vacio");
                negativo.ShowDialog();
                return false;
            }
            else if (!logica.validarEmail(txtCorreo.Text))
            {
                frmNegativo negativo = new frmNegativo("El Correo ingresado tiene un formato incorrecto");
                negativo.ShowDialog();
                return false;
            }
            else if (!logica.validarCampoVacio(txtTelefono.Text))
            {
                frmNegativo negativo = new frmNegativo("El campo Telefono no puede estar vacio");
                negativo.ShowDialog();
                return false;
            }
            else if (!logica.validarCampoVacio(txtDireccion.Text))
            {
                frmNegativo negativo = new frmNegativo("El campo Dirección no puede estar vacio");
                negativo.ShowDialog();
                return false;
            }
            else
            {
                return true;
            }
        }
        private void reset()
        {
            txtCedula.Enabled = true;
            txtCedula.Text = "";
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtCorreo.Text = "";
            txtTelefono.Text = "";
            txtDireccion.Text = "";
            cbEntradas.Text = "Entrada Estandar";
            cbMetodo.Text= "Contado";
            txtSeña.Text = "";
            dtpFecha.Text = DateTime.Today.ToString();
            Logica.logica.precioTotal = 0;
            total = 0;
            xd.Enabled = true;
            cedula = 0;
            lblCostoTotal.Text = String.Format("COSTO TOTAL: {0:C2}", total);
            Logica.logica.PagoTraslado = false;
            btnCancelar.Enabled = false;
            dgvReserva.Rows.Clear();
            if (Convert.ToDateTime(Logica.Spa.gethoraCierre()) <= Convert.ToDateTime(DateTime.Now.ToString("HH:mm:ss")))
            {
                dtpFecha.MinDate = DateTime.Today.AddDays(1);
                dtpFecha.Text = dtpFecha.MinDate.ToString();
            }
            switchTicket.Checked = true;
            SwitchConfirmado.Checked = false;
            //SwitchCorreoRecibo.Checked = false;
            foreach (Control c in pnlContenedor.Controls)
            {
                if (pnlContenedor.GetColumn(c) <= 1 && pnlContenedor.GetRow(c) <= 10 && pnlContenedor.GetRow(c) > 0)
                    c.Enabled = true;
            }
            acompañantes.lista.Rows.Clear();
            Reservas.reservas.Rows.Clear();
        }
        private void btnAcompañantes_Click(object sender, EventArgs e)
        {
            frmOtros acom = new frmOtros(b,txtCedula.Text);
            if (acom.ShowDialog() == DialogResult.OK)
            {
            }
        }
        private void bfbtnCancelar_Click(object sender, EventArgs e)
        {
            reset();
        }
        private void btnContinuar_Click(object sender, EventArgs e)
        {
            if (Logica.Cliente.cargarDatosClienteExistente(txtCedula, txtNombre, txtApellido, txtCorreo, txtTelefono, txtDireccion, cbEntradas) && txtCedula.Enabled)
            {
                frmSiNo dou = new frmSiNo("Cargar datos del cliente?");
                if (dou.ShowDialog() == DialogResult.OK)
                {
                    txtCedula.Enabled = false;
                }
            }
            else
            {
                if (validar()) {
                    xd.Enabled = false;
                    cantidadPersonas += acompañantes.lista.Rows.Count;
                   
                    fecha1 = dtpFecha.Value.ToString("yyyy-MM-dd");
                    cedula = Int32.Parse(txtCedula.Text);
                    foreach (string s in Logica.Servicio.getServicios())
                    {
                        if (s != "Traslado Ida" || s != "Traslado Vuelta")
                            dgvReserva.Rows.Add(s,"$" + Logica.Servicio.verificiarPrecio(s), "Click");

                    }
                    if(Reserva.GetIdReserva(fecha1,cedula)==-1)
                    {
                        costoEntradas = Entrada.getPrecioEntrada(cbEntradas.Text);
                        foreach (DataRow dr in acompañantes.lista.Rows)
                        {
                            costoEntradas += Entrada.getPrecioEntrada(dr["Entrada"].ToString());
                        }
                        total = costoEntradas;
                    }
                    lblCostoTotal.Text = String.Format("COSTO TOTAL: {0:C2}", total);
                    foreach (Control c in pnlContenedor.Controls)
                    {
                        if (pnlContenedor.GetColumn(c) <= 1 && pnlContenedor.GetRow(c) <= 10 && pnlContenedor.GetRow(c) > 0)
                            c.Enabled = false;
                        if (pnlContenedor.GetColumn(c) > 1 || pnlContenedor.GetRow(c) >= 9)
                            c.Visible = true;
                    }
                    btnCancelar.Enabled = true;
                }
               
            }
        }
        private void txtCedula_KeyPress(object sender, KeyPressEventArgs e)
        {
            logica.ValidarSoloNumeros(e);
        }
        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            logica.ValidarSoloLetras(e);
        }
        private void txtApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            logica.ValidarSoloLetras(e);
        }
        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            logica.ValidarSoloNumeros(e);
        }
        private void dgvReserva_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ArrayList horas = new ArrayList();
            try
            {
                DataGridViewRow Row = this.dgvReserva.Rows[e.RowIndex];
                x = e.RowIndex;

                if (e.ColumnIndex == dgvReserva.Columns["btnDgv"].Index && Row.Cells["Servicio"].Value.ToString() != "")
                {
                    Logica.Fecha.agregarHoras(Row.Cells["Servicio"].Value.ToString(), fecha1);
                    Logica.capacidadfecha.agregarCapacidad(Row.Cells["Servicio"].Value.ToString(), fecha1);
                    frmReservaHorarios dou = new frmReservaHorarios(Int32.Parse(txtCedula.Text),txtNombre.Text,txtApellido.Text,dtpFecha.Value, Row.Cells["Servicio"].Value.ToString(),b);

                    if (dou.ShowDialog() == DialogResult.OK)
                    {
                        total = 0;
                        foreach(DataRow dr in Reservas.reservas.Rows)
                        {
                            total += Int32.Parse(dr["Costo"].ToString());
                        }
                        total += costoEntradas;
                        lblCostoTotal.Text = String.Format("COSTO TOTAL: {0:C2}", total);
                    }
                }
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }
        }
        private void btnReservar_Click(object sender, EventArgs e)
        {
            if (txtSeña.Text == "")
            { txtSeña.Text = "0"; }
            if (Logica.Reservas.reservas.Rows.Count == 0)
            {
                frmNegativo chau = new frmNegativo("Debe reservar servicios.");
                if (chau.ShowDialog() == DialogResult.OK)
                {
                }
            }
            else
            {

                try {
                    if (Int32.Parse(txtSeña.Text) >= total)
                        SwitchConfirmado.Checked = true;
                }
                catch (Exception) {
                    txtSeña.Text = ""+total;
                }
                
                if (!Logica.Cliente.CheckClienteExiste(Convert.ToInt32(txtCedula.Text)))
                {
                    Logica.Cliente.ReservarCliente(cedula, txtNombre.Text, txtApellido.Text, txtCorreo.Text, txtTelefono.Text, txtDireccion.Text, cbEntradas.Text, 0);
                    Cliente.logCliente(logica.UsuarioActual,cedula,"Cliente registrado");
                }

                foreach (DataRow dr in acompañantes.lista.Rows)
                {
                    if (!Logica.Cliente.CheckClienteExiste(Convert.ToInt32(dr["CI"].ToString())))
                    {
                        Logica.Cliente.ReservarCliente(Int32.Parse(dr["CI"].ToString()),
                            dr["Nombre"].ToString(), dr["Apellido"].ToString(), dr["Correo"].ToString(), dr["Telefono"].ToString(), dr["Dirección"].ToString(), dr["Entrada"].ToString(),
                            0);
                        Cliente.logCliente(logica.UsuarioActual, Int32.Parse(dr["CI"].ToString()), "Cliente registrado");
                    }
                    acompañantes.agregarAcompañante(Convert.ToInt32(txtCedula.Text), Int32.Parse(dr["CI"].ToString()), dtpFecha.Value.ToString("yyyy-MM-dd"));

                }
                if (!Logica.Cliente.CheckReservaExiste(Convert.ToInt32(txtCedula.Text), dtpFecha.Value.ToString("yyyy-MM-dd")))
                {

                    if (SwitchConfirmado.Checked)
                    {
                        Logica.Reserva.ReservarServicio(dtpFecha.Value.ToString("yyyy-MM-dd"), cedula, 1, 0, total, cbMetodo.Text);
                        Reserva.logReserva(logica.UsuarioActual, Reserva.GetIdReserva(dtpFecha.Value.ToString("yyyy-MM-dd"), cedula),"Reserva creada");
                    }
                    else
                    {
                        int suma = total - Int32.Parse(txtSeña.Text);
                        if (suma < 0)
                            suma = 0;
                        Logica.Reserva.ReservarServicio(dtpFecha.Value.ToString("yyyy-MM-dd"), cedula, 0, suma, total, cbMetodo.Text);
                        Logica.Cliente.ModificarTotalAPagar(Convert.ToInt32(txtCedula.Text), suma);
                    }

                }
                else
                {
                    if (!SwitchConfirmado.Checked)
                    {
                        Reserva.sumarTotal(Reserva.GetIdReserva(dtpFecha.Value.ToString("yyyy-MM-dd"), cedula), total);
                        Reserva.SumarAPagar(Reserva.GetIdReserva(dtpFecha.Value.ToString("yyyy-MM-dd"), cedula), total);
                        Reserva.borrarConfirmacion(Reserva.GetIdReserva(dtpFecha.Value.ToString("yyyy-MM-dd"), cedula), Int32.Parse(txtSeña.Text));
                        if (!Logica.Cliente.CheckClienteExiste(Convert.ToInt32(txtCedula.Text)))
                        {
                            int suma = total - Int32.Parse(txtSeña.Text);
                            if (suma < 0)
                                suma = 0;
                            Logica.Cliente.ModificarTotalAPagar(Convert.ToInt32(txtCedula.Text), suma);
                        }

                    }
                    else
                    {
                        Reserva.sumarTotal(Reserva.GetIdReserva(dtpFecha.Value.ToString("yyyy-MM-dd"), cedula), total);
                    }



                    yaExiste = true;
                }
                if (logica.checkIda2())
                {
                    if (logica.checkVuelta2())
                    {
                        if (Logica.logica.reservarServiciosv2(Reserva.GetIdReserva(dtpFecha.Value.ToString("yyyy-MM-dd"), cedula), fecha1))
                        {
                            Reserva.SumarTotalAPagarCliente(cedula);
                            if (switchTicket.Checked)
                            {
                                
                                logica.ImprimirTicket(ImprimirTicket);
                            }
                            frmPositivo dou = new frmPositivo("reserva realizada correctamente");
                            dou.ShowDialog();
                            reset();
                        }
                    }
                    else
                    {
                        frmPositivo dou = new frmPositivo("F Vuelta");
                        dou.ShowDialog();
                    }

                }
                else
                {
                    frmPositivo dou = new frmPositivo("F ida");
                    dou.ShowDialog();
                }
            }
        }
        private void ImprimirTicket_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            logica.InformacionImprimir(e, Reserva.GetIdReserva(dtpFecha.Value.ToString("yyyy-MM-dd"), cedula),
                cbMetodo.Text,txtNombre.Text,txtApellido.Text,Int32.Parse(txtCedula.Text), dtpFecha.Value.ToString("dd/MM/yyyy"), dgvReserva,total,cbEntradas.Text,yaExiste,Int32.Parse(txtSeña.Text));
            

        }
        private void SwitchConfirmado_CheckedChanged(object sender, Bunifu.UI.WinForms.BunifuToggleSwitch.CheckedChangedEventArgs e)
        {
            if (SwitchConfirmado.Checked)
            {
                txtSeña.Enabled = false;
                txtSeña.Text = ""+total;
            }
                
            else
                txtSeña.Enabled = true;
        }
        private void txtSeña_KeyPress(object sender, KeyPressEventArgs e)
        {
            logica.ValidarSoloNumeros(e);
        }

        private void previewTicket_Load(object sender, EventArgs e)
        {

        }
    }
}
