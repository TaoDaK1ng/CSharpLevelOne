using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_2._5
{
    class Program
    {
        //Чагалысов
        //Задание 5
        //а) Написать программу, которая запрашивает массу и рост человека, вычисляет его индекс массы и сообщает, нужно ли человеку похудеть, набрать вес или всё в норме.
        //б) *Рассчитать, на сколько кг похудеть или сколько кг набрать для нормализации веса.

        static void Main(string[] args)
        {
            double IMT, weight, height, gainKg, loseKg;
            Console.WriteLine("Введите рост:");
            height = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите вес:");
            weight = Convert.ToDouble(Console.ReadLine()) / 100;
            IMT = weight / (height * height);
            gainKg = (18.5 - IMT) * (height * height);
            loseKg = (IMT - 25) * (height * height);
            string recomendation = (18.5 > IMT && IMT < 25) ? "У вас нормальный вес." : ((18.5 > IMT) ? $"Нужно набрать {gainKg} кг." : $"Нужно сбросить {loseKg} кг.");
            Console.WriteLine(recomendation);
            Console.ReadLine();
        }
    }
}
