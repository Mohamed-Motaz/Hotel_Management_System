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

namespace Frontend.ReceptionistForms
{
    public partial class frmMainReceptionist : Form
    {

        ManageResidents manageResidents = new ManageResidents();
        ManageReservations manageReservations = new ManageReservations();
        public frmMainReceptionist()
        {
            InitializeComponent();


            //chart1.Series["Data"]["PixelPointWidth"] = "30";
            //chart2.Series["Data"]["PixelPointWidth"] = "30";
            //label25.Text = dataGridView1.RowCount.ToString();
            //bunifuDatepicker1.Value = DateTime.Now;
            //bunifuDatepicker2.Value = DateTime.Now;

            clearAllPanels();
            openManageResidents();

            activeUserLabel.Text = "Mohamed Motaz";
            activeUserLabel.BringToFront(); //todo
        }


        //MySqlConnection con = new MySqlConnection("server = localhost; database = nuclinic; username = root; password = ; Convert Zero Datetime=True");


        private string firstname,lastname,middlename,username;

        public string Lastname
        {
            get { return lastname; }
            set { lastname = value; }
        }

        public string Firstname
        {
            get { return firstname; }
            set { firstname = value; }
        }
        public string Middlename
        {
            get { return middlename; }
            set { middlename = value; }
        }
        public string Username
        {
            get { return username; }
            set { username = value; }
        }

        private void btnLogout_Click_1(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Do you want to logout "+ Firstname + "?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                frmLogin frm = new frmLogin();
                this.Hide();
                frm.Show();
            }
            else if (dialogResult == DialogResult.No)
            {
                //do something else
            }
        }



        private void frmMain_Load(object sender, EventArgs e)
        {
            load();
        }

        private void bunifuDatepicker1_onValueChanged(object sender, EventArgs e)
        {
            //var date = bunifuDatepicker1.Value;
            //dateTimePicker1.Value = date;
            
        }

        private void bunifuDatepicker2_onValueChanged(object sender, EventArgs e)
        {
            //var date = bunifuDatepicker2.Value;
            //dateTimePicker2.Value = date;
        }



        public void load()
        {
            timer1.Start();
            time.Text = DateTime.Now.ToLongTimeString();
            label.Text = "  " + Firstname + " " + Middlename + " " + Lastname;
            activeUserLabel.Text = Firstname + " " + Middlename + " " + Lastname;
            date.Text = DateTime.Now.ToLongDateString();
            time.Text = DateTime.Now.ToLongTimeString();
            bunifuFlatButton1.Text = "Dashboard";
            label3.Text = username;

        }


        private void clearAllPanels()
        {

            try { this.panel1.Controls.Remove(manageResidents); } catch (Exception e) { }
            try { this.panel1.Controls.Remove(manageReservations); } catch (Exception e) { }


            try { manageResidents.Close(); } catch (Exception e) { }
            try { manageReservations.Close(); } catch (Exception e) { }
        }



        private void openManageResidents()
        {
            //set the correct line
            manageReservationsLine.Visible = false;
            manageResidentsLine.Visible = true;


            manageResidents = new ManageResidents();
            manageResidents.TopLevel = false;
            manageResidents.AutoScroll = true;
            manageResidents.TopMost = true;
            manageResidents.Dock = DockStyle.Fill;
            manageResidents.ControlBox = false;
            manageResidents.Text = String.Empty;

            this.panel1.Controls.Add(manageResidents);
            manageResidents.Show();
        }

        private void openManageReservations()
        {
            //set the correct line
            manageReservationsLine.Visible = true;
            manageResidentsLine.Visible = false;

            manageReservations = new ManageReservations();
            manageReservations.TopLevel = false;
            manageReservations.AutoScroll = true;
            manageReservations.TopMost = true;
            manageReservations.Dock = DockStyle.Fill;
            manageReservations.ControlBox = false;
            manageReservations.Text = String.Empty;

            this.panel1.Controls.Add(manageReservations);
            manageReservations.Show();
        }

       
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }


        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void manageReservationsButton_Click(object sender, EventArgs e)
        {
            clearAllPanels();
            openManageReservations();
        }

        private void manageResidentsButton_Click(object sender, EventArgs e)
        {
            clearAllPanels();
            openManageResidents();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            time.Text = DateTime.Now.ToLongTimeString();
            timer1.Start();
        }
      
    }
}
