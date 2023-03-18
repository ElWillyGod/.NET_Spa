using System;
using System.Windows.Forms;
using Logica;
namespace Spa
{
    public partial class frmModificacionEmpleado : Form
    { 
        //Declaraciones
        //#############################################################################################
        public static string txtID;
        Panel xd;
        string b ="";
        int cedula;

        //#############################################################################################

        //botones etc.
        //#############################################################################################
        public frmModificacionEmpleado(Panel a, string TipoUsuario, int ci)
        {
            cedula = ci;
            InitializeComponent();
            xd = a;
            b = TipoUsuario;
            
            txtCedula.Text =""+cedula;
            //if (Logica.Cliente.cargarDatosClienteExistente(txtCedula, txtNombre, txtApellido, txtCorreo, txtTelefono, txtDireccion, checkJubilado, checkTurista))
            //{
            //   txtAPagar.Text=""+ Logica.Cliente.getTotalAPagar(cedula);
            //}
        }
        private void frmModificacionCliente_Load(object sender, EventArgs e)
        {
            Logica.Usuarios.cargarDatosUsuarioExistente(txtCedula, txtNombre, txtApellido, txtCorreo, txtTelefono, txtDireccion);
            cbRol.Text = Logica.Usuarios.getUserType(cedula);
        }

        private void BtnIniciarSesion_Click(object sender, EventArgs e)
        {
            
          
            
        }
        private void TxtCedula_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void TxtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void TxtAPagar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void MenuTop_MouseDown(object sender, MouseEventArgs e)
        {
            logica.move(Handle, e);
        }
        private bool validar()
        {
            try {
                int nro = 0;
                if (txtCedula.Text != string.Empty)
                    nro = Int32.Parse(txtCedula.Text);
            }
            catch (Exception f)
            {
                frmNegativo ff = new frmNegativo("documento no valido");
                ff.ShowDialog();
                Console.WriteLine(f.Message);
                return false;
            }
            try
            {
                int nro = 0;
                if (txtTelefono.Text != string.Empty)
                    nro = Int32.Parse(txtTelefono.Text);
            }
            catch (Exception f)
            {
                frmNegativo ff = new frmNegativo("telefono no valido");
                ff.ShowDialog();
                Console.WriteLine(f.Message);
                return false;
            }

            if (!Logica.logica.validarCampoVacio(txtCedula.Text))
            {
                frmNegativo ff = new frmNegativo("El campo del documento no puede estar vacio");
                ff.ShowDialog();
                return false;
            }

            else if (!Logica.logica.validarCampoVacio(txtNombre.Text))
            {
                frmNegativo ff = new frmNegativo("El campo del Nombre no puede estar vacio");
                ff.ShowDialog();
                return false;
            }
            else if (!Logica.logica.validar50CaracteresMax(txtNombre.Text))
            {
                frmNegativo ff = new frmNegativo("El nombre no puede contener más de 50 caracteres");
                ff.ShowDialog();
                return false;
            }
            else if (!Logica.logica.validarCampoVacio(txtApellido.Text))
            {
                frmNegativo ff = new frmNegativo("El campo del Apellido no puede estar vacio");
                ff.ShowDialog();
                return false;
            }
            else if (!Logica.logica.validar50CaracteresMax(txtApellido.Text))
            {
                frmNegativo ff = new frmNegativo("El Apellido no puede contener más de 50 caracteres");
                ff.ShowDialog();
                return false;
            }
            else if (!Logica.logica.validarCampoVacio(txtCorreo.Text))
            {
                frmNegativo ff = new frmNegativo("El campo del Correo no puede estar vacio");
                ff.ShowDialog();
                return false;
            }
            else if (!Logica.logica.validar50CaracteresMax(txtCorreo.Text))
            {
                frmNegativo ff = new frmNegativo("El Correo no puede contener más de 50 caracteres");
                ff.ShowDialog();
                return false;
            }
            else if (!Logica.logica.validarEmail(txtCorreo.Text))
            {
                frmNegativo ff = new frmNegativo("El Correo Tiene un formato incorrecto");
                ff.ShowDialog();
                return false;
            }
            else if (!Logica.logica.validarCampoVacio(txtTelefono.Text))
            {
                frmNegativo ff = new frmNegativo("El campo del Telefono no puede estar vacio");
                ff.ShowDialog();
                return false;
            }
            else if (!Logica.logica.validar50CaracteresMax(txtTelefono.Text))
            {
                frmNegativo ff = new frmNegativo("El Telefono no puede contener más de 50 caracteres");
                ff.ShowDialog();
                return false;
            }
            else if (!Logica.logica.validarCampoVacio(txtDireccion.Text))
            {
                frmNegativo ff = new frmNegativo("El campo de la dirección no puede estar vacio");
                ff.ShowDialog();
                return false;
            }
            else if (!Logica.logica.validar50CaracteresMax(txtDireccion.Text))
            {
                frmNegativo ff = new frmNegativo("la dirección no puede contener más de 50 caracteres");
                ff.ShowDialog();
                return false;
            }
            else
            {
                    return true;
            }




        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (validar())
            {


                if (Logica.Usuarios.modificarEmpleado(cedula, Int32.Parse(txtCedula.Text), txtNombre.Text, txtApellido.Text, txtCorreo.Text, txtTelefono.Text,
                  txtDireccion.Text, cbRol.Text))
                {
                    frmPositivo dou = new frmPositivo("Empleado modificado correctamente");
                    dou.ShowDialog();

                    cedula = Int32.Parse(txtCedula.Text);

                }
            }
        }
    private void txtCedula_KeyPress_1(object sender, KeyPressEventArgs e)
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

        private void txtTelefono_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            logica.ValidarSoloNumeros(e);

        }

        //#############################################################################################
    }
}
