using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            //1.Mảng 2 chiều
            int[,] arr = new int[3, 5];
            //2.Khởi tạo và gán giá trị cho mảng
            int[,] arr1 = new int[2, 3] { { 1, 2, 3 }, { 4, 5, 6 } };
            //3.Nhập mảng
            int[,] arr2 = new int[2, 3];
            Random rd = new Random();
            for (int i = 0; i < arr2.GetLength(0); i++)
            {
                for (int j = 0; j < arr2.GetLength(1); j++)
                {
                    arr2[i, j] = rd.Next(1, 10);
                }
            }
            //4.In mảng
            Console.WriteLine("Mảng 2 chiều:");
            for (int i = 0; i < arr2.GetLength(0); i++)
            {
                for (int j = 0; j < arr2.GetLength(1); j++)
                {
                    Console.Write(arr2[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}
