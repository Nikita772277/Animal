using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp16
{
    internal class Veterinarian
    {

        public void TreatAnimal(Animal animal)
        {
            Console.WriteLine($"Животное на приёме");
            animal.GetInfo();
            Console.WriteLine();
        }
    }
}
