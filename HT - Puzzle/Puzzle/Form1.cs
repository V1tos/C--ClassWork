using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Puzzle
{
    public partial class Form1 : Form
    {
        Image tmpImg;
        PictureBox tmpPB;

        public Form1()
        {
            InitializeComponent();
            pictureBox1.AllowDrop = true;
            pictureBox2.AllowDrop = true;
            pictureBox3.AllowDrop = true;
            pictureBox4.AllowDrop = true;
            pictureBox5.AllowDrop = true;
            pictureBox6.AllowDrop = true;
            pictureBox7.AllowDrop = true;
            pictureBox8.AllowDrop = true;
            pictureBox9.AllowDrop = true;
        }

        private void pictureBox1_DragDrop(object sender, DragEventArgs e)
        {
            PictureBox pb = sender as PictureBox;
            tmpPB.Image = pb.Image;
            pb.Image = tmpImg;
        }

        private void pictureBox1_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            PictureBox pb = sender as PictureBox;
            tmpImg = pb.Image;
            tmpPB = pb;
            pb.DoDragDrop(pb, DragDropEffects.Copy);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[] arr = new int[9];
            for (int i = 0; i < 8; i++)
            {
                int a = new Random().Next(1, 9);
                if (!arr.Contains(a))
                    arr[i] = a;
                else
                    i--;
            }
            int f = 0;
            string name;
            foreach (PictureBox item in tableLayoutPanel1.Controls.OfType<PictureBox>())
            {
                if (f < 9)
                {
                    name = arr[f].ToString();
                    item.Image = Image.FromFile($"../../img/{name}.jpg");
                    f++;
                }
            }
        }
    }
}
