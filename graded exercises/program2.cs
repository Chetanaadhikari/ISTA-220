using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncryptionGradedEx2
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
            string sentenceencryption = String.Join("", encryptsentence.Where(char.IsLetter));

           
            Dictionary<string , int> Key = new Dictionary<string, int>();
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
            Key.Add("0", 15);
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
                int p =(keydifferencesentence/encryptionkey.Length);
                int remainder = (keydifferencesentence % encryptionkey.Length);


                do
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
                } while (p != 0);

                int nn = remainder;
                
                
                    int cc = 0;

                while(nn != 0)
                {
                        newList.Add(newList[cc]);
                        cc++;
                        nn--;

                    } 
                

                

                byte[] Asciisentence = Encoding.ASCII.GetBytes(sentenceencryption);


                for (int j = 0; j < Asciisentence.Length; j++)
                {
                    int newascii = Asciisentence[j];
                    int Encrypted = newascii + newList[j];

                    if (Encrypted > 90)
                    {
                        int Encryptedone = Encrypted - 26;

                        byte[] ASciitosentence = BitConverter.GetBytes(Encryptedone);

                        string s = Encoding.ASCII.GetString(ASciitosentence);
                        Console.Write(s);
                    }
                    else
                    {
                        
                        byte[] ASciitosentence = BitConverter.GetBytes(Encrypted);

                        string s = Encoding.ASCII.GetString(ASciitosentence);
                        Console.Write(s);
                    
                    } 


                    
                    
                    

                }


                   

                }



            }

            
        
    }
}
