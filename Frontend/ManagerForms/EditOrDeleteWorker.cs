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
            passwordTextBox.Enabled = !isRoomService.Checked;
        }


        private void searchByIdBtn_Click(object sender, EventArgs e)
        {
            worker.id = searchbyIdTextbox.Text;

            //TODO: api set worker to the api returend worker
            dynamic obj = new ExpandoObject();
            obj.id = Convert.ToInt32( searchbyIdTextbox.Text);
            dynamic work = Service.GetWorkerById(obj);
            nameTextBox.Text = work.userName.ToString();
            ageTextBox.Text = work.age.ToString();
            emailTextBox.Text = work.email.ToString();
            jobTitleTextbox.Text = work.jobTitle.ToString();
            try
            {
                if (isRoomService.Checked) { work.password = ""; }
                else { passwordTextBox.Text = work.password.ToString(); }
            }catch(Exception ex)
            {
                // dp nothing
            }
                
             phoneTextBox.Text = work.phoneNumber.ToString();
            salaryTextBox.Text = work.salary.ToString();
            incomeTypeTextBox.Text = work.incomeType.ToString();
        }

        private void isRoomService_CheckedChanged(object sender, EventArgs e)
        {
            passwordTextBox.Enabled = !isRoomService.Checked;
        }

        private void editWorkerBtn_Click(object sender, EventArgs e)
        {
            //api takes all data and edit it
            dynamic obj = new ExpandoObject();
            obj.id = searchbyIdTextbox.Text;
            obj.userName = nameTextBox.Text;
            obj.age = ageTextBox.Text;
            obj.email = emailTextBox.Text;
            obj.password = passwordTextBox.Text;
            obj.phoneNumber = phoneTextBox.Text;
            obj.salary = salaryTextBox.Text;
            obj.incomeType = incomeTypeTextBox.Text;
            obj.jobTitle = jobTitleTextbox.Text;
            
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
            nameTextBox.Text = "";
            ageTextBox.Text = "";
            emailTextBox.Text = "";
            passwordTextBox.Text = "";
            phoneTextBox.Text = "";
            salaryTextBox.Text = "";
            jobTitleTextbox.Text = "";
            incomeTypeTextBox.Text = "";
        }





        //apis needed
        //edit worker -> input worker object, typeOfWorker manager
        //delete worker -> input workerId,    typeOfWorker
        //getWorkers -> input nothing, output all workers and their types
    }
}
