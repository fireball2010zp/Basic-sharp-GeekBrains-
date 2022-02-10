using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    /* Яковлев Олег. Урок 5.
        2. Разработать статический класс Message, содержащий следующие статические методы для обработки текста:
            а) Вывести только те слова сообщения, которые содержат не более n букв.
            б) Удалить из сообщения все слова, которые заканчиваются на заданный символ.
            в) Найти самое длинное слово сообщения.
            г) Сформировать строку с помощью StringBuilder из самых длинных слов сообщения.
    */

namespace lesson_5
{
    internal class Task2
    {
        class Message
        {
            private static string[] separators = { ",", ".", "!", "?", ";", ":", " " };

            /// <summary>
            /// Вывод только тех слов сообщения, которые содержат не более n букв.
            /// </summary>
            /// <param name="message"></param>
            /// <param name="n"></param>
            public static void PrintWords(string message, int n)
            {
                string[] words = message.Split(separators, StringSplitOptions.RemoveEmptyEntries);

                for (int i = 0; i < words.Length; i++) // проходимся по всем словам
                {
                    if (words[i].Length <= n) // условие: не более n сим в слове
                    {
                        Console.WriteLine(words[i]);
                    }
                }
            }

            /// <summary>
            /// Удаление из сообщения всех слов, которые заканчиваются на заданный символ.
            /// </summary>
            /// <param name="message"></param>
            /// <param name="n"></param>
            public static void DeleteWords(string message, char n)
            {
                string[] words = message.Split(separators, StringSplitOptions.RemoveEmptyEntries);

                for (int i = 0; i < words.Length; i++)
                {
                    if (words[i][words[i].Length - 1] == n)
                    {
                        words[i] = "";
                    }
                    Console.Write(words[i] + " ");
                }
            }

            /// <summary>
            /// Определение самого длинного слова сообщения
            /// </summary>
            /// <param name="message"></param>
            public static string MaxWord(string message)
            {
                string[] words = message.Split(separators, StringSplitOptions.RemoveEmptyEntries);

                string maxWord = words[0];

                int max = words[0].Length;

                for (int i = 1; i < words.Length; i++)
                {
                    if (words[i].Length > max)
                    {
                        max = words[i].Length;
                        maxWord = words[i];
                    }
                }
                return maxWord;
            }

            /// <summary>
            /// Вывод самых длинных слов сообщения (через StringBuilder)
            /// </summary>
            /// <param name="message"></param>
            public static void AllMaxWords(string message)
            {
                string[] words = message.Split(separators, StringSplitOptions.RemoveEmptyEntries);

                StringBuilder sb = new StringBuilder();

                int max = Message.MaxWord(message).Length;

                for (int i = 0; i < words.Length; i++)
                {
                    if (words[i].Length == max)
                    {
                        sb.Append(words[i] + " ");
                    }
                }
                Console.Write(sb);
            }

        }

        static void Main(string[] args)
        {
            string message = "Минувшие эпохи в развитии животного мира Земли и древних народов изображались автором с художественной зримостью, познавательный материал вплетён в увлекательный сюжет.";

            Console.WriteLine("Дано следующее сообщение: \"Минувшие эпохи в развитии животного мира Земли и древних народов изображались автором с художественной зримостью, познавательный материал вплетён в увлекательный сюжет.\"");

            Console.Write("\nВывод только тех слов сообщения, которые содержат не более определённого количества букв.\nВведите число: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Message.PrintWords(message, n);

            Console.Write("\nВведите символ, на который заканчиваются слова для удаления их из строки: ");
            char endLetter = char.Parse(Console.ReadLine());
            Console.WriteLine();
            Message.DeleteWords(message, endLetter);

            Console.Write("\n\nCамое длинное слово сообщения: " + Message.MaxWord(message));

            Console.Write("\n\nCамые длинные слова в сообщении: ");
            Message.AllMaxWords(message);

            Console.ReadLine();
        }

    }
}
