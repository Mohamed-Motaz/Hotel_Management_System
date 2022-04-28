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

            incomeTypeComboBox.Items.Add("Weekly");
            incomeTypeComboBox.Items.Add("Monthly");
            incomeTypeComboBox.Items.Add("Yearly");

            passwordTextBox.Enabled = !isRoomServices.Checked;
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
            try
            {
                worker.age = Convert.ToInt32(ageTextBox.Text);
                worker.salary = Convert.ToDouble(salaryTextBox.Text);
                worker.userName = nameTextBox.Text;
            }catch(Exception ex)
            {
                // do Nothing
            }
            worker.email = emailTextBox.Text;
            worker.phoneNumber = phoneTextBox.Text;
            worker.jobTitle = JobTitleComboBox.GetItemText(JobTitleComboBox.SelectedItem);
            worker.incomeType = " ";
            // Pass password as null if the jobtype is Room Service
            if (CheckIfWorkerIsPrivileged())
            {
                worker.password = passwordTextBox.Text;
                passwordTextBox.Enabled = true;
            }
            else
                worker.password = null;

            dynamic resp = Service.AddWorker(worker);

            if (resp.success == true)
            {
                this.Hide();
                MessageBox.Show("New worker has been added");
            }
            else
            {
                MessageBox.Show("Cannot add this worker");
            }

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
        }

        private void IsRoomService(object sender, EventArgs e)
        {
            passwordTextBox.Enabled = !isRoomServices.Checked;
        }
    }
}
