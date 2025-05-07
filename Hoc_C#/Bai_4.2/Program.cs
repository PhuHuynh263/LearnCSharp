using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_4._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.Write("Moi nhap vao so nguyen n : ");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("Ban vua nhap so {0}", n);
            if (n % 2 == 0)
            {
                Console.WriteLine("{0} la so chan", n);
            }
            else
            {
                Console.WriteLine("{0} la so le", n);
            }
        }
    }
}
