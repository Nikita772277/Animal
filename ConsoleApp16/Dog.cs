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
            _food = food;
            _location = location;
        }

        public override void MakeNoise()
        {
            Console.WriteLine($"гавкает");
        }
        public override void Eat()
        {
            Console.WriteLine($"кости");
        }
        public override void Sleep()
        {
            
        }
    }
}
