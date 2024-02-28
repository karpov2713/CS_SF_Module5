using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    internal class Program
    {
        static void ShowColor()
        {
            Console.WriteLine("Напишите свой любимый цвет на английском с маленькой буквы: ");
            switch (Console.ReadLine())
            {
                case "red":
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.ForegroundColor = ConsoleColor.Green;

                    Console.WriteLine("Your color is red!");
                    break;

                case "green":
                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.ForegroundColor = ConsoleColor.White;

                    Console.WriteLine("Your color is green!");
                    break;

                case "cyan":
                    Console.BackgroundColor = ConsoleColor.Cyan;
                    Console.ForegroundColor = ConsoleColor.Red;

                    Console.WriteLine("Your color is cyan!");
                    break;

                case "yellow":
                    Console.BackgroundColor = ConsoleColor.Yellow;
                    Console.ForegroundColor = ConsoleColor.Cyan;

                    Console.WriteLine("Your color is yellow!");
                    break;

                default:

                    Console.WriteLine("Введите свой любимый цвет!: ");
                    break;
            }
        }

        static void Main(string[] args)
        {
            /*(string Name, string[] Dishes) User;

            Console.WriteLine("Введите имя пользователя: ");
            User.Name = Console.ReadLine();

            User.Dishes = new string[5];
            for (int i = 0; i < User.Dishes.Length; i++)
            {
                Console.WriteLine("Введите любимое блюдо номер {0}", i + 1);
                User.Dishes[i] = Console.ReadLine();
            }*/

            // 5.1. Методы

        }
    }
}
