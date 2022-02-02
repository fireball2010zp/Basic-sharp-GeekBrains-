using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

        /* Яковлев Олег. Урок 3.
            2. С клавиатуры вводятся числа, пока не будет введён 0 (каждое число в новой строке). Требуется подсчитать сумму всех нечётных положительных чисел. 
            Сами числа и сумму вывести на экран, используя tryParse.
        */

namespace lesson_3
{
    internal class Task2
    {

		static void Main(string[] args)
        {
			Console.Title = "Яковлев Олег. Задание 2"; // Заголовок консоли

			int s = 0; // объявили и обнулили переменную для подсчета суммы нечетных положительных чисел
			int n; // инициализация переменной n

			do
			{
				Console.Write("Введите число: ");
				if (int.TryParse(Console.ReadLine(), out n))
				{
					Console.WriteLine("Вы ввели число: " + n);
					if (isOdd(n) & n > 0) // проверка числа на нечетность и положительность
					{
						s = s + n; // подсчет суммы нечетных положительных чисел при каждой итерации 
					}
				}
				else
				{
					Console.WriteLine("Вы ввели некорректное число. Завершение работы приложения ...");
				}
				
			}
			while (n != 0); // постусловие - остановка цикла при вводе 0 или false от TryParse

			Console.Write("Сумма всех нечетных положительных введенных выше чисел = {0}\n", s); // вывод суммы всех нечетных положительных чисел

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
