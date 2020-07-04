using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lesson_2___Radiobuttons
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radio = sender as RadioButton;
            this.BackColor = Color.FromName(radio.Text);
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radio = sender as RadioButton;
            this.ForeColor = Color.FromName(radio.Text);
        }
    }
}
