using System;
using System.Linq;

namespace BPA_Task_06
{
    class Program
    {
        public static void ResizeMassString(ref string[] array, int newSize)
        {
            string[] newArray = new string[newSize];

            for (int i = 0; i < array.Length && i < newArray.Length; i++)
            {
                newArray[i] = array[i];
            }
            array = newArray;
        }

        public static void ResizeMassInt(ref int[] array, int newSize)
        {
            int[] newArray = new int[newSize];

            for (int i = 0; i < array.Length && i < newArray.Length; i++)
            {
                newArray[i] = array[i];
            }
            array = newArray;
        }

        public static void RemoveAtString(ref string[] array, int index)
        {
            string[] newArray = new string[array.Length - 1];

            for (int i = 0; i < index; i++)
                newArray[i] = array[i];

            for (int i = index + 1; i < array.Length; i++)
                newArray[i - 1] = array[i];

            array = newArray;
        }

        public static void RemoveAtInt(ref int[] array, int index)
        {
            int[] newArray = new int[array.Length - 1];

            for (int i = 0; i < index; i++)
                newArray[i] = array[i];

            for (int i = index + 1; i < array.Length; i++)
                newArray[i - 1] = array[i];

            array = newArray;
        }

        public static void Main(string[] args)
        {
            string[] dosieArr = new string[2];
            string[] posArr = new string[2];
            int[] countArr = new int[2];
            string commandInput, name, lastname, otch;
            countArr[0] = 1;

            int j = 0;
            int i = 1;
            int newLength = 2;
            while (true)
            {
                Console.WriteLine("Отдел кадров\n1 - добавить досье\n2 - вывести все досье\n3 - удалить досье\n4 - поиск по фамилии\n5 - выход из программы" + "\n");
                Console.Write("Выберите пункт меню: ");
                commandInput = Console.ReadLine();

                if (commandInput == "1")
                {
                    ResizeMassString(ref dosieArr, newLength + 1);
                    ResizeMassString(ref posArr, newLength + 1);
                    ResizeMassInt(ref countArr, newLength + 1);

                    Console.Write("Добавление досье\n" + "\n" + "Введите имя: ");
                    name = Console.ReadLine();
                    Console.Write("Введите фамилию: ");
                    lastname = Console.ReadLine();
                    Console.Write("Введите отчество: ");
                    otch = Console.ReadLine();
                    Console.Write("Введите должность: ");
                    posArr[j] = Console.ReadLine();

                    dosieArr[j] = $"{name} {lastname} {otch}";
                    countArr[j] = i++;
                    j++;

                    Console.WriteLine("\n" + "Данные занесены успешно!!!\n" + "\n" + "Нажмите любую клавишу...");
                    Console.ReadKey();
                    Console.Clear();
                    continue;
                }
                else if (commandInput == "2")
                {
                    if (j != 0 || dosieArr[0] != null)
                        for (int b = 0; b < j; b++)
                        {
                            Console.WriteLine("{0}) {1} - {2}", countArr[b], dosieArr[b], posArr[b]);
                        }
                    else
                        Console.WriteLine("Досье не найдено \n" + "\n" + "Нажмите любую клавишу...");
                    Console.ReadKey();
                    Console.Clear();
                    continue;
                }
                else if (commandInput == "3")
                {
                    Console.Write("Введите номер досье для удаления: ");
                    int deleteNum = int.Parse(Console.ReadLine());

                    RemoveAtString(ref dosieArr, deleteNum);
                    RemoveAtString(ref posArr, deleteNum);
                    RemoveAtInt(ref countArr, deleteNum);

                    Console.WriteLine("Досье успешно удалено!!!\n" + "\n" + "Нажмите любую клавишу...");
                    Console.ReadKey();
                    Console.Clear();
                    continue;
                }
                else if (commandInput == "4")
                {
                    Console.WriteLine("Введите фамилию: ");
                    string search = Console.ReadLine();
                    for (int fam = 0; fam <= j; fam++)
                    {
                        Console.WriteLine("Человек с такой фамилией " + search + (dosieArr[fam].Split(' ').Select(x => x == search).Count() > 0 ? " существует" : " не существует" + " в досье"));
                    }
                    Console.WriteLine("Нажмите любую клавишу...");
                    Console.ReadKey();
                    Console.Clear();
                    continue;
                }
                else if (commandInput == "5")
                {
                    Environment.Exit(0);
                    break;
                }
            }
            Console.ReadKey();
        }
        
    }
    
}
