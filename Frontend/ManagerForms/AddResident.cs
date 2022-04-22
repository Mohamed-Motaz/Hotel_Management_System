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
    public partial class AddResident : Form
    {
        public AddResident()
        {
            InitializeComponent();
        }

        private void addResidentBtn_Click(object sender, EventArgs e)
        {
            dynamic resident = new  ExpandoObject();
            resident.id = idTextBox.Text;
            resident.name = nameTextBox.Text;
            resident.age = ageTextBox.Text;
            resident.email = emailTextBox.Text;
            resident.password = passwordTextBox.Text;
            resident.phoneNumber = phoneTextBox.Text;


            //send to api addResident

        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            idTextBox.Text = "";
            nameTextBox.Text = "";
            ageTextBox.Text = "";
            emailTextBox.Text = "";
            passwordTextBox.Text = "";
            phoneTextBox.Text = "";
        }
    }
}
