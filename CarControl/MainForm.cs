using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarControl
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            initCOMM();

        }


        void initCOMM()
        {
            searchCOMM();
        }

        void searchCOMM()
        {
            for (int i = 1; i <= 64; i++)
            {
                serialPort1.PortName = "COM" + i.ToString();

                try
                {
                    serialPort1.Open();
                    if (serialPort1.IsOpen)
                    {
                        comboBox1.Items.Add(serialPort1.PortName);
                        serialPort1.Close();
                    }
                }  
                catch(Exception e)
                {
                    e.ToString();
                }
                
                
            }
        }

        private void swichComm_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedText != "")
                serialPort1.PortName = comboBox1.SelectedText;

            try
            {
                if (serialPort1.IsOpen)
                {
                    serialPort1.Close();
                    isOK.Text = "Closed";
                    isOK.Visible = false;
                    swichComm.Text = "打开串口";

                }
                else
                {
                    serialPort1.Open();
                    isOK.Text = "OK";
                    isOK.Visible = true;
                    swichComm.Text = "关闭串口";
                }
            }
            catch (Exception)
            {
                e.ToString();
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            serialPort1.PortName = comboBox1.SelectedText;

            try
            {
                if (serialPort1.IsOpen)
                {
                    isOK.Text = "OK";
                    isOK.Visible = true;
                    swichComm.Text = "关闭串口";
                }
                else
                {
                    isOK.Text = "Closed";
                    isOK.Visible = true;
                    swichComm.Text = "打开串口";
                }
            }
            catch (Exception)
            {
                e.ToString();
            }
        }

        private void lockcar_Click(object sender, EventArgs e)
        {
            string sends = "STD04 **** **** **** ****";
            try
            {
                if (serialPort1.IsOpen)
                {
                    serialPort1.Write(sends);
                    textBox1.AppendText("发送（锁车）：" + sends + "\r\n");
                }
            }
            catch (Exception)
            {

            }
        }

        private void unlockcar_Click(object sender, EventArgs e)
        {
            string sends = "STD04 **** **** **** ****";
            try
            {
                if (serialPort1.IsOpen)
                {
                    serialPort1.Write(sends);
                    textBox1.AppendText("发送（解锁）：" + sends + "\r\n");
                }
            }
            catch(Exception )
            {

            }
        }

        private void serialPort1_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            string recievs = serialPort1.ReadExisting();
            textBox1.AppendText("接收：" + recievs + "\r\n");
        }
    }
}
