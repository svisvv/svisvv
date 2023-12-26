using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabRab6
{
    interface IResistanceCalculationStrategy
    {
        double CalculateResistance(double[] resistances);
    }
}
