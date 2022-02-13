using System;
using System.Collections;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    /* Яковлев Олег. Урок 6.
    3. Переделать программу Пример использования коллекций для решения следующих задач:
        а) Подсчитать количество студентов учащихся на 5 и 6 курсах;
        б) подсчитать сколько студентов в возрасте от 18 до 20 лет на каком курсе учатся (*частотный массив);
        в) отсортировать список по возрасту студента;
        г) *отсортировать список по курсу и возрасту студента;
    */

namespace lesson_6
{
    class Student
    {
        public string firstName { get; set; }
        public string secondName { get; set; }
        public string university { get; set; }
        public string faculty { get; set; }
        public string department { get; set; }
        public int age { get; set; }
        public int course { get; set; }
        public int group { get; set; }
        public string city { get; set; }
        
        public Student(string firstName, string secondName, string university, string faculty, string department, int age, int course, int group, string city)
        {
            this.firstName = firstName;
            this.secondName = secondName;
            this.university = university;
            this.faculty = faculty;
            this.department = department;
            this.age = age;
            this.course = course;
            this.group = group;
            this.city = city;
        }
    }

    internal class Task3
    {

        static void Main(string[] args)
        {

            List<Student> list = new List<Student>();

            Dictionary<int, int> cousreAmount = new Dictionary<int, int>();

            StreamReader sr = new StreamReader(AppDomain.CurrentDomain.BaseDirectory + "students.csv");

            int fifthCourse = 0;
            int sixthCourse = 0;
            int sumAge = 0;

            while (!sr.EndOfStream)
            {
                try
                {
                    string[] s = sr.ReadLine().Split(';');

                    // добавление в список нового экземпляра класса Student
                    list.Add(new Student(s[0], s[1], s[2], s[3], s[4], int.Parse(s[5]), int.Parse(s[6]), int.Parse(s[7]), s[8]));

                    // подсчет количества студентов 5 и 6 курсов
                    if (int.Parse(s[6]) == 5)
                    {
                        fifthCourse++;
                    }
                    else if (int.Parse(s[6]) == 6)
                    {
                        sixthCourse++;
                    }

                    // подсчет студентов в возрасте от 18 до 20 лет на каком курсе учатся
                    if (int.Parse(s[5]) > 17 && int.Parse(s[5]) < 21)
                    {
                        sumAge++;
                        if (cousreAmount.ContainsKey(int.Parse(s[6])))
                        {
                            cousreAmount[int.Parse(s[6])] = cousreAmount[int.Parse(s[6])] + 1;
                        }
                        else
                        {
                            cousreAmount.Add(int.Parse(s[6]), 1);
                        }
                    }
                }
                catch
                {
                }
            }
            sr.Close();

            Console.WriteLine("Количество студентов на 5 и 6 курсах:");
            Console.WriteLine("5 курс: {0}", fifthCourse);
            Console.WriteLine("6 курс: {0}", sixthCourse);

            Console.WriteLine("\nКоличество студентов в возрасте от 18 до 20 лет: " + sumAge + "\nНа каких курсах учатся:");
            ICollection<int> keys = cousreAmount.Keys;
            foreach (int key in keys)
            {
                Console.WriteLine("{0} курс - {1} студент(ов)", key, cousreAmount[key]);
            }

            Console.WriteLine("\nОтсортированный список студентов по возрасту:");
            list.Sort(new Comparison<Student>(CompareAge));
            foreach (var a in list)
            {
                Console.WriteLine($"{a.firstName} {a.secondName} - {a.age}");
            }

            Console.WriteLine("\nОтсортированный список студентов по курсу и возрасту: ");
            list.Sort(new Comparison<Student>(CompareAgeCource));
            foreach (var a in list)
            {
                Console.WriteLine($"{a.firstName} {a.secondName}, {a.course} курс, возраст: {a.age}");
            }

            Console.ReadLine();
        }

        static int CompareAge(Student s1, Student s2)
        {
            return String.Compare(s1.age.ToString(), s2.age.ToString());
        }

        static int CompareAgeCource(Student s1, Student s2)
        {
            if (s1.age > s2.age)
                return 1;

            if (s1.age < s2.age)
                return -1;

            if (s1.course > s2.course)
                return 1;

            if (s1.course < s2.course)
                return -1;

            return 0;
        }

    }
}
