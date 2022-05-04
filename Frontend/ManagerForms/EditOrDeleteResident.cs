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


        private void clearBtn_Click(object sender, EventArgs e)
        {
            searchbyIdTextbox.Text = "";
            UserNameTextBox.Text = "";
            AgeTextBox.Text = "";
            EmailTextBox.Text = "";
            PasswordTextBox.Text = "";
            PhoneNumberTextBox.Text = "";
        }

        private void searchByIdBtn_Click(object sender, EventArgs e)
        {
            if ((searchbyIdTextbox.Text.Length == 0))
            {
                MessageBox.Show("Please enter a valid id.");
            }
            else
            {
                resident.id = searchbyIdTextbox.Text;
                dynamic obj = new ExpandoObject();
                obj.id = searchbyIdTextbox.Text;
                //TODO: api set resident to the api returend resident
                dynamic res = Service.GetResident(obj);

                UserNameTextBox.Text = res.name.ToString();
                AgeTextBox.Text = res.age.ToString();
                EmailTextBox.Text = res.email.ToString();
                PasswordTextBox.Text = res.password.ToString();
                PhoneNumberTextBox.Text = res.phoneNumber.ToString();
            }
        }

        private void editResidentBtn_Click(object sender, EventArgs e)
        {
            //api takes all data and edit it
            dynamic obj = new ExpandoObject();
            obj.id = searchbyIdTextbox.Text;
            obj.userName = UserNameTextBox.Text;
            obj.age = AgeTextBox.Text;
            obj.email = EmailTextBox.Text;
            obj.password = PasswordTextBox.Text;
            obj.phoneNumber = PhoneNumberTextBox.Text;

            if (Validate())
            {
                dynamic resp = Service.EditResident(obj);

                if (resp.success == true)
                {
                    this.Hide();
                    MessageBox.Show("This resident has been edited successfuly");
                }
                else
                {
                    MessageBox.Show("Cannot edit this resident");
                }
            }
            clearBtn_Click(sender, e);
        }

        private void deleteResidentBtn_Click(object sender, EventArgs e)
        {
            dynamic obj = new ExpandoObject();
            obj.id = searchbyIdTextbox.Text;

            
            dynamic resp = Service.DeleteResident(obj);

            if (resp.success == true)
            {
                this.Hide();
                MessageBox.Show("This resident has been deleted successfuly");
            }
            else
            {
                MessageBox.Show("Cannot delete this resident");
            }
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
