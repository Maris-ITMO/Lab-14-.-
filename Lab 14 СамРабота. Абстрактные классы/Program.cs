using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_14_СамРабота._Абстрактные_классы
{
    class Program
    {
        static void Main(string[] args)
        {
            Cat cat = new Cat("Мурка");
            cat.ShowInfo();

            Dog dog = new Dog("Тузик");
            dog.ShowInfo();
            Console.ReadKey();
        }
    }
}