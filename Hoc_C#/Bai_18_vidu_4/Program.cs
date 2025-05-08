using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_18_vidu_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            //Viết chương trình in ra số lớn thứ 2 và số nhỏ thứ 2 trong list
            // In ra vị trí index của số đó
            /*
             VD: lst={1,2,3,4,5}
             # số lớn thứ 2: 4, vị trí index trong list là 3
             # số nhỏ thứ 2 trong list là 2, vị trí index trong list là 1
             */
            List<int> lst = new List<int>() { 2, 1, 4, 3, 5 };
            Console.Write("Danh sách : ");
            foreach (var item in lst)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
            List<int> lst1 = new List<int>();
            lst1.AddRange(lst);
            lst1.Remove(lst1.Max());
            lst1.Remove(lst1.Min());
            foreach (var item in lst)
            {
                if (item == lst1.Max())
                {
                    Console.WriteLine("Số lớn thứ 2 là : " + item);
                    Console.WriteLine("Vị trí index trong list là : " + lst.IndexOf(item));
                    break;
                }
            }
            foreach (var item in lst)
            {
                if (item == lst1.Min())
                {
                    Console.WriteLine("Số nhỏ thứ 2 là : " + item);
                    Console.WriteLine("Vị trí index trong list là : " + lst.IndexOf(item));
                    break;
                }
            }
        }
    }
}
