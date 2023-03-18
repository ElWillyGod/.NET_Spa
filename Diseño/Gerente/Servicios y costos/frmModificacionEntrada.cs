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
    public partial class frmModificacionEntrada : Form
    {
        string xd = "";
        public frmModificacionEntrada(string entrada)
        {
            xd = entrada;
            InitializeComponent();
            txtNombre.Text = entrada;
            txtCosto.Text = "" + Logica.Entrada.getPrecioEntrada(entrada);
            cbHabilitado.Checked = Logica.Entrada.GetHabilitadaEntrada(entrada);
        }
        private void Generatelogs()
        {
            if (txtNombre.Text != xd)
            {
                Logica.Entrada.logsEntrada(Logica.logica.UsuarioActual,xd,"Nombre modificado de: "+ xd+" A "+ txtNombre.Text);
            }
            if (txtCosto.Text != ("" + Logica.Entrada.getPrecioEntrada(xd)))
            {
                Logica.Entrada.logsEntrada(Logica.logica.UsuarioActual, xd, "Costo modificado de: " + Logica.Entrada.getPrecioEntrada(xd) + " A " + txtCosto.Text);
            }
            if (cbHabilitado.Checked != Logica.Entrada.GetHabilitadaEntrada(xd))
            {
                Logica.Entrada.logsEntrada(Logica.logica.UsuarioActual, xd, "Habilitado modificado de: " + Logica.Entrada.GetHabilitadaEntrada(xd) + " A " + cbHabilitado.Checked);
            }
            
        }
        private bool validar()
        {
            try
            {
                int hola = 0;
                if (txtCosto.Text != string.Empty)
                    hola = Int32.Parse(txtCosto.Text);
            }
            catch (Exception)
            {
                frmNegativo no = new frmNegativo("El costo no es valido");
                no.ShowDialog();
                return false;
            }

            if (!Logica.logica.validarCampoVacio(txtNombre.Text))
            {
                frmNegativo negativo = new frmNegativo("El campo del nombre del servicio no puede estar vacio.");
                negativo.ShowDialog();
                return false;

            }
            else if (!Logica.logica.validarCampoVacio(txtCosto.Text))
            {
                frmNegativo negativo = new frmNegativo("El campo del costo no puede estar vacio.");
                negativo.ShowDialog();
                return false;
            }
            else
            {
                return true;
            }

        }

        private void bfbtnAgregar_Click(object sender, EventArgs e)
        {
            if (validar())
            {
                Generatelogs();
                if (cbHabilitado.Checked)
                    Logica.Entrada.modificarEntrada(txtNombre.Text, Int32.Parse(txtCosto.Text), 1, xd);
                   
                else 
                    Logica.Entrada.modificarEntrada(txtNombre.Text, Int32.Parse(txtCosto.Text), 0, xd); 
                DialogResult = DialogResult.OK;
            }
        }

        private void frmModificacionEntrada_Load(object sender, EventArgs e)
        {

        }

        private void MenuTop_MouseDown(object sender, MouseEventArgs e)
        {
            Logica.logica.move(Handle,e);
        }
    }
}
