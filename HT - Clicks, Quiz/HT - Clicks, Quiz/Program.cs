using System;
using System.Drawing;
using System.Windows.Forms;

namespace WF_intro_homework
{
    class Program
    {
        static int MouseLeftButton = 0;
        static int MouseMiddleButton = 0;
        static int MouseRightButton = 0;

        static Color[] colors = { Color.Red, Color.Orange, Color.Green, Color.Blue, Color.DarkBlue, Color.Violet };
        static int index = 0;
        static void Main(string[] args)
        {
            #region 1. Написати програму, яка веде підрахунок кліків лівою, правою, середньою кнопками по формі. Статистику виводити в заголовок форми.На формі зробити кнопку "Очищення статистики", яка після кліку онуляє рахунок кліків.
            Form form = new Form();
            form.Size = new Size(600, 200);
            form.StartPosition = FormStartPosition.CenterScreen;

            Button btnClear = new Button();

            btnClear.Size = new Size(100, 40);
            btnClear.BackColor = Color.Green;
            btnClear.ForeColor = Color.White;
            btnClear.Top = 50;
            btnClear.Left = 50;
            btnClear.Text = "Clear";


            form.MouseClick += Form_MouseClick;
            btnClear.MouseClick += BtnClear_MouseClick;

            form.Controls.Add(btnClear);

            form.ShowDialog();
            #endregion

            #region 2. Написати програму, яка з кожним кліком по формі буде змінювати фон форми на кольори веселки (і так циклічно)
            //Form rainbow = new Form();
            //rainbow.Size = new Size(550, 400);
            //rainbow.StartPosition = FormStartPosition.CenterScreen;

            //rainbow.Click += Rainbow_Click; ;

            //rainbow.ShowDialog();
            #endregion

            //#region 3. Створити програму Вікторина(Тестування). Програма задає декілька питань користувачу, очікуючи відповіді типу Так-Ні.
            //Form quizForm = new Form();
            //quizForm.Size = new Size(550, 400);
            //quizForm.StartPosition = FormStartPosition.CenterScreen;

            //Quiz quiz = new Quiz();
            //quiz.questions.Add(new Question
            //{
            //    question = "True or false?",
            //    answer = true

            //});

            //quiz.Run();


            //#endregion

        }

        #region 1
        private static void BtnClear_MouseClick(object sender, MouseEventArgs e)
        {
            MouseLeftButton = 0;
            MouseMiddleButton = 0;
            MouseRightButton = 0;

            ((sender as Button).Parent as Form).Text = $"Left: {MouseLeftButton} | Middle: {MouseMiddleButton} | Right: {MouseRightButton}";
        }

        private static void Form_MouseClick(object sender, MouseEventArgs e)
        {
            switch (e.Button)
            {
                case MouseButtons.Left:
                    MouseLeftButton++;
                    break;
                case MouseButtons.Middle:
                    MouseMiddleButton++;
                    break;
                case MouseButtons.Right:
                    MouseRightButton++;
                    break;
            }

            (sender as Form).Text = $"Left: {MouseLeftButton} | Middle: {MouseMiddleButton} | Right: {MouseRightButton}";
        }
        #endregion

        #region 2
        private static void Rainbow_Click(object sender, EventArgs e)
        {
            (sender as Form).BackColor = colors[index++];
            if (index == colors.Length) index = 0;
        }
        #endregion
    }
}
