using static System.Net.Mime.MediaTypeNames;
using System.Windows.Forms;

namespace Trabajo_final_Front_End
{
    public partial class ventanaPrincipal : Form
    {
        private lbImagen modulo1;
        private Modulo2 modulo2;
        private Modulo3 modulo3;
        private Modulo4 modulo4;    
        private Modulo5 modulo5;
        private Modulo6 modulo6;
        private Modulo7 modulo7;
        private Modulo8 modulo8;
        private Modulo9 modulo9;
        private Modulo10 modulo10;
        private Modulo11 modulo11;
        private Modulo12 modulo12;
        private Modulo13 modulo13;
        private Modulo14 modulo14;
        public ventanaPrincipal()
        {
            InitializeComponent();
        }

       
        private void ventanaPrincipal_Load(object sender, EventArgs e)
        {
            tssNombreI.Text = "Di Pane";
        }

        private void modulo1ToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (modulo1 == null)
            {
                modulo1 = new lbImagen();
                modulo1.MdiParent = this;
                modulo1.FormClosed += new FormClosedEventHandler(cerrarModulo1);
                modulo1.Show();
            }
            else
            {
                modulo1.Activate();
            }
        }

        private void modulo2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (modulo2 == null)
            {
                modulo2 = new Modulo2();
                modulo2.MdiParent = this;
                modulo2.FormClosed += new FormClosedEventHandler(cerrarModulo2);
                modulo2.Show();
            }
            else
            {
                modulo2.Activate();
            }
        }
        private void modulo3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (modulo3 == null)
            {
                modulo3 = new Modulo3();
                modulo3.MdiParent = this;
                modulo3.FormClosed += new FormClosedEventHandler(cerrarModulo3);
                modulo3.Show();
            }
            else
            {
                modulo3.Activate();
            }
        }
        private void modulo4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (modulo4 == null)
            {
                modulo4 = new Modulo4();
                modulo4.MdiParent = this;
                modulo4.FormClosed += new FormClosedEventHandler(cerrarModulo4);
                modulo4.Show();
            }
            else
            {
                modulo4.Activate();
            }
        }
        private void modulo5ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (modulo5 == null)
            {
                modulo5 = new Modulo5();
                modulo5.MdiParent = this;
                modulo5.FormClosed += new FormClosedEventHandler(cerrarModulo5);
                modulo5.Show();
            }
            else
            {
                modulo5.Activate();
            }
        }
        private void modulo6ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (modulo6 == null)
            {
                modulo6 = new Modulo6();
                modulo6.MdiParent = this;
                modulo6.FormClosed += new FormClosedEventHandler(cerrarModulo6);
                modulo6.Show();
            }
            else
            {
                modulo6.Activate();
            }
        }

        private void modulo7ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (modulo7 == null)
            {
                modulo7 = new Modulo7();
                modulo7.MdiParent = this;
                modulo7.FormClosed += new FormClosedEventHandler(cerrarModulo7);
                modulo7.Show();
            }
            else
            {
                modulo7.Activate();
            }
        }

        private void modulo8ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (modulo8 == null)
            {
                modulo8 = new Modulo8();
                modulo8.MdiParent = this;
                modulo8.FormClosed += new FormClosedEventHandler(cerrarModulo8);
                modulo8.Show();
            }
            else
            {
                modulo8.Activate();
            }
        }

        private void modulo9ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (modulo9 == null)
            {
                modulo9 = new Modulo9();
                modulo9.MdiParent = this;
                modulo9.FormClosed += new FormClosedEventHandler(cerrarModulo9);
                modulo9.Show();
            }
            else
            {
                modulo9.Activate();
            }
        }

        private void modulo10ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (modulo10 == null)
            {
                modulo10 = new Modulo10();
                modulo10.MdiParent = this;
                modulo10.FormClosed += new FormClosedEventHandler(cerrarModulo10);
                modulo10.Show();
            }
            else
            {
                modulo10.Activate();
            }
        }

        private void modulo11ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (modulo11 == null)
            {
                modulo11 = new Modulo11();
                modulo11.MdiParent = this;
                modulo11.FormClosed += new FormClosedEventHandler(cerrarModulo11);
                modulo11.Show();
            }
            else
            {
                modulo11.Activate();
            }
        }

        private void modulo12ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (modulo12 == null)
            {
                modulo12 = new Modulo12();
                modulo12.MdiParent = this;
                modulo12.FormClosed += new FormClosedEventHandler(cerrarModulo12);
                modulo12.Show();
            }
            else
            {
                modulo12.Activate();
            }
        }

        private void modulo13ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (modulo13 == null)
            {
                modulo13 = new Modulo13();
                modulo13.MdiParent = this;
                modulo13.FormClosed += new FormClosedEventHandler(cerrarModulo13);
                modulo13.Show();
            }
            else
            {
                modulo13.Activate();
            }
        }

        private void modulo14ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (modulo14 == null)
            {
                modulo14 = new Modulo14();
                modulo14.MdiParent = this;
                modulo14.FormClosed += new FormClosedEventHandler(cerrarModulo14);
                modulo14.Show();
            }
            else
            {
                modulo14.Activate();
            }
        }


        void cerrarModulo1(object sender, EventArgs e)
        {
            modulo1 = null;
        }
        void cerrarModulo2(object sender, EventArgs e)
        {
            modulo2 = null;
        }
        void cerrarModulo3(object sender, EventArgs e)
        {
            modulo3 = null;
        }
        void cerrarModulo4(object sender, EventArgs e)
        {
            modulo4 = null;
        }
        void cerrarModulo5(object sender, EventArgs e)
        {
            modulo5 = null;
        }
        void cerrarModulo6(object sender, EventArgs e)
        {
            modulo6 = null;
        }
        void cerrarModulo7(object sender, EventArgs e)
        {
            modulo7 = null;
        }
        void cerrarModulo8(object sender, EventArgs e)
        {
            modulo8 = null;
        }
        void cerrarModulo9(object sender, EventArgs e)
        {
            modulo9 = null;
        }
        void cerrarModulo10(object sender, EventArgs e)
        {
            modulo10 = null;
        }
        void cerrarModulo11(object sender, EventArgs e)
        {
            modulo11 = null;
        }
        void cerrarModulo12(object sender, EventArgs e)
        {
            modulo12 = null;
        }
        void cerrarModulo13(object sender, EventArgs e)
        {
            modulo13 = null;
        }
        void cerrarModulo14(object sender, EventArgs e)
        {
            modulo14 = null;
        }

        private void cerrarTodosLosModulosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                modulo1.Close();
                modulo2.Close();
                modulo3.Close();
                modulo4.Close();
                modulo5.Close();
                modulo6.Close();    
                modulo7.Close();    
                modulo8.Close();
                modulo9.Close();
                modulo10.Close();
                modulo11.Close();
                modulo12.Close();
                modulo13.Close();
                modulo14.Close();
            }
            catch
            {

            }
        }
    }
}