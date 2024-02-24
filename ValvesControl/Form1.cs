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
using System.IO;

public struct Test
{
    public string valveName;
    public string shortCircuitType;
    public int time;
}

namespace ValvesControl
{
    public partial class ValvesControl : Form
    {
        static SerialPort serialPort;
        string portName = null;
        
        ExecutingTestSequence executingTestSequenceForm;

        readonly string dataGridViewValveColumnName = "Valve";
        readonly string dataGridViewShortTypeColumnName = "Short Type";
        readonly string dataGridViewTimeColumnName = "Time [ms]";
        readonly string dataGridViewRunTestColumnName = "Run";

        readonly List<string> valveNames;
        readonly List<string> shortCircuitTypes;


        public ValvesControl()
        {
            InitializeComponent();

            valveNames = new List<string>() { "-select-" };
            shortCircuitTypes = new List<string>() { "-select-" };

            GetDataGridViewInformationFromFile();

            DataGridViewConfiguration();

            if (toolStripStatusLabel1.Text == "")
            {
                toolStripStatusLabel1.Text = "Not connected. Please select a port to connect automatically";
                statusStrip1.BackColor = Color.Yellow;
            }

            if(valveNames.Count() > 0)
            {
                valve1GroupBox.Text = valveNames[1];
                valve2GroupBox.Text = valveNames[2];
                valve3GroupBox.Text = valveNames[3];
                valve4GroupBox.Text = valveNames[4];
            }
        }

