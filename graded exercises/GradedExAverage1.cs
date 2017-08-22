using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13
{
    class Program
    {
        static void Main(string[] args)
        {

            double x, y;
            Console.WriteLine("\n Please enter a test score between 0 and 100: ");
            x = double.Parse(Console.ReadLine());
            int n = 3;

            while (n < 4 && n > 0)
            {
                n--;
                Console.WriteLine("\n Please enter another test score between 0 and 100: ");
                y = double.Parse(Console.ReadLine());
                x += y;
                
            }

            double z = x / 4;

            Console.WriteLine("The average of the test scores you entered is" + " " + z);
            Console.ReadLine();

            if (z >= 90 && z < 100)
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
                Console.WriteLine("\n You have failed: ");
                Console.ReadLine();

            }


        }
    }
}
