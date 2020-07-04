using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lesson_10___Dialog
{
    public partial class StdDialog : Form
    {
        public StdDialog()
        {
            InitializeComponent();
        }

        private void colorDialogToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                if (richTextBox1.SelectionLength != 0)
                    richTextBox1.SelectionColor = colorDialog1.Color;
                else
                    richTextBox1.ForeColor = colorDialog1.Color;
            }
        }

        private void fontDialogToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog fontDialog1 = new FontDialog();
            fontDialog1.Font = new Font("Times New Roman", 18, FontStyle.Bold | FontStyle.Underline);
            fontDialog1.ShowColor = true;
            fontDialog1.Color = Color.DarkSlateGray;
            if(fontDialog1.ShowDialog() == DialogResult.OK)
            {
                if (richTextBox1.SelectionLength != 0)
                {
                    richTextBox1.SelectionFont = fontDialog1.Font;
                    richTextBox1.SelectionColor = fontDialog1.Color;
                }
                else
                {
                    richTextBox1.SelectionFont = fontDialog1.Font;
                    richTextBox1.SelectAll();
                    richTextBox1.SelectionColor = fontDialog1.Color;
                }
            }
        }

        private void folderBrowserDialogToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            dialog.ShowDialog();
        }

        private void openToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "Text files(*.txt)|*.txt|All files|*.*";
            openFile.FileName = "Type name here";
            openFile.InitialDirectory = @"C:\Users\420\Desktop";
            var dialogResult = openFile.ShowDialog();

            if (dialogResult == DialogResult.OK)
            {
                //var result = File.ReadAllText(openFile.FileName);
                //richTextBox1.Text = result;
                if(Path.GetExtension(openFile.FileName) == ".rtf")
                    richTextBox1.LoadFile(openFile.FileName);
                else
                    richTextBox1.LoadFile(openFile.FileName, RichTextBoxStreamType.PlainText);
            }                                        
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sd = new SaveFileDialog();
            sd.Filter = "Text files(*.txt)|*.txt|All files|*.*";
            sd.InitialDirectory = @"C:\Users\420\Desktop";
            sd.OverwritePrompt = true;
            sd.ShowDialog();
            //File.WriteAllText(sd.FileName, richTextBox1.Text);
            richTextBox1.SaveFile(sd.FileName);
        }

        private void toolStripComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            richTextBox1.Font = new Font(richTextBox1.Font.FontFamily, Convert.ToSingle(toolStripComboBox1.SelectedItem));
        }
    }
}
