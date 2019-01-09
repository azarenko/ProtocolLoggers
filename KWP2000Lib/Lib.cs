using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Text;

namespace KWP2000Lib
{
    public static class Lib
    {
        public static Message ReadMessage(this SerialPort serialPort)
        {
            Message message = new Message();

            int crc_buffer = 0;

            byte header = (byte)serialPort.ReadByte();
            crc_buffer += header;

            if (header >> 5 == 0)
                throw new Exception("Unsupported message type");

            int len = header & 0x3F;

            message.Target = (byte)serialPort.ReadByte();
            crc_buffer += message.Target;
            message.Source = (byte)serialPort.ReadByte();
            crc_buffer += message.Source;

            if (len == 0)
            {
                len = (byte)serialPort.ReadByte();
                crc_buffer += len;
            }

            message.Sid = (byte)serialPort.ReadByte();
            crc_buffer += message.Sid;

            message.Data = new byte[len];
            for (int i = 0; i < len; i++)
            {
                message.Data[i] = (byte)serialPort.ReadByte();
                crc_buffer += message.Data[i];
            }

            int crc = serialPort.ReadByte();
          
            if((crc_buffer & 0xFF) != crc)
                throw new Exception("CRC is not valid");

            return message;
        }

        public static void WriteMessage(this SerialPort serialPort, Message message)
        {
                        
        }
    }
}
