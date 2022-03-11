using System;

namespace BPA_Task_03
{
    class Program
    {
        static void Main(string[] args)
        {
            string correctPassword = "password1";
            for (int i = 0; i < 3; i++)
            {
                Console.Write("Введите пароль: ");
                string inputPassword = Console.ReadLine();
                if (inputPassword == correctPassword)
                {
                    Console.WriteLine("Введен правильный пароль! " + correctPassword);
                    break;
                }
                else
                {
                    Console.WriteLine("Введен неправильный пароль, попробуйте еще раз");
                }
            }
        }
    }
}
