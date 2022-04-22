using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Frontend.ManagerForms
{
    public partial class EditOrDeleteWorker : Form
    {
        public EditOrDeleteWorker()
        {
            InitializeComponent();
        }

        private void getWorkers()
        {
            //api to get all workers and their ids
        }

        private void editWorker()
        {
            //create new worker object

            //fill the object

            //call api to edit the object
        }

        private void deleteWorker()
        {
            //collect the id

            //call api to delete worker
        }



        //apis needed
        //edit worker -> input worker object, typeOfWorker manager
        //delete worker -> input workerId,    typeOfWorker
        //getWorkers -> input nothing, output all workers and their types
    }
}
