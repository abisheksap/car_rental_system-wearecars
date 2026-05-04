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
    public partial class splash_1 : Form
    {
        public splash_1()
        {
            InitializeComponent();
        }
        private void splash_1_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }   
        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            login lg = new login();
            lg.Show();
            this.Hide();    

        }
    }
}
