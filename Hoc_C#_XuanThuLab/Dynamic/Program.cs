using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dynamic
{
    internal class Program
    {

        class Student
        {
            public string Name { get; set; }

            public void Hello() => Console.WriteLine(Name);
        }
        static void PrintInf(dynamic obj)
        {
            obj.Name = "Dai Phu";
            obj.Hello();
        }
        static void Main(string[] args)
        {
            Student a = new Student();
            PrintInf(a);
        }
    }
}
