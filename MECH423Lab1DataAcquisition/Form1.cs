using System;
using System.Windows;
using System.Windows.Forms.Integration;
using System.Windows.Media;
using System.Collections.Generic;
using System.IO.Ports;
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
        DateTime startTime, nulTime;
        double chartXSize = 2.0;

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

            //myCtrl = new MyControls.MyControl1();
            //myCtrl.InitializeComponent();
            //ctrlHost.Child = myCtrl;

            //myCtrl.Loaded += new RoutedEventHandler(avAddressCtrl_Loaded);
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

        private void UpdateTxt(int xA, int yA, int zA)
        {
            txtXA.Text = xA.ToString();
            txtYA.Text = yA.ToString();
            txtZA.Text = zA.ToString();
        }

        private void UpdateChart(int xA, int yA, int zA, double time)
        {
            chtXYZ.Series["SeriesX"].Points.AddXY(time, (double)xA);
            chtXYZ.Series["SeriesY"].Points.AddXY(time, (double)yA);
            chtXYZ.Series["SeriesZ"].Points.AddXY(time, (double)zA);

            double tempMax = chtXYZ.ChartAreas[0].AxisX.Maximum;
            chtXYZ.ChartAreas[0].AxisX.Minimum = tempMax - chartXSize;            
        }

        private void UpdatePBarBuffer()
        {
            pgbarBuffer.Visible = true;
            pgbarBuffer.Maximum = serialCOM.ReadBufferSize;
            pgbarBuffer.Minimum = 0;

            pgbarBuffer.Value = serialCOM.BytesToRead;
            labelShowBufferFill.Text = serialCOM.BytesToRead.ToString() + "/" + serialCOM.ReadBufferSize.ToString();
            pgbarBuffer.Refresh();
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
            double tmpTime;

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

                        UpdateTxt(tmpXA, tmpYA, tmpZA);
                        UpdateChart(tmpXA, tmpYA, tmpZA, tmpTime);
                    }
                }
            }

            if (serialCOM.IsOpen)
            {
                UpdatePBarBuffer();
            }
        }


        private void serialCOM_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            int byteLen = serialCOM.BytesToRead;
            byte[] byteBuffer = new byte[byteLen];
            if (serialCOM.IsOpen)
            {
                for (int i = 0; i < serialCOM.BytesToRead; i++)
                {
                    int temp = serialCOM.ReadByte();
                    double timeDiff;
                
                    //Append data and time to queues
                    dataQueue.Enqueue(temp);

                    if (i%4 == 0)
                    {
                        DateTime tempTime = DateTime.Now;
                        timeDiff = tempTime.Subtract(startTime).TotalSeconds;
                        timeQueue.Enqueue(timeDiff);
                    }
                }
            }
        }
    }
}
