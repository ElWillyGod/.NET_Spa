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
    public partial class frmAltaEntrada : Form
    {
        public frmAltaEntrada()
        {
            InitializeComponent();
        }

        private void pnlModificar_Paint(object sender, PaintEventArgs e)
        {

        }

        private bool validar()
        {
            try
            {
                int hola = 0;
                if (txtCosto.Text != string.Empty)
                    hola = Int32.Parse(txtCosto.Text);
            }catch(Exception)
            {
                frmNegativo no = new frmNegativo("El costo no es valido");
                no.ShowDialog();
                return false;
            }
            if(!Logica.logica.validarCampoVacio(txtNombre.Text))
            {
                frmNegativo no = new frmNegativo("El campo del nombre no puede estar vacio");
                no.ShowDialog();
                return false;
            }
            if (!Logica.logica.validarCampoVacio(txtCosto.Text))
            {
                frmNegativo no = new frmNegativo("El campo del costo no puede estar vacio");
                no.ShowDialog();
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
                Logica.Entrada.AltaEntrada(txtNombre.Text, Int32.Parse(txtCosto.Text));
                Logica.Entrada.logsEntrada(Logica.logica.UsuarioActual,txtNombre.Text,"Entrada creada");
                frmPositivo si = new frmPositivo("Entrada agregada correctamente!");
                si.ShowDialog();
                this.DialogResult = DialogResult.OK;
            }
        }

        private void txtCosto_KeyPress(object sender, KeyPressEventArgs e)
        {
            Logica.logica.ValidarSoloNumeros(e);
        }

        private void frmAltaEntrada_Load(object sender, EventArgs e)
        {

        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            Logica.logica.ValidarSoloLetras(e);
        }
    }
}
