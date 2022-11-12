namespace Trabajo_final_Front_End
{
    partial class InventarioVista
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.lbCantidad = new System.Windows.Forms.Label();
            this.lbPrecio = new System.Windows.Forms.Label();
            this.lbUnidad = new System.Windows.Forms.Label();
            this.lbDescripcion = new System.Windows.Forms.Label();
            this.lbInventario = new System.Windows.Forms.Label();
            this.dgvInventario = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nudInventario = new System.Windows.Forms.NumericUpDown();
            this.tbxDescripcion = new System.Windows.Forms.TextBox();
            this.tbxUnidad = new System.Windows.Forms.TextBox();
            this.tbxCantidad = new System.Windows.Forms.TextBox();
            this.tbxPrecio = new System.Windows.Forms.TextBox();
            this.lbEstatus = new System.Windows.Forms.Label();
            this.cbxEstatus = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudInventario)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(630, 134);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(94, 29);
            this.btnLimpiar.TabIndex = 20;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(630, 185);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(94, 29);
            this.btnCancelar.TabIndex = 19;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(630, 80);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(94, 29);
            this.btnEliminar.TabIndex = 18;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(630, 26);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(94, 29);
            this.btnNuevo.TabIndex = 17;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // lbCantidad
            // 
            this.lbCantidad.AutoSize = true;
            this.lbCantidad.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbCantidad.Location = new System.Drawing.Point(204, 248);
            this.lbCantidad.Name = "lbCantidad";
            this.lbCantidad.Size = new System.Drawing.Size(95, 28);
            this.lbCantidad.TabIndex = 21;
            this.lbCantidad.Text = "Cantidad:";
            // 
            // lbPrecio
            // 
            this.lbPrecio.AutoSize = true;
            this.lbPrecio.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbPrecio.Location = new System.Drawing.Point(229, 193);
            this.lbPrecio.Name = "lbPrecio";
            this.lbPrecio.Size = new System.Drawing.Size(70, 28);
            this.lbPrecio.TabIndex = 22;
            this.lbPrecio.Text = "Precio:";
            // 
            // lbUnidad
            // 
            this.lbUnidad.AutoSize = true;
            this.lbUnidad.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbUnidad.Location = new System.Drawing.Point(219, 136);
            this.lbUnidad.Name = "lbUnidad";
            this.lbUnidad.Size = new System.Drawing.Size(80, 28);
            this.lbUnidad.TabIndex = 23;
            this.lbUnidad.Text = "Unidad:";
            // 
            // lbDescripcion
            // 
            this.lbDescripcion.AutoSize = true;
            this.lbDescripcion.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbDescripcion.Location = new System.Drawing.Point(181, 76);
            this.lbDescripcion.Name = "lbDescripcion";
            this.lbDescripcion.Size = new System.Drawing.Size(118, 28);
            this.lbDescripcion.TabIndex = 24;
            this.lbDescripcion.Text = "Descripción:";
            // 
            // lbInventario
            // 
            this.lbInventario.AutoSize = true;
            this.lbInventario.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbInventario.Location = new System.Drawing.Point(141, 27);
            this.lbInventario.Name = "lbInventario";
            this.lbInventario.Size = new System.Drawing.Size(158, 28);
            this.lbInventario.TabIndex = 25;
            this.lbInventario.Text = "Id del inventario:";
            this.lbInventario.Click += new System.EventHandler(this.label5_Click);
            // 
            // dgvInventario
            // 
            this.dgvInventario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInventario.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.cantidad,
            this.estatus,
            this.dataGridViewTextBoxColumn1,
            this.Column3});
            this.dgvInventario.Location = new System.Drawing.Point(7, 339);
            this.dgvInventario.Name = "dgvInventario";
            this.dgvInventario.ReadOnly = true;
            this.dgvInventario.RowHeadersWidth = 51;
            this.dgvInventario.RowTemplate.Height = 29;
            this.dgvInventario.Size = new System.Drawing.Size(803, 188);
            this.dgvInventario.TabIndex = 26;
            this.dgvInventario.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvReceta_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "IdInventario";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Descripcion";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 125;
            // 
            // cantidad
            // 
            this.cantidad.HeaderText = "Unidad";
            this.cantidad.MinimumWidth = 6;
            this.cantidad.Name = "cantidad";
            this.cantidad.ReadOnly = true;
            this.cantidad.Width = 125;
            // 
            // estatus
            // 
            this.estatus.HeaderText = "Precio";
            this.estatus.MinimumWidth = 6;
            this.estatus.Name = "estatus";
            this.estatus.ReadOnly = true;
            this.estatus.Width = 125;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Cantidad";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Estatus";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 125;
            // 
            // nudInventario
            // 
            this.nudInventario.Location = new System.Drawing.Point(341, 32);
            this.nudInventario.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.nudInventario.Name = "nudInventario";
            this.nudInventario.Size = new System.Drawing.Size(150, 27);
            this.nudInventario.TabIndex = 27;
            // 
            // tbxDescripcion
            // 
            this.tbxDescripcion.Location = new System.Drawing.Point(341, 80);
            this.tbxDescripcion.Name = "tbxDescripcion";
            this.tbxDescripcion.Size = new System.Drawing.Size(150, 27);
            this.tbxDescripcion.TabIndex = 28;
            this.tbxDescripcion.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // tbxUnidad
            // 
            this.tbxUnidad.Location = new System.Drawing.Point(341, 140);
            this.tbxUnidad.Name = "tbxUnidad";
            this.tbxUnidad.Size = new System.Drawing.Size(150, 27);
            this.tbxUnidad.TabIndex = 29;
            this.tbxUnidad.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // tbxCantidad
            // 
            this.tbxCantidad.Location = new System.Drawing.Point(341, 254);
            this.tbxCantidad.Name = "tbxCantidad";
            this.tbxCantidad.Size = new System.Drawing.Size(150, 27);
            this.tbxCantidad.TabIndex = 31;
            // 
            // tbxPrecio
            // 
            this.tbxPrecio.Location = new System.Drawing.Point(341, 194);
            this.tbxPrecio.Name = "tbxPrecio";
            this.tbxPrecio.Size = new System.Drawing.Size(150, 27);
            this.tbxPrecio.TabIndex = 30;
            // 
            // lbEstatus
            // 
            this.lbEstatus.AutoSize = true;
            this.lbEstatus.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbEstatus.Location = new System.Drawing.Point(222, 295);
            this.lbEstatus.Name = "lbEstatus";
            this.lbEstatus.Size = new System.Drawing.Size(77, 28);
            this.lbEstatus.TabIndex = 32;
            this.lbEstatus.Text = "Estatus:";
            // 
            // cbxEstatus
            // 
            this.cbxEstatus.FormattingEnabled = true;
            this.cbxEstatus.Items.AddRange(new object[] {
            "Activo",
            "Inactivo"});
            this.cbxEstatus.Location = new System.Drawing.Point(341, 305);
            this.cbxEstatus.Name = "cbxEstatus";
            this.cbxEstatus.Size = new System.Drawing.Size(151, 28);
            this.cbxEstatus.TabIndex = 33;
            // 
            // InventarioVista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.ClientSize = new System.Drawing.Size(1317, 814);
            this.Controls.Add(this.cbxEstatus);
            this.Controls.Add(this.lbEstatus);
            this.Controls.Add(this.tbxCantidad);
            this.Controls.Add(this.tbxPrecio);
            this.Controls.Add(this.tbxUnidad);
            this.Controls.Add(this.tbxDescripcion);
            this.Controls.Add(this.nudInventario);
            this.Controls.Add(this.dgvInventario);
            this.Controls.Add(this.lbInventario);
            this.Controls.Add(this.lbDescripcion);
            this.Controls.Add(this.lbUnidad);
            this.Controls.Add(this.lbPrecio);
            this.Controls.Add(this.lbCantidad);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnNuevo);
            this.Name = "InventarioVista";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modulo3 | Inventario";
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudInventario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnLimpiar;
        private Button btnCancelar;
        private Button btnEliminar;
        private Button btnNuevo;
        private Label lbCantidad;
        private Label lbPrecio;
        private Label lbUnidad;
        private Label lbDescripcion;
        private Label lbInventario;
        private DataGridView dgvInventario;
        private NumericUpDown nudInventario;
        private TextBox tbxDescripcion;
        private TextBox tbxUnidad;
        private TextBox tbxCantidad;
        private TextBox tbxPrecio;
        private Label lbEstatus;
        private ComboBox cbxEstatus;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn cantidad;
        private DataGridViewTextBoxColumn estatus;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn Column3;
    }
}