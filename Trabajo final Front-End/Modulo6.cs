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
    public partial class Modulo6 : Form
    {
        public Modulo6()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Modulo6_Load(object sender, EventArgs e)
        {

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            if (nudProducto.Value == 0)
            {
                MessageBox.Show("El id del producto no puede estar vacio");
            } else if (tbxDescripcion.Text == "")
            {
                MessageBox.Show("La descripcion no puede estar vacia");
            } else if (tbxCostos.Text == "")
            {
                MessageBox.Show("Los costos no pueden estar vacio");
            } else if (tbxGanacias.Text == "")
            {
                MessageBox.Show("Las ganancias no pueden estar vacias");
            } else if (tbxExistencias.Text == "") {
                MessageBox.Show("Las existencias no pueden estar vacias");
            } else if (tbxCostosProduccion.Text == "")
            {
                MessageBox.Show("Los costos de produccion no pueden estar vacios");
            } else if (cbxEstatus.Text == "")
            {
                MessageBox.Show("El estatus no puede estar vacio");
            } else
            {
                int c = dgvProductos.Rows.Add();
                dgvProductos.Rows[c].Cells[0].Value = nudProducto.Value;
                dgvProductos.Rows[c].Cells[1].Value = tbxDescripcion.Text;
                dgvProductos.Rows[c].Cells[2].Value = tbxCostos.Text;
                dgvProductos.Rows[c].Cells[3].Value = tbxGanacias.Text;
                dgvProductos.Rows[c].Cells[4].Value = tbxExistencias.Text;
                dgvProductos.Rows[c].Cells[5].Value = tbxCostosProduccion;
                dgvProductos.Rows[c].Cells[6].Value = cbxEstatus.Text;

                btnLimpiar.Enabled = true;
                btnEliminar.Enabled = true;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                dgvProductos.Rows.Remove(dgvProductos.CurrentRow);
            }
            catch { }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            dgvProductos.Rows.Clear();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

        }

        private void BtnActualizar_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void nudProducto_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
