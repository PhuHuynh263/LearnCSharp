using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_15._2_vidu_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             Viết chương trình tách số và chữ từ chuỗi nhập vào thành 2 chuỗi : 	
             ví dụ nhập vào : abc123 sẽ tách và in ra thành 2 chuỗi abc và 123
             */
            Console.OutputEncoding = Encoding.UTF8;
            Console.Write("Nhập vào chuỗi bất kỳ : ");
            string str = Console.ReadLine();
            string letterStr = "";
            string numberStr = "";
            char[] lst = str.ToCharArray();
            foreach (char c in lst)
            {
                if (char.IsLetter(c))
                {
                    letterStr += c;
                }
                else if (char.IsDigit(c))
                {
                    numberStr += c;
                }
            }
            Console.WriteLine("Chuỗi số : " + numberStr);
            Console.WriteLine("Chuỗi ký tự : " + letterStr);
        }
    }
}
