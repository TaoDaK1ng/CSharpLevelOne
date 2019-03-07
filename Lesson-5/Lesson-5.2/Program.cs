using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Lesson_5._2
{
    //Задание 2
    //Чагалысов
    //Разработать статический класс Message, содержащий следующие статические методы для обработки текста:
    //а) Вывести только те слова сообщения,  которые содержат не более n букв.
    //б) Удалить из сообщения все слова, которые заканчиваются на заданный символ.
    //в) Найти самое длинное слово сообщения.
    //г) Сформировать строку с помощью StringBuilder из самых длинных слов сообщения.
    //д) *** Создать метод, который производит частотный анализ текста.В качестве параметра в него передается массив слов и текст,
    //в качестве результата метод возвращает сколько раз каждое из слов массива входит в этот текст.Здесь требуется использовать класс Dictionary.

    public static class Message
    {
        public static void MessageCount(string message, int n)
        {
            string[] array = message.Split(new char[] { ',', ' ', '.', '!', '?', '-' });
            foreach (var item in array)
            {
                if (item.Length <= n)
                {
                    Console.Write(item + " ");
                }
            }  
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            string message = Console.ReadLine();
            Message.Equals(message, 5);
            Console.ReadKey();
        }
    }
}
