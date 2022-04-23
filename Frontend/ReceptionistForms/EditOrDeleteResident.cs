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
            // and delete it
            clearBtn_Click(sender, e);
        }

        private void deleteWorkerBtn_Click(object sender, EventArgs e)
        {

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

            //TODO: api set resident to the api returend resident

            nameTextBox.Text = resident.name;
            ageTextBox.Text = resident.age;
            emailTextBox.Text = resident.email;
            passwordTextBox.Text = resident.password;
            phoneTextBox.Text = resident.phoneNumber;
        }

        private void editResidentBtn_Click(object sender, EventArgs e)
        {
            //api takes all data and edit it 
            // and clear it
            clearBtn_Click(sender, e);
        }

        private void deleteResidentBtn_Click(object sender, EventArgs e)
        {
            //api takes searchbyIdTextbox.Text , jobTitleTextBox.Text 
            // and clear it
            clearBtn_Click(sender, e);
        }
    }
}
