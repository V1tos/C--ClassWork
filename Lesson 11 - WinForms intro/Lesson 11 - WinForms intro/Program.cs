using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace Lesson_11___WinForms_intro
{
    class Program
    {
        static void Main(string[] args)
        {

            //Form form = new Form();
            //Button increaseButton = new Button();
            //Button decreacseButton = new Button();


            //form.Text = "First Form";
            //form.Size = new Size(750, 750);
            //form.BackColor = Color.Blue;


            //increaseButton.Text = "Increase opacity";
            //increaseButton.Size = new Size(250, 100);
            //increaseButton.BackColor = Color.Coral;
            //increaseButton.ForeColor = Color.Black;
            //increaseButton.Font = new Font("Comic Sans MS", 18);
            //increaseButton.Top = form.Height / 2 - increaseButton.Height;
            //increaseButton.Left = form.Width / 4 - increaseButton.Width / 2;
            //increaseButton.Click += IncreaseButton_Click;

            //decreacseButton.Text = "Decrease opacity";
            //decreacseButton.Size = new Size(250, 100);
            //decreacseButton.BackColor = Color.Coral;
            //decreacseButton.ForeColor = Color.Black;
            //decreacseButton.Font = new Font("Comic Sans MS", 18);
            //decreacseButton.Top = form.Height / 2 - increaseButton.Height;
            //decreacseButton.Left = form.Width / 2 - increaseButton.Width / 6;
            //decreacseButton.Click += DecreacseButton_Click;

            //form.Controls.Add(increaseButton);
            //form.Controls.Add(decreacseButton);
            //form.ShowDialog();




            Form form = new Form();
            Button catchButton = new Button();

            form.Size = new Size(750, 750);
            form.BackColor = Color.Blue;

            catchButton.Text = "Increase opacity";
            catchButton.Size = new Size(250, 100);
            catchButton.BackColor = Color.Coral;
            catchButton.ForeColor = Color.Black;
            catchButton.Font = new Font("Comic Sans MS", 18);
            catchButton.Top = form.Height / 2 - catchButton.Height;
            catchButton.Left = form.Width / 4 - catchButton.Width / 2;
            catchButton.MouseClick += CatchButton_Click;
            

            form.Controls.Add(catchButton);
            form.ShowDialog();


            //Console.Write("Enter form's width: ");
            //int width = int.Parse(Console.ReadLine());
            //Console.Write("Enter form's height: ");
            //int height = int.Parse(Console.ReadLine());
            //Console.Write("Enter form's headline: ");
            //string headline = Console.ReadLine();
            //Console.Write("Enter form's color: ");
            //string color = Console.ReadLine();

            //Form form = new Form();
            //form.Width = width;
            //form.Height = height;
            //form.Text = headline;
            //form.BackColor = Color.FromName(color);
            //form.ShowDialog();

        }

        private static void DecreacseButton_Click(object sender, EventArgs e)
        {
            ((sender as Button).Parent as Form).Opacity -= 0.1;
        }

        private static void IncreaseButton_Click(object sender, EventArgs e)
        {
            ((sender as Button).Parent as Form).Opacity += 0.1;
        }

        private static void CatchButton_Click(object sender, EventArgs e)
        {
            Random random = new Random();

            (sender as Button).Top = random.Next(0, 500);
            (sender as Button).Left = random.Next(0, 500);
        }
    }






    
    



}
