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
    public partial class Modulo4 : Form
    {
        public Modulo4()
        {
            InitializeComponent();
        }

        private void Modulo4_Load(object sender, EventArgs e)
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
                dgvInventarioProveedor.Rows.Remove(dgvInventarioProveedor.CurrentRow);
            }
            catch { }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            dgvInventarioProveedor.Rows.Clear();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            if (nudProveedor.Value == 0)
            {
                MessageBox.Show("El proveedor no puede estar vacio");
            } else if (nudInventario.Value == 0)
            {
                MessageBox.Show("El id del inventario no puede estar vacio");
            } else if (cbxEstatus.Text == "")
            {
                MessageBox.Show("El estatus no puede estar vacio");
            }
            else
            {
                int c = dgvInventarioProveedor.Rows.Add();
                dgvInventarioProveedor.Rows[c].Cells[0].Value = nudProveedor.Value;
                dgvInventarioProveedor.Rows[c].Cells[1].Value = nudInventario.Value;
                dgvInventarioProveedor.Rows[c].Cells[2].Value = cbxEstatus.Text;

                BtnActualizar.Enabled = true;
                btnEliminar.Enabled = true;
                btnLimpiar.Enabled = true;
            }

            nudProveedor.Value = 0;
            nudInventario.Value = 0;
            cbxEstatus.Text = "";
        }

        private void dgvInventarioProveedor_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
