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
    public partial class Publish : Form
    {
        public Publish()
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

        private void pb_maximize_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void pb_logout_Click(object sender, EventArgs e)
        {
            Login page = new Login();
            page.Show();
            this.Hide();
        }

        private void btn_write_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Text Files|*.txt";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                StreamWriter s = new StreamWriter(sfd.FileName);
                s.Write(tb_publish.Text);
                s.Close();
                MessageBox.Show("You write are published", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btn_open_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                StreamReader st = new StreamReader(ofd.FileName);
                tb_publish.Text = st.ReadToEnd();
                st.Close();
            }
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            tb_publish.Clear();
        }
    }
}
