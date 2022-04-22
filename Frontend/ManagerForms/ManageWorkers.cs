using Frontend.ManagerForms;
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
    public partial class ManageWorkers : Form
    {
        public ManageWorkers()
        {
            InitializeComponent();
        }

        private void workersListButton_Click(object sender, EventArgs e)
        {
            WorkersList workersList = new WorkersList();
            workersList.Show();
        }

        private void addWorkerButton_Click(object sender, EventArgs e)
        {
            AddWorker addWorker = new AddWorker();
            addWorker.Show();
        }

        private void editOrDeleteWorkerButton_Click(object sender, EventArgs e)
        {
            EditOrDeleteWorker editOrDeleteWorker = new EditOrDeleteWorker();
            editOrDeleteWorker.Show();
        }
    }
}
