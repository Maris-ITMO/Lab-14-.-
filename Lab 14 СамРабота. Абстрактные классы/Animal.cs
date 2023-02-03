using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_14_СамРабота._Абстрактные_классы
{
    abstract class Animal
    {
        public string Name { get; set; }

        public Animal(string name)
        {
            Name = name;
        }

        public abstract void Say();

        public void ShowInfo()
        {
            Console.WriteLine(Name);
            Say();
        }
    }
}