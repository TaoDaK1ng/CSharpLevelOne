using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lesson_7._2
{
    public partial class Form1 : Form
    {
        static Random r = new Random();
        int number = r.Next(1, 100), tryCount = 0, maxTryCount = 5;
        public Form1()
        {
            InitializeComponent();
            btnStep.Text = "Ход";
            lblTask.Text = "Угадайте число от 1 до 100";
            this.Text = "Угадай число";
        }

        private void btnStep_Click(object sender, EventArgs e)
        {
            tryCount++;

            if (int.Parse(textAnswer.Text) == number)
            {
                lblTask.Text = "Поздравляем, вы угадали!";
            }
            else if (tryCount >= maxTryCount)
            {
                lblTask.Text = $"Вы проиграли, правильный ответ: {number}";
                btnStep.Enabled = false;
                textAnswer.Enabled = false;
            }
            else if (int.Parse(textAnswer.Text) > number)
            {
                lblTask.Text = $"Вы ввели слишком большое число.\nКоличество оставшихся попыток = {maxTryCount - tryCount}\nПопробуйте еще раз. Введите число от 1 до 100";
            }
            else if (int.Parse(textAnswer.Text) < number)
            {
                lblTask.Text = $"Вы ввели слишком маленькое число.\nКоличество оставшихся попыток = {maxTryCount - tryCount}\nПопробуйте еще раз. Введите число от 1 до 100";
            }
        }
    }
}
