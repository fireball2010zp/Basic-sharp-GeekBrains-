using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
      Яковлев Олег. Урок 3.
      3.
        *Описать класс дробей — рациональных чисел, являющихся отношением двух целых чисел. 
        Предусмотреть методы сложения, вычитания, умножения и деления дробей. 
        Написать программу, демонстрирующую все разработанные элементы класса.
        Добавить свойства типа int для доступа к числителю и знаменателю; 
        Добавить свойство типа double только на чтение, чтобы получить десятичную дробь числа; 
        ** Добавить проверку, чтобы знаменатель не равнялся 0. Выбрасывать исключение ArgumentException("Знаменатель не может быть равен 0"); 
        *** Добавить упрощение дробей. (-)
*/

namespace lesson_3
{

    /// <summary>
    /// Дробное число
    /// </summary>
    class Fractional
    {
        /// <summary>
        /// Числитель дроби
        /// </summary>
        private int num; // numinator

        /// <summary>
        /// Знаменатель дроби
        /// </summary>
        private int den; // denominator

        /// <summary>
        /// Сложение дробей
        /// </summary>
        public Fractional Plus(Fractional x)
        {
            if (Math.Abs(den) == Math.Abs(x.den))
                return new Fractional(num + x.num, den);
            else
            {
                return new Fractional((num * x.den) + (x.num * den), den * x.den);
            }
        }

        /// <summary>
        /// Вычитание дробей
        /// </summary>
        public Fractional Minus(Fractional x)
        {
            if (Math.Abs(den) == Math.Abs(x.den))
                return new Fractional(num - x.num, den);
            else
            {
                return new Fractional((num * x.den) - (x.num * den), den * x.den);
            }
        }

        /// <summary>
        /// Произведение дробей
        /// </summary>
        public Fractional Multipl(Fractional x)
        {
            return new Fractional(num * x.num, den * x.den);
        }

        /// <summary>
        /// Произведение дробей
        /// </summary>
        public Fractional Division(Fractional x)
        {
            return new Fractional(num * x.den, den * x.num);
        }

        public override string ToString()
        {
            return $"{num}/{den}";
        }

        public double Num
        {
            set
            {
                if (value == 0)
                {
                    throw new Exception("На ноль делить нельзя!");
                }
                double num = value;
            }
        }

        public Fractional(int num, int den)
        {
            if (den == 0)
            {
                throw new ArgumentException("Знаменатель не может быть равен 0!");
            }

            this.num = num;
            this.den = den;
        }

    }

    internal class Task3
    {
        static void Main(string[] args)
        {
            Console.Title = "Яковлев Олег. Задание 3 (*,**)"; // Заголовок консоли

            Console.Write("Введите числитель 1-й дроби: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.Write("Введите знаменатель 1-й дроби: ");
            int den1 = int.Parse(Console.ReadLine());

            Console.Write("Введите числитель 2-й дроби: ");
            int num2 = int.Parse(Console.ReadLine());

            Console.Write("Введите знаменатель 2-й дроби: ");
            int den2 = int.Parse(Console.ReadLine());


            Fractional fractNumber01 = new Fractional(num1, den1);
            Fractional fractNumber02 = new Fractional(num2, den2);

            Console.WriteLine($"\nПервая дробь: {fractNumber01}");
            Console.WriteLine($"Вторая дробь: {fractNumber02}");

            Console.WriteLine($"\nСумма дробей {fractNumber01} и {fractNumber02} = {fractNumber01.Plus(fractNumber02)}");

            Console.WriteLine($"\nВычитание дробей {fractNumber01} и {fractNumber02} = {fractNumber01.Minus(fractNumber02)}");

            Console.WriteLine($"\nПроизведение дробей {fractNumber01} и {fractNumber02} = {fractNumber01.Multipl(fractNumber02)}");

            Console.WriteLine($"\nДеление дробей {fractNumber01} и {fractNumber02} = {fractNumber01.Division(fractNumber02)}");

            Console.ReadLine();
        }
    }

}
