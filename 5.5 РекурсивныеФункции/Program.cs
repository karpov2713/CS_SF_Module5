using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._5_РекурсивныеФункции
{
    internal class Program
    {
        static void Echo(string phrase, int deep)
        {
            Console.WriteLine(phrase);

            if (deep > 1)
            {
                Echo(phrase, deep - 1);
            }
        }

        static void Main(string[] args)
        {
            Console.Write("Напишите что-то: ");

            var str = Console.ReadLine();

            Console.Write("Укажите глубину эха: ");

            var deep = int.Parse(Console.ReadLine());

            Echo(str, deep);
        }
    }
}
