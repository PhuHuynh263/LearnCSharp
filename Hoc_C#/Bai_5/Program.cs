using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double r;
            const double PI = 3.14;
            Console.Write("Nhap ban kinh duong tron r : ");
            r = int.Parse(Console.ReadLine());
            double C = 2 * r * PI;
            double S = r * r * PI;

            Console.WriteLine("Chu vi hinh tron co ban kinh r = {0} la : {1}", r, C);
            Console.WriteLine("Dien tich hinh tron co ban kinh r = {0} la : {1}", r, S);
        }
    }
}
