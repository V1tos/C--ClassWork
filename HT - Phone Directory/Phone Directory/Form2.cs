using System;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Phone_Directory
{
    public partial class Form2 : Form
    {

        public Contact contact { get; set; }
        bool addNew;
        string emailPattern = @"^(?("")(""[^""]+?""@)|(([0-9a-z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-z])@))" +
                @"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-\w]*[0-9a-z]*\.)+[a-z0-9]{2,17}))$";

        string phonePattern = @"(\s*)?(\+)?([-_():= +]?\d[-_():= +]?){10,14}(\s*)?";

        public Form2(Contact contact, bool addNew)
        {
            InitializeComponent();

            this.addNew = addNew;
            this.contact = contact;

            if (!addNew)
            {
                textBox1.Text = contact.Name;
                textBox2.Text = contact.Surname;
                textBox3.Text = contact.Email;
                textBox4.Text = contact.Phone;
                if (!String.IsNullOrWhiteSpace(contact.PhotoPath))
                    pictureBox1.Image = contact.Image;
                this.Text = "Edit exist contact";
                return;
            }

            this.Text = "Add new contact";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            contact = contact ?? new Contact();

            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "")
            {
                MessageBox.Show("Заполните все поля"); return;
            }

            contact.Name = textBox1.Text;
            contact.Surname = textBox2.Text;
            contact.Image = pictureBox1.Image;

            if (Regex.IsMatch(textBox3.Text, emailPattern, RegexOptions.IgnoreCase))
                contact.Email = textBox3.Text;
            else
            {
                MessageBox.Show("Email isn't valid");
                return;
            }

            if (Regex.IsMatch(textBox4.Text, phonePattern, RegexOptions.IgnoreCase))
                contact.Phone = textBox4.Text;
            else
            {
                MessageBox.Show("Phone isn't valid");
                return;
            }

            this.DialogResult = DialogResult.OK;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                contact.Image = Image.FromFile(openFileDialog1.FileName);
                pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
                this.pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);

            }
        }
    }
}
