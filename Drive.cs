using System;
using System.Collections.Generic;
using System.Text;

namespace LabRab2
{
    public class Drive: TaxiBase, ITotalCost
    {
        public double CostOneHour { get; set;}
        public double QuantityHour { get; set; }

        public Drive(double costOneHour, double quantityHour, int numCar): base(numCar)
        {
            CostOneHour = costOneHour;
            QuantityHour = quantityHour;
        }
        
        
          public double GetTotalCost()
          {
             double resultDrive = 0;
             resultDrive += CostOneHour * QuantityHour;
             return resultDrive;
          }
    }
}