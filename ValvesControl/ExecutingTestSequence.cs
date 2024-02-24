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
        bool pause = false;

        public ExecutingTestSequence(SerialPort serialPort)
        {
            InitializeComponent();
            this.serialPort = serialPort;
            closeButton.Hide();
        }

        public void ShowTestCommand(Test test)
        {
            this.BeginInvoke(new Action(() => statusLabel.Text = "Status: Executing"));
            this.BeginInvoke(new Action(() => commandLabel.Text = "Command: " + test.shortCircuitType
                + " to " + test.valveName + " for " + test.time + " miliseconds"));

            this.BeginInvoke(new Action(() => progressBar1.Value = 0));
            this.BeginInvoke(new Action(() => progressBar1.Maximum = test.time));

            for (int i = 0; i < progressBar1.Maximum; i += 100)
            {
                Thread.Sleep(100);
                while (pause) { }
                this.BeginInvoke(new Action(() => progressBar1.Value = i));
            }

            this.BeginInvoke(new Action(() => numberOfCommandsExecutedLabel.Text = 
                (int.Parse(numberOfCommandsExecutedLabel.Text) + 1).ToString()));
        }

        public void TestSequenceDone()
        {
            this.BeginInvoke(new Action(() => statusLabel.Text = "Status: Finished"));
            this.BeginInvoke(new Action(() => pauseButton.Hide()));
            this.BeginInvoke(new Action(() => cancelButton.Hide()));
            this.BeginInvoke(new Action(() => closeButton.Show()));
        }

        
        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PauseButton_Click(object sender, EventArgs e)
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

        private void CancelButton_Click(object sender, EventArgs e)
        {
            serialPort.WriteLine("cancel");
            TestSequenceDone();
        }

        private void cancelButton_MouseHover(object sender, EventArgs e)
        {
            cancelButton.BackColor = Color.PaleTurquoise;
        }

        private void pauseButton_MouseHover(object sender, EventArgs e)
        {
            pauseButton.BackColor = Color.PaleTurquoise;
        }

        private void closeButton_MouseHover(object sender, EventArgs e)
        {
            closeButton.BackColor = Color.PaleTurquoise;
        }
    }
}
