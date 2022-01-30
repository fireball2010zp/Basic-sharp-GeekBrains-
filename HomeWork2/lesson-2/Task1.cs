using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson_2
{  

    internal class Task1
    {
        /// <summary>
        /// Точка входа в программу
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.Title = "Яковлев Олег. Задание 1"; // Заголовок консоли

            /*
            1. Написать метод, возвращающий минимальное из трёх чисел.
            */

            Console.WriteLine("Поиск минимального числа из трёх");
            Console.WriteLine("================================\n");

            Console.Write("Введите первое число: ");
            int a = int.Parse(Console.ReadLine());  // вводим первое целое число

            Console.Write("Введите второе число: ");
            int b = int.Parse(Console.ReadLine());  // вводим второе целое число

            Console.Write("Введите третье число: ");
            int c = int.Parse(Console.ReadLine());  // вводим третье целое число

            Console.WriteLine("Наименьшее число из трёх - {0}", Min(a, b, c)); // выводим результат обработки метода Min из введённых чисел a, b, c

            Console.ReadLine(); // Enter для выхода

        }

        /// <summary>
        /// Метод, возвращающий минимальное из трёх чисел
        /// </summary>
        /// <param name="a">Первое число</param>
        /// <param name="b">Второе число</param>
        /// <param name="c">Третье число</param>
        /// <returns>Возвращает минимальное из трёх чисел</returns>
        static int Min(int a, int b, int c)
        {
            return a < b ? (a < c ? a : c) : (b < c ? b : c);
        }
    }
}
