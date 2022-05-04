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
namespace Frontend.ManagerForms
{
    public partial class EditOrDeleteWorker : Form
    {
        dynamic worker;

        public EditOrDeleteWorker()
        {
            InitializeComponent();
        }

        private void EditOrDeleteWorker_Load(object sender, EventArgs e)
        {
            worker = new ExpandoObject();
            PasswordTextBox.Enabled = !isRoomService.Checked;
            JobTitleComboBox.Items.Add("Manager");
            JobTitleComboBox.Items.Add("Room Service");
            JobTitleComboBox.Items.Add("Receptionist");

            IncomeTypeComboBox.Items.Add("Weekly");
            IncomeTypeComboBox.Items.Add("Monthly");
            IncomeTypeComboBox.Items.Add("Yearly");
        }

        private bool CheckIfWorkerIsPrivileged()
        {
            bool isManager = JobTitleComboBox.GetItemText(JobTitleComboBox.SelectedItem).Equals("Manager");
            bool isReceptionist = JobTitleComboBox.GetItemText(JobTitleComboBox.SelectedItem).Equals("Receptionist");
            return isManager || isReceptionist;
        }
        private void searchByIdBtn_Click(object sender, EventArgs e)
        {
            if ((searchbyIdTextbox.Text.Length == 0))
            {
                MessageBox.Show("Please enter a valid id.");
            }
            else
            {
                worker.id = searchbyIdTextbox.Text;

                //TODO: api set worker to the api returend worker
                dynamic obj = new ExpandoObject();
                obj.id = Convert.ToInt32(searchbyIdTextbox.Text);
                dynamic work = Service.GetWorkerById(obj);
                UserNameTextBox.Text = work.userName.ToString();
                AgeTextBox.Text = work.age.ToString();
                EmailTextBox.Text = work.email.ToString();
                JobTitleComboBox.SelectedItem = work.jobTitle.ToString();
                try
                {
                    if (isRoomService.Checked) { work.password = ""; }
                    else { PasswordTextBox.Text = work.password.ToString(); }
                }
                catch (Exception ex)
                {
                    // dp nothing
                }

                PhoneNumberTextBox.Text = work.phoneNumber.ToString();
                SalaryTextBox.Text = work.salary.ToString();
                IncomeTypeComboBox.SelectedItem = work.incomeType.ToString();
            }
        }

        private void isRoomService_CheckedChanged(object sender, EventArgs e)
        {
            PasswordTextBox.Enabled = !isRoomService.Checked;
        }

        private void editWorkerBtn_Click(object sender, EventArgs e)
        {
            //api takes all data and edit it
            dynamic obj = new ExpandoObject();
            obj.id = searchbyIdTextbox.Text;
            obj.userName = UserNameTextBox.Text;
            obj.age = AgeTextBox.Text;
            obj.email = EmailTextBox.Text;
            obj.phoneNumber = PhoneNumberTextBox.Text;
            obj.salary = SalaryTextBox.Text;
            obj.incomeType = IncomeTypeComboBox.GetItemText(IncomeTypeComboBox.SelectedItem);
            obj.jobTitle = JobTitleComboBox.GetItemText(JobTitleComboBox.SelectedItem);
            bool WorkerIsPrivileged = false;
            if (CheckIfWorkerIsPrivileged())
            {
                obj.password = PasswordTextBox.Text;
                PasswordTextBox.Enabled = true;
                WorkerIsPrivileged = true;
            }
            else
                obj.password = null;
            if (Validate())
            {
                if (WorkerIsPrivileged && PasswordTextBox.Text.Length == 0)
                {
                    MessageBox.Show("Please enter a valid password.");
                }
                else
                {
                    dynamic resp = Service.EditWorker(obj);

                    if (resp.success == true)
                    {
                        this.Hide();
                        MessageBox.Show("This worker has been edited successfuly");
                    }
                    else
                    {
                        MessageBox.Show("Cannot edit this worker");
                    }
                }
            }
            // and delete it
            clearBtn_Click(sender, e);
        }

        private void deleteWorkerBtn_Click(object sender, EventArgs e)
        {
            dynamic obj = new ExpandoObject();
            obj.id = searchbyIdTextbox.Text;

            
            dynamic resp = Service.DeleteWorker(obj);

            if (resp.success == true)
            {
                this.Hide();
                MessageBox.Show("This worker has been deleted successfuly");
            }
            else
            {
                MessageBox.Show("Cannot delete this worker");
            }
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            searchbyIdTextbox.Text = "";
            UserNameTextBox.Text = "";
            AgeTextBox.Text = "";
            EmailTextBox.Text = "";
            PasswordTextBox.Text = "";
            PhoneNumberTextBox.Text = "";
            SalaryTextBox.Text = "";
        }
        private bool Validate()
        {
            bool isOkay = true;
            string email = EmailTextBox.Text;
            Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            Match match = regex.Match(email);
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
            else if (!match.Success)
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




        //apis needed
        //edit worker -> input worker object, typeOfWorker manager
        //delete worker -> input workerId,    typeOfWorker
        //getWorkers -> input nothing, output all workers and their types
    }
}
