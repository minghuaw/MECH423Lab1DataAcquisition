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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series13 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series14 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series15 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.btnSerial = new System.Windows.Forms.Button();
            this.cmbSerial = new System.Windows.Forms.ComboBox();
            this.txtXA = new System.Windows.Forms.TextBox();
            this.txtYA = new System.Windows.Forms.TextBox();
            this.txtZA = new System.Windows.Forms.TextBox();
            this.labelXA = new System.Windows.Forms.Label();
            this.labelYA = new System.Windows.Forms.Label();
            this.labelZA = new System.Windows.Forms.Label();
            this.chtXYZ = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.timerUpdateCmb = new System.Windows.Forms.Timer(this.components);
            this.serialCOM = new System.IO.Ports.SerialPort(this.components);
            this.pgbarBuffer = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.tmrUpdateData = new System.Windows.Forms.Timer(this.components);
            this.labelShowBufferFill = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chtXYZ)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSerial
            // 
            this.btnSerial.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSerial.Location = new System.Drawing.Point(181, 21);
            this.btnSerial.Name = "btnSerial";
            this.btnSerial.Size = new System.Drawing.Size(125, 31);
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
            // labelXA
            // 
            this.labelXA.AutoSize = true;
            this.labelXA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelXA.Location = new System.Drawing.Point(176, 63);
            this.labelXA.Name = "labelXA";
            this.labelXA.Size = new System.Drawing.Size(139, 25);
            this.labelXA.TabIndex = 5;
            this.labelXA.Text = "X Acceleration";
            // 
            // labelYA
            // 
            this.labelYA.AutoSize = true;
            this.labelYA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelYA.Location = new System.Drawing.Point(176, 99);
            this.labelYA.Name = "labelYA";
            this.labelYA.Size = new System.Drawing.Size(138, 25);
            this.labelYA.TabIndex = 6;
            this.labelYA.Text = "Y Acceleration";
            // 
            // labelZA
            // 
            this.labelZA.AutoSize = true;
            this.labelZA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelZA.Location = new System.Drawing.Point(176, 135);
            this.labelZA.Name = "labelZA";
            this.labelZA.Size = new System.Drawing.Size(137, 25);
            this.labelZA.TabIndex = 7;
            this.labelZA.Text = "Z Acceleration";
            // 
            // chtXYZ
            // 
            this.chtXYZ.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            chartArea5.Name = "ChartArea1";
            this.chtXYZ.ChartAreas.Add(chartArea5);
            legend5.Alignment = System.Drawing.StringAlignment.Center;
            legend5.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            legend5.MaximumAutoSize = 10F;
            legend5.Name = "Legend1";
            this.chtXYZ.Legends.Add(legend5);
            this.chtXYZ.Location = new System.Drawing.Point(12, 168);
            this.chtXYZ.Name = "chtXYZ";
            this.chtXYZ.RightToLeft = System.Windows.Forms.RightToLeft.No;
            series13.ChartArea = "ChartArea1";
            series13.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series13.Legend = "Legend1";
            series13.Name = "SeriesX";
            series14.ChartArea = "ChartArea1";
            series14.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series14.Legend = "Legend1";
            series14.Name = "SeriesY";
            series15.ChartArea = "ChartArea1";
            series15.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series15.Legend = "Legend1";
            series15.Name = "SeriesZ";
            this.chtXYZ.Series.Add(series13);
            this.chtXYZ.Series.Add(series14);
            this.chtXYZ.Series.Add(series15);
            this.chtXYZ.Size = new System.Drawing.Size(519, 355);
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
            this.serialCOM.ReadBufferSize = 16;
            this.serialCOM.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialCOM_DataReceived);
            // 
            // pgbarBuffer
            // 
            this.pgbarBuffer.Location = new System.Drawing.Point(441, 21);
            this.pgbarBuffer.Name = "pgbarBuffer";
            this.pgbarBuffer.Size = new System.Drawing.Size(137, 31);
            this.pgbarBuffer.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(372, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 25);
            this.label1.TabIndex = 10;
            this.label1.Text = "Buffer";
            // 
            // tmrUpdateData
            // 
            this.tmrUpdateData.Enabled = true;
            this.tmrUpdateData.Interval = 50;
            this.tmrUpdateData.Tick += new System.EventHandler(this.tmrUpdateData_Tick);
            // 
            // labelShowBufferFill
            // 
            this.labelShowBufferFill.AutoSize = true;
            this.labelShowBufferFill.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelShowBufferFill.Location = new System.Drawing.Point(584, 24);
            this.labelShowBufferFill.Name = "labelShowBufferFill";
            this.labelShowBufferFill.Size = new System.Drawing.Size(23, 25);
            this.labelShowBufferFill.TabIndex = 11;
            this.labelShowBufferFill.Text = " /";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(975, 535);
            this.Controls.Add(this.labelShowBufferFill);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pgbarBuffer);
            this.Controls.Add(this.chtXYZ);
            this.Controls.Add(this.labelZA);
            this.Controls.Add(this.labelYA);
            this.Controls.Add(this.labelXA);
            this.Controls.Add(this.txtZA);
            this.Controls.Add(this.txtYA);
            this.Controls.Add(this.txtXA);
            this.Controls.Add(this.cmbSerial);
            this.Controls.Add(this.btnSerial);
            this.Name = "Form1";
            this.Text = "Main";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.chtXYZ)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSerial;
        private System.Windows.Forms.ComboBox cmbSerial;
        private System.Windows.Forms.TextBox txtXA;
        private System.Windows.Forms.TextBox txtYA;
        private System.Windows.Forms.TextBox txtZA;
        private System.Windows.Forms.Label labelXA;
        private System.Windows.Forms.Label labelYA;
        private System.Windows.Forms.Label labelZA;
        private System.Windows.Forms.DataVisualization.Charting.Chart chtXYZ;
        private System.Windows.Forms.Timer timerUpdateCmb;
        private System.IO.Ports.SerialPort serialCOM;
        private System.Windows.Forms.ProgressBar pgbarBuffer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer tmrUpdateData;
        private System.Windows.Forms.Label labelShowBufferFill;
    }
}

