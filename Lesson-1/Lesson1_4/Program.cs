using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudyLibrary;

namespace Lesson1_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Study.Print("Чагалысов\nНаписать программу обмена значениями двух переменных:\nа) с использованием третьей переменной;\nб) *без использования третьей переменной.", 40, 0);
            int a = 10;    
            int b = 20;     
            int t = a;        
            a = b;           
            b = t;
            Console.WriteLine("а = " + a + ", b = " + b);
            a = 10;
            b = 20;
            Console.WriteLine("а = " + a + ", b = " + b);
            Console.ReadLine();
        }
    }
}
