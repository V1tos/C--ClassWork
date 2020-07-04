using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lesson_11___Drug_and_drop
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void lbDestination_MouseDown(object sender, MouseEventArgs e)
        {
            if(lbDestination.SelectedItem!=null)
                lbDestination.DoDragDrop(lbDestination.SelectedItem, DragDropEffects.None);

            typeof(Color).GetProperties();
        }

        private void tbMessage_MouseDown(object sender, MouseEventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(tbMessage.Text))
                tbMessage.DoDragDrop(tbMessage.Text, DragDropEffects.Copy);
        }

        private void lbDestination_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(String)))
                e.Effect = DragDropEffects.Copy;
        }

        private void lbDestination_DragDrop(object sender, DragEventArgs e)
        {
            lbDestination.Items.Add(e.Data.GetData(typeof(String)));
            Text = "Drag & Drop finished";
        }

        private void MainForm_DragOver(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
            Text = "Drag over";
        }
    }
}
