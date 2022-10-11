using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp16
{
    internal class Horse:Animal
    {
        public Horse()
        {

        }
        public Horse(string food, string location)
        {
            _food = food;
            _location = location;
        }

        public override void MakeNoise()
        {
            Console.WriteLine($"ржание");
        }
        public override void Eat()
        {
            Console.WriteLine($"сено");
        }
        public override void Sleep()
        {

        }
    }
}
