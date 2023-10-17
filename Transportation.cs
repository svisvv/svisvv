using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LabRab2
{
    public class TransportationList: List<TaxiBase>
    {
        public double GetTotalCost() {
            double resultAll = 0;

             this.ForEach(e =>
           {
               ITotalCost totalCost = e as ITotalCost;
               resultAll += totalCost.GetTotalCost();
           });
            return resultAll;
        }
    }
}
