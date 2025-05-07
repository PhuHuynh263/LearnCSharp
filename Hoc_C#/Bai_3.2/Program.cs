using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_3._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float x, y;
            Console.Write("Moi ban nhap vao gia tri cua x : ");
            x = float.Parse(Console.ReadLine());

            Console.Write("Moi ban nhap vao gia tri cua y : ");
            y = float.Parse(Console.ReadLine());

            float z1 = x + y;
            float z2 = x - y;
            float z3 = x * y;
            float z4 = x / y;
            float z5 = x % y;


            Console.WriteLine($"{x} + {y} = {z1}");
            Console.WriteLine($"{x} - {y} = {z2}");
            Console.WriteLine($"{x} * {y} = {z3}");
            Console.WriteLine($"{x} / {y} = {z4}");
            Console.WriteLine($"{x} % {y} = {z5}");

        }
    }
}
