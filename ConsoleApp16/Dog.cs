using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp16
{
    internal class Dog:Animal
    {
        public Dog()
        {

        }
        public Dog(string food,string location)
        {
            _food = "кости";
            _location = "лай";
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
