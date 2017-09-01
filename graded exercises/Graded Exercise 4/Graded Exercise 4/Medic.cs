using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graded_Exercise_4
{

   public abstract class Med
    {
        public abstract void jobdescription();
        public abstract void jobsatisfaction();
        public abstract void numberofmedics();
        
            
    }


   public class Medic : Med

    {
        public override void  jobdescription()
        {
            Console.WriteLine("\n I am a medic and I treat people in the platoon.");

        }

        public override void jobsatisfaction()
        {
            Console.WriteLine("\n As a medic I am very satisfied with my job. It feels great saving lives.");
        }

        public override void numberofmedics()
        {
            Console.WriteLine("\n In this army unit there are 4 medics. Two of us do sick call. And the other two take care of transporting");
        }
    }
}
