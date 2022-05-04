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
    public partial class CheckOutForm : Form
    {
        public CheckOutForm()
        {
            InitializeComponent();
        }

        private void CheckOutBtn_Click(object sender, EventArgs e)
        {
            // send to api room id and make it avaliable
            dynamic obj = new ExpandoObject();
            if ((RoomIDTextBox.Text.Length == 0))
            {
                MessageBox.Show("Please enter a room id.");
            }
            else
            {
                obj.roomId = RoomIDTextBox.Text;
                dynamic resp = Service.Checkout(obj);
                if (resp.success = true)
                {
                    this.Hide();
                    MessageBox.Show("Checkout has been done");
                }
                else
                {
                    MessageBox.Show("Cannot finish checkout process");
                }
            }
        }
    }
}
