using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    class Program
    {
        string a;
        double b, c, d;
        int n;
        public void crazy()
        {

            while (a != "done" )
            {
                Console.WriteLine("\n Please enter another number, and type done when you are done)");
                a = Console.ReadLine();
                b = Convert.ToDouble(a);
                d = 0;
                d += b;
                n = 0;
                n = n++;
                c = d / n;
            }

            Console.WriteLine("The average is" + " " + c);
            Console.ReadLine();
        }

       


    
        static void Main(string[] args)
        {
            Program c = new Program();
            c.crazy();
        }

    }
}
