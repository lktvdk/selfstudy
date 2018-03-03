using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Пример использования необязательных аргументов
// и именованных аргументов
// взят отсюда
// http://professorweb.ru/my/csharp/charp_theory/level5/5_10.php


namespace OptionalArguments
{
    class Program
    {
        // Аргументы b и c указывать при вызове необязательно
        static int mySum(int a, int b = 5, int c = 10)
        {
            return a + b + c;
        }

        static void Main(string[] args)
        {
            int sum1 = mySum(3);
            int sum2 = mySum(3, 12);
            //использование именованных аргументов
            int sum3 = mySum(a: 3, b: 10);

            Console.WriteLine("Sum1 = " + sum1);
            Console.WriteLine("Sum2 = " + sum2);
            Console.WriteLine("Sum3 = " + sum2);

            Console.ReadLine();
        }
    }
}
 