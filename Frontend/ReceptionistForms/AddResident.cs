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
            resident.userName = UserNameTextBox.Text;
            resident.age = Convert.ToInt32( AgeTextBox.Text);
            resident.email = EmailTextBox.Text;
            resident.password = PasswordTextBox.Text;
            resident.phoneNumber = PhoneNumberTextBox.Text;

            if (Validate())
            {
                //send to api addResident
                dynamic resp = Service.AddResident(resident);
                if (resp.success = true)
                {
                    this.Hide();
                    MessageBox.Show("New resident has been added");
                }
                else
                {
                    MessageBox.Show("Cannot add this resident");
                }
            }
            clearBtn_Click(sender, e);

        }
        private void clearBtn_Click(object sender, EventArgs e)
        {
            UserNameTextBox.Text = "";
            AgeTextBox.Text = "";
            EmailTextBox.Text = "";
            PasswordTextBox.Text = "";
            PhoneNumberTextBox.Text = "";
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
            else if (PasswordTextBox.Text.Length == 0)
            {
                MessageBox.Show("Please enter a valid password.");
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
            return isOkay;
        }
    }
}