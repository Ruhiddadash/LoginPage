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
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }
        private void pb_minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void lbl_have_Click(object sender, EventArgs e)
        {
            Login page = new Login();
            page.Show();
            this.Hide();
        }

        private void btn_signup_Click(object sender, EventArgs e)
        {
            if(tb_password.Text == tb_passconfirm.Text)
            {
                StreamWriter sw = new StreamWriter("Database.txt");
                sw.WriteLine(tb_username.Text); 
                sw.WriteLine(tb_email.Text);
                sw.WriteLine(tb_password.Text);

                sw.Close();

                Login page = new Login();
                page.Show();
                this.Hide();
            }

            else
            {
                MessageBox.Show("Password not the same", "Try Again", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cb_showpass_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_showpass.Checked)
            {
                tb_password.PasswordChar = '\0';
                tb_passconfirm.PasswordChar = '\0';
            }
            else
            {
                tb_password.PasswordChar = '•';
                tb_passconfirm.PasswordChar = '•';
            }
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            tb_username.Clear();
            tb_email.Clear();
            tb_password.Clear();
            tb_passconfirm.Clear();
        }

        private void pb_close_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

    }
}
