using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    class Program
    {
        string a;
        double b, c, d;
        int n, i;
        public void read()

        {
            Console.WriteLine("\n Please enter a value for a or type quit");
            a = (Console.ReadLine());
            if (a != "quit")
            {
                b = double.Parse(a);
                b += b;
                c = b / n;
                n = n++;
                return;
            }

            Console.WriteLine("The average sum is" + "" + c);
            Console.ReadLine();
        
     
                

               
            }


        

    





                

            










        static void Main(string[] args)
        {
            Program q = new Program();
            q.read();
        }
    }
}
