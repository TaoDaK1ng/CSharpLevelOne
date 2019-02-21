using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudyLibrary;

namespace Lesson_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Study.Print("Чагалысов\nНаписать программу «Анкета». Последовательно задаются вопросы (имя, фамилия, возраст, рост, вес). \nВ результате вся информация выводится в одну строчку:\nа) используя склеивание;\nб) используя форматированный вывод;\nв) используя вывод со знаком $.\nВвести вес и рост человека.Рассчитать и вывести индекс массы тела(ИМТ) по формуле\n I = m / (h * h); где m — масса тела в килограммах, h — рост в метрах.", 40, 0);
            var firstName = "";
            var lastName = "";
            var age = "";
            double growth = 0;
            double weight = 0;

            Console.WriteLine("Ваше имя?");
            firstName = Console.ReadLine();
            Console.WriteLine("Ваша фамилия?");
            lastName = Console.ReadLine();
            Console.WriteLine("Ваш возраст?");
            age = Console.ReadLine();
            Console.WriteLine("Ваш рост?");
            growth = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ваш вес?");
            weight = Convert.ToInt32(Console.ReadLine());
            
            Console.Write("Слияние \n");
            Console.Write("Имя - " + firstName + ", фамилия - " + lastName + ", возраст - " + age + ", рост - " + growth + ", вес - " + weight + "\n");
            Console.Write("Форматированный \n");
            Console.Write("Имя - {0}, фамилия - {1}, возраст - {2}, рост - {3}, вес - {4} \n", firstName, lastName, age, growth, weight);
            Console.Write("Со знаком $ \n");
            Console.Write($"Имя - {firstName}, фамилия - {lastName}, возраст - {age}, рост - {growth}, вес - {weight} \n");
            Console.Write("ИМТ =  " + weight / (growth * growth));
            Console.ReadLine();
        }
    }
}
