using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Lesson_2._6
{
    class Program
    {
        //Чагалысов
        //Задание 6
        //*Написать программу подсчета количества «хороших» чисел в диапазоне от 1 до 1 000 000 000. 
        //«Хорошим» называется число, которое делится на сумму своих цифр.
        //Реализовать подсчёт времени выполнения программы, используя структуру DateTime.
        #region Метод подсчета количества цифр числа

        /// <summary>
        /// Возвращает сумму цифр, заданного числа.
        /// </summary>
        /// <param name="number">Число</param>
        static int SumNumber(int number)
        {
            int sum = 0;
            while (number > 0)
            {
                sum += number % 10;
                number /= 10;
            }
            return sum;
        }
        #endregion

        static void Main(string[] args)
        {
            DateTime start = DateTime.Now;
            Thread.Sleep(20);
            int goodNumber = 0;
            int countNumber = 0;
            for (int i = 1; i <= 1000_000_000; i++)
            {
                goodNumber = i % SumNumber(i);
                if (goodNumber == 0) { countNumber++; }
            }
            DateTime finish = DateTime.Now;
            Console.WriteLine($"Количество «хороших» чисел = {countNumber}");
            Console.WriteLine($"Время выполнения программы: {(finish - start)}");
            Console.ReadKey();
        }
    }
}
