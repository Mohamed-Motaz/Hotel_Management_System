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
    public partial class ResidentsList : Form
    {
        public ResidentsList()
        {
            InitializeComponent();
        }
      

        private void ResidentsList_Load(object sender, EventArgs e)
        {
            SetupDataGridView();
           
        }

        private void SetupDataGridView()
        {
            dataGridView1.ColumnCount = 8;
            dataGridView1.Columns[2].Name = "ID";
            dataGridView1.Columns[3].Name = "Name";
            dataGridView1.Columns[4].Name = "Age";
            dataGridView1.Columns[5].Name = "PhoneNumber";
            dataGridView1.Columns[6].Name = "Email";
            dataGridView1.Columns[7].Name = "Password";
           
            List<dynamic> residents = Service.GetAllResidents();

            label1.Text = residents.Count.ToString();

            foreach (dynamic res in residents)
            {
                DataGridViewRow row = (DataGridViewRow)dataGridView1.Rows[0].Clone();
                row.Cells[2].Value = res.id.ToString() ;
                row.Cells[3].Value = res.userName.ToString();
                row.Cells[4].Value = res.age.ToString();
                row.Cells[5].Value = res.email.ToString();
                row.Cells[6].Value = res.phoneNumber.ToString();
                row.Cells[7].Value = res.password.ToString();

                dataGridView1.Rows.Add(row);
            }

            

        }

        private void bunifuMetroTextbox1_OnValueChanged(object sender, EventArgs e)
        {
            int cnt = 0;
            if (this.bunifuMetroTextbox1.Text != string.Empty)
            {
                try
                {
                    foreach (DataGridViewRow row in dataGridView1.Rows)
                    {
                        if (row.Cells[3].Value != null && row.Cells[3].Value.ToString().ToLower().Contains(bunifuMetroTextbox1.Text.ToLower()))
                        {
                            row.Visible = true;
                            cnt++;
                        }
                        else
                            row.Visible = false; 

                    }

                }
                catch (Exception)
                {
                    //do Nothing
                }
            }
            else
            {
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    cnt++;
                    if (row.Visible != true)
                    {
                        row.Visible = true;
                    }
                }
                cnt--;
            }
            label1.Text = cnt.ToString();

        }
    }
}
