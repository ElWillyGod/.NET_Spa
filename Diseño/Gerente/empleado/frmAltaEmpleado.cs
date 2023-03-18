using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Logica;

namespace Spa
{
    public partial class frmAltaEmpleado : Form
    {
        public frmAltaEmpleado()
        {
            InitializeComponent();
        }
       
        private bool validaciones()
        {
            if(txtCedula.Text == string.Empty)
            {

                frmNegativo no = new frmNegativo("No se ha ingresado ninguna cedula");
                no.ShowDialog();
                return false;
            }
            else if (txtNombre.Text == string.Empty)
            {
                frmNegativo no = new frmNegativo("No se ha ingresado ningun Nombre");
                no.ShowDialog();
                return false;
            }
            else if (txtApellido.Text == string.Empty)
            {
                frmNegativo no = new frmNegativo("No se ha ingresado ningun Apellido");
                no.ShowDialog();
                return false;
            }
            else if (cbCargos.Text == null || cbCargos.Text == string.Empty)
            {
                frmNegativo no = new frmNegativo("No se ha ingresado ningun Cargo");
                no.ShowDialog();    
                return false;
            }
            else if (txtTelefono.Text == string.Empty)
            {
                frmNegativo no = new frmNegativo("No se ha ingresado ningun telefono");
                no.ShowDialog();
                return false;
            }
            else if (txtDireccion.Text == string.Empty)
            {
                frmNegativo no = new frmNegativo("No se ha ingresado ninguna direccion");
                no.ShowDialog();
                return false;
            }
            else if (txtCorreo.Text == string.Empty)
            {
                frmNegativo no = new frmNegativo("No se ha ingresado ningun correo");
                no.ShowDialog();
                return false;
            }
            else if (!logica.validarEmail(txtCorreo.Text))
            {
                frmNegativo no = new frmNegativo("El correo introducido no es valido");
                no.ShowDialog();
                return false;
            }
            else
            {
                return true;
            }

        }
        private void bfbtnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog buscar = new OpenFileDialog();
                buscar.Filter = "Image Files(*.jpg;*.jpeg;*.gif;) | *.jpg;*.jpeg;*.gif;";
                if (buscar.ShowDialog() == DialogResult.OK)
                {
                    bpbFoto.Image = new Bitmap(buscar.FileName);
                    bpbFoto.BackgroundImage = Image.FromFile(buscar.FileName);
                    bpbFoto.ImageLocation = buscar.FileName;
                    bpbFoto.SizeMode = PictureBoxSizeMode.Zoom;
                }
            }
            catch (Exception)
            {

            }
    }

        private void MenuTop_MouseDown(object sender, MouseEventArgs e)
        {
            logica.move(Handle, e);
        }

     

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try {
                FileStream fs;
                BinaryReader br;
                byte[] ImageData;

                fs = new FileStream(bpbFoto.ImageLocation, FileMode.Open, FileAccess.Read);
                br = new BinaryReader(fs);
                ImageData = br.ReadBytes((int)fs.Length);
                br.Close();
                fs.Close();
            if (validaciones()) {

                
                int ci = Int32.Parse(txtCedula.Text);
                int telefono = Int32.Parse(txtTelefono.Text);
                string pass = logica.passGenerator(7);
                
                
                    if(Usuarios.altaEmpleado(ci, txtNombre.Text, txtApellido.Text, txtCorreo.Text, telefono, txtDireccion.Text, cbCargos.Text, pass, ImageData))
                    {
                        frmPositivo hola = new frmPositivo("Contraseña generada: " + pass);
                        hola.ShowDialog();
                        this.DialogResult = DialogResult.OK;
                    }
                    else
                    {
                        frmNegativo hola = new frmNegativo("Ese empleado ya esta registrado");
                        hola.ShowDialog();
                    }
                    
            }
            }
            catch (Exception) {
                frmNegativo hola = new frmNegativo("Ingrese una foto");
                hola.ShowDialog();
            }

        }

        private void txtCedula_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtSueldo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
