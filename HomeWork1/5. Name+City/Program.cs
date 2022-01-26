using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.Name_City
{
    /// <summary>
    /// Главный класс _5.Name_City.Program
    /// </summary>
    internal class Program
    {
        /// <summary>
        /// Точка входа в программу
        /// </summary>
        /// <param name="args">Строковые параметры</param>
        static void Main(string[] args)
        {
            Console.Title = "Яковлев Олег. Задание 5: Вывод на экран ФИО + город"; // Заголовок консоли

            /*
            а) Написать программу, которая выводит на экран ваше имя, фамилию и город проживания.
            б) Сделать задание, только вывод организовать в центре экрана.
            в) *Сделать задание б с использованием собственных методов (например, Print(string ms, int x,int y).
            */

            string myName = "Яковлев Олег"; // присваиваем переменной myName фамилию и имя
            string myCity = "Запорожье"; // присваиваем переменной myCity город проживания

            Console.SetCursorPosition(50, 14); // устанавливаем положение курсора по средине консоли
            Console.WriteLine(myName); // выводим значение переменной myName

            Console.SetCursorPosition(50, 15); // устанавливаем положение курсора по средине консоли, но на строку ниже
            Console.WriteLine(myCity); // выводим значение переменной myCity

            Console.ReadLine();

        }
    }
}
