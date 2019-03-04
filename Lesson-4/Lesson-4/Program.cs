using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Lesson_4
{
    //Чагалысов
    //Задача 1
    //Дан  целочисленный массив  из 20 элементов.Элементы массива  могут принимать  целые значения  от –10 000 до 10 000 включительно.
    //Заполнить случайными числами.Написать программу, позволяющую найти и вывести количество пар элементов массива,
    //в которых только одно число делится на 3. В данной задаче под парой подразумевается два подряд идущих элемента массива.
    //Например, для массива из пяти элементов: 6; 2; 9; –3; 6 ответ — 2. 
    //Задача 2
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
            Console.ReadKey();
        }
    }
}
