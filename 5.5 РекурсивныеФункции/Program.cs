using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._5_РекурсивныеФункции
{
    internal class Program
    {
        static void Echo(string saidword)
        {
            Console.WriteLine(saidword);
        }

        static void Main(string[] args)
        {
            Console.Write("Напишите что-то: ");

            var str = Console.ReadLine();

            Console.Write("Укажите глубину эха: ");

            var deep = int.Parse(Console.ReadLine());

            for (int i = 0; i < deep; i++)
            {
                Echo(str);
            }
        }
    }
}
