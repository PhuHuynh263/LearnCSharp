using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_15._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            //1.Khai báo chuỗi
            string chuoi = "Gà lại lập trình";
            Console.WriteLine("Chuỗi bạn vừa nhập là : " + chuoi);

            //2. Khai báo nguyên văn @
            string chuoi2 = @"D:\IntelliJ Java\IntelliJ IDEA Community Edition 2022.3";
            string chuoi3 = "D:\\galailaptrinh";
            string chuoi4 = "Có người nói rằng : \" abc \" ";
            string chuoi5 = "Có người nói rằng :\n \" abc \" ";
            Console.WriteLine(chuoi2);
            Console.WriteLine(chuoi3);
            Console.WriteLine(chuoi4);
            Console.WriteLine(chuoi5);

            //3. Chuyển đổi chuỗi
            int i = 123123;
            string chuoi6 = i.ToString();
            string chuoi7 = i + "";
            string chuoi8 = Convert.ToString(i);
            Console.WriteLine(chuoi6);
            Console.WriteLine(chuoi7);
            Console.WriteLine(chuoi8);

            //4. Tách chuỗi ra thành các ký tự lẻ
            string chuoi9 = "XinChao";
            char[] lst = chuoi9.ToCharArray();
            Console.WriteLine(lst);

            //5. Lenght
            string chuoi10 = "Test haha";
            int j = chuoi10.Length;
            Console.WriteLine(j);
            Console.WriteLine("Ký tự thứ 2 của chuỗi là : " + chuoi10[1]);

            //


        }
    }
}
