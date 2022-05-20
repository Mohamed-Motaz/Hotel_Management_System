using Frontend.HttpService;
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

namespace Frontend.ResidentForms
{
    public partial class ResidentDashboard : Form
    {
        dynamic resident;
        dynamic bookingInfo;
        dynamic room;
        public ResidentDashboard()
        {
            InitializeComponent();
        }
        private void ResidentDashboard_Load(object sender, EventArgs e)
        {
            dynamic obj = new ExpandoObject();
            obj.residentId = ResidentInformation.residentId; // keep track of cuurent resident id
            List<dynamic> reservations = Service.GetResidentReservations(obj);

            if (reservations.Count - 1 < 0)
            {
                roomType.Text = "";
                totalCost.Text = "";
                numberOfNights.Text = "";
                startDate.Text = "";
                boardingType.Text = "";
                return;
            }

            dynamic res = reservations[reservations.Count - 1];
           
            try
            {
                roomType.Text = res.roomType.ToString();
                totalCost.Text = res.totalPrice.ToString();
                numberOfNights.Text = TimeHandler.GetDateFromEpoch(res.endDate);
                startDate.Text = TimeHandler.GetDateFromEpoch(res.startDate) ;
                boardingType.Text = res.boardingType.ToString();
            }
            catch(Exception ex)
            {

            }


        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        //see list of reservations
        //add reservation
        //delete reservation
    }
}
