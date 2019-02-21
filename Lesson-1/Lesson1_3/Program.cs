using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudyLibrary;

namespace Lesson1_3
{
    class Program
    {
        static double Distance(double x1, double x2, double y1, double y2)
        {
            return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
        }
        static void Main(string[] args)
        {
            Study.Print("Чагалысов\nа) Написать программу, которая подсчитывает расстояние между точками с координатами x1, y1 и x2,y2 \nпо формуле r=Math.Sqrt(Math.Pow(x2-x1,2)+Math.Pow(y2-y1,2). \nВывести результат, используя спецификатор формата .2f (с двумя знаками после запятой);\nб) * Выполнить предыдущее задание, оформив вычисления расстояния между точками в виде метода.", 40, 0);

            double x1 = 0;
            double y1 = 0;
            double x2 = 0;
            double y2 = 0;
            double r = 0;

            
            Console.WriteLine("Введите координаты первой точки \nx1:");
            x1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("y1:");
            y1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите координаты второй точки \nx2:");
            x2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("y2:");
            y2 = Convert.ToDouble(Console.ReadLine());        
            Console.WriteLine("Расстояние = {0:F}", Distance(x1, x2, y1, y2));
            Console.ReadLine();
        }
    }
}
