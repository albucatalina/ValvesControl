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
    public string valve;
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

        string dataGridViewValveColumnName = "Valve";
        string dataGridViewShortTypeColumnName = "Short Type";
        string dataGridViewTimeColumnName = "Time [ms]";
        string dataGridViewRunTestColumnName = "Run";

        readonly List<string> valveNames;
        readonly List<string> shortCircuitTypes;


        public ValvesControl()
        {
            InitializeComponent();

            valveNames = new List<string>() { "-select-" };
            shortCircuitTypes = new List<string>() { "-select-" };

            GetDataGridViewInformationFromFile();

            DataGridViewConfiguration();

            if (portTextBox.Text == "")
            {
                toolStripStatusLabel1.Text = "Not connected. Please select a port to connect automatically";
                statusStrip1.BackColor = Color.Yellow;
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
            portTextBox.Text = portName;
            toolStripStatusLabel1.Text = "Connected";
            statusStrip1.BackColor = Color.Green;
            try
            {
                serialPort = new SerialPort(portName, 9600, Parity.None, 8, StopBits.One);
                serialPort.Open();
                serialPort.DiscardInBuffer();
                serialPort.DataReceived += new SerialDataReceivedEventHandler(DataReceivedHandler);
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
            MethodInvoker methodInvoker;
            string response = serialPort.ReadLine();
            if (response != "")
            {
                if (response.Contains("executing"))
                {
                    Test test = GetTestFromExecutingMessage(response.Substring(response.IndexOf('$') + 1));
                    executingTestSequenceForm.ShowTestCommand(test);
                }
                if (response.Contains("done"))
                {
                    executingTestSequenceForm.TestSequenceDone();
                }
                
                if (response.Contains("current"))
                {
                    int index = response.IndexOf("$");
                    response = response.Substring(index + 1);
                    index = response.IndexOf("$");
                    int valveId = int.Parse(response.Substring(0, index));
                    string value = response.Substring(index + 1);
                    ShowCurrentValue(valveId, value);
                }
                if (response.Contains("voltage"))
                {
                    int index = response.IndexOf("$");
                    response = response.Substring(index + 1);
                    index = response.IndexOf("$");
                    int valveId = int.Parse(response.Substring(0, index));
                    string value = response.Substring(index + 1);
                    ShowVoltageValue(valveId, value);
                }
                methodInvoker = new MethodInvoker(() => consoleTextBox.Text += "Arduino response: " + response + Environment.NewLine);
                consoleTextBox.Invoke(methodInvoker);
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

        private void ShowVoltageValue(int valveId, string volatgeValue)
        {
            switch (valveId)
            {
                case 1:
                    this.BeginInvoke(new Action(() => valve1VoltageTextBox.Text = volatgeValue + "V"));
                    break;
                case 2:
                    this.BeginInvoke(new Action(() => valve2VoltageTextBox.Text = volatgeValue + "V"));
                    break;
                case 3:
                    this.BeginInvoke(new Action(() => valve3VoltageTextBox.Text = volatgeValue + "V"));
                    break;
                case 4:
                    this.BeginInvoke(new Action(() => valve4VoltageTextBox.Text = volatgeValue + "V"));
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
            test.valve = valveNames[valveId];

            response = response.Substring(index + 1);
            index = response.IndexOf('$');
            int shortCircuitTypeId = int.Parse(response.Substring(0, index));
            test.shortCircuitType = shortCircuitTypes[shortCircuitTypeId];

            test.time = int.Parse(response.Substring(index + 1));

            Console.WriteLine(test.valve + "-" + test.shortCircuitType + "-" + test.time);

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
            dataGridViewTestConfig.Rows[0].Cells[dataGridViewValveColumnName].Value = ((DataGridViewComboBoxCell)dataGridViewTestConfig.Rows[0].Cells[dataGridViewValveColumnName]).Items[0];

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
            if (portTextBox.Text != "")
                serialPort.Close();
            
        }

        private void cleanConsoleButton_Click(object sender, EventArgs e)
        {
            consoleTextBox.Clear();
        }

        private void DataGridViewTestConfig_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                if (portTextBox.Text != "")
                {
                    if (IsDataGridViewRowValid(dataGridViewTestConfig.Rows[e.RowIndex]))
                    {
                        
                        Test test = GetTestFromDataGridViewRow(dataGridViewTestConfig.Rows[e.RowIndex]);
                        //consoleTextBox.Text += "Short type - " + test.shortCircuitType + ": Valva " + test.valve + " a fost selectata cu timpul " + test.time + Environment.NewLine;
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
            serialPort.DiscardOutBuffer();
            int valveId = valveNames.FindIndex(name => name == test.valve);
            int shortCircuitTypeId = shortCircuitTypes.FindIndex(shortType => shortType == test.shortCircuitType);
            int time = test.time;
            serialPort.Write("test$" + valveId + "$" + shortCircuitTypeId + "$" + time);
        }

        private void SendMessageToArduino(List<Test> testSequence, int repetitions)
        {
            string messageToSend = "testSequence$" + repetitions + "$";
            int valveId, shortCircuitTypeId, time;
            foreach (Test test in testSequence)
            {
                valveId = valveNames.FindIndex(name => name == test.valve);
                shortCircuitTypeId = shortCircuitTypes.FindIndex(shortType => shortType == test.shortCircuitType);
                time = test.time;
                messageToSend += "<" + valveId + "$" + shortCircuitTypeId + "$" + time + ">";
            }
            // consoleTextBox.Text += "trimis:" + messageToSend + Environment.NewLine;
            serialPort.Write(messageToSend); //!!!!!!!!!!!!!!!!!!!!!!!!!!!! nush dc trb write nu writeline....
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
            if (portTextBox.Text != "") //functie port available /connection ok
            {
                if (AreDataGridViewAllRowsValid())
                {
                    List<Test> tests = new List<Test>();
                    Test test;
                    //string testSequence = "testSequence$" + repeatNumericUpDown.Value;
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
            t.valve = dataGridViewRow.Cells[dataGridViewValveColumnName].Value.ToString();
            t.shortCircuitType = dataGridViewRow.Cells[dataGridViewShortTypeColumnName].Value.ToString();
            t.time = int.Parse(dataGridViewRow.Cells[dataGridViewTimeColumnName].Value.ToString());
            return t;
        }

        private void DataGridViewTestConfig_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            if (dataGridViewTestConfig.Columns[e.ColumnIndex] is DataGridViewTextBoxColumn)
            {
                if (int.TryParse(e.FormattedValue?.ToString(), out _))
                {
                    // Value is a valid integer
                }
                else
                {
                    // Value is not a valid integer
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

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
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
                    string[] lines = streamReader.ReadToEnd().Split(new[] { Environment.NewLine }, StringSplitOptions.None);
                    for (int i = 0; i < lines.Length - 1; i++)
                        dataGridViewTestConfig.Rows.Add();
                    for (int i = 0; i < dataGridViewTestConfig.RowCount - 1; i++)
                    {
                        Test test;
                        string[] lineSplit = lines[i].Split('$');
                        test.valve = lineSplit[0];
                        test.shortCircuitType = lineSplit[1];
                        test.time = int.Parse(lineSplit[2]);

                        dataGridViewTestConfig.Rows[i].Cells[dataGridViewValveColumnName].Value = valveNames.Find(s => s == test.valve);
                        dataGridViewTestConfig.Rows[i].Cells[dataGridViewShortTypeColumnName].Value = shortCircuitTypes.Find(s => s == test.shortCircuitType);
                        dataGridViewTestConfig.Rows[i].Cells[dataGridViewTimeColumnName].Value = test.time;
                    }

                }
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
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
                            streamWriter.WriteLine(test.valve + "$" + test.shortCircuitType + "$" + test.time);
                        }
                    }

                }
            }
            else
                MessageBox.Show("Some values are incorrect!");
        }
    }
}