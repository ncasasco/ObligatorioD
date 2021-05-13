using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserInterface
{
    public partial class VentanaGestor : Form
    {
        public VentanaGestor()
        {
            InitializeComponent();
            categoriasView1.Hide();
            contrasenasView1.Hide();
            tarjetasView1.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            categoriasView1.Show();
            contrasenasView1.Hide();
            tarjetasView1.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            categoriasView1.Hide();
            contrasenasView1.Show();
            tarjetasView1.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            categoriasView1.Hide();
            contrasenasView1.Hide();
            tarjetasView1.Show();
        }
    }
}
