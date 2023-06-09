﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Logica;

namespace Spa
{
    public partial class frmOtros : Form
    {
        string cedula = "";

        public frmOtros(string tipoUsuario,string ci)
        {
            cedula = ci;
            InitializeComponent();
            if (tipoUsuario == "Admin")
            {
                MenuTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(255)))));
                dgvOtros.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(255)))));
                dgvOtros.ColumnHeadersDefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(255)))));
                txtCedula.BorderColorActive = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
                txtCedula.OnActiveState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
                txtNombre.BorderColorActive = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
                txtNombre.OnActiveState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
                txtApellido.BorderColorActive = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
                txtApellido.OnActiveState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
                txtCorreo.BorderColorActive = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
                txtCorreo.OnActiveState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
                txtTelefono.BorderColorActive = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
                txtTelefono.OnActiveState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
                txtDireccion.BorderColorActive = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
                txtDireccion.OnActiveState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
                btnAgregar.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(255)))));
                btnAgregar.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
                btnAgregar.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
                btnAgregar.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
                btnAgregar.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(255)))));
                btnAgregar.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
                btnAgregar.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
                btnAgregar.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            }
            Logica.Entrada.MostrarEntradas(cbEntradas);
            dgvOtros.DataSource = acompañantes.lista;
            editar.DisplayIndex = 8;
            eliminar.DisplayIndex = 7;
        }
        private bool validarOtros()
        {

           
            try
            {
                int hola = 0;
                if(txtCedula.Text != string.Empty)
                     hola = Int32.Parse(txtCedula.Text);
            }
            catch (Exception)
            {
                frmNegativo negativo = new frmNegativo("El documento ingresado no es valido");
                negativo.ShowDialog();
                return false;
            }
            try
            {
                int hola = 0;
                if (txtTelefono.Text != string.Empty)
                     hola = Int32.Parse(txtTelefono.Text);
            }
            catch (Exception)
            {
                frmNegativo negativo = new frmNegativo("El telefono ingresado no es valido");
                negativo.ShowDialog();
                return false;
            }

            if (!logica.validarCampoVacio(txtCedula.Text))
            {
                frmNegativo negativo = new frmNegativo("El campo Cedula no puede estar vacio");
                negativo.ShowDialog();
                return false;
            }
            else if (txtCedula.Text == cedula)
            {
                return false;
            }

            else if (!logica.validarCampoVacio(txtNombre.Text))
            {
                frmNegativo negativo = new frmNegativo("El campo Nombre no puede estar vacio");
                negativo.ShowDialog();
                return false;
            }
            else if (!logica.validarCampoVacio(txtApellido.Text))
            {
                frmNegativo negativo = new frmNegativo("El campo Apellido no puede estar vacio");
                negativo.ShowDialog();
                return false;
            }
            else if (!logica.validarCampoVacio(txtCorreo.Text))
            {
                frmNegativo negativo = new frmNegativo("El campo Correo no puede estar vacio");
                negativo.ShowDialog();
                return false;
            }
            else if (!logica.validarEmail(txtCorreo.Text))
            {
                frmNegativo negativo = new frmNegativo("El Correo ingresado tiene un formato incorrecto");
                negativo.ShowDialog();
                return false;
            }

            else if (!logica.validarCampoVacio(txtTelefono.Text))
            {
                frmNegativo negativo = new frmNegativo("El campo Telefono no puede estar vacio");
                negativo.ShowDialog();
                return false;
            }
            else if (!logica.validarCampoVacio(txtDireccion.Text))
            {
                frmNegativo negativo = new frmNegativo("El campo Dirección no puede estar vacio");
                negativo.ShowDialog();
                return false;
            }
            else
            {
                foreach(DataRow dr in acompañantes.lista.Rows)
                {
                    if(dr["CI"].ToString()== txtCedula.Text)
                    {
                        return false;
                    }
                }
                return true;
            }
        }
        private bool validarModificar()
        {

            if (!logica.validarCampoVacio(txtCedula.Text))
            {
                frmNegativo negativo = new frmNegativo("El campo documento no puede estar vacio");
                negativo.ShowDialog();
                return false;
            }
            else if (!logica.validarCampoVacio(txtNombre.Text))
            {
                frmNegativo negativo = new frmNegativo("El nombre no puede estar vacio");
                negativo.ShowDialog();
                return false;
            }
            else if (!logica.validarCampoVacio(txtApellido.Text))
            {
                frmNegativo negativo = new frmNegativo("El campo apellido no puede estar vacio");
                negativo.ShowDialog();
                return false;
            }
            else if (!logica.validarCampoVacio(txtCorreo.Text))
            {
                frmNegativo negativo = new frmNegativo("El campo correo no puede estar vacio");
                negativo.ShowDialog();
                return false;
            }
            else if (!logica.validarEmail(txtCorreo.Text))
            {
                frmNegativo negativo = new frmNegativo("El correo no es valido");
                negativo.ShowDialog();
                return false;
            }
            else if (!logica.validarCampoVacio(txtTelefono.Text))
            {
                frmNegativo negativo = new frmNegativo("El campo telefono no puede estar vacio");
                negativo.ShowDialog();
                return false;
            }
            else if (!logica.validarCampoVacio(txtDireccion.Text))
            {
                frmNegativo negativo = new frmNegativo("El campo dirección no puede estar vacio");
                negativo.ShowDialog();
                return false;
            }
            else
            {
                return true;
            }
        }
        private void borrarTxt()
        {
            txtCedula.Clear();
            txtNombre.Clear();
            txtApellido.Clear();
            txtCorreo.Clear();
            txtTelefono.Clear();
            txtDireccion.Clear();
        }
        private void editarPersona(int cedula,string nombre,string apellido,string correo,string telefono,string direccion,string entrada,int indexNro)
        {
            acompañantes.lista.Rows[indexNro]["CI"] = cedula;
            acompañantes.lista.Rows[indexNro]["Nombre"] = nombre;
            acompañantes.lista.Rows[indexNro]["Apellido"] = apellido;
            acompañantes.lista.Rows[indexNro]["Correo"] = correo;
            acompañantes.lista.Rows[indexNro]["Telefono"] = telefono;
            acompañantes.lista.Rows[indexNro]["Dirección"] = direccion;
            acompañantes.lista.Rows[indexNro]["Entrada"] = entrada;
        }
        private void cargarPersona(int indexNro)
        {
            txtCedula.Text = acompañantes.lista.Rows[indexNro]["CI"].ToString();
            txtNombre.Text = acompañantes.lista.Rows[indexNro]["Nombre"].ToString();
            txtApellido.Text = acompañantes.lista.Rows[indexNro]["Apellido"].ToString();
            txtCorreo.Text = acompañantes.lista.Rows[indexNro]["Correo"].ToString();
            txtTelefono.Text = acompañantes.lista.Rows[indexNro]["Telefono"].ToString();
            txtDireccion.Text = acompañantes.lista.Rows[indexNro]["Dirección"].ToString();
            cbEntradas.Text = acompañantes.lista.Rows[indexNro]["Entrada"].ToString();
        }
        private void frmOtros_Load(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (Logica.Cliente.cargarDatosClienteExistente(txtCedula, txtNombre, txtApellido, txtCorreo, txtTelefono, txtDireccion, cbEntradas))
            {
            }
            if (validarOtros())
            {
                acompañantes.lista.Rows.Add(txtCedula.Text,txtNombre.Text,txtApellido.Text,txtCorreo.Text,txtTelefono.Text,txtDireccion.Text,cbEntradas.Text);
                dgvOtros.DataSource = acompañantes.lista;
                borrarTxt();
            }
            
        }

        private void dgvOtros_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvOtros.Columns["eliminar"].Index)
            {
                acompañantes.lista.Rows.RemoveAt(e.RowIndex);
                dgvOtros.DataSource = acompañantes.lista;
            }
            else if (e.ColumnIndex == dgvOtros.Columns["editar"].Index)
            {
                if (validarModificar())
                {
                    editarPersona(Int32.Parse(txtCedula.Text), txtNombre.Text, txtApellido.Text, txtCorreo.Text, txtTelefono.Text, txtDireccion.Text,cbEntradas.Text, e.RowIndex);
                    dgvOtros.DataSource = acompañantes.lista;
                }
            }
            else
            {
                cargarPersona(e.RowIndex);
            }
        }

        private void txtCedula_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            logica.ValidarSoloNumeros(e);
        }

        private void MenuTop_MouseDown(object sender, MouseEventArgs e)
        {
            logica.move(Handle, e);
        }
    }
}
