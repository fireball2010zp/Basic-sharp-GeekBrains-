using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*  Яковлев Олег. Урок 8.
    2. Создайте простую форму на которой свяжите свойство Text элемента TextBox со свойством Value элемента NumericUpDown.
*/

namespace lesson_8._2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                numericUpDown.Value = int.Parse(textBox.Text);
            }
            catch
            {
                MessageBox.Show("Вводите только целые числа!\n(от -2147483648 до 2147483647)", "NumericUpDown");
            }
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            textBox.Text = numericUpDown.Value.ToString();
        }
    }
}
