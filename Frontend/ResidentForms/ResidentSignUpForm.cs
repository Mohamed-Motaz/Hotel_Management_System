using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data.SqlClient;
using Frontend.ManagerForms;
using Frontend.ReceptionistForms;
using Frontend.ResidentForms;
using System.Dynamic;
using System.Text.RegularExpressions;
using Frontend.HttpService;
namespace Frontend
{
    public partial class ResidentSignUpForm : Form
    {
        public ResidentSignUpForm()
        {
            InitializeComponent();
            this.ActiveControl = UserNameTextBox;
            UserNameTextBox.Focus();
        
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {

           frmMain managerMainForm = new frmMain();
            this.Hide();
            managerMainForm.Show();
        }
        private void frmLogin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnLogin_Click(sender, e);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblWarning.Text = "";
        }
        private void CloseButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
            //DialogResult dialogResult = MessageBox.Show("Do you want to exit the application?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            //if (dialogResult == DialogResult.Yes)
            //{
            //    Application.Exit();
            //}
            //else if (dialogResult == DialogResult.No)
            //{
            //    //do something else
            //}
        }

        private void ResidentSignUpButton_Click(object sender, EventArgs e)
        {
            dynamic resident = new ExpandoObject();
            resident.userName = UserNameTextBox.Text;
            resident.password = PasswordTextBox.Text;
            resident.email = EmailTextBox.Text;
            resident.age = AgeTextBox.Text;
            resident.phoneNumber = PhoneNumberTextBox.Text;
            // validation
            if (Validate()) // try tp user built in validate
            {
                // send to api addResident after validation
                Service.AddResident(resident);
             //   ResidentInformation.residentId = 1;
                MainResidentForm residentForm = new MainResidentForm();
                residentForm.Show();
            }
            else
            {
                MessageBox.Show("Please enter a valid data");
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
