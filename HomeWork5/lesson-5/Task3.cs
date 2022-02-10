using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    /* Яковлев Олег. Урок 5.
    3. * Для двух строк написать метод, определяющий, является ли одна строка перестановкой другой.
        Например: badc являются перестановкой abcd.
    */

namespace lesson_5
{
    internal class Task3
    {

        /// <summary>
        /// Метод сравнения частотных массивов
        /// </summary>
        /// <param name="s1"></param>
        /// <param name="s2"></param>
        /// <returns></returns>
        public static bool FreqComparison(string s1, string s2)
        {
            if (FreqArr(s1) == FreqArr(s2))
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// Метод подсчета частоты символов
        /// </summary>
        /// <param name="s">Латинские буквы в нижнем регистре</param>
        /// <returns>Частотный массив (буква + частота вхождения) в виде строки в алфавитном порядке</returns>
        public static string FreqArr(string s)
        {
            int[] count = new int[26]; // частный случай: только латинские буквы в нижнем регистре
            int i, k, kA;
            char c;
            kA = (int)('a');  // сохранение кода буквы 'a'

            s = s + '.';
            i = 0;

            do
            {
                c = s[i];   // сохранение текущего символа
                k = (int)c; // получаем код символа

                if (c >= 'a' && c <= 'z') // если символ - маленькая буква
                {
                    count[k - kA]++;
                }
                i++; // увеличение частоты вхождения буквы в частотном массиве
            }
            while (c != '.');

            string result = "";

            for (i = 0; i < 26; i++)
                if (count[i] > 0)
                {
                    result = result + (char)(kA + i) + count[i] + " "; // собираем в строку частотный массив в алфавитном порядке
                }
            return result;

        }


        static void Main(string[] args)
        {

            Console.Write("Введите 1-ю строку (только латинские буквы в нижнем регистре):");
            string s1 = Console.ReadLine();

            Console.Write("Частотный массив 1-й строки: ");
            Console.WriteLine(FreqArr(s1));
            

            Console.Write("\nВведите 2-ю строку (только латинские буквы в нижнем регистре):");
            string s2 = Console.ReadLine();

            Console.Write("Частотный массив 2-й строки: ");
            Console.WriteLine(FreqArr(s2));

            if (s1 == s2)
            {
                Console.Write("\nСтрока " + s2 + " является копией строки " + s1);
            }
            else
            {
                if (FreqComparison(s1, s2))
                {
                    Console.Write("\nСтрока " + s2 + " является строкой перестановкой строки " + s1);
                }
                else
                {
                    Console.Write("\nСтрока " + s2 + " не является строкой перестановкой строки " + s1);
                }
            }
            Console.ReadLine();
        }

        
    }
}
