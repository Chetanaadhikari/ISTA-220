using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicles
{
    class Vehicles
    {
        public void StartEngine(string noiseToMakeStarting)
        { Console.WriteLine($"Starting engine: {noiseToMakeStarting}"); }
        public void StopEngine(string noiseToMakeWhenStopping)
        { Console.WriteLine($"Stopping engine: {noiseToMakeWhenStopping}"); }

        public virtual void Drive()
        { Console.WriteLine("Default implementation of the Drive method"); }


    }
}
