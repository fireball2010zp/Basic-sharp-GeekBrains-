using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    /*  Яковлев Олег. Урок 4.
     2. Реализуйте задачу 1 в виде статического класса StaticClass;
        а) Класс должен содержать статический метод, который принимает на вход массив и решает задачу 1;
        б) Добавьте статический метод для считывания массива из текстового файла. Метод должен возвращать массив целых чисел;
        в)* Добавьте обработку ситуации отсутствия файла на диске.
    */


namespace lesson_4
{

    public class StaticClass
    {
        #region Поля

        private int[] arr;

        #endregion

        #region Свойства

        public int this[int index] // индексное свойство
        {
            get // вернуть значение
            {
                return arr[index];
            }

            set // задать значение
            {
                arr[index] = value;
            }
        }

        #endregion

        #region Конструкторы

        public StaticClass(int[] arr) //передача по цепочке массива как параметра
        {
            this.arr = arr; // инициализация текущего поля 
        }

        public StaticClass(string fileName)
        {
            arr = LoadArrayFromFile(fileName);
        }

        #endregion

        #region Скрытые методы 

        private int[] LoadArrayFromFile(string fileName) // метод загрузки из файла
        {
            if (!File.Exists(fileName)) // проверка наличия файла
                return null;

            int[] arr = new int[1000];
            int counter = 0;

            StreamReader sr = new StreamReader(fileName); // вспомогательный класс, устанавливает связь между программой и внешним ресурсом (текстовым файлом)

            while (!sr.EndOfStream) // свойство, работает только на чтение, возвращает булевое значение (достигли ли конца файла?)
            {
                int number = int.Parse(sr.ReadLine());
                arr[counter] = number;
                counter++; // при выходе из цикла counter будет содержать актуальное кол-во эл-тов
            } 

            int[] buf = new int[counter]; // создание нового массива соразмерного массиву считанному из файла

            Array.Copy(arr, buf, counter); // метод позволяет скопировать эл-ты одного массива в эл-ты другого массива (откуда, куда, кол-во элементов)

            sr.Close(); // закрываем класс StreamReader через метод Close
            return buf;
        }

        #endregion

        #region Публичные методы 

        /// <summary>
        /// Метод для доступа к чтению массива
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public int GetElement(int index) 
        {
            return arr[index]; // возврат элемента массива по индексу
        }

        /// <summary>
        /// Метод для задания значения
        /// </summary>
        /// <param name="index"></param>
        /// <param name="value"></param>
        public void SetElement(int index, int value)
        {
            arr[index] = value;
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
        /// Метод подсчета пар в массиве, в которых только одно число делится на 3
        /// </summary>
        public void AmountPairs() 
        {
            int sum = 0; // объявление и инициализация счетчика по подсчету количества пар элементов массива, в которых только одно число делится на 3

            for (int i = 0; i < (arr.Length - 1); i++) // цикл с проверкой пар в массиве, в которых только одно число делится на 3 без остатка 
            {
                if (((arr[i] % 3 != 0) & (arr[i + 1] % 3 == 0)) | ((arr[i] % 3 == 0) & (arr[i + 1] % 3 != 0))) // в обоих позициях: 1-0 и 0-1
                {
                    sum++;
                }
            }
            Console.WriteLine("\nКоличество пар элементов массива, в которых только одно число делится на 3 = " + sum);
        }

        #endregion

    }

    public class Task2
    {
        static void Main(string[] args)
        {

            int[] array01 = new int[20]; // объявление массива, размерность 20

            Random random = new Random(); // объявили переменную random типа Random, псевдокласс позволяет генерить числа в заданном диапазоне

            for (int i = 0; i < 20; i++)
            {
                array01[i] = random.Next(-10000, 10001); // задана рандомная генерация (от -10000 включительно до 10000 включительно) для 20-ти эл-в
            }

            StaticClass StaticClass = new StaticClass(array01);

            StaticClass.PrintArray(); // вывод массива через метод PrintArray

            StaticClass.AmountPairs(); // подсчет пар в массиве, в которых только одно число делится на 3 + вывод результата через метод AmountPairs


            Console.WriteLine("\n===========================================================================");
            Console.WriteLine("\nДемонстрация статического метода для считывания массива из текстового файла");

            StaticClass array02 = new StaticClass(AppDomain.CurrentDomain.BaseDirectory + "ArrayFile.txt"); // обяъвление и инициализация массива array02 
            // класс AppDomain для работы с относительными адресами файлов + свойства CurrentDomain и BaseDirectory (возвращают текущую директорию программы)

            array02.PrintArray(); // вывод массива из текстового файла через метод PrintArray

            Console.WriteLine("\n===========================================================================");
            Console.WriteLine("\nПопытка считывания массива из несуществующего текстового файла");
            StaticClass array03 = new StaticClass(AppDomain.CurrentDomain.BaseDirectory + "ArrayFile1.txt");

            array03.PrintArray();


            Console.ReadLine();

        }
    }
}
