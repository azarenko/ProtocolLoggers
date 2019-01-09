using System;
using System.Collections.Generic;
using System.Text;

namespace KWP2000Lib
{
    public class Message
    {
        public byte Target
        {
            get; set;
        }

        public byte Source
        {
            get; set;
        }

        public byte Sid
        {
            get; set;
        }

        public byte[] Data
        {
            get; set;
        }        
    }
}
