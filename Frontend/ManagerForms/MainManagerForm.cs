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
using Frontend.Extras;

namespace Frontend
{
    public partial class frmMain : Form
    {

        Dashboard dashboard = new Dashboard();
        RoomsStatus roomsStatus = new RoomsStatus();
        ManageResidents manageResidents = new ManageResidents();
        ManageWorkers manageWorkers = new ManageWorkers();
        public frmMain()
        {
            InitializeComponent();


            //chart1.Series["Data"]["PixelPointWidth"] = "30";
            //chart2.Series["Data"]["PixelPointWidth"] = "30";
            //label25.Text = dataGridView1.RowCount.ToString();
            //bunifuDatepicker1.Value = DateTime.Now;
            //bunifuDatepicker2.Value = DateTime.Now;
            cmbComplaints();
            clearAllPanels();
            openDashboard();

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

        public void cmbComplaints()
        {

            //string query = "select complaints_cat as Name from category";
            //MySqlDataAdapter data = new MySqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            //data.Fill(dt);

            DataRow dr = dt.NewRow();
         
            dt.Rows.InsertAt(dr, 0);
            //comboBox1.ValueMember = "id";
            //comboBox1.DisplayMember = "Name";
            //comboBox1.DataSource = dt;
        }


        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            //panel8.Visible = false;
            //panelArhive.Visible = false;
            //panel1.Visible = false;
            viewRoomsStatusLine.Visible = false;
            picPatientList.Visible = false;
            pictureBox6.Visible = true;
            load();
            manageResidentsLine.Visible = false;
            dashboardLine.Visible = false;
            //panel7.Visible = false;
            manageWorkersLine.Visible = false;


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
            loadchart1();
        }
        public void loadchart1()
        {
            //String Conn1 = "server = localhost; database = nuclinic; username = root; password = ; Convert Zero Datetime=True";
            //String query1 = "select * from category";
            //MySqlConnection myConn1 = new MySqlConnection(Conn1);
            //MySqlCommand cmdDatabase1 = new MySqlCommand(query1, myConn1);
            //MySqlDataReader myReader;

            //try
            //{
            //    myConn1.Open();
            //    myReader = cmdDatabase1.ExecuteReader();
                //while (myReader.Read())
                //{
                    //this.chart1.Series["Data"].Points.AddXY("xxxxx", "yyyy");

            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
        }

