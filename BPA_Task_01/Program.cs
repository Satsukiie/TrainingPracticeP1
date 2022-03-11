using System;

namespace BPA_Task_01
{
    class Program
    {
            const int gemPrice = 360;
            static void Main(string[] args)
            {
                Console.WriteLine("Программа покупки Кристаллов за золото");
                Console.Write("Введите количество З О Л О Т А (Gold): ");
                string input = Console.ReadLine();
                int amount = Convert.ToInt32(input);
                Console.WriteLine("Курс обмены золота на кристаллы: 360 : 1");

                Console.Write("Введите количество золота для обмена: ");
                string inputTrade = Console.ReadLine();
                int goldTrade = Convert.ToInt32(inputTrade);

                if (amount >= goldTrade)
                {
                    int n, j, r;
                    n = goldTrade % gemPrice;
                    j = goldTrade / gemPrice;

                    r = amount - goldTrade;
                    n = n + r;
                    Console.WriteLine("Осталось золота: {0}", n);
                    Console.WriteLine("Куплено кристаллов: {0}", j);
                }
                else
                {
                    Console.WriteLine("Недостаточно золота. Текущий баланс: {0}", amount);
                }
                Console.ReadKey();
            }
        }
    }
