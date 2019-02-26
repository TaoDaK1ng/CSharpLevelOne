using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_3
{

    #region Структура комплексного числа

    /// <summary>
    /// Структура комплексного числа
    /// </summary>
    struct Complex
    {
        public double im;
        public double re;

        #region Метод суммы двух комплексных чисел

        /// <summary>
        /// Возвращает сумму двух комплексных чисел
        /// </summary>
        /// <param name="x">Комплексное число</param>
        public Complex Plus(Complex x)
        {
            Complex y;
            y.im = im + x.im;
            y.re = re + x.re;
            return y;
        }
        #endregion

        #region Метод разности двух комплексных чисел

        /// <summary>
        /// Возвращает разность двух комплексных чисел
        /// </summary>
        /// <param name="x">Комплексное число</param>
        public Complex Minus(Complex x)
        {
            Complex y;
            y.im = im - x.im;
            y.re = re - x.re;
            return y;
        }
        #endregion

        #region Метод произведения двух комплексных чисел

        /// <summary>
        /// Возвращает произведение двух комплексных чисел
        /// </summary>
        /// <param name="x">Комплексное число</param>
        public Complex Multi(Complex x)
        {
            Complex y;
            y.im = re * x.im + im * x.re;
            y.re = re * x.re - im * x.im;
            return y;
        }
        #endregion

        #region Метод преобразования в строковый формат комплексных чисел

        /// <summary>
        /// Преобразовывает в строковый формат комплексных чисел
        /// </summary>
        public string ToString()
        {
            return re + "+" + im + "i";
        }
        #endregion

    }
    #endregion

    #region Класс комплексного числа

    /// <summary>
    /// Класс комплексного числа
    /// </summary>
    class ComplexClass
    {        
        public double im;
        public double re;

        #region Метод суммы двух комплексных чисел

        /// <summary>
        /// Возвращает сумму двух комплексных чисел
        /// </summary>
        /// <param name="x2">Комплексное число</param>
        public ComplexClass Plus(ComplexClass x2)
        {
            ComplexClass x3 = new ComplexClass();
            x3.im = x2.im + this.im;
            x3.re = x2.re + this.re;
            return x3;
        }
        #endregion

        #region Метод разности двух комплексных чисел

        /// <summary>
        /// Возвращает разность двух комплексных чисел
        /// </summary>
        /// <param name="x2">Комплексное число</param>
        public ComplexClass Minus(ComplexClass x2)
        {
            ComplexClass x3 = new ComplexClass();
            x3.im = this.im - x2.im;
            x3.re = this.re - x2.re;
            return x3;
        }
        #endregion

        #region Метод произведения двух комплексных чисел

        /// <summary>
        /// Возвращает произведение двух комплексных чисел
        /// </summary>
        /// <param name="x2">Комплексное число</param>
        public ComplexClass Multi(ComplexClass x2)
        {
            ComplexClass x3 = new ComplexClass();
            x3.im = x2.im + this.im;
            x3.re = x2.re + this.re;

            x3.im = x2.re * this.im + x2.im * this.re;
            x3.re = x2.re * this.re - x2.im * this.im;
            return x3;
        }
        #endregion

        #region Метод преобразования в строковый формат комплексных чисел

        /// <summary>
        /// Преобразовывает в строковый формат комплексных чисел
        /// </summary>
        public string ToString()
        {
            return re + "+" + im + "i";
        }
        #endregion
    }
    #endregion

    //Чагалысов
    //Задание 1
    //а) Дописать структуру Complex, добавив метод вычитания комплексных чисел.
    //Продемонстрировать работу структуры.
    //б) Дописать класс Complex, добавив методы вычитания и произведения чисел. 
    //Проверить работу класса.
    //в) Добавить диалог с использованием switch демонстрирующий работу класса.

    class Program
    {
        static void Main(string[] args)
        {
            
            //Обьявление комплексных чисел структуры
            Complex complex1;
            complex1.re = 1;
            complex1.im = 1;

            Complex complex2;
            complex2.re = 2;
            complex2.im = 2;

            //Обьявление комплексных чисел класса
            ComplexClass complex1Class = new ComplexClass();
            complex1Class.re = 1;
            complex1Class.im = 1;

            ComplexClass complex2Class = new ComplexClass();
            complex2Class.re = 2;
            complex2Class.im = 2;
          
            Complex result = complex1.Plus(complex2);
            ComplexClass resultClass = complex1Class.Plus(complex2Class);

            Console.WriteLine("Введите номер одного из трёх вариантов:\n1)Сумма\n2)Разность\n3)Произведение");
            int quetion = Convert.ToInt32(Console.ReadLine());

            switch (quetion)
            {
                case 1:
                    Console.WriteLine($"Структура\ncomplex1 = {complex1.ToString()}\ncomplex2 = {complex2.ToString()}\nРезультат = {result.ToString()}\n-----");
                    Console.WriteLine($"Класс\ncomplex1Class = {complex1Class.ToString()}\ncomplex2Class = {complex2Class.ToString()}\nРезультат = {resultClass.ToString()}");
                    break;
                case 2:
                    result = complex1.Minus(complex2);
                    Console.WriteLine($"Структура\ncomplex1 = {complex1.ToString()}\ncomplex2 = {complex2.ToString()}\nРезультат = {result.ToString()}\n-----");
                    resultClass = complex1Class.Minus(complex2Class);
                    Console.WriteLine($"Класс\ncomplex1Class = {complex1Class.ToString()}\ncomplex2Class = {complex2Class.ToString()}\nРезультат = {resultClass.ToString()}");
                    break;
                case 3:
                    result = complex1.Multi(complex2);
                    Console.WriteLine($"Структура\ncomplex1 = {complex1.ToString()}\ncomplex2 = {complex2.ToString()}\nРезультат = {result.ToString()}\n-----");
                    resultClass = complex1Class.Multi(complex2Class);
                    Console.WriteLine($"Класс\ncomplex1Class = {complex1Class.ToString()}\ncomplex2Class = {complex2Class.ToString()}\nРезультат = {resultClass.ToString()}");
                    break;
            }

            Console.ReadKey();

        }
    }
}
