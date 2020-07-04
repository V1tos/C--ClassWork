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

namespace Lesson_13___Data_grid_view
{
    public partial class Form1 : Form
    {
        BookStore store = new BookStore();
        Garage garage = new Garage();
        DataSet data;
        public Form1()
        {
            InitializeComponent();
            toolStripStatusLabel1.Text = toolStripStatusLabel2.Text = "";
            InitData();
        }

        void InitData()
        {
            #region
            //1 way of fill DGV;
            foreach (Book item in store)
            {
                dataGridView1.Rows.Add(item.Title, item.Author, item.Availiable);
            }
            #endregion
            #region
            //2 way of fill DGV;
            foreach (Car item in garage)
            {
                bindingSource1.Add(item);
            }

            dataGridView2.DataSource = bindingSource1;
            tbBrend.DataBindings.Add("Text", bindingSource1, "Brend");
            tbModel.DataBindings.Add("Text", bindingSource1, "Model");
            tbCapacity.DataBindings.Add("Text", bindingSource1, "Capacity");
            #endregion
            #region
            //3 way of fill DGV
            data = new DataSet("EmployeeDataSet");
            DataTable table = CreateTable();
            data.Tables.Add(table);
            FillTable(data.Tables[0]);
            dataGridView3.DataSource = data.Tables[0];



            #endregion

        }

        private void FillTable(DataTable dataTable)
        {
            if (File.Exists("Employee.xml"))
            {
                data.ReadXml("Employee.xml");
                return;
            }
            
            Employees employees = new Employees();
            foreach (Employee item in employees)
            {
                dataTable.Rows.Add(item.Id, item.Name, item.Salary);
            }
        }

        private DataTable CreateTable()
        {
            DataTable table = new DataTable("Employee");
            DataColumn primaryKey = null;
            table.Columns.Add(primaryKey = new DataColumn("Id",typeof(int)));
            table.Columns.Add("Name", typeof(string));
            table.Columns.Add("Salary", typeof(int));

            table.PrimaryKey = new DataColumn[] { primaryKey };
            return table;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int row = e.RowIndex;
                tbAuthor.Text = dataGridView1.Rows[row].Cells[0].Value.ToString();
                tbTitle.Text = dataGridView1.Rows[row].Cells[1].Value.ToString();
                cbAvailiable.Checked = (bool)dataGridView1.Rows[row].Cells[2].Value;
            }
            catch(Exception ex)
            {
                tbAuthor.Text = tbTitle.Text = "";
                dataGridView1.EndEdit();
            }
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            toolStripStatusLabel1.Text = $"You clicked in ({e.RowIndex}, {e.ColumnIndex})";
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            data.WriteXml("Employee.xml");
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(tbID.Text) ||
               String.IsNullOrWhiteSpace(tbName.Text) ||
               String.IsNullOrWhiteSpace(tbSalary.Text))
                return;

            bool isParsedID = int.TryParse(tbID.Text, out int id);
            bool isParsedName = tbName.Text.Any(x => char.IsDigit(x));
            bool isParsedSalary = int.TryParse(tbSalary.Text, out int salary);

            foreach (DataRow row in data.Tables[0].Rows)
            {
                if (row[0].ToString().Equals(id.ToString()))
                {
                    isParsedID = false;
                    break;
                }
            }

            if (isParsedID && !isParsedName && isParsedSalary)
                data.Tables[0].Rows.Add(id, tbName.Text, salary);
           
        }
    }
}
