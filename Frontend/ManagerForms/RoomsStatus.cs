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

namespace Frontend.Extras
{
    public partial class RoomsStatus : Form
    {
        int numofBusyRooms = 0, numofAvailableRooms = 0;
        int numofsingleroomsava = 0, numofdoubleroomsava = 0, numoftripleroomsava = 0;
        int numofsingleroomsbusy = 0, numofdoubleroomsbusy = 0, numoftripleroomsbusy = 0;
        int numoffullboardroomsBusy = 0, numofhalfboardroomsBusy = 0, numofbedandbreakfastroomsBusy = 0;


        public RoomsStatus()
        {
            
            InitializeComponent();

            

        }

        private void RoomsStatus_Load(object sender, EventArgs e)
        {
            numofBusyRooms = 0; numofAvailableRooms = 0;

            numofsingleroomsava = 0; numofdoubleroomsava = 0; 
            numoftripleroomsava = 0; 
            
            numofsingleroomsbusy = 0; 
            numofdoubleroomsbusy = 0; numoftripleroomsbusy = 0;

            numoffullboardroomsBusy = 0; 
            numofhalfboardroomsBusy = 0; 
            numofbedandbreakfastroomsBusy = 0;

            List<dynamic> avaRooms = Service.GetActualAvailableRooms(new ExpandoObject());
            List<dynamic> busyRooms = Service.GetReservedRoom(new ExpandoObject());
            List<dynamic> reservations = Service.GetActiveReservations();

            for (int i = 0; i < reservations.Count ; i++)
            {
                if (reservations[i].boardingType == "Full Board")
                {
                    numoffullboardroomsBusy++;
                }else if (reservations[i].boardingType == "Half Board")
                {
                    numofhalfboardroomsBusy++;
                }else if (reservations[i].boardingType == "BedAndBreakfast Board")
                {
                    numofbedandbreakfastroomsBusy++;
                }
            }


            numofAvailableRooms = avaRooms.Count;
            numofBusyRooms = busyRooms.Count;

            for (int i = 0; i < avaRooms.Count ; i++)
            {
                if (avaRooms[i].type == "Single Room")
                {
                    numofsingleroomsava++;
                }else if (avaRooms[i].type == "Double Room")
                {
                    numofdoubleroomsava++;
                }else if (avaRooms[i].type == "Triple Room")
                {
                    numoftripleroomsava++;
                }
            }
            for (int i = 0; i < busyRooms.Count; i++)
            {
                if (busyRooms[i].type == "Single Room")
                {
                    numofsingleroomsbusy++;
                }
                else if (busyRooms[i].type == "Double Room")
                {
                    numofdoubleroomsbusy++;
                }
                else if (busyRooms[i].type == "Triple Room")
                {
                    numoftripleroomsbusy++;
                }
            }

            chart1.Series["S1"].Points.AddXY("Available Rooms", numofAvailableRooms);
            chart1.Series["S1"].Points.AddXY("Busy Rooms", numofBusyRooms);


            chart2.Series["Available"].Points.AddXY("Single Rooms", numofsingleroomsava);
            chart2.Series["Available"].Points.AddXY("Double Rooms", numofdoubleroomsava);
            chart2.Series["Available"].Points.AddXY("Triple Rooms", numoftripleroomsava);


            chart2.Series["Busy"].Points.AddXY("Single Rooms", numofsingleroomsbusy);
            chart2.Series["Busy"].Points.AddXY("Double Rooms ", numofdoubleroomsbusy);
            chart2.Series["Busy"].Points.AddXY("Triple rooms", numoftripleroomsbusy);



            //chart3.Series["Available"].Points.AddXY("Fullboard Rooms", numoffullboardroomsavailable);
            //chart3.Series["Available"].Points.AddXY("Halfboard Rooms ", numofhalfboardroomsavailable);
            //chart3.Series["Available"].Points.AddXY("Bedandbreakfast Rooms", numofbedandbreakfastroomsavailable);



            chart3.Series["Busy"].Points.AddXY("Fullboard Rooms", numoffullboardroomsBusy);
            chart3.Series["Busy"].Points.AddXY("Halfboard Rooms", numofhalfboardroomsBusy);
            chart3.Series["Busy"].Points.AddXY("Bedandbreakfast Rooms", numofbedandbreakfastroomsBusy);
        }

        private void chart2_Click(object sender, EventArgs e)
        {

        }
    }
}
