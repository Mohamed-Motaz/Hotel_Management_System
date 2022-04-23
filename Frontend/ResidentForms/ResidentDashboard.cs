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
            resident = new ExpandoObject();
            bookingInfo = new ExpandoObject();
            room = new ExpandoObject();
            // make resident equal the resident of the passed ID
            // make bookingInfo equal the bookingInfo of the passed resident ID
            // make room equal the room that has roomId in the bookingInfo
            roomType.Text = room.Type;
            totalCost.Text = bookingInfo.totalCost;
            numberOfNights.Text = bookingInfo.numberOfNights;
            startDate.Text = bookingInfo.startDate;
            boardingType.Text = bookingInfo.boardingType;

        }



        private void label18_Click(object sender, EventArgs e){}
    }
}
