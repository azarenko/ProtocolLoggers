using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Text;

namespace PortUtilits
{
    public static class Utilites
    {
        public static void WriteByte(this SerialPort port, byte b)
        {
            port.Write(new byte[] { b }, 0, 1);            
        }
    }
}
