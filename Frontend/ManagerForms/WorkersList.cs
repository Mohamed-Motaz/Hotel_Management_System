using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Frontend.ManagerForms
{
    public partial class WorkersList : Form
    {
        public WorkersList()
        {
            InitializeComponent();
        }
        public List<dynamic> getWorkers()
        {
            List<dynamic> workers = new List<dynamic>();
            
            
            
            dynamic worker = new ExpandoObject();
            worker.name = "Rawan";
            worker.id = "1";
            worker.age = "50";
            worker.email = "rawan@gmail.com";
            worker.phoneNumber = "01111111111";
            worker.salary = "10000";
            worker.jobTitle = "Manager";
            workers.Add(worker);

            dynamic worker1 = new ExpandoObject();
            worker1.name = "Salma";
            worker1.id = "2";
            worker1.age = "20";
            worker1.email = "salma@gmail.com";
            worker1.phoneNumber = "012351111111";
            worker1.salary = "15000";
            worker1.jobTitle = "Manager";
            workers.Add(worker1);


            return workers;
        }

        private void WorkersList_Load(object sender, EventArgs e)
        {
            setupWorkersListGridView();
        }
        private void setupWorkersListGridView()
        {
            WorkersListGridView.ColumnCount = 7;
            WorkersListGridView.Columns[0].Name = "ID";
            WorkersListGridView.Columns[1].Name = "Name";
            WorkersListGridView.Columns[2].Name = "Age";
            WorkersListGridView.Columns[3].Name = "Email";
            WorkersListGridView.Columns[4].Name = "PhoneNumber";
            WorkersListGridView.Columns[5].Name = "Salary";
            WorkersListGridView.Columns[6].Name = "Job Title";
            List<dynamic> workers = getWorkers();
            label1.Text = workers.Count.ToString();
            foreach (dynamic worker in workers)
            {
                DataGridViewRow row = (DataGridViewRow)WorkersListGridView.Rows[0].Clone();
                row.Cells[0].Value = worker.id;
                row.Cells[1].Value = worker.name;
                row.Cells[2].Value = worker.age; 
                row.Cells[3].Value = worker.email;
                row.Cells[4].Value = worker.phoneNumber;
                row.Cells[5].Value = worker.salary;
                row.Cells[6].Value = worker.jobTitle;

                WorkersListGridView.Rows.Add(row);

            }
            
        }

        private void bunifuMetroTextbox1_OnValueChanged(object sender, EventArgs e)
        {
            int cnt = 0;
            if (this.bunifuMetroTextbox1.Text != string.Empty)
            {
                try
                {
                    foreach (DataGridViewRow row in WorkersListGridView.Rows)
                    {
                        if (row.Cells[1].Value != null && row.Cells[1].Value.ToString().ToLower().Contains(bunifuMetroTextbox1.Text.ToLower()))
                        {
                            row.Visible = true;
                            cnt++;
                        }
                        else
                            row.Visible = false;

                    }

                }
                catch (Exception)
                {
                    //do Nothing
                }
            }
            else
            {
                foreach (DataGridViewRow row in WorkersListGridView.Rows)
                {
                    cnt++;
                    if (row.Visible != true)
                    {
                        row.Visible = true;
                    }
                }
                cnt--;
            }
            label1.Text = cnt.ToString();
        }
    }
}
