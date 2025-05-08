using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_18_vidu_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            List<int> ds = new List<int>() { 10, 12, 3, 4, 2, 99, 18 };
            List<int> ds1 = new List<int>();
            for (int i = 0; i < ds.Count; i++)
            {
                ds1.Add((int)Math.Pow(ds[i], 2));
            }
            foreach (var item in ds1)
            {
                Console.Write(item + " ");
            }
            int count = 0;
            for (int i = 0; i < ds1.Count; i++)
            {
                if (ds1[i] > 50)
                {
                    count++;
                }
            }
            Console.WriteLine("Số phần tử lớn hơn 50 : " + count);
        }
    }
}
