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
namespace Frontend.ReceptionistForms
{
    public partial class EditOrDeleteResident : Form
    {
        dynamic resident;

        public EditOrDeleteResident()
        {
            InitializeComponent();
        }

        private void EditOrDeleteResident_Load(object sender, EventArgs e)
        {
            resident = new ExpandoObject();
        }

        private void editWorkerBtn_Click(object sender, EventArgs e)
        {
            //api takes all data and edit it
            dynamic obj = new ExpandoObject();
            obj.id = searchbyIdTextbox.Text;
            obj.username = nameTextBox.Text;
            obj.age = ageTextBox.Text;
            obj.email = emailTextBox.Text;
            obj.password = passwordTextBox.Text;
            obj.phoneNumber = phoneTextBox.Text;
            

            Service.EditResident(obj);
            // and delete it
            clearBtn_Click(sender, e);
        }

        private void deleteWorkerBtn_Click(object sender, EventArgs e)
        {
            dynamic obj = new ExpandoObject();
            obj.id = searchbyIdTextbox.Text;

            Service.DeleteResident(obj);
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            searchbyIdTextbox.Text = "";
            nameTextBox.Text = "";
            ageTextBox.Text = "";
            emailTextBox.Text = "";
            passwordTextBox.Text = "";
            phoneTextBox.Text = "";
        }

        private void searchByIdBtn_Click(object sender, EventArgs e)
        {
            resident.id = searchbyIdTextbox.Text;
            dynamic obj = new ExpandoObject();
            obj.id = resident.id;
            //TODO: api set resident to the api returend resident
            dynamic res = Service.GetResident(obj);
            nameTextBox.Text = res.username;
            ageTextBox.Text = res.age;
            emailTextBox.Text = res.email;
            passwordTextBox.Text = res.password;
            phoneTextBox.Text = res.phoneNumber;
        }

        private void editResidentBtn_Click(object sender, EventArgs e)
        {
            //api takes all data and edit it
            dynamic obj = new ExpandoObject();
            obj.id = searchbyIdTextbox.Text;
            obj.username = nameTextBox.Text;
            obj.age = ageTextBox.Text;
            obj.email = emailTextBox.Text;
            obj.password = passwordTextBox.Text;
            obj.phoneNumber = phoneTextBox.Text;

            Service.EditResident(obj);

            // and delete it
            clearBtn_Click(sender, e);
        }

        private void deleteResidentBtn_Click(object sender, EventArgs e)
        {
            //api takes searchbyIdTextbox.Text , jobTitleTextBox.Text 
            // and clear it
            dynamic obj = new ExpandoObject();
            obj.id = searchbyIdTextbox.Text;

            Service.DeleteResident(obj);
            clearBtn_Click(sender, e);
        }
    }
}
