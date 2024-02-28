using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_4_FieldOfView
{
    internal class Program
    {
        static int num1 = 667; // Переменная контекста класса

        static int Sum()
        {
            var num2 = 1;
            return num2 + num1;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(num1);
            Console.WriteLine(Sum());

            if (num1 > 0)
            {
                var num3 = 5;
                Console.WriteLine(num1 + num3);
            }
        }
    }
}
