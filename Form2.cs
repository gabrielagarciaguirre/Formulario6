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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form3 Tornilleria = new Form3();
            
            Tornilleria.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Compra exitosa", "CasaCenter");
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Compra exitosa", "CasaCenter");
            this.Close();
        }
    }
}
