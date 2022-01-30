using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson_2
{
    internal class Task4
    {
        static void Main(string[] args)
        {
            Console.Title = "Яковлев Олег. Задание 4"; // Заголовок консоли

            /*
            4. Реализовать метод проверки логина и пароля. На вход метода подается логин и пароль. 
            На выходе истина, если прошел авторизацию, и ложь, если не прошел (Логин: root, Password: GeekBrains). 
            Используя метод проверки логина и пароля, написать программу: пользователь вводит логин и пароль, программа пропускает его дальше или не пропускает. 
            С помощью цикла do while ограничить ввод пароля тремя попытками.
            */

            Console.WriteLine("ВХОД В СИСТЕМУ\nВведите логин и пароль для авторизации!\n====================================\n");

            int i = 0;

            do
            {
                Console.Write("Логин: ");
                string login = Console.ReadLine();  // вводим логин

                Console.Write("Пароль: ");
                string password = Console.ReadLine();  // вводим пароль

                i++;  // запускаем отсчет попыток входа

                if (Access(login, password)) 
                {
                    Console.WriteLine("Добро пожаловать в личный кабинет!\n"); // вывод приветствия при возвращении true метода Access
                    break; // выход из цикла
                }
                else
                {
                    if (i == 3)
                    {
                        Console.WriteLine("Неверный логин и/или пароль! Вы использовали 3 попытки авторизации, попробуйте авторизоваться через время!\n"); // вывод сообщения о трёх неудачных попытках входа
                        break; // выход из цикла
                    }

                    Console.WriteLine("Неверный логин и/или пароль! Попробуйте ещё раз пожалуйста!\n"); // вывод сообщения о неудачной попытке входа при возвращении false метода Access
                }

            } while (i < 3);

            Console.ReadLine();
        }

        /// <summary>
        /// Проверка логина и пароля
        /// </summary>
        /// <param name="login">Логин</param>
        /// <param name="password">Пароль</param>
        /// <returns>Истина (при совпадении) или ложь (при несовпадении)</returns>
        static bool Access(string login, string password)
        {

            if (login == "root" && password == "GeekBrains")
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