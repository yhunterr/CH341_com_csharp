using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;


namespace CH341_com_Program
{
    public class Uart
    {
        private SerialPort _serialPort;

        public Uart(SerialPort serialPort)
        {
            _serialPort = serialPort;
        }

        public void uartWrite(string data)
        {
            if(_serialPort.IsOpen)
            {
                _serialPort.Write(data);
            }
        }

        public string uartReceive()
        {
            if(_serialPort.IsOpen)
            {
                return _serialPort.ReadExisting();
            }
            return string.Empty;
        }

        public bool uartConnect(int baudRate, string portName)
        {
            try
            {
                _serialPort.BaudRate = baudRate;
                _serialPort.PortName = portName;
                _serialPort.Open();
            }
            catch
            {
                return false;
            }
            return true;
        }
        public bool uartDisconnect()
        {
            try
            {
                _serialPort.Close();
            }
            catch
            {
                return false;
            }
            return true;
        }

        public bool uartConnectCheck()
        {
            return _serialPort.IsOpen;
        }
        public string[] uartGetPortname()
        {
            return SerialPort.GetPortNames();
        }
    }
}
