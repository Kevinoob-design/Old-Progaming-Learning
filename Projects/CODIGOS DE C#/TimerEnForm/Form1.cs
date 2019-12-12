using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimerEnForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            lblhora.Text = DateTime.Now.ToLongTimeString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblhora.Text = DateTime.Now.ToLongTimeString();
        }

        private int Num = 0;

        private void timer2_Tick(object sender, EventArgs e)
        {
            Num = Num + 1;
            if(Num % 2 == 0)
            {
                lbla.Visible = true;
                lblb.Visible = false;
            }
            else
            {
                lbla.Visible = false;
                lblb.Visible = true;
            }
        }

        private void btnplay_Click(object sender, EventArgs e)
        {
            timer2.Enabled = true;
        }

        private void btnstop_Click(object sender, EventArgs e)
        {
            timer2.Enabled = false;
        }
    }
}
