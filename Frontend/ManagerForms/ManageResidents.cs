﻿using Frontend.ManagerForms;
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
    public partial class ManageResidents : Form
    {
        public ManageResidents()
        {
            InitializeComponent();
        }

        private void residentsListButton_Click(object sender, EventArgs e)
        {
            ResidentsList residentsList = new ResidentsList();
            residentsList.Show();
        }
    }
}
