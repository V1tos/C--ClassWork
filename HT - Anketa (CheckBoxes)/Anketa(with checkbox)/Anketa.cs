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

namespace Anketa_with_checkbox_
{
    public partial class Anketa : Form
    {


        bool checkName = false,
            checkGender = false,
            hobbiIsChecked = false;

        
        //s
        public Anketa()
        {
            InitializeComponent();
            tbName.Focus();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            checkName = false;
            checkGender = false;
            panel1.Visible = false;
            pictureBox1.Image = null;
            lblName.Text = "Name: ";
            lblGender.Text = "Gender: ";
            lblAge.Text = "Age: ";
            lblSkils.Text = "Skills: ";
            lblLanguages.Text = "Foreign Language(English): ";
            lblHobbies.Text = "Hobbies: ";
            string ErrorList = "You have to fill next fields:\n\t";

            Person person = new Person
            {
                Name = tbName.Text,
                DateOfBirthday = dateTimePicker1.Value
            };

            lblName.Text += person.Name;
            lblAge.Text += $" {DateTime.Today.Year - person.DateOfBirthday.Year} | Birthday: {person.DateOfBirthday.Day}.{person.DateOfBirthday.Month}.{person.DateOfBirthday.Year}";

            foreach(var control in gbGender.Controls)
            {
                if (!(control is RadioButton))
                    continue;
                RadioButton btn = control as RadioButton;
                if (btn.Text == "Male" && btn.Checked)
                {
                    //pictureBox1.Image = Image.FromFile("../../img/man.jpg");
                    person.img = Image.FromFile("../../img/man.jpg");
                    person.Gender = btn.Text;
                    checkGender = true;
                }
                else if(btn.Text == "Female" && btn.Checked)
                {
                    //pictureBox1.Image = Image.FromFile("../../img/woman.jpg");
                    person.img = Image.FromFile("../../img/woman.jpg");
                    person.Gender = btn.Text;
                    checkGender = true;
                }
            }

            foreach (var control in gbSkills.Controls)
            {
                if (!(control is CheckBox))
                    continue;
                CheckBox check = control as CheckBox;

                if (check.Checked)
                {
                    lblSkils.Text += check.Text + ", ";
                    person.Skills.Add(check.Text);
                }
            }

            foreach (var control in gbOtherLanguages.Controls)
            {
                if (!(control is CheckBox))
                    continue;
                CheckBox check = control as CheckBox;

                if (check.Checked)
                    person.EnglishKnowledge = "Good";
                else
                    person.EnglishKnowledge = "Bad";
            }

            foreach(var control in gbHobby.Controls)
            {
                if (!(control is CheckBox))
                    continue;

                CheckBox check = control as CheckBox;

                if (check.Checked && check.Text != "Other")
                {
                    person.hobbies.Add(check.Text);
                    lblHobbies.Text += check.Text + ", ";
                }
                else if(check.Checked && check.Text == "Other")
                {
                    person.hobbies.Add(tbHobby.Text);
                    lblHobbies.Text += tbHobby.Text + ", ";
                }
            }

            if (!(tbName.Text == String.Empty))
                checkName = true;

            //if (hobbiIsChecked && tbHobby.Text == String.Empty)

            if (!checkName || !checkGender)
            {

                if (tbName.Text == String.Empty)
                    ErrorList += "enter name\n\t";
                if (!checkGender)
                    ErrorList += "select gender\n\t";
                if (hobbiIsChecked && tbHobby.Text == String.Empty)
                    ErrorList += "Fill text area about hobby";

                        MessageBox.Show(ErrorList, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            
            pictureBox1.Image = person.img;
            lblLanguages.Text += person.EnglishKnowledge;
            lblGender.Text += person.Gender;
            lblHobbies.Text = lblHobbies.Text.Substring(0, lblHobbies.Text.Length - 2);
            lblSkils.Text = lblSkils.Text.Substring(0, lblSkils.Text.Length - 2);
            panel1.Visible = true;

        }

        private void tbName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != 8 && e.KeyChar != 32 && !((e.KeyChar >= 65 && e.KeyChar <= 90) || (e.KeyChar >= 97 && e.KeyChar <= 122)))
                e.Handled = true;
        }

        private void checkBox18_CheckedChanged(object sender, EventArgs e)
        {
            if ((sender as CheckBox).Checked)
            { 
                tbHobby.Visible = true;
                hobbiIsChecked = true;
            }
            else
            {
                tbHobby.Visible = false;
                hobbiIsChecked = false;
            }
        }
    }
}
