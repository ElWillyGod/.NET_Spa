﻿using System;
using System.Windows.Forms;

namespace Spa
{
    public partial class frmServiciosCliente : Form
    {
        string b;
        int CI;
        public frmServiciosCliente(string TipoUsuario, int ci)
        {
            CI = ci;
            InitializeComponent();
            b = TipoUsuario;
            if (TipoUsuario == "Gerente")
            {

                dgvServicios.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));
                btnCerrar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));
            }
            else
            {
                dgvServicios.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
                btnCerrar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            }
        }
        private void frmServiciosCliente_Load(object sender, EventArgs e)
        {
            Logica.Reservas.cargarServiciosCliente(dgvServicios, CI);

            if (dgvServicios.Rows.Count == 0)
            {
                frmNegativo chau = new frmNegativo("No hay servicios reservados para este cliente");
                if (chau.ShowDialog() == DialogResult.OK)
                {
                    this.Close();
                }
    
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {

        }
    }
}
