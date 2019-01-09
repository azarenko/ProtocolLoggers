using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using PortUtilits;

namespace Geely.Emgrand7.Petrol
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            backgroundWorker.RunWorkerAsync();
        }

        public static bool isRun = false;
        public static bool isLog = false;

        private void _connect_Click(object sender, EventArgs e)
        {
            if (serialPort.IsOpen)
                return;

            serialPort.PortName = _portNames.Text;
            serialPort.WriteTimeout = 1000;

            // Start communication fast init
            serialPort.BaudRate = 360;
            serialPort.Open();
            serialPort.WriteByte(0x00);
            serialPort.Close();
            Thread.Sleep(25);

            serialPort.BaudRate = 10400;
            serialPort.Open();



            isRun = true;
        }

        private void _disconnect_Click(object sender, EventArgs e)
        {
            if (serialPort.IsOpen)
            {
                isRun = false;
                serialPort.Close();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (string name in SerialPort.GetPortNames())
            {
                _portNames.Items.Add(name);
            }

            if (_portNames.Items.Count > 0)
            {
                _portNames.SelectedIndex = 0;
            }
        }

        private void backgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            do
            {
                while (isRun)
                {
                    Thread.Sleep(200);
                }
                Thread.Sleep(200);
            }
            while(true);
        }

        private void _startLog_Click(object sender, EventArgs e)
        {
            isLog = true;
        }

        private void _stopLog_Click(object sender, EventArgs e)
        {
            isLog = false;
        }

        private void selectFile_Click(object sender, EventArgs e)
        {
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                _filePath.Text = saveFileDialog.FileName;
            }
        }
    }
}
