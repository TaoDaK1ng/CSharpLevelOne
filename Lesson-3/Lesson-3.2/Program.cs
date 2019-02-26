using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_3._2
{
    class Program
    {
        //Чагалысов
        //Задание 2
        //а)С клавиатуры вводятся числа, пока не будет введён 0 (каждое число в новой строке). 
        //Требуется подсчитать сумму всех нечётных положительных чисел. 
        //Сами числа и сумму вывести на экран, используя tryParse.

        static void Main(string[] args)
        {
            int number = 0;
            int summ = 0;
            Console.WriteLine("Введите числа: ");
            do
            {
                while (!int.TryParse(Console.ReadLine(), out number))
                {
                    Console.WriteLine("Введите число!");
                }
                if ((number % 2) != 0 && number > 0) { summ += number; }

            } while (number != 0);
            Console.WriteLine($"Сумма положительных не чётных чисел = {summ}");
            Console.ReadKey();
        }
    }
}
