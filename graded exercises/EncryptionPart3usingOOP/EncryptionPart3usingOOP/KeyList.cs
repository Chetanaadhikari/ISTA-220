using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncryptionPart3usingOOP
{
    public class KeyList
    {
        public static List<int> KeyasciiList(string stringfilteredkey, string stringfilteredsentence)
        {

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


            List<int> newList = new List<int>();
            List<int> sentenceList = new List<int>();

            for (int i = 0; i < stringfilteredkey.Length; i++)
            {
                string x = stringfilteredkey[i].ToString();

                int kkey = Key[x];
                newList.Add(kkey);

            }

            for (int j = 0; j < stringfilteredsentence.Length; j++)
            {
                string y = stringfilteredsentence[j].ToString();
                int skey = Key[y];
                sentenceList.Add(skey);

            }

            if (newList.Count < stringfilteredsentence.Length)
            {
                int keydifferencesentence = stringfilteredsentence.Length - newList.Count;
                int p = (keydifferencesentence / stringfilteredkey.Length);
                int remainder = (keydifferencesentence % stringfilteredkey.Length);


                while (p != 0)
                {
                    int n = stringfilteredsentence.Length;
                    int c = 0;
                    do
                    {
                        newList.Add(sentenceList[c]);
                        c++;
                        n--;

                    } while (n != 0);
                    p--;
                }

                int nn = remainder;


                int cc = 0;

                while (nn != 0)
                {
                    newList.Add(newList[cc]);
                    cc++;
                    nn--;

                }

            }


            return newList;
        }
    }
}
