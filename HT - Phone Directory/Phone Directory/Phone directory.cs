using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Phone_Directory
{
    public partial class Form1 : Form
    {
        Contact contact = null;
        List<Contact> contacts = new List<Contact>();

        public Form1()
        {
            InitializeComponent();
            for (int i = 0; i < contacts.Count; i++)
            {
                lbContacts.Items.Add(contacts[i].PhotoPath);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            contact = new Contact();
            Form2 addform = new Form2(contact, true);
            if (addform.ShowDialog() == DialogResult.OK)
            {
                lbContacts.Items.Add(contact);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lbContacts.SelectedIndex == -1)
            {
                MessageBox.Show("No select contact ...");
                return;
            }

            lbContacts.Items.RemoveAt(lbContacts.SelectedIndex);
            this.pictureBox1.Image = null;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (lbContacts.SelectedIndex == -1)
            {
                MessageBox.Show("You doesn't select contact");
                return;
            }

            int index = lbContacts.SelectedIndex;
            contact = (Contact)lbContacts.Items[index];
            Form2 editForm = new Form2(contact, false);
            editForm.ShowDialog();
            lbContacts.Items.RemoveAt(index);
            lbContacts.Items.Insert(index, contact);
            lbContacts.SelectedIndex = index;

        }

        private void lbContacts_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbContacts.SelectedIndex != -1)
            {
                contact = (Contact)lbContacts.Items[lbContacts.SelectedIndex];
                pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
                this.pictureBox1.Image = contact.Image;
            }
        }

        private void btnClearLB_Click(object sender, EventArgs e)
        {
            lbContacts.Items.Clear();
            this.pictureBox1.Image = null;
        }
    }
}
