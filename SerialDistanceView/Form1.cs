using System;
using System.IO.Ports;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace SerialDistanceView
{
    public partial class SerialDistanceView : Form
    {
        public int distanceMap;
        public SerialDistanceView()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
        }

        private void SerialDistanceView_Load(object sender, EventArgs e)
        {
            SerialPortName.DataSource = SerialPort.GetPortNames();
            serialPort1.PortName = SerialPortName.Text;
            serialPort1.DataReceived += new SerialDataReceivedEventHandler(SerialDataReceived);
        }

        private void SerialDataReceived(Object sender, SerialDataReceivedEventArgs e)
        {
            DistanceText.Text = serialPort1.ReadLine();
            distanceMap = Convert.ToInt32(Convert.ToDouble(Regex.Replace(DistanceText.Text, @"[^\d.\d]", "")));
            if (distanceMap > 50)
            {
                distanceMap = (distanceMap - 50) / 100 + 50;
                if (distanceMap > 60) { distanceMap = 60; }
            }
            DistanceBar.Value = distanceMap;
        }

        private void OpenSerial_Click(object sender, EventArgs e)
        {
            if (!serialPort1.IsOpen)
            {
                serialPort1.Open();
            }
        }

        private void CloseSerial_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                serialPort1.Close();
            }
        }

        private void SerialPortName_SelectedIndexChanged(object sender, EventArgs e)
        {
            serialPort1.PortName = SerialPortName.Text;
        }
    }
}
