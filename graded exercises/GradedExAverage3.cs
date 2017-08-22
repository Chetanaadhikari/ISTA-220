using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14
{
    class Program
    {
        static void Main(string[] args)
        {
            double y = 0;
            Console.WriteLine("\n Please enter a test score between 0 and 100, if you want to quit enter -1: ");
            double x = double.Parse(Console.ReadLine());
            int n = 0;

            while ( x != -1)
            {
                n++;
                y += x;
                Console.WriteLine("\n Please enter another test score between 0 and 100 or type -1.0 to quit: ");
                 x = double.Parse(Console.ReadLine());
                
                

            }


            double z = y / n;
            Console.WriteLine("The average of the test scores you entered is" + " " + (z));
            Console.ReadLine();

            if (z >= 90 && z <= 100)
            {
                Console.WriteLine("\n The average grade is A");
                Console.ReadLine();
            }

            else if (z >= 80 && z < 90)
            {
                Console.WriteLine("\n The average grade is B");
                Console.ReadLine();


            }

            else if (z >= 70 && z < 80)
            {
                Console.WriteLine("\n The average grade is C");
                Console.ReadLine();
            }


            else if (z >= 60 && z < 70)

            {
                Console.WriteLine("\n The average grade is D");
                Console.ReadLine();
            }

            else
            {
                Console.WriteLine("\n You have failed. ");
                Console.ReadLine();

            }
        }
    }
}
