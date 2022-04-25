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
using Frontend.HttpService;

namespace Frontend
{
    public partial class WorkerLoginForm : Form
    {
        public WorkerLoginForm()
        {
            InitializeComponent();
            this.ActiveControl = txtUser;
            txtUser.Focus();
        
        }


        int count;
        private string username, password;

        public string LogInCheck()
        {
            dynamic obj = new ExpandoObject();
            obj.userName = txtUser.Text;
            obj.password = txtPass.Text;
            obj.worker = true;
            return Service.SignIn(obj);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //login();
            if (LogInCheck() == "Manager")
            {
                frmMain managerMainForm = new frmMain();
                this.Hide();
                managerMainForm.Show();
            }
            else
            {
                MessageBox.Show("Please enter a valid data");
            }
        }

        private void login()
        {
            try
            {
                username = txtUser.Text;
                password = txtPass.Text;

                count = count + 1;

                
                if (username == "" && password == "")
                {
                    lblWarning.Text = "Username and Password can't be blank";
                }


                else
                {
                    //string query = "select * from user where username = '" + username + "'&& password = '" + password + "' ";
                    //MySqlDataAdapter data = new MySqlDataAdapter(query, con);
                    DataTable dt = new DataTable();
                    //data.Fill(dt);

                    //if (dt.Rows.Count == 1)
                    //{
                    //MessageBox.Show("Access Granted. Welcome " + dt.Rows[0]["firstname"].ToString() + " " + dt.Rows[0]["middlename"].ToString() + " " + dt.Rows[0]["lastname"].ToString() + "!");

                    frmMain ma = new frmMain();


                    this.Hide();
                    ma.Firstname = "mohamed";
                    ma.Middlename = "mo3taz";
                    ma.Lastname = "elzein";
                    ma.Username = "momo";
                    ma.Show();
                    //}
                    //else
                    //{
                    //    lblWarning.Text = "Please try again";
                    //    txtUser.Clear();
                    //    txtPass.Clear();
                    //    txtUser.Focus();
                    //}


                }
            } catch (Exception ex)
                {
                MessageBox.Show("Warning: " + ex.ToString());
                }
        }
       
        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            txtUser.Clear();
            txtPass.Clear();
        }


        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            //DialogResult dialogResult = MessageBox.Show("Do you want to exit the application?", "", MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            //if (dialogResult == DialogResult.Yes)
            //{
            //    Application.Exit();
            //}
            //else if (dialogResult == DialogResult.No)
            //{
            //    //do something else
            //}
        }

        private void button1_Click(object sender, EventArgs e)
        {
            login();
            //select();
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

        private void bunifuTileButton1_Click(object sender, EventArgs e)
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

        private void bunifuFlatButton1_Click_1(object sender, EventArgs e)
        {
            if (LogInCheck() == "Receptionist")
            {
                frmMainReceptionist frmMainReceptionist = new frmMainReceptionist();
                this.Hide();
                frmMainReceptionist.Show();
            }
            else
            {
                MessageBox.Show("Please enter a valid data");
            }
        }

    }
}
