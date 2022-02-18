using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


    /* Яковлев Олег. Урок 7.
        2. Используя Windows Forms, разработать игру «Угадай число». 
           Компьютер загадывает число от 1 до 100, а человек пытается его угадать за минимальное число попыток. 
           Компьютер говорит, больше или меньше загаданное число введенного.
            a) Для ввода данных от человека используется элемент TextBox;
            б) **Реализовать отдельную форму c TextBox для ввода числа.
    */


namespace lesson_7._2_Guess
{
    public partial class Form1 : Form
    {
        private int computerNumber;
        private int stepsNumber;

        public int ComputerNumber { get { return this.computerNumber; } }
        public int StepsNumber { get { return this.stepsNumber; } }

        private Random random = new Random();

        public Form1()
        {
            InitializeComponent();
            Update();

        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            int userNumber = int.Parse(tbNumber.Text);
            CheckWin(userNumber);
        }

        public new void Update()
        {
            this.computerNumber = random.Next(1, 100);
        }
        
        public void CheckWin(int userNumber)
        {
            if (userNumber == this.computerNumber)
            {
                if (MessageBox.Show($"Поздравляем, вы угадали число за {this.stepsNumber} ходов! Желаете сыграть ещё раз?", "Угадай число",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    Update();
                    tbNumber.Clear();
                }
                else
                {
                    Close();
                }
            }
            else if (userNumber > this.computerNumber)
            {
                this.stepsNumber++;
                MessageBox.Show("Введённое число больше загаданного, попробуйте ещё раз!", "Угадай число",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                this.stepsNumber++;
                MessageBox.Show("Введённое число меньше загаданного, попробуйте ещё раз!", "Угадай число",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
