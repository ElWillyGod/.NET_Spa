using System;
using System.Windows.Forms;
using Logica;
namespace Spa
{
    public partial class frmAltaServicio : Form
    {
        public frmAltaServicio()
        {
            InitializeComponent();
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
            if (!Logica.logica.validarCampoVacio(txtNombre.Text))
            {
                frmNegativo xd = new frmNegativo("Ingrese el nombre del servicio");
                xd.ShowDialog();
                return false;

            }
            else if (!Logica.logica.validarCampoVacio(txtCapacidad.Text))
            {
                frmNegativo xd = new frmNegativo("Ingrese una capacidad diaria");
                xd.ShowDialog();
                return false;

            }
            else if (Int32.Parse(txtCapacidad.Text)<-1 || txtCapacidad.Text=="0")
            {
                frmNegativo xd = new frmNegativo("Ingrese una capacidad diaria valida");
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
            else if (Int32.Parse(txtCupos.Text) < -1 || txtCupos.Text == "0")
            {
                frmNegativo xd = new frmNegativo("Ingrese una cantidad de cupos valida");
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

        private void agregar() {
            
                Logica.Servicio.altaServicio(txtNombre.Text, Int32.Parse(txtCapacidad.Text), Int32.Parse(txtPermanencia.Text), Int32.Parse(txtCupos.Text), Int32.Parse(txtCosto.Text));
            Servicio.logServicio(logica.UsuarioActual,txtNombre.Text,"Servicio creado");
                DialogResult = DialogResult.OK;
            
        }
        private void bfbtnAgregar_Click(object sender, EventArgs e)
        {
            if(validar())
                agregar();
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

        private void frmAltaServicio_Load(object sender, EventArgs e)
        {

        }

        private void MenuTop_MouseDown(object sender, MouseEventArgs e)
        {
            logica.move(Handle, e);
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            logica.ValidarSoloLetras(e);
        }
    }
}
