using System;

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// взял здесь:
// http://professorweb.ru/my/csharp/charp_theory/level10/10_6.php
namespace Lambda
{
    // Создадим несколько делегатов имитирующих
    // простейшую форму регистрации
    delegate int LenghtLogin(string s);
    delegate bool BoolPassword(string s1, string s2);
    delegate void Captha(string s1, string s2);

    class Program
    {
        private static void SetLogin()
        {
            Console.Write("Введите логин: ");
            string login = Console.ReadLine();

            // Используем лямбда-выражение
            LenghtLogin lenghtLoginDelegate = s => s.Length;

            int lengthLogin = lenghtLoginDelegate(login);
            if (lengthLogin > 25)
            {
                Console.WriteLine("Слишком длинное имя\n");

                // Рекурсия на этот же метод, чтобы вывести заново логин
                SetLogin();
            }
        }
        static void Main(string[] args)
        {
            SetLogin();

            Console.Write("Введите пароль: ");
            string password1 = Console.ReadLine();
            Console.Write("Повторите пароль: ");
            string password2 = Console.ReadLine();

            // Используем лямбда выражение
            BoolPassword bp = (s1, s2) => s1 == s2;

            if (bp(password1, password2))
            {
                Random ran = new Random();
                string resCaptha = "";
                for (int i = 0; i < 10; i++)
                    resCaptha += (char)ran.Next(0, 100);
                Console.WriteLine("Введите код xD: " + resCaptha);
                string resCode = Console.ReadLine();

                // Реализуем блочное лямбда-выражение
                Captha cp = (s1, s2) =>
                {
                    if (s1 == s2)
                        Console.WriteLine("Регистрация удалась!");
                    else Console.WriteLine("Не переживай, в следующий раз получится :)");
                    return;
                };
                cp(resCaptha, resCode);
            }
            else 
                Console.WriteLine("Регистрация провалилась. Пароли не совпадают");

            Console.ReadLine();
        }
    }
}
