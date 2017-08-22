using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Programz
    {
        double a, b, c;
        public void read()
        {
            Console.WriteLine("\n enter value of a:");
            a = double.Parse(Console.ReadLine());
            Console.WriteLine("\n enter value of b:");
            b = double.Parse(Console.ReadLine());
            Console.WriteLine("\n enter value of c:");
            c = double.Parse(Console.ReadLine());
        }

        public void compute()
        {
            int value;
            double x1, x2, d;

            d = (b * b) - (4 * a * c);

            if (d > 0)
                value = 1;

            else if (d == 0)
                value = 2;

            else
                value = 3;

            switch (value)
            {
                case 1: Console.WriteLine("\n root is a real number");
                       Console.ReadLine();
                    x1 = (-b + Math.Sqrt(d)) / (2 * a);
                    x2 = (-b - Math.Sqrt(d)) / (2 * a);
                    Console.WriteLine("\n the first value of x is" + x1);
                    Console.ReadLine();
                    Console.WriteLine("\n the second value of x is" + x2);
                    Console.ReadLine();
                    break;

                case 2: Console.WriteLine("\n root is a real number");
                    Console.ReadLine();
                    x1 = x2 = (-b) / (2 * a);
                    Console.WriteLine("\n the first value of root is" + x1);
                    Console.ReadLine();
                    Console.WriteLine("\n the Second value of root is", x2);
                    Console.ReadLine();
                    break;

                case 3: Console.WriteLine("\n root is an imaginary  number");
                    Console.ReadLine();
                    x1 = (-b + Math.Sqrt(-d)) / (2 * a);
                    x2 = (-b - Math.Sqrt(-d)) / (2 * a);
                    Console.WriteLine("\n the first value of x is" + x1);
                    Console.ReadLine();
                    Console.WriteLine("\n the second value of x is" + x2);
                    Console.ReadLine();
                    break;






            }



        }
        static void Main(string[] args)
        {
            Programz q = new Programz();
            q.read();
            q.compute();
        }
    }
}
