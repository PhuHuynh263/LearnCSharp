using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_15._2_vidu_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             Viết chương trình chuyển tin nhắn sang mật mã theo bảng : 	
            #a="abcdefghijklmnopqrstuvwxyz"   
	        #b="zxcvbnmasdfghjklqwertyuiop“
            */
            string str1 = "abcdefghijklmnopqrstuvwxyz";
            string str2 = "zxcvbnmasdfghjklqwertyuiop";
            Console.Write("Enter your code string : ");
            string codeStr = Console.ReadLine();
            string prizeCodeStr = "";
            char[] lst = codeStr.ToCharArray();
            foreach (char c in lst)
            {
                int indexChar = str1.IndexOf(c);
                prizeCodeStr += str2[indexChar];
            }
            Console.WriteLine("Prize your code string : " + prizeCodeStr);
        }
    }
}
