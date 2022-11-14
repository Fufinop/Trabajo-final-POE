using Controladores;
using Entidad;
using Modelos;
using MySql.Data.MySqlClient;
using Negocio;
using System.Drawing.Imaging;

namespace Trabajo_final_Front_End
{

    public partial class EmpleadosVista : Form
    {
        CnEmpleado cnEmpleado = new CnEmpleado();
        public EmpleadosVista()
        {
            InitializeComponent();

            cbxEstatus.Text = "Activo";
            
        }
        private void cargarDatos()
        {
            dgvEmpleado.DataSource = cnEmpleado.obtenerDatos().Tables["tb1"];
        }
        private void Modulo10_Load(object sender, EventArgs e)
        {
            cargarDatos();
            tabControl1.TabPages.Remove(tabPage1);
            picImagen = null;
        }
        private void limpiarForm()
        {
            nudEmpleado.Value = 0;
            tbxNombre.Text = string.Empty;
            tbxApellidos.Text = string.Empty;
            tbxSalario.Text = string.Empty;
            cbxTipo.Text = string.Empty;
            cbxEstatus.Text = "Activo";
            picPrueba = null;
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

        

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            limpiarForm();
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
            //ceempleado.Foto = picImagen.ImageLocation;

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
            //picFoto.Load(dgvEmpleado.CurrentRow.Cells["Foto"].Value.ToString());
        }

        

        private void btnGuardar_Click_1(object sender, EventArgs e)
        {
            /*Convercion de la imagen
            MemoryStream ms = new MemoryStream();
            picPrueba.Image.Save(ms, ImageFormat.Jpeg);
            byte[] img = ms.ToArray();
            */

            bool Resultado;
            CeEmpleado ceEmpleado = new CeEmpleado();
            ceEmpleado.Id = (int)nudEmpleado.Value;
            ceEmpleado.Nombre = tbxNombre.Text;
            ceEmpleado.Apellidos = tbxApellidos.Text;
            ceEmpleado.Salario = tbxSalario.Text;
            ceEmpleado.Tipo = cbxTipo.Text;
            ceEmpleado.Estatus = cbxEstatus.Text;
            //ceEmpleado.Foto = img;
            Resultado = cnEmpleado.validarDatos(ceEmpleado);

            if (Resultado == false)
            {
                return;
            }

            if (ceEmpleado.Id == 0)
            {
                cnEmpleado.crearEmpleado(ceEmpleado);
            }
            else
            {
                cnEmpleado.editarEmpleado(ceEmpleado);
            }

            

            cargarDatos();
            limpiarForm();
            tabControl1.TabPages.Remove(tabPage1);
            tabControl1.TabPages.Add(tabPage2);
        }

        

        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            tabControl1.TabPages.Remove(tabPage1);
            tabControl1.TabPages.Add(tabPage2);
        }

        private void btnEliminar_Click_2(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Seguro que deseas eliminar el registro selecionado?", "Peligo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {

                dgvEmpleado.Rows.RemoveAt(dgvEmpleado.CurrentRow.Index);
                 //id = dgvEmpleado.Rows.
                //MessageBox.Show(" " + id);

                CeEmpleado cE = new CeEmpleado();
                
                //cE.Id = id;
                cnEmpleado.eliminarEmpleado(cE);
                cargarDatos();
                limpiarForm();
            }
        }

        private void btnLimpiar_Click_2(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Seguro que desea eliminar todos los datos?", "Atencion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                CeEmpleado cE = new CeEmpleado();
                cnEmpleado.eliminarDatos(cE);
                cargarDatos();
                limpiarForm();
            }
        }

        

        private void btnNuevo_Click_2(object sender, EventArgs e)
        {
            limpiarForm();
            nudEmpleado.Visible = false;
            lbEmpleado.Visible = false;
            cbxEstatus.Visible = false;
            lbEstatus.Visible = false;
            tabControl1.TabPages.Remove(tabPage2);
            tabControl1.TabPages.Add(tabPage1);
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            cbxEstatus.Visible = true;
            lbEmpleado.Visible = true;
            cbxEstatus.Visible = true;
            lbEstatus.Visible = true;
            cbxEstatus.Enabled = true;
            tabControl1.TabPages.Remove(tabPage2);
            tabControl1.TabPages.Add(tabPage1);
        }

        private void dgvEmpleado_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            /*
            try
            {
                id = (int)dgvEmpleado.CurrentRow.Cells["id"].Value;
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }
            
            MessageBox.Show(" " + id);
            */


            MessageBox.Show("Ya puedes Editar este campo");
            nudEmpleado.Value = (uint)dgvEmpleado.CurrentRow.Cells["IdEmpleado"].Value;
            tbxNombre.Text = dgvEmpleado.CurrentRow.Cells["Nombres"].Value.ToString();
            tbxApellidos.Text = dgvEmpleado.CurrentRow.Cells["Apellidos"].Value.ToString();
            tbxSalario.Text = dgvEmpleado.CurrentRow.Cells["Salario"].Value.ToString();
            cbxTipo.Text = dgvEmpleado.CurrentRow.Cells["Tipo"].Value.ToString();
            //picFoto.Load(dgvEmpleado.CurrentRow.Cells["Imagen"].Value.ToString());
            cbxEstatus.Text = dgvEmpleado.CurrentRow.Cells["Estatus"].Value.ToString();

            //Reader
            //MySqlDataReader reader = 

            try
            {
                
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btnEliminar_Click_3(object sender, EventArgs e)
        {
            if (nudEmpleado.Value == 0) return;

            if (MessageBox.Show("¿Seguro que deseas eliminar el registro?", "Atencion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                CeEmpleado cE = new CeEmpleado();
                cnEmpleado.eliminarEmpleado(cE);
                cargarDatos();
                limpiarForm();
            }

            tabControl1.TabPages.Remove(tabPage1);
            tabControl1.TabPages.Add(tabPage2);
        }

        //Metodos sin usar
        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void BtnActualizar_Click(object sender, EventArgs e)
        {

        }
        private void lbImagen_Click(object sender, EventArgs e)
        {

        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void btnEliminar_Click_1(object sender, EventArgs e)
        {

        }
        private void btnLimpiar_Click_1(object sender, EventArgs e)
        {

        }
        private void lbEmpleado_Click(object sender, EventArgs e)
        {

        }
        private void tabPage2_Click(object sender, EventArgs e)
        {

        }
        private void tabPage2_Click_1(object sender, EventArgs e)
        {

        }
        private void btnNuevo_Click_1(object sender, EventArgs e)
        {

        }
        private void cbxEstatus_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofdSeleccionar = new OpenFileDialog();

            ofdSeleccionar.Filter = "Imagenes | jpg; *.png;";
            ofdSeleccionar.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
            ofdSeleccionar.Title = "Seleccionar Imagen";

            if (ofdSeleccionar.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    picPrueba.Image = Image.FromFile(ofdSeleccionar.FileName);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("" + ex.ToString);
                    throw;
                }
                
            }


        }
    }
}
