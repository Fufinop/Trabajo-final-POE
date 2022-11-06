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
    public partial class Modulo2 : Form
    {
        public Modulo2()
        {
            InitializeComponent();
        }

        private void Modulo2_Load(object sender, EventArgs e)
        {

        }

        private void lbCantidad_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void cbxEstatus_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            if (nudProducto.Value == 0)
            {
                MessageBox.Show("Producto no debe de ser 0");
            }
            else if (nudCantidad.Value == 0)
            {
                MessageBox.Show("La cantidad no puede ser 0");
            }
            else if (cbxEstatus.Text == "")
            {
                MessageBox.Show("El estatus no puede estar vacio");
            } else
            {
                int c = dgvProduccion.Rows.Add();
                dgvProduccion.Rows[c].Cells[0].Value = nudProducto.Value;
                dgvProduccion.Rows[c].Cells[1].Value = nudCantidad.Value;
                dgvProduccion.Rows[c].Cells[2].Value = dtpFecha.Value;
                dgvProduccion.Rows[c].Cells[3].Value = cbxEstatus.Text;

                //BtnActualizar.Enabled = true;
                btnEliminar.Enabled = true;
                btnLimpiar.Enabled = true;
            }

            nudProducto.Value = 0;
            nudCantidad.Value = 0;
            cbxEstatus.Text = "";

        }

        private void dgvReceta_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            dgvProduccion.Rows.Clear();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                dgvProduccion.Rows.Remove(dgvProduccion.CurrentRow);
            }
            catch { }
        }
    }
}
