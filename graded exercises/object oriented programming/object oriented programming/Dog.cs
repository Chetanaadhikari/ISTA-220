using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace object_oriented_programming
{
    class Dog
    {
        public String dogtalk(string name, string animal, string talk, int height, int weight)
        {
            return $"Hi, My name is {name}. I am a {animal} and I say {talk}. My height is {height}ft and my weight is {weight}lbs.";
        }
    }

}
