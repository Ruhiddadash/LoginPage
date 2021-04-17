using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginPage
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void pb_close_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void pb_minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void lbl_dont_Click(object sender, EventArgs e)
        {
            Register page = new Register();
            page.Show();
            this.Hide();
        }

        private void btn_signup_Click(object sender, EventArgs e)
        {
            string file = "Database.txt";
            string username = File.ReadLines(file).First();
            string password = File.ReadLines(file).Last();


            if (username == tb_username.Text && password == tb_password.Text)
            {
                Publish page = new Publish();
                page.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Username or Password is wrong!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void cb_showpass_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_showpass.Checked)
            {
                tb_password.PasswordChar = '\0';
            }
            else
            {
                tb_password.PasswordChar = '•';
            }
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            tb_username.Clear();    
            tb_password.Clear();
        }
    }
}
