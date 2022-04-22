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
            passwordTextBox.Enabled = !isRoomService.Checked;

        }

        private void addWorkerBtn_Click(object sender, EventArgs e)
        {
            dynamic worker = new ExpandoObject();
            
            worker.id = idTextBox.Text;
            worker.name = nameTextBox.Text;
            worker.age = ageTextBox.Text;
            worker.email = emailTextBox.Text;
            worker.password = passwordTextBox.Text;
            worker.phoneNumber = phoneTextBox.Text;
            worker.salary = salaryTextBox.Text;
            worker.jobType = jobTitleTextBox.Text;
            worker.incomeType = incomeTypeTextBox.Text;

            // Pass password as null if the jobtype is Room Service
            if (isRoomService.Checked) { worker.password = ""; }

            //TODO: send to api addWorker

            clearBtn_Click(sender, e);
        }

        private void isRoomService_CheckedChanged(object sender, EventArgs e)
        {
            passwordTextBox.Enabled = !isRoomService.Checked;
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            idTextBox.Text = "";
            nameTextBox.Text = "";
            ageTextBox.Text = "";
            emailTextBox.Text = "";
            passwordTextBox.Text = "";
            phoneTextBox.Text = "";
            salaryTextBox.Text = "";
            jobTitleTextBox.Text = "";
            incomeTypeTextBox.Text = "";
        }
    }
}