        private void GetDataGridViewInformationFromFile()
        {
            string valveNamesFilePath = "..\\..\\..\\Resources\\ValveNames.txt";
            string shortCircuitTypesFilePath = "..\\..\\..\\Resources\\ShortCircuitTypes.txt";

            try
            {
                using (StreamReader streamReader = new StreamReader(valveNamesFilePath))
                {
                    string line;
                    while ((line = streamReader.ReadLine()) != null)
                    {
                        valveNames.Add(line);
                    }
                }
            }
            catch (FileNotFoundException ex)
            {
                MessageBox.Show(ex.Message);
            }

            try
            {
                using (StreamReader streamReader = new StreamReader(shortCircuitTypesFilePath))
                {
                    string line;
                    while ((line = streamReader.ReadLine()) != null)
                    {
                        shortCircuitTypes.Add(line);
                    }
                }
            }
            catch (FileNotFoundException ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void PortClickEvent(object sender, EventArgs e)
        {
            portName = (sender as ToolStripMenuItem).Text;
            try
            {
                serialPort = new SerialPort(portName, 9600, Parity.None, 8, StopBits.One);
                serialPort.Open();
                serialPort.DiscardInBuffer();
                serialPort.DataReceived += new SerialDataReceivedEventHandler(DataReceivedHandler);
                toolStripStatusLabel1.Text = "Connected     Port: " + portName;
                statusStrip1.BackColor = Color.Green;
            }
            catch (Exception)
            {
                toolStripStatusLabel1.Text = "Connection Failed";
                statusStrip1.BackColor = Color.Red;
            }
        }

        private void DataReceivedHandler(object sender, SerialDataReceivedEventArgs e)
        {
            SerialPort serialPort = (SerialPort)sender;
            string response = serialPort.ReadLine();
            if (response != "")
            {
                if (response.StartsWith("executing"))
                {
                    Test test = GetTestFromExecutingMessage(response.Substring(response.IndexOf('$') + 1));
                    this.BeginInvoke(new Action(() => consoleTextBox.Text += "Executing command: " + 
                        test.shortCircuitType + " to " + test.valveName + " for " + test.time + 
                        " miliseconds" + Environment.NewLine));
                    executingTestSequenceForm.ShowTestCommand(test);
                }
                if (response.StartsWith("done"))
                {
                    executingTestSequenceForm.TestSequenceDone();
                    this.BeginInvoke(new Action(() => consoleTextBox.Text += "Command executed successfully!" 
                        + Environment.NewLine));
                }
                if (response.StartsWith("current"))
                {
                    int index = response.IndexOf("$");
                    response = response.Substring(index + 1);
                    index = response.IndexOf("$");
                    int valveId = int.Parse(response.Substring(0, index));
                    string value = response.Substring(index + 1);
                    ShowCurrentValue(valveId, value);
                }
                if (response.StartsWith("voltage"))
                {
                    int index = response.IndexOf("$");
                    response = response.Substring(index + 1);
                    index = response.IndexOf("$");
                    int valveId = int.Parse(response.Substring(0, index));
                    string value = response.Substring(index + 1);
                    ShowVoltageValue(valveId, value);
                }
                if (response.StartsWith("error"))
                {
                    this.BeginInvoke(new Action(() => consoleLabel.Text += 
                        response.Substring(response.IndexOf('$') + 1) + Environment.NewLine));
                }
                Console.WriteLine("Arduino response: " + response);
            }
        }

        private void ShowCurrentValue(int valveId, string currentValue)
        {
            switch(valveId)
            {
                case 1:
                    this.BeginInvoke(new Action(() => valve1CurrentTextBox.Text = currentValue + "A"));
                    break;
                case 2:
                    this.BeginInvoke(new Action(() => valve2CurrentTextBox.Text = currentValue + "A"));
                    break;
                case 3:
                    this.BeginInvoke(new Action(() => valve3CurrentTextBox.Text = currentValue + "A"));
                    break;
                case 4:
                    this.BeginInvoke(new Action(() => valve4CurrentTextBox.Text = currentValue + "A"));
                    break;
                default:
                    break;
            }
        }

        private void ShowVoltageValue(int valveId, string voltageValue)
        {
            switch (valveId)
            {
                case 1:
                    this.BeginInvoke(new Action(() => valve1VoltageTextBox.Text = voltageValue + "V"));
                    break;
                case 2:
                    this.BeginInvoke(new Action(() => valve2VoltageTextBox.Text = voltageValue + "V"));
                    break;
                case 3:
                    this.BeginInvoke(new Action(() => valve3VoltageTextBox.Text = voltageValue + "V"));
                    break;
                case 4:
                    this.BeginInvoke(new Action(() => valve4VoltageTextBox.Text = voltageValue + "V"));
                    break;
                default:
                    break;
            }
        }

        private Test GetTestFromExecutingMessage(string response)
        {
            Test test;
            int index = response.IndexOf('$');
            int valveId = int.Parse(response.Substring(0, index));
            test.valveName = valveNames[valveId];

            response = response.Substring(index + 1);
            index = response.IndexOf('$');
            int shortCircuitTypeId = int.Parse(response.Substring(0, index));
            test.shortCircuitType = shortCircuitTypes[shortCircuitTypeId];

            test.time = int.Parse(response.Substring(index + 1));

           // this.BeginInvoke(new Action(() => consoleTextBox.Text += test.valveName + "-" + test.shortCircuitType + "-" + test.time + Environment.NewLine));
            Console.WriteLine(test.valveName + "-" + test.shortCircuitType + "-" + test.time);

            return test;
        }

        private void DataGridViewConfiguration()
        {

            DataGridViewComboBoxColumn valveComboBoxColumn = new DataGridViewComboBoxColumn();
            valveComboBoxColumn.DataSource = valveNames;
            valveComboBoxColumn.AutoComplete = true;
            valveComboBoxColumn.DataPropertyName = dataGridViewValveColumnName;
            valveComboBoxColumn.Name = dataGridViewValveColumnName;
            valveComboBoxColumn.HeaderText = dataGridViewValveColumnName;
            dataGridViewTestConfig.Columns.Add(valveComboBoxColumn);
            dataGridViewTestConfig.Rows[0].Cells[dataGridViewValveColumnName].Value = 
                ((DataGridViewComboBoxCell)dataGridViewTestConfig.Rows[0].Cells[dataGridViewValveColumnName]).Items[0];

            DataGridViewComboBoxColumn shortTypeComboBoxColumn = new DataGridViewComboBoxColumn();
            shortTypeComboBoxColumn.DataSource = shortCircuitTypes;
            shortTypeComboBoxColumn.AutoComplete = true;
            shortTypeComboBoxColumn.DataPropertyName = dataGridViewShortTypeColumnName;
            shortTypeComboBoxColumn.Name = dataGridViewShortTypeColumnName;
            shortTypeComboBoxColumn.HeaderText = dataGridViewShortTypeColumnName;
            dataGridViewTestConfig.Columns.Add(shortTypeComboBoxColumn);
            dataGridViewTestConfig.Rows[0].Cells[dataGridViewShortTypeColumnName].Value = ((DataGridViewComboBoxCell)dataGridViewTestConfig.Rows[0].Cells[dataGridViewShortTypeColumnName]).Items[0];

            DataGridViewTextBoxColumn timeTextBoxColumn = new DataGridViewTextBoxColumn();
            timeTextBoxColumn.DataPropertyName = dataGridViewTimeColumnName;
            timeTextBoxColumn.Name = dataGridViewTimeColumnName;
            timeTextBoxColumn.HeaderText = dataGridViewTimeColumnName;
            dataGridViewTestConfig.Columns.Add(timeTextBoxColumn);
            dataGridViewTestConfig.Rows[0].Cells[dataGridViewTimeColumnName].Value = 0;

            DataGridViewButtonColumn runTestButtonColumn = new DataGridViewButtonColumn();
            runTestButtonColumn.DataPropertyName = dataGridViewRunTestColumnName;
            runTestButtonColumn.Name = dataGridViewRunTestColumnName;
            runTestButtonColumn.HeaderText = dataGridViewRunTestColumnName;
            dataGridViewTestConfig.Columns.Add(runTestButtonColumn);

        }

        private void ValvesControl_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (toolStripStatusLabel1.Text.Contains("Connected"))
                serialPort.Close();
        }

        private void clearConsoleButton_Click(object sender, EventArgs e)
        {
            consoleTextBox.Clear();
        }

        private void DataGridViewTestConfig_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                if (toolStripStatusLabel1.Text.Contains("Connected"))
                {
                    if (IsDataGridViewRowValid(dataGridViewTestConfig.Rows[e.RowIndex]))
                    {
                        
                        Test test = GetTestFromDataGridViewRow(dataGridViewTestConfig.Rows[e.RowIndex]);
                        SendMessageToArduino(test);
                        executingTestSequenceForm = new ExecutingTestSequence(serialPort);
                        executingTestSequenceForm.Show();                        
                    }
                    else
                        MessageBox.Show("Some values are incorrect!");
                }
                else
                    MessageBox.Show("Not Connected");
            }
        }

