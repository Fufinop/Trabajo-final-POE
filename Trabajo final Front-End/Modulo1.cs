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
    public partial class lbImagen : Form
    {
        public lbImagen()
        {
            InitializeComponent();
        }

        private void Modulo1_Load(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            if (nudProducto.Value == 0)
            {
                MessageBox.Show("Producto no debe de ser 0");
            }else if (nudInventario.Value == 0)
            {
                MessageBox.Show("Inventario no debe de ser 0");
            } else if (nudCantidad.Value == 0)
            {
                MessageBox.Show("La cantidad debe de ser mayor a 0");
            } else if (cbxEstatus.Text == "")
            {
                MessageBox.Show("Estatus debe de ser Activo o Inactivo");
            } else
            {
                int c = dgvReceta.Rows.Add();
                dgvReceta.Rows[c].Cells[0].Value = nudProducto.Value;
                dgvReceta.Rows[c].Cells[1].Value = nudInventario.Value;
                dgvReceta.Rows[c].Cells[2].Value = nudCantidad.Value;
                dgvReceta.Rows[c].Cells[3].Value = cbxEstatus.Text;

                
                btnEliminar.Enabled = true;
                btnLimpiar.Enabled = true;
            }


            nudProducto.Value = 0;
            nudInventario.Value = 0;
            nudCantidad.Value = 0;
            cbxEstatus.Text = "";

           

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            //string eliminar;
            //eliminar = Microsoft.VisualBasic.Interaction.InputBox("Ingrese el numero de fila que desea eliminar:", "columna eliminada", "0", 50, 0);
            try
            {
                dgvReceta.Rows.Remove(dgvReceta.CurrentRow);
            }
            catch
            { }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            dgvReceta.Rows.Clear();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

        }

        private void BtnActualizar_Click(object sender, EventArgs e)
        {

        }

        private void dgvReceta_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
