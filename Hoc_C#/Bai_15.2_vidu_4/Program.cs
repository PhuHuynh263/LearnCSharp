using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_15._2_vidu_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             Cho chuỗi : 
                a= “
                tôi chăm học
                tôi chịu khó
                tôi đẹp zai
                “
                đếm từ tôi trong string a trên
            */
            Console.OutputEncoding = Encoding.UTF8;
            string str1 = "tôi chăm học tôi chịu khó tôi đẹp zai";
            string[] arr = str1.Split(' ');
            int count = 0;
            foreach (string x in arr)
            {
                if (x.Equals("tôi"))
                {
                    count++;
                }
            }
            Console.WriteLine(str1);
            Console.WriteLine("Số từ tôi : " + count);
        }
    }
}
