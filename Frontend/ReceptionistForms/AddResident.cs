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
    public partial class AddResident : Form
    {
        public AddResident()
        {
            InitializeComponent();
        }

        private void addResidentBtn_Click(object sender, EventArgs e)
        {
            dynamic resident = new ExpandoObject();
            resident.userName = nameTextBox.Text;
            resident.age = Convert.ToInt32( ageTextBox.Text);
            resident.email = emailTextBox.Text;
            resident.password = passwordTextBox.Text;
            resident.phoneNumber = phoneTextBox.Text;


            //send to api addResident
            Service.AddResident(resident);

            clearBtn_Click(sender, e);

        }
        private void clearBtn_Click(object sender, EventArgs e)
        {
            nameTextBox.Text = "";
            ageTextBox.Text = "";
            emailTextBox.Text = "";
            passwordTextBox.Text = "";
            phoneTextBox.Text = "";
        }
    }
}