using Modelos;
using Org.BouncyCastle.Crypto.Tls;
using Persistencia;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trabajo_final_Front_End
{
    public partial class Modulo11 : Form
    {
        CnCliente cnCliente = new CnCliente();
        public Modulo11()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Modulo11_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbEstatus_Click(object sender, EventArgs e)
        {

        }

        private void lbApellido2_Click(object sender, EventArgs e)
        {

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            nudCliente.Value = 0;
            tbxNombre.Text = string.Empty;
            tbxApellidos.Text = string.Empty;
            tbxDireccion.Text = string.Empty;
            tbxCedula.Text = string.Empty;
            tbxTelefono.Text = string.Empty;
            tbxEmail.Text = string.Empty;
            cbxEstatus.Text = string.Empty;
            picFoto = null;
        }

        private void lnkFoto_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            openFileDialog1.FileName = string.Empty;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                picFoto.Load(openFileDialog1.FileName);
            }

            openFileDialog1.FileName = string.Empty;
        }

        private void BtnActualizar_Click(object sender, EventArgs e)
        {
            bool Resultado;
            CeCliente cliente = new CeCliente();
            cliente.Id = (int)nudCliente.Value;
            cliente.Nombre = tbxNombre.Text;
            cliente.Apellidos = tbxApellidos.Text;
            cliente.Direccion = tbxDireccion.Text;
            cliente.Cedula = tbxTelefono.Text;
            cliente.Telefono = tbxTelefono.Text;
            cliente.Email = tbxEmail.Text;
            cliente.Estatus = cbxEstatus.Text;

            Resultado = cnCliente.validarDatos(cliente);

            if (Resultado == false)
            {
                return;
            }

            MessageBox.Show("Todo bien");
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            cnCliente.prueaMysql();
        }
    }
}
