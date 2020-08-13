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
using System.Xml.Serialization;

namespace HT___Exam
{
    public partial class LoadForm : Form
    {
        List<Question> questions = new List<Question>();
        public LoadForm()
        {
            InitializeComponent();
            openFileDialog1.Filter = "xml files (*.xml)|*.xml";
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                XmlSerializer xml = new XmlSerializer(typeof(List<Question>));
                string file = openFileDialog1.FileName;
                using (Stream stream = new FileStream(file, FileMode.Open, FileAccess.Read))
                    questions = (List<Question>)xml.Deserialize(stream);
                TestForm testingForm = new TestForm(questions);
                DialogResult dr = testingForm.ShowDialog();
            }
        }
    }
}
