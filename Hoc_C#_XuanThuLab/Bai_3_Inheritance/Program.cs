using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_3_Inheritance
{
    class Animal
    {
        public int Legs { get; set; }
        public float weight { get; set; }

        public void ShowLegs()
        {
            Console.WriteLine($"Legs: {Legs}");
        }
    }

    class Cat : Animal
    {
        public string food;

        public void Eat()
        {
            Console.WriteLine(food);
        }

        public Cat()
        {
            this.Legs = 4;
            this.food = "Mouse";

        }

    }


    internal class Program
    {
        static void Main(string[] args)
        {
            Cat c = new Cat();
            c.ShowLegs();
            c.Eat();
        }
    }
}
