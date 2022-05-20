using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
            PasswordTextBox.Enabled = false;
            JobTitleComboBox.Items.Add("Manager");
            JobTitleComboBox.Items.Add("Room Service");
            JobTitleComboBox.Items.Add("Receptionist");

            IncomeTypeComboBox.Items.Add("Weekly");
            IncomeTypeComboBox.Items.Add("Monthly");
            IncomeTypeComboBox.Items.Add("Yearly");

            PasswordTextBox.Enabled = !isRoomServices.Checked;
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
                worker.age = Convert.ToInt32(AgeTextBox.Text);
                worker.salary = Convert.ToDouble(SalaryTextBox.Text);
                worker.userName = UserNameTextBox.Text;
            }catch(Exception ex)
            {
                // do Nothing
            }
            worker.email = EmailTextBox.Text;
            worker.phoneNumber = PhoneNumberTextBox.Text;
            worker.jobTitle = JobTitleComboBox.GetItemText(JobTitleComboBox.SelectedItem);
            worker.incomeType = IncomeTypeComboBox.GetItemText(IncomeTypeComboBox.SelectedItem);
            // Pass password as null if the jobtype is Room Service
            bool WorkerIsPrivileged = false;
            if (CheckIfWorkerIsPrivileged())
            {
                worker.password = PasswordTextBox.Text;
                PasswordTextBox.Enabled = true;
                WorkerIsPrivileged = true;
            }
            else
                worker.password = null;
            if (Validate())
            {
                if (WorkerIsPrivileged && PasswordTextBox.Text.Length == 0)
                {
                    MessageBox.Show("Please enter a valid password.");
                }
                else
                {
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
                }
            }

            ClearWorkerButton_Click(sender, e);
        }

        private void ClearWorkerButton_Click(object sender, EventArgs e)
        {
            UserNameTextBox.Text = "";
            AgeTextBox.Text = "";
            EmailTextBox.Text = "";
            PasswordTextBox.Text = "";
            PhoneNumberTextBox.Text = "";
            SalaryTextBox.Text = "";
           
        }

        private void IsRoomService(object sender, EventArgs e)
        {
            PasswordTextBox.Enabled = !isRoomServices.Checked;
        }
        private bool Validate()
        {
            bool isOkay = true;
            string email = EmailTextBox.Text;
            Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            Match match = regex.Match(email);
            PasswordTextBox.Enabled = false;
            if ((UserNameTextBox.Text.Length == 0))
            {
                MessageBox.Show("Please enter a valid user name.");
                isOkay = false;
            }
            else if ((SalaryTextBox.Text.Length == 0))
            {
                MessageBox.Show("Please enter a valid salary.");
                isOkay = false;
            }
            else if (int.Parse(AgeTextBox.Text) < 0 || (AgeTextBox.Text.Length == 0))
            {
                MessageBox.Show("Please enter a valid age.");
                isOkay = false;
            }
            else if (PhoneNumberTextBox.Text.Length == 0 || (PhoneNumberTextBox.Text.Length != 11))
            {
                MessageBox.Show("Please enter a valid phone number.");
                isOkay = false;
            }
            else if (EmailTextBox.Text.Length == 0)
            {
                MessageBox.Show("Please enter a valid email.");
                isOkay = false;
            }
            else if (string.IsNullOrEmpty(IncomeTypeComboBox.Text))
            {
                MessageBox.Show("Please choose a valid income type.");
                isOkay = false;
            }
            else if (string.IsNullOrEmpty(JobTitleComboBox.Text))
            {
                MessageBox.Show("Please choose a valid job tilte.");
                isOkay = false;
            }
            return isOkay;
        }

        private void isRoomServices_EnabledChanged(object sender, EventArgs e)
        {
            PasswordTextBox.Text = "";
        }
    }
}
