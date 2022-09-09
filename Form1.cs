using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formulario6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void usuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 usuario = new Form3();
            usuario.MdiParent = this;
            usuario.Show();
        }

        private void herramientasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 Tornilleria= new Form2();
            Tornilleria.MdiParent = this;
            Tornilleria.Show();
        }

        private void pinturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 Pintura = new Form4();
            Pintura.MdiParent = this;
            Pintura.Show();
        }

        private void ventanasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form5 Ventanas = new Form5();
            Ventanas.MdiParent = this;
            Ventanas.Show();
        }

        private void clavosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form6 Clavos = new Form6();
            Clavos.MdiParent = this;
            Clavos.Show();
        }

        private void herramientasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form7 Herramientas = new Form7();
            Herramientas.MdiParent = this;
            Herramientas.Show();
        }

        private void equiposToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form8 Equipos = new Form8();
            Equipos.MdiParent = this;
            Equipos.Show();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void productosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
