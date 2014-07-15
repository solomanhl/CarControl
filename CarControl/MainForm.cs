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
        private string timer1tag;
        private string recievs;

        private int maxspeed, maxfuhe, minfuhe, maxrpm, minrpm, maxjieqimen, minjieqimen, maxtempre, mintempre;
        private float maxvolt, minvolt;

        public MainForm()
        {
            InitializeComponent();

           

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            maxspeed = 0;
            maxfuhe = 0;
            minfuhe = 100;
            maxrpm = 0;
            minrpm = 10000;
            maxjieqimen = 0;
            minjieqimen = 100;
            maxtempre = 0;
            mintempre = 200;
            maxvolt = 0;
            minvolt = 20;

            initCOMM();
        }

        void initCOMM()
        {
            searchCOMM();

            //添加波特率
            comboBox2.Items.Add("9600");
            comboBox2.Items.Add("19200");
            comboBox2.Items.Add("38400");//OBDII开发模块用
            comboBox2.Items.Add("256000");//罗斯威尔CAN用
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
            if (comboBox1.SelectedItem.ToString() != "" && comboBox1.SelectedItem.ToString() != "")
            {
                serialPort1.PortName = comboBox1.SelectedItem.ToString();
                serialPort1.BaudRate = Convert.ToInt32(comboBox2.SelectedItem.ToString());
            }

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
            serialPort1.PortName = comboBox1.SelectedItem.ToString();

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

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            serialPort1.BaudRate = Convert.ToInt32(comboBox2.SelectedItem.ToString());
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
            recievs += serialPort1.ReadExisting();
            //textBox1.AppendText("接收：" + recievs + "\r\n");

            if (recievs.StartsWith("$") && recievs.EndsWith("<CR><LF>"))//有头有尾
            {
                //timerUI.Enabled = true;
            }
            else if (recievs.StartsWith("$")) //头来了，没收完
            {
                
            }
            else if(!recievs.StartsWith("$")) //头都没有 直接丢
            {
                recievs = "";
            }
                
        }


        void decodeATX(string recievs)
        {
            string []tmp;

            if (recievs != "" && recievs!=null )
            {
                tmp = recievs.Split(',');

                switch (tmp[0])
                {
                    case "$XYHSTATURS"://ATX01
                        ATX01(tmp);
                        break;
                    case "$XYHPOWERS":  //ATX02
                        ATX02(tmp);
                        break;

                    default:
                        break;
                }
                //recievs = "";
            }
        }

        void ATX01(string []tmp)
        {
            int length = tmp.Length;

            licheng.Text = tmp[1];
            shunshiyouhao.Text = tmp[2];
            pinjunyouhao.Text = tmp[3];
            xinshishijian.Text = tmp[4] + "秒";

            recievs = "";
        }

        void ATX02(string []tmp)
        {
            chesu.Text = tmp[1];
            fuhe.Text =tmp[2];
            shuiwen.Text = tmp[3];
            jieqimen.Text = tmp[4];
            zhuansu.Text = tmp[5];
            dianya.Text = tmp[6];



            maxspeed = Math.Max(maxspeed, Convert.ToInt32(tmp[1]));
            maxfuhe = Math.Max(maxfuhe, Convert.ToInt32(tmp[2]));
            minfuhe = Math.Min(minfuhe, Convert.ToInt32(tmp[2]));
            maxtempre = Math.Max(maxtempre, Convert.ToInt32(tmp[3]));
            mintempre = Math.Min(mintempre, Convert.ToInt32(tmp[3]));
            maxjieqimen = Math.Max(maxjieqimen, Convert.ToInt32(tmp[4]));
            minjieqimen = Math.Min(minjieqimen, Convert.ToInt32(tmp[4]));
            maxrpm  = Math.Max(maxrpm , Convert.ToInt32(tmp[5]));
            minrpm = Math.Min(minrpm, Convert.ToInt32(tmp[5]));
            maxvolt = Math.Max(maxvolt, Convert.ToSingle(tmp[6]));
            minvolt = Math.Min(minvolt, Convert.ToSingle(tmp[6]));

            maxchesu.Text = maxspeed.ToString();
            mafuhe.Text = maxfuhe.ToString();
            mifuhe.Text = minfuhe.ToString();
            maxshuiwen.Text = maxtempre.ToString();
            minshuiwen.Text = mintempre.ToString();
            maxjieimen.Text = maxjieqimen.ToString();
            minjieimen.Text = minjieqimen.ToString();
            maxzhuansu.Text = maxrpm.ToString();
            minzhuansu.Text = minrpm.ToString();
            maxdinaya.Text = maxvolt.ToString();
            mindianya.Text = minvolt.ToString();



            recievs = "";
        }

        private void b_ATS_Click(object sender, EventArgs e)
        {
            string sends = "ATS" + "\r\n";
            try
            {
                if (serialPort1.IsOpen)
                {
                    serialPort1.Write(sends);
                    textBox1.AppendText("发送（版本）：" + sends + "\r\n");
                }
            }
            catch (Exception)
            {

            }
        }

        private void b_ATR_Click(object sender, EventArgs e)
        {
            string sends = "ATR" + "\r\n";
            try
            {
                if (serialPort1.IsOpen)
                {
                    serialPort1.Write(sends);
                    textBox1.AppendText("发送（重启）：" + sends + "\r\n");
                }
            }
            catch (Exception)
            {

            }
        }

        private void b_ATZ_Click(object sender, EventArgs e)
        {
            string sends = "ATZ" + "\r\n";
            try
            {
                if (serialPort1.IsOpen)
                {
                    serialPort1.Write(sends);
                    textBox1.AppendText("发送（清零）：" + sends + "\r\n");
                }
            }
            catch (Exception)
            {

            }
        }

        private void b_ATP_Click(object sender, EventArgs e)
        {
            string sends = "ATP" + "\r\n";
            try
            {
                if (serialPort1.IsOpen)
                {
                    serialPort1.Write(sends);
                    textBox1.AppendText("发送（协议）：" + sends + "\r\n");
                }
            }
            catch (Exception)
            {

            }
        }

        private void b_ATB_Click(object sender, EventArgs e)
        {
            string sends = "ATB"+ "\r\n";
            try
            {
                if (serialPort1.IsOpen)
                {
                    serialPort1.Write(sends);
                    textBox1.AppendText("发送（模式转换）：" + sends);
                }
            }
            catch (Exception)
            {

            }
        }

        private void b_ATX01_Click(object sender, EventArgs e)
        {
           

            string sends = "ATX01" + "\r\n" ;
            try
            {
                if (serialPort1.IsOpen)
                {
                    serialPort1.Write(sends);
                    textBox1.AppendText("发送（ATX01）：" + sends);

                    //timerUI.Enabled = true;
                    timer1tag = "atx01";
                }
            }
            catch (Exception)
            {

            }
        }

        private void b_ATX02_Click(object sender, EventArgs e)
        {
            string sends = "ATX02" + "\r\n" ;
            
            try
            {
                if (serialPort1.IsOpen)
                {
                    serialPort1.Write(sends);
                    textBox1.AppendText("发送（ATX02）：" + sends);

                    timer1tag = "atx02";
                    //timerUI.Enabled = true;
                }
            }
            catch (Exception)
            {

            }
        }

        private void b_ATX03_Click(object sender, EventArgs e)
        {
            string sends = "ATX03" + "\r\n";
            try
            {
                if (serialPort1.IsOpen)
                {
                    serialPort1.Write(sends);
                    textBox1.AppendText("发送（ATX03，读故障码）：" + sends);
                }
            }
            catch (Exception)
            {

            }
        }

        private void b_ATX031_Click(object sender, EventArgs e)
        {
            string sends = "ATX031" + "\r\n";
            try
            {
                if (serialPort1.IsOpen)
                {
                    serialPort1.Write(sends);
                    textBox1.AppendText("发送（ATX032，清故障码）：" + sends);
                }
            }
            catch (Exception)
            {

            }
        }

        private void b_ATX11_Click(object sender, EventArgs e)
        {
            string sends = "ATX11" + "\r\n";
            try
            {
                if (serialPort1.IsOpen)
                {
                    serialPort1.Write(sends);
                    textBox1.AppendText("发送（ATX11）：" + sends);
                }
            }
            catch (Exception)
            {

            }
        }

        private void b_ATX12_Click(object sender, EventArgs e)
        {
            string sends = "AT12" + "\r\n";
            try
            {
                if (serialPort1.IsOpen)
                {
                    serialPort1.Write(sends);
                    textBox1.AppendText("发送（ATX12）：" + sends);
                }
            }
            catch (Exception)
            {

            }
        }

        private void b_ATX13_Click(object sender, EventArgs e)
        {
            string sends = "ATX13" + "\r\n";
            try
            {
                if (serialPort1.IsOpen)
                {
                    serialPort1.Write(sends);
                    textBox1.AppendText("发送（ATX13）：" + sends );
                }
            }
            catch (Exception)
            {

            }
        }

        private void b_ATX14_Click(object sender, EventArgs e)
        {
            string sends = "ATX14" + "\r\n";
            try
            {
                if (serialPort1.IsOpen)
                {
                    serialPort1.Write(sends);
                    textBox1.AppendText("发送（ATX14）：" + sends);
                }
            }
            catch (Exception)
            {

            }
        }


        int timer1cnt = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            //timer1.Enabled = false;
            timer1.Interval = 500;

            timer1cnt++;
            
            switch (timer1cnt %2)
            {
                case 0:
                    b_ATX02_Click(sender, e);
                    break;
                case 1:
                    b_ATX01_Click(sender, e);
                    break;
                default:
                    break;
            }
            
            

            //textBox1.AppendText("接收：" + recievs + "\r\n");
            //decodeATX(recievs);
            //switch (timer1tag)
            //{
            //    case "atx01":
            //        b_ATX01_Click(sender, e);
            //        break;
            //    case "atx02":
            //        b_ATX02_Click(sender, e);
            //        break;
            //    default:
            //        break;
            //}
        }

        private void timerUI_Tick(object sender, EventArgs e)
        {
            //timerUI.Enabled = false;

            if (recievs != null && recievs != "")
            {
                textBox1.AppendText("接收：" + recievs + "\r\n");
                decodeATX(recievs);
            }
        }

        private void autoATX_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }


    }
}
