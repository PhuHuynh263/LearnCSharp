using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_15._2_vidu_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             Viết chương trình kiểm tra tính hợp lệ của mật khẩu: aaaaaAAAAAA1
            mật khẩu hợp lệ khi: 
            có ít nhất 6 ký tự 
            chứa ít nhất 1 chữ cái ( chữ cái thường hoặc hoa đều được) 
            chứa ít nhất 1 chữ số 
            cho người dùng nhập vào mật khẩu để login / so sánh, 
            nếu đúng mở của, sai quá 5 lần khóa đăng nhập, thoát chương trình
             */
            Console.Write("Enter your password : ");
            string password = Console.ReadLine();
            bool check = true;
            int countNumber = 0;
            int countLetter = 0;
            while (check)
            {
                foreach (char c in password)
                {
                    if (char.IsDigit(c))
                    {
                        countNumber++;
                    }
                    else if (char.IsLetter(c))
                    {
                        countLetter++;
                    }
                }
                if (password.Length >= 6 && countNumber >= 1 && countLetter >= 1)
                {
                    Console.WriteLine("Password is valid");
                    check = false;
                }
                else
                {
                    Console.WriteLine("Password is invalid");
                    Console.Write("Enter your password again : ");
                    password = Console.ReadLine();
                    countNumber = 0;
                    countLetter = 0;
                }
            }
            Console.WriteLine("Your password is : " + password);
            string login = "";
            int countLogin = 0;
            Console.Write("Login your password : ");
            login = Console.ReadLine();
            while (true)
            {
                if (login.Equals(password))
                {
                    Console.WriteLine("Login successfully");
                    break;
                }
                else
                {
                    Console.WriteLine("Login failed");
                    Console.Write("Enter your password again : ");
                    login = Console.ReadLine();
                    countLogin++;
                    if (countLogin >= 5)
                    {
                        Console.WriteLine("You have entered the wrong password 5 times, please try again later");
                        break;
                    }
                }
            }

        }
    }
}
