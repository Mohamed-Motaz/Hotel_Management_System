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
        public static long GetDateInEpoch(int day, int month, int year)
        {
            return (long)(new DateTimeOffset(year, month, day, 0, 0, 0, TimeSpan.Zero) - new DateTimeOffset(1970, 1, 1, 0, 0, 0, TimeSpan.Zero)).TotalSeconds;
        }
        private void SaveButton_Click(object sender, EventArgs e)
        {
            dynamic Reservation = new ExpandoObject();
            Reservation.residentId = ResidentIDTextBox.Text;
            Reservation.roomType = RoomTypeComboBox.GetItemText(RoomTypeComboBox.SelectedItem);
            
            DateTime dt = Convert.ToDateTime(StartDateDatepicker.Value);
            Reservation.startDate = GetDateInEpoch(dt.Day, dt.Month, dt.Year);

            dt = Convert.ToDateTime(EndDateDatepicker.Value);
            Reservation.endDate = GetDateInEpoch(dt.Day, dt.Month, dt.Year);

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

        private void showAvailableRooms(object sender, EventArgs e)
        {
            dynamic obj = new ExpandoObject();

            DateTime dt = Convert.ToDateTime(StartDateDatepicker.Value);
            obj.startDate = GetDateInEpoch(dt.Day, dt.Month, dt.Year);

            dt = Convert.ToDateTime(EndDateDatepicker.Value);
            obj.endDate = GetDateInEpoch(dt.Day, dt.Month, dt.Year);

            dynamic AvailableRooms = Service.GetAvailableRooms(obj);
            foreach (dynamic room in AvailableRooms)
            {
                // api returns all available rooms to display it in combo box

                RoomTypeComboBox.Items.Add(room.roomType + " " + room.boardingType);
            }
        }

        private void StartDateDatepicker_onValueChanged(object sender, EventArgs e)
        {
            showAvailableRooms(sender, e);
        }

        private void EndDateDatepicker_onValueChanged(object sender, EventArgs e)
        {
            showAvailableRooms(sender, e);
        }
    }
}
