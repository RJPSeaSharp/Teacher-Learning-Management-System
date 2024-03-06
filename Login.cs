using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignemt_4._3
{
    public partial class Form1Login : Form
    {
        public Form1Login()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtUserName_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUserName.Text == "Teacher" && txtPassword.Text == "Admin")
            {
                new LMS().Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("The User name or password you entered is incorrect, try again");
                txtUserName.Clear();
                txtPassword.Clear();
                txtUserName.Focus();
            }
        }

        private void Form1Login_Load(object sender, EventArgs e)
        {

        }

        private void lblPassword_Click(object sender, EventArgs e)
        {

        }
    }
}
