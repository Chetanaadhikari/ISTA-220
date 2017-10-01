using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncryptionPart3usingOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a key that you want to use for Encryption. " +
                "It should contain only letters. Non letter inputs will be deleted: ");
            string userinputkey = null;
            while (true)
            {
                var key = System.Console.ReadKey(true);
                if (key.Key == ConsoleKey.Enter)
                    break;
                userinputkey += key.KeyChar;

            }
           
            string filteredkey = Userinputconverter.stringfilter(userinputkey);

            Console.WriteLine("Enter a sentence that you want to decrypt using the key you provided");
            string userinputmessage = null;
            while (true)
            {
                var key = System.Console.ReadKey(true);
                if (key.Key == ConsoleKey.Enter)
                    break;
                userinputmessage += key.KeyChar;

            }
            string filteredsentence = Userinputconverter.stringfilter(userinputmessage);

            List<int> NewList = KeyList.KeyasciiList(filteredkey, filteredsentence);
            List<string> final = new List<string>();
            List<string> finaldecrypted = new List<string>();

            byte[] convertsentencetoascii = StringtoAscii.converttobyte(filteredsentence);

            for (int j = 0; j < convertsentencetoascii.Length; j++)
            {

                int Encrypted = convertsentencetoascii[j] + NewList[j];

                if (Encrypted > 90)
                {
                    int Encryptedone = Encrypted - 26;

                    string s = AsciiTostring.asciitostring(Encryptedone);

                    final.Add(s);
                }

                else
                {

                    string s = AsciiTostring.asciitostring(Encrypted);
                    final.Add(s);

                }

            }

            Console.WriteLine("The encrypted message is: ");
            for (int i = 0; i < final.Count; i++)
            {
                Console.Write(final[i]);
            }

            Console.WriteLine("Do you want to decrypt your message. If yes then enter the key again: ");
            
            string newkeytwo = null;
            while (true)
            {
                var key = System.Console.ReadKey(true); //Readkey(bool) gives the option to display text or not
                if (key.Key == ConsoleKey.Enter)        // True = No display. False = Display
                    break;
                newkeytwo += key.KeyChar;

            }
            string Decryptionkey = Userinputconverter.stringfilter(newkeytwo);

            string decrypt = "1";
            string finaldecryptedoutputone = "2";

            if (Decryptionkey.Equals(filteredkey))
            {

                for (int j = 0; j < final.Count; j++)
                {

                    decrypt += final[j];

                }

                string Encryptedstring = Userinputconverter.stringfilter(decrypt);
                byte[] Ecrypted = StringtoAscii.converttobyte(Encryptedstring);

                for (int i = 0; i < Encryptedstring.Length; i++)


                {

                    if ((Ecrypted[i] - NewList[i]) < 65)
                    {
                        int decrypted = (Ecrypted[i] - NewList[i]) + 26;

                        string decryptedsentence = AsciiTostring.asciitostring(decrypted);

                        finaldecrypted.Add(decryptedsentence);
                    }

                    else
                    {
                        int decrypted = Ecrypted[i] - NewList[i];

                        string decryptedsentence = AsciiTostring.asciitostring(decrypted);

                        finaldecrypted.Add(decryptedsentence);

                    }
                }

                for (int j = 0; j < finaldecrypted.Count; j++)
                {

                    finaldecryptedoutputone += finaldecrypted[j];

                }

                string finaldecryptedoutput = Userinputconverter.stringfilter(finaldecryptedoutputone);
                Console.WriteLine("The decrypted message is" + " " + finaldecryptedoutput);





            }
        }
    }
}
