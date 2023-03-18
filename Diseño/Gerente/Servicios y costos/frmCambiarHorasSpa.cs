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
    public partial class frmCambiarHorasSpa : Form
    {
        public frmCambiarHorasSpa()
        {
            InitializeComponent();
            comboApertura.Text = Logica.Spa.gethoraApertura();
            comboCierre.Text = Logica.Spa.gethoraCierre();
            Logica.logica.CargarHoras(comboApertura);
            Logica.logica.CargarHoras(comboCierre);

        }

        private void btnModificarHorario_Click(object sender, EventArgs e)
        {
            
            if (Convert.ToDateTime(comboApertura.Text)>= Convert.ToDateTime(comboCierre.Text)) {
                frmNegativo ekisde = new frmNegativo("La hora de apertura no puede ser superior o igual a la de cierre");
                ekisde.ShowDialog();
            }
            else
            {
                Logica.Spa.modificarHorarioSpa(comboApertura.Text,comboCierre.Text);
                frmPositivo ekisde = new frmPositivo("Horario Modificado Correctamente");
                ekisde.ShowDialog();
                this.DialogResult = DialogResult.OK;
            }
        }

        private void MenuTop_MouseDown(object sender, MouseEventArgs e)
        {
            Logica.logica.move(Handle, e);
        }
    }
}
