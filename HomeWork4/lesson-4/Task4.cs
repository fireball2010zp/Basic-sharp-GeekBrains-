using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

    /* Яковлев Олег. Урок 4.
        4. Решить задачу с логинами из урока 2, только логины и пароли считать из файла в массив. 
        Создайте структуру Account, содержащую Login и Password.
    */

namespace lesson_4
{
    /// <summary>
    /// Логин и пароль
    /// </summary>
    struct Account
    {
        private string[] arr;
        
        public Account(string fileName)
        {
            string[] arr = new string[2];
            this.arr = arr;
            this.arr = LoadArrayFromFile(fileName);
        }

        private string[] LoadArrayFromFile(string fileName) // метод загрузки из файла
        {
            if (!File.Exists(fileName)) // проверка наличия файла
                return null;

            string[] arr = new string[2];
            int counter = 0;

            StreamReader sr = new StreamReader(fileName); // вспомогательный класс, устанавливает связь между программой и внешним ресурсом (текстовым файлом)

            while (!sr.EndOfStream) // свойство, работает только на чтение, возвращает булевое значение (достигли ли конца файла?)
            {
                string word = sr.ReadLine();
                arr[counter] = word;
                counter++; // при выходе из цикла counter будет содержать актуальное кол-во эл-тов
            }

            string[] buf = new string[counter]; // создание нового массива соразмерного массиву считанному из файла

            Array.Copy(arr, buf, counter); // метод позволяет скопировать эл-ты одного массива в эл-ты другого массива (откуда, куда, кол-во элементов)

            sr.Close(); // закрываем класс StreamReader через метод Close
            return buf;
        }

        /// <summary>
        /// Метод вывода массива
        /// </summary>
        public void PrintArray()
        {
            if (arr == null) // проверка наличия файла с метода LoadArrayFromFile
            {
                Console.WriteLine("\nТекстовый файл не найден на диске! Проверьте пусть/имя файла!");
            }
            else
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    Console.Write($"{arr[i]}\t");
                }
                Console.WriteLine();
            }
        }

        /// <summary>
        ////Метод проверки логина и пароля 
        /// </summary>
        /// <param name="login"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public bool Access(string login, string password)
        {

            if (login == arr[0] & password == arr[1])
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }

    internal class Task4
    {
        static void Main(string[] args)
        {
            Account array01 = new Account(AppDomain.CurrentDomain.BaseDirectory + "Access.txt"); // обяъвление и инициализация массива array01 (считываем логин и пароль из файла в массив)

            Console.WriteLine("ВХОД В СИСТЕМУ\nВведите логин и пароль для авторизации!\n====================================");

            int i = 0;

            do
            {
                Console.Write("\nЛогин: ");
                string login = Console.ReadLine();  // вводим логин

                Console.Write("Пароль: ");
                string password = Console.ReadLine();  // вводим пароль

                i++;  // запускаем отсчет попыток входа

                if (array01.Access(login, password))
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

                    Console.WriteLine("Неверный логин и/или пароль! Попробуйте ещё раз пожалуйста!\nУ вас осталось попыток: " + (3-i)); // вывод сообщения о неудачной попытке входа при возвращении false метода Access
                }

            } while (i < 3);

            Console.ReadLine();

        }
    }
}
