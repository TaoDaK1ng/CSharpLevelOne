using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_2._4
{
    class Program
    {
        //Чагалысов
        //Задание 4
        //Реализовать метод проверки логина и пароля.
        //На вход метода подается логин и пароль. 
        //На выходе истина, если прошел авторизацию, и ложь, если не прошел (Логин: root, Password: GeekBrains).
        //Используя метод проверки логина и пароля, написать программу: пользователь вводит логин и пароль,
        //программа пропускает его дальше или не пропускает.
        //С помощью цикла do while ограничить ввод пароля тремя попытками.

        #region Метод проверки логина и пароля

        /// <summary>
        /// Проверяет логин и пароль на совпадение
        /// </summary>
        /// <param name="login">Логин</param>
        /// <param name="password">Пароль</param>
        /// <returns></returns>
        static bool Authorization(string login, string password)
        {
            if (login == "root" && password == "GeekBrains") { return true; }
            else { return false; }
        }
        #endregion

        static void Main(string[] args)
        {
            string login, password;
            int tryCount = 0;
            do
            {
                Console.WriteLine("Введите логин:");
                login = Console.ReadLine();
                Console.WriteLine("Введите пароль:");
                password = Console.ReadLine();
                if (Authorization(login, password))
                {
                    Console.WriteLine("Подключено");
                    break;
                }
                else 
                {
                    Console.WriteLine($"Вы ввели неправильный логин или пароль!\nКоличество оставшихся попыток: {3-(tryCount + 1)}");   
                    tryCount++;
                }
            } while (tryCount < 3);
            Console.ReadKey();   
        }
    }
}
