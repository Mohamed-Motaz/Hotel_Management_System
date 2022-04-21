﻿using System;
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

namespace NU_Clinic
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
            this.ActiveControl = txtUser;
            txtUser.Focus();
        
        }


        //MySqlConnection con = new MySqlConnection("server = localhost; database = nuclinic; username = root; password = ;");
        int count;
        private string username, password;


        private void btnLogin_Click(object sender, EventArgs e)
        {
                login();
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
            DialogResult dialogResult = MessageBox.Show("Do you want to exit the application?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                Application.Exit();
            }
            else if (dialogResult == DialogResult.No)
            {
                //do something else
            }
        }

        public void select()
        {
           // MySqlConnection con = new MySqlConnection("server = localhost; database = nuclinic; username = root; password = ;");
            //SqlConnection Cn = new SqlConnection("server = localhost; database = nuclinic; username = root; password = ;");
            //SqlCommand Cmd = Cn.CreateCommand();
            //try
            //{
            //    SqlDataReader myReader = null;
            //    SqlCommand myCommand = new SqlCommand("select * firstname from user",Cn);
            //    myReader = myCommand.ExecuteReader();
            //    while (myReader.Read())
            //    {
            //       // textBox1.Text = myReader["Column1"].ToString();

            //    }
            //}
            //catch (Exception e)
            //{
            //    MessageBox.Show(e.ToString());
            //}
        }
        

       
    }
}
