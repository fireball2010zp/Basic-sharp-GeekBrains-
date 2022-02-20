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
    3.
    а) Создать приложение, показанное на уроке, добавив в него защиту от возможных ошибок 
    (не создана база данных, обращение к несуществующему вопросу, открытие слишком большого файла и т.д.).
    б) Изменить интерфейс программы, увеличив шрифт, поменяв цвет элементов и добавив другие 
    «косметические» улучшения на свое усмотрение.
    в) Добавить в приложение меню «О программе» с информацией о программе (автор, версия, авторские права и др.).
    г)* Добавить пункт меню Save As, в котором можно выбрать имя для сохранения базы данных (элемент SaveFileDialog).
*/


namespace lesson_8._3
{
    public partial class Main : Form
    {
        private TrueFalse database;

        public Main()
        {
            InitializeComponent();
        }

        private void menuItemExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void menuItemNew_Click(object sender, EventArgs e)
        {
            SaveFileDialog dlg = new SaveFileDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                database = new TrueFalse(dlg.FileName);
                database.Add("Замля круглая?", true);
                database.Save();
                nudNumber.Minimum = 1;
                nudNumber.Maximum = 1;
                nudNumber.Value = 1;
            }
        }

        private void menuItemOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                database = new TrueFalse(dlg.FileName);
                database.Load();
                nudNumber.Minimum = 1;
                nudNumber.Maximum = database.Count;
                nudNumber.Value = 1;
            }
        }

        private void menuItemSave_Click(object sender, EventArgs e)
        {
            try
            {
                database.Save();
            }
            catch(NullReferenceException)
            {
                MessageBox.Show("Для записи списка вопросов сначала загрузите или создайте список!",
                    "Список вопросов для записи в файл не обнаружен!",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void menuItemSaveAs_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog dlg = new SaveFileDialog();
                if (dlg.ShowDialog() == DialogResult.Cancel)
                        return;

                if (database == null)
                {
                    database = new TrueFalse(dlg.FileName);
                    database.Add("#n", true);
                    database.Save();
                    nudNumber.Minimum = 1;
                    nudNumber.Maximum = 1;
                    nudNumber.Value = 1;

                    MessageBox.Show("Список вопросов сохранён в файл!", "Уведомление",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    database.fileName = dlg.FileName;
                    database.Save();

                    MessageBox.Show("Список вопросов сохранён в файл!", "Уведомление",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Для записи списка вопросов сначала загрузите или создайте список!",
                    "Список вопросов для записи в файл не обнаружен!",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void nudNumber_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                tbQuestion.Text = database[(int)nudNumber.Value - 1].Text;
                cbTrue.Checked = database[(int)nudNumber.Value - 1].TrueFalse;
            }
            catch(NullReferenceException)
            {
                MessageBox.Show("Для перебора вопросов сначала загрузите список!",
                    "Список вопросов не обнаружен!",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                database.Add($"#{database.Count + 1}", true);
                nudNumber.Maximum = database.Count;
                nudNumber.Value = database.Count;
            }
            catch(NullReferenceException)
            {
                MessageBox.Show("Для добавления нового вопроса создайте базу данных!", 
                    "Не возможно добавить новый вопрос!",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                database.Remove((int)nudNumber.Value - 1);
                nudNumber.Maximum--;
                nudNumber.Value--;
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Для удаления вопроса из списка сначала загрузите или создайте список вопросов!",
                    "Не возможно удалить вопрос!",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                database[(int)nudNumber.Value - 1].Text = tbQuestion.Text;
                database[(int)nudNumber.Value - 1].TrueFalse = cbTrue.Checked;

            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Для сохранения изменения вопроса сначала загрузите или создайте список и выберите нужный вопрос!",
                   "Не возможно сохранить вопрос!",
                   MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void tlAboutProgram_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Автор: Яковлев Олег\nВерсия: 1.2.3\nВсе права защищены!\n22.02.2022",
                "О программе",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
