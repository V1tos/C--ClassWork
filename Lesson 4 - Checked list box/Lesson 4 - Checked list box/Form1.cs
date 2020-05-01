using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lesson_4___Checked_list_box
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            checkedListBox1.Items.Add("Six", false);
            checkedListBox1.Items.Add("Seven", true);
            checkedListBox1_SelectedIndexChanged(null, null);
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            labelSelected.Text = String.Empty;
            if (checkedListBox1.CheckedIndices.Count==0)
            {
                labelSelected.Text = "Don't changed any elements";
                return;
            }

            foreach (int index in checkedListBox1.CheckedIndices)
            {
                labelSelected.Text += $"Choosed element {checkedListBox1.Items[index]} with index: {index}\n";
            }
            
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            while(checkedListBox1.CheckedIndices.Count !=0)
                checkedListBox1.Items.RemoveAt(checkedListBox1.CheckedIndices[0]);
            checkedListBox1_SelectedIndexChanged(null, null);
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(textBox1.Text))
                return;

            checkedListBox1.Items.Add(textBox1.Text);
            textBox1.Text = String.Empty;
            textBox1.Focus();
            
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Return)
                buttonAdd_Click(sender, e);
        }

        private void srBtn_Click(object sender, EventArgs e)
        {
            tbDelete.Visible = true;
            tbDelete.Focus();
        }

        private void tbDelete_KeyDown(object sender, KeyEventArgs e)
        {
            if (tbDelete.Focused)
                AcceptButton = null;
            
            if (e.KeyCode == Keys.Return)
            {
                if (checkedListBox1.Items.Contains(tbDelete.Text))
                    checkedListBox1.Items.Remove(tbDelete.Text);


                tbDelete.Text = "";
                checkedListBox1_SelectedIndexChanged(null, null);
            }
               
        }
    }
}
