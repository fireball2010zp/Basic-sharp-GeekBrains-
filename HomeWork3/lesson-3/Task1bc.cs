using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

        /* Яковлев Олег. Урок 3.
          1.
              а) Дописать структуру Complex, добавив метод вычитания комплексных чисел. Продемонстрировать работу структуры.
          --> б) Дописать класс Complex, добавив методы вычитания и произведения чисел. Проверить работу класса.
          --> в) Добавить диалог с использованием switch демонстрирующий работу класса.
         */

namespace lesson_3
{

    /// <summary>
    /// Комплексное число
    /// </summary>
    class ComplexClass
    {
        /// <summary>
        /// Мнимая часть комплексного числа
        /// </summary>
        private double im;

        /// <summary>
        /// Действительная часть комплексного числа
        /// </summary>
        private double re;

        /// <summary>
        /// Свойства комплексного числа
        /// </summary>
        public double Re 
        {
            get // метод, который возвращает действительную часть комплексного числа
            {
                return re; 
            }
            set // метод, который задаёт значение value
            {
                if (value == 0)
                {
                    throw new Exception("На ноль делить нельзя!"); // возбуждение исключения (прерывание выполнения, если действительную часть комплексного числа = 0)
                }
                re = value; // возвращение значения value для чтения
            }
        }

        public ComplexClass() // базовый конструктор класса ComplexClass (в явной форме)
        {

        }

        public ComplexClass(double re, double im) // перегрузка базового конструктора (параметры - значения действительной и мнимой части)
        {
            if (re == 0)
            {
                throw new Exception("На ноль делить нелья!"); // возбуждение исключения (прерывание выполнения, если действительную часть комплексного числа = 0)
            }

            this.re = re; // доступность до действительной части комплексного числа в рамках класса
            this.im = im; // доступность до мнимой части комплексного числа в рамках класса
        }

        /// <summary>
        /// Сложение комплексных чисел
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        public ComplexClass Plus(ComplexClass x)
        {
            return new ComplexClass(re + x.re, im + x.im);
        }

        /// <summary>
        /// Вычитание комплексных чисел
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        public ComplexClass Minus(ComplexClass x)
        {
            return new ComplexClass(re - x.re, im - x.im);
        }

        /// <summary>
        /// Произведение комплексных чисел
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        public ComplexClass Multiplication(ComplexClass x)
        {
            return new ComplexClass((re * x.re) - (im * x.im), (re * x.im) + (im * x.re)); // формула для произведения z1=a+bi и z2=c+di - z1z2 = (ac-bd)+i(ad+cb)
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

    internal class Taks1bc
    {

        static void PlusComp()
        {
            Console.WriteLine($"\nДемонстрация сложения комплексных чисел");
            Console.WriteLine($"=======================================");

            ComplexClass complex01 = new ComplexClass(5, 3);
            ComplexClass complex02 = new ComplexClass(3, -1);

            Console.WriteLine($"Первое комплексное число: {complex01}");
            Console.WriteLine($"Второе комплексное число: {complex02}");

            Console.WriteLine($"Сумма комплексных чисел {complex01} и {complex02} = {complex01.Plus(complex02)}");
        }

        static void MinusComp()
        {
            Console.WriteLine($"\nДемонстрация вычитания комплексных чисел");
            Console.WriteLine($"========================================");

            ComplexClass complex01 = new ComplexClass(5, 3);
            ComplexClass complex02 = new ComplexClass(3, -1);

            Console.WriteLine($"Первое комплексное число: {complex01}");
            Console.WriteLine($"Второе комплексное число: {complex02}");

            Console.WriteLine($"Вычитание комплексных чисел {complex01} и {complex02} = {complex01.Minus(complex02)}");
        }

        static void MultiplComp()
        {
            Console.WriteLine($"\nДемонстрация произведения комплексных чисел");
            Console.WriteLine($"===========================================");

            ComplexClass complex01 = new ComplexClass(5, 3);
            ComplexClass complex02 = new ComplexClass(3, -1);

            Console.WriteLine($"Первое комплексное число: {complex01}");
            Console.WriteLine($"Второе комплексное число: {complex02}");

            Console.WriteLine($"Произведение комплексных чисел {complex01} и {complex02} = {complex01.Multiplication(complex02)}");
        }

        static void Main(string[] args)
        {
            Console.Title = "Яковлев Олег. Задание 1 б,в)"; // Заголовок консоли

            bool f = true;
            while (f)
            {
                Console.WriteLine($"\nВыберите интересующую вас демонстрацию операции с комплексными числами:");
                Console.WriteLine($"======================================================================");
                Console.WriteLine($"1 - Демонстрация сложения комплексных чисел");
                Console.WriteLine($"2 - Демонстрация вычитания комплексных чисел");
                Console.WriteLine($"3 - Демонстрация произведения комплексных чисел");
                Console.WriteLine($"0 - Завершение работы приложения");
                Console.WriteLine($"======================================================================\n");

                Console.Write("Введите номер демонстрации: ");
                int number = int.Parse(Console.ReadLine());

                switch (number)
                {
                    case 0:
                        Console.WriteLine("Завершение работы приложения ...");
                        f = false;
                        break;

                    case 1:
                        PlusComp();
                        break;

                    case 2:
                        MinusComp();
                        break;

                    case 3:
                        MultiplComp();
                        break;

                    default:
                        Console.WriteLine("Некорректный номер демонстрации. \nПовторите попытку ввода");
                        break;

                }

            }

            Console.ReadLine();
        }
    }
}