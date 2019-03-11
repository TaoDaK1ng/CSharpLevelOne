using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace Lesson_6._2
{
    //Чагалысов
    //Задание 2
    //Модифицировать программу нахождения минимума функции так, чтобы можно было передавать функцию в виде делегата.
    //а) Сделать меню с различными функциями и представить пользователю выбор, для какой функции и на каком отрезке находить минимум.
    //Использовать массив(или список) делегатов, в котором хранятся различные функции.
    //б) * Переделать функцию Load, чтобы она возвращала массив считанных значений.Пусть она возвращает минимум через параметр(с использованием модификатора out). 

    public delegate double Fun(double x); 

    class Program
    {
        List<Fun> list;
        public Program()
        {
            list = new List<Fun>();
            list.Add(MyFunc);
            list.Add(MyFunc2);
            list.Add(MyFunc3);
        }
        /// <summary>
        /// Возвращает результат функции: f(x) = x * x - 50x + 10
        /// </summary>
        /// <param name="x">Число подставляемое в функцию вместо x</param>
        /// <returns>Результат функции, после подстановки</returns>
        public static double MyFunc(double x)
        {
            return x * x - 50 * x + 10;
        }
        /// <summary>
        /// Возвращает результат функции: f(x) = x^3 - 3x + 1
        /// </summary>
        /// <param name="x">Число подставляемое в функцию вместо x</param>
        /// <returns>Результат функции, после подстановки</returns>
        public static double MyFunc2(double x)
        {
            return Math.Pow(x, 3) - 3 * x + 1;
        }
        /// <summary>
        /// Возвращает результат функции: f(x) = x^2
        /// </summary>
        /// <param name="x">Число подставляемое в функцию вместо x</param>
        /// <returns>Результат функции, после подстановки</returns>
        public static double MyFunc3(double x)
        {
            return Math.Pow(x, 2);
        }
        /// <summary>
        /// Записывает данные функции в файл на промежутке от a до b с шагом h
        /// </summary>
        /// <param name="F">Делегат с сигнатурой double (double)</param>
        /// <param name="fileName">Имя файла, в который будут записываться данные</param>
        /// <param name="a">Начало отрезка</param>
        /// <param name="b">Конец отрезка</param>
        /// <param name="h">Шаг</param>
        public static void SaveFunc(Fun F, string fileName, double a, double b, double h)
        {
            FileStream fs = new FileStream(fileName, FileMode.Create, FileAccess.Write);
            BinaryWriter bw = new BinaryWriter(fs);
            double x = a;
            while (x <= b)
            {
                bw.Write(F(x));
                x += h;
            }
            bw.Close();
            fs.Close(); 
        }
        /// <summary>
        /// Возвращает массив считанных значений и находит минимум функции
        /// </summary>
        /// <param name="fileName">Имя файла, из которого будут считываться данные</param>
        /// <param name="min">Минимум функции</param>
        /// <returns>Массив считанных значений</returns>
        public static double[] Load(string fileName, out double min)
        {
            FileStream fs = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            BinaryReader bw = new BinaryReader(fs);
            min = double.MaxValue;
            double[] array = new double[fs.Length];
            for (int i = 0; i < fs.Length / sizeof(double); i++)
            {
                // Считываем значение и переходим к следующему
                array[i] = bw.ReadDouble();
                if (array[i] < min) min = array[i];
            }
            bw.Close();
            fs.Close();
            return array;
        }
        static void Main(string[] args)
        {
            double min;
            Program a = new Program();
            Console.WriteLine("Выберите одну из функций, для которой хотите найти минимум:");
            Console.WriteLine("1) f(x) = x * x - 50x + 10 на отрезке от -100 до 100");
            Console.WriteLine("2) f(x) = x^3 - 3x + 1 на отрезке от -200 до 200");
            Console.WriteLine("3) f(x) = x^2 на отрезке от -300 до 300");
            switch (Convert.ToInt32(Console.ReadLine()))
            {
                case 1: SaveFunc(a.list[0], "data.bin", -100, 100, 0.5);
                    break;
                case 2: SaveFunc(a.list[1], "data.bin", -200, 200, 0.5);
                    break;
                case 3: SaveFunc(a.list[2], "data.bin", -300, 300, 0.5);
                    break;
            }
            Console.WriteLine("Массив считанных значений:");
            double[] array = Load("data.bin", out min);
            foreach (var item in array)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine($"\nМинимум функции: {min}");
            Console.ReadKey();
        }
    }
}
