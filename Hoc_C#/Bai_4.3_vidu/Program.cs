using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_4._3_vidu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b = 2;
            Console.Write("Nhap so nguyen a : ");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine($"a += 3 = {a += 3}");
            Console.Write("Nhap so nguyen a : ");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine($"a -= 5 = {a -= 5}");
            Console.Write("Nhap so nguyen a : ");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine($"a *= 2 = {a *= 2}");
            Console.Write("Nhap so nguyen a : ");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine($"a /= 9 = {a /= 9}");
            b += 7;
            Console.Write("Nhap so nguyen a : ");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine($"a = a - (b+7) = {a -= b}");
        }
    }
}
