using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_6
{
    //Чагалысов
    //Задание 1
    //Изменить программу вывода таблицы функциивывода таблицы функции так,
    //чтобы можно было передавать функции типа double (double, double).
    //Продемонстрировать работу на функции с функцией a* x^2 и функцией a* sin(x).

    public delegate double Fun(double x, double a);

    class Program
    {
        // Создаем метод, который принимает делегат
        // На практике этот метод сможет принимать любой метод
        // с такой же сигнатурой, как у делегата
        public static void Table(Fun F, double x, double a, double b)
        {
            Console.WriteLine("----- X ----- Y -----");
            while (x <= b)
            {
                Console.WriteLine("| {0,8:0.000} | {1,8:0.000} |", x, F(x,a));
                x += 1;
            }
            Console.WriteLine("---------------------");
        }
        // Создаем метод для передачи его в качестве параметра в Table

        /// <summary>
        /// Возвращает результат функции: f(a,x) = a * x^2
        /// </summary>
        /// <param name="x">Число подставляемое в функцию вместо x</param>
        /// <param name="a">Число подставляемое в функцию вместо а</param>
        /// <returns>Результат функции, после подстановки</returns>
        public static double MyFuncPow(double x, double a)
        {
            return a * Math.Pow(x,2);
        }
        /// <summary>
        /// Возвращает результат функции: f(a,x) = a * sin(x)
        /// </summary>
        /// <param name="x">Число подставляемое в функцию вместо x</param>
        /// <param name="a">Число подставляемое в функцию вместо а</param>
        /// <returns>Результат функции, после подстановки</returns>
        public static double MyFuncSin(double x, double a)
        {
            return a * Math.Sin(x);
        }

        static void Main()
        {          
            Console.WriteLine("Таблица функции a * x^2:");
            Table(MyFuncPow, -6, 2, 2);      
            Console.WriteLine("Таблица функции a*sin(x):");
            Table(MyFuncSin, -6, 2, 2);
            Console.ReadKey();
        }
    }
}
