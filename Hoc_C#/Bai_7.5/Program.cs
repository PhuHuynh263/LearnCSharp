using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_7._5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;
            Console.Write("Please type a : ");
            a = int.Parse(Console.ReadLine());
            Console.Write("Please type b : ");
            b = int.Parse(Console.ReadLine());
            Console.Write("Please type c : ");
            c = int.Parse(Console.ReadLine());
            double delta = b * b - 4 * a * c;
            if (a == 0)
            {
                if (b == 0)
                {
                    if (c == 0)
                    {
                        Console.WriteLine("Equation with infinite solutions");
                    }
                    else
                    {
                        Console.WriteLine("Equation has no solution");
                    }
                }
                else
                {
                    Console.WriteLine($"The equation has a solution : {(double)-c / b}");
                }
            }
            else
            {
                if (delta == 0)
                {
                    int x = -b / 2 * a;
                    Console.WriteLine("The equation has a solution : {0}", x);
                }
                else if (delta > 0)
                {
                    double x1 = (-b + Math.Sqrt(delta)) / 2 * a;
                    double x2 = (-b - Math.Sqrt(delta)) / 2 * a;
                    Console.WriteLine("The equation has two solutions : {0} & {1}", x1, x2);
                }
                else
                {
                    Console.WriteLine("Equation has no solution");
                }
            }
        }
    }
}
