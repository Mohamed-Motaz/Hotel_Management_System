using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Frontend.Extras
{
    public partial class RoomsStatus : Form
    {
        public RoomsStatus()
        {
            int numofBusyRooms=70, numofAvailableRooms=30;
            int numofsingleroomsava=10, numofdoubleroomsava=15, numoftripleroomsava=20;
            int numofsingleroomsbusy=20, numofdoubleroomsbusy=25, numoftripleroomsbusy=30;
            int numoffullboardroomsavailable=30, numofhalfboardroomsavailable=35, numofbedandbreakfastroomsavailable=49;
            int numoffullboardroomsBusy=25, numofhalfboardroomsBusy=66, numofbedandbreakfastroomsBusy=56;

            InitializeComponent();

            chart1.Series["S1"].Points.AddXY("AvailableRooms", numofAvailableRooms);
            chart1.Series["S1"].Points.AddXY("BusyRooms", numofBusyRooms);


            chart2.Series["Available"].Points.AddXY("singleroomsavailable ", numofsingleroomsava);
            chart2.Series["Available"].Points.AddXY("doubleroomsavailable ", numofdoubleroomsava);
            chart2.Series["Available"].Points.AddXY("tripleroomsavailable ", numoftripleroomsava);


            chart2.Series["Busy"].Points.AddXY("singleroomsbusy ", numofsingleroomsbusy);
            chart2.Series["Busy"].Points.AddXY("doubleroomsbusy ", numofdoubleroomsbusy);
            chart2.Series["Busy"].Points.AddXY("tripleroomsbusy ", numoftripleroomsbusy);



            chart3.Series["Available"].Points.AddXY("fullboardroomsavailable ", numoffullboardroomsavailable);
            chart3.Series["Available"].Points.AddXY("halfboardroomsavailable ", numofhalfboardroomsavailable);
            chart3.Series["Available"].Points.AddXY("bedandbreakfastroomsavailable ", numofbedandbreakfastroomsavailable);



            chart3.Series["Busy"].Points.AddXY("fullboardroomsBusy ", numoffullboardroomsBusy);
            chart3.Series["Busy"].Points.AddXY("halfboardroomsBusy ", numofhalfboardroomsBusy);
            chart3.Series["Busy"].Points.AddXY("bedandbreakfastroomsBusy ", numofbedandbreakfastroomsBusy);

        }

        private void RoomsStatus_Load(object sender, EventArgs e)
        {

        }

        private void chart2_Click(object sender, EventArgs e)
        {

        }
    }
}
