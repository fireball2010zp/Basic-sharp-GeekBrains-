using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Anketa
{
    /// <summary>
    /// Главный класс _1.Anketa.Program
    /// </summary>
    internal class Program
    {
        /// <summary>
        /// Точка входа в программу
        /// </summary>
        /// <param name="args">Строковые параметры</param>
        static void Main(string[] args)
        {
            Console.Title = "Яковлев Олег. Задание 1: Анкета"; // Заголовок консоли

            /*
            1. Написать программу «Анкета». Последовательно задаются вопросы (имя, фамилия, возраст, рост, вес). В результате вся информация выводится в одну строчку:
                а) используя склеивание;
                б) используя форматированный вывод;
                в) используя вывод со знаком $.
            */

            Console.WriteLine("Заполните анкету\n");

            Console.Write("Введите ваше имя: ");
            string firstName = Console.ReadLine(); // ввод имени

            Console.Write("Введите вашу фамилию: ");
            string lastName = Console.ReadLine(); // ввод фамилии

            Console.Write("Введите ваш возраст (полных лет): ");
            string age = Console.ReadLine(); // ввод возраста (только цифра)

            Console.Write("Введите ваш рост (в см): ");
            string height = Console.ReadLine(); // ввод роста (только цифра)

            Console.Write("Введите ваш вес (в кг): ");
            string weight = Console.ReadLine(); // ввод веса (только цифра)

            Console.WriteLine("\nВаши данные: " + firstName + " " + lastName + ", " + age + " лет, " + height + " см, " + weight + " кг"); // вывод склеиванием
            Console.WriteLine("Ваши данные: {0} {1}, {2} лет, {3} см, {4} кг", firstName, lastName, age, height, weight); // форматированный вывод
            Console.WriteLine($"Ваши данные: {firstName} {lastName}, {age} лет, {height} см, {weight} кг"); // вывод со знаком $

            Console.ReadLine(); 

        }
    }
}
