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
    public partial class frmReservaHorarios : Form
    {
        private string serv="";
        private string date = "";
        public frmReservaHorarios(int ci,string nombre,string apellido,DateTime fecha,string servicio,string tipo)
        {
            serv = servicio;
            date = fecha.ToString("yyyy-MM-dd");
            InitializeComponent();
            ColumnaHoras.Items.AddRange(Logica.Fecha.CargarHoras2(servicio, fecha.ToString("yyyy-MM-dd")).ToArray());
        if(tipo == "Admin")
            {
                btnReservarCupos.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(255)))));
                btnReservarCupos.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
                btnReservarCupos.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
                dgvHorarios.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(255)))));
                dgvHorarios.ColumnHeadersDefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(255)))));
            }

            
            dgvHorarios.Rows.Add(ci.ToString(),(nombre+" "+ apellido));
            foreach(DataRow dr in Logica.acompañantes.lista.Rows)
            {

                dgvHorarios.Rows.Add(dr["CI"].ToString(), (dr["Nombre"].ToString() + " " + dr["Apellido"].ToString()));
            }
            foreach (DataRow dr in Logica.Reservas.reservas.Rows)
            {
                for (int rows = 0; rows < dgvHorarios.Rows.Count; rows++)
                {

                    if (dr["CI"].ToString()== dgvHorarios.Rows[rows].Cells[0].Value.ToString() && dr["Servicio"].ToString() == serv && dr["Fecha"].ToString() == date)
                    {
                        dgvHorarios.Rows[rows].Cells[2].Value = dr["Hora"];
                    }
                }
            }
        }    
        private bool validarCupos()
        {
           
            DataTable xd = new DataTable("xd");
            xd.Columns.Add("Hora");
            xd.Columns.Add("Personas");
            for (int rows = 0; rows < dgvHorarios.Rows.Count; rows++)
            {
                if (dgvHorarios.Rows[rows].Cells[2].Value != null)
                {
                    if (xd.Rows.Count > 0) {
                        foreach (DataRow dr in xd.Rows)
                        {
                            if (dr["Hora"].ToString() == dgvHorarios.Rows[rows].Cells[2].Value.ToString())
                            {

                                int x = Int32.Parse(dr["Personas"].ToString()) + 1;
                                dr["Personas"] = x;
                                break;
                            }
                            else
                            {
                               
                            }
                            //int cupos = Logica.Fecha.getCuposHora(serv, date, dgvHorarios.Rows[rows].Cells[2].Value.ToString());
                        }
                    }
                    else
                    {
                        xd.Rows.Add(dgvHorarios.Rows[rows].Cells[2].Value.ToString(), 1);
                    }
                    
                }
            }
            foreach(DataRow dr in xd.Rows)
            {
                int cupos = Logica.Fecha.getCuposHora(serv, date, dr["Hora"].ToString());
                if (cupos < Int32.Parse(dr["personas"].ToString()) && cupos!=-1)
                {
                    frmNegativo f = new frmNegativo("No hay suficientes cupos para la hora " + dr["Hora"].ToString());
                    f.ShowDialog();
                    return false;
                }
            }
            return true;

        }
        private bool validarCapacidad()
        {
            int x = 0;
            for (int rows = 0; rows < dgvHorarios.Rows.Count; rows++)
            {
                if (dgvHorarios.Rows[rows].Cells[2].Value != null)
                {
                    x++;
                }
            }
            if (Logica.capacidadfecha.GetCapacidadFecha(serv, date) >= x || Logica.capacidadfecha.GetCapacidadFecha(serv, date) == -1)
                return true;
            else
            {
                frmNegativo f = new frmNegativo("Cupos diarios superados");
                f.ShowDialog();
                return false;
            }
        }
        private bool validarHorasDisponiblesDT()
        {

            for (int rows = 0; rows < dgvHorarios.Rows.Count; rows++)
            {
                foreach (DataRow dr in Logica.Reservas.reservas.Rows)
                {
                    if (dgvHorarios.Rows[rows].Cells[2].Value != null) {
                        DateTime hora1 = Convert.ToDateTime(dgvHorarios.Rows[rows].Cells[2].Value.ToString());
                        DateTime hora2 = Convert.ToDateTime(dr["Hora"].ToString());
                        DateTime hora3 = Convert.ToDateTime(dr["Hora"].ToString()).AddMinutes(Logica.Servicio.getPermanencia(dr["Servicio"].ToString()));
                        if (dr["CI"].ToString() == dgvHorarios.Rows[rows].Cells[0].Value.ToString() && dr["Fecha"].ToString() == date && (hora1>=hora2 && hora1<hora3))
                        {
                            if (dr["Servicio"].ToString() != serv)
                            {
                                frmNegativo f = new frmNegativo(dr["Servicio"].ToString() + " fue reservado a esa fecha y hora para " + dgvHorarios.Rows[rows].Cells[0].Value.ToString());
                                f.ShowDialog();
                            }
                            else
                            {
                                return true;
                            }
                            return false;
                        }
                    }
                }

            }
            return true;
        }
        private bool validarHorasDisponiblesBD()
        {
            DataTable xd = Logica.Reservas.CargarHorasNoDisponiblesBD(date);
            for (int rows = 0; rows < dgvHorarios.Rows.Count; rows++)
            {
                foreach (DataRow dr in xd.Rows)
                {
                    if (dgvHorarios.Rows[rows].Cells[2].Value != null)
                    {
                        DateTime hora1 = Convert.ToDateTime(dgvHorarios.Rows[rows].Cells[2].Value.ToString());
                        DateTime hora2 = Convert.ToDateTime(dr["Hora"].ToString());
                        DateTime hora3 = Convert.ToDateTime(dr["Hora"].ToString()).AddMinutes(Logica.Servicio.getPermanencia(dr["Servicio"].ToString()));
                        if (dr["Cliente"].ToString() == dgvHorarios.Rows[rows].Cells[0].Value.ToString() && (hora1 >= hora2 && hora1 < hora3))
                        {
                            if (dr["Servicio"].ToString() != serv)
                            {
                                frmNegativo f = new frmNegativo(dr["Servicio"].ToString() + " fue reservado a esa fecha y hora para " + dgvHorarios.Rows[rows].Cells[0].Value.ToString());
                                f.ShowDialog();
                            }
                            else
                            {
                                return true;
                            }
                            return false;
                        }
                    }
                }

            }
            return true;
        }
        private void reservar() {
            for (int rows = 0; rows < dgvHorarios.Rows.Count; rows++)
            {
                bool agregar = true;
                if (Logica.Reservas.reservas.Rows.Count > 0)
                {
                    foreach (DataRow dr in Logica.Reservas.reservas.Rows)
                    {
                        if (dr["CI"].ToString() == dgvHorarios.Rows[rows].Cells[0].Value.ToString() && dr["Servicio"].ToString() == serv && dr["Fecha"].ToString() == date)
                        {
                            agregar = false;
                            if (dgvHorarios.Rows[rows].Cells[2].Value != null && dr["Hora"] != dgvHorarios.Rows[rows].Cells[2].Value)
                            {
                                dr["Hora"] = dgvHorarios.Rows[rows].Cells[2].Value;
                            }
                        }
                    }
                    if (agregar)
                    {
                        if (dgvHorarios.Rows[rows].Cells[2].Value != null && dgvHorarios.Rows[rows].Cells[2].Value.ToString() != string.Empty)
                        {
                            if (serv == "Traslado Ida" || serv == "Traslado Vuelta") {

                                if(Logica.logica.checkTrasladoPago(Int32.Parse(dgvHorarios.Rows[rows].Cells[0].Value.ToString())))
                                {
                                    Logica.Reservas.reservas.Rows.Add(dgvHorarios.Rows[rows].Cells[0].Value.ToString(), serv, date, dgvHorarios.Rows[rows].Cells[2].Value.ToString(),0);
                                }
                            }
                            else
                            {
                                Logica.Reservas.reservas.Rows.Add(dgvHorarios.Rows[rows].Cells[0].Value.ToString(), serv, date, dgvHorarios.Rows[rows].Cells[2].Value.ToString(), Logica.Servicio.verificiarPrecio(serv));
                            }
                        }
                    }
                }
                else
                {
                    if (dgvHorarios.Rows[rows].Cells[2].Value != null && dgvHorarios.Rows[rows].Cells[2].Value.ToString() != string.Empty)
                    {
                        Logica.Reservas.reservas.Rows.Add(dgvHorarios.Rows[rows].Cells[0].Value.ToString(), serv, date, dgvHorarios.Rows[rows].Cells[2].Value.ToString(), Logica.Servicio.verificiarPrecio(serv));
                        Logica.Reservas.reservas.AcceptChanges();
                    }
                }
            }
        }


        private void btnReservarCupos_Click(object sender, EventArgs e)
        {
            if (validarHorasDisponiblesDT() && validarCupos() && validarCapacidad() && validarHorasDisponiblesBD())
            {
                reservar();
                DialogResult = DialogResult.OK;
            }
                
        }

        private void dgvHorarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow Row = dgvHorarios.Rows[e.RowIndex];
            if (e.ColumnIndex == dgvHorarios.Columns["ColumnaBorrar"].Index && Row.Cells["ColumnaHoras"].Value.ToString() != "")
            {
                Row.Cells["ColumnaHoras"].Value = "";
                foreach(DataRow dr in Logica.Reservas.reservas.Rows)
                {                
                        if (dr["CI"].ToString() == dgvHorarios.Rows[e.RowIndex].Cells[0].Value.ToString() && dr["Servicio"].ToString() == serv && dr["Fecha"].ToString() == date)
                        {
                        dr.Delete();
                            Logica.Reservas.reservas.AcceptChanges();
                            break;
                        }
                    
                }
                
            }
        }

        private void frmReservaHorarios_Load(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {

        }
    }
}
