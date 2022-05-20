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
using Frontend.ResidentForms;

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
            Reservation.residentId = ResidentInformation.residentId;
            ResidentIDTextBox.Text = ResidentInformation.residentId.ToString();
            Reservation.roomType = Reservation.boardingType = "";
            //Reservation.roomType = RoomTypeComboBox.GetItemText(RoomTypeComboBox.SelectedItem);
            string types = RoomTypeComboBox.GetItemText(RoomTypeComboBox.SelectedItem);
            string[] list = types.Split('/');
            if (list.Length == 2)
            {
                Reservation.roomType = list[0];
                Reservation.boardingType = list[1];
            }
            DateTime dt = Convert.ToDateTime(StartDateDatepicker.Value);
            Reservation.startDate = TimeHandler.GetDateInEpoch(dt.Day, dt.Month, dt.Year);

            dt = Convert.ToDateTime(EndDateDatepicker.Value);
            Reservation.endDate = TimeHandler.GetDateInEpoch(dt.Day, dt.Month, dt.Year);

            if ((EndDateDatepicker.Value < StartDateDatepicker.Value))
                MessageBox.Show("Please Enter a valid end date");
            else if (string.IsNullOrEmpty(RoomTypeComboBox.Text))
                MessageBox.Show("Please choose a valid Room Type.");
            else
            {
                // api call takes [ResidentID, RoomType, startDate, EndDate]
                // returns[RoomID and TotalPrice] in case success reservation then add it to reservationsList
                // else return failed reservation
                
                dynamic resp = Service.AddReservation(Reservation);
                if (resp.success == true)
                { 
                    this.Hide();
                    MessageBox.Show("Reservation has been added successfully!");
                   
                }
                else
                {
                    MessageBox.Show("Cannot add this reservation");
                }
                Clear();
            }
        }
        private bool CheckForResidentID(string ResidentID)
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
            obj.startDate = TimeHandler.GetDateInEpoch(dt.Day, dt.Month, dt.Year);

            dt = Convert.ToDateTime(EndDateDatepicker.Value);
            obj.endDate = TimeHandler.GetDateInEpoch(dt.Day, dt.Month, dt.Year);

            dynamic AvailableRooms = Service.GetAvailableRooms(obj);
            foreach (dynamic room in AvailableRooms)
            {
                // api returns all available rooms to display it in combo box

                RoomTypeComboBox.Items.Add(room.roomType + "/" + room.boardingType);
            }
        }

        private void StartDateDatepicker_onValueChanged(object sender, EventArgs e)
        {
            //showAvailableRooms(sender, e);
        }

        private void EndDateDatepicker_onValueChanged(object sender, EventArgs e)
        {
            //showAvailableRooms(sender, e);
        }
    }
}
