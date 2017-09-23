using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n Please write a positive number between 0 to 100");
            double x = double.Parse(Console.ReadLine());
            int n = 0;
            double avg = 0;

            while (x != -1)
            {
                avg += x;
                n++;
                Console.WriteLine("\n Please enter another positive number 0 to 100 or type -1 if you dont want to enter another number");
                x = double.Parse(Console.ReadLine());


            }

            double y = avg / n;
            Console.WriteLine("\n The average of the numbers is" + " " + (y));
            Console.ReadLine();


            if (y >= 90)
            {
                Console.WriteLine("Your average grade is A");
                Console.ReadLine();
            }

            else if (y >= 80 && y < 90)
            {
                Console.WriteLine("Your average grade is B");
                Console.ReadLine();

            }

            else if (y >= 70 && y < 80)
            {
                Console.WriteLine("Your average grade is C");
                Console.ReadLine();

            }

            else if (y >= 60 && y < 70)
            {
                Console.WriteLine("Your average grade is D");
                Console.ReadLine();

            }

            else
            {
                Console.WriteLine("You have failed");
                Console.ReadLine();
            }
        }



    }
}
