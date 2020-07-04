using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lesson_8___List_box_2
{
    public partial class Form1 : Form
    {
        List<ProgrammingLanguage> languages;
        public Form1()
        {
            InitializeComponent();

            languages = new List<ProgrammingLanguage>()
            {
                new ProgrammingLanguage{Name = "C++", Popularity=2},
                new ProgrammingLanguage{Name = "C#", Popularity=4},
                new ProgrammingLanguage{Name = "Java", Popularity=5},
                new ProgrammingLanguage{Name = "Python", Popularity=6},
                new ProgrammingLanguage{Name = "Perl", Popularity=1},
                new ProgrammingLanguage{Name = "Objective C", Popularity=1},
                new ProgrammingLanguage{Name = "JavaScript", Popularity=5}
            };

            ClearDataSource();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        public class ProgrammingLanguage
        {
            public string Name { get; set; }
            public int Popularity { get; set; }

            //public override string ToString()
            //{
            //    return $"{Name} ---- {Popularity}";
            //}
            
        }

        private void lbProgLan_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbProgLan.SelectedIndex == -1)
                return;

            ProgrammingLanguage temp = lbProgLan.SelectedItem as ProgrammingLanguage;
            tbName.Text = temp.Name;
            tbPopularity.Text = temp.Popularity.ToString();

            tbText.Text = lbProgLan.Text;
            tbValue.Text = lbProgLan.SelectedValue.ToString();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(tbName.Text) ||
                String.IsNullOrWhiteSpace(tbPopularity.Text))
                return;

            int popularity;

            if (!int.TryParse(tbPopularity.Text, out popularity))
                return;
            var prog = languages.Find(x => x.Name == tbName.Text);

            if (prog != null)
                return;


            ProgrammingLanguage language = new ProgrammingLanguage
            {
                Name = tbName.Text,
                Popularity = popularity
            };
            languages.Add(language);
            ClearDataSource();
        }

        private void ClearDataSource()
        {
            lbProgLan.DataSource = null;
            lbProgLan.DataSource = languages;
            lbProgLan.DisplayMember = "Name";
            lbProgLan.ValueMember = "Popularity";
            lbProgLan.SelectedIndex = -1;
            lbProgLan.SelectedItem = null;
            tbName.Text = "";
            tbPopularity.Text = "";
        }
    }
}
