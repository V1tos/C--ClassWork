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

namespace TreeViews_labWork
{
    public partial class Form1 : Form
    {

        string treeViewPath;
        string listViewPath;

        public Form1()
        {
            InitializeComponent();
        }

        private void browseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                TreeNode driveNode = new TreeNode { Text = folderBrowserDialog1.SelectedPath.ToString() };
                FillTreeNode(driveNode, folderBrowserDialog1.SelectedPath);
                treeView1.Nodes.Add(driveNode);
            }
        }

        private void FillTreeNode(TreeNode driveNode, string path)
        {
            string[] dirs = Directory.GetDirectories(path);
            foreach (string dir in dirs)
            {
                TreeNode dirNode = new TreeNode();
                dirNode.Text = dir.Remove(0, dir.LastIndexOf("\\") + 1);
                driveNode.Nodes.Add(dirNode);
            }
        }

        private void treeView1_DoubleClick(object sender, EventArgs e)
        {
            listView1.Items.Clear();

            string[] files = Directory.GetFileSystemEntries(treeView1.SelectedNode.FullPath);
            treeViewPath = treeView1.SelectedNode.FullPath;
            listViewPath = treeView1.SelectedNode.FullPath;

            toolStripStatusLabel1.Text = treeViewPath;
            toolStripStatusLabel3.Text = listViewPath;

            for (int i = 0; i < files.Length; i++)
            {
                listView1.Items.Add(new ListViewItem(Path.GetFileName(files[i])));
            }
            int j = 0;
            foreach (ListViewItem item in listView1.Items)
            {
                item.SubItems.Add(File.GetCreationTime(files[j]).ToShortDateString().ToString());
                j++;
            }
        }

        private void ChangeDirectoryInListView(String path)
        {
            string[] files = Directory.GetFileSystemEntries(path);

            listView1.Items.Clear();
            for (int i = 0; i < files.Length; i++)
            {
                listView1.Items.Add(new ListViewItem(Path.GetFileNameWithoutExtension(files[i])));
            }
            int j = 0;
            foreach (ListViewItem item in listView1.Items)
            {
                item.SubItems.Add(File.GetCreationTime(files[j++]).ToShortDateString().ToString());
            }
            listViewPath = path;
            toolStripStatusLabel1.Text = treeViewPath;
            toolStripStatusLabel3.Text = listViewPath;
        }

        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            ListView table = (ListView)sender;

            try
            {
                string newPath = listViewPath + "\\" + listView1.SelectedItems[0].Text;
                ChangeDirectoryInListView(newPath);
            }
            catch
            {
                
            }
        }

        private void listView1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Back)
            {
                ListView table = (ListView)sender;

                try
                {
                    string newPath = listViewPath.Remove(listViewPath.LastIndexOf("\\"));
                    ChangeDirectoryInListView(newPath);
                }
                catch
                {

                }
            }

            if(e.KeyCode == Keys.Delete && listView1.SelectedItems.Count > 0)
            {
                string path = listViewPath + "\\" + listView1.SelectedItems[0].Text;

                if (!String.IsNullOrEmpty(Path.GetExtension(path)))
                    File.Delete(path);
                else
                    Directory.Delete(path);
                listView1.Items.Remove(listView1.SelectedItems[0]);
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                foreach(RadioButton item in groupBox1.Controls)
                {
                    if (item.Checked)
                    {
                        View view = (View)Enum.Parse(typeof(View), item.Text);
                        listView1.View = view;
                        break;
                    }
                }
            }
            catch
            {

            }
        }
    }
}
