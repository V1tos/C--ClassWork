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


namespace Lesson_7___Event_planner
{
    
    public partial class EventPlanner : Form
    {
        public EventPlanner()
        {
            InitializeComponent();
        }
        List<Event> eventList = new List<Event>();
        Event myEvent;

        private void EventPlanner_Load(object sender, EventArgs e)
        {
            myEvent = new Event();
            tbName.Text = "Name";
            tbPlace.Text = "Place";
            tbName.Focus();
        }

        private void tbName_MouseClick(object sender, MouseEventArgs e)
        {
            tbName.Text = String.Empty;
        }

        private void EventPlanner_MouseClick(object sender, MouseEventArgs e)
        {

            
        }

        private void tbPlace_MouseClick(object sender, MouseEventArgs e)
        {
            tbPlace.Text = String.Empty;
            if (String.IsNullOrWhiteSpace(tbName.Text))
            {
                MessageBox.Show("You must to specify name", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                tbName.Focus();
                EventPlanner_Load(null, null);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddEvent();
            TaskList.Items.Add(myEvent.ToString());
            EventPlanner_Load(null, null);
        }

        private void AddEvent()
        {
            myEvent.Name = tbName.Text;
            myEvent.Place = tbPlace.Text;
            myEvent.Date = dtpEvent.Value;  
            
            if (dtpEvent.Value.Day == DateTime.Now.Day)
                myEvent.Date = new DateTime(DateTime.Today.Year, DateTime.Today.Month, DateTime.Today.Day+1);

            if (cbPriority.SelectedItem != null)
                myEvent.Priority = cbPriority.SelectedItem.ToString();
            else
                myEvent.Priority = "Medium";

            eventList.Add(myEvent);
        }

        private void DeletEvents()
        {
            
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            eventList.Clear();
            TaskList.Items.Clear();
            EventPlanner_Load(null, null);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string file = dtpEvent.Value.ToString() + ".xml";
            XmlSerializer xml = new XmlSerializer(typeof(Event));  // typeof(EventList)

            using (Stream stream = new FileStream("Event.xml", FileMode.Create,FileAccess.Write))
            {
                xml.Serialize(stream, myEvent);
            }
            MessageBox.Show("Completed!");
        }
    }
}
                
               
        

