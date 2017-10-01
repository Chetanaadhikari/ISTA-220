using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encryption1and2WithOOP
{
   public class AsciiTostring
    {
        public static string asciitostring(int x)
        {
            byte[] AScii = BitConverter.GetBytes(x);

            string s = Encoding.ASCII.GetString(AScii);
            return s;

        }
    }
}
