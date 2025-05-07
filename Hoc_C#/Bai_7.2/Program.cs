using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_7._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float dtb;
            Console.Write("Moi ban nhap diem trung binh : ");
            dtb = float.Parse(Console.ReadLine());
            if (dtb >= 8)
            {
                Console.WriteLine("Ban xep loai gioi!!!");

            }
            else if (dtb >= 6.5 && dtb < 8)
            {
                Console.WriteLine("Ban xep loai kha!!!");
            }
            else if (dtb >= 5 && dtb < 6.5)
            {
                Console.WriteLine("Ban xep loai trung binh!!!");
            }
            else
            {
                Console.WriteLine("Ban xep loai yeu!!!");
            }
        }
    }
}
