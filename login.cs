using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// Name: Abishek Sapkota Sharma
// Student ID: bj19le
namespace last_try 
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void showpass_chk_CheckedChanged(object sender, EventArgs e)
        {
            if (showpass_chk.Checked == true)
            {
                password_txt.UseSystemPasswordChar = false;
            }
            else
            {
                password_txt.UseSystemPasswordChar = true;
            }
        }
        int Counter = 0;
        private void Button1_Click(object sender, EventArgs e)
        {
            if (Username_txt.Text == "sta001" && password_txt.Text == "givemethekeys123")
            {
                splash_2 f3 = new splash_2();
                f3.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid Credentials", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Counter++;
                if (Counter == 5)
                {
                    MessageBox.Show(" Too Many Attemmts");
                    this.Close();
                }

            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are you sure you want to exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                Close();
                this.Hide();
            }
            else
            {
                return;
            }
        }

        private void login_Load(object sender, EventArgs e)
        {

        }

        private void login_Load_1(object sender, EventArgs e)
        {

        }
    }
}
