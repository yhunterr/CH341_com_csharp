using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CH341_com_Program
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            uart = new Uart(serialPort1,Uart.DataReceiveMode.EventBased);
            ch341_i2c = new CH341_I2C();
            ch341_spi = new CH341_SPI();
            uart.DataReceived += OnDataReceived;

            ui_cb_uart_portname();
        }

        #region UART
        private Uart uart;

        void ui_cb_uart_portname()
        {
            string[] ports = uart.uartGetPortname();
            cb_uart_portname.Items.Clear();
            cb_uart_portname.Items.AddRange(ports);
        }

        private void OnDataReceived(string data)
        {
            if (InvokeRequired)
            {
                Invoke(new Action(() => OnDataReceived(data)));
            }
            else
            {
                tb_uart_receive.Text += data;
            }
        }
        private void uart_connect_btn_Click(object sender, EventArgs e)
        {
            if (uart.uartConnectCheck())
            {
                btn_uart_connect.Text = "connect";
                
                if(uart.uartDisconnect())
                {
                    lbl_uart_status.Text = "disconnect~";
                }
            }
            else
            {
                try
                {
                    if (uart.uartConnect(int.Parse(cb_uart_baudrate.Text), cb_uart_portname.Text))
                    {
                        lbl_uart_status.Text = "connect!";
                        btn_uart_connect.Text = "disconnect";
                    }
                    else
                    {
                        lbl_uart_status.Text = "connect try fail!";
                        btn_uart_connect.Text = "connect";
                    }
                }
                catch
                {
                    lbl_uart_status.Text = "error!";
                }
            }  
        }

        private void btn_uart_send_Click(object sender, EventArgs e)
        {
            uart.uartWrite(tb_uart_write.Text);
        }

        private void cb_uart_portname_Click(object sender, EventArgs e)
        {
            ui_cb_uart_portname();
        }

        private void btn_uart_receive_Click(object sender, EventArgs e)
        {
            tb_uart_receive.Text += uart.uartReceive();
        }
        #endregion
        #region I2C
        private CH341_I2C ch341_i2c;
        private Byte i2c_address;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (ch341_i2c.i2cConnect())
            {
                lbl_deviceStatus_led2.ForeColor = lbl_deviceStatus_led.ForeColor = Color.Green;
                btn_i2c_all_read.Enabled = btn_i2c_all_write.Enabled = true;
                i2c_address = Convert.ToByte(tb_i2c_address.Text, 16);
            }
            else
            {
                lbl_deviceStatus_led2.ForeColor = lbl_deviceStatus_led.ForeColor = Color.Red;
                btn_i2c_all_read.Enabled = btn_i2c_all_write.Enabled = false;
            }
        }
        private void btn_i2c_all_write_Click(object sender, EventArgs e)
        {
            string s_test = tb_i2c_write.Text;
            string[] s_split = s_test.Split(',', '\n', ' ');

            for (int i = 0; i < s_split.Length; i++)
            {
                s_split[i] = s_split[i].Replace("\r", "");
            }
            for (int i = 0; i < s_split.Length; i++)
            {
                if (ch341_i2c.i2cConnect())
                {
                    ch341_i2c.i2cWrite(i2c_address, Convert.ToByte(s_split[i], 16), Convert.ToByte(s_split[i + 1], 16));
                    Thread.Sleep(Convert.ToInt32(tb_i2c_write_interval.Text));
                }
                i++;
            }
        }

        
        private void btn_i2c_all_read_Click(object sender, EventArgs e)
        {
            string s_test = tb_i2c_read.Text;
            string READ_DATA_ALL = "";
            string[] s_split = s_test.Split('\n', ' ');
            Byte READ_DATA;

            for (int i = 0; i < s_split.Length; i++)
            {
                s_split[i] = s_split[i].Replace("\r", "");
            }

            for (int i = 0; i < s_split.Length; i++)
            {
                if (ch341_i2c.i2cConnect())
                {
                    ch341_i2c.i2cRead(i2c_address, Convert.ToByte(s_split[i], 16), out READ_DATA);
                    READ_DATA_ALL += "0x" + Convert.ToString(READ_DATA, 16) + "\n";
                    lbl_i2c_read_result.Text = READ_DATA_ALL;
                    Thread.Sleep(Convert.ToInt32(tb_i2c_read_interval.Text));
                }
            }
        }
        #endregion


        #region SPI
        private CH341_SPI ch341_spi;

        private void btn_spi_send_Click(object sender, EventArgs e)
        {
            string hexText = tb_spi_write.Text.Trim();
            if (hexText.StartsWith("0x") || hexText.StartsWith("0X"))
            {
                hexText = hexText.Substring(2);
            }

            byte oneByte = Convert.ToByte(hexText, 16);
            byte[] b_test = new byte[] { oneByte };

            Console.WriteLine(b_test[0]);

            if (ch341_spi.spiConnect())
            {
                ch341_spi.spiWrite(ref b_test);
                int value = int.Parse(b_test[0]+"");
                string s_ead = "0x" + value.ToString("X2");

                tb_spi_read.Text = s_ead;
            }
        }
        #endregion

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            ch341_i2c.i2cConnectClose();
        }


    }
}
