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
    public partial class EditOrDeleteReservation : Form
    {
        dynamic Reservation;
        public EditOrDeleteReservation()
        {
            InitializeComponent();
        }

        private void EditOrDeleteReservation_Load(object sender, EventArgs e)
        {
            Reservation = new ExpandoObject();
            RoomTypeComboBox.Items.Add("Single Room");
            RoomTypeComboBox.Items.Add("Double Room");
            RoomTypeComboBox.Items.Add("Triple Room");
            StartDateDatepicker.Value = DateTime.Today;
        }

        private void EditReservationBtn_Click(object sender, EventArgs e)
        {
            // api takes all data and edit it 
            // and clear it
            Reservation.ResidentID = ResidentIDTextBox.Text;
            Reservation.RoomID = RoomIDTextBox.Text;
            Reservation.TotalPrice = TotalPriceTextBox.Text;
            Reservation.RoomType = RoomTypeComboBox.GetItemText(RoomTypeComboBox.SelectedItem);
            Reservation.NumberofNights = NumberofNightsTextBox.Text;
            Reservation.StartDate = StartDateDatepicker.Value;

            Service.EditReservation(Reservation);

            ClearBtn_Click(sender, e);
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            RoomIDTextBox.Text = "";
            RoomTypeComboBox.SelectedItem = "";
            NumberofNightsTextBox.Text = "";
            TotalPriceTextBox.Text = "";
            ResidentIDTextBox.Text = "";
            StartDateDatepicker.Value = DateTime.Today;

        }

        private void DeleteReservationBtn_Click(object sender, EventArgs e)
        {
            // api takes all data and delete it 
            Service.DeleteReservations(Reservation.ResidentID);
            // and clear it
            ClearBtn_Click(sender, e);
        }

    }
}
