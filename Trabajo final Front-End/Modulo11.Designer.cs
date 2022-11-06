namespace Trabajo_final_Front_End
{
    partial class Modulo11
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
            this.nudCliente = new System.Windows.Forms.NumericUpDown();
            this.lbIdCliente = new System.Windows.Forms.Label();
            this.lbTelefono = new System.Windows.Forms.Label();
            this.lbDireccion = new System.Windows.Forms.Label();
            this.lbApellido2 = new System.Windows.Forms.Label();
            this.lbApellido1 = new System.Windows.Forms.Label();
            this.lbNombre = new System.Windows.Forms.Label();
            this.tbxDireccion = new System.Windows.Forms.TextBox();
            this.tbxApellido2 = new System.Windows.Forms.TextBox();
            this.tbxApellido1 = new System.Windows.Forms.TextBox();
            this.tbxNombre = new System.Windows.Forms.TextBox();
            this.tbxTelefono = new System.Windows.Forms.TextBox();
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
            ((System.ComponentModel.ISupportInitialize)(this.nudCliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReceta)).BeginInit();
            this.SuspendLayout();
            // 
            // nudCliente
            // 
            this.nudCliente.Location = new System.Drawing.Point(246, 28);
            this.nudCliente.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.nudCliente.Name = "nudCliente";
            this.nudCliente.Size = new System.Drawing.Size(150, 27);
            this.nudCliente.TabIndex = 8;
            // 
            // lbIdCliente
            // 
            this.lbIdCliente.AutoSize = true;
            this.lbIdCliente.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbIdCliente.Location = new System.Drawing.Point(69, 28);
            this.lbIdCliente.Name = "lbIdCliente";
            this.lbIdCliente.Size = new System.Drawing.Size(125, 28);
            this.lbIdCliente.TabIndex = 7;
            this.lbIdCliente.Text = "Id de Cliente:";
            // 
            // lbTelefono
            // 
            this.lbTelefono.AutoSize = true;
            this.lbTelefono.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbTelefono.Location = new System.Drawing.Point(96, 289);
            this.lbTelefono.Name = "lbTelefono";
            this.lbTelefono.Size = new System.Drawing.Size(90, 28);
            this.lbTelefono.TabIndex = 9;
            this.lbTelefono.Text = "Teléfono:";
            this.lbTelefono.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbDireccion
            // 
            this.lbDireccion.AutoSize = true;
            this.lbDireccion.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbDireccion.Location = new System.Drawing.Point(96, 236);
            this.lbDireccion.Name = "lbDireccion";
            this.lbDireccion.Size = new System.Drawing.Size(98, 28);
            this.lbDireccion.TabIndex = 10;
            this.lbDireccion.Text = "Dirección:";
            this.lbDireccion.Click += new System.EventHandler(this.label2_Click);
            // 
            // lbApellido2
            // 
            this.lbApellido2.AutoSize = true;
            this.lbApellido2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbApellido2.Location = new System.Drawing.Point(88, 186);
            this.lbApellido2.Name = "lbApellido2";
            this.lbApellido2.Size = new System.Drawing.Size(106, 28);
            this.lbApellido2.TabIndex = 11;
            this.lbApellido2.Text = "Apellido 2:";
            // 
            // lbApellido1
            // 
            this.lbApellido1.AutoSize = true;
            this.lbApellido1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbApellido1.Location = new System.Drawing.Point(88, 132);
            this.lbApellido1.Name = "lbApellido1";
            this.lbApellido1.Size = new System.Drawing.Size(106, 28);
            this.lbApellido1.TabIndex = 12;
            this.lbApellido1.Text = "Apellido 1:";
            this.lbApellido1.Click += new System.EventHandler(this.label4_Click);
            // 
            // lbNombre
            // 
            this.lbNombre.AutoSize = true;
            this.lbNombre.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbNombre.Location = new System.Drawing.Point(105, 76);
            this.lbNombre.Name = "lbNombre";
            this.lbNombre.Size = new System.Drawing.Size(89, 28);
            this.lbNombre.TabIndex = 13;
            this.lbNombre.Text = "Nombre:";
            // 
            // tbxDireccion
            // 
            this.tbxDireccion.Location = new System.Drawing.Point(246, 240);
            this.tbxDireccion.Name = "tbxDireccion";
            this.tbxDireccion.Size = new System.Drawing.Size(150, 27);
            this.tbxDireccion.TabIndex = 14;
            this.tbxDireccion.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // tbxApellido2
            // 
            this.tbxApellido2.Location = new System.Drawing.Point(246, 190);
            this.tbxApellido2.Name = "tbxApellido2";
            this.tbxApellido2.Size = new System.Drawing.Size(150, 27);
            this.tbxApellido2.TabIndex = 15;
            // 
            // tbxApellido1
            // 
            this.tbxApellido1.Location = new System.Drawing.Point(246, 136);
            this.tbxApellido1.Name = "tbxApellido1";
            this.tbxApellido1.Size = new System.Drawing.Size(150, 27);
            this.tbxApellido1.TabIndex = 16;
            // 
            // tbxNombre
            // 
            this.tbxNombre.Location = new System.Drawing.Point(246, 80);
            this.tbxNombre.Name = "tbxNombre";
            this.tbxNombre.Size = new System.Drawing.Size(150, 27);
            this.tbxNombre.TabIndex = 17;
            // 
            // tbxTelefono
            // 
            this.tbxTelefono.Location = new System.Drawing.Point(246, 293);
            this.tbxTelefono.Name = "tbxTelefono";
            this.tbxTelefono.Size = new System.Drawing.Size(150, 27);
            this.tbxTelefono.TabIndex = 18;
            this.tbxTelefono.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(606, 229);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(94, 29);
            this.btnLimpiar.TabIndex = 24;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(606, 280);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(94, 29);
            this.btnCancelar.TabIndex = 23;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(606, 175);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(94, 29);
            this.btnEliminar.TabIndex = 22;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(606, 26);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(94, 29);
            this.btnNuevo.TabIndex = 21;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(606, 75);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(94, 29);
            this.btnBuscar.TabIndex = 20;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // BtnActualizar
            // 
            this.BtnActualizar.Location = new System.Drawing.Point(606, 124);
            this.BtnActualizar.Name = "BtnActualizar";
            this.BtnActualizar.Size = new System.Drawing.Size(94, 29);
            this.BtnActualizar.TabIndex = 19;
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
            this.dgvReceta.Location = new System.Drawing.Point(69, 345);
            this.dgvReceta.Name = "dgvReceta";
            this.dgvReceta.ReadOnly = true;
            this.dgvReceta.RowHeadersWidth = 51;
            this.dgvReceta.RowTemplate.Height = 29;
            this.dgvReceta.Size = new System.Drawing.Size(553, 188);
            this.dgvReceta.TabIndex = 25;
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
            // Modulo11
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(731, 545);
            this.Controls.Add(this.dgvReceta);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.BtnActualizar);
            this.Controls.Add(this.tbxTelefono);
            this.Controls.Add(this.tbxNombre);
            this.Controls.Add(this.tbxApellido1);
            this.Controls.Add(this.tbxApellido2);
            this.Controls.Add(this.tbxDireccion);
            this.Controls.Add(this.lbNombre);
            this.Controls.Add(this.lbApellido1);
            this.Controls.Add(this.lbApellido2);
            this.Controls.Add(this.lbDireccion);
            this.Controls.Add(this.lbTelefono);
            this.Controls.Add(this.nudCliente);
            this.Controls.Add(this.lbIdCliente);
            this.Name = "Modulo11";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modulo 11 | Clientes";
            this.Load += new System.EventHandler(this.Modulo11_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudCliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReceta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private NumericUpDown nudCliente;
        private Label lbIdCliente;
        private Label lbTelefono;
        private Label lbDireccion;
        private Label lbApellido2;
        private Label lbApellido1;
        private Label lbNombre;
        private TextBox tbxDireccion;
        private TextBox tbxApellido2;
        private TextBox tbxApellido1;
        private TextBox tbxNombre;
        private TextBox tbxTelefono;
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