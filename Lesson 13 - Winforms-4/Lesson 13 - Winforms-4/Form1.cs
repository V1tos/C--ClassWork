using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lesson_13___Winforms_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (char.IsDigit((char)e.KeyValue))
                e.Handled = true;           
            label1.Text = "KeyDown: " + e.KeyCode + "Modifiers: " + e.Modifiers;

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit((char)e.KeyChar))
                e.Handled = true;
            label1.Text += "\nKeyPress: " + e.KeyChar;
        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            if (char.IsDigit((char)e.KeyValue))
                e.Handled = true;
            label1.Text += "\nKeyUp: " + (char)e.KeyValue + " Modifiers: " + e.Modifiers; ;
        }
    }
}
