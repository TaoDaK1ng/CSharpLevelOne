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

    class Program
    {
        static void Main(string[] args)
        {
            Complex complex1;
            complex1.re = 1;
            complex1.im = 1;

            Complex complex2;
            complex2.re = 2;
            complex2.im = 2;

            Complex result = complex1.Plus(complex2);
            Console.WriteLine($"Сумма\ncomplex1 = {complex1.ToString()}\ncomplex2 = {complex2.ToString()}\nРезультат = {result.ToString()}");
            result = complex1.Minus(complex2);
            Console.WriteLine($"Разность\ncomplex1 = {complex1.ToString()}\ncomplex2 = {complex2.ToString()}\nРезультат = {result.ToString()}");
            result = complex1.Multi(complex2);
            Console.WriteLine($"Произведение\ncomplex1 = {complex1.ToString()}\ncomplex2 = {complex2.ToString()}\nРезультат = {result.ToString()}");
            Console.ReadKey();
        }
    }
}
