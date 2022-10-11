using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp16
{
    internal class Cat:Animal
    {
        public Cat()
        {

        }
        public Cat(string food, string location)
        {
            _food=food;
            _location = location;
        }

        public override void MakeNoise()
        {
            Console.WriteLine($"Мяукает");
        }
        public override void Eat()
        {
            Console.WriteLine($"Ест рыбу");
        }
        public override void Sleep()
        {

        }
    }
}
