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
namespace Frontend.ManagerForms
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
            ResidentsListGridView.ColumnCount = 7;
            ResidentsListGridView.Columns[0].Name = "ID";
            ResidentsListGridView.Columns[1].Name = "Name";
            ResidentsListGridView.Columns[2].Name = "Age";
            ResidentsListGridView.Columns[3].Name = "PhoneNumber";
            ResidentsListGridView.Columns[4].Name = "Email";
           // dataGridView1.Columns[5].Name = "Password";
           
            List<dynamic> residents = Service.GetAllResidents();
            
            CntLabel.Text = residents.Count.ToString();

            foreach (dynamic res in residents)
            {
                DataGridViewRow row = (DataGridViewRow)ResidentsListGridView.Rows[0].Clone();
                row.Cells[0].Value = res.id.ToString();
                row.Cells[1].Value = res.userName.ToString();
                row.Cells[2].Value = res.age.ToString();
                row.Cells[3].Value = res.phoneNumber.ToString();
                row.Cells[4].Value = res.email.ToString();
             //   row.Cells[5].Value = res.password.ToString();

                ResidentsListGridView.Rows.Add(row);
            }
        }

        private void SearchTextbox_OnValueChanged(object sender, EventArgs e)
        {
            int cnt = 0;
            if (this.SearchTextbox.Text != string.Empty)
            {
                try
                {
                    foreach (DataGridViewRow row in ResidentsListGridView.Rows)
                    {
                        if (row.Cells[3].Value != null && row.Cells[3].Value.ToString().ToLower().Contains(SearchTextbox.Text.ToLower()))
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
                foreach (DataGridViewRow row in ResidentsListGridView.Rows)
                {
                    cnt++;
                    if (row.Visible != true)
                    {
                        row.Visible = true;
                    }
                }
                cnt--;
            }
            CntLabel.Text = cnt.ToString();
        }
    }
}