        private void SendMessageToArduino(Test test)
        {
            int valveId = valveNames.FindIndex(name => name == test.valveName);
            int shortCircuitTypeId = shortCircuitTypes.FindIndex(shortType => shortType == test.shortCircuitType);
            int time = test.time;
            serialPort.WriteLine("test$" + valveId + "$" + shortCircuitTypeId + "$" + time);
        }

        private void SendMessageToArduino(List<Test> testSequence, int repetitions)
        {
            string messageToSend = "testSequence$" + repetitions + "$";
            int valveId, shortCircuitTypeId, time;
            foreach (Test test in testSequence)
            {
                valveId = valveNames.FindIndex(name => name == test.valveName);
                shortCircuitTypeId = shortCircuitTypes.FindIndex(shortType => shortType == test.shortCircuitType);
                time = test.time;
                messageToSend += "<" + valveId + "$" + shortCircuitTypeId + "$" + time + ">";
            }
            serialPort.WriteLine(messageToSend);
        }

        private void dataGridViewTestConfig_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            if (e.RowIndex != 0)
            {
                {
                    if (dataGridViewTestConfig.Rows[e.RowIndex].Cells[dataGridViewValveColumnName] is DataGridViewComboBoxCell comboBoxCell)
                    {
                        comboBoxCell.Value = comboBoxCell.Items[0]; // Set the first item as the default value

                    }

                    if (dataGridViewTestConfig.Rows[e.RowIndex].Cells[dataGridViewShortTypeColumnName] is DataGridViewComboBoxCell comboBoxCell1)
                    {
                        comboBoxCell1.Value = comboBoxCell1.Items[0]; // Set the first item as the default value
                    }

                    if (dataGridViewTestConfig.Rows[e.RowIndex].Cells[dataGridViewTimeColumnName] is DataGridViewTextBoxCell textBoxCell)
                    {
                        textBoxCell.Value = 0;
                    }
                }
            }
        }

        private bool IsDataGridViewRowValid(DataGridViewRow dataGridViewRow)
        {
            if (dataGridViewRow.Cells[dataGridViewValveColumnName].Value.ToString() == valveNames[0])
                return false;
            if (dataGridViewRow.Cells[dataGridViewShortTypeColumnName].Value.ToString() == shortCircuitTypes[0])
                return false;
            if (dataGridViewRow.Cells[dataGridViewTimeColumnName].Value.ToString() == "0")
                return false;
            return int.TryParse(dataGridViewRow.Cells[dataGridViewTimeColumnName].Value.ToString(), out _);

        }

        private bool AreDataGridViewAllRowsValid()
        {
            if (dataGridViewTestConfig.RowCount == 0)
                return false;
            for (int i = 0; i < dataGridViewTestConfig.RowCount - 1; i++)
                if (!IsDataGridViewRowValid(dataGridViewTestConfig.Rows[i]))
                    return false;
            return true;
        }

        private void StartTestButton_Click(object sender, EventArgs e)
        {
            if (toolStripStatusLabel1.Text.Contains("Connected"))
            {
                if (AreDataGridViewAllRowsValid())
                {
                    List<Test> tests = new List<Test>();
                    Test test;
                    for (int i = 0; i < dataGridViewTestConfig.RowCount - 1; i++)
                    {
                        test = GetTestFromDataGridViewRow(dataGridViewTestConfig.Rows[i]);
                        tests.Add(test);
                    }
                    SendMessageToArduino(tests, (int)repeatNumericUpDown.Value);

                    executingTestSequenceForm = new ExecutingTestSequence(serialPort);
                    executingTestSequenceForm.Show();

                }
                else
                    MessageBox.Show("Some values are incorrect!");
            }
            else
                MessageBox.Show("Please select a port from menu");
        }

        
        private Test GetTestFromDataGridViewRow(DataGridViewRow dataGridViewRow)
        {
            Test t;
            t.valveName = dataGridViewRow.Cells[dataGridViewValveColumnName].Value.ToString();
            t.shortCircuitType = dataGridViewRow.Cells[dataGridViewShortTypeColumnName].Value.ToString();
            t.time = int.Parse(dataGridViewRow.Cells[dataGridViewTimeColumnName].Value.ToString());
            return t;
        }

        private void DataGridViewTestConfig_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            if (dataGridViewTestConfig.Columns[e.ColumnIndex] is DataGridViewTextBoxColumn)
            {
                if (!int.TryParse(e.FormattedValue?.ToString(), out _))
                {
                    MessageBox.Show("Please enter a valid integer value");
                }
            }
        }

        private void PortsToolStripMenuItem_MouseEnter(object sender, EventArgs e)
        {
            portsToolStripMenuItem.DropDownItems.Clear();
            string[] availablePorts = SerialPort.GetPortNames();
            if (availablePorts.Length == 0)
            {
                portsToolStripMenuItem.DropDownItems.Add("no ports");
            }
            else
            {
                foreach (string port in availablePorts)
                {
                    Console.WriteLine(port);

                    portsToolStripMenuItem.DropDownItems.Add(port, null, PortClickEvent);
                }
            }
        }

        private void OpenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*",
                Title = "Open configuration"
            };
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                if (dataGridViewTestConfig.RowCount > 1)
                    dataGridViewTestConfig.Rows.Clear();

                using (StreamReader streamReader = new StreamReader(openFileDialog.FileName))
                {
                    string[] lines = streamReader.ReadToEnd()
                        .Split(new[] { Environment.NewLine }, StringSplitOptions.None);

                    for (int i = 0; i < lines.Length - 1; i++)
                        dataGridViewTestConfig.Rows.Add();
                    for (int i = 0; i < dataGridViewTestConfig.RowCount - 1; i++)
                    {
                        Test test;
                        string[] lineSplit = lines[i].Split('$');
                        test.valveName = lineSplit[0];
                        test.shortCircuitType = lineSplit[1];
                        test.time = int.Parse(lineSplit[2]);

                        dataGridViewTestConfig.Rows[i].Cells[dataGridViewValveColumnName].Value = 
                            valveNames.Find(s => s == test.valveName);
                        dataGridViewTestConfig.Rows[i].Cells[dataGridViewShortTypeColumnName].Value =
                            shortCircuitTypes.Find(s => s == test.shortCircuitType);
                        dataGridViewTestConfig.Rows[i].Cells[dataGridViewTimeColumnName].Value = test.time;
                    }
                }
            }
        }

        private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (AreDataGridViewAllRowsValid())
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog
                {
                    Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*",
                    Title = "Save configuration"
                };
                saveFileDialog.ShowDialog();

                if (saveFileDialog.FileName != "")
                {

                    using (StreamWriter streamWriter = new StreamWriter(saveFileDialog.FileName))
                    {
                        Test test;
                        for (int i = 0; i < dataGridViewTestConfig.RowCount - 1; i++)
                        {
                            test = GetTestFromDataGridViewRow(dataGridViewTestConfig.Rows[i]);
                            streamWriter.WriteLine(test.valveName + "$" + test.shortCircuitType + "$" + test.time);
                        }
                    }

                }
            }
            else
                MessageBox.Show("Some values are incorrect!");
        }

        private void startTestButton_MouseHover(object sender, EventArgs e)
        {
            startTestButton.BackColor = Color.PaleTurquoise;
        }

        private void clearConsoleButton_MouseHover(object sender, EventArgs e)
        {
            clearConsoleButton.BackColor = Color.PaleTurquoise;
        }
    }
}