using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp16
{
    internal abstract class Animal
    {
        protected string _food;
        protected string _location;
        public abstract void MakeNoise();
        public abstract void Eat();
        public abstract void Sleep();
        public abstract void GetInfo();
    }
}