        public void loadArhive()
        {
            //if (comboBox1.Text == "" && txtSearch.Text == "")
            //{
            startArchive();
            //}
            //else
            //{


            //    //MySqlConnection con = new MySqlConnection("server = localhost; database = nuclinic; username = root; password = ; Convert Zero Datetime=True");
            //    //MySqlCommand command = new MySqlCommand("SELECT dctd.date, patient.studentid,dctd.id,patient.firstname,patient.lastname,dctd.doctor,dctd.treatment,dctd.complaints,dctd.category from patient INNER JOIN dctd ON patient.id=dctd.id  Where (date BETWEEN @date AND @date2) && (category = @category || category = @category2) ", con);
            //    //command.Parameters.AddWithValue("@date", dateTimePicker1.Value.Date);
            //    //command.Parameters.AddWithValue("@date2", dateTimePicker2.Value.Date);
            //    //command.Parameters.AddWithValue("@category", txtSearch.Text);
            //    //command.Parameters.AddWithValue("@category2", comboBox1.Text);

            //    ////MySqlCommand command = new MySqlCommand("SELECT patient.lastname,patient.studentid,dctd.id,dctd.complaints,dctd.date from patient INNER JOIN dctd ON patient.id=dctd.id", con);
            //    //MySqlDataAdapter da = new MySqlDataAdapter(command);
            //    DataTable dt = new DataTable();
            //    //da.Fill(dt);
            //    dataGridView1.DataSource = dt;
            //    label25.Text = dataGridView1.RowCount.ToString();
            //    label29.Visible = true;
            //    label29.Text = "Showing: "+ dataGridView1.RowCount.ToString()+ " results";
            //}

        }
        public void startArchive()
        {
           
                //MySqlConnection con = new MySqlConnection("server = localhost; database = nuclinic; username = root; password = ; Convert Zero Datetime=True");
                //MySqlCommand command = new MySqlCommand("SELECT dctd.date, patient.studentid,dctd.id,patient.firstname,patient.lastname,dctd.doctor,dctd.treatment,dctd.complaints,dctd.category from patient INNER JOIN dctd ON patient.id=dctd.id  Where date BETWEEN @date AND @date2", con);
                //command.Parameters.AddWithValue("@date", dateTimePicker1.Value.Date);
                //command.Parameters.AddWithValue("@date2", dateTimePicker2.Value.Date);


                ////MySqlCommand command = new MySqlCommand("SELECT patient.lastname,patient.studentid,dctd.id,dctd.complaints,dctd.date from patient INNER JOIN dctd ON patient.id=dctd.id", con);
                //MySqlDataAdapter da = new MySqlDataAdapter(command);
                //DataTable dt = new DataTable();
                //da.Fill(dt);
            //    dataGridView1.DataSource = dt;
            //label25.Text = dataGridView1.RowCount.ToString();
            //label29.Visible = true;
            //label29.Text = "Showing: " + dataGridView1.RowCount.ToString() + " results";
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //if (dataGridView1.Columns[e.ColumnIndex].Name == "Delete")
            //{




            //    int id = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["id"].Value.ToString());
            //    //MySqlDataAdapter ada = new MySqlDataAdapter("select id as 'id',studentid as 'Student ID',firstname as'Firstname',lastname as 'Lastname',telno as 'Contact No',age as 'Age',sex as 'Gender',course as'Course' from patient where id= '" + id + "'", con);

            //    dataGridView1.CurrentCell = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex];
            //    dataGridView1.Rows[e.RowIndex].Selected = true;
            //    dataGridView1.Focus();
            //    DataTable dt = new DataTable();
            //    //ada.Fill(dt);
            //    dataGridView1.DataSource = dt;

            //    foreach (DataRow dr in dt.Rows)
            //    {
            //        textBox1.Text = dr["id"].ToString();

            //    }

                if (MessageBox.Show("Are you sure you want to delete this?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {


                    try
                    {

                        //MySqlCommand cmd = new MySqlCommand();
                        //cmd.Connection = con;
                        //cmd.CommandText = "delete from patient where id = '" + textBox1.Text + "'";


                        //con.Open();
                        //cmd.ExecuteNonQuery();
                        MessageBox.Show("Item Deleted");
                        loadArhive();
                        //con.Close();
                   
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                else
                {
                    loadArhive();
                }
            
            //else if (dataGridView1.Columns[e.ColumnIndex].Name == "View")
            //{
            //    if (dataGridView1.Columns[e.ColumnIndex].Name == "View")
            //    {

            //        int id = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["id"].Value.ToString());
            //        //MySqlDataAdapter ada = new MySqlDataAdapter("select id as 'id',studentid as 'Student ID',firstname as'Firstname',lastname as 'Lastname',telno as 'Contact No',age as 'Age',sex as 'Gender',course as'Course' from patient where id= '" + id + "'", con);

            //        dataGridView1.CurrentCell = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex];
            //        dataGridView1.Rows[e.RowIndex].Selected = true;




            //        DataTable dt = new DataTable();
            //        //ada.Fill(dt);
            //        dataGridView1.DataSource = dt;

            //        foreach (DataRow dr in dt.Rows)
            //        {
            //            frmViewPatient frm = new frmViewPatient();

            //            //frm.label2.Text = dr["id"].ToString();
            //            frm.ID = dt.Rows[0]["id"].ToString();
            //            frm.Firstname = dt.Rows[0]["Firstname"].ToString();
            //            frm.Lastname = dt.Rows[0]["Lastname"].ToString();
            //            // frm.Middlename = dt.Rows[0]["middlename"].ToString();
            //            frm.Studentid = dt.Rows[0]["Student ID"].ToString();
            //            //frm.Birthday = dt.Rows[0]["Birthday"].ToString();
            //            frm.Course = dt.Rows[0]["Course"].ToString();
            //            frm.ShowDialog();

            //        }
            //    }
            //    else
            //    {
            //        loadArhive();
            //    }



            //}
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

            try
            {

                //MySqlCommand cmd = con.CreateCommand();
                //MySqlCommand cmd2 = con.CreateCommand();
                //MySqlCommand cmd3 = con.CreateCommand();
                //MySqlCommand cmd4 = con.CreateCommand();
                //MySqlCommand cmd5 = con.CreateCommand();
                //cmd.CommandText = "Select count(*) as myCount from patient";
                //cmd2.CommandText = "Select count(*) as myCount from user";
                //cmd3.CommandText = "Select count(*) as myCount from dctd";
                //cmd4.CommandText = "SELECT count(*) FROM dctd WHERE date = CURDATE()";
                //cmd5.CommandText = "SELECT count(*) FROM dctd WHERE MONTH (date) = MONTH(CURRENT_DATE())";

                //con.Open();
                //long count = (long)cmd.ExecuteScalar();
                //long doc = (long)cmd2.ExecuteScalar();
                //long dctd = (long)cmd3.ExecuteScalar();
                //long today = (long)cmd4.ExecuteScalar();
                //long monthly = (long)cmd5.ExecuteScalar();

                //label9.Text = count.ToString();
                //lblDoctors.Text = doc.ToString();
                //lblDiagnosis.Text = dctd.ToString();
                //lbltoday.Text = today.ToString();
                //thismonth.Text = monthly.ToString();
                //con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                //con.Close();
            }
        }


        private void clearAllPanels()
        {

            try { this.panel1.Controls.Remove(dashboard); } catch (Exception e) { }
            try { this.panel1.Controls.Remove(roomsStatus); } catch (Exception e) { }
            try { this.panel1.Controls.Remove(manageResidents); } catch (Exception e) { }
            try { this.panel1.Controls.Remove(manageWorkers); } catch (Exception e) { }


            try { dashboard.Close(); } catch (Exception e) { }
            try { roomsStatus.Close(); } catch (Exception e) { }
            try { manageResidents.Close(); } catch (Exception e) { }
            try { manageWorkers.Close(); } catch (Exception e) { }
        }

        private void openDashboard()
        {
            //set the correct line
            manageWorkersLine.Visible = false;
            manageResidentsLine.Visible = false;
            dashboardLine.Visible = true;
            viewRoomsStatusLine.Visible = false;

            dashboard = new Dashboard();
            dashboard.TopLevel = false;
            dashboard.AutoScroll = true;
            dashboard.TopMost = true;
            dashboard.Dock = DockStyle.Fill;
            dashboard.ControlBox = false;
            dashboard.Text = String.Empty;

            this.panel1.Controls.Add(dashboard);
            dashboard.Show();
        }

        private void openRoomsStatus()
        {
            //set the correct line
            manageWorkersLine.Visible = false;
            manageResidentsLine.Visible = false;
            dashboardLine.Visible = false;
            viewRoomsStatusLine.Visible = true;

            roomsStatus = new RoomsStatus();
            roomsStatus.TopLevel = false;
            roomsStatus.AutoScroll = true;
            roomsStatus.TopMost = true;
            roomsStatus.Dock = DockStyle.Fill;
            roomsStatus.ControlBox = false;
            roomsStatus.Text = String.Empty;

            this.panel1.Controls.Add(roomsStatus);
            roomsStatus.Show();
        }

        private void openManageResidents()
        {
            //set the correct line
            manageWorkersLine.Visible = false;
            manageResidentsLine.Visible = true;
            dashboardLine.Visible = false;
            viewRoomsStatusLine.Visible = false;

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

        private void openManageWorkers()
        {
            //set the correct line
            manageWorkersLine.Visible = true;
            manageResidentsLine.Visible = false;
            dashboardLine.Visible = false;
            viewRoomsStatusLine.Visible = false;

            manageWorkers = new ManageWorkers();
            manageWorkers.TopLevel = false;
            manageWorkers.AutoScroll = true;
            manageWorkers.TopMost = true;
            manageWorkers.Dock = DockStyle.Fill;
            manageWorkers.ControlBox = false;
            manageWorkers.Text = String.Empty;

            this.panel1.Controls.Add(manageWorkers);
            manageWorkers.Show();
        }

       

        public void Load3()
        {
            //MySqlConnection con = new MySqlConnection("server = localhost; database = nuclinic; username = root; password = ; Convert Zero Datetime=True");
            //MySqlCommand command = new MySqlCommand("SELECT dctd.date, patient.studentid,dctd.id,patient.firstname,patient.lastname,dctd.doctor,dctd.treatment,dctd.complaints,dctd.category from patient INNER JOIN dctd ON patient.id=dctd.id", con);
  

            ////MySqlCommand command = new MySqlCommand("SELECT patient.lastname,patient.studentid,dctd.id,dctd.complaints,dctd.date from patient INNER JOIN dctd ON patient.id=dctd.id", con);
            ////MySqlDataAdapter da = new MySqlDataAdapter(command);
            //DataTable dt = new DataTable();
            ////da.Fill(dt);
            //dataGridView2.DataSource = dt;

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

        private void dashboardButton_Click(object sender, EventArgs e)
        {
            clearAllPanels();
            openDashboard();

        }

        private void manageResidentsButton_Click(object sender, EventArgs e)
        {
            clearAllPanels();
            openManageResidents();
        }

        private void manageWorkersButton_Click(object sender, EventArgs e)
        {
            clearAllPanels();
            openManageWorkers();
        }

        private void viewRoomsStatus_Click(object sender, EventArgs e)
        {
            clearAllPanels();
            openRoomsStatus();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            time.Text = DateTime.Now.ToLongTimeString();
            timer1.Start();
        }
      
    }
}
