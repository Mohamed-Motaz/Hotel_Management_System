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

            nameTextBox.Text = worker.name;
            ageTextBox.Text = worker.age;
            emailTextBox.Text = worker.email;
            if (isRoomService.Checked) { worker.password = ""; }
            else { passwordTextBox.Text = worker.password; }
            phoneTextBox.Text = worker.phoneNumber;
            salaryTextBox.Text = worker.salary;
            jobTitleTextBox.Text = worker.jobType;
            incomeTypeTextBox.Text = worker.incomeType;
        }

        private void isRoomService_CheckedChanged(object sender, EventArgs e)
        {
            passwordTextBox.Enabled = !isRoomService.Checked;
        }

        private void editWorkerBtn_Click(object sender, EventArgs e)
        {
            //api takes all data and edit it 
            // and delete it
            clearBtn_Click(sender, e);
        }

        private void deleteWorkerBtn_Click(object sender, EventArgs e)
        {
            //api takes searchbyIdTextbox.Text , jobTitleTextBox.Text 
            // and delete it
            clearBtn_Click(sender,e);
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
            jobTitleTextBox.Text = "";
            incomeTypeTextBox.Text = "";
        }





        //apis needed
        //edit worker -> input worker object, typeOfWorker manager
        //delete worker -> input workerId,    typeOfWorker
        //getWorkers -> input nothing, output all workers and their types
    }
}
