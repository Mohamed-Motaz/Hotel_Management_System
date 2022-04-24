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
    public partial class AddReservation : Form
    {
        public AddReservation()
        {
            InitializeComponent();
        }

        private void AddReservation_Load(object sender, EventArgs e)
        {
            dynamic AvailableRooms = Service.GetAvailableRooms();
            foreach(dynamic room in AvailableRooms)
            {
                // api returns all available rooms to display it in combo box

                RoomTypeComboBox.Items.Add(room.roomType + " " + room.boardingType);
            }
            StartDateDatepicker.Value = DateTime.Today;
            EndDateDatepicker.Value = DateTime.Today.AddDays(1);
        }
        private void Clear()
        {
            RoomTypeComboBox.SelectedItem = "";
            ResidentIDTextBox.Text = "";
            StartDateDatepicker.Value = DateTime.Today;
            EndDateDatepicker.Value = DateTime.Today.AddDays(1);
        }
        private void ClearBtn_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            dynamic Reservation = new ExpandoObject();
            Reservation.residentId = ResidentIDTextBox.Text;
            Reservation.roomType = RoomTypeComboBox.GetItemText(RoomTypeComboBox.SelectedItem);
            Reservation.startDate = Convert.ToInt64(StartDateDatepicker.Value);
            Reservation.endDate = Convert.ToInt64( EndDateDatepicker.Value );
            if ((EndDateDatepicker.Value < StartDateDatepicker.Value))
                MessageBox.Show("Please Enter a valid end date");
            else if (!CheckForResidentID(int.Parse(ResidentIDTextBox.Text)))
                MessageBox.Show("Please Enter a valid resident id");
            else
            {
                // api call takes [ResidentID, RoomType, startDate, EndDate]
                // returns[RoomID and TotalPrice] in case success reservation then add it to reservationsList
                // else return failed reservation
                Service.AddReservation(Reservation);
                MessageBox.Show("Reservation has been added successfully!");
                // MessageBox.Show();
            }
            Clear();
        }
        private bool CheckForResidentID(int ResidentID)
        {
            // api call send resident id and check if it's found return true
            dynamic obj = new ExpandoObject();
            obj.id = ResidentID;

            return Service.checkForResident(obj);
        }
    }
}
