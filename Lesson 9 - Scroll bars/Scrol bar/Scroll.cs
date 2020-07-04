using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Scrol_bar
{
    public partial class Scroll : Form
    {
        List<string> names = new List<string>();
        public Scroll()
        {
            InitializeComponent();
            hScrollBar1.Maximum = imageList1.Images.Count - 1;
            hScrollBar1.LargeChange = hScrollBar1.SmallChange = 1;

            toolStripProgressBar1.Maximum = imageList1.Images.Count;



            names.AddRange(new []{ "Picture 1","Picture 2","Picture 3","Picture 4"});

            pictureBox1.Image = imageList1.Images[0];
            toolStripProgressBar1.Value = 1;

            linkLabel1.Links.Add(new LinkLabel.Link() { LinkData = "https://google.com" });
        }

        private void hScrollBar1_ValueChanged(object sender, EventArgs e)
        {
            int j = hScrollBar1.Value; // 0
            pictureBox1.Image = imageList1.Images[j];
            toolStripStatusLabel1.Text = names[j];
            toolStripProgressBar1.Value = j+1;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(e.Link.LinkData.ToString());
        }
    }
}
