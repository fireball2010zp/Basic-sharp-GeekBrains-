using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson_2
{
    internal class Task3
    {
        static void Main(string[] args)
        {
			Console.Title = "Яковлев Олег. Задание 3"; // Заголовок консоли

			/*
            3. С клавиатуры вводятся числа, пока не будет введен 0. Подсчитать сумму всех нечетных положительных чисел.
            */

			int s = 0; // объявили и обнулили переменную для подсчета суммы нечетных положительных чисел
			int n; // инициализация переменной n

			do
            {
				Console.Write("Введите число: ");
				n = int.Parse(Console.ReadLine()); // вводим целое число (как положительное, так и отризательное)
				
				if (isOdd(n) & n > 0) // проверка числа на нечетность и положительность
					s = s + n; // подсчет суммы нечетных положительных чисел при каждой итерации 
			}
			while (n != 0); // постусловие - остановка цикла при вводе 0

			Console.Write("Сумма всех нечетных положительных введенных чисел составляет: {0}", s); // вывод суммы всех нечетных положительных чисел

			Console.ReadLine();
		}

		/// <summary>
		////Определение нечетности числа
		/// </summary>
		/// <param name="a">целое число типа int</param>
		/// <returns>true для нечётного числа</returns>
		static bool isOdd(int a)
		{
			return a % 2 != 0;
		}

	}
}