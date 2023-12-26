using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabRab6
{
    class SerialResistanceCalculationStrategy: IResistanceCalculationStrategy
    {
        public double CalculateResistance(double[] resistances)
        {
            double totalResistance = 0;
            foreach (var resistance in resistances)
            {
                totalResistance += resistance;
            }
            return totalResistance;
        }
    }
}
