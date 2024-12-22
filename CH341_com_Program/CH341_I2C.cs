using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CH341;


namespace CH341_com_Program
{
    public class CH341_I2C
    {
        CH341A ch = new CH341A();

        public bool i2cConnect()
        {
            return ch.OpenDevice();
        }

        public void i2cWrite(byte address, byte data1, byte data2)
        {
            ch.WriteI2C(address, data1, data2);
        }
        
        public void i2cRead(byte address, byte data, out byte data2)
        {
            ch.ReadI2C(address, data, out data2);
        }

        public void i2cSetStream(byte data)
        {
            ch.SetStream(data);
        }

        public void i2cConnectClose()
        {
            if(i2cConnect())
            {
                ch.CloseDevice();
            }
        }
    }
}
