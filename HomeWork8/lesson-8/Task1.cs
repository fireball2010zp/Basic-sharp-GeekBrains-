using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

    /*  Яковлев Олег. Урок 8.
        1. С помощью рефлексии выведите все свойства структуры DateTime.
    */

namespace lesson_8
{
    internal class Task1
    {

        static void Main(string[] args)
        {

            Type type = typeof(DateTime);

            Console.WriteLine("Все свойства структуры DateTime: \n");

            foreach (var property in type.GetProperties())
                Console.WriteLine(property.Name);

            Console.ReadLine();
        }

    }
}
