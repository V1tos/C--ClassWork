using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lesson_12___Tree_view
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            treeView1.LabelEdit = true; // Allow to edit vuzliv;
        }

        private void treeView1_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        private void treeView1_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            toolStripLabel1.Text = "Selected: " + e.Node.Text;
            toolStripLabel2.Text = e.Node.FullPath;
            Text = "Level: " + e.Node.Level;
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            treeView1.SelectedNode.Remove();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(tbNode.Text))
                return;

            TreeNode add = new TreeNode(tbNode.Text);
            treeView1.SelectedNode.Nodes.Add(add);
            tbNode.Text = String.Empty;
        }

        private void tbNode_Enter(object sender, EventArgs e)
        {
            tbNode.Text = String.Empty;
        }

        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            treeView1.Nodes.Clear();
        }

        private void treeView1_BeforeLabelEdit(object sender, NodeLabelEditEventArgs e)
        {
      
            toolStripLabel2.BackColor = Color.Maroon;
            toolStripLabel2.Text = "You're going to change text of current node" + e.Node.FullPath;
        }

        bool isCancelled = false;
        private void treeView1_AfterLabelEdit(object sender, NodeLabelEditEventArgs e)
        {
            if(isCancelled)
            {
                toolStripLabel2.Text = "You changed Text to " + e.Label;
                toolStripLabel2.BackColor = Color.Transparent;
            }
            else
            {
                toolStripLabel2.Text = "You cancelled changes ";
                toolStripLabel2.BackColor = Color.LightCoral;
            }
        }

        private void treeView1_KeyDown(object sender, KeyEventArgs e)
        {
            isCancelled = e.KeyCode == Keys.Escape;
        }

        private void treeView1_AfterCollapse(object sender, TreeViewEventArgs e)
        {
            toolStripLabel3.Text = "You collapsed " + e.Node;
            treeView1.CollapseAll();
            foreach(TreeNode item in treeView1.Nodes)
            {
                foreach (TreeNode item2 in item.Nodes)
                    item2.Collapse();
                    item.Expand();
            }
            treeView1.Refresh();
        }

        private void treeView1_BeforeExpand(object sender, TreeViewCancelEventArgs e)
        {
            toolStripLabel3.Text = "Before expand " + e.Node;
        }
    }
}
