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
    public partial class EditOrDeleteReservation : Form
    {
        dynamic Reservation;
        public EditOrDeleteReservation()
        {
            InitializeComponent();
        }

        private void EditOrDeleteReservation_Load(object sender, EventArgs e)
        {
            StartDateDatepicker.Value = DateTime.Today;
            EndDateDatepicker.Value = DateTime.Today.AddDays(1);

        }
        
        private void EditReservationBtn_Click(object sender, EventArgs e)
        {
            dynamic Reservation = new ExpandoObject();
            Reservation.residentId = ResidentInformation.residentId; // the keep tracked one
            Reservation.id = Convert.ToInt32( searchbyIdTextbox.Text) ;
            if (!(RoomTypeComboBox.SelectedItem is null))
            {
                string types = RoomTypeComboBox.GetItemText(RoomTypeComboBox.SelectedItem);
                string[] list = types.Split('/');
                Reservation.roomType = list[0];
                Reservation.boardingType = list[1];
            }
            else
            {
                Reservation.roomType = "";
                Reservation.boardingType = "" ;
            }
            DateTime dt = Convert.ToDateTime(StartDateDatepicker.Value);
            Reservation.startDate = TimeHandler.GetDateInEpoch(dt.Day, dt.Month, dt.Year);

            dt = Convert.ToDateTime(EndDateDatepicker.Value);
            Reservation.endDate = TimeHandler.GetDateInEpoch(dt.Day, dt.Month, dt.Year);
            long currentDate = Convert.ToInt64(TimeHandler.GetDateInEpoch(DateTime.Now.Day, DateTime.Now.Month, DateTime.Now.Year));
            if (Reservation.startDate < currentDate)
                MessageBox.Show("Please enter a valid start date");
            else if ((EndDateDatepicker.Value < StartDateDatepicker.Value))
                MessageBox.Show("Please Enter a valid end date");
            else if (string.IsNullOrEmpty(RoomTypeComboBox.Text))
                MessageBox.Show("Please choose a valid Room Type.");
            else
            {
                dynamic response = Service.EditReservation(Reservation);
                // api takes [ ResidentID with new( RoomType, startDate, EndDate) ]
                // and delete reservation of ResidentID 
                // returns bool 1 -> success deleteReservation or 0-> fail deleteReservation
                if (response.success == true)
                {
                    this.Hide();
                    MessageBox.Show("Reservation has been edied successfully!\n " +
                        "Total Price =  " + response.totalPrice + "\n" + 
                         "Room ID = " + response.roomId  );
                }
                else
                {
                    MessageBox.Show("Room type cannot be edited");
                }
            }
            Clear();
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

        private void DeleteReservationBtn_Click(object sender, EventArgs e)
        {

            dynamic obj = new ExpandoObject();
            if (searchbyIdTextbox.Text.Length == 0)
            {
                MessageBox.Show("Please enter a valid id");
            }
            else
            {
                obj.id = searchbyIdTextbox.Text;
                dynamic response = Service.DeleteReservation(obj);
                if (response.success == true)
                {
                    this.Hide();
                    MessageBox.Show("Reservation has been deleted successfully!");
                }
                else
                {
                    MessageBox.Show("Reservation cannot be deleted!");
                }
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
        private void availableRooms_Click(object sender, EventArgs e)
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
            //availableRooms_Click( sender,  e);
        }

        private void EndDateDatepicker_onValueChanged(object sender, EventArgs e)
        {
           // availableRooms_Click(sender, e);
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            dynamic reservation = new ExpandoObject();
            if (searchbyIdTextbox.Text.Length == 0)
            {
                MessageBox.Show("Please enter a valid id");
            }
            else
            {
                reservation.id = searchbyIdTextbox.Text;

                // call api for get Booking info by booking id
                dynamic res = Service.GetReservation(reservation);

                StartDateDatepicker.Value = Convert.ToDateTime(TimeHandler.GetDateFromEpoch(res.booking.startDate));
                EndDateDatepicker.Value = Convert.ToDateTime(TimeHandler.GetDateFromEpoch(res.booking.endDate));
                RoomTypeComboBox.Text = Convert.ToString(res.booking.roomType) + "/" + Convert.ToString(res.booking.boardingType);
            }
        }
    }
}
