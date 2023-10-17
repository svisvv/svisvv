using System;
using System.Collections.Generic;
using System.Text;

namespace LabRab2
{
    public class Shipping : TaxiBase, ITotalCost
    {
        public double CostPogruzRazgruz { get; set; }
        public double CostDelivery { get; set; }

        public Shipping(double costPogruzRazgruz, double costDelivery, int numCar): base(numCar)
        {
            CostPogruzRazgruz = costPogruzRazgruz;
            CostDelivery = costDelivery;
        }
        
        
          public double GetTotalCost()
          {
            double resultShipping = 0;
            resultShipping += CostPogruzRazgruz + CostDelivery;
            return resultShipping;
          }
    }

}