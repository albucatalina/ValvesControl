using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ValvesControl
{
    public partial class ExecutingTestSequence : Form
    {
        
        SerialPort serialPort;
        System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
        int totalTime = 3000;
        int interval = 50;
        int progress =0;
        bool pause = false;

        public ExecutingTestSequence(SerialPort serialPort)
        {
            InitializeComponent();
            this.serialPort = serialPort;
            closeButton.Hide();
            timer.Interval = interval;
            
           // timer.Tick += new EventHandler(IncreaseProgressBar);
        }

        private void IncreaseProgressBar(object sender, EventArgs e)
        {
            this.BeginInvoke(new Action(() => progressBar1.Increment(1)));
            if(progressBar1.Value == progressBar1.Maximum)
            {
                this.BeginInvoke(new Action(() => timer.Stop()));

            }
           /* progress += interval;
            //progressBar1.Increment(1);
            this.BeginInvoke(new Action(() => progressBar1.Value = (int)((progress / (double)totalTime) * progressBar1.Maximum)));

            if (progress > totalTime)
            {
                this.BeginInvoke(new Action(() => timer.Stop()));
                //timer.Stop();
                //MessageBox.Show("completed");
            }*/
           
        }


        public void ShowTestCommand(Test test)
        {
            this.BeginInvoke(new Action(() => statusLabel.Text = "Status: Executing"));
            this.BeginInvoke(new Action(() => commandLabel.Text = "Command: " + test.shortCircuitType + " to " + test.valve + " for " + test.time + " miliseconds"));

            

            MethodInvoker m = new MethodInvoker(() => progressBar1.Value = 0);
            progressBar1.Invoke(m);

            
            m = new MethodInvoker(() => progressBar1.Maximum = test.time);
            progressBar1.Invoke(m);

            for (int i = 0; i < progressBar1.Maximum; i += 100)
            {
                Thread.Sleep(100);
                while (pause) { }
                this.BeginInvoke(new Action(() => progressBar1.Value = i));
                Console.WriteLine(progressBar1.Value);
            }

            m = new MethodInvoker(() => numberOfCommandsExecutedLabel.Text = (int.Parse(numberOfCommandsExecutedLabel.Text) + 1).ToString());
            numberOfCommandsExecutedLabel.Invoke(m);
        }

        public void TestSequenceDone()
        {
            this.BeginInvoke(new Action(() => statusLabel.Text = "Status: Finished"));
            this.BeginInvoke(new Action(() => pauseButton.Hide()));
            this.BeginInvoke(new Action(() => cancelButton.Hide()));
            this.BeginInvoke(new Action(() => closeButton.Show()));
        }

        
        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pauseButton_Click(object sender, EventArgs e)
        {
            if (pauseButton.Text == "Pause")
            {
                pause = true;
                serialPort.WriteLine("pause");
                pauseButton.Text = "Resume";
                statusLabel.Text = "Status: Paused";
                
            }
            else
            {
                pause = false;
                serialPort.WriteLine("resume");
                pauseButton.Text = "Pause";
                
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            serialPort.WriteLine("cancel");
            TestSequenceDone();
        }
    }
}
