using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson_2
{
    internal class Task2
    {
        static void Main(string[] args)
        { 
            Console.Title = "Яковлев Олег. Задание 2"; // Заголовок консоли

            /*
            2. Написать метод подсчета количества цифр числа.
            */

            Console.WriteLine("Подсчет количества цифр числа");
            Console.WriteLine("================================\n");

            Console.Write("Введите целое число: ");
            int a = int.Parse(Console.ReadLine());  // вводим целое число

            Console.WriteLine("Количество цифр в ведённом числе - {0}", Amount(a)); // выводим результат обработки метода Amount из введённого чисела a

            Console.ReadLine(); // Enter для выхода
        }

        /// <summary>
        /// Метод, возвращающий количество цифр числа
        /// </summary>
        /// <param name="a">Целое число</param>
        /// <returns>Значение счетчика (количество цифр числа)</returns>
        static int Amount(int a)
        {
            int i = 0; // обнуление счетчика
            while (a != 0) 
            {
                i++; // увеличиваем счетчик
                a = a / 10; // целое число - деление целочисленное	
            }
            return i;
        }
    }
}
