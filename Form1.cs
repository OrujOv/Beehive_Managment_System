using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Beehive_Managment_System_charpter_7_
{
    public partial class Form1 : Form
    {
        private Queen queen;

        public Form1()
        {
            InitializeComponent();

            workerBeeJob.SelectedIndex = 0; // that line sets the ComboBox to show its first item

            Worker[] workers = new Worker[4];
            workers[0] = new Worker(new string[] { "Nectar collector", "Honey manufacturing" }, 175);
            workers[1] = new Worker(new string[] { "Egg care", "Baby bee tutoring" }, 114);
            workers[2] = new Worker(new string[] { "Hive maintenance", "Sting patrol" }, 149);
            workers[3] = new Worker(new string[] { "Hive maintenance", "Sting patrol", "Nectar collector", "Honey manufacturing", "Egg care", "Baby bee tutoring" }, 155);

            queen = new Queen(workers, 275);
        }

        private void nextShiftButton_Click(object sender, EventArgs e)
        {
            Report.Text = queen.WorkTheNextShift();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!queen.AssignWork(workerBeeJob.Text, (int)shifts.Value))
                MessageBox.Show("No workers are available to do this job '" + workerBeeJob.Text + "'", "The queen bee says...");
            else MessageBox.Show("The job '" + workerBeeJob.Text + "' will be done in "+shifts.Value+ " shifts", "The queen bee says...");
        }
    }
}
