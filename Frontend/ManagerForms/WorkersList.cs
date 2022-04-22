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
            worker.id = 1;
            worker.email = "rawan@gmail.com";
            worker.phoneNumber = 01111111111;
            worker.salary = 10000;
            worker.jobTitle = "Manager";
            workers.Add(worker);
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
            foreach (dynamic worker in workers)
                WorkersListGridView.Rows.Add(worker);
        }
    }
}
