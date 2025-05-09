using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_1_Method
{
    internal class Program
    {
        public static int tich(int a, int b)
        {
            return a * b;
        }
        static void Main(string[] args)
        {
            xinchao();
            int c = tich(3, 4);
            Console.WriteLine(c);
            int d = Bai_1_Method.tinhToan.tong(2, 3);
            Console.WriteLine(d);
        }

        static void xinchao()
        {
            Console.WriteLine("Xin chào !!!");
        }
    }
}
