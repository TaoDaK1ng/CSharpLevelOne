using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Lesson_2._2
{
    class Program
    {
        //Чагалысов
        //Задание 2
        //Написать метод подсчета количества цифр числа.
        #region Метод подсчета количества цифр числа

        /// <summary>
        /// Возвращает количество цифр, заданного числа.
        /// </summary>
        /// <param name="number">Число</param>
        static int CountNumber(int number)
        {
            int count = 0;
            while (number > 0)
            {
                number = number / 10;
                count++;
            }
            return count;
        }
        #endregion

        static void Main(string[] args)
        {
            Console.WriteLine($"Количество цифр = {CountNumber(589)}");
            Console.ReadKey();
        }
    }
}
