namespace Trabajo_final_Front_End
{
    partial class Modulo4
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
            this.nudProveedor = new System.Windows.Forms.NumericUpDown();
            this.nudInventario = new System.Windows.Forms.NumericUpDown();
            this.lbIdInventario = new System.Windows.Forms.Label();
            this.lbIdProducto = new System.Windows.Forms.Label();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.BtnActualizar = new System.Windows.Forms.Button();
            this.dgvInventarioProveedor = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbxEstatus = new System.Windows.Forms.ComboBox();
            this.lbEstatus = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudProveedor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudInventario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventarioProveedor)).BeginInit();
            this.SuspendLayout();
            // 
            // nudProveedor
            // 
            this.nudProveedor.Location = new System.Drawing.Point(268, 42);
            this.nudProveedor.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.nudProveedor.Name = "nudProveedor";
            this.nudProveedor.Size = new System.Drawing.Size(150, 27);
            this.nudProveedor.TabIndex = 10;
            // 
            // nudInventario
            // 
            this.nudInventario.Location = new System.Drawing.Point(268, 100);
            this.nudInventario.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.nudInventario.Name = "nudInventario";
            this.nudInventario.Size = new System.Drawing.Size(150, 27);
            this.nudInventario.TabIndex = 9;
            // 
            // lbIdInventario
            // 
            this.lbIdInventario.AutoSize = true;
            this.lbIdInventario.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbIdInventario.Location = new System.Drawing.Point(80, 99);
            this.lbIdInventario.Name = "lbIdInventario";
            this.lbIdInventario.Size = new System.Drawing.Size(158, 28);
            this.lbIdInventario.TabIndex = 8;
            this.lbIdInventario.Text = "Id del inventario:";
            // 
            // lbIdProducto
            // 
            this.lbIdProducto.AutoSize = true;
            this.lbIdProducto.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbIdProducto.Location = new System.Drawing.Point(76, 42);
            this.lbIdProducto.Name = "lbIdProducto";
            this.lbIdProducto.Size = new System.Drawing.Size(162, 28);
            this.lbIdProducto.TabIndex = 7;
            this.lbIdProducto.Text = "Id del proveedor:";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Enabled = false;
            this.btnLimpiar.Location = new System.Drawing.Point(513, 172);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(94, 29);
            this.btnLimpiar.TabIndex = 20;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(513, 223);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(94, 29);
            this.btnCancelar.TabIndex = 19;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Enabled = false;
            this.btnEliminar.Location = new System.Drawing.Point(513, 118);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(94, 29);
            this.btnEliminar.TabIndex = 18;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(513, 20);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(94, 29);
            this.btnNuevo.TabIndex = 17;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // BtnActualizar
            // 
            this.BtnActualizar.Enabled = false;
            this.BtnActualizar.Location = new System.Drawing.Point(513, 67);
            this.BtnActualizar.Name = "BtnActualizar";
            this.BtnActualizar.Size = new System.Drawing.Size(94, 29);
            this.BtnActualizar.TabIndex = 15;
            this.BtnActualizar.Text = "Actualizar";
            this.BtnActualizar.UseVisualStyleBackColor = true;
            this.BtnActualizar.Click += new System.EventHandler(this.BtnActualizar_Click);
            // 
            // dgvInventarioProveedor
            // 
            this.dgvInventarioProveedor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInventarioProveedor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.estatus});
            this.dgvInventarioProveedor.Location = new System.Drawing.Point(31, 250);
            this.dgvInventarioProveedor.Name = "dgvInventarioProveedor";
            this.dgvInventarioProveedor.ReadOnly = true;
            this.dgvInventarioProveedor.RowHeadersWidth = 51;
            this.dgvInventarioProveedor.RowTemplate.Height = 29;
            this.dgvInventarioProveedor.Size = new System.Drawing.Size(431, 188);
            this.dgvInventarioProveedor.TabIndex = 21;
            this.dgvInventarioProveedor.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvInventarioProveedor_CellContentClick);
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
            this.Column2.HeaderText = "IdInventario";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 125;
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
            this.cbxEstatus.Location = new System.Drawing.Point(268, 148);
            this.cbxEstatus.Name = "cbxEstatus";
            this.cbxEstatus.Size = new System.Drawing.Size(151, 28);
            this.cbxEstatus.TabIndex = 23;
            // 
            // lbEstatus
            // 
            this.lbEstatus.AutoSize = true;
            this.lbEstatus.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbEstatus.Location = new System.Drawing.Point(161, 148);
            this.lbEstatus.Name = "lbEstatus";
            this.lbEstatus.Size = new System.Drawing.Size(77, 28);
            this.lbEstatus.TabIndex = 22;
            this.lbEstatus.Text = "Estatus:";
            // 
            // Modulo4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(666, 450);
            this.Controls.Add(this.cbxEstatus);
            this.Controls.Add(this.lbEstatus);
            this.Controls.Add(this.dgvInventarioProveedor);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.BtnActualizar);
            this.Controls.Add(this.nudProveedor);
            this.Controls.Add(this.nudInventario);
            this.Controls.Add(this.lbIdInventario);
            this.Controls.Add(this.lbIdProducto);
            this.Name = "Modulo4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modulo4 | Inventario de proveedor";
            this.Load += new System.EventHandler(this.Modulo4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudProveedor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudInventario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventarioProveedor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private NumericUpDown nudProveedor;
        private NumericUpDown nudInventario;
        private Label lbIdInventario;
        private Label lbIdProducto;
        private Button btnLimpiar;
        private Button btnCancelar;
        private Button btnEliminar;
        private Button btnNuevo;
        private Button BtnActualizar;
        private DataGridView dgvInventarioProveedor;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn estatus;
        private ComboBox cbxEstatus;
        private Label lbEstatus;
    }
}