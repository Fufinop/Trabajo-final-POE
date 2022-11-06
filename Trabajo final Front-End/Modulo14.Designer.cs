namespace Trabajo_final_Front_End
{
    partial class Modulo14
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
            this.nudProducto = new System.Windows.Forms.NumericUpDown();
            this.nudInventario = new System.Windows.Forms.NumericUpDown();
            this.lbIdCliente = new System.Windows.Forms.Label();
            this.lbIdEncargo = new System.Windows.Forms.Label();
            this.lbFechaFin = new System.Windows.Forms.Label();
            this.lbFechaEn = new System.Windows.Forms.Label();
            this.lbAnticipo = new System.Windows.Forms.Label();
            this.tbxAnticipo = new System.Windows.Forms.TextBox();
            this.dtpFechaEntrega = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaEncargo = new System.Windows.Forms.DateTimePicker();
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
            ((System.ComponentModel.ISupportInitialize)(this.nudProducto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudInventario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReceta)).BeginInit();
            this.SuspendLayout();
            // 
            // nudProducto
            // 
            this.nudProducto.Location = new System.Drawing.Point(236, 44);
            this.nudProducto.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.nudProducto.Name = "nudProducto";
            this.nudProducto.Size = new System.Drawing.Size(150, 27);
            this.nudProducto.TabIndex = 10;
            // 
            // nudInventario
            // 
            this.nudInventario.Location = new System.Drawing.Point(236, 102);
            this.nudInventario.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.nudInventario.Name = "nudInventario";
            this.nudInventario.Size = new System.Drawing.Size(150, 27);
            this.nudInventario.TabIndex = 9;
            // 
            // lbIdCliente
            // 
            this.lbIdCliente.AutoSize = true;
            this.lbIdCliente.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbIdCliente.Location = new System.Drawing.Point(73, 102);
            this.lbIdCliente.Name = "lbIdCliente";
            this.lbIdCliente.Size = new System.Drawing.Size(127, 28);
            this.lbIdCliente.TabIndex = 8;
            this.lbIdCliente.Text = "Id del cliente:";
            // 
            // lbIdEncargo
            // 
            this.lbIdEncargo.AutoSize = true;
            this.lbIdEncargo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbIdEncargo.Location = new System.Drawing.Point(59, 44);
            this.lbIdEncargo.Name = "lbIdEncargo";
            this.lbIdEncargo.Size = new System.Drawing.Size(141, 28);
            this.lbIdEncargo.TabIndex = 7;
            this.lbIdEncargo.Text = "Id del encargo:";
            // 
            // lbFechaFin
            // 
            this.lbFechaFin.AutoSize = true;
            this.lbFechaFin.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbFechaFin.Location = new System.Drawing.Point(41, 272);
            this.lbFechaFin.Name = "lbFechaFin";
            this.lbFechaFin.Size = new System.Drawing.Size(165, 28);
            this.lbFechaFin.TabIndex = 11;
            this.lbFechaFin.Text = "Fecha de entrega:";
            // 
            // lbFechaEn
            // 
            this.lbFechaEn.AutoSize = true;
            this.lbFechaEn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbFechaEn.Location = new System.Drawing.Point(37, 218);
            this.lbFechaEn.Name = "lbFechaEn";
            this.lbFechaEn.Size = new System.Drawing.Size(169, 28);
            this.lbFechaEn.TabIndex = 12;
            this.lbFechaEn.Text = "Fecha de encargo:";
            // 
            // lbAnticipo
            // 
            this.lbAnticipo.AutoSize = true;
            this.lbAnticipo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbAnticipo.Location = new System.Drawing.Point(110, 163);
            this.lbAnticipo.Name = "lbAnticipo";
            this.lbAnticipo.Size = new System.Drawing.Size(90, 28);
            this.lbAnticipo.TabIndex = 13;
            this.lbAnticipo.Text = "Anticipo:";
            // 
            // tbxAnticipo
            // 
            this.tbxAnticipo.Location = new System.Drawing.Point(236, 167);
            this.tbxAnticipo.Name = "tbxAnticipo";
            this.tbxAnticipo.Size = new System.Drawing.Size(150, 27);
            this.tbxAnticipo.TabIndex = 14;
            this.tbxAnticipo.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // dtpFechaEntrega
            // 
            this.dtpFechaEntrega.Location = new System.Drawing.Point(236, 274);
            this.dtpFechaEntrega.Name = "dtpFechaEntrega";
            this.dtpFechaEntrega.Size = new System.Drawing.Size(293, 27);
            this.dtpFechaEntrega.TabIndex = 15;
            // 
            // dtpFechaEncargo
            // 
            this.dtpFechaEncargo.Location = new System.Drawing.Point(236, 220);
            this.dtpFechaEncargo.Name = "dtpFechaEncargo";
            this.dtpFechaEncargo.Size = new System.Drawing.Size(293, 27);
            this.dtpFechaEncargo.TabIndex = 16;
            this.dtpFechaEncargo.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(598, 233);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(94, 29);
            this.btnLimpiar.TabIndex = 22;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(598, 284);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(94, 29);
            this.btnCancelar.TabIndex = 21;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(598, 179);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(94, 29);
            this.btnEliminar.TabIndex = 20;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(598, 30);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(94, 29);
            this.btnNuevo.TabIndex = 19;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(598, 79);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(94, 29);
            this.btnBuscar.TabIndex = 18;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // BtnActualizar
            // 
            this.BtnActualizar.Location = new System.Drawing.Point(598, 128);
            this.BtnActualizar.Name = "BtnActualizar";
            this.BtnActualizar.Size = new System.Drawing.Size(94, 29);
            this.BtnActualizar.TabIndex = 17;
            this.BtnActualizar.Text = "Actualizar";
            this.BtnActualizar.UseVisualStyleBackColor = true;
            this.BtnActualizar.Click += new System.EventHandler(this.BtnActualizar_Click);
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
            this.dgvReceta.Location = new System.Drawing.Point(41, 352);
            this.dgvReceta.Name = "dgvReceta";
            this.dgvReceta.ReadOnly = true;
            this.dgvReceta.RowHeadersWidth = 51;
            this.dgvReceta.RowTemplate.Height = 29;
            this.dgvReceta.Size = new System.Drawing.Size(553, 188);
            this.dgvReceta.TabIndex = 23;
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
            // Modulo14
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(717, 552);
            this.Controls.Add(this.dgvReceta);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.BtnActualizar);
            this.Controls.Add(this.dtpFechaEncargo);
            this.Controls.Add(this.dtpFechaEntrega);
            this.Controls.Add(this.tbxAnticipo);
            this.Controls.Add(this.lbAnticipo);
            this.Controls.Add(this.lbFechaEn);
            this.Controls.Add(this.lbFechaFin);
            this.Controls.Add(this.nudProducto);
            this.Controls.Add(this.nudInventario);
            this.Controls.Add(this.lbIdCliente);
            this.Controls.Add(this.lbIdEncargo);
            this.Name = "Modulo14";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modulo 14 | Pedidos";
            this.Load += new System.EventHandler(this.Modulo14_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudProducto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudInventario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReceta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private NumericUpDown nudProducto;
        private NumericUpDown nudInventario;
        private Label lbIdCliente;
        private Label lbIdEncargo;
        private Label lbFechaFin;
        private Label lbFechaEn;
        private Label lbAnticipo;
        private TextBox tbxAnticipo;
        private DateTimePicker dtpFechaEntrega;
        private DateTimePicker dtpFechaEncargo;
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