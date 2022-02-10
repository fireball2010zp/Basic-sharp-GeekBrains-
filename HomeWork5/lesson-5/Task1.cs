using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

/* Яковлев Олег. Урок 5.
 1. Создать программу, которая будет проверять корректность ввода логина. 
    Корректным логином будет строка от 2 до 10 символов, содержащая только буквы латинского алфавита или цифры, при этом цифра не может быть первой:
    а) без использования регулярных выражений;
    б) **с использованием регулярных выражений.
*/

namespace lesson_5
{
    internal class Task1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Проверка логина на корректность (БЕЗ использования регулярных выражений)");
            Console.WriteLine("=======================================================================");
            Console.WriteLine("(Должны быть соблюдены следующие условия:\n- длина логина от 2 до 10 символов;\n- логин содержит только буквы латинского алфавита или цифры\n- в логине цифра не может быть первой)");

            do
            {
                Console.Write("\nВведите логин: ");
                string login = Console.ReadLine();
                Console.WriteLine("");

                if (isCorrect(login)) 
                {
                    Console.WriteLine("Логин корректен!");
                    break;
                }
                else
                {
                    Console.WriteLine("Логин не корректен!");
                }

            } while (true);

            Console.ReadLine();

            Console.Clear();

            Console.WriteLine("Проверка логина на корректность (С использованием регулярных выражений)");
            Console.WriteLine("=======================================================================");
            Console.WriteLine("(Должны быть соблюдены следующие условия:\n- длина логина от 2 до 10 символов;\n- логин содержит только буквы латинского алфавита или цифры\n- в логине цифра не может быть первой)");

            do
            {
                Console.Write("\nВведите логин: ");
                string login = Console.ReadLine();
                Console.WriteLine("");

                Regex regexLogin = new Regex("^[A-Za-z]{1}[A-Za-z0-9]{1,9}$");

                if (regexLogin.IsMatch(login))
                {
                    Console.WriteLine("Логин корректен!");
                    break;
                }
                else
                {
                    Console.WriteLine("Логин не корректен!");
                }

            } while (true);

            Console.ReadLine();
        }

        /// <summary>
        ////Метод проверки логина на корректность
        /// </summary>
        /// <param name="login"></param>
        /// <returns></returns>
        static bool isCorrect(string login)
        {
            for (int i = 0; i < login.Length; i++)
            {
                if ( login.All(isLatinNum) && isLength(login) && char.IsLetter(login[0]) )
                {
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// Метод проверки длины логина
        /// </summary>
        /// <param name="login"></param>
        /// <returns></returns>
        static bool isLength(string login)
        {
            if (login.Length < 2 || login.Length > 10) 
                return false;
            return true;
        }

        /// <summary>
        /// Метод проверки латиницы и цифр
        /// </summary>
        /// <param name="letter"></param>
        /// <returns></returns>
        static bool isLatinNum(char let)
        {
            int n = let;

            if ( (n >= 65 && n <= 90) || (n >= 97 && n <= 122) || (n >= 48 && n <= 57))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
