using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Area
{ 
    class Programs
    {
        double r;
        public void read()
        { 
            Console.WriteLine("\n Provide the value of radius r:");
           r = double.Parse(Console.ReadLine());

        }

        public void compute()
        {
            double a, p;
            a = (r * r) * Math.PI;
            Console.WriteLine("\n The area of the circle is" + a);
            Console.ReadLine();
            p = 2 * r * Math.PI;
            Console.WriteLine("\n The circumference of the circle is" + p);
            Console.ReadLine();
            }




        
    
        static void Main(string[] args)
        {
        Programs a = new Programs();
        a.read();
        a.compute();
        }
    }

}