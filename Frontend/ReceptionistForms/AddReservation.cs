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
    public partial class AddReservation : Form
    {
        public AddReservation()
        {
            InitializeComponent();
        }

        private void AddReservation_Load(object sender, EventArgs e)
        {
            RoomTypeComboBox.Items.Add("Single Room");
            RoomTypeComboBox.Items.Add("Double Room");
            RoomTypeComboBox.Items.Add("Triple Room");
            StartDateDatepicker.Value = DateTime.Today;
        }
        private void clear()
        {
            RoomIDTextBox.Text = "";
            RoomTypeComboBox.SelectedItem = "";
            NumberofNightsTextBox.Text = "";
            TotalPriceTextBox.Text = "";
            ResidentIDTextBox.Text = "";
            StartDateDatepicker.Value = DateTime.Today;
        }
        private void ClearBtn_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            dynamic Reservation = new ExpandoObject();
            Reservation.ResidentID = ResidentIDTextBox.Text;
            Reservation.RoomID = RoomIDTextBox.Text;
            Reservation.TotalPrice = TotalPriceTextBox.Text;
            Reservation.RoomType = RoomTypeComboBox.GetItemText(RoomTypeComboBox.SelectedItem);
            Reservation.NumberofNights = NumberofNightsTextBox.Text;
            Reservation.StartDate = StartDateDatepicker.Value;
            clear();
        }
    }
}
