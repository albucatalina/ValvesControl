using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.Threading;

namespace ValvesControl
{
    public partial class ValvesControl : Form
    {
        static SerialPort port = new SerialPort("COM3", 9600, Parity.None, 8, StopBits.One);
        Thread thread;
        static string response = "";


        private void Listen()
        {
            MethodInvoker m;
            while (true)
            {
                response = port.ReadLine();
                if (response != "")
                {
                    Console.WriteLine("Arduino response " + response);
                    m = new MethodInvoker(() => consoleTextBox.Text += "Arduino response: " + response + Environment.NewLine);
                    consoleTextBox.Invoke(m);
                   
                }
            }
        }

        public ValvesControl()
        {
            InitializeComponent();
            
            port.Open();
            thread = new Thread(Listen);
            thread.Start();
            
        }

        private void testButton_Click(object sender, EventArgs e)
        {
            port.Write(testTextBox.Text);
        }

        private void ValvesControl_FormClosed(object sender, FormClosedEventArgs e)
        {
            port.Close();
            thread.Abort();
        }
    }
}
