using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*  Яковлев Олег. Урок 7.
    1.
    а) Добавить в программу «Удвоитель» подсчёт количества отданных команд удвоителю.
    б) Добавить меню и команду «Играть». При нажатии появляется сообщение, какое число должен получить игрок. 
        Игрок должен получить это число за минимальное количество ходов.
    в) *Добавить кнопку «Отменить», которая отменяет последние ходы. 
        Используйте библиотечный обобщенный класс System.Collections.Generic.Stack<int>Stack.
        Вся логика игры должна быть реализована в классе с удвоителем.
*/


namespace lesson_7
{

    public delegate void Reverse();

    public partial class Main : Form
    {

        private Random random = new Random(); // объявление переменной для генерации чисел

        private int computerNumber; // переменная сгенерированная компьютером
        private int userNumber; // переменная получаемая пользователем
        public int stepsNumber; // счетчик кол-ва ходов

        Stack<Reverse> operations = new Stack<Reverse>();

        public int UserNumber { get { return this.userNumber; } }
        public int StepsNumber { get { return this.stepsNumber; } }
        public int ComputerNumber { get { return this.computerNumber; } }

        public Main()
        {
            InitializeComponent();
            
            userNumber = 0;
            stepsNumber = 0;
            computerNumber = 0;

            MessageBox.Show($"Для запуска игры выберите пункт Меню -> Играть или кнопку \"Новая игра\"", "Удвоитель",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // Метод обновляет число ходов
        private void Steps(int stepsNumber)
        {
            lbStepsNumber.Text = $"Количество ходов: {stepsNumber}";
        }

        // Метод обновляет только число пользователя (lbUserNumber)
        private void UpdateGameState(int userNumber)
        {
            lbUserNumber.Text = $"Текущее число: {userNumber}";
        }

        // Метод обновляет текущее значение элементов lbComputerNumber, lbUserNumber и lbStepsNumber
        private void UpdateGameState(int userNumber, int computerNumber, int stepsNumber)
        {
            UpdateGameState(userNumber); // обновляем текст поля userNumber
            this.computerNumber = computerNumber; // обновляем текущее значение computerNumber
            lbComputerNumber.Text = $"Получите число: {computerNumber}"; // обновляем текст поля computerNumber
            Steps(stepsNumber);
        }

        // Метод подписки на событие - клик по кнопке Новая игра
        private void btnReset_Click(object sender, EventArgs e)
        {
            userNumber = 0;
            stepsNumber = 0;
            UpdateGameState(userNumber, random.Next(1, 50), stepsNumber);
        }

        // Подписка на событие - клик по кнопке +1
        private void btnPlus_Click(object sender, EventArgs e)
        {
            //userNumber = userNumber + 1;
            UpdateGameState(++userNumber);
            Steps(++stepsNumber);
            CheckWin();
            operations.Push(new Reverse(Decrement)); // заносит элемент в стек Stack
        }

        // Подписка на событие - клик по кнопке *2
        private void btnMultiply_Click(object sender, EventArgs e)
        {
            // userNumber = userNumber * 2;
            UpdateGameState(userNumber *= 2);
            Steps(++stepsNumber);
            CheckWin();
            operations.Push(new Reverse(Divide)); // заносит элемент в стек Stack
        }

        // Метод декремента для отмены хода
        public void Decrement()
        {
            UpdateGameState(--userNumber);
            Steps(--stepsNumber);
        }

        // Метод деления на 2 для отмены хода
        public void Divide()
        {
            UpdateGameState(userNumber /= 2);
            Steps(--stepsNumber);
        }

        // Метод отмены действия
        public void Check()
        {
            Reverse reverse;
            if (operations.Count != 0) // проверка пустого стэка
            {
                reverse = operations.Pop(); // выполняет операцию, обратную последней
                reverse();
            }
            return;
        }

        // Проверка победы
        private void CheckWin()
        {
            if (computerNumber == userNumber)
            {
                MessageBox.Show($"Вы успешно завершили игру за {operations.Count} ходов", "Удвоитель",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (MessageBox.Show("Желаете сыграть еще раз?", "Удвоитель",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    userNumber = 0;
                    stepsNumber = 0;
                    UpdateGameState(userNumber, random.Next(1, 50), stepsNumber);
                }
                else
                {
                    Close();
                }
            }
        }

        // Подписка на событие - клик по кнопке в меню Играть
        private void MenuPlayItem_Click(object sender, EventArgs e)
        {
            UpdateGameState(userNumber, random.Next(1, 50), stepsNumber);
            MessageBox.Show($"Для успешного прохождения игры вы должны получить число {computerNumber} " +
                $"за минимальное количество ходов", "Удвоитель",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // Подписка на событие - клик по кнопке Отменить ход
        private void btnMoveBack_Click(object sender, EventArgs e)
        {
           Check();
        }
    }
    
}
