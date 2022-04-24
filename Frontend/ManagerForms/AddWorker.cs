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
namespace Frontend.Extras
{
    public partial class AddWorker : Form
    {
        public AddWorker()
        {
            InitializeComponent();
        }

        private void AddWorker_Load(object sender, EventArgs e)
        {
            passwordTextBox.Enabled = false;
            JobTitleComboBox.Items.Add("Manager");
            JobTitleComboBox.Items.Add("Room Service");
            JobTitleComboBox.Items.Add("Receptionist");
            passwordTextBox.Enabled = !isRoomServices.Checked;
        }
        private void addWorkerBtn_Click(object sender, EventArgs e)
        {
            dynamic worker = new ExpandoObject();

            worker.name = nameTextBox.Text;
            worker.age = ageTextBox.Text;
            worker.email = emailTextBox.Text;
            worker.phoneNumber = phoneTextBox.Text;
            worker.salary = salaryTextBox.Text;
            worker.jobTitle = JobTitleComboBox.GetItemText(JobTitleComboBox.SelectedItem);
            worker.incomeType = incomeTypeTextBox.Text;
            // Pass password as null if the jobtype is Room Service
            if (CheckIfWorkerIsPrivileged())
                worker.password = passwordTextBox.Text;

            else
                worker.password = "";

            //TODO: send to api addWorker
            Service.AddWorker(worker);

            ClearWorkerButton_Click(sender, e);
        }
        private bool CheckIfWorkerIsPrivileged()
        {
            bool isManager = JobTitleComboBox.GetItemText(JobTitleComboBox.SelectedItem).Equals("Manager");
            bool isReceptionist = JobTitleComboBox.GetItemText(JobTitleComboBox.SelectedItem).Equals("Receptionist");
            return isManager || isReceptionist;
        }
        private void AddWorkerBtn_Click(object sender, EventArgs e)
        {
            dynamic worker = new ExpandoObject();

            worker.name = nameTextBox.Text;
            worker.age = ageTextBox.Text;
            worker.email = emailTextBox.Text;
            worker.phoneNumber = phoneTextBox.Text;
            worker.salary = salaryTextBox.Text;
            worker.jobTitle = JobTitleComboBox.GetItemText(JobTitleComboBox.SelectedItem);
            worker.incomeType = incomeTypeTextBox.Text;
            // Pass password as null if the jobtype is Room Service
            if (CheckIfWorkerIsPrivileged())
            {
                worker.password = passwordTextBox.Text;
                passwordTextBox.Enabled = true;
            }
            else
                worker.password = "";

            //TODO: send to api addWorker
            Service.AddWorker(worker);

            ClearWorkerButton_Click(sender, e);
        }

        private void ClearWorkerButton_Click(object sender, EventArgs e)
        {
            nameTextBox.Text = "";
            ageTextBox.Text = "";
            emailTextBox.Text = "";
            passwordTextBox.Text = "";
            phoneTextBox.Text = "";
            salaryTextBox.Text = "";
            incomeTypeTextBox.Text = "";
        }

        private void IsRoomService(object sender, EventArgs e)
        {
            passwordTextBox.Enabled = !isRoomServices.Checked;
        }
    }
}
