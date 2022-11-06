namespace Trabajo_final_Front_End
{
    partial class Modulo12
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
            this.nudVenta = new System.Windows.Forms.NumericUpDown();
            this.nudCliente = new System.Windows.Forms.NumericUpDown();
            this.lbIdCliente = new System.Windows.Forms.Label();
            this.lbIdVenta = new System.Windows.Forms.Label();
            this.nudEmpleado = new System.Windows.Forms.NumericUpDown();
            this.lbEmpleado = new System.Windows.Forms.Label();
            this.lbFecha = new System.Windows.Forms.Label();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.BtnActualizar = new System.Windows.Forms.Button();
            this.dgvReceta = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.nudVenta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudEmpleado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReceta)).BeginInit();
            this.SuspendLayout();
            // 
            // nudVenta
            // 
            this.nudVenta.Location = new System.Drawing.Point(239, 27);
            this.nudVenta.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.nudVenta.Name = "nudVenta";
            this.nudVenta.Size = new System.Drawing.Size(150, 27);
            this.nudVenta.TabIndex = 10;
            // 
            // nudCliente
            // 
            this.nudCliente.Location = new System.Drawing.Point(239, 85);
            this.nudCliente.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.nudCliente.Name = "nudCliente";
            this.nudCliente.Size = new System.Drawing.Size(150, 27);
            this.nudCliente.TabIndex = 9;
            // 
            // lbIdCliente
            // 
            this.lbIdCliente.AutoSize = true;
            this.lbIdCliente.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbIdCliente.Location = new System.Drawing.Point(68, 84);
            this.lbIdCliente.Name = "lbIdCliente";
            this.lbIdCliente.Size = new System.Drawing.Size(127, 28);
            this.lbIdCliente.TabIndex = 8;
            this.lbIdCliente.Text = "Id del cliente:";
            // 
            // lbIdVenta
            // 
            this.lbIdVenta.AutoSize = true;
            this.lbIdVenta.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbIdVenta.Location = new System.Drawing.Point(62, 27);
            this.lbIdVenta.Name = "lbIdVenta";
            this.lbIdVenta.Size = new System.Drawing.Size(133, 28);
            this.lbIdVenta.TabIndex = 7;
            this.lbIdVenta.Text = "Id de la venta:";
            // 
            // nudEmpleado
            // 
            this.nudEmpleado.Location = new System.Drawing.Point(239, 145);
            this.nudEmpleado.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.nudEmpleado.Name = "nudEmpleado";
            this.nudEmpleado.Size = new System.Drawing.Size(150, 27);
            this.nudEmpleado.TabIndex = 12;
            // 
            // lbEmpleado
            // 
            this.lbEmpleado.AutoSize = true;
            this.lbEmpleado.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbEmpleado.Location = new System.Drawing.Point(37, 144);
            this.lbEmpleado.Name = "lbEmpleado";
            this.lbEmpleado.Size = new System.Drawing.Size(158, 28);
            this.lbEmpleado.TabIndex = 11;
            this.lbEmpleado.Text = "Id del empleado:";
            this.lbEmpleado.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbFecha
            // 
            this.lbFecha.AutoSize = true;
            this.lbFecha.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbFecha.Location = new System.Drawing.Point(129, 202);
            this.lbFecha.Name = "lbFecha";
            this.lbFecha.Size = new System.Drawing.Size(66, 28);
            this.lbFecha.TabIndex = 13;
            this.lbFecha.Text = "Fecha:";
            // 
            // dtpFecha
            // 
            this.dtpFecha.Location = new System.Drawing.Point(239, 202);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(289, 27);
            this.dtpFecha.TabIndex = 14;
            this.dtpFecha.Value = new System.DateTime(2022, 11, 1, 0, 0, 0, 0);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(615, 228);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(94, 29);
            this.btnLimpiar.TabIndex = 20;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(615, 279);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(94, 29);
            this.btnCancelar.TabIndex = 19;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(615, 174);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(94, 29);
            this.btnEliminar.TabIndex = 18;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(615, 25);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(94, 29);
            this.btnNuevo.TabIndex = 17;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(615, 74);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(94, 29);
            this.btnBuscar.TabIndex = 16;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // BtnActualizar
            // 
            this.BtnActualizar.Location = new System.Drawing.Point(615, 123);
            this.BtnActualizar.Name = "BtnActualizar";
            this.BtnActualizar.Size = new System.Drawing.Size(94, 29);
            this.BtnActualizar.TabIndex = 15;
            this.BtnActualizar.Text = "Actualizar";
            this.BtnActualizar.UseVisualStyleBackColor = true;
            // 
            // dgvReceta
            // 
            this.dgvReceta.AllowUserToDeleteRows = false;
            this.dgvReceta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReceta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.cantidad,
            this.estatus});
            this.dgvReceta.Location = new System.Drawing.Point(56, 292);
            this.dgvReceta.Name = "dgvReceta";
            this.dgvReceta.ReadOnly = true;
            this.dgvReceta.RowHeadersWidth = 51;
            this.dgvReceta.RowTemplate.Height = 29;
            this.dgvReceta.Size = new System.Drawing.Size(553, 188);
            this.dgvReceta.TabIndex = 21;
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
            // cantidad
            // 
            this.cantidad.HeaderText = "Cantidad";
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
            // Modulo12
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(740, 513);
            this.Controls.Add(this.dgvReceta);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.BtnActualizar);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.lbFecha);
            this.Controls.Add(this.nudEmpleado);
            this.Controls.Add(this.lbEmpleado);
            this.Controls.Add(this.nudVenta);
            this.Controls.Add(this.nudCliente);
            this.Controls.Add(this.lbIdCliente);
            this.Controls.Add(this.lbIdVenta);
            this.Name = "Modulo12";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modulo12 | Ventas";
            ((System.ComponentModel.ISupportInitialize)(this.nudVenta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudEmpleado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReceta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private NumericUpDown nudVenta;
        private NumericUpDown nudCliente;
        private Label lbIdCliente;
        private Label lbIdVenta;
        private NumericUpDown nudEmpleado;
        private Label lbEmpleado;
        private Label lbFecha;
        private DateTimePicker dtpFecha;
        private Button btnLimpiar;
        private Button btnCancelar;
        private Button btnEliminar;
        private Button btnNuevo;
        private Button btnBuscar;
        private Button BtnActualizar;
        private DataGridView dgvReceta;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn cantidad;
        private DataGridViewTextBoxColumn estatus;
    }
}