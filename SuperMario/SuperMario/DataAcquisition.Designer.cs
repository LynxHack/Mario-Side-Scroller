namespace SuperMario
{
    partial class DataTester
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.serCom = new System.IO.Ports.SerialPort(this.components);
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ZDataBox = new System.Windows.Forms.TextBox();
            this.YDataBox = new System.Windows.Forms.TextBox();
            this.XDataBox = new System.Windows.Forms.TextBox();
            this.XaxisBox = new System.Windows.Forms.TextBox();
            this.YaxisBox = new System.Windows.Forms.TextBox();
            this.ZaxisBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SerialPortListBox = new System.Windows.Forms.ComboBox();
            this.AccelGraph = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.DisconnectButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AccelGraph)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 50;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // serCom
            // 
            this.serCom.PortName = "COM4";
            this.serCom.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serCom_DataReceived);
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Gainsboro;
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.ZDataBox);
            this.tabPage1.Controls.Add(this.YDataBox);
            this.tabPage1.Controls.Add(this.XDataBox);
            this.tabPage1.Controls.Add(this.XaxisBox);
            this.tabPage1.Controls.Add(this.YaxisBox);
            this.tabPage1.Controls.Add(this.ZaxisBox);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.SerialPortListBox);
            this.tabPage1.Controls.Add(this.AccelGraph);
            this.tabPage1.Controls.Add(this.DisconnectButton);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1053, 513);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Debugger";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(903, 475);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Z axis";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(672, 475);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Y axis";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(441, 475);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "X axis";
            // 
            // ZDataBox
            // 
            this.ZDataBox.Location = new System.Drawing.Point(811, 241);
            this.ZDataBox.Multiline = true;
            this.ZDataBox.Name = "ZDataBox";
            this.ZDataBox.Size = new System.Drawing.Size(219, 231);
            this.ZDataBox.TabIndex = 14;
            // 
            // YDataBox
            // 
            this.YDataBox.Location = new System.Drawing.Point(579, 241);
            this.YDataBox.Multiline = true;
            this.YDataBox.Name = "YDataBox";
            this.YDataBox.Size = new System.Drawing.Size(226, 231);
            this.YDataBox.TabIndex = 13;
            // 
            // XDataBox
            // 
            this.XDataBox.Location = new System.Drawing.Point(352, 241);
            this.XDataBox.Multiline = true;
            this.XDataBox.Name = "XDataBox";
            this.XDataBox.Size = new System.Drawing.Size(221, 231);
            this.XDataBox.TabIndex = 12;
            // 
            // XaxisBox
            // 
            this.XaxisBox.Location = new System.Drawing.Point(26, 135);
            this.XaxisBox.Name = "XaxisBox";
            this.XaxisBox.Size = new System.Drawing.Size(111, 20);
            this.XaxisBox.TabIndex = 2;
            // 
            // YaxisBox
            // 
            this.YaxisBox.Location = new System.Drawing.Point(26, 161);
            this.YaxisBox.Name = "YaxisBox";
            this.YaxisBox.Size = new System.Drawing.Size(111, 20);
            this.YaxisBox.TabIndex = 3;
            // 
            // ZaxisBox
            // 
            this.ZaxisBox.Location = new System.Drawing.Point(26, 187);
            this.ZaxisBox.Name = "ZaxisBox";
            this.ZaxisBox.Size = new System.Drawing.Size(111, 20);
            this.ZaxisBox.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(22, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(160, 24);
            this.label4.TabIndex = 11;
            this.label4.Text = "Data Acquisition";
            // 
            // SerialPortListBox
            // 
            this.SerialPortListBox.FormattingEnabled = true;
            this.SerialPortListBox.Location = new System.Drawing.Point(26, 60);
            this.SerialPortListBox.Name = "SerialPortListBox";
            this.SerialPortListBox.Size = new System.Drawing.Size(132, 21);
            this.SerialPortListBox.TabIndex = 0;
            this.SerialPortListBox.SelectedIndexChanged += new System.EventHandler(this.SerialPortListBox_SelectedIndexChanged);
            // 
            // AccelGraph
            // 
            chartArea4.AxisX.Title = "Sample Point";
            chartArea4.AxisY.Title = "Acceleration (m/s^2)";
            chartArea4.Name = "ChartArea1";
            this.AccelGraph.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.AccelGraph.Legends.Add(legend4);
            this.AccelGraph.Location = new System.Drawing.Point(352, 22);
            this.AccelGraph.Name = "AccelGraph";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            this.AccelGraph.Series.Add(series4);
            this.AccelGraph.Size = new System.Drawing.Size(678, 213);
            this.AccelGraph.TabIndex = 8;
            this.AccelGraph.Text = "chart1";
            // 
            // DisconnectButton
            // 
            this.DisconnectButton.Location = new System.Drawing.Point(173, 58);
            this.DisconnectButton.Name = "DisconnectButton";
            this.DisconnectButton.Size = new System.Drawing.Size(86, 23);
            this.DisconnectButton.TabIndex = 1;
            this.DisconnectButton.Text = "Connect";
            this.DisconnectButton.UseVisualStyleBackColor = true;
            this.DisconnectButton.Click += new System.EventHandler(this.DisconnectButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(157, 190);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Z axis";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(157, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Y axis";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(157, 138);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "X axis";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(0, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1061, 539);
            this.tabControl1.TabIndex = 9;
            // 
            // DataTester
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(299, 136);
            this.Controls.Add(this.tabControl1);
            this.MinimumSize = new System.Drawing.Size(260, 173);
            this.Name = "DataTester";
            this.Text = "Form1";
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AccelGraph)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer timer;
        public System.IO.Ports.SerialPort serCom;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox ZDataBox;
        private System.Windows.Forms.TextBox YDataBox;
        private System.Windows.Forms.TextBox XDataBox;
        private System.Windows.Forms.TextBox XaxisBox;
        private System.Windows.Forms.TextBox YaxisBox;
        private System.Windows.Forms.TextBox ZaxisBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox SerialPortListBox;
        private System.Windows.Forms.DataVisualization.Charting.Chart AccelGraph;
        private System.Windows.Forms.Button DisconnectButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl1;
    }
}

