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
using System.Collections.Concurrent;
using System.Windows.Forms.DataVisualization.Charting;
using WindowsInput;
using WindowsInput.Native;

namespace SuperMario
{
    public partial class DataTester : Form
    {

        public DataTester()
        {
            InitializeComponent();

            AccelGraph.Series.Add("Accel_X");
            AccelGraph.Series["Accel_X"].ChartType = SeriesChartType.FastLine;
            AccelGraph.Series["Accel_X"].Color = Color.Blue;

            AccelGraph.Series.Add("Accel_Y");
            AccelGraph.Series["Accel_Y"].ChartType = SeriesChartType.FastLine;
            AccelGraph.Series["Accel_Y"].Color = Color.Green;

            AccelGraph.Series.Add("Accel_Z");
            AccelGraph.Series["Accel_Z"].ChartType = SeriesChartType.FastLine;
            AccelGraph.Series["Accel_Z"].Color = Color.Yellow;

            GlobalVariables.Accel_X.Add(0);
            GlobalVariables.Accel_Y.Add(0);
            GlobalVariables.Accel_Z.Add(0);
        }

        public static class GlobalVariables
        {
            public static Axis_Acceleration AccelerationData = new Axis_Acceleration();
            public static List<double> Accel_X = new List<double>();
            public static List<double> Accel_Y = new List<double>();
            public static List<double> Accel_Z = new List<double>();
        }

        string[] PortArray;
        public class Axis_Acceleration
        {
            public double X, Y, Z;
        }

        InputSimulator InputSimulator = new InputSimulator();
        string keystate = "";
        string keystate2 = "";
        private void timer_Tick(object sender, EventArgs e)
        {
            string[] test = SerialPort.GetPortNames().ToArray();
            if (SerialPortListBox.DroppedDown == false) //Prevent list updates during drop down activated so list doesn't flash
            {
                PortArray = SerialPort.GetPortNames().ToArray();
                SerialPortListBox.Items.Clear();
                foreach (string portname in PortArray)
                {
                    SerialPortListBox.Items.Add(portname);
                }
            }

            //Retrieve Acceleration data from one data packet
            if (DisconnectButton.Text == "Disconnect")
            {
                int QueueData;
                SerialReceivedQueue.TryDequeue(out QueueData);
                GlobalVariables.AccelerationData.X = QueueData;
                SerialReceivedQueue.TryDequeue(out QueueData);
                GlobalVariables.AccelerationData.Y = QueueData;
                SerialReceivedQueue.TryDequeue(out QueueData);
                GlobalVariables.AccelerationData.Z = QueueData;

                if (GlobalVariables.AccelerationData.X == 0 || GlobalVariables.AccelerationData.Y == 0 || GlobalVariables.AccelerationData.Z == 0)
                {
                    return;
                }

                XaxisBox.Text = GlobalVariables.AccelerationData.X.ToString();
                YaxisBox.Text = GlobalVariables.AccelerationData.Y.ToString();
                ZaxisBox.Text = GlobalVariables.AccelerationData.Z.ToString();

                int YUpper = 135;
                int YLower = 120;
                int XUpper = 160;
                int XLower = 122;

                if (Convert.ToInt32(YaxisBox.Text) < YLower && Convert.ToInt32(YaxisBox.Text) > 0 && keystate != "left") //Left
                {
                    InputSimulator.Keyboard.KeyUp(VirtualKeyCode.RIGHT);
                    InputSimulator.Keyboard.KeyDown(VirtualKeyCode.LEFT);
                    keystate = "left";
                }
                else if (Convert.ToInt32(YaxisBox.Text) > YUpper && Convert.ToInt32(YaxisBox.Text) > 0 && keystate != "right") //Right
                {
                    InputSimulator.Keyboard.KeyUp(VirtualKeyCode.LEFT);
                    InputSimulator.Keyboard.KeyDown(VirtualKeyCode.RIGHT);
                    keystate = "right";
                }
                else if (Convert.ToInt32(YaxisBox.Text) < YUpper && Convert.ToInt32(YaxisBox.Text) > YLower)
                {
                    InputSimulator.Keyboard.KeyUp(VirtualKeyCode.RIGHT);
                    InputSimulator.Keyboard.KeyUp(VirtualKeyCode.LEFT);
                    keystate = "";
                }

                if (Convert.ToInt32(XaxisBox.Text) < XLower && Convert.ToInt32(XaxisBox.Text) > 0 && keystate2 != "up") //Up
                {
                    InputSimulator.Keyboard.KeyUp(VirtualKeyCode.DOWN);
                    InputSimulator.Keyboard.KeyDown(VirtualKeyCode.UP);
                    keystate2 = "up";
                }
                else if (Convert.ToInt32(XaxisBox.Text) > XUpper && Convert.ToInt32(XaxisBox.Text) > 0 && keystate2 != "down") //Right
                {
                    InputSimulator.Keyboard.KeyUp(VirtualKeyCode.UP);
                    InputSimulator.Keyboard.KeyDown(VirtualKeyCode.DOWN);
                    keystate2 = "down";
                }
                else if (Convert.ToInt32(XaxisBox.Text) < XUpper && Convert.ToInt32(XaxisBox.Text) > XLower)
                {
                    InputSimulator.Keyboard.KeyUp(VirtualKeyCode.UP);
                    InputSimulator.Keyboard.KeyUp(VirtualKeyCode.DOWN);
                    keystate2 = "";
                }


                GlobalVariables.Accel_X.Add(GlobalVariables.AccelerationData.X);
                GlobalVariables.Accel_Y.Add(GlobalVariables.AccelerationData.Y);
                GlobalVariables.Accel_Z.Add(GlobalVariables.AccelerationData.Z);

                XDataBox.AppendText(GlobalVariables.Accel_X[GlobalVariables.Accel_X.Count() - 1].ToString() + " ");
                YDataBox.AppendText(GlobalVariables.Accel_Y[GlobalVariables.Accel_Y.Count() - 1].ToString() + " ");
                ZDataBox.AppendText(GlobalVariables.Accel_Z[GlobalVariables.Accel_Z.Count() - 1].ToString() + " ");

                AccelGraph.Series["Accel_X"].Points.AddXY(AccelGraph.Series["Accel_X"].Points.Count(), GlobalVariables.AccelerationData.X.ToString());
                AccelGraph.Series["Accel_Y"].Points.AddXY(AccelGraph.Series["Accel_Y"].Points.Count(), GlobalVariables.AccelerationData.Y.ToString());
                AccelGraph.Series["Accel_Z"].Points.AddXY(AccelGraph.Series["Accel_Z"].Points.Count(), GlobalVariables.AccelerationData.Z.ToString());

                if (AccelGraph.ChartAreas[0].AxisX.Maximum - AccelGraph.ChartAreas[0].AxisX.Minimum > 100)
                {
                    AccelGraph.ChartAreas[0].AxisX.Minimum = AccelGraph.ChartAreas[0].AxisX.Minimum + 1; ;
                }
            }
        }

