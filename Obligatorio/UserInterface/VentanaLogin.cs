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
    public partial class VentanaLogin : Form
    {
        public VentanaLogin()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if(txtUser.Text == "123" && txtPassword.Text == "123")
            {

            }
            else
            {
                MessageBox.Show("El usuario o contraseña son incorrectos. Inténtalo de nuevo.");
                txtUser.Text = "";
                txtPassword.Text = "";
                txtUser.Focus();
            }
        }
    }
}
