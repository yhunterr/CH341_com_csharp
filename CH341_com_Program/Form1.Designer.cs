
namespace CH341_com_Program
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btn_uart_connect = new System.Windows.Forms.Button();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.lbl_uart_status = new System.Windows.Forms.Label();
            this.cb_uart_portname = new System.Windows.Forms.ComboBox();
            this.cb_uart_baudrate = new System.Windows.Forms.ComboBox();
            this.lbl_uart_comport = new System.Windows.Forms.Label();
            this.lbl_uart_baudrate = new System.Windows.Forms.Label();
            this.btn_uart_send = new System.Windows.Forms.Button();
            this.tb_uart_receive = new System.Windows.Forms.TextBox();
            this.tb_uart_write = new System.Windows.Forms.TextBox();
            this.btn_uart_receive = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_i2c_read_result = new System.Windows.Forms.Label();
            this.tb_i2c_address = new System.Windows.Forms.TextBox();
            this.tb_i2c_read = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tb_i2c_read_interval = new System.Windows.Forms.TextBox();
            this.tb_i2c_write_interval = new System.Windows.Forms.TextBox();
            this.btn_i2c_all_read = new System.Windows.Forms.Button();
            this.tb_i2c_write = new System.Windows.Forms.TextBox();
            this.btn_i2c_all_write = new System.Windows.Forms.Button();
            this.lbl_deviceStatus_led = new System.Windows.Forms.Label();
            this.lbl_deviceStatus = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.lbl_deviceStatus_led2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btn_spi_send = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_spi_write = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_spi_read = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_uart_connect
            // 
            this.btn_uart_connect.Location = new System.Drawing.Point(233, 43);
            this.btn_uart_connect.Name = "btn_uart_connect";
            this.btn_uart_connect.Size = new System.Drawing.Size(98, 25);
            this.btn_uart_connect.TabIndex = 0;
            this.btn_uart_connect.Text = "connect";
            this.btn_uart_connect.UseVisualStyleBackColor = true;
            this.btn_uart_connect.Click += new System.EventHandler(this.uart_connect_btn_Click);
            // 
            // lbl_uart_status
            // 
            this.lbl_uart_status.AutoSize = true;
            this.lbl_uart_status.Location = new System.Drawing.Point(231, 20);
            this.lbl_uart_status.Name = "lbl_uart_status";
            this.lbl_uart_status.Size = new System.Drawing.Size(94, 12);
            this.lbl_uart_status.TabIndex = 1;
            this.lbl_uart_status.Text = "waiting connect";
            // 
            // cb_uart_portname
            // 
            this.cb_uart_portname.FormattingEnabled = true;
            this.cb_uart_portname.Location = new System.Drawing.Point(92, 17);
            this.cb_uart_portname.Name = "cb_uart_portname";
            this.cb_uart_portname.Size = new System.Drawing.Size(91, 20);
            this.cb_uart_portname.TabIndex = 2;
            this.cb_uart_portname.Click += new System.EventHandler(this.cb_uart_portname_Click);
            // 
            // cb_uart_baudrate
            // 
            this.cb_uart_baudrate.FormattingEnabled = true;
            this.cb_uart_baudrate.Items.AddRange(new object[] {
            "100",
            "300",
            "600",
            "1200",
            "2400",
            "4800",
            "9600",
            "14400",
            "19200",
            "38400",
            "57600",
            "115200",
            "230400",
            "460800",
            "921600"});
            this.cb_uart_baudrate.Location = new System.Drawing.Point(92, 48);
            this.cb_uart_baudrate.Name = "cb_uart_baudrate";
            this.cb_uart_baudrate.Size = new System.Drawing.Size(91, 20);
            this.cb_uart_baudrate.TabIndex = 3;
            this.cb_uart_baudrate.Text = "9600";
            // 
            // lbl_uart_comport
            // 
            this.lbl_uart_comport.AutoSize = true;
            this.lbl_uart_comport.Location = new System.Drawing.Point(21, 20);
            this.lbl_uart_comport.Name = "lbl_uart_comport";
            this.lbl_uart_comport.Size = new System.Drawing.Size(51, 12);
            this.lbl_uart_comport.TabIndex = 4;
            this.lbl_uart_comport.Text = "comport";
            // 
            // lbl_uart_baudrate
            // 
            this.lbl_uart_baudrate.AutoSize = true;
            this.lbl_uart_baudrate.Location = new System.Drawing.Point(22, 51);
            this.lbl_uart_baudrate.Name = "lbl_uart_baudrate";
            this.lbl_uart_baudrate.Size = new System.Drawing.Size(54, 12);
            this.lbl_uart_baudrate.TabIndex = 5;
            this.lbl_uart_baudrate.Text = "baudrate";
            // 
            // btn_uart_send
            // 
            this.btn_uart_send.Location = new System.Drawing.Point(257, 85);
            this.btn_uart_send.Name = "btn_uart_send";
            this.btn_uart_send.Size = new System.Drawing.Size(75, 23);
            this.btn_uart_send.TabIndex = 6;
            this.btn_uart_send.Text = "send";
            this.btn_uart_send.UseVisualStyleBackColor = true;
            this.btn_uart_send.Click += new System.EventHandler(this.btn_uart_send_Click);
            // 
            // tb_uart_receive
            // 
            this.tb_uart_receive.Location = new System.Drawing.Point(24, 112);
            this.tb_uart_receive.Multiline = true;
            this.tb_uart_receive.Name = "tb_uart_receive";
            this.tb_uart_receive.Size = new System.Drawing.Size(227, 114);
            this.tb_uart_receive.TabIndex = 7;
            // 
            // tb_uart_write
            // 
            this.tb_uart_write.Location = new System.Drawing.Point(25, 85);
            this.tb_uart_write.Name = "tb_uart_write";
            this.tb_uart_write.Size = new System.Drawing.Size(226, 21);
            this.tb_uart_write.TabIndex = 8;
            this.tb_uart_write.Text = "TEST";
            // 
            // btn_uart_receive
            // 
            this.btn_uart_receive.Location = new System.Drawing.Point(257, 114);
            this.btn_uart_receive.Name = "btn_uart_receive";
            this.btn_uart_receive.Size = new System.Drawing.Size(75, 23);
            this.btn_uart_receive.TabIndex = 9;
            this.btn_uart_receive.Text = "receive";
            this.btn_uart_receive.UseVisualStyleBackColor = true;
            this.btn_uart_receive.Click += new System.EventHandler(this.btn_uart_receive_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(11, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(422, 290);
            this.tabControl1.TabIndex = 10;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.tb_uart_receive);
            this.tabPage1.Controls.Add(this.btn_uart_receive);
            this.tabPage1.Controls.Add(this.btn_uart_connect);
            this.tabPage1.Controls.Add(this.tb_uart_write);
            this.tabPage1.Controls.Add(this.lbl_uart_status);
            this.tabPage1.Controls.Add(this.cb_uart_portname);
            this.tabPage1.Controls.Add(this.btn_uart_send);
            this.tabPage1.Controls.Add(this.cb_uart_baudrate);
            this.tabPage1.Controls.Add(this.lbl_uart_baudrate);
            this.tabPage1.Controls.Add(this.lbl_uart_comport);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(414, 264);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "UART";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.lbl_i2c_read_result);
            this.tabPage2.Controls.Add(this.tb_i2c_address);
            this.tabPage2.Controls.Add(this.tb_i2c_read);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.tb_i2c_read_interval);
            this.tabPage2.Controls.Add(this.tb_i2c_write_interval);
            this.tabPage2.Controls.Add(this.btn_i2c_all_read);
            this.tabPage2.Controls.Add(this.tb_i2c_write);
            this.tabPage2.Controls.Add(this.btn_i2c_all_write);
            this.tabPage2.Controls.Add(this.lbl_deviceStatus_led);
            this.tabPage2.Controls.Add(this.lbl_deviceStatus);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(414, 264);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "I2C";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 12);
            this.label1.TabIndex = 13;
            this.label1.Text = "ADDRESS";
            // 
            // lbl_i2c_read_result
            // 
            this.lbl_i2c_read_result.Location = new System.Drawing.Point(366, 38);
            this.lbl_i2c_read_result.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_i2c_read_result.Name = "lbl_i2c_read_result";
            this.lbl_i2c_read_result.Size = new System.Drawing.Size(41, 169);
            this.lbl_i2c_read_result.TabIndex = 29;
            this.lbl_i2c_read_result.Text = "0x01\r\n0x02\r\n0x03\r\n0x04\r\n0x05\r\n0x06\r\n0x07\r\n0x08\r\n0x09\r\n0x0A\r\n0x0B";
            // 
            // tb_i2c_address
            // 
            this.tb_i2c_address.Location = new System.Drawing.Point(100, 7);
            this.tb_i2c_address.Margin = new System.Windows.Forms.Padding(2);
            this.tb_i2c_address.Name = "tb_i2c_address";
            this.tb_i2c_address.Size = new System.Drawing.Size(71, 21);
            this.tb_i2c_address.TabIndex = 12;
            this.tb_i2c_address.Text = "0x03";
            // 
            // tb_i2c_read
            // 
            this.tb_i2c_read.Location = new System.Drawing.Point(300, 36);
            this.tb_i2c_read.Margin = new System.Windows.Forms.Padding(2);
            this.tb_i2c_read.Multiline = true;
            this.tb_i2c_read.Name = "tb_i2c_read";
            this.tb_i2c_read.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tb_i2c_read.Size = new System.Drawing.Size(63, 171);
            this.tb_i2c_read.TabIndex = 28;
            this.tb_i2c_read.Text = "0x01\r\n0x02\r\n0x03\r\n0x04\r\n0x05\r\n0x06\r\n0x07\r\n0x08\r\n0x09\r\n0x0A\r\n0x0B";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(212, 38);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(83, 12);
            this.label9.TabIndex = 27;
            this.label9.Text = "READ_DATAS";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(202, 213);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(93, 12);
            this.label11.TabIndex = 24;
            this.label11.Text = "INTERVAL(MS)";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(5, 213);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(93, 12);
            this.label8.TabIndex = 25;
            this.label8.Text = "INTERVAL(MS)";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 39);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 12);
            this.label7.TabIndex = 26;
            this.label7.Text = "WRITE_DATAS";
            // 
            // tb_i2c_read_interval
            // 
            this.tb_i2c_read_interval.Location = new System.Drawing.Point(300, 211);
            this.tb_i2c_read_interval.Margin = new System.Windows.Forms.Padding(2);
            this.tb_i2c_read_interval.Name = "tb_i2c_read_interval";
            this.tb_i2c_read_interval.Size = new System.Drawing.Size(79, 21);
            this.tb_i2c_read_interval.TabIndex = 22;
            this.tb_i2c_read_interval.Text = "10";
            // 
            // tb_i2c_write_interval
            // 
            this.tb_i2c_write_interval.Location = new System.Drawing.Point(100, 211);
            this.tb_i2c_write_interval.Margin = new System.Windows.Forms.Padding(2);
            this.tb_i2c_write_interval.Name = "tb_i2c_write_interval";
            this.tb_i2c_write_interval.Size = new System.Drawing.Size(79, 21);
            this.tb_i2c_write_interval.TabIndex = 23;
            this.tb_i2c_write_interval.Text = "10";
            // 
            // btn_i2c_all_read
            // 
            this.btn_i2c_all_read.Location = new System.Drawing.Point(300, 233);
            this.btn_i2c_all_read.Margin = new System.Windows.Forms.Padding(2);
            this.btn_i2c_all_read.Name = "btn_i2c_all_read";
            this.btn_i2c_all_read.Size = new System.Drawing.Size(78, 20);
            this.btn_i2c_all_read.TabIndex = 19;
            this.btn_i2c_all_read.Text = "ALL READ";
            this.btn_i2c_all_read.UseVisualStyleBackColor = true;
            this.btn_i2c_all_read.Click += new System.EventHandler(this.btn_i2c_all_read_Click);
            // 
            // tb_i2c_write
            // 
            this.tb_i2c_write.Location = new System.Drawing.Point(100, 37);
            this.tb_i2c_write.Margin = new System.Windows.Forms.Padding(2);
            this.tb_i2c_write.Multiline = true;
            this.tb_i2c_write.Name = "tb_i2c_write";
            this.tb_i2c_write.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tb_i2c_write.Size = new System.Drawing.Size(91, 171);
            this.tb_i2c_write.TabIndex = 21;
            this.tb_i2c_write.Text = "0x01,0x00\r\n0x02,0x00\r\n0x03,0x00\r\n0x04,0x00\r\n0x05,0x00\r\n0x06,0x00\r\n0x07,0x00\r\n0x08" +
    ",0x00\r\n0x09,0x00\r\n0x0A,0x00\r\n0x0B,0x00";
            // 
            // btn_i2c_all_write
            // 
            this.btn_i2c_all_write.Location = new System.Drawing.Point(100, 233);
            this.btn_i2c_all_write.Margin = new System.Windows.Forms.Padding(2);
            this.btn_i2c_all_write.Name = "btn_i2c_all_write";
            this.btn_i2c_all_write.Size = new System.Drawing.Size(78, 20);
            this.btn_i2c_all_write.TabIndex = 20;
            this.btn_i2c_all_write.Text = "ALL WRITE";
            this.btn_i2c_all_write.UseVisualStyleBackColor = true;
            this.btn_i2c_all_write.Click += new System.EventHandler(this.btn_i2c_all_write_Click);
            // 
            // lbl_deviceStatus_led
            // 
            this.lbl_deviceStatus_led.AutoSize = true;
            this.lbl_deviceStatus_led.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbl_deviceStatus_led.Location = new System.Drawing.Point(362, 16);
            this.lbl_deviceStatus_led.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_deviceStatus_led.Name = "lbl_deviceStatus_led";
            this.lbl_deviceStatus_led.Size = new System.Drawing.Size(17, 12);
            this.lbl_deviceStatus_led.TabIndex = 18;
            this.lbl_deviceStatus_led.Text = "●";
            // 
            // lbl_deviceStatus
            // 
            this.lbl_deviceStatus.AutoSize = true;
            this.lbl_deviceStatus.Location = new System.Drawing.Point(279, 16);
            this.lbl_deviceStatus.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_deviceStatus.Name = "lbl_deviceStatus";
            this.lbl_deviceStatus.Size = new System.Drawing.Size(82, 12);
            this.lbl_deviceStatus.TabIndex = 17;
            this.lbl_deviceStatus.Text = "Device Status";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.tb_spi_read);
            this.tabPage3.Controls.Add(this.label4);
            this.tabPage3.Controls.Add(this.tb_spi_write);
            this.tabPage3.Controls.Add(this.label2);
            this.tabPage3.Controls.Add(this.btn_spi_send);
            this.tabPage3.Controls.Add(this.lbl_deviceStatus_led2);
            this.tabPage3.Controls.Add(this.label3);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(414, 264);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "SPI";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // lbl_deviceStatus_led2
            // 
            this.lbl_deviceStatus_led2.AutoSize = true;
            this.lbl_deviceStatus_led2.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbl_deviceStatus_led2.Location = new System.Drawing.Point(367, 19);
            this.lbl_deviceStatus_led2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_deviceStatus_led2.Name = "lbl_deviceStatus_led2";
            this.lbl_deviceStatus_led2.Size = new System.Drawing.Size(17, 12);
            this.lbl_deviceStatus_led2.TabIndex = 20;
            this.lbl_deviceStatus_led2.Text = "●";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(284, 19);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 12);
            this.label3.TabIndex = 19;
            this.label3.Text = "Device Status";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btn_spi_send
            // 
            this.btn_spi_send.Location = new System.Drawing.Point(195, 35);
            this.btn_spi_send.Name = "btn_spi_send";
            this.btn_spi_send.Size = new System.Drawing.Size(75, 23);
            this.btn_spi_send.TabIndex = 21;
            this.btn_spi_send.Text = "SEND";
            this.btn_spi_send.UseVisualStyleBackColor = true;
            this.btn_spi_send.Click += new System.EventHandler(this.btn_spi_send_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 12);
            this.label2.TabIndex = 22;
            this.label2.Text = "WRITE_DATA";
            // 
            // tb_spi_write
            // 
            this.tb_spi_write.Location = new System.Drawing.Point(89, 35);
            this.tb_spi_write.Name = "tb_spi_write";
            this.tb_spi_write.Size = new System.Drawing.Size(100, 21);
            this.tb_spi_write.TabIndex = 23;
            this.tb_spi_write.Text = "0x01";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 12);
            this.label4.TabIndex = 22;
            this.label4.Text = "READ_DATA";
            // 
            // tb_spi_read
            // 
            this.tb_spi_read.Location = new System.Drawing.Point(89, 62);
            this.tb_spi_read.Name = "tb_spi_read";
            this.tb_spi_read.ReadOnly = true;
            this.tb_spi_read.Size = new System.Drawing.Size(100, 21);
            this.tb_spi_read.TabIndex = 23;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 314);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "CH341_COM";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_uart_connect;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Label lbl_uart_status;
        private System.Windows.Forms.ComboBox cb_uart_portname;
        private System.Windows.Forms.ComboBox cb_uart_baudrate;
        private System.Windows.Forms.Label lbl_uart_comport;
        private System.Windows.Forms.Label lbl_uart_baudrate;
        private System.Windows.Forms.Button btn_uart_send;
        private System.Windows.Forms.TextBox tb_uart_receive;
        private System.Windows.Forms.TextBox tb_uart_write;
        private System.Windows.Forms.Button btn_uart_receive;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lbl_deviceStatus_led;
        private System.Windows.Forms.Label lbl_deviceStatus;
        private System.Windows.Forms.Label lbl_i2c_read_result;
        private System.Windows.Forms.TextBox tb_i2c_read;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tb_i2c_read_interval;
        private System.Windows.Forms.TextBox tb_i2c_write_interval;
        private System.Windows.Forms.Button btn_i2c_all_read;
        private System.Windows.Forms.TextBox tb_i2c_write;
        private System.Windows.Forms.Button btn_i2c_all_write;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_i2c_address;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label lbl_deviceStatus_led2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_spi_send;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_spi_read;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_spi_write;
    }
}

