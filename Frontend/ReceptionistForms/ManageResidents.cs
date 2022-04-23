using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Frontend.ReceptionistForms
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

        private void addResidentButton_Click(object sender, EventArgs e)
        {
            AddResident addResident = new AddResident();
            addResident.Show();
        }

        private void editOrDeleteResidentButton_Click(object sender, EventArgs e)
        {
            EditOrDeleteResident editOrDeleteResident = new EditOrDeleteResident();
            editOrDeleteResident.Show();
        }
    }
}
