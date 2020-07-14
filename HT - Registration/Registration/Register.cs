using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Registration
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void Register_MouseDown(object sender, MouseEventArgs e)
        {
            base.Capture = false;
            Message m = Message.Create(base.Handle, 0xa1, new IntPtr(2), IntPtr.Zero);
            this.WndProc(ref m);
        }

        private void label_MouseEnter(object sender, EventArgs e)
        {
            (sender as Label).ForeColor = Color.DarkRed;
        }

        private void label_MouseLeave(object sender, EventArgs e)
        {
            (sender as Label).ForeColor = Color.White;
        }

        private void lblCloseApp_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lblMinimizeApp_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled))
                lblDone.Visible = !lblDone.Visible;
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != 8 && e.KeyChar != 32 && !((e.KeyChar >= 65 && e.KeyChar <= 90) || (e.KeyChar >= 97 && e.KeyChar <= 122)))
                e.Handled = true;
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != 8 && e.KeyChar != 32 && !((e.KeyChar >= 48 && e.KeyChar <= 57)))
                e.Handled = true;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.Clear();
        }

        private void textBox1_Validating(object sender, CancelEventArgs e)
        {
            TextBox tb = sender as TextBox;

            if (string.IsNullOrWhiteSpace(tb.Text))
            {
                e.Cancel = true;
                tb.Focus();
                errorProvider1.SetError(tb, "You must to fill this field");
            }
        }

        private void dateTimePicker1_Validating(object sender, CancelEventArgs e)
        {
            DateTimePicker dtp = sender as DateTimePicker;

            if ((DateTime.Now.Year - dtp.Value.Year) <= 12)
            {
                e.Cancel = true;
                errorProvider1.SetError(dtp, "Age cannot be less than 12 years");
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            errorProvider1.Clear();
        }
    }
}
