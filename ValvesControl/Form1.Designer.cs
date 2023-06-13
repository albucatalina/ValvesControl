
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
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hardwareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.electricalSchemaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.relaysConfigurationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.portsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.valve4VoltageTextBox = new System.Windows.Forms.TextBox();
            this.valve4CurrentTextBox = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.valve3VoltageTextBox = new System.Windows.Forms.TextBox();
            this.valve3CurrentTextBox = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.valve2VoltageTextBox = new System.Windows.Forms.TextBox();
            this.valve2CurrentTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.valve1VoltageTextBox = new System.Windows.Forms.TextBox();
            this.valve1CurrentTextBox = new System.Windows.Forms.TextBox();
            this.consoleTextBox = new System.Windows.Forms.TextBox();
            this.cleanConsoleButton = new System.Windows.Forms.Button();
            this.dataGridViewTestConfig = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.startTestButton = new System.Windows.Forms.Button();
            this.repeatNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.portTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTestConfig)).BeginInit();
            this.groupBox3.SuspendLayout();
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
            this.menuStrip1.BackColor = System.Drawing.Color.Orange;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hystoryToolStripMenuItem,
            this.helpToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.hardwareToolStripMenuItem,
            this.portsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1150, 30);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // hystoryToolStripMenuItem
            // 
            this.hystoryToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem});
            this.hystoryToolStripMenuItem.Name = "hystoryToolStripMenuItem";
            this.hystoryToolStripMenuItem.Size = new System.Drawing.Size(114, 26);
            this.hystoryToolStripMenuItem.Text = "Configuration";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(128, 26);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(128, 26);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(55, 26);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(55, 26);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // hardwareToolStripMenuItem
            // 
            this.hardwareToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.electricalSchemaToolStripMenuItem1,
            this.relaysConfigurationToolStripMenuItem});
            this.hardwareToolStripMenuItem.Name = "hardwareToolStripMenuItem";
            this.hardwareToolStripMenuItem.Size = new System.Drawing.Size(88, 26);
            this.hardwareToolStripMenuItem.Text = "Hardware";
            // 
            // electricalSchemaToolStripMenuItem1
            // 
            this.electricalSchemaToolStripMenuItem1.Name = "electricalSchemaToolStripMenuItem1";
            this.electricalSchemaToolStripMenuItem1.Size = new System.Drawing.Size(229, 26);
            this.electricalSchemaToolStripMenuItem1.Text = "Electrical Schema";
            // 
            // relaysConfigurationToolStripMenuItem
            // 
            this.relaysConfigurationToolStripMenuItem.Name = "relaysConfigurationToolStripMenuItem";
            this.relaysConfigurationToolStripMenuItem.Size = new System.Drawing.Size(229, 26);
            this.relaysConfigurationToolStripMenuItem.Text = "Relays Configuration";
            // 
            // portsToolStripMenuItem
            // 
            this.portsToolStripMenuItem.Name = "portsToolStripMenuItem";
            this.portsToolStripMenuItem.Size = new System.Drawing.Size(55, 26);
            this.portsToolStripMenuItem.Text = "Ports";
            this.portsToolStripMenuItem.MouseEnter += new System.EventHandler(this.PortsToolStripMenuItem_MouseEnter);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox6);
            this.groupBox2.Controls.Add(this.groupBox5);
            this.groupBox2.Controls.Add(this.groupBox4);
            this.groupBox2.Controls.Add(this.groupBox1);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox2.Location = new System.Drawing.Point(578, 52);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(550, 256);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Measurement";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.valve4VoltageTextBox);
            this.groupBox6.Controls.Add(this.valve4CurrentTextBox);
            this.groupBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox6.Location = new System.Drawing.Point(283, 137);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(252, 90);
            this.groupBox6.TabIndex = 21;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "valve 4";
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
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.valve3VoltageTextBox);
            this.groupBox5.Controls.Add(this.valve3CurrentTextBox);
            this.groupBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox5.Location = new System.Drawing.Point(16, 137);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(252, 90);
            this.groupBox5.TabIndex = 20;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "valve 3";
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
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.valve2VoltageTextBox);
            this.groupBox4.Controls.Add(this.valve2CurrentTextBox);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox4.Location = new System.Drawing.Point(283, 30);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(252, 90);
            this.groupBox4.TabIndex = 19;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "valve 2";
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.valve1VoltageTextBox);
            this.groupBox1.Controls.Add(this.valve1CurrentTextBox);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox1.Location = new System.Drawing.Point(16, 30);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(252, 90);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "valve 1";
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
            this.valve1VoltageTextBox.Text = "+0.00 v";
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
            // cleanConsoleButton
            // 
            this.cleanConsoleButton.Location = new System.Drawing.Point(986, 560);
            this.cleanConsoleButton.Name = "cleanConsoleButton";
            this.cleanConsoleButton.Size = new System.Drawing.Size(142, 28);
            this.cleanConsoleButton.TabIndex = 13;
            this.cleanConsoleButton.Text = "Clean Console";
            this.cleanConsoleButton.UseVisualStyleBackColor = true;
            this.cleanConsoleButton.Click += new System.EventHandler(this.cleanConsoleButton_Click);
            // 
            // dataGridViewTestConfig
            // 
            this.dataGridViewTestConfig.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewTestConfig.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTestConfig.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dataGridViewTestConfig.Location = new System.Drawing.Point(12, 30);
            this.dataGridViewTestConfig.Name = "dataGridViewTestConfig";
            this.dataGridViewTestConfig.RowHeadersVisible = false;
            this.dataGridViewTestConfig.RowHeadersWidth = 51;
            this.dataGridViewTestConfig.RowTemplate.Height = 24;
            this.dataGridViewTestConfig.Size = new System.Drawing.Size(492, 466);
            this.dataGridViewTestConfig.TabIndex = 15;
            this.dataGridViewTestConfig.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewTestConfig_CellContentClick);
            this.dataGridViewTestConfig.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.DataGridViewTestConfig_CellValidating);
            this.dataGridViewTestConfig.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dataGridViewTestConfig_RowsAdded);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.startTestButton);
            this.groupBox3.Controls.Add(this.repeatNumericUpDown);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.dataGridViewTestConfig);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox3.Location = new System.Drawing.Point(16, 52);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(530, 550);
            this.groupBox3.TabIndex = 16;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Test Sequence Configuration";
            // 
            // startTestButton
            // 
            this.startTestButton.Location = new System.Drawing.Point(424, 508);
            this.startTestButton.Name = "startTestButton";
            this.startTestButton.Size = new System.Drawing.Size(80, 32);
            this.startTestButton.TabIndex = 18;
            this.startTestButton.Text = "Start";
            this.startTestButton.UseVisualStyleBackColor = true;
            this.startTestButton.Click += new System.EventHandler(this.StartTestButton_Click);
            // 
            // repeatNumericUpDown
            // 
            this.repeatNumericUpDown.Location = new System.Drawing.Point(79, 514);
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
            this.label4.Location = new System.Drawing.Point(6, 514);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 20);
            this.label4.TabIndex = 16;
            this.label4.Text = "Repeat:";
            // 
            // portTextBox
            // 
            this.portTextBox.Location = new System.Drawing.Point(769, 320);
            this.portTextBox.Name = "portTextBox";
            this.portTextBox.Size = new System.Drawing.Size(100, 22);
            this.portTextBox.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(729, 320);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 17);
            this.label1.TabIndex = 18;
            this.label1.Text = "Port";
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.BurlyWood;
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
            this.BackColor = System.Drawing.Color.Beige;
            this.ClientSize = new System.Drawing.Size(1150, 640);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.portTextBox);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.cleanConsoleButton);
            this.Controls.Add(this.consoleTextBox);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.consoleLabel);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ValvesControl";
            this.RightToLeftLayout = true;
            this.Text = "Valves control";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ValvesControl_FormClosed);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTestConfig)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.repeatNumericUpDown)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label consoleLabel;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox valve1CurrentTextBox;
        private System.Windows.Forms.ToolStripMenuItem hystoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.TextBox consoleTextBox;
        private System.Windows.Forms.ToolStripMenuItem hardwareToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem electricalSchemaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem relaysConfigurationToolStripMenuItem;
        private System.Windows.Forms.Button cleanConsoleButton;
        private System.Windows.Forms.DataGridView dataGridViewTestConfig;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button startTestButton;
        private System.Windows.Forms.NumericUpDown repeatNumericUpDown;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.TextBox valve4VoltageTextBox;
        private System.Windows.Forms.TextBox valve4CurrentTextBox;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox valve3VoltageTextBox;
        private System.Windows.Forms.TextBox valve3CurrentTextBox;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox valve2VoltageTextBox;
        private System.Windows.Forms.TextBox valve2CurrentTextBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox valve1VoltageTextBox;
        private System.Windows.Forms.TextBox portTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem portsToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
    }
}

