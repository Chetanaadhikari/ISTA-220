using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        double a, b, c;
        public void read()

        {
            Console.WriteLine("\n Enter value for a : ");
            a = double.Parse(Console.ReadLine());
            Console.WriteLine("\n Enter value for b : ");
            b = double.Parse(Console.ReadLine());
            Console.WriteLine("\n Enter value for c : ");
            c = double.Parse(Console.ReadLine());

        }

        public void calculate()
                    {
            




        

            int value;

            double s, x, y;

            s = (a + b + c) / 2;
            x = s * (s - a) * (s - b) * (s - c);
            


            if (x > 0)
                value = 1;

            else
                value = 2;

            switch (value)

            {
                case 1: Console.WriteLine("\n Roots are real");
                    y = Math.Sqrt(x);
                    Console.WriteLine("\n The area is" + y);
                    Console.ReadLine();
                                        break;

                case 2: Console.WriteLine("\n Roots are imaginary");
                    y = Math.Sqrt(-x);
                    Console.WriteLine("The area is" + y);
                    Console.ReadLine();
                    break;

                
                    


            }




        }

        public static void Main()
        {
            Program q = new Program();
            q.read();
            q.calculate();
        }
    }
}
