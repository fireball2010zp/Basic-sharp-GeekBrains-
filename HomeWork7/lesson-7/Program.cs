using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lesson_7
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            // класс Application позволяет запускать формы в приложении
            // метод EnableVisualStyles позволяет применить к элементам формы
            // визуальные стили, которые присущи той операционной системе,
            // под которой запускается наше приложение

            Application.SetCompatibleTextRenderingDefault(false);
            // метод SetCompatibleTextRenderingDefault - для совместимости
            // нашего приложения с .Net Framework 2.0

            Application.Run(new Main());
            // запуск новой формы на выполнение
            // когда запускается процесс, метод Main запускается главным потоком,
            // с которым работает точка входа, этот метод (Run) ожидает пока отработает
            // второстепенный поток (например с формой) и только потом завершится сам

        }
    }
}