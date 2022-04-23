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

namespace Frontend
{
    public partial class ResidentLoginForm : Form
    {
        public ResidentLoginForm()
        {
            InitializeComponent();
            this.ActiveControl = txtUser;
            txtUser.Focus();
        
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

        private void ResidentLoginButton_Click(object sender, EventArgs e)
        {
            MainResidentForm residentForm = new MainResidentForm();
            residentForm.Show();
        }

        private void ResidentSignUpButton_Click(object sender, EventArgs e)
        {
            ResidentSignUpForm residentSignUpForm = new ResidentSignUpForm();
            residentSignUpForm.Show();

        }
    }
}
