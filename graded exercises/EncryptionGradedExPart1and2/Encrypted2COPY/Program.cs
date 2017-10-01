using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encrypted2COPY
{
    class Program
    {
        static void Main(string[] args)

        {

            Console.WriteLine("Enter a word that contains only letters. This will be your encryption key: ");
            string EncryptionKey = Console.ReadLine();
            string encrypt = EncryptionKey.ToUpper();

            string encryptionkey = String.Join("", encrypt.Where(char.IsLetter));

            Console.WriteLine("Enter the word/statement you want to encode");
            string encryptsentence = Console.ReadLine();
            string sentence = encryptsentence.ToUpper();
            string sentenceencryption = String.Join("", sentence.Where(char.IsLetter));
            //Console.WriteLine(sentenceencryption);


            Dictionary<string, int> Key = new Dictionary<string, int>();
            Key.Add("A", 1);
            Key.Add("B", 2);
            Key.Add("C", 3);
            Key.Add("D", 4);
            Key.Add("E", 5);
            Key.Add("F", 6);
            Key.Add("G", 7);
            Key.Add("H", 8);
            Key.Add("I", 9);
            Key.Add("J", 10);
            Key.Add("K", 11);
            Key.Add("L", 12);
            Key.Add("M", 13);
            Key.Add("N", 14);
            Key.Add("O", 15);
            Key.Add("P", 16);
            Key.Add("Q", 17);
            Key.Add("R", 18);
            Key.Add("S", 19);
            Key.Add("T", 20);
            Key.Add("U", 21);
            Key.Add("V", 22);
            Key.Add("W", 23);
            Key.Add("X", 24);
            Key.Add("Y", 25);
            Key.Add("Z", 26);
            List<string> finaldecrypted = new List<string>();
            //List<byte> Decryptionascii = new List<byte>();
            List<string> final = new List<string>();
            List<int> newList = new List<int>();

            for (int i = 0; i < encryptionkey.Length; i++)
            {
                string x = encryptionkey[i].ToString();

                int kkey = Key[x];
                newList.Add(kkey);

            }



            if (newList.Count < sentenceencryption.Length)
            {
                int keydifferencesentence = sentenceencryption.Length - newList.Count;
                int p = (keydifferencesentence / encryptionkey.Length);
                int remainder = (keydifferencesentence % encryptionkey.Length);


                while (p != 0) 
                {
                    int n = encryptionkey.Length;
                    int c = 0;
                    do
                    {
                        newList.Add(newList[c]);
                        c++;
                        n--;

                    } while (n != 0);
                    p--;
                } //while (p != 0);

                int nn = remainder;


                int cc = 0;

                while (nn != 0)
                {
                    newList.Add(newList[cc]);
                    cc++;
                    nn--;

                }

                /*for(int i = 0; i < newList.Count; i++)
                {
                    Console.Write(newList[i]);
                    
                }*/


            }

            
            byte[] Asciisentence = Encoding.ASCII.GetBytes(sentenceencryption);

            for (int i = 0; i < Asciisentence.Length; i++)
            {
               // Console.WriteLine("ASCII codes are" + " " + Asciisentence[i]);
            }



            for (int j = 0; j < Asciisentence.Length; j++)
            {
                //int newascii = Asciisentence[j];
                int Encrypted = Asciisentence[j] + newList[j];

                if (Encrypted > 90)
                {
                    int Encryptedone = Encrypted - 26;

                    byte[] ASciitosentence = BitConverter.GetBytes(Encryptedone);

                    string s = Encoding.ASCII.GetString(ASciitosentence);
                    final.Add(s);



                }
                else
                {

                    byte[] ASciitosentence = BitConverter.GetBytes(Encrypted);

                    string s = Encoding.ASCII.GetString(ASciitosentence);
                    final.Add(s);
                    
                                   

                }

                
            }

            for (int i = 0; i < final.Count; i++)
            {
                Console.Write(final[i]);
            }
            

            Console.WriteLine(" Do you want to decrypt your message. If yes then enter the key again: ");
            string newkeytwo = Console.ReadLine();
            string newkeyone = newkeytwo.ToUpper();
            string newkey = String.Join("", newkeyone.Where(char.IsLetter));
            string decrypt = "1";
            string finaldecryptedoutputone = "2";
            if (newkey.Equals(encryptionkey))
            {

                for (int j = 0; j < final.Count; j++)
                {

                    decrypt += final[j];


                    
                }

                string encrypttodecrypt = String.Join("", decrypt.Where(char.IsLetter));
               //Console.Write("the string to be decrypted is" + encrypttodecrypt);
                byte[] EncryptoDecrypt = Encoding.ASCII.GetBytes(encrypttodecrypt);

                for (int i = 0; i < EncryptoDecrypt.Length; i++)

                {
                    //Console.WriteLine("The decrypt ASCII is" + EncryptoDecrypt[i]);
                    if ((EncryptoDecrypt[i] - newList[i]) < 65)
                    {
                        int decrypted = (EncryptoDecrypt[i] - newList[i]) + 26;
                       // Console.WriteLine("The ascii added to keyascii is" + decrypted);

                        byte[] DecryptedtoSentence = BitConverter.GetBytes(decrypted);

                        string decryptedsentence = Encoding.ASCII.GetString(DecryptedtoSentence);
                        finaldecrypted.Add(decryptedsentence);



                    }

                    else
                    {
                        int decrypted = EncryptoDecrypt[i] - newList[i];
                        //Console.WriteLine("The ascii added to keyascii is" + decrypted);

                        byte[] DecryptedtoSentence = BitConverter.GetBytes(decrypted);

                        string decryptedsentence = Encoding.ASCII.GetString(DecryptedtoSentence);
                        finaldecrypted.Add(decryptedsentence);




                    }



                }

                

                for (int j = 0; j < finaldecrypted.Count; j++)
                {

                    finaldecryptedoutputone += finaldecrypted[j];

                }

                string finaldecryptedoutput = String.Join("", finaldecryptedoutputone.Where(char.IsLetter));
                Console.WriteLine("The decrypted message is" + " " + finaldecryptedoutput);



            }




        }
    }
}
