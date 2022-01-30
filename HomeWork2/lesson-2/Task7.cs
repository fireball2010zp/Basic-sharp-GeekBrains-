using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson_2
{
    internal class Task7
    {
        static void Main(string[] args)
        {
            Console.Title = "Яковлев Олег. Задание 7"; // Заголовок консоли

            /*
             7.
                a) Разработать рекурсивный метод, который выводит на экран числа от a до b(a<b).
                б) *Разработать рекурсивный метод, который считает сумму чисел от a до b.
             */

            Console.WriteLine("Вывод на экран чисел от a до b (рекурсивный метод)");
            Console.WriteLine("==================================================\n");

            Console.Write("Введите первое число: ");
            int a = int.Parse(Console.ReadLine());  // вводим первое число

            Console.Write("Введите второе число: ");
            int b = int.Parse(Console.ReadLine());  // вводим второе число

            Console.Write("\nЧисла, входящие в промежуток: ");
            Loop(a, b); // вывод через рекурсивный метод ряда чисел

            Console.WriteLine("\nСумма чисел: " + SumAB(a, b, 0)); // вывод через рекурсивный метод суммы чисел

            Console.ReadLine();
        }

        /// <summary>
        /// Рекурсивный метод вывода на экран чисел от a до b
        /// </summary>
        /// <param name="a">Первое число</param>
        /// <param name="b">Последнее число</param>
        static void Loop(int a, int b)
        {
            Console.Write("{0} ", a);
            if (a < b) 
                Loop(a + 1, b);
        }

        /// <summary>
        /// Рекурсивный метод подсчета суммы чисел от a до b
        /// </summary>
        /// <param name="a">Первое число</param>
        /// <param name="b">Последнее число</param>
        /// <param name="sum">Переменная суммы чисел</param>
        /// <returns>Сумму чисел от a до b</returns>
        static long SumAB(int a, int b, long sum)
        {
            if (a == b) return sum + b;
            else
            {
                sum = sum + a;
                a++;
                return SumAB(a, b, sum);
            }
        }

    }
}

