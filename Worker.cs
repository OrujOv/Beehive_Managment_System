using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beehive_Managment_System_charpter_7_
{
    class Worker:Bee
    {
        private string currentJob = "";
        public string CurrentJob
        {
            get
            {
                return currentJob;
            }
        }
        public int ShiftsLeft
        {
            get
            {
                return shiftsToWork - shiftsWorked;
            }
        }

        private string[] jobsICanDo;
        private int shiftsToWork;
        private int shiftsWorked;

        public Worker(string[] jobsICanDo, double weightMg) : base(weightMg)
        {
            this.jobsICanDo = jobsICanDo;
        }

        public override double HoneyConsumtionRate()
        {
            return base.HoneyConsumtionRate()+(.65*shiftsWorked);
        }

        public bool DoThisJob(string jobToDo, int shiftnumber)
        {
            if (!String.IsNullOrEmpty(currentJob)) return false;

            for (int i=0; i<jobsICanDo.Length; i++)
            {
                if (jobsICanDo[i] == jobToDo)
                {
                    currentJob = jobToDo;
                    shiftsToWork = shiftnumber;
                    shiftsWorked = 0;
                    return true;
                }
            }
            return false;
            
            //else return false;
        } 

        public bool DidYouFinish()
        {
            if (String.IsNullOrEmpty(currentJob)) return false;

            shiftsWorked ++;
            if (shiftsWorked > shiftsToWork)
            {
                shiftsWorked = 0;
                shiftsToWork = 0;
                currentJob = "";
                return true;
            }
            else return false;
        }
    }
}
