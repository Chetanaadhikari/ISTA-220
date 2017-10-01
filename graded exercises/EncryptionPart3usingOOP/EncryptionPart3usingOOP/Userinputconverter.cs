using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncryptionPart3usingOOP
{
    class Userinputconverter
    {
        public static string stringfilter(string input)
        {
            string encrypt = input.ToUpper();

            string filtered = String.Join("", encrypt.Where(char.IsLetter));
            return filtered;
        }
    }
}
