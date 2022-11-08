using Controladores;
using Entidad;
using Modelos;
using Negocio;
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
    
    public partial class Modulo10 : Form
    {
        CnEmpleado cnEmpleado = new CnEmpleado();
        public Modulo10()
        {
            InitializeComponent();
        }
        private void cargarDatos()
        {
            dgvEmpleado.DataSource = cnEmpleado.obtenerDatos().Tables["tb1"];
        }
        private void Modulo10_Load(object sender, EventArgs e)
        {
            cargarDatos();
        }
        private void limpiarForm()
        {
            nudEmpleado.Value = 0;
            tbxNombre.Text = string.Empty;
            tbxApellidos.Text = string.Empty;
            tbxSalario.Text = string.Empty;
            cbxTipo.Text = string.Empty;
            cbxEstatus.Text = string.Empty;
            picFoto = null;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void BtnActualizar_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tbxApellido2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar >= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo puedes ingresar numeros", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
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

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            limpiarForm();
        }

        private void cbxEstatus_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            bool resultado;
            CeEmpleado ceempleado = new CeEmpleado();
            ceempleado.Id = (int)nudEmpleado.Value;
            ceempleado.Nombre = tbxNombre.Text;
            ceempleado.Apellidos = tbxApellidos.Text;
            ceempleado.Salario = tbxSalario.Text;
            ceempleado.Tipo = cbxTipo.Text;
            ceempleado.Foto = picFoto.ImageLocation;

            resultado = cnEmpleado.validarDatos(ceempleado);

            if (resultado == false)
            {
                return;
            }

            if (ceempleado.Id == 0)
            {
                cnEmpleado.crearEmpleado(ceempleado);
            }
            else
            {
                cnEmpleado.editarEmpleado(ceempleado);
            }

            cnEmpleado.crearEmpleado(ceempleado);

            cargarDatos();
            limpiarForm();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (nudEmpleado.Value == 0) return;

            if (MessageBox.Show("¿Deseas eliminar el registro?", "Titulo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                CeEmpleado cE = new CeEmpleado();
                cE.Id = (int)nudEmpleado.Value;
                cnEmpleado.eliminarEmpleado(cE);
                cargarDatos();
                limpiarForm();
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Seguro que desea eliminar todos los datos?", "Atencion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                CeEmpleado cE = new CeEmpleado();
                cnEmpleado.eliminarDatos(cE);
                cargarDatos();
                limpiarForm();
            }
        }

        private void dgvEmpleado_DoubleClick(object sender, EventArgs e)
        {
            nudEmpleado.Value = (int)dgvEmpleado.CurrentRow.Cells["id"].Value;
            tbxNombre.Text = dgvEmpleado.CurrentRow.Cells["Nombre"].Value.ToString();
            tbxApellidos.Text = dgvEmpleado.CurrentRow.Cells["Apellidos"].Value.ToString();
            tbxSalario.Text = dgvEmpleado.CurrentRow.Cells["Salario"].Value.ToString();
            cbxTipo.Text = dgvEmpleado.CurrentRow.Cells["Tipo"].Value.ToString();
            cbxEstatus.Text = dgvEmpleado.CurrentRow.Cells["Estatus"].Value.ToString();
            picFoto.Load(dgvEmpleado.CurrentRow.Cells["Foto"].Value.ToString());
        }
    }
}
