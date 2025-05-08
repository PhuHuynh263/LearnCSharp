using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_16_vidu_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.Write("Nhập số phần tử của mảng : ");
            int n = int.Parse(Console.ReadLine());
            int[] mang = new int[n];
            Random rd = new Random();
            for (int i = 0; i < n; i++)
            {
                mang[i] = rd.Next(1, 100);
            }
            Console.Write("Mảng ngẫu nhiên : ");
            foreach (int item in mang)
            {
                Console.Write(item + " ");
            }
            int[] mang2 = mang.Reverse().ToArray();
            Console.Write("\nMảng đảo ngược : ");
            foreach (int item in mang2)
            {
                Console.Write(item + " ");
            }
            Array.Sort(mang2);
            Console.Write("\nMảng sau khi sắp xếp : ");
            foreach (int item in mang2)
            {
                Console.Write(item + " ");
            }
            int tong = 0;
            foreach (int item in mang2)
            {
                tong += item;
            }
            Console.WriteLine("\nTổng các phần tử trong mảng : " + tong);
            Console.Write("Nhập số bạn muốn tìm kiếm : ");
            int yourNumber = int.Parse(Console.ReadLine());
            int index = 0;
            foreach (var item in mang2)
            {
                if (item == yourNumber)
                {
                    index = Array.IndexOf(mang2, item);
                    Console.WriteLine("Số bạn tìm kiếm có tại vị trí thứ " + index);
                    break;
                }
                else
                {
                    Console.WriteLine("Số bạn tìm kiếm không có trong mảng");
                    break;
                }
            }

            Console.ReadKey();
        }
    }
}
