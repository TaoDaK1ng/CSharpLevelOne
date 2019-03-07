using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Lesson_5
{
    class Program
    {
        //Задание 1
        //Чагалысов
        //Создать программу, которая будет проверять корректность ввода логина.
        //Корректным логином будет строка от 2 до 10 символов, содержащая только буквы латинского алфавита или цифры,
        //при этом цифра не может быть первой:
        //а) без использования регулярных выражений;
        //б) **с использованием регулярных выражений.
        /// <summary>
        /// Проверяет на корректность логин, без использования регулярного выражения
        /// </summary>
        static void WithoutRegular()
        {
            bool flag = false;
            Console.WriteLine("Введите логин:");
            string login;
            do
            {
                login = Console.ReadLine();
                if (login.Length > 10 || login.Length < 2) { flag = true; }
                else if (char.IsDigit(login[0])) { flag = true; }
                else { flag = false; }
                for (int i = 0; i < login.Length; i++)
                {
                    if (!char.IsLetterOrDigit(login[i]))
                    {
                        flag = true;
                        break;
                    }
                    else if (login[i] >= 'а' && login[i] <= 'я' || login[i] >= 'А' && login[i] <= 'Я')
                    {
                        flag = true;
                        break;
                    }
                }
                if (flag)
                {
                    Console.WriteLine("Логин не корректен!");
                }
            } while (flag);
        }

        /// <summary>
        /// Проверяет на корректность логин, с использованием регулярного выражения
        /// </summary>
        static void Regular()
        {
            Console.WriteLine("Введите логин:");
            string login;
            while (true)
            {
                login = Console.ReadLine();
                Regex format = new Regex(@"^[a-zA-Z][a-zA-Z0-9]{1,9}$");
                if (!format.IsMatch(login)) { Console.WriteLine("Логин не корректен!"); }
                else { break; }
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Без использования регулярных выражений");
            WithoutRegular();
            Console.WriteLine("С использованием регулярных выражений");
            Regular();
            Console.ReadKey();
        }
    }
}
