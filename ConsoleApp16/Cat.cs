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
            _food="рыба";
            _location = "мяуканье";
        }

        public override void MakeNoise()
        {
            Console.WriteLine($"издает звук: {_location}");
        }
        public override void Eat()
        {
            Console.WriteLine($"петается: {_food}");
        }
        public override void Sleep()
        {

        }
        public override void GetInfo()
        {
            MakeNoise();
            Eat();
        }

    }
}
