using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_7._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double x, y;
            double tong, hieu;
            Console.Write("Nhap vao tong : ");
            tong = double.Parse(Console.ReadLine());
            Console.Write("Nhap vao hieu : ");
            hieu = double.Parse(Console.ReadLine());
            x = (tong + hieu) / 2;
            y = tong - x;
            Console.WriteLine("X can tim la : {0}", x);
            Console.WriteLine("Y can tim la : {0}", y);
        }
    }
}
