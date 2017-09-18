using System;
using System.Windows;
using System.Windows.Forms.Integration;
using System.Windows.Media;
using System.Collections.Generic;
using System.IO.Ports;
using System.IO;
using System.Collections.Concurrent;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MECH423Lab1DataAcquisition
{
    public partial class Form1 : Form
    {
        ConcurrentQueue<int> dataQueue = new ConcurrentQueue<int>();
        ConcurrentQueue<double> timeQueue = new ConcurrentQueue<double>();
        ConcurrentQueue<double> xAvgBuffer = new ConcurrentQueue<double>();
        ConcurrentQueue<double> yAvgBuffer = new ConcurrentQueue<double>();
        ConcurrentQueue<double> zAvgBuffer = new ConcurrentQueue<double>();
        ConcurrentQueue<string> gestureHist = new ConcurrentQueue<string>();

        DateTime startTime, nulTime;
        StreamWriter outputFile;

        int zeroG = 127;
        int punchThreshold = 113;
        int highPunchThreshold = 93;
        int rightHookThreshold = 83;
        int gestureState = 0;
        double gestureTime = -1;
        int gestureCount = 0;
        double chartXSize = 4.0;
        double lastXV = 0;
        double lastYV = 0;
        double lastZV = 0;
        double? lastTime = null;
        double g = 9.81;

        private ElementHost ctrlHost;
        private WPF2048.My2048 wpfCtrl;
        private MyControls.MyControl1 myCtrl;
        System.Windows.FontWeight initFontWeight;
        double initFontSize;
        System.Windows.FontStyle initFontStyle;
        System.Windows.Media.SolidColorBrush initBackBrush;
        System.Windows.Media.SolidColorBrush initForeBrush;
        System.Windows.Media.FontFamily initFontFamily;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ctrlHost = new ElementHost();
            ctrlHost.Dock = DockStyle.Fill;
            
            panelMy2048.Controls.Add(ctrlHost);
            wpfCtrl = new WPF2048.My2048();
            wpfCtrl.InitializeComponent();
            ctrlHost.Child = wpfCtrl;
            wpfCtrl.InitGame();
            labelGameStatus.Text = "";

            //myCtrl = new MyControls.MyControl1();
            //myCtrl.InitializeComponent();
            //ctrlHost.Child = myCtrl;           

            //myCtrl.Loaded += new RoutedEventHandler(avAddressCtrl_Loaded);

            chtXYZ.ChartAreas[0].AxisY.Maximum = ConvertAccToMetric(255) + 1;
            chtXYZ.ChartAreas[0].AxisY.Minimum = ConvertAccToMetric(0) - 1;
            chtXYZ.ChartAreas[0].AxisY.Title = "Acceleration (m/s^2)";
            chtXYZ.ChartAreas[0].AxisX.Title = "Time (s)";

            // Set maximum and minimum of x y z acceleration progress bar
            pbarXA.Maximum = 255;
            pbarXA.Minimum = 0;
            pbarYA.Maximum = 255;
            pbarYA.Minimum = 0;
            pbarZA.Maximum = 255;
            pbarZA.Minimum = 0;
        }

        private void avAddressCtrl_Loaded(object sender, EventArgs e)
        {
            initBackBrush = (SolidColorBrush)myCtrl.MyControl_Background;
            initForeBrush = myCtrl.MyControl_Foreground;
            initFontFamily = myCtrl.MyControl_FontFamily;
            initFontSize = myCtrl.MyControl_FontSize;
            initFontWeight = myCtrl.MyControl_FontWeight;
            initFontStyle = myCtrl.MyControl_FontStyle;
        }

        private void timerUpdate_Tick(object sender, EventArgs e)
        {            
            string[] ports = SerialPort.GetPortNames().ToArray();

            if (cmbSerial.DataSource == null)
            {
                cmbSerial.DataSource = ports;
            }     
        }      

        private void btnSerial_Click(object sender, EventArgs e)
        {          
            if (cmbSerial.Enabled == true)
            {
                if (cmbSerial.SelectedIndex != -1)
                {                 
                    serialCOM.PortName = cmbSerial.SelectedItem.ToString();
                }
            }

            if (!serialCOM.IsOpen)
            {
                serialCOM.BaudRate = 128000;
                serialCOM.Open();
                btnSerial.Text = "Disconnect";
                cmbSerial.Enabled = false;

                if (startTime.Equals(nulTime))
                {
                    startTime = DateTime.Now;
                }
            }
            else
            {
                serialCOM.Close();
                btnSerial.Text = "Connect";
                cmbSerial.Enabled = true;
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (serialCOM != null && serialCOM.IsOpen)
            {
                serialCOM.Close();
            }
        }

        private void tmrUpdateData_Tick(object sender, EventArgs e)
        {
            int startByte, tmpXA, tmpYA, tmpZA;
            double tmpTime, metXA, metYA, metZA;

            if (dataQueue.Count >= 4)
            {
                for (int i = 0; i < dataQueue.Count / 4; i++)
                {
                    dataQueue.TryDequeue(out startByte);
                    if (startByte == 255)
                    {
                        dataQueue.TryDequeue(out tmpXA);
                        dataQueue.TryDequeue(out tmpYA);
                        dataQueue.TryDequeue(out tmpZA);
                        timeQueue.TryDequeue(out tmpTime);

                        // Convert data to metric uint
                        metXA = ConvertAccToMetric(tmpXA);
                        metYA = ConvertAccToMetric(tmpYA);
                        metZA = ConvertAccToMetric(tmpZA);

                        UpdateTxt(tmpXA, tmpYA, tmpZA);
                        UpdateGesture(tmpXA, tmpYA, tmpZA, tmpTime);
                        UpdateAvg(tmpXA, tmpYA, tmpZA);
                        UpdateACCPBar(tmpXA, tmpYA, tmpZA);
                        UpdateChart(metXA, metYA, metZA, tmpTime);

                        // save data to CSV file
                        SaveToCSV(tmpXA, tmpYA, tmpZA, tmpTime, ",");
                    }
                }
            }

            if (serialCOM.IsOpen)
            {
                UpdatePBarBuffer();
            }
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                txtDirectory.Text = openFile.FileName;
                outputFile = new StreamWriter(openFile.FileName);                
            }
        }

        private void SaveToCSV(int xa, int ya, int za, double t, string delim)
        {
            if (cbxSaveToFile.Checked == true && txtDirectory.Text != "") 
            {
                outputFile.Write(t + delim);
                outputFile.Write(xa + delim);
                outputFile.Write(ya + delim);
                outputFile.Write(za + "\n");
            }
        }

        private double ConvertAccToMetric(double acc)
        {
            double m = 0.24525, b = -31.14675;

            return (m*acc + b); 
        }

        private void serialCOM_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            int byteLen = serialCOM.BytesToRead;
            byte[] byteBuffer = new byte[byteLen];
            if (serialCOM.IsOpen)
            {
                int tempBytesToRead = 0;
                try
                {
                    tempBytesToRead = serialCOM.BytesToRead;
                }
                catch { }

                for (int i = 0; i < tempBytesToRead; i++)
                {
                    int temp = -1;
                    double timeDiff;

                    try
                    {
                        temp = serialCOM.ReadByte();
                    }
                    catch { }                    
                    
                    if (temp != -1)
                        dataQueue.Enqueue(temp);//Append data and time to queues

                    if (i%4 == 0)
                    {
                        DateTime tempTime = DateTime.Now;
                        timeDiff = tempTime.Subtract(startTime).TotalSeconds;
                        timeQueue.Enqueue(timeDiff);
                    }
                }
            }
        }

        private void UpdateTxt(double xA, double yA, double zA)
        {
            txtXA.Text = xA.ToString();
            txtYA.Text = yA.ToString();
            txtZA.Text = zA.ToString();
        }

        private void UpdateChart(double xA, double yA, double zA, double time)
        {
            chtXYZ.Series["SeriesX"].Points.AddXY(time, xA);
            chtXYZ.Series["SeriesY"].Points.AddXY(time, yA);
            chtXYZ.Series["SeriesZ"].Points.AddXY(time, zA);

            double tempMax = chtXYZ.ChartAreas[0].AxisX.Maximum;
            chtXYZ.ChartAreas[0].AxisX.Minimum = tempMax - chartXSize;

            //// Update velocity chart
            //lastXV = lastXV + CalcdVel(xA, time);
            //lastYV = lastYV + CalcdVel(yA, time);
            //lastZV = lastZV + CalcdVel(zA-g, time);
            //lastTime = time;

            //chartVelocity.Series[0].Points.AddXY(time, lastXV);
            //chartVelocity.Series[1].Points.AddXY(time, lastYV);
            //chartVelocity.Series[2].Points.AddXY(time, lastZV);

            //tempMax = chtXYZ.ChartAreas[0].AxisX.Maximum;
            //chartVelocity.ChartAreas[0].AxisX.Minimum = tempMax - chartXSize;
        }

        private double CalcdVel(double acc, double time)
        {
            double dt, dVel = 0;
            if (lastTime != null)
            {
                dt = time - (double)lastTime;
                dVel = acc * dt;
            }

            return dVel;
        }

        private void UpdatePBarBuffer()
        {
            pgbarBuffer.Visible = true;
            pgbarBuffer.Maximum = serialCOM.ReadBufferSize;
            pgbarBuffer.Minimum = 0;

            try
            {
                pgbarBuffer.Value = serialCOM.BytesToRead;
            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show(e.Message);
            }
            labelShowBufferFill.Text = serialCOM.BytesToRead.ToString() + "/" + serialCOM.ReadBufferSize.ToString();
            pgbarBuffer.Refresh();
        }

        private void UpdateACCPBar(int xA, int yA, int zA)
        {
            try
            {
                pbarXA.Value = xA;
                pbarYA.Value = yA;
                pbarZA.Value = zA;
            }
            catch { }
        }

        private void UpdateAvg(int xA, int yA, int zA)
        {
            double temp = 0;
            double xAvg, yAvg, zAvg;
            int toAvgN = GetAvgN();

            if (xAvgBuffer.Count > toAvgN)
            {
                xAvgBuffer.TryDequeue(out temp);
                yAvgBuffer.TryDequeue(out temp);
                zAvgBuffer.TryDequeue(out temp);
            }
            else
            {
                xAvgBuffer.Enqueue((double)xA);
                yAvgBuffer.Enqueue((double)yA);
                zAvgBuffer.Enqueue((double)zA);
            }

            if (xAvgBuffer.Count > toAvgN - 5)
            {
                xAvg = xAvgBuffer.ToArray().Average();
                yAvg = yAvgBuffer.ToArray().Average();
                zAvg = zAvgBuffer.ToArray().Average();

                txtXAvg.Text = xAvg.ToString();
                txtYAvg.Text = yAvg.ToString();
                txtZAvg.Text = zAvg.ToString();
            }
        }

        // Update orientation
        private void UpdateOrientation()
        {            
            int xA = -1, yA = -1, zA = -1;

            if (serialCOM.IsOpen)
            {
                if (txtXA.Text != "")
                    xA = Convert.ToInt32(txtXA.Text);
                if (txtYA.Text != "")
                    yA = Convert.ToInt32(txtYA.Text);
                if (txtZA.Text != "")
                    zA = Convert.ToInt32(txtZA.Text);
            }

            if (xA > -1 && yA > -1 && zA > -1)
            {
                if (xA > 160)
                    txtOrientation.Text = "forward";
                else if (xA < 94)
                    txtOrientation.Text = "backward";
                else if (yA > 160)
                    txtOrientation.Text = "left";
                else if (yA < 94)
                    txtOrientation.Text = "right";
                else if (zA > 160)
                    txtOrientation.Text = "up";
                else if (zA < 94)
                    txtOrientation.Text = "down";
            }
        }

        private void UpdateGesture(int xA, int yA, int zA, double time)
        {
            double gTimeDiff = time - gestureTime;            
            if (gTimeDiff > 1)
            {
                gestureState = 0;
                txtGesture.Clear();
            }
            
            if (gestureState == 0)
            {               
                if (xA > 230)
                {
                    gestureState = 1;
                    gestureTime = time;
                }               
                else if (zA > 230)
                {
                    gestureState = 2;
                    gestureTime = time;
                }

                if (yA > 230)
                {
                    gestureState = 3;
                    gestureTime = time;
                }
            }
            else if (gTimeDiff > 0.02 && gTimeDiff < 0.1)
            {
                if (gestureState == 1 && xA > 200)
                {
                    gestureState = 4;
                    gestureCount++;
                }

                if (gestureState == 2 && xA > 200 && xA < 240)
                {
                    gestureState = 5;
                    gestureCount++;
                }

                if (gestureState == 3 && yA > 210)
                {
                    gestureState = 6;
                    gestureCount++;
                }
            }

            if (listGestureHistory.Items.Count < gestureCount)
            {
                if (gestureState == 4)
                {
                    txtGesture.Text = "Simple Punch";
                    gestureHist.Enqueue("Simple Punch");
                }
                else if (gestureState == 5)
                {
                    txtGesture.Text = "High Punch";
                    gestureHist.Enqueue("High Punch");
                }
                else if (gestureState == 6)
                {
                    txtGesture.Text = "Right hook";
                    gestureHist.Enqueue("Right hook");
                }
            }

            UpdateGestureHist();
        }

        private void UpdateGestureHist()
        {
            //listGestureHistory.Items.Clear();
            string[] gestArray = gestureHist.ToArray();
            string temp;
            if (gestureHist.Count > 0)
            {               
                gestureHist.TryDequeue(out temp);
                listGestureHistory.Items.Add(temp);
                //listGestureHistory.Items.AddRange(gestArray.Cast<Object>().ToArray<Object>());
            }
        }

        private void UpdateScore()
        {
            txtScore.Text = wpfCtrl.GetScore().ToString();
        }

        private void tmrUpdateOrientation_Tick(object sender, EventArgs e)
        {
            UpdateOrientation();           
        }

        private void btnStartGame_MouseClick(object sender, MouseEventArgs e)
        {
            if (wpfCtrl.IsStarted())
            {
                wpfCtrl.Pause();
            }
            else
            {
                wpfCtrl.Resume();
            }

            wpfCtrl.UpdateGrid();
        }

        private void txtOrientation_TextChanged(object sender, EventArgs e)
        {
            string temp = txtOrientation.Text;
            if (wpfCtrl.IsStarted())
            {
                if (temp != "up" && temp != "down" && temp != "")
                {
                    wpfCtrl.Move(txtOrientation.Text);
                }
            }

            UpdateScore();

            if (wpfCtrl.IsGameOver())
            {
                labelGameStatus.Text = "Game is over";
            }
        }

        private int GetAvgN()
        {
            int n = 100;

            if (txtAvgN.Text != "")
            {
                if (Int32.TryParse(txtAvgN.Text, out n))
                    return n;
            }

            return n;
        }
    }
}
