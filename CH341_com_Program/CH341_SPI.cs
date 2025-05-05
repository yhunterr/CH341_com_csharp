using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using CH341;


namespace CH341_com_Program
{
    public class CH341_SPI
    {
        [DllImport("CH341DLL.DLL")]
        public static extern bool CH341StreamSPI4(int index, int iChipSelect, int iLength, byte[] buf);


        CH341A ch = new CH341A();

        public bool spiConnect()
        {
            return ch.OpenDevice();
        }

        public void spiWrite(ref byte[] ioBuffer)
        {
            spiSetStream(0x81);
            ch.StreamSPI4(0x80,ref ioBuffer);
        }
        
        public void spiRead(byte address, byte data, out byte data2)
        {
            ch.ReadI2C(address, data, out data2);
        }

        public void spiSetStream(byte data)
        {
            // Bit 1 - Bit 0: I2C interface speed / SCL frequency
            //  00 = low speed / 20KHz
            //  01 = standard / 100KHz (default)
            //  10 = fast / 400KHz
            //  11 = high speed / 750KHz
            // Bit 2: SPI I/O count/IO pin, 
            //  0=Single input and single output (D3 clock/D5 out/D7 input) (default), 
            //  1=Double in and double out (D3 clock/D5 out D4) Out / D7 into D6 into
            // Bit 7: The bit order in the SPI byte, 
            //  0 = low bit first, (LSB)
            //  1 = high bit first (MSB)
            ch.SetStream(data);
        }

        public void spiConnectClose()
        {
            if(spiConnect())
            {
                ch.CloseDevice();
            }
        }
    }
}
