using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_7._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int month;
            Console.Write("Type your month : ");
            month = int.Parse(Console.ReadLine());
            switch (month)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    Console.WriteLine("Month {0} has 31 days", month);
                    break;
                case 2:
                    int year;
                    Console.Write("Moi ban nhap nam : ");
                    year = int.Parse(Console.ReadLine());
                    if ((year % 4 == 0 && year % 100 != 0) || year % 400 == 0)
                    {
                        Console.WriteLine("{0} is a leap year!!!", year);
                        Console.WriteLine("Month {0} has 29 days", month);
                    }
                    else
                    {
                        Console.WriteLine("{0} is not a leap year!!!", year);
                        Console.WriteLine("Month {0} has 28 days", month);
                    }
                    break;
                case 4:
                case 6:
                case 9:
                case 11:
                    Console.WriteLine("Month {0} has 30 days", month);
                    break;
            }
        }
    }
}
