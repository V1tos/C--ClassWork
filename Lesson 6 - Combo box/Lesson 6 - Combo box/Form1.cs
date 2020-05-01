using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lesson_6___Combo_box
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //string[] colors = new[] { "Red", "Green", "Blue" };
            //cbColor.Items.AddRange(colors);

            cbColor.Items.AddRange(typeof(Color).GetProperties()
                        .Select(x=>x.Name).ToArray());

            for (int i = 0; i < 9; i++)
            {
                cbColor.Items.RemoveAt(cbColor.Items.Count - 1);
            }
            cbColor.Items.RemoveAt(0);
            cbColor.SelectedIndex = new Random().Next(0, cbColor.Items.Count);

            string[] types = new[] { "Acriles", "Latex", "Aquarel", "Guash" };
            clbType.Items.AddRange(types);

            string[] makers = new[] { "Sniezka", "Zebra", "Royal", "Colorit", "Veselka" };
            lbManufacture.Items.AddRange(makers);
        }

        private void cbColor_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox box = sender as ComboBox;
            lblColor.BackColor = Color.FromName(box.SelectedItem.ToString());
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            List<string> types = new List<string>();

            foreach (var item in clbType.CheckedItems)
            {
                types.Add(item.ToString());
            }

            string maker = lbManufacture.SelectedItem.ToString();
            string color = cbColor.Text;

            string result = $"Manufacturer: {maker}, Color: {color}";
            string type = "Types: ";
            foreach (var item in types)
            {
                type += item + ", ";
            }
            result += type;
            result = result.Substring(0, result.Length - 2);
            lbResult.Items.Add(result);
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            while(lbResult.SelectedIndices.Count>0)
                lbResult.Items.RemoveAt(lbResult.SelectedIndices[0]);
        }
    }
}
