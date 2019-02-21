using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudyLibrary;

namespace Lesson1_5
{
    class Program
    {
        static void Print(string msg, int x, int y)
        {
            Console.SetCursorPosition(x, y);
            Console.WriteLine(msg);
        }

        static void Main(string[] args)
        {
            Study.Print("Чагалысов\nа) Написать программу, которая выводит на экран ваше имя, фамилию и город проживания.\nб) * Сделать задание, только вывод организовать в центре экрана.\nв) **Сделать задание б с использованием собственных методов(например, Print(string ms, int x, int y).", 40, 0);
            Print("Артём Чагалысов, Санкт-Петербург", 40, 12);
            Console.ReadLine();
        }
    }
}
