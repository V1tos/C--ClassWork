using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lesson_11___Drag_image
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            toolStripStatusLabel1.Text = "";
            AllowDrop = true;
            pictureBox1.AllowDrop = true;
            pictureBox2.AllowDrop = true;
            pictureBox3.AllowDrop = true;
            pictureBox4.AllowDrop = true;
            pictureBox5.AllowDrop = true;
            pictureBox6.AllowDrop = true;
            pictureBox7.AllowDrop = true;
            pictureBox8.AllowDrop = true;
            pictureBox9.AllowDrop = true;
            pictureBox10.AllowDrop = true;
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox6.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox7.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox8.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox9.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox10.SizeMode = PictureBoxSizeMode.Zoom;
            
        }
        PictureBox pbCache = new PictureBox();

        private void Form1_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
            toolStripStatusLabel1.Text = "Enter form";
        }

        private void Form1_DragLeave(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Leave form";
        }
        private void pictureBox1_DragEnter(object sender, DragEventArgs e)
        {
            toolStripStatusLabel1.Text = "Enter picturebox";
            if (e.Data.GetDataPresent(DataFormats.Bitmap))
                e.Effect = DragDropEffects.Copy;
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.Copy;
        }
        private void pictureBox1_DragLeave(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_DragDrop(object sender, DragEventArgs e)
        {
            PictureBox pb = sender as PictureBox;
            if (e.Data.GetDataPresent(DataFormats.Bitmap))
            {
                Bitmap currentImage = (Bitmap)e.Data.GetData(DataFormats.Bitmap);
                pbCache.Image = pb.Image;
                pb.Image = currentImage;
                Refresh();
            }
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                object data = e.Data.GetData(DataFormats.FileDrop);
                string fileName = ((string[])data)[0];
                pb.Image = Image.FromFile(fileName);
            }
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_MouseDown(object sender, MouseEventArgs e)
        {
            PictureBox pb = sender as PictureBox;
            pbCache = pb;            
            pb.DoDragDrop(pb.Image, DragDropEffects.Copy);           
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
