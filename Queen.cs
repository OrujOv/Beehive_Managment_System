using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beehive_Managment_System_charpter_7_
{
    class Queen:Bee
    {
        private Worker[] workers;
        private int shiftNumber=0;
        
        public Queen (Worker[] workers, double weightMg):base(weightMg)
        {
            this.workers = workers;
        }

        public bool AssignWork(string jobThatNeedsToBeDone, int numberOfShifts)
        {
            for (int i = 0; i < workers.Length; i++)
            {
                if (workers[i].DoThisJob(jobThatNeedsToBeDone, numberOfShifts))
                    return true;
            }
            return false;
        }
        
        public string WorkTheNextShift()
        {
            shiftNumber++;
            string stringToReturn;
            double totalConsumpation= HoneyConsumtionRate();

            stringToReturn = "Report for shift #"+shiftNumber+"\r\n";

            for (int i=0; i<workers.Length; i++)
            {
                if (workers[i].DidYouFinish())
                    stringToReturn += "Worker #"+(i+1)+" finished the job\r\n";
                if (String.IsNullOrEmpty(workers[i].CurrentJob)) stringToReturn += "Worker #" + (i + 1) + " is not working\r\n";
                    else
                    if (workers[i].ShiftsLeft>0)
                        stringToReturn += "Worker #" + (i + 1) + " is doing '"+workers[i].CurrentJob+"' for "+workers[i].ShiftsLeft+ " shifts\r\n";
                    else
                        stringToReturn += "Worker #" + (i + 1) + " wiil be done with '" + workers[i].CurrentJob + "' after this shift\r\n";
                totalConsumpation += workers[i].HoneyConsumtionRate();
            }
            stringToReturn += "Total honey consumed for the shift: " +totalConsumpation+ " for the units\r\n";
            return stringToReturn;
        }
    }
}
