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

namespace Frontend.ManagerForms
{
    public partial class ResidentsList : Form
    {
        public ResidentsList()
        {
            InitializeComponent();
        }
        public List<dynamic> GetResidentList()
        {

            List<dynamic> residents = new List<dynamic>();
            dynamic resident = new ExpandoObject();

            resident.id = "1";
            resident.age = "35";
            resident.Name = "Salma";
            resident.Email = "salma@hotmail.com";
            resident.PhoneNumber = "011111111";
            resident.password = "4444";

            residents.Add(resident);
            dynamic res = new ExpandoObject();
            res.id = "2";
            res.age = "40";
            res.Name = "Ay haga";
            res.Email = "ay haga@hotmail.com";
            res.PhoneNumber = "0111215651111";
            res.password = "6666";

            residents.Add(res);

            return residents;
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
           
            List<dynamic> residents = GetResidentList();
            
            label1.Text = residents.Count.ToString();

            foreach (dynamic res in residents)
            {
                DataGridViewRow row = (DataGridViewRow)dataGridView1.Rows[0].Clone();
                row.Cells[2].Value = res.id;
                row.Cells[3].Value = res.Name;
                row.Cells[4].Value = res.age;
                row.Cells[5].Value = res.Email;
                row.Cells[6].Value = res.PhoneNumber;
                row.Cells[7].Value = res.password;

                dataGridView1.Rows.Add(row);
            }

            

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

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
