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
            if (point.X < ClientSize.Width - timeLbl.Width && point.Y < startBtn.Location.Y - timeLbl.Height - 20)
                timeLbl.Location = new Point(point.X + 20, point.Y);
            else if (point.X > ClientSize.Width - timeLbl.Width && point.Y < startBtn.Location.Y - timeLbl.Height - 20)
                timeLbl.Location = new Point(point.X, point.Y + 20);
            else if (point.Y > startBtn.Location.Y - timeLbl.Height - 20)
                timeLbl.Location = new Point(point.X - 20, point.Y);
            else if ()
                timeLbl.Location = new Point(point.X, point.Y - 20);

            timeLbl.Text = ++i + " sec";
        }
    }
}