        private void DisconnectButton_Click(object sender, EventArgs e)
        {
            if (serCom.IsOpen)
            {
                DisconnectButton.Text = "Connect";
                serCom.Close();
                GlobalVariables.Accel_X.Clear();
                GlobalVariables.Accel_Y.Clear();
                GlobalVariables.Accel_Z.Clear();
                SerialPortListBox.Enabled = true;
            }
            else if (serCom.IsOpen == false)
            {
                DisconnectButton.Text = "Disconnect";
                serCom.PortName = SerialPortListBox.Text.ToString();
                serCom.DataBits = 8;
                serCom.BaudRate = 128000;
                try
                {
                    serCom.Open();
                    SerialPortListBox.Enabled = false;
                }
                catch
                {
                    DisconnectButton.Text = "Connect";
                    MessageBox.Show("The Port is currently disconnected, please reconnect it again!", "Error");
                }
            }
        }

        public Axis_Acceleration Bin2Acc(Axis_Acceleration data)
        {
            double Vdd = 5;
            Axis_Acceleration result = new Axis_Acceleration();
            result.X = (data.X - 127) * (Vdd / 254) * (0.145 * Vdd); //0.145*Vdd is sensitivity V/g and Vdd/254 is for rangescale
            result.Y = (data.Y - 127) * (Vdd / 254) * (0.145 * Vdd);
            result.Z = -1 * (data.Z - 127) * (Vdd / 254) * (0.145 * Vdd);
            return result;
        }

        private void SerialPortListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            serCom.PortName = SerialPortListBox.Text.ToString();
        }

        ConcurrentQueue<int> SerialReceivedQueue = new ConcurrentQueue<int>();
        private void serCom_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            int ItemToClear;
            while (SerialReceivedQueue.TryDequeue(out ItemToClear))
            {
                //wait for queue to be cleared for the next set of data in order to not clog up the queue;
            }
            try
            {
                while (serCom.BytesToRead > 0)
                {
                    int data = serCom.ReadByte();

                    if (data == 255) //remove the starting byte
                        continue;
                    SerialReceivedQueue.Enqueue(data);
                }


            }
            catch { }

        }
    }
}



