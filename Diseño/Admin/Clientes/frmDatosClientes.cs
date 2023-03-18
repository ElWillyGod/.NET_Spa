using System;
using System.Windows.Forms;

namespace Spa
{
    public partial class frmDatosClientes : Form
    { 
        //Declaraciones
        //#############################################################################################
        public static string txtID;
        string b;
        Panel xd;
        //#############################################################################################
        public frmDatosClientes(Panel a, string TipoUsuario)
        {
            InitializeComponent();
            xd = a;
            b = TipoUsuario;
            if (TipoUsuario == "Admin")
            {
                btnBuscar.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
                btnBuscar.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
                btnBuscar.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(255)))));
                btnBuscar.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
                btnBuscar.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
                btnBuscar.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(255)))));
                btnBuscar.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
                btnBuscar.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
                txtBuscador.BorderColorActive = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(255)))));
                txtBuscador.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));

                
                btnBuscarPorReserva.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
                btnBuscarPorReserva.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
                btnBuscarPorReserva.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(255)))));
                btnBuscarPorReserva.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
                btnBuscarPorReserva.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
                btnBuscarPorReserva.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(255)))));
                btnBuscarPorReserva.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
                btnBuscarPorReserva.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
                
                txtBuscador.OnActiveState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
                txtBuscador.OnHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(255)))));
                dgvCliente.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
                dgvCliente.ColumnHeadersDefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));


            }
            else
            {
                dgvCliente.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));
            }
        }    
        //etc.
        //#############################################################################################
        private void frmDatosClientes_Load(object sender, EventArgs e)
        {
            Logica.Cliente.CargarClientes(dgvCliente);
            DataGridViewButtonColumn servicioColumna = new DataGridViewButtonColumn();
            servicioColumna.Name = "Reservas";
            servicioColumna.Text = "Mostrar";
            servicioColumna.HeaderText = "Reservas";
            servicioColumna.UseColumnTextForButtonValue = true;
            int columnIndex = 6;
            if (dgvCliente.Columns["Reservas"] == null)
            {
                if(dgvCliente.Columns.Count != 0)
                {
                    dgvCliente.Columns.Insert(columnIndex, servicioColumna);

                }
                
            }
            eliminar.DisplayIndex = 10;
            editar.DisplayIndex = 9;

        }    
        private void dgvCliente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == dgvCliente.Columns["Reservas"].Index)
                {

                    DataGridViewRow row = dgvCliente.Rows[e.RowIndex];
                    txtID = row.Cells[1].Value.ToString();

                    string cedula = row.Cells["CI"].Value.ToString();
                    frmReservas dou = new frmReservas(Int32.Parse(cedula),b);
                    if (dou.ShowDialog() == DialogResult.OK)
                    {

                        Logica.Reserva.SumarTotalAPagarCliente(Int32.Parse(cedula));
                        Logica.Cliente.CargarClientes(dgvCliente);
                    }
                }
                else if (e.ColumnIndex == dgvCliente.Columns["editar"].Index)
                {
                    DataGridViewRow row = dgvCliente.Rows[e.RowIndex];
                    txtID = row.Cells[1].Value.ToString();
                    string cedula = row.Cells["CI"].Value.ToString();
                    frmModificacionCliente dou = new frmModificacionCliente(xd, b, Int32.Parse(cedula));
                    if (dou.ShowDialog() == DialogResult.OK)
                    {
                        Logica.Cliente.CargarClientes(dgvCliente);
                    }
                }
                else if (e.ColumnIndex == dgvCliente.Columns["eliminar"].Index)
                {
                    DataGridViewRow row = dgvCliente.Rows[e.RowIndex];
                    txtID = row.Cells[1].Value.ToString();
                    string cedula = row.Cells["CI"].Value.ToString();

                    frmSiNo chau = new frmSiNo("Estas seguro que quieres dar de baja a este cliente?");
                    if (chau.ShowDialog() == DialogResult.OK)
                    {
                        Logica.Cliente.logCliente(Logica.logica.UsuarioActual,Int32.Parse(cedula),"Cliente eliminado");
                        Logica.Reserva.borrarTodasReservasCliente(Int32.Parse(cedula));
                        Logica.Cliente.CargarClientes(dgvCliente);
                    }
                    
                }
               
                
            }
            catch(ArgumentOutOfRangeException)
            {
                
            }
           
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Logica.Cliente.BuscarCliente(dgvCliente, txtBuscador.Text);
        }

        private void txtBuscador_TextChanged(object sender, EventArgs e)
        {
            if(txtBuscador.Text == string.Empty){
                Logica.Cliente.CargarClientes(dgvCliente);
            }
        }

        private void btnBuscarReserva_Click(object sender, EventArgs e)
        {
            frmBuscarPorReserva xd = new frmBuscarPorReserva(b);
            xd.ShowDialog();
        }

        private void btnBuscarPorReserva_Click(object sender, EventArgs e)
        {
            Logica.Cliente.BuscarClientePorIdReserva(dgvCliente, txtBuscador.Text);
        }


        //#############################################################################################
    }
}
  
