using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

    /* Яковлев Олег. Урок 6.
        2. Модифицировать программу нахождения минимума функции так, чтобы можно было передавать функцию в виде делегата.
        а) Сделать меню с различными функциями и представить пользователю выбор, для какой функции и на каком отрезке находить минимум. 
            Использовать массив (или список) делегатов, в котором хранятся различные функции.
    */

namespace lesson_6
{
    internal class Task2
    {
        public delegate double Func(double x);

        public static double SinX(double x) // метод для передачи через делегат (уравнение y = sin(x))
        {
            return Math.Sin(x);
        }

        public static double X2(double x) // метод для передачи через делегат (уравнение y = x^2)
        {
            return x * x;
        }

        public static double X3(double x) // метод для передачи через делегат (уравнение y = x^3)
        {
            return x * x * x;
        }

        public static void SaveFunc(string fileName, double a, double b, double h, Func F)
        {
            FileStream fs = new FileStream(fileName, FileMode.Create, FileAccess.Write);
            BinaryWriter bw = new BinaryWriter(fs);
            double x = a;
            while (x <= b)
            {
                bw.Write(F(x));
                x = x + h;
            }
            bw.Close();
            fs.Close();
        }

        public static double Load(string fileName)
        {
            FileStream fs = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            BinaryReader bw = new BinaryReader(fs);
            double min = double.MaxValue;
            double d;
            for (int i = 0; i < fs.Length / sizeof(double); i++)
            {
                // Считываем значение и переходим к следующему
                d = bw.ReadDouble();
                if (d < min) min = d;
            }
            bw.Close();
            fs.Close();
            return min;
        }

        static void Main(string[] args)
        {
            List<Func> functions = new List<Func> { new Func(SinX), new Func(X2), new Func(X3) };

            Console.WriteLine("Введите номер функции для нахождения её минимума:\n0 - y=sin(x)\n1 - y=x^2\n2 - y=x^3\n-------------");
            Console.Write("Номер: ");
            int numberFunc = int.Parse(Console.ReadLine());

            do
            {
                if (numberFunc >= 0 && numberFunc <= 2)
                    break;
                else
                {
                    Console.Write("Неверное число! Введите целое число от 0 до 2: ");
                    numberFunc = int.Parse(Console.ReadLine());
                }
            }
            while (true);

            Console.Write("\nВведите отрезок для нахождения минимума функции (точки х1 и х2)\nx1: ");
            double x1 = double.Parse(Console.ReadLine());
            Console.Write("x2: ");
            double x2 = double.Parse(Console.ReadLine());

            SaveFunc("data.bin", x1, x2, 1, functions[numberFunc]);
            Console.WriteLine("Минимальное значение функции: {0:0.00}", Load("data.bin"));

            Console.ReadLine();
        }

    }
}
