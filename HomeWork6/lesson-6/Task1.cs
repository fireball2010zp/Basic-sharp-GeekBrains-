using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    /* Яковлев Олег. Урок 6.
    1. Изменить программу вывода таблицы функции так, чтобы можно было передавать функции типа double (double, double). 
       Продемонстрировать работу на функции с функцией a*x^2 и функцией a*sin(x). 
    */

namespace lesson_6
{
    internal class Task1
    {

        public delegate double Fun(double a, double x);

        class Program
        {
            public static void Table(Fun F, double a, double x, double b) // метод, который принимает делегат Fun
            {
                Console.WriteLine("------ A -------- X ------ Y ------");
                while (x <= b)
                {
                    Console.WriteLine("| {0,8:0.000} | {1,8:0.000} | {2,8:0.000} |", a, x, F(a, x));
                    x += 1;
                }
                Console.WriteLine("-----------------------------------");
            }

            public static double Ax2(double a, double x) // метод для передачи его в качестве параметра в Table (функция a*x^2)
            {
                return a * x * x;
            }

            public static double ASinX(double a, double x) // метод для передачи его в качестве параметра в Table (функция a*sin(x))
            {
                return a * Math.Sin(x);
            }


            static void Main()
            {
                Console.WriteLine("Таблица функции a*x^2 (через переменную operation)");
                Fun operation = Ax2; // объявление и инициализация делегата через переменную operation
                Table(operation, 2, -2, 2); // вывод функции a*x^2 через переменную operation

                Console.WriteLine("\nТаблица функции a*x^2 (без переменной operation, передача напрамую без ссылки)");
                Table(Ax2, 2, -2, 2); // вывод функции a*x^2, сокращенная запись (без переменной)



                Console.WriteLine("\nТаблица функции a*sin(x) (через переменную operation)");
                Fun operation1 = ASinX; // объявление и инициализация делегата через переменную operation
                Table(operation1, 2, 0, 5); // вывод функции a*sin(x) через переменную operation1

                Console.WriteLine("\nТаблица функции a*sin(x) (без переменной operation, передача напрамую без ссылки)");
                Table(ASinX, 2, 0, 5); // вывод функции a*sin(x), сокращенная запись (без переменной)



                Console.WriteLine("\nТаблица функции a*x^2 (через анонимный метод с переменной operation2)");
                Fun operation2 = delegate (double a, double x) 
                {
                    return a * x * x; 
                };
                Table(operation2, 2, -2, 2);

                Console.WriteLine("\nТаблица функции a*x^2 (через анонимный метод без переменной):");
                Table(delegate (double a, double x) { return a * x * x; }, 2, -2, 2);



                Console.WriteLine("\nТаблица функции a*sin(x) (через анонимный метод с переменной operation3)");
                Fun operation3 = delegate (double a, double x)
                {
                    return a * Math.Sin(x);
                };
                Table(operation3, 2, 0, 5);

                Console.WriteLine("\nТаблица функции a*sin(x) (вывод через анонимный метод):");
                Table(delegate (double a, double x) { return a * Math.Sin(x); }, 2, 0, 5);

                Console.ReadLine();
            }
        }

    }
}
