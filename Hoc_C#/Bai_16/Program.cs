using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            //1. Khai báo mảng
            int[] stt;
            char[] ch;
            string[] str;

            //2. Khởi tạo mảng
            stt = new int[5];
            ch = new char[5];
            str = new string[5];

            //3. Gán giá trị cho mảng
            int[] mang2 = new int[5] { 1, 2, 3, 4, 5 };

            //4.Khởi tạo mảng ngẫu nhiên
            Random rd = new Random();
            int[] mangNgauNhien = new int[10];
            for (int i = 0; i < mangNgauNhien.Length; i++)
            {
                mangNgauNhien[i] = rd.Next(1, 100);
            }

            foreach (int item in mangNgauNhien)
            {
                Console.Write(item + " ");
            }

            //7. Lenght
            int lenght = mangNgauNhien.Length;
            Console.WriteLine("\n" + lenght);

            //8. Truy xuất qua index
            int[] mang4 = new int[5] { 1, 2, 3, 4, 5 };
            Console.WriteLine(mang4[0]);
            Console.WriteLine(mang4[1]);
            Console.WriteLine(mang4[2]);

            //9. Thay đổi giá trị tại index
            int[] mang5 = new int[5] { 1, 2, 3, 4, 5 };
            mang5[0] = 10;
            Console.Write("Mảng 5 sau thay đổi : ");
            foreach (int item in mang5)
            {
                Console.Write(item + " ");
            }

            //10. Duyệt mảng
            int[] mang6 = new int[5] { 1, 2, 3, 4, 5 };
            Console.Write("Mảng 6 : ");
            for (int i = 0; i < mang6.Length; i++)
            {
                Console.Write(mang6[i] + " ");
            }

            //11. Gán mảng : Gán mảng mới = mảng cũ 
            int[] mang7 = new int[5] { 1, 2, 3, 4, 5 };
            int[] mang8 = mang7;
            mang8[0] = 10;
            Console.WriteLine();
            Console.WriteLine("Mảng 7 sau đổi : " + mang7[0]);
            Console.WriteLine("Mảng 8 sau đổi : " + mang8[0]);

            //13. CopyTo
            int[] mang9 = { 1, 2, 3, 4, 5 };
            int[] mang10 = { 6, 7, 8, 9, 10, 11, 12, 13, 14 };
            mang9.CopyTo(mang10, 2);
            Console.Write("Mảng 9 : ");
            foreach (int item in mang10)
            {
                Console.Write(item + " ");
            }

            //14.Copy
            int[] mang11 = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int[] mang12 = new int[5];
            Array.Copy(mang11, mang12, 5);
            Console.WriteLine();
            Console.Write("Mảng 11 : ");
            foreach (int item in mang12)
            {
                Console.Write(item + " ");
            }

            //16. Clone
            int[] mang13 = { 1, 2, 3, 4, 5 };
            int[] mang14 = (int[])mang13.Clone();
            Console.WriteLine();
            foreach (int item in mang14)
            {
                Console.Write(item + " ");
            }

            //17. Reverse
            int[] mang15 = { 1, 2, 3, 4, 5 };
            Array.Reverse(mang15);
            Console.WriteLine();
            Console.Write("Mảng 15 sau khi đảo ngược : ");
            foreach (int item in mang15)
            {
                Console.Write(item + " ");
            }

            //18. Sort
            int[] mang16 = { 5, 4, 3, 2, 1 };
            Array.Sort(mang16);
            Console.WriteLine();
            Console.Write("Mảng 16 sau khi sắp xếp : ");
            foreach (int item in mang16)
            {
                Console.Write(item + " ");
            }


        }
    }
}
