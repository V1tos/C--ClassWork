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

namespace TextEditor
{
    public partial class TextEditor : Form
    {

        string filter = "Text Files|*.txt|RTF|*.rtf|C# Files|*.cs|All Files|*.*";

        bool isBold = false;
        bool isItalic = false;
        bool isStrikeout = false;
        bool isUnderline = false;
        bool isSave = true;
        string path = "";
        public TextEditor()
        {
            InitializeComponent();
            toolStripComboBox1.Items.AddRange(typeof(Color).GetProperties().Skip(1).Select(x => x.Name).ToArray());
            for (int i = 0; i < 9; i++)
            {
                toolStripComboBox1.Items.RemoveAt(toolStripComboBox1.Items.Count - 1);
            }

            openFileDialog1.Filter = filter;
            saveFileDialog1.Filter = filter;
        }
        #region

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                if (richTextBox1.SelectionLength != 0)
                {
                    richTextBox1.SelectionFont = fontDialog1.Font;
                    richTextBox1.SelectionColor = fontDialog1.Color;
                }
                else
                {
                    richTextBox1.Font = fontDialog1.Font;
                    richTextBox1.SelectionColor = fontDialog1.Color;
                }
            }
        }

        private void toolStripButton_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
                if (richTextBox1.SelectionLength != 0)
                    richTextBox1.SelectionColor = colorDialog1.Color;
                else
                    richTextBox1.ForeColor = colorDialog1.Color;
        }

        private void toolStripComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            richTextBox1.BackColor = Color.FromName(toolStripComboBox1.SelectedItem.ToString());
        }


        private void ChangeFontStyle(ref bool currentState, ref bool flag1, ref bool flag2, ref bool flag3, FontStyle fontStyle)
        {
            if (!currentState)
            {
                richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont, fontStyle);
                currentState = true;
            }
            else
            {
                richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont, FontStyle.Regular);
                currentState = false;
            }

            flag1 = flag2 = flag3 = false;
            isActive();
        }

        private void isActive()
        {
            toolStripButton1.BackColor = Control.DefaultBackColor;
            toolStripButton2.BackColor = Control.DefaultBackColor;
            toolStripButton3.BackColor = Control.DefaultBackColor;
            toolStripButton4.BackColor = Control.DefaultBackColor;

            if (isBold)
                toolStripButton1.BackColor = Color.DeepSkyBlue;
            else if (isItalic)
                toolStripButton2.BackColor = Color.DeepSkyBlue;
            else if (isStrikeout)
                toolStripButton3.BackColor = Color.DeepSkyBlue;
            else if (isUnderline)
                toolStripButton4.BackColor = Color.DeepSkyBlue;

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            ChangeFontStyle(ref isBold, ref isItalic, ref isStrikeout, ref isUnderline, FontStyle.Bold);
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            ChangeFontStyle(ref isItalic, ref isBold, ref isStrikeout, ref isUnderline, FontStyle.Italic); ;
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            ChangeFontStyle(ref isStrikeout, ref isItalic, ref isBold, ref isUnderline, FontStyle.Strikeout);
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            ChangeFontStyle(ref isUnderline, ref isItalic, ref isStrikeout, ref isBold, FontStyle.Underline);
        }

        private void toolStripButtonUndo_Click(object sender, EventArgs e)
        {
            richTextBox1.Undo();
        }

        private void toolStripButtonRedo_Click(object sender, EventArgs e)
        {
            richTextBox1.Redo();
        }

        private void toolStripButtonCapitalize_Click(object sender, EventArgs e)
        {
            if (richTextBox1.SelectionLength != 0)
                richTextBox1.SelectedText = richTextBox1.SelectedText.ToUpper();
        }

        private void toolStripButtonSmallCase_Click(object sender, EventArgs e)
        {
            if (richTextBox1.SelectionLength != 0)
                richTextBox1.SelectedText = richTextBox1.SelectedText.ToLower();
        }

        private void toolStripButtonIncrease_Click(object sender, EventArgs e)
        {
            Font currentFont = richTextBox1.SelectionFont;
            if (richTextBox1.SelectionLength != 0 && currentFont.Size <= 72)
                richTextBox1.SelectionFont = new Font(currentFont.FontFamily, currentFont.Size + 2);
        }

        private void toolStripButtonReduce_Click(object sender, EventArgs e)
        {
            Font currentFont = richTextBox1.SelectionFont;
            if (richTextBox1.SelectionLength != 0 && currentFont.Size >= 2)
                richTextBox1.SelectionFont = new Font(currentFont.FontFamily, currentFont.Size - 2);
        }

        private void toolStripButton9_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionAlignment = HorizontalAlignment.Left;
        }

        private void toolStripButton11_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionAlignment = HorizontalAlignment.Right;
        }

        private void toolStripButton10_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionAlignment = HorizontalAlignment.Center;
        }


        private void toolStripButtonCopy_Click(object sender, EventArgs e)
        {
            if (richTextBox1.SelectionLength != 0)
                richTextBox1.Copy();
        }

        private void toolStripButtonPaste_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();
        }

        private void toolStripButtonCut_Click(object sender, EventArgs e)
        {
            if (richTextBox1.SelectionLength != 0)
                richTextBox1.Cut();
        }

        #endregion

        private void toolStripButtonOpen_Click(object sender, EventArgs e)
        {
            if (!isSave)
            {
                DialogResult result = MessageBox.Show("File is not saved\nSave?", $"Info", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (result == DialogResult.Yes)
                    saveAsToolStripMenu_Click(null, null);
            }

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.LoadFile(openFileDialog1.FileName, RichTextBoxStreamType.PlainText);
                path = openFileDialog1.FileName;
                isSave = true;
            }
        }

        private void saveAsToolStripMenu_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                if (saveFileDialog1.FileName.Length > 0)
                {
                    richTextBox1.SaveFile(saveFileDialog1.FileName, RichTextBoxStreamType.PlainText);
                    path = saveFileDialog1.FileName;
                    isSave = true;
                }
        }


        private void toolStripButtonSave_Click(object sender, EventArgs e)
        {
            richTextBox1.SaveFile(path, RichTextBoxStreamType.PlainText);
            isSave = true;
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            isSave = false;
        }

        private void toolStripButtonNew_Click(object sender, EventArgs e)
        {
            saveAsToolStripMenu_Click(null, null);
        }

        private void TextEditor_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!isSave)
            {
                DialogResult result = MessageBox.Show("File is not saved\nSave?", $"Info", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (result == DialogResult.Yes)
                    saveAsToolStripMenu_Click(null, null);
            }
        }
        private void saveToolStripMenu_Click(object sender, EventArgs e)
        {
            toolStripButtonSave_Click(null, null);
        }
    }
}
