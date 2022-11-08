namespace Trabajo_final_Front_End
{
    partial class ventanaPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.msVentanaP = new System.Windows.Forms.MenuStrip();
            this.abrirModulosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modulo1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarTodosLosModulosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tssNombre = new System.Windows.Forms.ToolStripStatusLabel();
            this.tssNombreI = new System.Windows.Forms.ToolStripStatusLabel();
            this.modulo2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.msVentanaP.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // msVentanaP
            // 
            this.msVentanaP.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.msVentanaP.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.abrirModulosToolStripMenuItem,
            this.cerrarTodosLosModulosToolStripMenuItem});
            this.msVentanaP.Location = new System.Drawing.Point(0, 0);
            this.msVentanaP.Name = "msVentanaP";
            this.msVentanaP.Size = new System.Drawing.Size(1343, 28);
            this.msVentanaP.TabIndex = 1;
            this.msVentanaP.Text = "menuStrip1";
            // 
            // abrirModulosToolStripMenuItem
            // 
            this.abrirModulosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.modulo1ToolStripMenuItem,
            this.modulo2ToolStripMenuItem});
            this.abrirModulosToolStripMenuItem.Name = "abrirModulosToolStripMenuItem";
            this.abrirModulosToolStripMenuItem.Size = new System.Drawing.Size(118, 24);
            this.abrirModulosToolStripMenuItem.Text = "Abrir modulos";
            this.abrirModulosToolStripMenuItem.Click += new System.EventHandler(this.abrirModulosToolStripMenuItem_Click);
            // 
            // modulo1ToolStripMenuItem
            // 
            this.modulo1ToolStripMenuItem.Name = "modulo1ToolStripMenuItem";
            this.modulo1ToolStripMenuItem.Size = new System.Drawing.Size(236, 26);
            this.modulo1ToolStripMenuItem.Text = "Modulo 1 | Clientes";
            this.modulo1ToolStripMenuItem.Click += new System.EventHandler(this.modulo1ToolStripMenuItem_Click_1);
            // 
            // cerrarTodosLosModulosToolStripMenuItem
            // 
            this.cerrarTodosLosModulosToolStripMenuItem.Name = "cerrarTodosLosModulosToolStripMenuItem";
            this.cerrarTodosLosModulosToolStripMenuItem.Size = new System.Drawing.Size(190, 24);
            this.cerrarTodosLosModulosToolStripMenuItem.Text = "Cerrar todos los modulos";
            this.cerrarTodosLosModulosToolStripMenuItem.Click += new System.EventHandler(this.cerrarTodosLosModulosToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tssNombre,
            this.tssNombreI});
            this.statusStrip1.Location = new System.Drawing.Point(0, 763);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1343, 26);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tssNombre
            // 
            this.tssNombre.Name = "tssNombre";
            this.tssNombre.Size = new System.Drawing.Size(72, 20);
            this.tssNombre.Text = "Pasteleria";
            // 
            // tssNombreI
            // 
            this.tssNombreI.Name = "tssNombreI";
            this.tssNombreI.Size = new System.Drawing.Size(151, 20);
            this.tssNombreI.Text = "toolStripStatusLabel1";
            // 
            // modulo2ToolStripMenuItem
            // 
            this.modulo2ToolStripMenuItem.Name = "modulo2ToolStripMenuItem";
            this.modulo2ToolStripMenuItem.Size = new System.Drawing.Size(236, 26);
            this.modulo2ToolStripMenuItem.Text = "Modulo 2 | Empleado";
            this.modulo2ToolStripMenuItem.Click += new System.EventHandler(this.modulo2ToolStripMenuItem_Click_1);
            // 
            // ventanaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1343, 789);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.msVentanaP);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.msVentanaP;
            this.Name = "ventanaPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ventana Principal";
            this.Load += new System.EventHandler(this.ventanaPrincipal_Load);
            this.msVentanaP.ResumeLayout(false);
            this.msVentanaP.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip msVentanaP;
        private ToolStripMenuItem abrirModulosToolStripMenuItem;
        private ToolStripMenuItem modulo1ToolStripMenuItem;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel tssNombre;
        private ToolStripStatusLabel tssNombreI;
        private ToolStripMenuItem cerrarTodosLosModulosToolStripMenuItem;
        private ToolStripMenuItem modulo2ToolStripMenuItem;
    }
}