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
    public partial class InventarioVista : Form
    {
        public InventarioVista()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void dgvReceta_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnActualizar_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                dgvInventario.Rows.Remove(dgvInventario.CurrentRow);
            }
            catch { }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            dgvInventario.Rows.Clear();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            if (nudInventario.Value == 0)
            {
                MessageBox.Show("ID del inventario no puede ser 0");
            } else if (tbxDescripcion.Text == "")
            {
                MessageBox.Show("La descripcion no puede esta vacia");
            } else if (tbxUnidad.Text == "")
            {
                MessageBox.Show("Unidad no puede estar vacia");
            } else if (tbxPrecio.Text == "")
            {
                MessageBox.Show("El precio no puede estar vacio");
            } else if (tbxCantidad.Text == "")
            {
                MessageBox.Show("La cantidad no puede estar vacia");
            } else if (cbxEstatus.Text == "")
            {
                MessageBox.Show("El estatus no puede estar vacio");
            }
            else
            {
                int c = dgvInventario.Rows.Add();
                dgvInventario.Rows[c].Cells[0].Value = nudInventario.Value;
                dgvInventario.Rows[c].Cells[1].Value = tbxDescripcion.Text;
                dgvInventario.Rows[c].Cells[2].Value = tbxUnidad.Text;
                dgvInventario.Rows[c].Cells[3].Value = tbxPrecio.Text;
                dgvInventario.Rows[c].Cells[4].Value = tbxCantidad.Text;
                dgvInventario.Rows[c].Cells[5].Value = cbxEstatus.Text;

                //BtnActualizar.Enabled = true;
                btnEliminar.Enabled = true;
                btnLimpiar.Enabled = true;
            }

            nudInventario.Value = 0;
            tbxDescripcion.Text = "";
            tbxUnidad.Text = "";
            tbxUnidad.Text = "";
            tbxPrecio.Text = "";
            tbxCantidad.Text = "";
            cbxEstatus.Text = "";
        }
    }
}
