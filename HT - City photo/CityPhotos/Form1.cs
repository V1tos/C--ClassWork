using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace CityPhotos
{
    public partial class Form1 : Form
    {
        List<City> cities = new List<City>
        {
            new City{Name = "Lviv", Address = "https://en.wikipedia.org/wiki/Lviv"},
            new City{Name = "Rivne", Address = "https://en.wikipedia.org/wiki/Rivne"}
        };

        public Form1()
        {
            InitializeComponent();

            string[] photos = Directory.GetFiles("../../img/");

            for (int i = 0; i < cities.Count; i++)
            {
                cities[i].photos.AddRange(photos.Where(x => x.Contains(cities[i].Name)));
                comboBox1.Items.Add(cities[i].Name);
            }

            comboBox1.SelectedIndex = 0;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbCityLink.Links.Clear();
            toolStripStatusLabel1.Text = "Views: " + ++cities[comboBox1.SelectedIndex].counterViews;
            pictureBox1.Load(cities[comboBox1.SelectedIndex].photos[0]);
            lbCityLink.Links.Add(new LinkLabel.Link() { LinkData = cities[comboBox1.SelectedIndex].Address });
            lbCityLink.Text = cities[comboBox1.SelectedIndex].Name;
        }

        private void vScrollBar1_ValueChanged(object sender, EventArgs e)
        {
            pictureBox1.Load(cities[comboBox1.SelectedIndex].photos[vScrollBar1.Value]);
        }

        private void lbCityLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(e.Link.LinkData.ToString());
        }
    }
}