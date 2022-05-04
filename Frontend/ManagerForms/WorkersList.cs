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
using Frontend.HttpService;
namespace Frontend.ManagerForms
{
    public partial class WorkersList : Form
    {
        public WorkersList()
        {
            InitializeComponent();
        }
        

        private void WorkersList_Load(object sender, EventArgs e)
        {
            setupWorkersListGridView();
        }
        private void setupWorkersListGridView()
        {
            WorkersListGridView.ColumnCount = 9;
            WorkersListGridView.Columns[0].Name = "ID";
            WorkersListGridView.Columns[1].Name = "Name";
            WorkersListGridView.Columns[2].Name = "Age";
            WorkersListGridView.Columns[3].Name = "Email";
            WorkersListGridView.Columns[4].Name = "PhoneNumber";
            WorkersListGridView.Columns[5].Name = "Salary";
            WorkersListGridView.Columns[6].Name = "Job Title";
            WorkersListGridView.Columns[7].Name = "Income Type";
            WorkersListGridView.Columns[8].Name = "Password";
            List<dynamic> workers = Service.GetAllWorkers();
            label1.Text = workers.Count.ToString();
            foreach (dynamic worker in workers)
            {
                DataGridViewRow row = (DataGridViewRow)WorkersListGridView.Rows[0].Clone();
                row.Cells[0].Value = worker.id.ToString();
                row.Cells[1].Value = worker.userName.ToString();
                row.Cells[2].Value = worker.age.ToString(); 
                row.Cells[3].Value = worker.email.ToString();
                row.Cells[4].Value = worker.phoneNumber.ToString();
                row.Cells[5].Value = worker.salary.ToString();
                row.Cells[6].Value = worker.jobTitle.ToString();
                row.Cells[7].Value = worker.incomeType.ToString();
                try
                {
                    row.Cells[8].Value = worker.password.ToString();
                }
                catch (Exception) { }
                
                WorkersListGridView.Rows.Add(row);

            }
            
        }
        private void SearchTextbox_OnValueChanged(object sender, EventArgs e)
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
