using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Distance
{
    /// <summary>
    /// Главный класс _3.Distance.Program
    /// </summary>
    internal class Program
    {
        /// <summary>
        /// Точка входа в программу
        /// </summary>
        /// <param name="args">Строковые параметры</param>
        static void Main(string[] args)
        {
            Console.Title = "Яковлев Олег. Задание 3: Расстояние между точками"; // Заголовок консоли

            /*
             3. 
                а) Написать программу, которая подсчитывает расстояние между точками с координатами x1,y1 и x2,y2 по формуле r=Math.Sqrt(Math.Pow(x2-x1,2)+Math.Pow(y2-y1,2). Вывести результат, используя спецификатор формата .2f (с двумя знаками после запятой);
            */

            Console.WriteLine("Рассчет расстояния между точками с координатами x1,y1 и x2,y2 (без метода)\n");

            Console.WriteLine("Введите координаты первой точки");

            Console.Write("x1: ");
            double x1 = double.Parse(Console.ReadLine()); // ввод координаты x1 первой точки

            Console.Write("y1: ");
            double y1 = double.Parse(Console.ReadLine()); // ввод координаты y1 первой точки

            Console.WriteLine("Введите координаты второй точки:");

            Console.Write("x2: ");
            double x2 = double.Parse(Console.ReadLine()); // ввод координаты x2 второй точки

            Console.Write("y2: ");
            double y2 = double.Parse(Console.ReadLine()); // ввод координаты y2 второй точки

            double result = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2)); // рассчет расстояния между точками по формуле

            Console.WriteLine("Расстояние между точками: {0:F2}", result); // вывод расстояния, используя спецификатор формата .2f

            Console.ReadLine();

            Console.Clear(); // очистка отображаемой информации

            /*
             3.
                б) *Выполнить предыдущее задание, оформив вычисления расстояния между точками в виде метода.
            */

            Console.WriteLine("Рассчет расстояния между точками с координатами a1,b1 и a2,b2) (с методом)\n");

            Console.WriteLine("Введите координаты первой точки");

            Console.Write("a1: ");
            double a1 = double.Parse(Console.ReadLine()); // ввод координаты a1 первой точки

            Console.Write("b1: ");
            double b1 = double.Parse(Console.ReadLine()); // ввод координаты b1 первой точки

            Console.WriteLine("Введите координаты второй точки:");

            Console.Write("a2: ");
            double a2 = double.Parse(Console.ReadLine()); // ввод координаты a2 второй точки

            Console.Write("b2: ");
            double b2 = double.Parse(Console.ReadLine()); // ввод координаты b2 второй точки

            Console.WriteLine("Расстояние между точками: {0:F2}", Distance(a1, b1, a2, b2)); // форматированный вывод расстояния, используя спецификатор формата .2f

            Console.ReadLine();

        }

        /// <summary>
        /// Подсчет расстояния между точками с координатами x1,y1 и x2,y2 по формуле r=Math.Sqrt(Math.Pow(x2-x1,2)+Math.Pow(y2-y1,2)
        /// </summary>
        /// <param name="x1">Координата x1 первой точки</param>
        /// <param name="y1">Координата y1 первой точки</param>
        /// <param name="x2">Координата x2 второй точки</param>
        /// <param name="y2">Координата y2 второй точки</param>
        /// <returns>Результат вычисления расстояния между точками</returns>
        static double Distance(double x1, double y1, double x2, double y2)
        {
            return Math.Sqrt(Math.Pow((x1 - x2), 2) + Math.Pow((y1 - y2), 2));
        }
    }
}
