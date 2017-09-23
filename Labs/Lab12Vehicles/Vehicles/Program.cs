using System;

namespace Vehicles
{
    class Program
    {
        static void doWork()
        {
            Console.WriteLine("Journey by airplane:");
            Airplane myplane = new Airplane();
            myplane.StartEngine("Contact");
            myplane.Takeoff();
            myplane.Drive();
            myplane.Land();
            myplane.StopEngine("Whirr");

            Console.WriteLine("\nJourney by car");
            Car mycar = new Car();
            mycar.StartEngine("Brm brm");
            mycar.Accelerate();
            mycar.Drive();
            mycar.Brake();
            mycar.StopEngine("phut phut");

            Console.WriteLine("\nTesting polymorphism");
            Vehicles v = mycar;
            v.Drive();
            v = myplane;
            v.Drive();






            // TODO:
        }

        static void Main()
        {
            try
            {
                doWork();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception: {0}", ex.Message);
            }
        }
    }
}