//using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Data;
//using System.Drawing;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Windows.Forms;
//using System.IO.Ports;
//using System.Collections.Concurrent;

//namespace SerialReaderSuperSimple
//{
//    public partial class Form1 : Form
//    {

//        public Form1()
//        {
//            InitializeComponent();

//        }

//        string[] PortArray;
//        class Axis_Acceleration
//        {
//            public double X, Y, Z;
//        }
//        private void timer_Tick(object sender, EventArgs e)
//        {
//            string[] test = SerialPort.GetPortNames().ToArray();
//            if (SerialPortListBox.DroppedDown == false) //Prevent list updates during drop down activated so list doesn't flash
//            {
//                PortArray = SerialPort.GetPortNames().ToArray();
//                SerialPortListBox.Items.Clear();
//                foreach (string portname in PortArray)
//                {
//                    SerialPortListBox.Items.Add(portname);
//                }
//            }

//            Axis_Acceleration AccelerationData;

//            //Retrieve Acceleration data from one data packet
//            int QueueData;
//            SerialReceivedQueue.TryDequeue(out QueueData);
//            AccelerationData.X = QueueData.ToString();
//            SerialReceivedQueue.TryDequeue(out QueueData);
//            AccelerationData.Y = QueueData.ToString();
//            SerialReceivedQueue.TryDequeue(out QueueData);
//            AccelerationData.Z = QueueData.ToString();

//            XaxisBox.Text = Bin2Acc(AccelerationData).X.ToString();
//            YaxisBox.Text = Bin2Acc(AccelerationData).Y.ToString();
//            ZaxisBox.Text = Bin2Acc(AccelerationData).Z.ToString();

//            //XaxisBox.Text = QueueData.ToString(); //X data written


//            //YaxisBox.Text = QueueData.ToString(); //Y data written

//           // SerialReceivedQueue.TryDequeue(out QueueData);
//            //ZaxisBox.Text = QueueData.ToString(); //Z data written


//        }

//        private void DisconnectButton_Click(object sender, EventArgs e)
//        {
//            if (serCom.IsOpen)
//            {
//                DisconnectButton.Text = "Connect";
//                serCom.Close();
//                SerialPortListBox.Enabled = true;
//            }
//            else if(serCom.IsOpen == false)
//            {
//                DisconnectButton.Text = "Disconnect";
//                serCom.PortName = SerialPortListBox.Text.ToString();
//                serCom.DataBits = 8;
//                serCom.BaudRate = 128000;
//                try {
//                    serCom.Open();
//                    SerialPortListBox.Enabled = false;
//                }
//                catch {
//                    DisconnectButton.Text = "Connect";
//                    MessageBox.Show("The Port is currently disconnected, please reconnect it again!", "Error");
//                }
//            }
//        }

//        public Axis_Acceleration Bin2Acc(Axis_Acceleration data)
//        {
//            double Vdd = 5;
//            Axis_Acceleration result;
//            Console.WriteLine(data.X);
//            result.X = (data.X - 127) * (Vdd / 254) * (0.145 * Vdd); //0.145*Vdd is sensitivity V/g and Vdd/254 is for rangescale
//            result.Y = (data.Y - 127) * (Vdd / 254) * (0.145 * Vdd);
//            result.Z = (data.Z - 127) * (Vdd / 254) * (0.145 * Vdd);

//            Console.WriteLine(result.X);
//            return result;
//        }

//        private void SerialPortListBox_SelectedIndexChanged(object sender, EventArgs e)
//        {
//            serCom.PortName = SerialPortListBox.Text.ToString();
//        }

//        ConcurrentQueue<int> SerialReceivedQueue = new ConcurrentQueue<int>();
//        private void serCom_DataReceived(object sender, SerialDataReceivedEventArgs e)
//        {
//            int ItemToClear;
//            while (SerialReceivedQueue.TryDequeue(out ItemToClear))
//            {
//                //wait for queue to be cleared for the next set of data in order to not clog up the queue;
//            }
//            try
//            {
//                while (serCom.BytesToRead > 0)
//                {
//                    int data = serCom.ReadByte();

//                    if (data == 255) //remove the starting byte
//                        continue;
//                    SerialReceivedQueue.Enqueue(data);
//                }
//            }
//            catch { }

//        }
//    }
//}
