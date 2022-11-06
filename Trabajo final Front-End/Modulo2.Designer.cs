namespace Trabajo_final_Front_End
{
    partial class Modulo2
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
            this.lbEstatus = new System.Windows.Forms.Label();
            this.lbCantidad = new System.Windows.Forms.Label();
            this.lbIdInventario = new System.Windows.Forms.Label();
            this.lbIdProducto = new System.Windows.Forms.Label();
            this.nudProducto = new System.Windows.Forms.NumericUpDown();
            this.nudCantidad = new System.Windows.Forms.NumericUpDown();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.cbxEstatus = new System.Windows.Forms.ComboBox();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.dgvProduccion = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.nudProducto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduccion)).BeginInit();
            this.SuspendLayout();
            // 
            // lbEstatus
            // 
            this.lbEstatus.AutoSize = true;
            this.lbEstatus.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbEstatus.Location = new System.Drawing.Point(155, 186);
            this.lbEstatus.Name = "lbEstatus";
            this.lbEstatus.Size = new System.Drawing.Size(77, 28);
            this.lbEstatus.TabIndex = 11;
            this.lbEstatus.Text = "Estatus:";
            // 
            // lbCantidad
            // 
            this.lbCantidad.AutoSize = true;
            this.lbCantidad.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbCantidad.Location = new System.Drawing.Point(166, 132);
            this.lbCantidad.Name = "lbCantidad";
            this.lbCantidad.Size = new System.Drawing.Size(66, 28);
            this.lbCantidad.TabIndex = 10;
            this.lbCantidad.Text = "Fecha:";
            this.lbCantidad.Click += new System.EventHandler(this.lbCantidad_Click);
            // 
            // lbIdInventario
            // 
            this.lbIdInventario.AutoSize = true;
            this.lbIdInventario.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbIdInventario.Location = new System.Drawing.Point(137, 75);
            this.lbIdInventario.Name = "lbIdInventario";
            this.lbIdInventario.Size = new System.Drawing.Size(95, 28);
            this.lbIdInventario.TabIndex = 9;
            this.lbIdInventario.Text = "Cantidad:";
            // 
            // lbIdProducto
            // 
            this.lbIdProducto.AutoSize = true;
            this.lbIdProducto.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbIdProducto.Location = new System.Drawing.Point(85, 18);
            this.lbIdProducto.Name = "lbIdProducto";
            this.lbIdProducto.Size = new System.Drawing.Size(147, 28);
            this.lbIdProducto.TabIndex = 8;
            this.lbIdProducto.Text = "Id de producto:";
            // 
            // nudProducto
            // 
            this.nudProducto.Location = new System.Drawing.Point(264, 22);
            this.nudProducto.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.nudProducto.Name = "nudProducto";
            this.nudProducto.Size = new System.Drawing.Size(150, 27);
            this.nudProducto.TabIndex = 14;
            // 
            // nudCantidad
            // 
            this.nudCantidad.Location = new System.Drawing.Point(264, 80);
            this.nudCantidad.Name = "nudCantidad";
            this.nudCantidad.Size = new System.Drawing.Size(150, 27);
            this.nudCantidad.TabIndex = 13;
            // 
            // dtpFecha
            // 
            this.dtpFecha.Location = new System.Drawing.Point(264, 134);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(250, 27);
            this.dtpFecha.TabIndex = 15;
            this.dtpFecha.Value = new System.DateTime(2022, 10, 31, 0, 0, 0, 0);
            this.dtpFecha.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // cbxEstatus
            // 
            this.cbxEstatus.FormattingEnabled = true;
            this.cbxEstatus.Items.AddRange(new object[] {
            "Activo",
            "Inactivo"});
            this.cbxEstatus.Location = new System.Drawing.Point(264, 190);
            this.cbxEstatus.Name = "cbxEstatus";
            this.cbxEstatus.Size = new System.Drawing.Size(151, 28);
            this.cbxEstatus.TabIndex = 16;
            this.cbxEstatus.SelectedIndexChanged += new System.EventHandler(this.cbxEstatus_SelectedIndexChanged);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Enabled = false;
            this.btnLimpiar.Location = new System.Drawing.Point(552, 125);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(94, 29);
            this.btnLimpiar.TabIndex = 22;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(552, 176);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(94, 29);
            this.btnCancelar.TabIndex = 21;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Enabled = false;
            this.btnEliminar.Location = new System.Drawing.Point(552, 71);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(94, 29);
            this.btnEliminar.TabIndex = 20;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(552, 22);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(94, 29);
            this.btnNuevo.TabIndex = 19;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // dgvProduccion
            // 
            this.dgvProduccion.AllowUserToDeleteRows = false;
            this.dgvProduccion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProduccion.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.cantidad,
            this.estatus});
            this.dgvProduccion.Location = new System.Drawing.Point(44, 313);
            this.dgvProduccion.Name = "dgvProduccion";
            this.dgvProduccion.ReadOnly = true;
            this.dgvProduccion.RowHeadersWidth = 51;
            this.dgvProduccion.RowTemplate.Height = 29;
            this.dgvProduccion.Size = new System.Drawing.Size(553, 188);
            this.dgvProduccion.TabIndex = 23;
            this.dgvProduccion.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvReceta_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "IdProducto";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Cantidad";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 125;
            // 
            // cantidad
            // 
            this.cantidad.HeaderText = "Fecha";
            this.cantidad.MinimumWidth = 6;
            this.cantidad.Name = "cantidad";
            this.cantidad.ReadOnly = true;
            this.cantidad.Width = 125;
            // 
            // estatus
            // 
            this.estatus.HeaderText = "Estatus";
            this.estatus.MinimumWidth = 6;
            this.estatus.Name = "estatus";
            this.estatus.ReadOnly = true;
            this.estatus.Width = 125;
            // 
            // Modulo2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(676, 540);
            this.Controls.Add(this.dgvProduccion);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.cbxEstatus);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.nudProducto);
            this.Controls.Add(this.nudCantidad);
            this.Controls.Add(this.lbEstatus);
            this.Controls.Add(this.lbCantidad);
            this.Controls.Add(this.lbIdInventario);
            this.Controls.Add(this.lbIdProducto);
            this.Name = "Modulo2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modulo 2 | Producción";
            this.Load += new System.EventHandler(this.Modulo2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudProducto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduccion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lbEstatus;
        private Label lbCantidad;
        private Label lbIdInventario;
        private Label lbIdProducto;
        private NumericUpDown nudProducto;
        private NumericUpDown nudCantidad;
        private DateTimePicker dtpFecha;
        private ComboBox cbxEstatus;
        private Button btnLimpiar;
        private Button btnCancelar;
        private Button btnEliminar;
        private Button btnNuevo;
        private DataGridView dgvProduccion;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn cantidad;
        private DataGridViewTextBoxColumn estatus;
    }
}