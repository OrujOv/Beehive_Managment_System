using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beehive_Managment_System_charpter_7_
{
    class Bee
    {
        public const double HoneyUnitsConsumedPerMg = .25;

        public double WeightMg { get; private set; }

        public Bee (double weightMg)
        {
            WeightMg = weightMg;
        }

        virtual public double HoneyConsumtionRate()
        {
            return WeightMg * HoneyUnitsConsumedPerMg;
        }
    }
}
