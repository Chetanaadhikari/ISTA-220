using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graded_Exercise_4
{

   public abstract class Sup
    {

        public abstract void supjobdescription();
        public abstract void supjobsatisfaction();
        public abstract void numberofsupplyspecialists();
    }

   public class Supply : Sup
    {

        public override void supjobdescription()
        {
            Console.WriteLine("\n I manage the supplies of the unit");
        }

        public override void supjobsatisfaction()
        {
            Console.WriteLine("\n As a supply specialist my unit makes me work a lot. The commander never leaves me alone.It is very stressful to be a supply specialist.");

        }

        public override void numberofsupplyspecialists()
        {
            Console.WriteLine("\n There are two supply specialists in this unit. One is a supply NCO, who supervises me. The other is me...the one and only supply specialist.");
        }
    }
}
