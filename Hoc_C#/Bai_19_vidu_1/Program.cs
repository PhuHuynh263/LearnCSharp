using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_19_vidu_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Dictionary<string, string> dic = new Dictionary<string, string>();
            dic.Add("daiphu66", "123456");
            dic.Add("daiphu76", "123123");
            dic.Add("daiphu86", "123789");
            dic.Add("daiphu96", "123654");
            dic.Add("daiphu106", "123321");

            foreach (KeyValuePair<string, string> item in dic)
            {
                Console.WriteLine("Tài khoản: " + item.Key + ", Mật khẩu: " + item.Value);
            }

            Console.Write("Tài khoản : ");
            string user = Console.ReadLine();
            Console.Write("Mật khẩu : ");
            string pass = Console.ReadLine();
            if (dic.ContainsKey(user))
            {
                if (dic[user] == pass)
                {
                    Console.WriteLine("Đăng nhập thành công");
                }
                else
                {
                    Console.WriteLine("Sai mật khẩu");
                }
            }
            else
            {
                Console.WriteLine("Tài khoản không tồn tại");
            }
        }
    }
}
