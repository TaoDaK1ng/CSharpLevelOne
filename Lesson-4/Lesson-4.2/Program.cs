using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Lesson_4._2
{
    //Задача 2
    //Чагалысов
    //Реализуйте задачу 1 в виде статического класса StaticClass;
    //а) Класс должен содержать статический метод, который принимает на вход массив и решает задачу 1;
    //б) * Добавьте статический метод для считывания массива из текстового файла.Метод должен возвращать массив целых чисел;
    //в)** Добавьте обработку ситуации отсутствия файла на диске.

    public static class StaticClass
    {
        public static void ArrayСouples(int[] array)
        {
            int count = 0;
            for (int i = 0; i < array.Length - 1; i++)
            {
                if (array[i] % 3 == 0 || array[i + 1] % 3 == 0)
                {
                    count++;
                }
            }
            Console.WriteLine("\nКоличество пар: " + count);
        }
        public static int[] ArrayFile(string filename)
        {
            try
            {
                string[] array = File.ReadAllLines("C:/" + filename);
                int[] a = new int[array.Length];
                for (int i = 0; i < array.Length; i++)
                {
                    a[i] = Convert.ToInt32(array[i]);
                }
                return a;
            }
            catch
            {
                int[] a = new int[0];
                Console.WriteLine("Файл не найден");
                return a;
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[20];
            Random rand = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rand.Next(-10000, 10000);
                Console.Write($"{array[i]} ");
            }
            StaticClass.ArrayСouples(array);
            
            //Массив из текстового файла
            int[] array2 = StaticClass.ArrayFile("array.txt");
            foreach (var item in array2)
            {
                Console.Write(item + " ");
            }
            Console.ReadKey();
        }
    }
}
