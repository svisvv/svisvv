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
                if (totalCost != null)
                {
                    resultAll += totalCost.GetTotalCost();
                }
                else Console.WriteLine("Вы ввели недопустимые значения");
            });
            return resultAll;
        }
    }
}
