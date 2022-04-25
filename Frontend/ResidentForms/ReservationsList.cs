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
namespace Frontend.ResidentForms
{
    public partial class ReservationsList : Form
    {
        public ReservationsList()
        {
            InitializeComponent();
        }
      
        private void ReservationsList_Load(object sender, EventArgs e)
        {
            setUpDataGridView();
        }
        public void setUpDataGridView()
        {
            ReservationsGV.ColumnCount = 8;
            ReservationsGV.Columns[0].Name = "ID";
            ReservationsGV.Columns[1].Name = "RoomID"; 
            ReservationsGV.Columns[2].Name = "Room Type";
            ReservationsGV.Columns[3].Name = "Boarding Type"; 
            ReservationsGV.Columns[4].Name = "ResidentID";
            ReservationsGV.Columns[5].Name = "Start Date";
            ReservationsGV.Columns[6].Name = "End Date";
            ReservationsGV.Columns[7].Name = "Total price";

            dynamic obj = new ExpandoObject();
            obj.residentId = ResidentInformation.residentId; // keep track of cuurent resident id
            List<dynamic> reservations = Service.GetResidentReservations(obj);

            label1.Text = reservations.Count.ToString();

          
            foreach (dynamic res in reservations)
            {
                DataGridViewRow row = (DataGridViewRow)ReservationsGV.Rows[0].Clone();
                row.Cells[0].Value = res.id.ToString();
                row.Cells[1].Value = res.roomId.ToString();
                row.Cells[2].Value = res.roomType.ToString();
                row.Cells[3].Value = res.boardingType.ToString();
                row.Cells[4].Value = res.residentId.ToString();
                row.Cells[5].Value = TimeHandler.GetDateFromEpoch(res.startDate);
                row.Cells[6].Value = TimeHandler.GetDateFromEpoch(res.endDate);
                row.Cells[7].Value = res.totalPrice.ToString();

                ReservationsGV.Rows.Add(row);
            }

        }

        private void bunifuMetroTextbox1_OnValueChanged(object sender, EventArgs e)
        {
            int cnt = 0;
            if (this.bunifuMetroTextbox1.Text != string.Empty) // search by roomID
            {
                try
                {
                    foreach (DataGridViewRow row in ReservationsGV.Rows)
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
                foreach (DataGridViewRow row in ReservationsGV.Rows)
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
