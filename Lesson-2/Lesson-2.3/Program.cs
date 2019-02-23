using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_2._3
{
    class Program
    {
        //Чагалысов
        //Задание 3
        //С клавиатуры вводятся числа, пока не будет введен 0.
        //Подсчитать сумму всех не чётных положительных чисел.

        static void Main(string[] args)
        {
            int number = 0;
            int summ = 0;
            Console.WriteLine("Введите числа: ");
            do
            {
                number = Convert.ToInt32(Console.ReadLine());
                if ((number % 2) != 0 && number > 0) { summ += number; }               
            } while (number != 0);
            Console.WriteLine($"Сумма положительных не чётных чисел = {summ}");
            Console.ReadKey();
        }
    }
}
