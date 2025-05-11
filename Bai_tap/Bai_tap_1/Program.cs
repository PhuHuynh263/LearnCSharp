using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Bai_tap_1
{
    class Program
    {
        static List<Letters> listLetter = new List<Letters>();
        static List<Goods> listGoods = new List<Goods>();
        static List<Postage> listPostage = new List<Postage>();
        static void Main(string[] args)
        {
            Letters letters1 = new Letters("Da Nang", "Phu", true);
            Letters letters2 = new Letters("Sai Gon", "Quang", false);

            Goods goods1 = new Goods("Da Lat", "Phong", 25);
            Goods goods2 = new Goods("Nha Tang", "Long", 18);

            listLetter.Add(letters1);
            listLetter.Add(letters2);
            listGoods.Add(goods1);
            listGoods.Add(goods2);

            listPostage.Add(letters1);
            listPostage.Add(letters2);
            listPostage.Add(goods1);
            listPostage.Add(goods2);

            Encoding uTF8 = Encoding.UTF8;
            Console.OutputEncoding = uTF8;
            Letters letters = new Letters();
            Goods goods = new Goods();

            MainMenu();
        }

        public static void MainMenu()
        {
            bool isRunning = true;

            while (isRunning)
            {
                Console.Clear();
                Console.WriteLine("=== Menu ===");
                Console.WriteLine("1. Enter Postage Information");
                Console.WriteLine("2. Display Postage Information And Its Cost");
                Console.WriteLine("3. Goods Count.");
                Console.WriteLine("4. Search Letters By Name.");
                Console.WriteLine("5. Sort By Name.");
                Console.WriteLine("6. Total Cost");
                Console.WriteLine("7. Exit");
                Console.Write("Your Choice : ");

                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        EnterPostageItems();
                        break;
                    case 2:
                        DisplayPostageItems();
                        break;
                    case 3:
                        CountGoods();
                        break;
                    case 4:
                        SearchLetterByName();
                        break;
                    case 5:
                        DisplaySortListByName();
                        break;
                    case 6:
                        TotalCost();
                        break;
                    case 7:
                        isRunning = false;
                        Console.WriteLine("Exiting Program...");
                        break;
                    default:
                        Console.WriteLine("Choice is not valid, please try again.");
                        break;
                }

                if (isRunning)
                {
                    Console.WriteLine("Enter any key to continue...");
                    Console.ReadKey();
                }
            }
        }


        static void EnterPostageItems()
        {

            Console.WriteLine("\nEnter your postage information:");

            Console.WriteLine("1.Goods");
            Console.WriteLine("2.Letters");
            Console.Write("Enter your choice : ");
            int type = int.Parse(Console.ReadLine());

            Console.Write("Address: ");
            string address = Console.ReadLine();

            Console.Write("Name: ");
            string receiverName = Console.ReadLine();

            if (type == 1)
            {
                Console.Write("Weight (kg): ");
                double weight = double.Parse(Console.ReadLine());
                Goods goods = new Goods(address, receiverName, weight);
                listGoods.Add(goods);
                listPostage.Add(goods);
                Console.WriteLine("Information is saved.");
            }
            else if (type == 2)
            {
                Console.Write("Letter Type (Fast hay Normal): ");
                string typeLetter = Console.ReadLine().ToLower();
                bool isFast = typeLetter == "fast";

                Letters letter = new Letters(address, receiverName, isFast);
                listLetter.Add(letter);
                listPostage.Add(letter);
                Console.WriteLine("Information is saved.");
            }
            else
            {
                Console.WriteLine("Choice is not valid.");
            }
        }

        static void DisplayPostageItems()
        {
            Console.WriteLine("What postage do you want to see :");
            Console.WriteLine("1.Goods");
            Console.WriteLine("2.Letters");
            Console.WriteLine("3.All");
            Console.Write("Enter your choice : ");
            int type = int.Parse(Console.ReadLine());

            if (type == 1)
            {
                Console.WriteLine("Goods List :");
                foreach (var good in listGoods)
                {
                    double cost = good.CalculateShippingCost();
                    Console.WriteLine(good.ToString());

                }
            }
            else if (type == 2)
            {
                Console.WriteLine("Letter List :");
                foreach (var letter in listLetter)
                {
                    double cost = letter.CalculateShippingCost();
                    Console.WriteLine(letter.ToString());

                }
            }
            else
            {
                Console.WriteLine("Postage List :");
                foreach (var item in listPostage)
                {
                    double cost = item.CalculateShippingCost();
                    Console.WriteLine(item.ToString()); ;

                }
            }
        }

        static void CountGoods()
        {
            int count = listGoods.Count();
            Console.WriteLine("Total goods : " + count);
        }


        static void SearchLetterByName()
        {
            Console.WriteLine("Enter the name do you want to search : ");
            List<string> listNameLetters = new List<string>();
            string nameWantToSearch = Console.ReadLine();
            foreach (var item in listLetter)
            {
                listNameLetters.Add(item.name);
            }

            foreach (var name in listNameLetters)
            {
                if (nameWantToSearch.Contains(name))
                {
                    foreach (var item in listLetter)
                    {
                        if (item.name.Contains(nameWantToSearch))
                        {
                            double cost = item.CalculateShippingCost();
                            Console.WriteLine(item.ToString());
                        }
                    }
                    break;
                }
                else
                {
                    Console.WriteLine("No information found");
                    break;
                }
            }
        }

        static void TotalCost()
        {
            double totalCost = 0;
            List<string> costList = new List<string>();

            foreach (var item in listGoods)
            {
                double cost = item.CalculateShippingCost();
                costList.Add(cost.ToString());
            }
            foreach (var item in listLetter)
            {
                double cost = item.CalculateShippingCost();
                costList.Add(cost.ToString());
            }

            foreach (var item in costList)
            {
                double cost = double.Parse(item.ToString());
                totalCost += cost;
            }
            Console.WriteLine("Total Postage Cost : " + totalCost);
        }

        static void SortByName<T>(List<T> list) where T : Postage
        {
            list.Sort((x, y) => x.name.CompareTo(y.name));
            Console.WriteLine("List sorted by name : ");
            foreach (var item in list)
            {
                Console.WriteLine(item.ToString());
            }

        }

        static void DisplaySortListByName()
        {
            Console.WriteLine("What list do you want to sort :");
            Console.WriteLine("1.Goods");
            Console.WriteLine("2.Letters");
            Console.WriteLine("3.All");
            Console.Write("Enter your choice : ");
            int type = int.Parse(Console.ReadLine());

            if (type == 1)
            {
                SortByName(listGoods);
            }
            else if (type == 2)
            {
                SortByName(listLetter);
            }
            else
            {
                SortByName(listPostage);
            }
        }
    }
}