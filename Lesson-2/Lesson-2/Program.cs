using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_2
{
    class Program
    {
        //Чагалысов
        //Задание 1
        //Написать метод, возвращающий минимальное из трёх чисел.
        /// <summary>
        /// Нахождение минимального числа из трех заданных чисел
        /// </summary>
        /// <param name="a">Первое число</param>
        /// <param name="b">Второе число</param>
        /// <param name="c">Третье число</param>
        static int Min(int a, int b, int c)
        {
            if (a < b && a < c) { return a; }
            else if (b < c) { return b; }
            else { return c; }
        }
        static void Main(string[] args)
        { 
            Console.WriteLine($"Минимальное число = {Min(1,2,3)}");
            Console.ReadLine();
        }
    }
}
