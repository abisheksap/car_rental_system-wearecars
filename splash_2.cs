using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// Name: Abishek Sapkota Sharma
// Student ID: bj19le
namespace last_try
{
    public partial class splash_2 : Form
    {
        public splash_2()
        {
            InitializeComponent();
    
        }
        private void splash_2_Load(object sender, EventArgs e)
        {
            timer2.Start();
           
        }   

        private void timer2_Tick_1(object sender, EventArgs e)
        {
            timer2.Stop();
            Options op = new Options();
            op.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

    }

}
