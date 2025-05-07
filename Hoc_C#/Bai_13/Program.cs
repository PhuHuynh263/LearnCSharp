using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int soNgauNhien = random.Next(50, 101);
            Console.WriteLine("So ngau nhien la : " + soNgauNhien);

            double d2 = random.NextDouble();
            Console.WriteLine("So ngau nhien double la : " + d2);
        }
    }
}
