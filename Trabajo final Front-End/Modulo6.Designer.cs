namespace Trabajo_final_Front_End
{
    partial class Modulo6
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.nudProducto = new System.Windows.Forms.NumericUpDown();
            this.tbxDescripcion = new System.Windows.Forms.TextBox();
            this.tbxExistencias = new System.Windows.Forms.TextBox();
            this.tbxGanacias = new System.Windows.Forms.TextBox();
            this.tbxCostos = new System.Windows.Forms.TextBox();
            this.tbxCostosProduccion = new System.Windows.Forms.TextBox();
            this.dgvProductos = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CostoProduccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbxEstatus = new System.Windows.Forms.ComboBox();
            this.lbEstatus = new System.Windows.Forms.Label();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.nudProducto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(57, 302);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Costos de producción:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(160, 243);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 28);
            this.label2.TabIndex = 1;
            this.label2.Text = "Existencias";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(39, 177);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(225, 28);
            this.label3.TabIndex = 2;
            this.label3.Text = "Porcentaje de ganancias:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(98, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(166, 28);
            this.label4.TabIndex = 3;
            this.label4.Text = "Costos indirectos:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(146, 57);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 28);
            this.label5.TabIndex = 4;
            this.label5.Text = "Descripción:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(112, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(152, 28);
            this.label6.TabIndex = 5;
            this.label6.Text = "Id del producto:";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(619, 134);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(94, 29);
            this.btnLimpiar.TabIndex = 20;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(619, 185);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(94, 29);
            this.btnCancelar.TabIndex = 19;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(619, 80);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(94, 29);
            this.btnEliminar.TabIndex = 18;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(619, 31);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(94, 29);
            this.btnNuevo.TabIndex = 17;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // nudProducto
            // 
            this.nudProducto.Location = new System.Drawing.Point(299, 14);
            this.nudProducto.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.nudProducto.Name = "nudProducto";
            this.nudProducto.Size = new System.Drawing.Size(150, 27);
            this.nudProducto.TabIndex = 21;
            this.nudProducto.ValueChanged += new System.EventHandler(this.nudProducto_ValueChanged);
            // 
            // tbxDescripcion
            // 
            this.tbxDescripcion.Location = new System.Drawing.Point(299, 51);
            this.tbxDescripcion.Multiline = true;
            this.tbxDescripcion.Name = "tbxDescripcion";
            this.tbxDescripcion.Size = new System.Drawing.Size(276, 58);
            this.tbxDescripcion.TabIndex = 22;
            // 
            // tbxExistencias
            // 
            this.tbxExistencias.Location = new System.Drawing.Point(299, 247);
            this.tbxExistencias.Name = "tbxExistencias";
            this.tbxExistencias.Size = new System.Drawing.Size(162, 27);
            this.tbxExistencias.TabIndex = 23;
            // 
            // tbxGanacias
            // 
            this.tbxGanacias.Location = new System.Drawing.Point(299, 182);
            this.tbxGanacias.Name = "tbxGanacias";
            this.tbxGanacias.Size = new System.Drawing.Size(162, 27);
            this.tbxGanacias.TabIndex = 24;
            // 
            // tbxCostos
            // 
            this.tbxCostos.Location = new System.Drawing.Point(299, 129);
            this.tbxCostos.Name = "tbxCostos";
            this.tbxCostos.Size = new System.Drawing.Size(162, 27);
            this.tbxCostos.TabIndex = 25;
            // 
            // tbxCostosProduccion
            // 
            this.tbxCostosProduccion.Location = new System.Drawing.Point(299, 306);
            this.tbxCostosProduccion.Name = "tbxCostosProduccion";
            this.tbxCostosProduccion.Size = new System.Drawing.Size(162, 27);
            this.tbxCostosProduccion.TabIndex = 26;
            this.tbxCostosProduccion.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // dgvProductos
            // 
            this.dgvProductos.AllowUserToDeleteRows = false;
            this.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.cantidad,
            this.estatus,
            this.Column3,
            this.CostoProduccion,
            this.Column4});
            this.dgvProductos.Location = new System.Drawing.Point(12, 425);
            this.dgvProductos.Name = "dgvProductos";
            this.dgvProductos.ReadOnly = true;
            this.dgvProductos.RowHeadersWidth = 51;
            this.dgvProductos.RowTemplate.Height = 29;
            this.dgvProductos.Size = new System.Drawing.Size(929, 188);
            this.dgvProductos.TabIndex = 27;
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
            this.Column2.HeaderText = "Descripcion";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 125;
            // 
            // cantidad
            // 
            this.cantidad.HeaderText = "Costos";
            this.cantidad.MinimumWidth = 6;
            this.cantidad.Name = "cantidad";
            this.cantidad.ReadOnly = true;
            this.cantidad.Width = 125;
            // 
            // estatus
            // 
            this.estatus.HeaderText = "Ganancias";
            this.estatus.MinimumWidth = 6;
            this.estatus.Name = "estatus";
            this.estatus.ReadOnly = true;
            this.estatus.Width = 125;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Existencias";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 125;
            // 
            // CostoProduccion
            // 
            this.CostoProduccion.HeaderText = "CostoProduccion";
            this.CostoProduccion.MinimumWidth = 6;
            this.CostoProduccion.Name = "CostoProduccion";
            this.CostoProduccion.ReadOnly = true;
            this.CostoProduccion.Width = 125;
            // 
            // cbxEstatus
            // 
            this.cbxEstatus.FormattingEnabled = true;
            this.cbxEstatus.Items.AddRange(new object[] {
            "Activo",
            "Inactivo"});
            this.cbxEstatus.Location = new System.Drawing.Point(294, 354);
            this.cbxEstatus.Name = "cbxEstatus";
            this.cbxEstatus.Size = new System.Drawing.Size(163, 28);
            this.cbxEstatus.TabIndex = 29;
            // 
            // lbEstatus
            // 
            this.lbEstatus.AutoSize = true;
            this.lbEstatus.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbEstatus.Location = new System.Drawing.Point(187, 350);
            this.lbEstatus.Name = "lbEstatus";
            this.lbEstatus.Size = new System.Drawing.Size(77, 28);
            this.lbEstatus.TabIndex = 28;
            this.lbEstatus.Text = "Estatus:";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Estatus";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 125;
            // 
            // Modulo6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(974, 655);
            this.Controls.Add(this.cbxEstatus);
            this.Controls.Add(this.lbEstatus);
            this.Controls.Add(this.dgvProductos);
            this.Controls.Add(this.tbxCostosProduccion);
            this.Controls.Add(this.tbxCostos);
            this.Controls.Add(this.tbxGanacias);
            this.Controls.Add(this.tbxExistencias);
            this.Controls.Add(this.tbxDescripcion);
            this.Controls.Add(this.nudProducto);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Modulo6";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modulo 6 | Productos";
            this.Load += new System.EventHandler(this.Modulo6_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudProducto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button btnLimpiar;
        private Button btnCancelar;
        private Button btnEliminar;
        private Button btnNuevo;
        private NumericUpDown nudProducto;
        private TextBox tbxDescripcion;
        private TextBox tbxExistencias;
        private TextBox tbxGanacias;
        private TextBox tbxCostos;
        private TextBox tbxCostosProduccion;
        private DataGridView dgvProductos;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn cantidad;
        private DataGridViewTextBoxColumn estatus;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn CostoProduccion;
        private ComboBox cbxEstatus;
        private Label lbEstatus;
        private DataGridViewTextBoxColumn Column4;
    }
}