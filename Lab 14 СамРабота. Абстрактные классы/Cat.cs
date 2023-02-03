using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_14_СамРабота._Абстрактные_классы
{
    class Cat : Animal
    {
        public Cat(string name)
            : base(name)
        {
            Name = name;
        }
        public override void Say()
        {
            Console.WriteLine("Мяу");
        }
    }
}