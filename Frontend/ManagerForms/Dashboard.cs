using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Frontend.Extras
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        // call for number of residents 
        public int  getNewResidentsNumber()
        {
            return 5;
        }
        public int getWeeklyIncome()
        {
            return 150;
        }

        public int getNumOfWorkers()
        {
            return 1500;
        }

        public int getMonthlyIncome()
        {
            return 8000;
        }
        public int getCurrentStayingResidents()
        {
            return 8000;
        }

        public int getYearlyIncome()
        {
            return 180000;
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            label1.Text = getNewResidentsNumber().ToString();

            label16.Text = getWeeklyIncome().ToString();

            label7.Text = getNumOfWorkers().ToString();

            label8.Text = getMonthlyIncome().ToString();

            label6.Text = getCurrentStayingResidents().ToString();

            label20.Text = getYearlyIncome().ToString();

        }
    }
}
