using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Bai_19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            //1. Khai báo dictionary
            Dictionary<int, string> dictionary = new Dictionary<int, string>();

            //2. Khai báo dictionary với các phần tử
            Dictionary<int, string> dictionary2 = new Dictionary<int, string>()
            {
                { 1, "Nguyễn Văn A" },
                { 2, "Nguyễn Văn B" },
                { 3, "Nguyễn Văn C" }
            };

            //3. Thêm phần tử vào dictionary
            dictionary.Add(1, "Nguyễn Văn A");
            dictionary.Add(2, "Nguyễn Văn B");
            dictionary.Add(3, "Nguyễn Văn C");
            dictionary.Add(4, "Nguyễn Văn D");
            dictionary.Add(5, "Nguyễn Văn E");
            dictionary.Add(6, "Nguyễn Văn F");

            //4. Duyệt các phần tử trong dictionary
            foreach (KeyValuePair<int, string> item in dictionary)
            {
                Console.WriteLine("Key: " + item.Key + ", Value: " + item.Value);
            }

            //5. containsKey
            if (dictionary.ContainsKey(1))
            {
                Console.WriteLine("Có key 1 trong dictionary");
            }
            else
            {
                Console.WriteLine("Không có key 1 trong dictionary");
            }

            //6. containsValue
            if (dictionary.ContainsValue("Nguyễn Văn A"))
            {
                Console.WriteLine("Có value Nguyễn Văn A trong dictionary");
            }
            else
            {
                Console.WriteLine("Không có value Nguyễn Văn A trong dictionary");
            }

            //7.dictionary.key
            Console.WriteLine("Các key trong dictionary:");
            string name = dictionary[2];
            Console.WriteLine(name);

            //8.dictionary.remove
            dictionary.Remove(1);
            Console.WriteLine("Sau khi xóa key 1:");
            foreach (KeyValuePair<int, string> item in dictionary)
            {
                Console.WriteLine("Key: " + item.Key + ", Value: " + item.Value);
            }

            //9. dictionary.clear
            /* dictionary.Clear();
             Console.WriteLine("Sau khi xóa tất cả các phần tử trong dictionary:");
             foreach (KeyValuePair<int, string> item in dictionary)
             {
                 Console.WriteLine("Key: " + item.Key + ", Value: " + item.Value);
             }*/

            //10. chuyển value thành list
            List<string> list = new List<string>();
            list = dictionary.Values.ToList();
            Console.WriteLine("Các value trong dictionary:");
            foreach (string item in list)
            {
                Console.WriteLine(item);
            }

            //11. chuyển key thành list
            List<int> listKey = new List<int>();
            listKey = dictionary.Keys.ToList();
            Console.WriteLine("Các key trong dictionary:");
            foreach (int item in listKey)
            {
                Console.WriteLine(item);
            }



        }
    }
}
