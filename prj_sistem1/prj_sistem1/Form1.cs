using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prj_sistem1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BTNstart_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled)
            {
               
                timer1.Enabled = false; // Stop timer if it's currently running
            }
            else
            {
               
                timer1.Enabled = true;  // Start timer if it's currently stopped
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value < 100)  // Update progress bar if value is less than 100
                progressBar1.Value++;
            else
            {
                timer1.Enabled = false; // Stop timer if it's currently running
                Form frm = new Form2(); // Stop timer and show a new form (Form2) upon reaching max progress
                frm.Show();

            }
        }
    }
}
