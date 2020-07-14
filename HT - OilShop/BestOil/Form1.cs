using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BestOil
{
    public partial class AZS : Form
    {

        List<Oil> kindsOil = new List<Oil>
        {
            new Oil {Name = "A-80", Price = 24},
            new Oil {Name = "A-92", Price = 25},
            new Oil {Name = "A-95", Price = 26},
            new Oil {Name = "A-98", Price = 27}
        };

        decimal cafePrice = 0;
        decimal oilPrice = 0;
        float allPrice = 0;

        public AZS()
        {
            InitializeComponent();

            for (int i = 0; i < kindsOil.Count; i++)
                comboBox1.Items.Add(kindsOil[i].Name);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblPrice.Text = kindsOil[comboBox1.SelectedIndex].Price.ToString();
            radioButton1.Enabled = radioButton2.Enabled = true;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = sender as RadioButton;

            if (rb.Text == "Кількість")
                textBox6.Enabled = !textBox6.Enabled;
            else 
                textBox2.Enabled = !textBox2.Enabled;
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace((sender as TextBox).Text))
                return;


            if (radioButton1.Checked)
            {
                decimal count = decimal.Parse(textBox6.Text);
                textBox2.Text = (count * kindsOil[comboBox1.SelectedIndex].Price).ToString();
            }
            else if(radioButton2.Checked)
            {
                decimal count = decimal.Parse(textBox2.Text);
                textBox6.Text = (count / kindsOil[comboBox1.SelectedIndex].Price).ToString();
            }

            lblOilPrice.Text = textBox2.Text;
            oilPrice = decimal.Parse(textBox2.Text);

        }



        //private void button2_Click(object sender, EventArgs e)
        //{
        //    foreach(var item in groupBox2.Controls)
        //    {
        //        if (!(item is GroupBox) || (item as GroupBox).Text == "До оплати:")
        //            continue;

        //        GroupBox gb = item as GroupBox;

        //        foreach(var control in gb.Controls)
        //        {
        //            CheckBox cb = 
                    

        //            if (!(control as CheckBox).Checked)
        //                continue;

        //            cafePrice += decimal.Parse((control as TextBox).Text) * (control as NumericUpDown).Value;
        //        }

        //    }
        //    groupBox6.Text = cafePrice.ToString();
        //}

        

        private void button2_Click(object sender, EventArgs e)
        {

            cafePrice = 0;

            foreach(var item in groupBox2.Controls)
            {
                if (!(item is CheckBox))
                    continue;

                CheckBox checkbox = item as CheckBox;

                if (checkbox.Checked && checkbox.Text == "Хот-дог")
                    cafePrice += decimal.Parse(textBox1.Text) * numericUpDown1.Value;
                if (checkbox.Checked && checkbox.Text == "Картопля-фрі")
                    cafePrice += decimal.Parse(textBox4.Text) * numericUpDown3.Value;
                if (checkbox.Checked && checkbox.Text == "Гамбургер")
                    cafePrice += decimal.Parse(textBox3.Text) * numericUpDown2.Value;
                if (checkbox.Checked && checkbox.Text == "Кока-Кола")
                    cafePrice += decimal.Parse(textBox5.Text) * numericUpDown4.Value;
                    
            }

            lblCafePrice.Text = cafePrice.ToString();
        }

        private void groupBox7_Enter(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void groupBox5_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            lblPriceAll.Text = (oilPrice + cafePrice).ToString();
        }
    }
}
