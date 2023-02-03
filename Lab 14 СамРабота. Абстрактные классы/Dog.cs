using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_14_СамРабота._Абстрактные_классы
{
    class Dog : Animal
    {        
        public Dog(string name)
            : base(name)
        {
            Name = name;
        }

        public override void Say()
        {
            Console.WriteLine("Гав");
        }
    }
}