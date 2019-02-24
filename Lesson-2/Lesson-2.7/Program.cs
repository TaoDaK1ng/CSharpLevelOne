using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_2._7
{
    class Program
    {
        //Чагалысов
        //7 задание
        //a) Разработать рекурсивный метод, который выводит на экран числа от a до b(a<b).
        //б) *Разработать рекурсивный метод, который считает сумму чисел от a до b.
        #region Рекурсивный метод, который выводит на экран числа от a до b

        /// <summary>
        /// Выводит на экран числа от a до b.
        /// </summary>
        /// <param name="a">Начальное число</param>
        /// <param name="b">Конечное число</param>
        static void Loop(int a, int b)
        {
            Console.Write("{0,4}", a);
            if (a < b) Loop(a + 1, b);
        }
        #endregion

        #region Рекурсивный метод, который считает сумму чисел от a до b

        /// <summary>
        /// Считает сумму чисел от a до b.
        /// </summary>
        /// <param name="a">Начальное число</param>
        /// <param name="b">Конечное число</param>
        static int SumLoop(int a, int b)
        {
            return (a == b) ? b : a + SumLoop(a + 1, b); 
        }
        #endregion

        static void Main(string[] args)
        {
            Loop(3, 13);
            Console.WriteLine("\n Сумма чисел равна: " + SumLoop(3, 13));
            Console.ReadKey();
        }
    }
}
