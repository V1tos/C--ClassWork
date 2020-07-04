using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lesson_5___List_box
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            string[] words = new[] { "One", "Two", "Three", "Four" };
            lbElements.Items.AddRange(words);
            lbElements.Items.Insert(3, "New element");
            lbElements_SelectedIndexChanged(null, null);
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(tbNew.Text))
                return;

            lbElements.Items.Add(tbNew.Text);
            tbNew.Text = String.Empty;
            tbNew.Focus();
        }

        private void lbElements_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblSelected.Text = String.Empty;

            if (lbElements.SelectedIndices.Count==0)
            {
                lblSelected.Text = "Didn't choose any element";
            }
            foreach (int index in lbElements.SelectedIndices)
            {
                lblSelected.Text += $"Choosed element {lbElements.Items[index]} with index: {index}\n";
            }
        }

        private void radioOne_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = sender as RadioButton;

            if (rb == radioOne)
                lbElements.SelectionMode = SelectionMode.One;
            else if (rb == radioSimple)
                lbElements.SelectionMode = SelectionMode.MultiSimple;
            else 
                lbElements.SelectionMode = SelectionMode.MultiExtended;

            lbElements_SelectedIndexChanged(null, null);

        }

        private void manyColBox_CheckedChanged(object sender, EventArgs e)
        {
            lbElements.MultiColumn = manyColBox.Checked;
        }

        private void delBtn_Click(object sender, EventArgs e)
        {
            while (lbElements.SelectedIndices.Count != 0)
                lbElements.Items.RemoveAt(lbElements.SelectedIndices[0]);          
        }
    }
}
