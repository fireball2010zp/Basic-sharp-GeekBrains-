using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

            /* Яковлев Олег. Урок 3.
             1.
             --> а) Дописать структуру Complex, добавив метод вычитания комплексных чисел. Продемонстрировать работу структуры.
                 б) Дописать класс Complex, добавив методы вычитания и произведения чисел. Проверить работу класса.
                 в) Добавить диалог с использованием switch демонстрирующий работу класса.
            */

namespace lesson_3
{
    /// <summary>
    /// Комплексное число
    /// </summary>
    struct Complex
    {
        /// <summary>
        /// Мнимая часть комплексного числа
        /// </summary>
        public double im;

        /// <summary>
        /// Действительная часть комплексного числа
        /// </summary>
        public double re;

        /// <summary>
        /// Сложение комплексных чисел
        /// </summary>
        /// <param name="x">Второе комплексное число</param>
        /// <returns>Третье комплексное число - результат сложения комплексных чисел</returns>
        public Complex Plus(Complex x)
        {
            Complex y;
            y.re = re + x.re;
            y.im = im + x.im;
            return y;
        }

        /// <summary>
        /// Вычитание комплексных чисел
        /// </summary>
        /// <param name="x">Второе комплексное число</param>
        /// <returns>Третье комплексное число - результат вычитания комплексных чисел</returns>
        public Complex Minus(Complex x)
        {
            Complex y;
            y.re = re - x.re;
            y.im = im - x.im;
            return y;
        }

        /// <summary>
        /// Метод переопределения структуры комплексного числа
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            if (im <= -1)
            {
                return $"{re}-{Math.Abs(im)}i";
            }
            else return $"{re}+{im}i";
        }
    }


    internal class Task1a
    {

        static void Main(string[] args)
        {
            Console.Title = "Яковлев Олег. Задание 1 a)"; // Заголовок консоли

            Console.Write("Введите действительную часть 1-го комплексного числа: ");
            double inputRe01 = double.Parse(Console.ReadLine()); // ввод действительной части 1-го комплексного числа

            Console.Write("Введите мнимую часть 1-го комплексного числа: ");
            double inputIm01 = double.Parse(Console.ReadLine()); // ввод мнимой части 1-го комплексного числа

            Complex complex01; // объявление переменной complex01 типа Complex
            complex01.re = inputRe01; // инициализация действительной части переменной complex01 типа Complex
            complex01.im = inputIm01; // инициализация мнимой части переменной complex01 типа Complex

            Console.Write("\nВведите действительную часть 2-го комплексного числа: ");
            double inputRe02 = double.Parse(Console.ReadLine()); // ввод действительной части 2-го комплексного числа

            Console.Write("Введите мнимую часть 2-го комплексного числа: ");
            double inputIm02 = double.Parse(Console.ReadLine()); // ввод мнимой части 2-го комплексного числа

            Complex complex02; // объявление переменной complex02 типа Complex
            complex02.re = inputRe02; // инициализация действительной части переменной complex02 типа Complex
            complex02.im = inputIm02; // инициализация мнимой части переменной complex02 типа Complex


            Console.WriteLine($"\nПервое комплексное число: {complex01}");
            Console.WriteLine($"Второе комплексное число: {complex02}");

            Console.WriteLine($"\nСумма комплексных чисел {complex01} и {complex02} = {complex01.Plus(complex02)}"); // вывод сложения комплексных чисел
            Console.WriteLine($"Вычитание комплексных чисел {complex01} и {complex02} = {complex01.Minus(complex02)}"); // вывод вычитания комплексных чисел

            Console.ReadLine();




        }
    }
}
