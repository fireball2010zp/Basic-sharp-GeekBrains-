using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.IMT
{
    /// <summary>
    /// Главный класс _2.IMT.Program
    /// </summary>
    internal class Program
    {
        /// <summary>
        /// Точка входа в программу
        /// </summary>
        /// <param name="args">Строковые параметры</param>
        static void Main(string[] args)
        {
            Console.Title = "Яковлев Олег. Задание 2: Рассчет ИМТ"; // Заголовок консоли

            /*
            2. Ввести вес и рост человека. Рассчитать и вывести индекс массы тела (ИМТ) по формуле I=m/(h*h); где m — масса тела в килограммах, h — рост в метрах. 
            */

            Console.WriteLine("Рассчет индекса массы тела (ИМТ)\n");

            Console.Write("Введите ваш вес (в кг): ");
            double m = double.Parse(Console.ReadLine()); // ввод веса (только цифра)

            Console.Write("Введите ваш рост (в метрах): ");
            double h = double.Parse(Console.ReadLine()); // ввод роста (только цифра)

            double I = m / (h * h); // рассчет ИМТ по формуле

            Console.WriteLine("Ваш ИМТ: {0:F2}", I); // вывод ИМТ, используя спецификатор формата .2f

            Console.ReadLine();

        }
    }
}
