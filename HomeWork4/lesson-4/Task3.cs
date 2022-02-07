using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*  Яковлев Олег. Урок 4.
    3.
    а) Дописать класс для работы с одномерным массивом. 
    Реализовать конструктор, создающий массив определенного размера и заполняющий массив числами от начального значения с заданным шагом. 
    Создать свойство Sum, которое возвращает сумму элементов массива, 
    метод Inverse, возвращающий новый массив с измененными знаками у всех элементов массива (старый массив, остается без изменений), 
    метод Multi, умножающий каждый элемент массива на определённое число, 
    свойство MaxCount, возвращающее количество максимальных элементов.
*/

namespace lesson_4
{
    public class OneDimArray
    {
        #region Поля

        private int[] arr;

        #endregion

        #region Свойства

        public int this[int index]
        {
            get
            {
                return arr[index];
            }

            set
            {
                arr[index] = value;
            }
        }

        /// <summary>
        /// Свойство возвращает сумму элементов массива
        /// </summary>
        public int Sum
        {
            get 
            { 
                int s = 0;
                for (int i = 0; i < arr.Length; i++)
                {
                    s = s + arr[i];
                }
                return s; 
            }
        }

        /// <summary>
        /// Свойство возвращает количество максимальных элементов массива
        /// </summary>
        public int MaxCount
        {
            get
            {
                int max = arr[0];
                int count = 1;

                for (int i = 1; i < arr.Length; i++)
                {
                    if (arr[i] > max)
                    {
                        max = arr[i];
                        count = 1;
                    }
                    else if (arr[i] == max)
                    {
                        count++;
                    }
                }
                return count;
            }
        }

        #endregion

        #region Конструкторы

        public OneDimArray(int[] arr)
        {
            this.arr = arr;
        }

        /// <summary>
        /// Конструктор, создающий массив определенного размера и заполняющий массив числами от начального значения с заданным шагом.
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="Amount">Количество элементов массива</param>
        /// <param name="a">Начальное значение</param>
        /// <param name="step">Шаг</param>
        public OneDimArray(int Amount, int a, int step )
        {

            arr = new int[Amount]; // инициализация кол-ва элементов массива

            for (int i = 0; i < Amount; i++)
            {
                arr[i] = a + step * i;

                Console.Write($"{arr[i]}\t");
            }
            Console.WriteLine();
        }

        #endregion


        #region Публичные методы 

        public int GetElement(int index)
        {
            return arr[index];
        }

        public void SetElement(int index, int value)
        {
            arr[index] = value;
        }

        /// <summary>
        /// Метод вывода массива
        /// </summary>
        public void PrintArray()
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write($"{arr[i]}\t");
            }
                Console.WriteLine();
        }

        /// <summary>
        /// Метод меняющий знаки элементов массива (передаёт значения в новый массив)
        /// </summary>
        public void Inverse()
        {
            int[] arr1 = new int[arr.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                arr1[i] = arr[i] * -1;
                Console.Write($"{arr1[i]}\t");
            }
            Console.WriteLine();
        }

        /// <summary>
        /// Метод, умножающий каждый элемент массива на определённое число
        /// </summary>
        /// <param name="n"></param>
        public void Multi(int n)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = arr[i] * n;
                Console.Write($"{arr[i]}\t");
            }
            Console.WriteLine();
        }

        #endregion

    }

    internal class Task3
    {
        static void Main(string[] args)
        {
            Console.Write("Введите кол-во элементов массива: ");
            int Amount = int.Parse(Console.ReadLine());

            Console.Write("Введите значение первого элемента массива: ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("Введите значение шага, с которым будет заполнен массив: ");
            int step = int.Parse(Console.ReadLine());

            OneDimArray array01 = new OneDimArray(Amount, a, step);

            Console.WriteLine("Сумма элементов массива = " + array01.Sum);

            Console.WriteLine("\nМассив с измененными знаками у всех элементов массива (старый массив без изменений): ");
            array01.Inverse();

            Console.Write("\nДля демонстрации метода Multi (умножающего каждый элемент массива на определённое число) введите число: ");
            int n = int.Parse(Console.ReadLine());

            array01.Multi(n);

            Console.WriteLine("Количество максимальных элементов в массиве = " + array01.MaxCount);

            Console.ReadLine();
        }
    }
}
