using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudyLibrary
{
    //Создать класс с методами, которые могут пригодиться в вашей учебе(Print, Pause)
    public class Study
    {
        public static void Pause()
        {
            Console.ReadKey();
        }
        public static void Pause(string msg)
        {
            Console.WriteLine(msg);
            Console.ReadKey();
        }

        public static void Print(string msg, int x, int y)
        {
            // Установим позицию курсора на экране
            Console.SetCursorPosition(x, y);
            Console.WriteLine(msg);
        }

        public static void Print(string msg, ConsoleColor foregroundcolor)
        {
            // Установим цвет символов
            Console.ForegroundColor = foregroundcolor;
            Console.WriteLine(msg);
        }


    }
}
