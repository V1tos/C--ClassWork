using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lesson_9___Scroll_bars
{
    public partial class ScrollBars : Form
    {
        public ScrollBars()
        {
            InitializeComponent();
        }

        private void trackBar1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            UpdateColor();
        }

        private void UpdateColor()
        {
            splitContainer1.Panel1.BackColor = Color.FromArgb(trackBar1.Value,
                                                              trackBar2.Value,
                                                              trackBar3.Value);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //progressBar1.Value += 10;
            //if (progressBar1.Value == progressBar1.Maximum)
            //    progressBar1.Value = progressBar1.Minimum;
            //else
            //    progressBar1.Increment(10);
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = !timer1.Enabled;
        }
    }
}
