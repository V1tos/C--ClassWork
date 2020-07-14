using System;
using System.IO;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Anketa
{
    public partial class Anketa : Form
    {
        public Anketa()
        {
            InitializeComponent();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            tbStudentSurname.Text = String.Empty;
            tbStudentName.Text = String.Empty;
            cbStudentGender.Text = String.Empty;

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Student student = new Student
            {
                Name = tbStudentName.Text,
                Surname = tbStudentSurname.Text,
                Gender = cbStudentGender.Text,
                Birthday = dateTimePicker1.Value
            };

            string file = dateTimePicker1.Value.ToShortDateString() + $"_{student.Name}.xml";

            XmlSerializer xml = new XmlSerializer(typeof(Student));
            using (Stream stream = new FileStream(file, FileMode.OpenOrCreate, FileAccess.Write))
            {
                xml.Serialize(stream, student);
            }

            MessageBox.Show("Success!", "File was write", MessageBoxButtons.OK, MessageBoxIcon.Information);
            btnClear_Click(null, null);
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {

            string path = Directory.GetCurrentDirectory();
            string[] fi = Directory.GetFiles(path, "*.xml");
            string temp = "";

            try
            {
                foreach (var item in fi)
                {

                    DateTime dateTime = Convert.ToDateTime(File.GetCreationTimeUtc(item));
                    foreach (var file in fi)
                    {
                        DateTime nextTime = Convert.ToDateTime(File.GetCreationTimeUtc(file));
                        if (dateTime >= nextTime)
                            temp = item;
                    }

                }
                Student student;
                XmlSerializer xml = new XmlSerializer(typeof(Student));

                using (Stream stream = new FileStream(temp, FileMode.Open, FileAccess.Read))
                {
                    student = (Student)xml.Deserialize(stream);

                    tbStudentName.Text = student.Name;
                    tbStudentSurname.Text = student.Surname;
                    cbStudentGender.Text = student.Gender;
                    dateTimePicker1.Value = student.Birthday;

                }
            }
            catch (ArgumentException)
            {
                MessageBox.Show("Create a survey", "No profiles found", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            lblStudentAge.Text = $"Age: {(DateTime.Today.Year - dateTimePicker1.Value.Year).ToString()}";
        }
    }
}
