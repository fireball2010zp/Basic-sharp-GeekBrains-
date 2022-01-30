using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson_2
{
    internal class Task6
    {
        static void Main(string[] args)
        {
            Console.Title = "Яковлев Олег. Задание 6"; // Заголовок консоли

            /*
            6. *Написать программу подсчета количества «хороших» чисел в диапазоне от 1 до 1 000 000 000. 
            «Хорошим» называется число, которое делится на сумму своих цифр. 
            Реализовать подсчёт времени выполнения программы, используя структуру DateTime.
            */


            Console.WriteLine("Подождите пока программа подсчитает количество \"хороших\" чисел в диапазоне от 1 до 1 000 000 000\n");

            DateTime start = DateTime.Now; // перед началом работы цикла сохраняем текущее время

            long amountGoodNumbers = 0; // объявляем переменную для подсчета суммы цифр числа

            for (long i = 1; i < 1000000000; i++)
            {
                if (GoodCheck(i))
                    amountGoodNumbers++; // при возвращении true с метода GoodCheck увеличиваем счетчик
            }

            Console.WriteLine("Программа выполнялась " + (DateTime.Now - start)); // по выходу из цикла вычитаем текущее время из сохранённого и выводим на экран

            Console.WriteLine("\nКоличество \"хороших\" чисел в интервале от 1 до 1 000 000 000 составило {0:N0} штук", amountGoodNumbers); // вывод количества «хороших» чисел

            Console.ReadLine();
        }

        /// <summary>
        /// Метод проверки «хороших» чисел
        /// </summary>
        /// <param name="i">Число типа long</param>
        /// <returns>Возврат true при делении числа и сумму цифр без остатка</returns>
        static bool GoodCheck(long i)
        {
            long temp = i;
            long amountNumbers = 0;
            while (temp > 0)
            {
                amountNumbers = amountNumbers + temp % 10;
                temp = temp / 10;
            }
            return i % amountNumbers == 0;
        }
    }
}