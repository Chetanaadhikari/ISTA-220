using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graded_Exercise_4
{
    public abstract class Tanks
    {
        public abstract void tankjobdescription();
        public abstract void tankjobsatisfaction();
        public abstract void numberoftankers();

    }
    class Tank : Tanks
    {
        public override void tankjobdescription()
        {
            Console.WriteLine("\n I am a tanker. I go to the frontline and destroy the enemy.");
                    }
        public override void tankjobsatisfaction()
        {
            Console.WriteLine("\n I am very satisfied with the job. I love going to combat and destroying the enemy.");
        }

        public override void numberoftankers()
        {
            Console.WriteLine("\n In this unit there are two hundred tankers. We are devided into three platoons.");
        }
    }
}
