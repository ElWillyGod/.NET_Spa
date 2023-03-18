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
    public partial class frmShowPass : Form
    {
        int x = 25;
        public frmShowPass(string ci)
        {
            InitializeComponent();
            lblPass.Text = Logica.Usuarios.GetPass(Int32.Parse(ci));
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if (x <= 0)
            {
                Timer.Stop();
                this.Close();
            }
            else
            {
                x--;
                lblTimer.Text = "" + x;
            }
        }

        private void MenuTop_MouseDown(object sender, MouseEventArgs e)
        {
            Logica.logica.move(Handle, e);
        }
    }
}
