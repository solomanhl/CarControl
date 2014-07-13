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
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
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
            this.serialPort1.BaudRate = 256000;
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
            this.isOK.Location = new System.Drawing.Point(130, 6);
            this.isOK.Name = "isOK";
            this.isOK.Size = new System.Drawing.Size(41, 12);
            this.isOK.TabIndex = 2;
            this.isOK.Text = "Closed";
            this.isOK.Visible = false;
            // 
            // swichComm
            // 
            this.swichComm.Cursor = System.Windows.Forms.Cursors.Default;
            this.swichComm.Location = new System.Drawing.Point(177, 3);
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
            this.panel1.Size = new System.Drawing.Size(383, 136);
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
            this.textBox1.Location = new System.Drawing.Point(423, 64);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(292, 266);
            this.textBox1.TabIndex = 5;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(14, 42);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(403, 288);
            this.tabControl1.TabIndex = 6;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(395, 262);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(395, 262);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(727, 342);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.swichComm);
            this.Controls.Add(this.isOK);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Name = "MainForm";
            this.Text = "BYD";
            this.panel1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
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
        private System.Windows.Forms.TabPage tabPage2;
    }
}

