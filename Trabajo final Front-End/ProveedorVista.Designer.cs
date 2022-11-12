namespace Trabajo_final_Front_End
{
    partial class ProveedorVista
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
            this.lbTelefono = new System.Windows.Forms.Label();
            this.lbNombre = new System.Windows.Forms.Label();
            this.lbProveedor = new System.Windows.Forms.Label();
            this.nudProveedor = new System.Windows.Forms.NumericUpDown();
            this.tbxTelefono = new System.Windows.Forms.TextBox();
            this.tbxNombre = new System.Windows.Forms.TextBox();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.dgvProveedor = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbxEstatus = new System.Windows.Forms.ComboBox();
            this.lbEstatus = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudProveedor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProveedor)).BeginInit();
            this.SuspendLayout();
            // 
            // lbTelefono
            // 
            this.lbTelefono.AutoSize = true;
            this.lbTelefono.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbTelefono.Location = new System.Drawing.Point(69, 123);
            this.lbTelefono.Name = "lbTelefono";
            this.lbTelefono.Size = new System.Drawing.Size(219, 28);
            this.lbTelefono.TabIndex = 0;
            this.lbTelefono.Text = "Teléfono del proveedor:";
            // 
            // lbNombre
            // 
            this.lbNombre.AutoSize = true;
            this.lbNombre.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbNombre.Location = new System.Drawing.Point(70, 65);
            this.lbNombre.Name = "lbNombre";
            this.lbNombre.Size = new System.Drawing.Size(218, 28);
            this.lbNombre.TabIndex = 1;
            this.lbNombre.Text = "Nombre del proveedor:";
            this.lbNombre.Click += new System.EventHandler(this.label2_Click);
            // 
            // lbProveedor
            // 
            this.lbProveedor.AutoSize = true;
            this.lbProveedor.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbProveedor.Location = new System.Drawing.Point(126, 18);
            this.lbProveedor.Name = "lbProveedor";
            this.lbProveedor.Size = new System.Drawing.Size(162, 28);
            this.lbProveedor.TabIndex = 2;
            this.lbProveedor.Text = "Id del proveedor:";
            this.lbProveedor.Click += new System.EventHandler(this.label3_Click);
            // 
            // nudProveedor
            // 
            this.nudProveedor.Location = new System.Drawing.Point(331, 23);
            this.nudProveedor.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.nudProveedor.Name = "nudProveedor";
            this.nudProveedor.Size = new System.Drawing.Size(150, 27);
            this.nudProveedor.TabIndex = 7;
            this.nudProveedor.ValueChanged += new System.EventHandler(this.nudProducto_ValueChanged);
            // 
            // tbxTelefono
            // 
            this.tbxTelefono.Location = new System.Drawing.Point(331, 127);
            this.tbxTelefono.Name = "tbxTelefono";
            this.tbxTelefono.Size = new System.Drawing.Size(150, 27);
            this.tbxTelefono.TabIndex = 8;
            // 
            // tbxNombre
            // 
            this.tbxNombre.Location = new System.Drawing.Point(331, 75);
            this.tbxNombre.Name = "tbxNombre";
            this.tbxNombre.Size = new System.Drawing.Size(150, 27);
            this.tbxNombre.TabIndex = 9;
            this.tbxNombre.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(640, 129);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(94, 29);
            this.btnLimpiar.TabIndex = 20;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(640, 180);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(94, 29);
            this.btnCancelar.TabIndex = 19;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(640, 75);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(94, 29);
            this.btnEliminar.TabIndex = 18;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(640, 24);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(94, 29);
            this.btnNuevo.TabIndex = 17;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // dgvProveedor
            // 
            this.dgvProveedor.AllowUserToDeleteRows = false;
            this.dgvProveedor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProveedor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.cantidad,
            this.estatus});
            this.dgvProveedor.Location = new System.Drawing.Point(46, 227);
            this.dgvProveedor.Name = "dgvProveedor";
            this.dgvProveedor.ReadOnly = true;
            this.dgvProveedor.RowHeadersWidth = 51;
            this.dgvProveedor.RowTemplate.Height = 29;
            this.dgvProveedor.Size = new System.Drawing.Size(553, 188);
            this.dgvProveedor.TabIndex = 21;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "IdProveedor";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Nombre";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 125;
            // 
            // cantidad
            // 
            this.cantidad.HeaderText = "Telefono";
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
            // cbxEstatus
            // 
            this.cbxEstatus.FormattingEnabled = true;
            this.cbxEstatus.Items.AddRange(new object[] {
            "Activo",
            "Inactivo"});
            this.cbxEstatus.Location = new System.Drawing.Point(330, 173);
            this.cbxEstatus.Name = "cbxEstatus";
            this.cbxEstatus.Size = new System.Drawing.Size(151, 28);
            this.cbxEstatus.TabIndex = 25;
            // 
            // lbEstatus
            // 
            this.lbEstatus.AutoSize = true;
            this.lbEstatus.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbEstatus.Location = new System.Drawing.Point(211, 174);
            this.lbEstatus.Name = "lbEstatus";
            this.lbEstatus.Size = new System.Drawing.Size(77, 28);
            this.lbEstatus.TabIndex = 24;
            this.lbEstatus.Text = "Estatus:";
            // 
            // ProveedorVista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.ClientSize = new System.Drawing.Size(1317, 814);
            this.Controls.Add(this.cbxEstatus);
            this.Controls.Add(this.lbEstatus);
            this.Controls.Add(this.dgvProveedor);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.tbxNombre);
            this.Controls.Add(this.tbxTelefono);
            this.Controls.Add(this.nudProveedor);
            this.Controls.Add(this.lbProveedor);
            this.Controls.Add(this.lbNombre);
            this.Controls.Add(this.lbTelefono);
            this.ForeColor = System.Drawing.Color.Coral;
            this.Name = "ProveedorVista";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modulo5 | Proveedor";
            this.Load += new System.EventHandler(this.Modulo5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudProveedor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProveedor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lbTelefono;
        private Label lbNombre;
        private Label lbProveedor;
        private NumericUpDown nudProveedor;
        private TextBox tbxTelefono;
        private TextBox tbxNombre;
        private Button btnLimpiar;
        private Button btnCancelar;
        private Button btnEliminar;
        private Button btnNuevo;
        private DataGridView dgvProveedor;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn cantidad;
        private DataGridViewTextBoxColumn estatus;
        private ComboBox cbxEstatus;
        private Label lbEstatus;
    }
}