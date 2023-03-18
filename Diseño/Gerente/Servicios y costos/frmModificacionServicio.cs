using System;
using System.Windows.Forms;
using Logica;
namespace Spa
{
    public partial class frmmodificacionServicio : Form
    {
        string xd = "";
        public frmmodificacionServicio(string servicio)
        {
            xd = servicio;
            InitializeComponent();
            txtCapacidad.Text = "" + Servicio.getCapacidadMaxima(servicio);
            txtPermanencia.Text = "" + Servicio.getPermanencia(servicio);
            txtCupos.Text = "" + Servicio.getCupos(servicio);
            txtCosto.Text = "" + Servicio.verificiarPrecio(servicio);
            cbHabilitado.Checked = Servicio.GetHabilitado(servicio);
        }

        private bool validar()
        {
            try
            {
                int hola = 0;
                if (txtCapacidad.Text != string.Empty)
                    hola = Int32.Parse(txtCapacidad.Text);
            }
            catch (Exception)
            {
                frmNegativo negativo = new frmNegativo("la capacidad diaria ingresada no es valida");
                negativo.ShowDialog();
                return false;

            }
            try
            {
                int hola = 0;
                if (txtPermanencia.Text != string.Empty)
                    hola = Int32.Parse(txtPermanencia.Text);
            }
            catch (Exception)
            {
                frmNegativo negativo = new frmNegativo("la permanencia ingresada no es valida");
                negativo.ShowDialog();
                return false;

            }
            try
            {
                int hola = 0;
                if (txtCupos.Text != string.Empty)
                    hola = Int32.Parse(txtCupos.Text);
            }
            catch (Exception)
            {
                frmNegativo negativo = new frmNegativo("el numero de cupos ingresado no es valido");
                negativo.ShowDialog();
                return false;

            }
            try
            {
                int hola = 0;
                if (txtCosto.Text != string.Empty)
                    hola = Int32.Parse(txtCosto.Text);
            }
            catch (Exception)
            {
                frmNegativo negativo = new frmNegativo("El costo ingresado no es valido");
                negativo.ShowDialog();
                return false;

            }
            if (!Logica.logica.validarCampoVacio(txtCapacidad.Text))
            {
                frmNegativo xd = new frmNegativo("Ingrese una capacidad diaria");
                xd.ShowDialog();
                return false;

            }
            else if (!Logica.logica.validarCampoVacio(txtPermanencia.Text))
            {
                frmNegativo xd = new frmNegativo("Ingrese una permanecia");
                xd.ShowDialog();
                return false;

            }
            else if (!Logica.logica.validarCampoVacio(txtCupos.Text))
            {
                frmNegativo xd = new frmNegativo("Ingrese una cantidad de cupos por hora");
                xd.ShowDialog();
                return false;

            }
            else if (!Logica.logica.validarCampoVacio(txtCosto.Text))
            {
                frmNegativo xd = new frmNegativo("Ingrese un costo");
                xd.ShowDialog();
                return false;
            }
            else
            {
                return true;
            }
        }
        private void Generatelogs()
        {
            if (txtCapacidad.Text != ("" + Servicio.getCapacidadMaxima(xd)))
            {
                Servicio.logServicio(logica.UsuarioActual, xd, "Capacidad Modificada de "+Servicio.getCapacidadMaxima(xd)+" A " + txtCapacidad.Text);
            }
            if (txtPermanencia.Text != ("" + Servicio.getPermanencia(xd)))
            {
                Servicio.logServicio(logica.UsuarioActual, xd, "Permanencia Modificada de " + Servicio.getPermanencia(xd) + " A " + txtPermanencia.Text);
            }
            if (txtCupos.Text != ("" + Servicio.getCupos(xd)))
            {
                Servicio.logServicio(logica.UsuarioActual, xd, "Cupos Modificados de " + Servicio.getCupos(xd) + " A " + txtCupos.Text);
            }
            if (txtCosto.Text != ("" + Servicio.verificiarPrecio(xd)))
            {
                Servicio.logServicio(logica.UsuarioActual, xd, "Costo Modificado de " + Servicio.verificiarPrecio(xd) + " A " + txtCosto.Text);
            }
            if (cbHabilitado.Checked != (Servicio.GetHabilitado(xd)))
            {
                Servicio.logServicio(logica.UsuarioActual, xd, "Habilitado de " + Servicio.GetHabilitado(xd) + " A " + cbHabilitado.Checked);
            }
        }
        private void Modificar()
        {

            if (cbHabilitado.Checked)
            {
                Generatelogs();
                Servicio.ModificarServicio(Int32.Parse(txtCapacidad.Text), Int32.Parse(txtPermanencia.Text), Int32.Parse(txtCupos.Text), Int32.Parse(txtCosto.Text), 1, xd);
                DialogResult = DialogResult.OK;
            }
            else
            {
                Generatelogs();
                Servicio.ModificarServicio(Int32.Parse(txtCapacidad.Text), Int32.Parse(txtPermanencia.Text), Int32.Parse(txtCupos.Text), Int32.Parse(txtCosto.Text), 0, xd);
                DialogResult = DialogResult.OK;
            }
        }
        private void bfbtnAgregar_Click(object sender, EventArgs e)
        {
            if(validar())
                Modificar();
        }
        private void txtCapacidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            Logica.logica.ValidarNumerosYGuion(e);
        }
        private void txtPermanencia_KeyPress(object sender, KeyPressEventArgs e)
        {
            Logica.logica.ValidarSoloNumeros(e);
        }
        private void txtCupos_KeyPress(object sender, KeyPressEventArgs e)
        {
            Logica.logica.ValidarNumerosYGuion(e);
        }
        private void txtCosto_KeyPress(object sender, KeyPressEventArgs e)
        {
            Logica.logica.ValidarSoloNumeros(e);
        }



        private void MenuTop_MouseDown(object sender, MouseEventArgs e)
        {
            logica.move(Handle, e);
        }

        private void frmmodificacionServicio_Load(object sender, EventArgs e)
        {

        }
    }
}
