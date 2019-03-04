using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Lesson_4._4
{
    //Задача 4
    //Чагалысов
    //Решить задачу с логинами из урока 2, только логины и пароли считать из файла в массив.Создайте структуру Account, содержащую Login и Password.

    struct Account
    {
        public string login;
        public string password;

        public string[] ArrayFile()
        {
            string[] accountData;
            try
            {
                return accountData = File.ReadAllLines("C:/array.txt");
            }
            catch
            {
                Console.WriteLine("Файл не найден");
                return accountData = new string[0];
            }
        }

        public bool Authorization()
        {
            bool flag = false;
            int count = 0;
            string[] accountData = ArrayFile();
            for (int i = 0; i < accountData.Length; i++)
            {
                if (accountData[i] == this.login) { count++; }
                else if (accountData[i] == this.password) { count++; } 
            }
            if (count == 2) { flag = true; }
            return flag;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Account account;
            account.login = "root";
            account.password = "GeekBrains";
                if (account.Authorization())
                {
                    Console.WriteLine("Подключено");
                }
                else
                {
                    Console.WriteLine($"Совпадений не найдено!");
                }
            Console.ReadKey();
        }
    }
}
