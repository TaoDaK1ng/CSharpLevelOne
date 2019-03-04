using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ArrayLibrary;

namespace Lesson_4._3
{
    //Задача 3
    //Чагалысов
    //а) Дописать класс для работы с одномерным массивом.Реализовать конструктор, 
    //создающий массив определенного размера и заполняющий массив числами от начального значения с заданным шагом.
    //Создать свойство Sum, которое возвращает сумму элементов массива, метод Inverse,
    //возвращающий новый массив с измененными знаками у всех элементов массива(старый массив, остается без изменений),
    //метод Multi, умножающий каждый элемент массива на определённое число, свойство MaxCount, возвращающее количество максимальных элементов.
    //б)** Создать библиотеку содержащую класс для работы с массивом.Продемонстрировать работу библиотеки
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[10];
            Random rand = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rand.Next(10);
                Console.Write($"{array[i]} ");
            }
            Arrays arrayClass = new Arrays(10, 5, 1);
            Console.WriteLine($"\nSum: {arrayClass.Sum(array)}");
            Console.WriteLine("Inverse");
            int[] array2 = arrayClass.Inverse(array);
            foreach (var item in array2)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine($"\nMaxCounter: {arrayClass.MaxCounter(array)}");
            Console.WriteLine("Multi");
            int[] array3 = arrayClass.Multi(array, 5);
            foreach (var item in array3)
            {
                Console.Write($"{item} ");
            }
            Console.ReadKey();
        }
    }
}
