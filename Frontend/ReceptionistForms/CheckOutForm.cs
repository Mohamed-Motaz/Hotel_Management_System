﻿using System;
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
            obj.roomId = RoomIDTextBox.Text;
            Service.Checkout(obj);
        }
    }
}
