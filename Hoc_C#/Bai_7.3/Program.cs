using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_7._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int year;
            Console.Write("Moi ban nhap nam : ");
            year = int.Parse(Console.ReadLine());
            if ((year % 4 == 0 && year % 100 != 0) || year % 400 == 0)
            {
                Console.WriteLine("{0} is Leap year!!!", year);
            }
            else
            {
                Console.WriteLine("{0} is not Leap year!!!", year);
            }
        }
    }
}
