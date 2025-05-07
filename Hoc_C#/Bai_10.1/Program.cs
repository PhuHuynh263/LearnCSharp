using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_10._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.Write("Enter n from 1 to 99 : ");
            n = int.Parse(Console.ReadLine());
            while (n < 1 || n > 99)
            {
                Console.Write("Enter n again : ");
                n = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("N = " + n);
        }
    }
}
