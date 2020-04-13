using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lesson_11___Winform_Task1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        int i = 0;
        
        private void startBtn_Click(object sender, EventArgs e)
        {       

            Point point = timeLbl.Location;
            timer.Start();
            if (point.Y > startBtn.Location.Y - timeLbl.Height - 10)
            {
                point.Y = startBtn.Location.Y - timeLbl.Height - 10;
            }
            if (point.X<20 && point.Y != 26)
            {
                point.X = 10;
            }
            if (point.Y<20)
            {
                point.Y = 26;
            }

            if (point.X < ClientSize.Width - timeLbl.Width - 20 && point.Y < startBtn.Location.Y - timeLbl.Height - 10&&point.Y==26)
                timeLbl.Location = new Point(point.X + 20, point.Y);
            if (point.X > ClientSize.Width - timeLbl.Width - 20 && point.Y < startBtn.Location.Y - timeLbl.Height - 10)
                timeLbl.Location = new Point(point.X, point.Y + 20);
            else if (point.Y == startBtn.Location.Y - timeLbl.Height - 10&&point.X>20)
                timeLbl.Location = new Point(point.X - 20, point.Y);
            else if(point.X==10)
                timeLbl.Location = new Point(point.X, point.Y - 20);
            else if (point.X == 10&& /*point.Y < startBtn.Location.Y - timeLbl.Height - 10&&*/point.Y!=26)
                timeLbl.Location = new Point(point.X, point.Y - 20);

            timeLbl.Text = ++i + " sec";
        }
    }
}
