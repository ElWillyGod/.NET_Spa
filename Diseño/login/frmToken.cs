using Logica;
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
    public partial class frmToken : Form
    {

        static private int cedula=0;
        
        public frmToken(int ci)
        {
            cedula = ci;
            
            InitializeComponent();
        }
       
        
  

        private void frmToken_Load(object sender, EventArgs e)
        {
        }

        private void bfbtnVerificar_Click(object sender, EventArgs e)
        {
        }

        private void bftxtCodigo_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
