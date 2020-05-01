﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lesson_1___Checkboxes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox check = sender as CheckBox;
            this.Text = $"{check.Checked} ---> {check.CheckState} {check.ThreeState}";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (Control item in this.Controls)
            {
                if (item is CheckBox)
                {
                    CheckBox temp = item as CheckBox;
                    if (temp.Checked)
                        label1.Text += temp.Text + Environment.NewLine;                   
                }
            }

        }

        private void checkAgree_CheckedChanged(object sender, EventArgs e)
        {
            if (checkAgree.Checked)
                button1.Enabled = true;
            else
                button1.Enabled = false;
        }
    }
}
