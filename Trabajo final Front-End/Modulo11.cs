using Modelos;
using Org.BouncyCastle.Asn1.IsisMtt.Ocsp;
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

        private void Modulo11_Load(object sender, EventArgs e)
        {
            cargarDatos();
        }

        private void cargarDatos()
        {
            dgvReceta.DataSource = cnCliente.obtenerDatos().Tables["tb1"];
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            limpiarForm();
        }

        private void limpiarForm()
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
            ofdFoto.FileName = string.Empty;

            if (ofdFoto.ShowDialog() == DialogResult.OK)
            {
                picFoto.Load(ofdFoto.FileName);
            }

            ofdFoto.FileName = string.Empty;
        }

        private void BtnActualizar_Click(object sender, EventArgs e)
        {
            bool Resultado;
            CeCliente cecliente = new CeCliente();
            cecliente.Id = (int)nudCliente.Value;
            cecliente.Nombre = tbxNombre.Text;
            cecliente.Apellidos = tbxApellidos.Text;
            cecliente.Direccion = tbxDireccion.Text;
            cecliente.Cedula = tbxTelefono.Text;
            cecliente.Telefono = tbxTelefono.Text;
            cecliente.Email = tbxEmail.Text;
            cecliente.Estatus = cbxEstatus.Text;
            cecliente.Foto = picFoto.ImageLocation;

            Resultado = cnCliente.validarDatos(cecliente);

            if (Resultado == false)
            {
                return;
            }

            if (cecliente.Id == 0)
            {
                cnCliente.crearCliente(cecliente);
            }
            else
            {
                cnCliente.editarCliente(cecliente);
            }

            cnCliente.crearCliente(cecliente);

            cargarDatos();
            limpiarForm();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (nudCliente.Value == 0) return;

            if (MessageBox.Show("¿Deseas eliminar el registro?","Titulo",MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                CeCliente cE = new CeCliente();
                cE.Id = (int)nudCliente.Value;
                cnCliente.eliminarCliente(cE);
                cargarDatos();
                limpiarForm();
            }
            
        }
        private void btnLimpiar_Click(object sender, EventArgs e)
        {

        }
        private void dgvReceta_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //nudCliente.Value = (int)dgvReceta.CurrentRow.Cells["id"].Value;
            tbxNombre.Text = dgvReceta.CurrentRow.Cells["Nombre"].Value.ToString();
            tbxApellidos.Text = dgvReceta.CurrentRow.Cells["Apellidos"].Value.ToString();
            tbxDireccion.Text = dgvReceta.CurrentRow.Cells["Direccion"].Value.ToString();
            tbxCedula.Text = dgvReceta.CurrentRow.Cells["Cedula"].Value.ToString();
            tbxTelefono.Text = dgvReceta.CurrentRow.Cells["Telefono"].Value.ToString();
            tbxEmail.Text = dgvReceta.CurrentRow.Cells["Email"].Value.ToString();
            cbxEstatus.Text = dgvReceta.CurrentRow.Cells["Estatus"].Value.ToString();
            picFoto.Load(dgvReceta.CurrentRow.Cells["Foto"].Value.ToString());
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Eventos sin usar

        private void picFoto_Click(object sender, EventArgs e)
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
        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dgvReceta_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        
    }
}
