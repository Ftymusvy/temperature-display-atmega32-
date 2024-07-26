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
    public partial class Form2 : Form
    {
        string data;  // String variable to store data received from serial port
        public Form2()
        {
            InitializeComponent();

            // Create an ASCII encoding object for serial port communication
            System.Text.ASCIIEncoding aSCII = new ASCIIEncoding();
            serialPort1.Encoding = aSCII;
        }

        private void exitBTN_Click(object sender, EventArgs e)
        {
            Application.Exit();  // Close the application
        }

        private void STbtn_Click(object sender, EventArgs e)
        {
            serialPort1.PortName = "COM6"; // Configure serial port settings
            serialPort1.Open();

            // Disable start button and enable stop button
            STbtn.Enabled = false;
            stopBTN.Enabled = true;

            timer1.Enabled = true;  // Start timer for reading data
        }

        private void stopBTN_Click(object sender, EventArgs e)
        {
            serialPort1.Close();
            STbtn.Enabled = true;
            stopBTN.Enabled = false;

        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (serialPort1.IsOpen)   // Check if serial port is open before closing
                serialPort1.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Degreelbl.Text = data;  // Update label with received data
        }

        private void serialPort1_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            data = serialPort1.ReadLine().ToString(); // Read data from serial port and store it in the 'data' variable
        }
    }
}
