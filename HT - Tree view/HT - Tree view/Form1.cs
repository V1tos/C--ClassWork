using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HT___Tree_view
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }


        private void browseToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.ShowDialog();

            foreach (var item in folderBrowserDialog1.SelectedPath)
            {

            }

        }
    }
}
