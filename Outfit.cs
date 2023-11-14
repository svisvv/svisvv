using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabRab4
{
    public class OutfitsList : List<OutfitBase>
    {
        public IDictionary<string, decimal> GetTotalCostEachType()
        {
            return this
                .GroupBy(e => e.GetType().Name)
                .ToDictionary(g => g.Key, g => g.Sum(c => c.Cost)); 

        }
    }       
}
