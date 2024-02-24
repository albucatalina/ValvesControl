
namespace ValvesControl
{
    partial class ValvesControl
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.consoleLabel = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.hystoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.portsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.measurementGroupBox = new System.Windows.Forms.GroupBox();
            this.valve4GroupBox = new System.Windows.Forms.GroupBox();
            this.valve4VoltageTextBox = new System.Windows.Forms.TextBox();
            this.valve4CurrentTextBox = new System.Windows.Forms.TextBox();
            this.valve3GroupBox = new System.Windows.Forms.GroupBox();
            this.valve3VoltageTextBox = new System.Windows.Forms.TextBox();
            this.valve3CurrentTextBox = new System.Windows.Forms.TextBox();
            this.valve2GroupBox = new System.Windows.Forms.GroupBox();
            this.valve2VoltageTextBox = new System.Windows.Forms.TextBox();
            this.valve2CurrentTextBox = new System.Windows.Forms.TextBox();
            this.valve1GroupBox = new System.Windows.Forms.GroupBox();
            this.valve1VoltageTextBox = new System.Windows.Forms.TextBox();
            this.valve1CurrentTextBox = new System.Windows.Forms.TextBox();
            this.consoleTextBox = new System.Windows.Forms.TextBox();
            this.clearConsoleButton = new System.Windows.Forms.Button();
            this.dataGridViewTestConfig = new System.Windows.Forms.DataGridView();
            this.testConfigurationGroupBox = new System.Windows.Forms.GroupBox();
            this.startTestButton = new System.Windows.Forms.Button();
            this.repeatNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1.SuspendLayout();
            this.measurementGroupBox.SuspendLayout();
            this.valve4GroupBox.SuspendLayout();
            this.valve3GroupBox.SuspendLayout();
            this.valve2GroupBox.SuspendLayout();
            this.valve1GroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTestConfig)).BeginInit();
            this.testConfigurationGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.repeatNumericUpDown)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // consoleLabel
            // 
            this.consoleLabel.AutoSize = true;
            this.consoleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.consoleLabel.Location = new System.Drawing.Point(574, 333);
            this.consoleLabel.Name = "consoleLabel";
            this.consoleLabel.Size = new System.Drawing.Size(77, 20);
            this.consoleLabel.TabIndex = 1;
            this.consoleLabel.Text = "Console";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.DarkCyan;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hystoryToolStripMenuItem,
            this.portsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1150, 31);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // hystoryToolStripMenuItem
            // 
            this.hystoryToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem});
            this.hystoryToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.hystoryToolStripMenuItem.Name = "hystoryToolStripMenuItem";
            this.hystoryToolStripMenuItem.Size = new System.Drawing.Size(129, 27);
            this.hystoryToolStripMenuItem.Text = "Configuration";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(136, 28);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.OpenToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(136, 28);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.SaveToolStripMenuItem_Click);
            // 
            // portsToolStripMenuItem
            // 
            this.portsToolStripMenuItem.Name = "portsToolStripMenuItem";
            this.portsToolStripMenuItem.Size = new System.Drawing.Size(55, 27);
            this.portsToolStripMenuItem.Text = "Ports";
            this.portsToolStripMenuItem.MouseEnter += new System.EventHandler(this.PortsToolStripMenuItem_MouseEnter);
            // 
            // measurementGroupBox
            // 
            this.measurementGroupBox.Controls.Add(this.valve4GroupBox);
            this.measurementGroupBox.Controls.Add(this.valve3GroupBox);
            this.measurementGroupBox.Controls.Add(this.valve2GroupBox);
            this.measurementGroupBox.Controls.Add(this.valve1GroupBox);
            this.measurementGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.measurementGroupBox.Location = new System.Drawing.Point(578, 52);
            this.measurementGroupBox.Name = "measurementGroupBox";
            this.measurementGroupBox.Size = new System.Drawing.Size(550, 256);
            this.measurementGroupBox.TabIndex = 5;
            this.measurementGroupBox.TabStop = false;
            this.measurementGroupBox.Text = "Measurement";
            // 
            // valve4GroupBox
            // 
            this.valve4GroupBox.Controls.Add(this.valve4VoltageTextBox);
            this.valve4GroupBox.Controls.Add(this.valve4CurrentTextBox);
            this.valve4GroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.valve4GroupBox.Location = new System.Drawing.Point(283, 137);
            this.valve4GroupBox.Name = "valve4GroupBox";
            this.valve4GroupBox.Size = new System.Drawing.Size(252, 90);
            this.valve4GroupBox.TabIndex = 21;
            this.valve4GroupBox.TabStop = false;
            this.valve4GroupBox.Text = "valve 4";
            // 
            // valve4VoltageTextBox
            // 
            this.valve4VoltageTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.valve4VoltageTextBox.Location = new System.Drawing.Point(20, 33);
            this.valve4VoltageTextBox.Multiline = true;
            this.valve4VoltageTextBox.Name = "valve4VoltageTextBox";
            this.valve4VoltageTextBox.ReadOnly = true;
            this.valve4VoltageTextBox.Size = new System.Drawing.Size(94, 38);
            this.valve4VoltageTextBox.TabIndex = 0;
            this.valve4VoltageTextBox.Text = "+0.00 V";
            // 
            // valve4CurrentTextBox
            // 
            this.valve4CurrentTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.valve4CurrentTextBox.Location = new System.Drawing.Point(139, 33);
            this.valve4CurrentTextBox.Multiline = true;
            this.valve4CurrentTextBox.Name = "valve4CurrentTextBox";
            this.valve4CurrentTextBox.ReadOnly = true;
            this.valve4CurrentTextBox.Size = new System.Drawing.Size(94, 38);
            this.valve4CurrentTextBox.TabIndex = 1;
            this.valve4CurrentTextBox.Text = "+0.00 A";
            // 
            // valve3GroupBox
            // 
            this.valve3GroupBox.Controls.Add(this.valve3VoltageTextBox);
            this.valve3GroupBox.Controls.Add(this.valve3CurrentTextBox);
            this.valve3GroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.valve3GroupBox.Location = new System.Drawing.Point(16, 137);
            this.valve3GroupBox.Name = "valve3GroupBox";
            this.valve3GroupBox.Size = new System.Drawing.Size(252, 90);
            this.valve3GroupBox.TabIndex = 20;
            this.valve3GroupBox.TabStop = false;
            this.valve3GroupBox.Text = "valve 3";
            // 
            // valve3VoltageTextBox
            // 
            this.valve3VoltageTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.valve3VoltageTextBox.Location = new System.Drawing.Point(20, 33);
            this.valve3VoltageTextBox.Multiline = true;
            this.valve3VoltageTextBox.Name = "valve3VoltageTextBox";
            this.valve3VoltageTextBox.ReadOnly = true;
            this.valve3VoltageTextBox.Size = new System.Drawing.Size(94, 38);
            this.valve3VoltageTextBox.TabIndex = 0;
            this.valve3VoltageTextBox.Text = "+0.00 V";
            // 
            // valve3CurrentTextBox
            // 
            this.valve3CurrentTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.valve3CurrentTextBox.Location = new System.Drawing.Point(139, 33);
            this.valve3CurrentTextBox.Multiline = true;
            this.valve3CurrentTextBox.Name = "valve3CurrentTextBox";
            this.valve3CurrentTextBox.ReadOnly = true;
            this.valve3CurrentTextBox.Size = new System.Drawing.Size(94, 38);
            this.valve3CurrentTextBox.TabIndex = 1;
            this.valve3CurrentTextBox.Text = "+0.00 A";
            // 
            // valve2GroupBox
            // 
            this.valve2GroupBox.Controls.Add(this.valve2VoltageTextBox);
            this.valve2GroupBox.Controls.Add(this.valve2CurrentTextBox);
            this.valve2GroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.valve2GroupBox.Location = new System.Drawing.Point(283, 30);
            this.valve2GroupBox.Name = "valve2GroupBox";
            this.valve2GroupBox.Size = new System.Drawing.Size(252, 90);
            this.valve2GroupBox.TabIndex = 19;
            this.valve2GroupBox.TabStop = false;
            this.valve2GroupBox.Text = "valve 2";
            // 
            // valve2VoltageTextBox
            // 
            this.valve2VoltageTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.valve2VoltageTextBox.Location = new System.Drawing.Point(20, 33);
            this.valve2VoltageTextBox.Multiline = true;
            this.valve2VoltageTextBox.Name = "valve2VoltageTextBox";
            this.valve2VoltageTextBox.ReadOnly = true;
            this.valve2VoltageTextBox.Size = new System.Drawing.Size(94, 38);
            this.valve2VoltageTextBox.TabIndex = 0;
            this.valve2VoltageTextBox.Text = "+0.00 V";
            // 
            // valve2CurrentTextBox
            // 
            this.valve2CurrentTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.valve2CurrentTextBox.Location = new System.Drawing.Point(139, 33);
            this.valve2CurrentTextBox.Multiline = true;
            this.valve2CurrentTextBox.Name = "valve2CurrentTextBox";
            this.valve2CurrentTextBox.ReadOnly = true;
            this.valve2CurrentTextBox.Size = new System.Drawing.Size(94, 38);
            this.valve2CurrentTextBox.TabIndex = 1;
            this.valve2CurrentTextBox.Text = "+0.00 A";
            // 
            // valve1GroupBox
            // 
            this.valve1GroupBox.Controls.Add(this.valve1VoltageTextBox);
            this.valve1GroupBox.Controls.Add(this.valve1CurrentTextBox);
            this.valve1GroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.valve1GroupBox.Location = new System.Drawing.Point(16, 30);
            this.valve1GroupBox.Name = "valve1GroupBox";
            this.valve1GroupBox.Size = new System.Drawing.Size(252, 90);
            this.valve1GroupBox.TabIndex = 18;
            this.valve1GroupBox.TabStop = false;
            this.valve1GroupBox.Text = "valve 1";
            // 
            // valve1VoltageTextBox
            // 
            this.valve1VoltageTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.valve1VoltageTextBox.Location = new System.Drawing.Point(20, 33);
            this.valve1VoltageTextBox.Multiline = true;
            this.valve1VoltageTextBox.Name = "valve1VoltageTextBox";
            this.valve1VoltageTextBox.ReadOnly = true;
            this.valve1VoltageTextBox.Size = new System.Drawing.Size(94, 38);
            this.valve1VoltageTextBox.TabIndex = 0;
            this.valve1VoltageTextBox.Text = "+0.00 V";
            // 
            // valve1CurrentTextBox
            // 
            this.valve1CurrentTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.valve1CurrentTextBox.Location = new System.Drawing.Point(139, 33);
            this.valve1CurrentTextBox.Multiline = true;
            this.valve1CurrentTextBox.Name = "valve1CurrentTextBox";
            this.valve1CurrentTextBox.ReadOnly = true;
            this.valve1CurrentTextBox.Size = new System.Drawing.Size(94, 38);
            this.valve1CurrentTextBox.TabIndex = 1;
            this.valve1CurrentTextBox.Text = "+0.00 A";
            // 
            // consoleTextBox
            // 
            this.consoleTextBox.Location = new System.Drawing.Point(578, 356);
            this.consoleTextBox.Multiline = true;
            this.consoleTextBox.Name = "consoleTextBox";
            this.consoleTextBox.ReadOnly = true;
            this.consoleTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.consoleTextBox.Size = new System.Drawing.Size(550, 192);
            this.consoleTextBox.TabIndex = 8;
            // 
            // clearConsoleButton
            // 
            this.clearConsoleButton.BackColor = System.Drawing.Color.MediumTurquoise;
            this.clearConsoleButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearConsoleButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.clearConsoleButton.Location = new System.Drawing.Point(986, 560);
            this.clearConsoleButton.Name = "clearConsoleButton";
            this.clearConsoleButton.Size = new System.Drawing.Size(142, 33);
            this.clearConsoleButton.TabIndex = 13;
            this.clearConsoleButton.Text = "Clear Console";
            this.clearConsoleButton.UseVisualStyleBackColor = false;
            this.clearConsoleButton.Click += new System.EventHandler(this.clearConsoleButton_Click);
            this.clearConsoleButton.MouseHover += new System.EventHandler(this.clearConsoleButton_MouseHover);
            // 
            // dataGridViewTestConfig
            // 
            this.dataGridViewTestConfig.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewTestConfig.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTestConfig.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dataGridViewTestConfig.GridColor = System.Drawing.SystemColors.Control;
            this.dataGridViewTestConfig.Location = new System.Drawing.Point(12, 30);
            this.dataGridViewTestConfig.Name = "dataGridViewTestConfig";
            this.dataGridViewTestConfig.RowHeadersVisible = false;
            this.dataGridViewTestConfig.RowHeadersWidth = 51;
            this.dataGridViewTestConfig.RowTemplate.Height = 24;
            this.dataGridViewTestConfig.Size = new System.Drawing.Size(511, 466);
            this.dataGridViewTestConfig.TabIndex = 15;
            this.dataGridViewTestConfig.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewTestConfig_CellContentClick);
            this.dataGridViewTestConfig.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.DataGridViewTestConfig_CellValidating);
            this.dataGridViewTestConfig.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dataGridViewTestConfig_RowsAdded);
            // 
            // testConfigurationGroupBox
            // 
            this.testConfigurationGroupBox.Controls.Add(this.startTestButton);
            this.testConfigurationGroupBox.Controls.Add(this.repeatNumericUpDown);
            this.testConfigurationGroupBox.Controls.Add(this.label4);
            this.testConfigurationGroupBox.Controls.Add(this.dataGridViewTestConfig);
            this.testConfigurationGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.testConfigurationGroupBox.Location = new System.Drawing.Point(16, 52);
            this.testConfigurationGroupBox.Name = "testConfigurationGroupBox";
            this.testConfigurationGroupBox.Size = new System.Drawing.Size(541, 550);
            this.testConfigurationGroupBox.TabIndex = 16;
            this.testConfigurationGroupBox.TabStop = false;
            this.testConfigurationGroupBox.Text = "Test Sequence Configuration";
            // 
            // startTestButton
            // 
            this.startTestButton.BackColor = System.Drawing.Color.MediumTurquoise;
            this.startTestButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.startTestButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.startTestButton.Location = new System.Drawing.Point(424, 508);
            this.startTestButton.Name = "startTestButton";
            this.startTestButton.Size = new System.Drawing.Size(99, 32);
            this.startTestButton.TabIndex = 18;
            this.startTestButton.Text = "Start";
            this.startTestButton.UseVisualStyleBackColor = false;
            this.startTestButton.Click += new System.EventHandler(this.StartTestButton_Click);
            this.startTestButton.MouseHover += new System.EventHandler(this.startTestButton_MouseHover);
            // 
            // repeatNumericUpDown
            // 
            this.repeatNumericUpDown.Location = new System.Drawing.Point(81, 508);
            this.repeatNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.repeatNumericUpDown.Name = "repeatNumericUpDown";
            this.repeatNumericUpDown.Size = new System.Drawing.Size(67, 27);
            this.repeatNumericUpDown.TabIndex = 17;
            this.repeatNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 510);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 20);
            this.label4.TabIndex = 16;
            this.label4.Text = "Repeat:";
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.MediumTurquoise;
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 618);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1150, 22);
            this.statusStrip1.TabIndex = 19;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 16);
            // 
            // ValvesControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OldLace;
            this.ClientSize = new System.Drawing.Size(1150, 640);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.testConfigurationGroupBox);
            this.Controls.Add(this.clearConsoleButton);
            this.Controls.Add(this.consoleTextBox);
            this.Controls.Add(this.measurementGroupBox);
            this.Controls.Add(this.consoleLabel);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ValvesControl";
            this.RightToLeftLayout = true;
            this.Text = "Valves control";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ValvesControl_FormClosed);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.measurementGroupBox.ResumeLayout(false);
            this.valve4GroupBox.ResumeLayout(false);
            this.valve4GroupBox.PerformLayout();
            this.valve3GroupBox.ResumeLayout(false);
            this.valve3GroupBox.PerformLayout();
            this.valve2GroupBox.ResumeLayout(false);
            this.valve2GroupBox.PerformLayout();
            this.valve1GroupBox.ResumeLayout(false);
            this.valve1GroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTestConfig)).EndInit();
            this.testConfigurationGroupBox.ResumeLayout(false);
            this.testConfigurationGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.repeatNumericUpDown)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label consoleLabel;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.GroupBox measurementGroupBox;
        private System.Windows.Forms.TextBox valve1CurrentTextBox;
        private System.Windows.Forms.ToolStripMenuItem hystoryToolStripMenuItem;
        private System.Windows.Forms.TextBox consoleTextBox;
        private System.Windows.Forms.Button clearConsoleButton;
        private System.Windows.Forms.DataGridView dataGridViewTestConfig;
        private System.Windows.Forms.GroupBox testConfigurationGroupBox;
        private System.Windows.Forms.Button startTestButton;
        private System.Windows.Forms.NumericUpDown repeatNumericUpDown;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox valve4GroupBox;
        private System.Windows.Forms.TextBox valve4VoltageTextBox;
        private System.Windows.Forms.TextBox valve4CurrentTextBox;
        private System.Windows.Forms.GroupBox valve3GroupBox;
        private System.Windows.Forms.TextBox valve3VoltageTextBox;
        private System.Windows.Forms.TextBox valve3CurrentTextBox;
        private System.Windows.Forms.GroupBox valve2GroupBox;
        private System.Windows.Forms.TextBox valve2VoltageTextBox;
        private System.Windows.Forms.TextBox valve2CurrentTextBox;
        private System.Windows.Forms.GroupBox valve1GroupBox;
        private System.Windows.Forms.TextBox valve1VoltageTextBox;
        private System.Windows.Forms.ToolStripMenuItem portsToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
    }
}

