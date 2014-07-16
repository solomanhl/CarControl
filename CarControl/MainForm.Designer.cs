namespace CarControl
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.isOK = new System.Windows.Forms.Label();
            this.swichComm = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.unlockcar = new System.Windows.Forms.Button();
            this.lockcar = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.l_TDST = new System.Windows.Forms.TabPage();
            this.maxchesu = new System.Windows.Forms.Label();
            this.chesu = new System.Windows.Forms.Label();
            this.mifuhe = new System.Windows.Forms.Label();
            this.mafuhe = new System.Windows.Forms.Label();
            this.fuhe = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.minjieimen = new System.Windows.Forms.Label();
            this.maxjieimen = new System.Windows.Forms.Label();
            this.jieqimen = new System.Windows.Forms.Label();
            this.minshuiwen = new System.Windows.Forms.Label();
            this.maxshuiwen = new System.Windows.Forms.Label();
            this.shuiwen = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.minzhuansu = new System.Windows.Forms.Label();
            this.maxzhuansu = new System.Windows.Forms.Label();
            this.zhuansu = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.mindianya = new System.Windows.Forms.Label();
            this.maxdinaya = new System.Windows.Forms.Label();
            this.dianya = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.xinshishijian = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.pinjunyouhao = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.shunshiyouhao = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.licheng = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.stopauto = new System.Windows.Forms.Button();
            this.autoATX = new System.Windows.Forms.Button();
            this.b_ATB = new System.Windows.Forms.Button();
            this.b_ATP = new System.Windows.Forms.Button();
            this.b_ATZ = new System.Windows.Forms.Button();
            this.b_ATR = new System.Windows.Forms.Button();
            this.b_ATX14 = new System.Windows.Forms.Button();
            this.b_ATX13 = new System.Windows.Forms.Button();
            this.b_ATX12 = new System.Windows.Forms.Button();
            this.b_ATX11 = new System.Windows.Forms.Button();
            this.b_ATX031 = new System.Windows.Forms.Button();
            this.b_ATX03 = new System.Windows.Forms.Button();
            this.b_ATX02 = new System.Windows.Forms.Button();
            this.b_ATX01 = new System.Windows.Forms.Button();
            this.b_ATS = new System.Windows.Forms.Button();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timerUI = new System.Windows.Forms.Timer(this.components);
            this.label13 = new System.Windows.Forms.Label();
            this.l_DST = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.l_FUE = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.l_TFUE = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.l_TDST.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "串口号:";
            // 
            // serialPort1
            // 
            this.serialPort1.BaudRate = 38400;
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(66, 3);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(58, 20);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // isOK
            // 
            this.isOK.AutoSize = true;
            this.isOK.ForeColor = System.Drawing.Color.Green;
            this.isOK.Location = new System.Drawing.Point(271, 6);
            this.isOK.Name = "isOK";
            this.isOK.Size = new System.Drawing.Size(41, 12);
            this.isOK.TabIndex = 2;
            this.isOK.Text = "Closed";
            this.isOK.Visible = false;
            // 
            // swichComm
            // 
            this.swichComm.Cursor = System.Windows.Forms.Cursors.Default;
            this.swichComm.Location = new System.Drawing.Point(318, 6);
            this.swichComm.Name = "swichComm";
            this.swichComm.Size = new System.Drawing.Size(75, 23);
            this.swichComm.TabIndex = 3;
            this.swichComm.Text = "打开串口";
            this.swichComm.UseVisualStyleBackColor = true;
            this.swichComm.Click += new System.EventHandler(this.swichComm_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.unlockcar);
            this.panel1.Controls.Add(this.lockcar);
            this.panel1.Location = new System.Drawing.Point(6, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(110, 102);
            this.panel1.TabIndex = 4;
            // 
            // unlockcar
            // 
            this.unlockcar.Location = new System.Drawing.Point(54, 3);
            this.unlockcar.Name = "unlockcar";
            this.unlockcar.Size = new System.Drawing.Size(50, 23);
            this.unlockcar.TabIndex = 1;
            this.unlockcar.Text = "解锁";
            this.unlockcar.UseVisualStyleBackColor = true;
            this.unlockcar.Click += new System.EventHandler(this.unlockcar_Click);
            // 
            // lockcar
            // 
            this.lockcar.Location = new System.Drawing.Point(4, 4);
            this.lockcar.Name = "lockcar";
            this.lockcar.Size = new System.Drawing.Size(43, 23);
            this.lockcar.TabIndex = 0;
            this.lockcar.Text = "锁车";
            this.lockcar.UseVisualStyleBackColor = true;
            this.lockcar.Click += new System.EventHandler(this.lockcar_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(935, 64);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(337, 561);
            this.textBox1.TabIndex = 5;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.l_TDST);
            this.tabControl1.Location = new System.Drawing.Point(14, 42);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(915, 587);
            this.tabControl1.TabIndex = 6;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(907, 561);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "CAN分析仪";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // l_TDST
            // 
            this.l_TDST.Controls.Add(this.maxchesu);
            this.l_TDST.Controls.Add(this.chesu);
            this.l_TDST.Controls.Add(this.mifuhe);
            this.l_TDST.Controls.Add(this.mafuhe);
            this.l_TDST.Controls.Add(this.fuhe);
            this.l_TDST.Controls.Add(this.label4);
            this.l_TDST.Controls.Add(this.label11);
            this.l_TDST.Controls.Add(this.minjieimen);
            this.l_TDST.Controls.Add(this.maxjieimen);
            this.l_TDST.Controls.Add(this.jieqimen);
            this.l_TDST.Controls.Add(this.minshuiwen);
            this.l_TDST.Controls.Add(this.maxshuiwen);
            this.l_TDST.Controls.Add(this.shuiwen);
            this.l_TDST.Controls.Add(this.label12);
            this.l_TDST.Controls.Add(this.label10);
            this.l_TDST.Controls.Add(this.minzhuansu);
            this.l_TDST.Controls.Add(this.maxzhuansu);
            this.l_TDST.Controls.Add(this.zhuansu);
            this.l_TDST.Controls.Add(this.label9);
            this.l_TDST.Controls.Add(this.mindianya);
            this.l_TDST.Controls.Add(this.maxdinaya);
            this.l_TDST.Controls.Add(this.dianya);
            this.l_TDST.Controls.Add(this.label8);
            this.l_TDST.Controls.Add(this.xinshishijian);
            this.l_TDST.Controls.Add(this.label7);
            this.l_TDST.Controls.Add(this.pinjunyouhao);
            this.l_TDST.Controls.Add(this.label6);
            this.l_TDST.Controls.Add(this.shunshiyouhao);
            this.l_TDST.Controls.Add(this.label5);
            this.l_TDST.Controls.Add(this.l_TFUE);
            this.l_TDST.Controls.Add(this.l_FUE);
            this.l_TDST.Controls.Add(this.label15);
            this.l_TDST.Controls.Add(this.l_DST);
            this.l_TDST.Controls.Add(this.licheng);
            this.l_TDST.Controls.Add(this.label17);
            this.l_TDST.Controls.Add(this.label16);
            this.l_TDST.Controls.Add(this.label14);
            this.l_TDST.Controls.Add(this.label13);
            this.l_TDST.Controls.Add(this.label3);
            this.l_TDST.Controls.Add(this.stopauto);
            this.l_TDST.Controls.Add(this.autoATX);
            this.l_TDST.Controls.Add(this.b_ATB);
            this.l_TDST.Controls.Add(this.b_ATP);
            this.l_TDST.Controls.Add(this.b_ATZ);
            this.l_TDST.Controls.Add(this.b_ATR);
            this.l_TDST.Controls.Add(this.b_ATX14);
            this.l_TDST.Controls.Add(this.b_ATX13);
            this.l_TDST.Controls.Add(this.b_ATX12);
            this.l_TDST.Controls.Add(this.b_ATX11);
            this.l_TDST.Controls.Add(this.b_ATX031);
            this.l_TDST.Controls.Add(this.b_ATX03);
            this.l_TDST.Controls.Add(this.b_ATX02);
            this.l_TDST.Controls.Add(this.b_ATX01);
            this.l_TDST.Controls.Add(this.b_ATS);
            this.l_TDST.Location = new System.Drawing.Point(4, 22);
            this.l_TDST.Name = "l_TDST";
            this.l_TDST.Padding = new System.Windows.Forms.Padding(3);
            this.l_TDST.Size = new System.Drawing.Size(907, 561);
            this.l_TDST.TabIndex = 1;
            this.l_TDST.Text = "OBDII开发模块";
            this.l_TDST.UseVisualStyleBackColor = true;
            // 
            // maxchesu
            // 
            this.maxchesu.AutoSize = true;
            this.maxchesu.Font = new System.Drawing.Font("宋体", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.maxchesu.Location = new System.Drawing.Point(135, 100);
            this.maxchesu.Name = "maxchesu";
            this.maxchesu.Size = new System.Drawing.Size(43, 22);
            this.maxchesu.TabIndex = 17;
            this.maxchesu.Text = "000";
            // 
            // chesu
            // 
            this.chesu.AutoSize = true;
            this.chesu.Font = new System.Drawing.Font("宋体", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.chesu.Location = new System.Drawing.Point(135, 78);
            this.chesu.Name = "chesu";
            this.chesu.Size = new System.Drawing.Size(43, 22);
            this.chesu.TabIndex = 17;
            this.chesu.Text = "000";
            // 
            // mifuhe
            // 
            this.mifuhe.AutoSize = true;
            this.mifuhe.Font = new System.Drawing.Font("宋体", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.mifuhe.Location = new System.Drawing.Point(267, 121);
            this.mifuhe.Name = "mifuhe";
            this.mifuhe.Size = new System.Drawing.Size(32, 22);
            this.mifuhe.TabIndex = 17;
            this.mifuhe.Text = "00";
            // 
            // mafuhe
            // 
            this.mafuhe.AutoSize = true;
            this.mafuhe.Font = new System.Drawing.Font("宋体", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.mafuhe.Location = new System.Drawing.Point(267, 99);
            this.mafuhe.Name = "mafuhe";
            this.mafuhe.Size = new System.Drawing.Size(32, 22);
            this.mafuhe.TabIndex = 17;
            this.mafuhe.Text = "00";
            // 
            // fuhe
            // 
            this.fuhe.AutoSize = true;
            this.fuhe.Font = new System.Drawing.Font("宋体", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.fuhe.Location = new System.Drawing.Point(267, 77);
            this.fuhe.Name = "fuhe";
            this.fuhe.Size = new System.Drawing.Size(32, 22);
            this.fuhe.TabIndex = 17;
            this.fuhe.Text = "00";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(73, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 22);
            this.label4.TabIndex = 16;
            this.label4.Text = "车速：";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("宋体", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label11.Location = new System.Drawing.Point(199, 78);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(76, 22);
            this.label11.TabIndex = 16;
            this.label11.Text = "负荷：";
            // 
            // minjieimen
            // 
            this.minjieimen.AutoSize = true;
            this.minjieimen.Font = new System.Drawing.Font("宋体", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.minjieimen.Location = new System.Drawing.Point(530, 122);
            this.minjieimen.Name = "minjieimen";
            this.minjieimen.Size = new System.Drawing.Size(32, 22);
            this.minjieimen.TabIndex = 15;
            this.minjieimen.Text = "00";
            // 
            // maxjieimen
            // 
            this.maxjieimen.AutoSize = true;
            this.maxjieimen.Font = new System.Drawing.Font("宋体", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.maxjieimen.Location = new System.Drawing.Point(530, 100);
            this.maxjieimen.Name = "maxjieimen";
            this.maxjieimen.Size = new System.Drawing.Size(32, 22);
            this.maxjieimen.TabIndex = 15;
            this.maxjieimen.Text = "00";
            // 
            // jieqimen
            // 
            this.jieqimen.AutoSize = true;
            this.jieqimen.Font = new System.Drawing.Font("宋体", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.jieqimen.Location = new System.Drawing.Point(530, 78);
            this.jieqimen.Name = "jieqimen";
            this.jieqimen.Size = new System.Drawing.Size(32, 22);
            this.jieqimen.TabIndex = 15;
            this.jieqimen.Text = "00";
            // 
            // minshuiwen
            // 
            this.minshuiwen.AutoSize = true;
            this.minshuiwen.Font = new System.Drawing.Font("宋体", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.minshuiwen.Location = new System.Drawing.Point(388, 122);
            this.minshuiwen.Name = "minshuiwen";
            this.minshuiwen.Size = new System.Drawing.Size(32, 22);
            this.minshuiwen.TabIndex = 15;
            this.minshuiwen.Text = "00";
            // 
            // maxshuiwen
            // 
            this.maxshuiwen.AutoSize = true;
            this.maxshuiwen.Font = new System.Drawing.Font("宋体", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.maxshuiwen.Location = new System.Drawing.Point(388, 100);
            this.maxshuiwen.Name = "maxshuiwen";
            this.maxshuiwen.Size = new System.Drawing.Size(32, 22);
            this.maxshuiwen.TabIndex = 15;
            this.maxshuiwen.Text = "00";
            // 
            // shuiwen
            // 
            this.shuiwen.AutoSize = true;
            this.shuiwen.Font = new System.Drawing.Font("宋体", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.shuiwen.Location = new System.Drawing.Point(388, 78);
            this.shuiwen.Name = "shuiwen";
            this.shuiwen.Size = new System.Drawing.Size(32, 22);
            this.shuiwen.TabIndex = 15;
            this.shuiwen.Text = "00";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("宋体", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label12.Location = new System.Drawing.Point(435, 78);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(98, 22);
            this.label12.TabIndex = 14;
            this.label12.Text = "节气门：";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("宋体", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label10.Location = new System.Drawing.Point(325, 78);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(76, 22);
            this.label10.TabIndex = 14;
            this.label10.Text = "水温：";
            // 
            // minzhuansu
            // 
            this.minzhuansu.AutoSize = true;
            this.minzhuansu.Font = new System.Drawing.Font("宋体", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.minzhuansu.Location = new System.Drawing.Point(646, 122);
            this.minzhuansu.Name = "minzhuansu";
            this.minzhuansu.Size = new System.Drawing.Size(54, 22);
            this.minzhuansu.TabIndex = 13;
            this.minzhuansu.Text = "0000";
            // 
            // maxzhuansu
            // 
            this.maxzhuansu.AutoSize = true;
            this.maxzhuansu.Font = new System.Drawing.Font("宋体", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.maxzhuansu.Location = new System.Drawing.Point(646, 100);
            this.maxzhuansu.Name = "maxzhuansu";
            this.maxzhuansu.Size = new System.Drawing.Size(54, 22);
            this.maxzhuansu.TabIndex = 13;
            this.maxzhuansu.Text = "0000";
            // 
            // zhuansu
            // 
            this.zhuansu.AutoSize = true;
            this.zhuansu.Font = new System.Drawing.Font("宋体", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.zhuansu.Location = new System.Drawing.Point(646, 78);
            this.zhuansu.Name = "zhuansu";
            this.zhuansu.Size = new System.Drawing.Size(54, 22);
            this.zhuansu.TabIndex = 13;
            this.zhuansu.Text = "0000";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("宋体", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label9.Location = new System.Drawing.Point(579, 78);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(76, 22);
            this.label9.TabIndex = 12;
            this.label9.Text = "转速：";
            // 
            // mindianya
            // 
            this.mindianya.AutoSize = true;
            this.mindianya.Font = new System.Drawing.Font("宋体", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.mindianya.Location = new System.Drawing.Point(816, 122);
            this.mindianya.Name = "mindianya";
            this.mindianya.Size = new System.Drawing.Size(65, 22);
            this.mindianya.TabIndex = 11;
            this.mindianya.Text = "00.0V";
            // 
            // maxdinaya
            // 
            this.maxdinaya.AutoSize = true;
            this.maxdinaya.Font = new System.Drawing.Font("宋体", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.maxdinaya.Location = new System.Drawing.Point(816, 100);
            this.maxdinaya.Name = "maxdinaya";
            this.maxdinaya.Size = new System.Drawing.Size(65, 22);
            this.maxdinaya.TabIndex = 11;
            this.maxdinaya.Text = "00.0V";
            // 
            // dianya
            // 
            this.dianya.AutoSize = true;
            this.dianya.Font = new System.Drawing.Font("宋体", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dianya.Location = new System.Drawing.Point(816, 78);
            this.dianya.Name = "dianya";
            this.dianya.Size = new System.Drawing.Size(65, 22);
            this.dianya.TabIndex = 11;
            this.dianya.Text = "00.0V";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("宋体", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.Location = new System.Drawing.Point(734, 77);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 22);
            this.label8.TabIndex = 10;
            this.label8.Text = "电压：";
            // 
            // xinshishijian
            // 
            this.xinshishijian.AutoSize = true;
            this.xinshishijian.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.xinshishijian.Location = new System.Drawing.Point(799, 35);
            this.xinshishijian.Name = "xinshishijian";
            this.xinshishijian.Size = new System.Drawing.Size(82, 24);
            this.xinshishijian.TabIndex = 9;
            this.xinshishijian.Text = "00000S";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.Location = new System.Drawing.Point(683, 35);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(130, 24);
            this.label7.TabIndex = 8;
            this.label7.Text = "行驶时间：";
            // 
            // pinjunyouhao
            // 
            this.pinjunyouhao.AutoSize = true;
            this.pinjunyouhao.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.pinjunyouhao.Location = new System.Drawing.Point(585, 35);
            this.pinjunyouhao.Name = "pinjunyouhao";
            this.pinjunyouhao.Size = new System.Drawing.Size(70, 24);
            this.pinjunyouhao.TabIndex = 7;
            this.pinjunyouhao.Text = "00。0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(471, 36);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(130, 24);
            this.label6.TabIndex = 6;
            this.label6.Text = "平均油耗：";
            // 
            // shunshiyouhao
            // 
            this.shunshiyouhao.AutoSize = true;
            this.shunshiyouhao.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.shunshiyouhao.Location = new System.Drawing.Point(378, 36);
            this.shunshiyouhao.Name = "shunshiyouhao";
            this.shunshiyouhao.Size = new System.Drawing.Size(70, 24);
            this.shunshiyouhao.TabIndex = 5;
            this.shunshiyouhao.Text = "00。0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(267, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(130, 24);
            this.label5.TabIndex = 4;
            this.label5.Text = "瞬时油耗：";
            // 
            // licheng
            // 
            this.licheng.AutoSize = true;
            this.licheng.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.licheng.Location = new System.Drawing.Point(144, 36);
            this.licheng.Name = "licheng";
            this.licheng.Size = new System.Drawing.Size(106, 24);
            this.licheng.TabIndex = 3;
            this.licheng.Text = "00000.00";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(73, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "里程：";
            // 
            // stopauto
            // 
            this.stopauto.Location = new System.Drawing.Point(521, 7);
            this.stopauto.Name = "stopauto";
            this.stopauto.Size = new System.Drawing.Size(60, 23);
            this.stopauto.TabIndex = 1;
            this.stopauto.Text = "停止";
            this.stopauto.UseVisualStyleBackColor = true;
            this.stopauto.Click += new System.EventHandler(this.stopauto_Click);
            // 
            // autoATX
            // 
            this.autoATX.Location = new System.Drawing.Point(455, 7);
            this.autoATX.Name = "autoATX";
            this.autoATX.Size = new System.Drawing.Size(60, 23);
            this.autoATX.TabIndex = 1;
            this.autoATX.Text = "自动";
            this.autoATX.UseVisualStyleBackColor = true;
            this.autoATX.Click += new System.EventHandler(this.autoATX_Click);
            // 
            // b_ATB
            // 
            this.b_ATB.Location = new System.Drawing.Point(271, 7);
            this.b_ATB.Name = "b_ATB";
            this.b_ATB.Size = new System.Drawing.Size(60, 23);
            this.b_ATB.TabIndex = 1;
            this.b_ATB.Text = "ATB模式";
            this.b_ATB.UseVisualStyleBackColor = true;
            this.b_ATB.Click += new System.EventHandler(this.b_ATB_Click);
            // 
            // b_ATP
            // 
            this.b_ATP.Location = new System.Drawing.Point(205, 7);
            this.b_ATP.Name = "b_ATP";
            this.b_ATP.Size = new System.Drawing.Size(60, 23);
            this.b_ATP.TabIndex = 1;
            this.b_ATP.Text = "ATP协议";
            this.b_ATP.UseVisualStyleBackColor = true;
            this.b_ATP.Click += new System.EventHandler(this.b_ATP_Click);
            // 
            // b_ATZ
            // 
            this.b_ATZ.Location = new System.Drawing.Point(139, 7);
            this.b_ATZ.Name = "b_ATZ";
            this.b_ATZ.Size = new System.Drawing.Size(60, 23);
            this.b_ATZ.TabIndex = 1;
            this.b_ATZ.Text = "ATZ清零";
            this.b_ATZ.UseVisualStyleBackColor = true;
            this.b_ATZ.Click += new System.EventHandler(this.b_ATZ_Click);
            // 
            // b_ATR
            // 
            this.b_ATR.Location = new System.Drawing.Point(73, 7);
            this.b_ATR.Name = "b_ATR";
            this.b_ATR.Size = new System.Drawing.Size(60, 23);
            this.b_ATR.TabIndex = 1;
            this.b_ATR.Text = "ATR重启";
            this.b_ATR.UseVisualStyleBackColor = true;
            this.b_ATR.Click += new System.EventHandler(this.b_ATR_Click);
            // 
            // b_ATX14
            // 
            this.b_ATX14.Location = new System.Drawing.Point(7, 295);
            this.b_ATX14.Name = "b_ATX14";
            this.b_ATX14.Size = new System.Drawing.Size(60, 23);
            this.b_ATX14.TabIndex = 0;
            this.b_ATX14.Text = "ATX14";
            this.b_ATX14.UseVisualStyleBackColor = true;
            this.b_ATX14.Click += new System.EventHandler(this.b_ATX14_Click);
            // 
            // b_ATX13
            // 
            this.b_ATX13.Location = new System.Drawing.Point(7, 256);
            this.b_ATX13.Name = "b_ATX13";
            this.b_ATX13.Size = new System.Drawing.Size(60, 23);
            this.b_ATX13.TabIndex = 0;
            this.b_ATX13.Text = "ATX13";
            this.b_ATX13.UseVisualStyleBackColor = true;
            this.b_ATX13.Click += new System.EventHandler(this.b_ATX13_Click);
            // 
            // b_ATX12
            // 
            this.b_ATX12.Location = new System.Drawing.Point(7, 218);
            this.b_ATX12.Name = "b_ATX12";
            this.b_ATX12.Size = new System.Drawing.Size(60, 23);
            this.b_ATX12.TabIndex = 0;
            this.b_ATX12.Text = "ATX12";
            this.b_ATX12.UseVisualStyleBackColor = true;
            this.b_ATX12.Click += new System.EventHandler(this.b_ATX12_Click);
            // 
            // b_ATX11
            // 
            this.b_ATX11.Location = new System.Drawing.Point(7, 178);
            this.b_ATX11.Name = "b_ATX11";
            this.b_ATX11.Size = new System.Drawing.Size(60, 23);
            this.b_ATX11.TabIndex = 0;
            this.b_ATX11.Text = "ATX11";
            this.b_ATX11.UseVisualStyleBackColor = true;
            this.b_ATX11.Click += new System.EventHandler(this.b_ATX11_Click);
            // 
            // b_ATX031
            // 
            this.b_ATX031.Location = new System.Drawing.Point(754, 9);
            this.b_ATX031.Name = "b_ATX031";
            this.b_ATX031.Size = new System.Drawing.Size(85, 23);
            this.b_ATX031.TabIndex = 0;
            this.b_ATX031.Text = "ATX031清故障";
            this.b_ATX031.UseVisualStyleBackColor = true;
            this.b_ATX031.Click += new System.EventHandler(this.b_ATX031_Click);
            // 
            // b_ATX03
            // 
            this.b_ATX03.Location = new System.Drawing.Point(650, 9);
            this.b_ATX03.Name = "b_ATX03";
            this.b_ATX03.Size = new System.Drawing.Size(85, 23);
            this.b_ATX03.TabIndex = 0;
            this.b_ATX03.Text = "ATX03故障码";
            this.b_ATX03.UseVisualStyleBackColor = true;
            this.b_ATX03.Click += new System.EventHandler(this.b_ATX03_Click);
            // 
            // b_ATX02
            // 
            this.b_ATX02.Location = new System.Drawing.Point(7, 77);
            this.b_ATX02.Name = "b_ATX02";
            this.b_ATX02.Size = new System.Drawing.Size(60, 23);
            this.b_ATX02.TabIndex = 0;
            this.b_ATX02.Text = "ATX02";
            this.b_ATX02.UseVisualStyleBackColor = true;
            this.b_ATX02.Click += new System.EventHandler(this.b_ATX02_Click);
            // 
            // b_ATX01
            // 
            this.b_ATX01.Location = new System.Drawing.Point(7, 36);
            this.b_ATX01.Name = "b_ATX01";
            this.b_ATX01.Size = new System.Drawing.Size(60, 23);
            this.b_ATX01.TabIndex = 0;
            this.b_ATX01.Text = "ATX01";
            this.b_ATX01.UseVisualStyleBackColor = true;
            this.b_ATX01.Click += new System.EventHandler(this.b_ATX01_Click);
            // 
            // b_ATS
            // 
            this.b_ATS.Location = new System.Drawing.Point(7, 7);
            this.b_ATS.Name = "b_ATS";
            this.b_ATS.Size = new System.Drawing.Size(60, 23);
            this.b_ATS.TabIndex = 0;
            this.b_ATS.Text = "ATS版本";
            this.b_ATS.UseVisualStyleBackColor = true;
            this.b_ATS.Click += new System.EventHandler(this.b_ATS_Click);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(184, 3);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(58, 20);
            this.comboBox2.TabIndex = 8;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(130, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 7;
            this.label2.Text = "波特率：";
            // 
            // timer1
            // 
            this.timer1.Interval = 300;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timerUI
            // 
            this.timerUI.Enabled = true;
            this.timerUI.Tick += new System.EventHandler(this.timerUI_Tick);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label13.Location = new System.Drawing.Point(73, 217);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(70, 24);
            this.label13.TabIndex = 2;
            this.label13.Text = "DST：";
            // 
            // l_DST
            // 
            this.l_DST.AutoSize = true;
            this.l_DST.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.l_DST.Location = new System.Drawing.Point(144, 217);
            this.l_DST.Name = "l_DST";
            this.l_DST.Size = new System.Drawing.Size(106, 24);
            this.l_DST.TabIndex = 3;
            this.l_DST.Text = "00000.00";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label14.Location = new System.Drawing.Point(290, 217);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(82, 24);
            this.label14.TabIndex = 2;
            this.label14.Text = "TDST：";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label15.Location = new System.Drawing.Point(361, 217);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(106, 24);
            this.label15.TabIndex = 3;
            this.label15.Text = "00000.00";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label16.Location = new System.Drawing.Point(510, 217);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(70, 24);
            this.label16.TabIndex = 2;
            this.label16.Text = "FUE：";
            // 
            // l_FUE
            // 
            this.l_FUE.AutoSize = true;
            this.l_FUE.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.l_FUE.Location = new System.Drawing.Point(581, 217);
            this.l_FUE.Name = "l_FUE";
            this.l_FUE.Size = new System.Drawing.Size(106, 24);
            this.l_FUE.TabIndex = 3;
            this.l_FUE.Text = "00000.00";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label17.Location = new System.Drawing.Point(709, 217);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(82, 24);
            this.label17.TabIndex = 2;
            this.label17.Text = "TFUE：";
            // 
            // l_TFUE
            // 
            this.l_TFUE.AutoSize = true;
            this.l_TFUE.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.l_TFUE.Location = new System.Drawing.Point(780, 217);
            this.l_TFUE.Name = "l_TFUE";
            this.l_TFUE.Size = new System.Drawing.Size(106, 24);
            this.l_TFUE.TabIndex = 3;
            this.l_TFUE.Text = "00000.00";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1284, 641);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.swichComm);
            this.Controls.Add(this.isOK);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Name = "MainForm";
            this.Text = "BYD";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panel1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.l_TDST.ResumeLayout(false);
            this.l_TDST.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label isOK;
        private System.Windows.Forms.Button swichComm;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button unlockcar;
        private System.Windows.Forms.Button lockcar;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage l_TDST;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button b_ATB;
        private System.Windows.Forms.Button b_ATP;
        private System.Windows.Forms.Button b_ATZ;
        private System.Windows.Forms.Button b_ATR;
        private System.Windows.Forms.Button b_ATS;
        private System.Windows.Forms.Button b_ATX14;
        private System.Windows.Forms.Button b_ATX13;
        private System.Windows.Forms.Button b_ATX12;
        private System.Windows.Forms.Button b_ATX11;
        private System.Windows.Forms.Button b_ATX03;
        private System.Windows.Forms.Button b_ATX02;
        private System.Windows.Forms.Button b_ATX01;
        private System.Windows.Forms.Button b_ATX031;
        private System.Windows.Forms.Label licheng;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label shunshiyouhao;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label xinshishijian;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label pinjunyouhao;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timerUI;
        private System.Windows.Forms.Label zhuansu;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label dianya;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label shuiwen;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label fuhe;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button autoATX;
        private System.Windows.Forms.Label chesu;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label jieqimen;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label maxchesu;
        private System.Windows.Forms.Label mafuhe;
        private System.Windows.Forms.Label maxjieimen;
        private System.Windows.Forms.Label maxshuiwen;
        private System.Windows.Forms.Label maxzhuansu;
        private System.Windows.Forms.Label maxdinaya;
        private System.Windows.Forms.Label mifuhe;
        private System.Windows.Forms.Label minjieimen;
        private System.Windows.Forms.Label minshuiwen;
        private System.Windows.Forms.Label minzhuansu;
        private System.Windows.Forms.Label mindianya;
        private System.Windows.Forms.Button stopauto;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label l_DST;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label l_TFUE;
        private System.Windows.Forms.Label l_FUE;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
    }
}

