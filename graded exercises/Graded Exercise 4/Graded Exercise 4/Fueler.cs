using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graded_Exercise_4
{
   public abstract class Fueler
    {
        public abstract void fueljobdescription();
        public abstract void jobsatisfaction();
        public abstract void numberoffuelers();
    }

    public class Fuel : Fueler

    {      public override void fueljobdescription()

        { Console.WriteLine("\n I am a fueler!!! An army unit can not go anywhere without me."); }

        public override void jobsatisfaction()
        {
            Console.WriteLine("\n As a fueler, I am not very satisfied with my job. I sit around a lot, and get tasked out for silly details.");
        }

        public override void numberoffuelers()
        {
            Console.WriteLine("\n I am the one and only fueler of this unit.");
        }

    }
}
