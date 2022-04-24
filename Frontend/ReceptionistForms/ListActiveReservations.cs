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
    public partial class ListActiveReservations : Form
    {
        public ListActiveReservations()
        {
            InitializeComponent();
        }
        public List<dynamic> GetActiveReservations()
        {
            List<dynamic> ActiveReservations = Service.GetActiveReservations() ;

            dynamic res = new ExpandoObject();
            res.id = "1";
            res.RoomId = "1";
            res.BoardId = "2";
            res.ResidentId = "3";
            res.StartDate = "23/8";
            res.EndDate = "8/9";
            res.TotalPrice = "26000";

            ActiveReservations.Add(res);

            dynamic res1 = new ExpandoObject();
            res1.id = "2";
            res1.RoomId = "5";
            res1.BoardId = "7";
            res1.ResidentId = "5";
            res1.StartDate = "7/8";
            res1.EndDate = "3/9";
            res1.TotalPrice = "2600";

            ActiveReservations.Add(res1);

            return ActiveReservations;
        }
        private void ListActiveReservations_Load(object sender, EventArgs e)
        {
            setUpDataGridView();

        }
        public void setUpDataGridView()
        {
            ActiveReservationsGV.ColumnCount = 7;
            ActiveReservationsGV.Columns[0].Name = "ID";
            ActiveReservationsGV.Columns[1].Name = "RoomID";
            ActiveReservationsGV.Columns[2].Name = "BoardID";
            ActiveReservationsGV.Columns[3].Name = "ResidentID";
            ActiveReservationsGV.Columns[4].Name = "Start Date";
            ActiveReservationsGV.Columns[5].Name = "End Date";
            ActiveReservationsGV.Columns[6].Name = "Total price";

            List<dynamic> reservations = GetActiveReservations();

            label1.Text = reservations.Count.ToString();


            foreach (dynamic res in reservations)
            {
                DataGridViewRow row = (DataGridViewRow)ActiveReservationsGV.Rows[0].Clone();
                row.Cells[0].Value = res.id;
                row.Cells[1].Value = res.RoomId;
                row.Cells[2].Value = res.BoardId;
                row.Cells[3].Value = res.ResidentId;
                row.Cells[4].Value = res.StartDate;
                row.Cells[5].Value = res.EndDate;
                row.Cells[6].Value = res.TotalPrice;

                ActiveReservationsGV.Rows.Add(row);
            }


        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void bunifuMetroTextbox1_OnValueChanged(object sender, EventArgs e)
        {
            int cnt = 0;
            if (this.bunifuMetroTextbox1.Text != string.Empty) // search by roomID
            {
                try
                {
                    foreach (DataGridViewRow row in ActiveReservationsGV.Rows)
                    {
                        if (row.Cells[1].Value != null && row.Cells[1].Value.ToString().ToLower().Contains(bunifuMetroTextbox1.Text.ToLower()))
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
                foreach (DataGridViewRow row in ActiveReservationsGV.Rows)
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
