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
            dynamic AvailableRooms = new ExpandoObject();
            foreach (dynamic room in AvailableRooms)
            {
                // api returns all available rooms to display it in combo box
                RoomTypeComboBox.Items.Add(room);
            }
            StartDateDatepicker.Value = DateTime.Today;
            EndDateDatepicker.Value = DateTime.Today.AddDays(1);
        }

        private void EditReservationBtn_Click(object sender, EventArgs e)
        {
            dynamic Reservation = new ExpandoObject();
            Reservation.ResidentID = ResidentIDTextBox.Text;
            Reservation.RoomType = RoomTypeComboBox.GetItemText(RoomTypeComboBox.SelectedItem);
            Reservation.StartDate = StartDateDatepicker.Value;
            Reservation.EndDate = EndDateDatepicker.Value;
            if ((EndDateDatepicker.Value < StartDateDatepicker.Value))
                MessageBox.Show("Please Enter a valid end date");
            else if (!CheckForResidentID(int.Parse(ResidentIDTextBox.Text)))
                MessageBox.Show("Please Enter a valid resident id");
            else
            {
                // api takes [ ResidentID with new( RoomType, startDate, EndDate) ]
                // and delete reservation of ResidentID 
                // returns bool 1 -> success deleteReservation or 0-> fail deleteReservation
                MessageBox.Show("Reservation has been edited successfully!");
            }
            Clear();
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

        private void DeleteReservationBtn_Click(object sender, EventArgs e)
        {
            if (!CheckForResidentID(int.Parse(ResidentIDTextBox.Text)))
                MessageBox.Show("Please Enter a valid resident id");
            else
            {
                MessageBox.Show("Reservation has been deleted successfully!");
            }
            Clear();
        }
        private bool CheckForResidentID(int ResidentID)
        {
            // api call send resident id and check if it's found return true
            return false;
        }
    }
}
