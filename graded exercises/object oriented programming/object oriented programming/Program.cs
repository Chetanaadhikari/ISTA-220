using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace object_oriented_programming
{
    class Farm
    {
        static void Main(string[] args)
        {
            Horse z = new Horse();
            Console.WriteLine(z.Horsey("Rocky", "Horse", "Neigh Neigh, Neigh", 7, 120));
           

            Pig x = new Pig();
            Console.WriteLine(x.pigtalk("Piggy", "Pig", "Oink...Oink...Oink!!!", 3, 160));
          

            Dog y = new Dog();
            Console.WriteLine(y.dogtalk("Clifford", "Dog", "Woof...Woof...Woof", 7, 220));
           

            Cat k = new Cat();
            Console.WriteLine(k.cattalk("Tom", "Cat", "Meow...Meow...Meow", 2, 20));



        }

        
    }

}
