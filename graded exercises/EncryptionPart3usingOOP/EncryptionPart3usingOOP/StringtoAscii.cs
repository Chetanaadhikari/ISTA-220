using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncryptionPart3usingOOP
{
    class StringtoAscii
    {
        public static byte[] converttobyte(string s)
        {

            byte[] Asciisentence = Encoding.ASCII.GetBytes(s);
            return Asciisentence;

        }
    }
}
