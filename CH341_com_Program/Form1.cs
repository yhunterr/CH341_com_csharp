using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CH341_com_Program
{
    public partial class Form1 : Form
    {
        private Uart uart;

        public Form1()
        {
            InitializeComponent();
        }

        
        void ui_cb_uart_portname()
        {
            string[] ports = uart.uartGetPortname();
            cb_uart_portname.Items.Clear();
            cb_uart_portname.Items.AddRange(ports);
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            uart = new Uart(serialPort1);
            ui_cb_uart_portname();

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

        private void button1_Click(object sender, EventArgs e)
        {
            Console.WriteLine(cb_uart_baudrate.Text + "");
        }

        private void cb_uart_portname_Click(object sender, EventArgs e)
        {
            ui_cb_uart_portname();
        }
    }
}
