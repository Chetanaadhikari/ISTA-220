﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicles
{
    class Airplane : Vehicles
    {
       public void Takeoff()
        { Console.WriteLine("Taking off"); }

        public void Land ()
        { Console.WriteLine("Landing"); }

        public override void Drive()
        { Console.WriteLine("Flying"); }

          }
}