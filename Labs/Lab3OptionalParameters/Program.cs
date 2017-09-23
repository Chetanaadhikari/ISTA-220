using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dailyRate
{
    class Program
    {
        static void Main(string[] args)
        {
            (new Program()).run();
        }
       

      


        private double calculateFee(double dailyRate = 500.0, int noOfDays = 1)

        { 
            Console.WriteLine("caculateFee using two optional parameters");
            Console.ReadLine();
            return dailyRate* noOfDays;


    }

    private double calculateFee(double dailyRate = 500.0)
     { 
    Console.WriteLine("calculateFee using one optional parameter");
            Console.ReadLine();
        int defaultnoOfDays = 1;
    return dailyRate* defaultnoOfDays;


}
    private double calculateFee()
        
        {
            Console.WriteLine("calculateFee using hardcoded values");
            Console.ReadLine();
            double defaultDailyRate = 400.0;
            int defaultnoOfDays = 1;
            return defaultDailyRate * defaultnoOfDays;
        }

        int a;
        void option()
        {
            Console.WriteLine("\n enter a value from 1 to 3 for a  ");
            a = int.Parse(Console.ReadLine());
        }
        int x, u;
        void choose()
        {

            x = a;
            if (a = 1)
                u = 4;
            else if (a = 2)
                u = 5
                    }


                

        }
        void run()
        {
            double fee = calculateFee();
            Console.WriteLine($"Fee is {fee}");
            Console.ReadLine();
        }
    }



}
