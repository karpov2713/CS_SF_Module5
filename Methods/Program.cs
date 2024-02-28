using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    internal class Program
    {
        static string ShowColor(string username, int userage, params string[] favcolors)
        {
            Console.WriteLine($"{username} - {userage}, \nнапишите свой любимый цвет на английском с маленькой буквы: ");
            string color = Console.ReadLine();

            switch (color)
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

            return color;
        }

        static string GetDataFromConsole() // Просто возвращаем данные введенные в консоль.
        {
            return Console.ReadLine();
        }

        static string GetDataFromConsole_ShortForm() => Console.ReadLine(); // Сокращенный вариант записи предыдущего метода.

        static int[] GetArrayFromConsole()
        {
            int[] result = new int[5];

            // Инициируем массив данными из цикла.
            for (int i = 0; i < result.Length; i++)
            {
                Console.WriteLine("Введите элемент массива номер {0}", i + 1);
                result[i] = int.Parse(Console.ReadLine());
            }

            return result;
        }

        // Упорядочиваем массив по возрастанию
        static int[] SortArray(int[] result)
        {
            int temp = 0;
            for (int i = 0; i < result.Length; i++)
            {
                for (int j = i + 1; j < result.Length; j++)
                {
                    if (result[i] > result[j])
                    {
                        temp = result[i];
                        result[i] = result[j];
                        result[j] = temp;
                    }
                }
            }

            // Выводим упорядоченный массив в консоль
            for (int i = 0; i < result.Length; i++)
            {
                Console.WriteLine(result[i]);
            }

            return result;
        }

        // К разделу 5.3. Передача параметров
        static void GetName(out string name)
        {
            Console.WriteLine("Введите имя: ");
            name = Console.ReadLine();
            Console.WriteLine(name);
        }

        static void GetAge(int age)
        {
            Console.Write("Введите ваш возраст: ");
            age = int.Parse(Console.ReadLine());
            Console.WriteLine(age);
        }

        static void BigDataOperation(int[] arr)
        {
            arr[0] = 4;
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
            /*var (name, age) = ("Дмитрий", 54);

            string[] favcolors = new string[3];

            for (int i = 0; i < favcolors.Length; i++)
            {
                favcolors[i] = ShowColor(name, age);
            }

            Console.WriteLine("Выши любимые цвета: ");
            foreach (var color in favcolors)
            {
                Console.WriteLine(color);
            }*/

            // Инициализация массива с помощью метода GetArrayFromConsole()
            // int[] array = GetArrayFromConsole(); 

            // 5.2. Параметры методов см. ShowColor с параметрами (выше).
            // SortArray(GetArrayFromConsole());

            // 5.3. Передача параметров
            /*string name = "Дмитрий";
            GetName(out name); // ref - передача по ссылке, метод изменяет значение переменной
            Console.WriteLine(name);*/

            /*int age = 54;
            GetAge(age);
            Console.WriteLine(age);*/

            /*var arr = new int[] { 1, 2, 3 };
            BigDataOperation(arr);

            Console.WriteLine(arr[0]);*/


        }
    }
}
