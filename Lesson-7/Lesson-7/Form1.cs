using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lesson_7
{
    //Чагалысов
    //Задание 1
    //а) Добавить в программу «Удвоитель» подсчёт количества отданных команд удвоителю.
    //б) Добавить меню и команду «Играть». При нажатии появляется сообщение, какое число должен получить игрок.Игрок должен получить это число за минимальное количество ходов.
    //в) * Добавить кнопку «Отменить», которая отменяет последние ходы.Используйте  библиотечный обобщенный класс System.Collections.Generic.Stack<int> Stack.

    public partial class Form1 : Form
    {
        static Random r = new Random();
        static int stepCount = 0, stepNumber = r.Next(2,10), victoryNumber = r.Next(1,10);
        public Form1()
        {
            InitializeComponent();
            btnCommand1.Text = "+1";
            btnCommand2.Text = "x2";
            btnReset.Text = "Сброс";
            lblNumber.Text = "0";
            lblTask.Text = $"Вы должны получить число {victoryNumber} за {stepNumber} ходов.";
            this.Text = "Удвоитель";
        }

        void Check()
        {
            if (stepCount == stepNumber)
            {
                lblTask.Text = "Вы проиграли!";
                btnCommand1.Enabled = false;
                btnCommand2.Enabled = false;
                btnReset.Enabled = false;
            }
            if (int.Parse(lblNumber.Text) == victoryNumber)
            {
                lblTask.Text = "Вы выиграли!";
                btnCommand1.Enabled = false;
                btnCommand2.Enabled = false;
                btnReset.Enabled = false;
            }
        }

        private void btnCommand1_Click(object sender, EventArgs e)
        {
            lblNumber.Text = (int.Parse(lblNumber.Text) + 1).ToString();
            stepCount++;
            Check();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            btnPlay.Visible = false;
            btnCommand1.Visible = true;
            btnCommand2.Visible = true;
            btnReset.Visible = true;
            lblNumber.Visible = true;
            lblTask.Visible = true;
        }

        private void btnCommand2_Click(object sender, EventArgs e)
        {
            lblNumber.Text = (int.Parse(lblNumber.Text) * 2).ToString();
            stepCount++;
            Check();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            lblNumber.Text = "0";
            stepCount++;
            Check();
        }
    }
}
