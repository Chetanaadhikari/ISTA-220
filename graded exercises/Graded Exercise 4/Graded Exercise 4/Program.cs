using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graded_Exercise_4
{

    

   public class Program 
    {




        static void Main(string[] args)
        {
            int i;
            Console.WriteLine("\n If you want to learn about Supply press 1, if you want to learn about Medic press 2, if you want to learn about Fueler press 3, if you want to learn about Tank press 4.");
             i = int.Parse(Console.ReadLine());

            do
            {
                switch (i)
                {

                    case 1:
                        Supply s = new Supply();
                        s.supjobdescription();
                        s.supjobsatisfaction();
                        s.numberofsupplyspecialists();
                        break;

                    case 2:
                        Medic m = new Medic();
                        m.jobdescription();
                        m.numberofmedics();
                        m.jobsatisfaction();
                        break;

                    case 3:
                        Fuel f = new Fuel();
                        f.fueljobdescription();
                        f.jobsatisfaction();
                        f.numberoffuelers();
                        break;

                    case 4:
                        Tank t = new Tank();
                        t.tankjobdescription();
                        t.tankjobsatisfaction();
                        t.numberoftankers();
                        break;


                }
                Console.WriteLine("\n If you want to learn about Supply press 1, if you want to learn about Medic press 2, if you want to learn about Fueler press 3, if you want to learn about Tank press 4. To quit type 0.");
                i = int.Parse(Console.ReadLine());

            } while (i != 0);
                    }
    }
}
