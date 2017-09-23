using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp15
{
    class Program
    {
        static void Main(string[] args)
        {
            double y = 0;
            Console.WriteLine("\n Write the number of scores you want to calculate the average for: ");
            int n = int.Parse(Console.ReadLine());
            int g = n -1;
            Console.WriteLine("\n Enter the test score: ");
            double x = double.Parse(Console.ReadLine());
            y += x;

            while (g > 0)
            {
                g--;
                
                Console.WriteLine("\n Enter the next test score: ");
                x = double.Parse(Console.ReadLine());
                y += x;
            }

            double z = y / n;
            Console.WriteLine("\n The average of the" + "" + n + "" + "testscores you entered is" + " " + z + ".");
            Console.ReadLine();
        }

    }
}
