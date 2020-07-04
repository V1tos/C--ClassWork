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

namespace HT___TeamsView
{
    public partial class Teams : Form
    {
        List<Unit> whiteTeam = new List<Unit>();
        List<Unit> blackTeam = new List<Unit>();
        Unit[] draftTeam = new[] { new Unit { Name = "Archer", HealthPoint = 6},
                                    new Unit { Name = "Mage", HealthPoint = 4 },
                                    new Unit { Name = "Swordman", HealthPoint = 10}};

        public Teams()
        {
            InitializeComponent();

            lbDraft.DataSource = draftTeam;
        }

        private void Teams_Load(object sender, EventArgs e)
        {

        }

        private void dupPlayerCount_SelectedItemChanged(object sender, EventArgs e)
        {
            dupPlayerCount.Text = dupPlayerCount.SelectedItem.ToString();
        }

        private void dupTeamView_SelectedItemChanged(object sender, EventArgs e)
        {
            dupTeamView.Text = dupTeamView.SelectedItem.ToString();

            if (dupTeamView.Text == "1")
                ClearDataSource(lbTeamView, whiteTeam);
            else if (dupTeamView.Text == "2")
                ClearDataSource(lbTeamView, blackTeam);
        }

        private void btnAddFirst_Click(object sender, EventArgs e)
        {
            if (whiteTeam.Count > dupPlayerCount.SelectedIndex)
                return;
            
            Unit unit = draftTeam[lbDraft.SelectedIndex];
            whiteTeam.Add(unit);
            ClearDataSource(lbTeam1, whiteTeam);
        }


        private void btnAddSecond_Click(object sender, EventArgs e)
        {
            if (blackTeam.Count > dupPlayerCount.SelectedIndex)
                return;

            Unit unit = draftTeam[lbDraft.SelectedIndex];
            blackTeam.Add(unit);
            ClearDataSource(lbTeam2, blackTeam);
        }

        private void ClearDataSource(ListBox lb, List<Unit> team)
        {
            lb.DataSource = null;
            lb.DataSource = team;
            lb.SelectedIndex = -1;
            lb.SelectedItem = null;
        }

        private void btnFirstSave_Click(object sender, EventArgs e)
        {
            SaveToXML(whiteTeam, "first");
        }

        private void btnSecondSave_Click(object sender, EventArgs e)
        {
            SaveToXML(whiteTeam, "second");
        }

        private void SaveToXML(List<Unit> team, string teamName)
        {
            string file = teamName + ".xml";
            XmlSerializer xml = new XmlSerializer(typeof(List<Unit>));  // typeof(EventList)

            using (Stream stream = new FileStream(file, FileMode.Create, FileAccess.Write))
            {
                xml.Serialize(stream, team);
            }
            MessageBox.Show("Completed!");
        }
    }
}
