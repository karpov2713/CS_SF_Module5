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
            var modif = phrase;
            
            if (modif.Length > 2)
            {
                modif = modif.Remove(0, 2);
            }

            Console.WriteLine($"... {modif}");

            if (deep > 1)
            {
                Echo(modif, deep - 1);
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
