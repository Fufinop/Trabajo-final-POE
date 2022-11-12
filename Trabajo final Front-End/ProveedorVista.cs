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
    public partial class ProveedorVista : Form
    {
        public ProveedorVista()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void nudProducto_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            if (nudProveedor.Value == 0)
            {
                MessageBox.Show("El id del proveedor no puede ser cero");
            } else if (tbxNombre.Text == "")
            {
                MessageBox.Show("El nombre del proveedor no puede estar vacio");
            } else if (tbxTelefono.Text == "")
            {
                MessageBox.Show("El telefono del proveedor no puede estar vacio");
            } else if (cbxEstatus.Text == "")
            {
                MessageBox.Show("El estatus no puede estar vacio");
            } else
            {
                int c = dgvProveedor.Rows.Add();
                dgvProveedor.Rows[c].Cells[0].Value = nudProveedor.Value;
                dgvProveedor.Rows[c].Cells[1].Value = tbxNombre.Text;
                dgvProveedor.Rows[c].Cells[2].Value = tbxTelefono.Text;
                dgvProveedor.Rows[c].Cells[3].Value = cbxEstatus.Text;

                btnEliminar.Enabled = true;
                btnLimpiar.Enabled = true;
            }

            nudProveedor.Value = 0;
            tbxNombre.Text = "";
            tbxTelefono.Text = "";
            cbxEstatus.Text = "";
        }

        private void Modulo5_Load(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            dgvProveedor.Rows.Clear();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                dgvProveedor.Rows.Remove(dgvProveedor.CurrentRow);
            }
            catch { }
        }
    }
}
