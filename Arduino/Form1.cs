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

namespace Arduino
{
    public partial class Form1 : Form
    {
        private enum Digital
        {
            h,l
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox_COM.SelectedItem = "COM3";
            comboBox_RATE.SelectedItem = "9600";
        }

        private void btnHigh_Click(object sender, EventArgs e)
        {
            WriteToCom(Digital.h);
        }

        private void btnLow_Click(object sender, EventArgs e)
        {
            WriteToCom(Digital.l);
        }

        private void WriteToCom(Digital button)
        {
            SerialPort mySerialPort = new SerialPort(comboBox_COM.SelectedItem.ToString());
            mySerialPort.BaudRate = int.Parse(comboBox_RATE.SelectedItem.ToString());
            mySerialPort.Open();
            mySerialPort.Write(button.ToString());
            mySerialPort.Close();
        }

    }
}
