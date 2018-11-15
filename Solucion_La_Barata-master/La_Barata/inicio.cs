using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace La_Barata
{
    public partial class inicio : Form
    {
        public inicio()
        {
            InitializeComponent();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            pictureBox6.Visible = true;
            pictureBox5.Visible = false;
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            pictureBox6.Visible = false;
            pictureBox5.Visible = true;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }


        private void AbrirFormInPanel(object Formhijo)
        {
            if (this.panelContenerdo.Controls.Count > 0)
                this.panelContenerdo.Controls.RemoveAt(0);
            Form fh = Formhijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panelContenerdo.Controls.Add(fh);
            this.panelContenerdo.Tag = fh;
            fh.Show();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnVenta_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new Ventas());
        }

        private void btnOferta_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new Ofertas());
        }

        private void btnInventario_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new Inventario());
        }

        private void btnRecortes_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new Recortescs());
        }

        private void btnRegistro_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new Registro());
        }

        private void panelContenerdo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox5_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            pictureBox6.Visible = true;
            pictureBox5.Visible = false;
        }

        private void pictureBox4_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox3_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox6_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            pictureBox6.Visible = false;
            pictureBox5.Visible = true;
        }
    }
}
