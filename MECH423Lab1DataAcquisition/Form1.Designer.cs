namespace MECH423Lab1DataAcquisition
{
    partial class Form1
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
            System.Windows.Forms.Label labelXA;
            System.Windows.Forms.Label labelYA;
            System.Windows.Forms.Label labelZA;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label4;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label label5;
            System.Windows.Forms.Label labelOrientation;
            System.Windows.Forms.Label labelGesture;
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.Label labelIsStarted;
            System.Windows.Forms.Label label6;
            System.Windows.Forms.Label label7;
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.btnSerial = new System.Windows.Forms.Button();
            this.cmbSerial = new System.Windows.Forms.ComboBox();
            this.txtXA = new System.Windows.Forms.TextBox();
            this.txtYA = new System.Windows.Forms.TextBox();
            this.txtZA = new System.Windows.Forms.TextBox();
            this.chtXYZ = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.timerUpdateCmb = new System.Windows.Forms.Timer(this.components);
            this.serialCOM = new System.IO.Ports.SerialPort(this.components);
            this.pgbarBuffer = new System.Windows.Forms.ProgressBar();
            this.tmrUpdateData = new System.Windows.Forms.Timer(this.components);
            this.labelShowBufferFill = new System.Windows.Forms.Label();
            this.panelMy2048 = new System.Windows.Forms.Panel();
            this.cbxSaveToFile = new System.Windows.Forms.CheckBox();
            this.txtDirectory = new System.Windows.Forms.TextBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.pbarXA = new System.Windows.Forms.ProgressBar();
            this.pbarYA = new System.Windows.Forms.ProgressBar();
            this.pbarZA = new System.Windows.Forms.ProgressBar();
            this.txtZAvg = new System.Windows.Forms.TextBox();
            this.txtYAvg = new System.Windows.Forms.TextBox();
            this.txtXAvg = new System.Windows.Forms.TextBox();
            this.txtAvgN = new System.Windows.Forms.TextBox();
            this.txtOrientation = new System.Windows.Forms.TextBox();
            this.tmrUpdateOrientation = new System.Windows.Forms.Timer(this.components);
            this.listGestureHistory = new System.Windows.Forms.ListBox();
            this.txtGesture = new System.Windows.Forms.TextBox();
            this.txtScore = new System.Windows.Forms.TextBox();
            this.labelGameStatus = new System.Windows.Forms.Label();
            this.chartVelocity = new System.Windows.Forms.DataVisualization.Charting.Chart();
            labelXA = new System.Windows.Forms.Label();
            labelYA = new System.Windows.Forms.Label();
            labelZA = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            labelOrientation = new System.Windows.Forms.Label();
            labelGesture = new System.Windows.Forms.Label();
            labelIsStarted = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chtXYZ)).BeginInit();
            this.panelMy2048.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartVelocity)).BeginInit();
            this.SuspendLayout();
            // 
            // labelXA
            // 
            labelXA.AutoSize = true;
            labelXA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            labelXA.Location = new System.Drawing.Point(176, 63);
            labelXA.Name = "labelXA";
            labelXA.Size = new System.Drawing.Size(139, 25);
            labelXA.TabIndex = 5;
            labelXA.Text = "X Acceleration";
            // 
            // labelYA
            // 
            labelYA.AutoSize = true;
            labelYA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            labelYA.Location = new System.Drawing.Point(176, 99);
            labelYA.Name = "labelYA";
            labelYA.Size = new System.Drawing.Size(138, 25);
            labelYA.TabIndex = 6;
            labelYA.Text = "Y Acceleration";
            // 
            // labelZA
            // 
            labelZA.AutoSize = true;
            labelZA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            labelZA.Location = new System.Drawing.Point(176, 135);
            labelZA.Name = "labelZA";
            labelZA.Size = new System.Drawing.Size(137, 25);
            labelZA.TabIndex = 7;
            labelZA.Text = "Z Acceleration";
            // 
            // label1
            // 
            label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label1.Location = new System.Drawing.Point(345, 24);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(63, 25);
            label1.TabIndex = 10;
            label1.Text = "Buffer";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label4.Location = new System.Drawing.Point(345, 184);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(103, 25);
            label4.TabIndex = 22;
            label4.Text = "Avg of last";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label2.Location = new System.Drawing.Point(176, 256);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(103, 25);
            label2.TabIndex = 25;
            label2.Text = "Z Acc Avg";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label3.Location = new System.Drawing.Point(176, 220);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(104, 25);
            label3.TabIndex = 24;
            label3.Text = "Y Acc Avg";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label5.Location = new System.Drawing.Point(176, 184);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(105, 25);
            label5.TabIndex = 23;
            label5.Text = "X Acc Avg";
            // 
            // labelOrientation
            // 
            labelOrientation.AutoSize = true;
            labelOrientation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            labelOrientation.Location = new System.Drawing.Point(345, 256);
            labelOrientation.Name = "labelOrientation";
            labelOrientation.Size = new System.Drawing.Size(107, 25);
            labelOrientation.TabIndex = 27;
            labelOrientation.Text = "Orientation";
            // 
            // labelGesture
            // 
            labelGesture.AutoSize = true;
            labelGesture.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            labelGesture.Location = new System.Drawing.Point(688, 25);
            labelGesture.Name = "labelGesture";
            labelGesture.Size = new System.Drawing.Size(81, 25);
            labelGesture.TabIndex = 30;
            labelGesture.Text = "Gesture";
            // 
            // btnSerial
            // 
            this.btnSerial.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSerial.Location = new System.Drawing.Point(181, 21);
            this.btnSerial.Name = "btnSerial";
            this.btnSerial.Size = new System.Drawing.Size(125, 35);
            this.btnSerial.TabIndex = 0;
            this.btnSerial.Text = "Connect";
            this.btnSerial.UseVisualStyleBackColor = true;
            this.btnSerial.Click += new System.EventHandler(this.btnSerial_Click);
            // 
            // cmbSerial
            // 
            this.cmbSerial.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSerial.FormattingEnabled = true;
            this.cmbSerial.Location = new System.Drawing.Point(14, 21);
            this.cmbSerial.Name = "cmbSerial";
            this.cmbSerial.Size = new System.Drawing.Size(161, 33);
            this.cmbSerial.TabIndex = 1;
            // 
            // txtXA
            // 
            this.txtXA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtXA.Location = new System.Drawing.Point(14, 60);
            this.txtXA.Name = "txtXA";
            this.txtXA.Size = new System.Drawing.Size(161, 30);
            this.txtXA.TabIndex = 2;
            // 
            // txtYA
            // 
            this.txtYA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtYA.Location = new System.Drawing.Point(14, 96);
            this.txtYA.Name = "txtYA";
            this.txtYA.Size = new System.Drawing.Size(161, 30);
            this.txtYA.TabIndex = 3;
            // 
            // txtZA
            // 
            this.txtZA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtZA.Location = new System.Drawing.Point(14, 132);
            this.txtZA.Name = "txtZA";
            this.txtZA.Size = new System.Drawing.Size(161, 30);
            this.txtZA.TabIndex = 4;
            // 
            // chtXYZ
            // 
            this.chtXYZ.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            chartArea1.Name = "ChartArea1";
            this.chtXYZ.ChartAreas.Add(chartArea1);
            legend1.Alignment = System.Drawing.StringAlignment.Center;
            legend1.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            legend1.MaximumAutoSize = 10F;
            legend1.Name = "Legend1";
            this.chtXYZ.Legends.Add(legend1);
            this.chtXYZ.Location = new System.Drawing.Point(12, 331);
            this.chtXYZ.MinimumSize = new System.Drawing.Size(675, 300);
            this.chtXYZ.Name = "chtXYZ";
            this.chtXYZ.RightToLeft = System.Windows.Forms.RightToLeft.No;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series1.Legend = "Legend1";
            series1.Name = "SeriesX";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series2.Legend = "Legend1";
            series2.Name = "SeriesY";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series3.Legend = "Legend1";
            series3.Name = "SeriesZ";
            this.chtXYZ.Series.Add(series1);
            this.chtXYZ.Series.Add(series2);
            this.chtXYZ.Series.Add(series3);
            this.chtXYZ.Size = new System.Drawing.Size(675, 300);
            this.chtXYZ.TabIndex = 8;
            this.chtXYZ.Text = "XYZ Line Chart";
            // 
            // timerUpdateCmb
            // 
            this.timerUpdateCmb.Enabled = true;
            this.timerUpdateCmb.Interval = 50;
            this.timerUpdateCmb.Tick += new System.EventHandler(this.timerUpdate_Tick);
            // 
            // serialCOM
            // 
            this.serialCOM.BaudRate = 128000;
            this.serialCOM.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialCOM_DataReceived);
            // 
            // pgbarBuffer
            // 
            this.pgbarBuffer.Location = new System.Drawing.Point(419, 21);
            this.pgbarBuffer.Name = "pgbarBuffer";
            this.pgbarBuffer.Size = new System.Drawing.Size(159, 31);
            this.pgbarBuffer.TabIndex = 9;
            // 
            // tmrUpdateData
            // 
            this.tmrUpdateData.Enabled = true;
            this.tmrUpdateData.Interval = 50;
            this.tmrUpdateData.Tick += new System.EventHandler(this.tmrUpdateData_Tick);
            // 
            // labelShowBufferFill
            // 
            this.labelShowBufferFill.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.labelShowBufferFill.AutoSize = true;
            this.labelShowBufferFill.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelShowBufferFill.Location = new System.Drawing.Point(609, 25);
            this.labelShowBufferFill.Name = "labelShowBufferFill";
            this.labelShowBufferFill.Size = new System.Drawing.Size(23, 25);
            this.labelShowBufferFill.TabIndex = 11;
            this.labelShowBufferFill.Text = " /";
            // 
            // panelMy2048
            // 
            this.panelMy2048.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panelMy2048.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelMy2048.Controls.Add(this.labelGameStatus);
            this.panelMy2048.Location = new System.Drawing.Point(1009, 21);
            this.panelMy2048.Name = "panelMy2048";
            this.panelMy2048.Size = new System.Drawing.Size(650, 650);
            this.panelMy2048.TabIndex = 12;
            // 
            // cbxSaveToFile
            // 
            this.cbxSaveToFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cbxSaveToFile.AutoSize = true;
            this.cbxSaveToFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxSaveToFile.Location = new System.Drawing.Point(1071, 810);
            this.cbxSaveToFile.Name = "cbxSaveToFile";
            this.cbxSaveToFile.Size = new System.Drawing.Size(137, 29);
            this.cbxSaveToFile.TabIndex = 13;
            this.cbxSaveToFile.Text = "Save to File";
            this.cbxSaveToFile.UseVisualStyleBackColor = true;
            // 
            // txtDirectory
            // 
            this.txtDirectory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtDirectory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDirectory.Location = new System.Drawing.Point(1229, 808);
            this.txtDirectory.Name = "txtDirectory";
            this.txtDirectory.Size = new System.Drawing.Size(276, 30);
            this.txtDirectory.TabIndex = 14;
            // 
            // btnBrowse
            // 
            this.btnBrowse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnBrowse.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBrowse.Location = new System.Drawing.Point(1511, 805);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(148, 47);
            this.btnBrowse.TabIndex = 15;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // pbarXA
            // 
            this.pbarXA.Location = new System.Drawing.Point(350, 57);
            this.pbarXA.Name = "pbarXA";
            this.pbarXA.Size = new System.Drawing.Size(228, 31);
            this.pbarXA.TabIndex = 16;
            // 
            // pbarYA
            // 
            this.pbarYA.Location = new System.Drawing.Point(350, 93);
            this.pbarYA.Name = "pbarYA";
            this.pbarYA.Size = new System.Drawing.Size(228, 31);
            this.pbarYA.TabIndex = 17;
            // 
            // pbarZA
            // 
            this.pbarZA.Location = new System.Drawing.Point(350, 129);
            this.pbarZA.Name = "pbarZA";
            this.pbarZA.Size = new System.Drawing.Size(228, 31);
            this.pbarZA.TabIndex = 18;
            // 
            // txtZAvg
            // 
            this.txtZAvg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtZAvg.Location = new System.Drawing.Point(14, 253);
            this.txtZAvg.Name = "txtZAvg";
            this.txtZAvg.Size = new System.Drawing.Size(161, 30);
            this.txtZAvg.TabIndex = 21;
            // 
            // txtYAvg
            // 
            this.txtYAvg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtYAvg.Location = new System.Drawing.Point(14, 217);
            this.txtYAvg.Name = "txtYAvg";
            this.txtYAvg.Size = new System.Drawing.Size(161, 30);
            this.txtYAvg.TabIndex = 20;
            // 
            // txtXAvg
            // 
            this.txtXAvg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtXAvg.Location = new System.Drawing.Point(14, 181);
            this.txtXAvg.Name = "txtXAvg";
            this.txtXAvg.Size = new System.Drawing.Size(161, 30);
            this.txtXAvg.TabIndex = 19;
            // 
            // txtAvgN
            // 
            this.txtAvgN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAvgN.Location = new System.Drawing.Point(476, 181);
            this.txtAvgN.Name = "txtAvgN";
            this.txtAvgN.Size = new System.Drawing.Size(102, 30);
            this.txtAvgN.TabIndex = 26;
            // 
            // txtOrientation
            // 
            this.txtOrientation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOrientation.Location = new System.Drawing.Point(476, 253);
            this.txtOrientation.Name = "txtOrientation";
            this.txtOrientation.Size = new System.Drawing.Size(102, 30);
            this.txtOrientation.TabIndex = 28;
            this.txtOrientation.TextChanged += new System.EventHandler(this.txtOrientation_TextChanged);
            // 
            // tmrUpdateOrientation
            // 
            this.tmrUpdateOrientation.Enabled = true;
            this.tmrUpdateOrientation.Interval = 50;
            this.tmrUpdateOrientation.Tick += new System.EventHandler(this.tmrUpdateOrientation_Tick);
            // 
            // listGestureHistory
            // 
            this.listGestureHistory.FormattingEnabled = true;
            this.listGestureHistory.ItemHeight = 16;
            this.listGestureHistory.Location = new System.Drawing.Point(693, 107);
            this.listGestureHistory.Name = "listGestureHistory";
            this.listGestureHistory.Size = new System.Drawing.Size(307, 564);
            this.listGestureHistory.TabIndex = 29;
            // 
            // txtGesture
            // 
            this.txtGesture.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGesture.Location = new System.Drawing.Point(693, 60);
            this.txtGesture.Name = "txtGesture";
            this.txtGesture.Size = new System.Drawing.Size(307, 30);
            this.txtGesture.TabIndex = 31;
            // 
            // txtScore
            // 
            this.txtScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtScore.Location = new System.Drawing.Point(1074, 687);
            this.txtScore.Name = "txtScore";
            this.txtScore.Size = new System.Drawing.Size(102, 30);
            this.txtScore.TabIndex = 33;
            // 
            // labelIsStarted
            // 
            labelIsStarted.AutoSize = true;
            labelIsStarted.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            labelIsStarted.Location = new System.Drawing.Point(1004, 690);
            labelIsStarted.Name = "labelIsStarted";
            labelIsStarted.Size = new System.Drawing.Size(64, 25);
            labelIsStarted.TabIndex = 34;
            labelIsStarted.Text = "Score";
            // 
            // labelGameStatus
            // 
            this.labelGameStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelGameStatus.AutoSize = true;
            this.labelGameStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGameStatus.Location = new System.Drawing.Point(2, 269);
            this.labelGameStatus.Name = "labelGameStatus";
            this.labelGameStatus.Size = new System.Drawing.Size(647, 91);
            this.labelGameStatus.TabIndex = 0;
            this.labelGameStatus.Text = "labelGameStatus";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label6.Location = new System.Drawing.Point(288, 303);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(120, 25);
            label6.TabIndex = 35;
            label6.Text = "Acceleration";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label7.Location = new System.Drawing.Point(308, 634);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(81, 25);
            label7.TabIndex = 37;
            label7.Text = "Velocity";
            // 
            // chartVelocity
            // 
            this.chartVelocity.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            chartArea2.Name = "ChartArea1";
            this.chartVelocity.ChartAreas.Add(chartArea2);
            legend2.Alignment = System.Drawing.StringAlignment.Center;
            legend2.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            legend2.MaximumAutoSize = 10F;
            legend2.Name = "Legend1";
            this.chartVelocity.Legends.Add(legend2);
            this.chartVelocity.Location = new System.Drawing.Point(12, 662);
            this.chartVelocity.MinimumSize = new System.Drawing.Size(675, 300);
            this.chartVelocity.Name = "chartVelocity";
            this.chartVelocity.RightToLeft = System.Windows.Forms.RightToLeft.No;
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series4.Legend = "Legend1";
            series4.Name = "X Vel";
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series5.Legend = "Legend1";
            series5.Name = "Y Vel";
            series6.ChartArea = "ChartArea1";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series6.Legend = "Legend1";
            series6.Name = "Z Vel";
            this.chartVelocity.Series.Add(series4);
            this.chartVelocity.Series.Add(series5);
            this.chartVelocity.Series.Add(series6);
            this.chartVelocity.Size = new System.Drawing.Size(675, 300);
            this.chartVelocity.TabIndex = 36;
            this.chartVelocity.Text = "Velocity Chart";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1671, 1002);
            this.Controls.Add(label7);
            this.Controls.Add(this.chartVelocity);
            this.Controls.Add(label6);
            this.Controls.Add(labelIsStarted);
            this.Controls.Add(this.txtScore);
            this.Controls.Add(this.txtGesture);
            this.Controls.Add(labelGesture);
            this.Controls.Add(this.listGestureHistory);
            this.Controls.Add(this.txtOrientation);
            this.Controls.Add(labelOrientation);
            this.Controls.Add(this.txtAvgN);
            this.Controls.Add(label2);
            this.Controls.Add(label3);
            this.Controls.Add(label5);
            this.Controls.Add(label4);
            this.Controls.Add(this.txtZAvg);
            this.Controls.Add(this.txtYAvg);
            this.Controls.Add(this.txtXAvg);
            this.Controls.Add(this.pbarZA);
            this.Controls.Add(this.pbarYA);
            this.Controls.Add(this.pbarXA);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.txtDirectory);
            this.Controls.Add(this.cbxSaveToFile);
            this.Controls.Add(this.panelMy2048);
            this.Controls.Add(label1);
            this.Controls.Add(this.labelShowBufferFill);
            this.Controls.Add(this.pgbarBuffer);
            this.Controls.Add(this.chtXYZ);
            this.Controls.Add(labelZA);
            this.Controls.Add(labelYA);
            this.Controls.Add(labelXA);
            this.Controls.Add(this.txtZA);
            this.Controls.Add(this.txtYA);
            this.Controls.Add(this.txtXA);
            this.Controls.Add(this.cmbSerial);
            this.Controls.Add(this.btnSerial);
            this.MinimumSize = new System.Drawing.Size(1223, 578);
            this.Name = "Form1";
            this.Text = "Main";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chtXYZ)).EndInit();
            this.panelMy2048.ResumeLayout(false);
            this.panelMy2048.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartVelocity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSerial;
        private System.Windows.Forms.ComboBox cmbSerial;
        private System.Windows.Forms.TextBox txtXA;
        private System.Windows.Forms.TextBox txtYA;
        private System.Windows.Forms.TextBox txtZA;
        private System.Windows.Forms.DataVisualization.Charting.Chart chtXYZ;
        private System.Windows.Forms.Timer timerUpdateCmb;
        private System.IO.Ports.SerialPort serialCOM;
        private System.Windows.Forms.ProgressBar pgbarBuffer;
        private System.Windows.Forms.Timer tmrUpdateData;
        private System.Windows.Forms.Label labelShowBufferFill;
        private System.Windows.Forms.Panel panelMy2048;
        private System.Windows.Forms.CheckBox cbxSaveToFile;
        private System.Windows.Forms.TextBox txtDirectory;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.ProgressBar pbarXA;
        private System.Windows.Forms.ProgressBar pbarYA;
        private System.Windows.Forms.ProgressBar pbarZA;
        private System.Windows.Forms.TextBox txtZAvg;
        private System.Windows.Forms.TextBox txtYAvg;
        private System.Windows.Forms.TextBox txtXAvg;
        private System.Windows.Forms.TextBox txtAvgN;
        private System.Windows.Forms.TextBox txtOrientation;
        private System.Windows.Forms.Timer tmrUpdateOrientation;
        private System.Windows.Forms.ListBox listGestureHistory;
        private System.Windows.Forms.TextBox txtGesture;
        private System.Windows.Forms.TextBox txtScore;
        private System.Windows.Forms.Label labelGameStatus;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartVelocity;
    }
}

